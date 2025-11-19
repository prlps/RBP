using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using AutoRent.Data;
using AutoRent.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoRent.Services
{
 public class JsonService
 {
 private readonly AutoRentContext _context;
 private readonly JsonSerializerOptions _options = new JsonSerializerOptions
 {
 WriteIndented = true,
 PropertyNamingPolicy = JsonNamingPolicy.CamelCase
 };

 public JsonService(AutoRentContext context)
 {
 _context = context ?? throw new ArgumentNullException(nameof(context));
 }

 public async Task ExportCarsToJsonAsync(string filePath)
 {
 await _context.Cars.LoadAsync();
 var list = await _context.Cars.AsNoTracking().ToListAsync();
 var json = JsonSerializer.Serialize(list, _options);
 await File.WriteAllTextAsync(filePath, json);
 Logger.Info($"Exported Cars JSON to {filePath}");
 }

 public async Task ExportClientsToJsonAsync(string filePath)
 {
 await _context.Clients.LoadAsync();
 var list = await _context.Clients.AsNoTracking().ToListAsync();
 var json = JsonSerializer.Serialize(list, _options);
 await File.WriteAllTextAsync(filePath, json);
 Logger.Info($"Exported Clients JSON to {filePath}");
 }

 public async Task<ImportResult> ImportCarsFromJsonAsync(string filePath)
 {
 var result = new ImportResult();
 if (!File.Exists(filePath))
 {
 result.Errors.Add("File not found: " + filePath);
 return result;
 }

 try
 {
 var text = await File.ReadAllTextAsync(filePath);
 var list = JsonSerializer.Deserialize<List<Car>>(text, _options);
 if (list == null) return result;

 foreach (var c in list)
 {
 if (string.IsNullOrWhiteSpace(c.Make) || string.IsNullOrWhiteSpace(c.Type))
 {
 result.Errors.Add("Invalid car entry (Make/Type required)");
 continue;
 }

 var exists = await _context.Cars.AnyAsync(x => x.Make.ToLower() == c.Make.ToLower() && x.Type.ToLower() == c.Type.ToLower());
 if (exists)
 {
 result.Skipped++;
 continue;
 }

 // ensure defaults
 c.IsAvailable = c.IsAvailable;
 _context.Cars.Add(c);
 result.Added++;
 }

 if (result.Added >0) await _context.SaveChangesAsync();
 Logger.Info($"ImportCarsFromJson: added={result.Added} skipped={result.Skipped} errors={result.Errors.Count}");
 return result;
 }
 catch (Exception ex)
 {
 result.Errors.Add(ex.Message);
 Logger.Error("ImportCarsFromJsonAsync error: " + ex);
 return result;
 }
 }

 public async Task<ImportResult> ImportClientsFromJsonAsync(string filePath)
 {
 var result = new ImportResult();
 if (!File.Exists(filePath))
 {
 result.Errors.Add("File not found: " + filePath);
 return result;
 }

 try
 {
 var text = await File.ReadAllTextAsync(filePath);
 var list = JsonSerializer.Deserialize<List<Client>>(text, _options);
 if (list == null) return result;

 foreach (var c in list)
 {
 if (string.IsNullOrWhiteSpace(c.LastName) || string.IsNullOrWhiteSpace(c.FirstName))
 {
 result.Errors.Add("Invalid client entry (LastName/FirstName required)");
 continue;
 }

 var exists = await _context.Clients.AnyAsync(x => x.LastName.ToLower() == c.LastName.ToLower() && x.FirstName.ToLower() == c.FirstName.ToLower() && x.Phone == c.Phone);
 if (exists)
 {
 result.Skipped++;
 continue;
 }

 _context.Clients.Add(c);
 result.Added++;
 }

 if (result.Added >0) await _context.SaveChangesAsync();
 Logger.Info($"ImportClientsFromJson: added={result.Added} skipped={result.Skipped} errors={result.Errors.Count}");
 return result;
 }
 catch (Exception ex)
 {
 result.Errors.Add(ex.Message);
 Logger.Error("ImportClientsFromJsonAsync error: " + ex);
 return result;
 }
 }
 }
}
