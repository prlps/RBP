using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoRent.Data;
using AutoRent.Data.Models;
using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;

namespace AutoRent.Services
{
 public class ImportResult
 {
 public int Added { get; set; }
 public int Skipped { get; set; }
 public List<string> Errors { get; } = new List<string>();
 }

 public class ImportService
 {
 private readonly AutoRentContext _context;

 public ImportService(AutoRentContext context)
 {
 _context = context ?? throw new ArgumentNullException(nameof(context));
 }

 public async Task<ImportResult> ImportClientsFromExcelAsync(string filePath)
 {
 var result = new ImportResult();
 if (!File.Exists(filePath))
 {
 result.Errors.Add("Файл не найден: " + filePath);
 return result;
 }

 using var wb = new XLWorkbook(filePath);
 var ws = wb.Worksheets.First();

 // Expect columns: LastName, FirstName, MiddleName, Address, Phone (1..5)
 var row =2;
 var toAdd = new List<Client>();
 while (true)
 {
 var last = ws.Cell(row,1).GetString().Trim();
 var first = ws.Cell(row,2).GetString().Trim();
 if (string.IsNullOrEmpty(last) && string.IsNullOrEmpty(first)) break; // assuming end

 var middle = ws.Cell(row,3).GetString().Trim();
 var address = ws.Cell(row,4).GetString().Trim();
 var phone = ws.Cell(row,5).GetString().Trim();

 if (string.IsNullOrEmpty(last) || string.IsNullOrEmpty(first))
 {
 result.Errors.Add($"Строка {row}: пустые фамилия или имя");
 row++;
 continue;
 }

 // duplicate detection: same LastName+FirstName+Phone
 var exists = await _context.Clients.AnyAsync(c => c.LastName.ToLower() == last.ToLower() && c.FirstName.ToLower() == first.ToLower() && c.Phone == phone);
 if (exists)
 {
 result.Skipped++;
 row++;
 continue;
 }

 toAdd.Add(new Client { LastName = last, FirstName = first, MiddleName = string.IsNullOrEmpty(middle) ? null : middle, Address = address, Phone = phone });
 result.Added++;
 row++;
 }

 if (toAdd.Any())
 {
 _context.Clients.AddRange(toAdd);
 await _context.SaveChangesAsync();
 }

 Logger.Info($"ImportClientsFromExcel: added={result.Added} skipped={result.Skipped} errors={result.Errors.Count}");
 return result;
 }

 public async Task<ImportResult> ImportCarsFromExcelAsync(string filePath)
 {
 var result = new ImportResult();
 if (!File.Exists(filePath))
 {
 result.Errors.Add("Файл не найден: " + filePath);
 return result;
 }

 using var wb = new XLWorkbook(filePath);
 var ws = wb.Worksheets.First();

 // Expect columns: Make, Type, PurchasePrice, RentalPricePerDay, IsAvailable
 var row =2;
 var toAdd = new List<Car>();
 while (true)
 {
 var make = ws.Cell(row,1).GetString().Trim();
 var type = ws.Cell(row,2).GetString().Trim();
 if (string.IsNullOrEmpty(make) && string.IsNullOrEmpty(type)) break;

 var purchaseStr = ws.Cell(row,3).GetString().Trim();
 var rentalStr = ws.Cell(row,4).GetString().Trim();
 var availStr = ws.Cell(row,5).GetString().Trim();

 if (string.IsNullOrEmpty(make) || string.IsNullOrEmpty(type))
 {
 result.Errors.Add($"Строка {row}: пустые Make или Type");
 row++;
 continue;
 }

 decimal purchase =0m;
 decimal rental =0m;
 bool isAvailable = true;
 if (!string.IsNullOrEmpty(purchaseStr) && !decimal.TryParse(purchaseStr, out purchase))
 {
 result.Errors.Add($"Строка {row}: неверный формат PurchasePrice");
 row++;
 continue;
 }
 if (!string.IsNullOrEmpty(rentalStr) && !decimal.TryParse(rentalStr, out rental))
 {
 result.Errors.Add($"Строка {row}: неверный формат RentalPricePerDay");
 row++;
 continue;
 }
 if (!string.IsNullOrEmpty(availStr) && !bool.TryParse(availStr, out isAvailable))
 {
 // try common variants
 var low = availStr.ToLower();
 isAvailable = low is "1" or "yes" or "y" or "true" or "да";
 }

 // duplicate detection: same Make+Type
 var exists = await _context.Cars.AnyAsync(c => c.Make.ToLower() == make.ToLower() && c.Type.ToLower() == type.ToLower());
 if (exists)
 {
 result.Skipped++;
 row++;
 continue;
 }

 toAdd.Add(new Car { Make = make, Type = type, PurchasePrice = purchase, RentalPricePerDay = rental, IsAvailable = isAvailable });
 result.Added++;
 row++;
 }

 if (toAdd.Any())
 {
 _context.Cars.AddRange(toAdd);
 await _context.SaveChangesAsync();
 }

 Logger.Info($"ImportCarsFromExcel: added={result.Added} skipped={result.Skipped} errors={result.Errors.Count}");
 return result;
 }
 }
}
