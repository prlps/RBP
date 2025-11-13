using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoRent.Data;
using AutoRent.Data.Models;
using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;
using Xceed.Words.NET;
using Xceed.Document.NET;

namespace AutoRent.Services
{
 public class ReportService
 {
 private readonly AutoRentContext _context;

 public ReportService(AutoRentContext context)
 {
 _context = context ?? throw new ArgumentNullException(nameof(context));
 }

 public async Task<string> ExportAllDataToExcelAsync(string filePath)
 {
 try
 {
 await _context.Cars.LoadAsync();
 await _context.Clients.LoadAsync();
 await _context.Rentals.Include(r => r.Car).Include(r => r.Client).LoadAsync();

 using var wb = new XLWorkbook();

 var wsCars = wb.Worksheets.Add("Cars");
 wsCars.Cell(1,1).Value = "CarId";
 wsCars.Cell(1,2).Value = "Make";
 wsCars.Cell(1,3).Value = "Type";
 wsCars.Cell(1,4).Value = "PurchasePrice";
 wsCars.Cell(1,5).Value = "RentalPricePerDay";
 wsCars.Cell(1,6).Value = "IsAvailable";

 var row =2;
 foreach (var c in _context.Cars.Local)
 {
 wsCars.Cell(row,1).Value = c.CarId;
 wsCars.Cell(row,2).Value = c.Make;
 wsCars.Cell(row,3).Value = c.Type;
 wsCars.Cell(row,4).Value = c.PurchasePrice;
 wsCars.Cell(row,5).Value = c.RentalPricePerDay;
 wsCars.Cell(row,6).Value = c.IsAvailable;
 row++;
 }

 var wsClients = wb.Worksheets.Add("Clients");
 wsClients.Cell(1,1).Value = "ClientId";
 wsClients.Cell(1,2).Value = "LastName";
 wsClients.Cell(1,3).Value = "FirstName";
 wsClients.Cell(1,4).Value = "MiddleName";
 wsClients.Cell(1,5).Value = "Address";
 wsClients.Cell(1,6).Value = "Phone";
 row =2;
 foreach (var cl in _context.Clients.Local)
 {
 wsClients.Cell(row,1).Value = cl.ClientId;
 wsClients.Cell(row,2).Value = cl.LastName;
 wsClients.Cell(row,3).Value = cl.FirstName;
 wsClients.Cell(row,4).Value = cl.MiddleName;
 wsClients.Cell(row,5).Value = cl.Address;
 wsClients.Cell(row,6).Value = cl.Phone;
 row++;
 }

 var wsRentals = wb.Worksheets.Add("Rentals");
 wsRentals.Cell(1,1).Value = "RentalId";
 wsRentals.Cell(1,2).Value = "Car";
 wsRentals.Cell(1,3).Value = "Client";
 wsRentals.Cell(1,4).Value = "DateOut";
 wsRentals.Cell(1,5).Value = "PlannedReturnDate";
 wsRentals.Cell(1,6).Value = "ActualReturnDate";
 wsRentals.Cell(1,7).Value = "PricePerDay";
 wsRentals.Cell(1,8).Value = "TotalPrice";
 wsRentals.Cell(1,9).Value = "Notes";

 row =2;
 foreach (var r in _context.Rentals.Local)
 {
 wsRentals.Cell(row,1).Value = r.RentalId;
 wsRentals.Cell(row,2).Value = r.Car?.ToString();
 wsRentals.Cell(row,3).Value = r.Client?.ToString();
 wsRentals.Cell(row,4).Value = r.DateOut;
 wsRentals.Cell(row,5).Value = r.PlannedReturnDate;
 wsRentals.Cell(row,6).Value = r.ActualReturnDate;
 wsRentals.Cell(row,7).Value = r.PricePerDay;
 wsRentals.Cell(row,8).Value = r.TotalPrice;
 wsRentals.Cell(row,9).Value = r.Notes;
 row++;
 }

 wb.SaveAs(filePath);
 Logger.Info($"Exported Excel to {filePath}");
 return filePath;
 }
 catch (Exception ex)
 {
 Logger.Error("ExportAllDataToExcelAsync error: " + ex);
 throw;
 }
 }

 public async Task<string> ExportRentalsHtmlAsync(string filePath)
 {
 try
 {
 await _context.Rentals.Include(r => r.Client).Include(r => r.Car).LoadAsync();

 var sb = new StringBuilder();
 sb.AppendLine("<html><head><meta charset=\"utf-8\"><title>Rentals Report</title>");
 sb.AppendLine("<style>table{border-collapse:collapse;width:100%;}th,td{border:1px solid #ccc;padding:8px;text-align:left;}th{background:#f0f0f0;}</style>");
 sb.AppendLine("</head><body>");
 sb.AppendLine($"<h1>Rentals report generated {DateTime.Now:O}</h1>");

 // Group by client
 var groups = _context.Rentals.Local.GroupBy(r => r.Client?.ToString() ?? "Unknown");
 foreach (var g in groups)
 {
 sb.AppendLine($"<h2>Client: {System.Net.WebUtility.HtmlEncode(g.Key)}</h2>");
 sb.AppendLine("<table><tr><th>RentalId</th><th>Car</th><th>DateOut</th><th>PlannedReturn</th><th>ActualReturn</th><th>PricePerDay</th><th>Total</th></tr>");
 foreach (var r in g)
 {
 sb.AppendLine("<tr>");
 sb.AppendLine($"<td>{r.RentalId}</td>");
 sb.AppendLine($"<td>{System.Net.WebUtility.HtmlEncode(r.Car?.ToString() ?? "")}</td>");
 sb.AppendLine($"<td>{r.DateOut:d}</td>");
 sb.AppendLine($"<td>{r.PlannedReturnDate:d}</td>");
 sb.AppendLine($"<td>{(r.ActualReturnDate?.ToString("d") ?? "")}</td>");
 sb.AppendLine($"<td>{r.PricePerDay}</td>");
 sb.AppendLine($"<td>{r.TotalPrice}</td>");
 sb.AppendLine("</tr>");
 }
 sb.AppendLine("</table>");
 }

 sb.AppendLine("</body></html>");

 File.WriteAllText(filePath, sb.ToString(), Encoding.UTF8);
 Logger.Info($"Exported HTML to {filePath}");
 return filePath;
 }
 catch (Exception ex)
 {
 Logger.Error("ExportRentalsHtmlAsync error: " + ex);
 throw;
 }
 }

 public async Task<string> GenerateRentalAgreementAsync(int rentalId, string filePath)
 {
 try
 {
 var rental = await _context.Rentals.Include(r => r.Car).Include(r => r.Client).FirstOrDefaultAsync(r => r.RentalId == rentalId);
 if (rental == null) throw new InvalidOperationException("Rental not found");

 using var doc = DocX.Create(filePath);
 doc.InsertParagraph("Договор аренды автомобиля").FontSize(16).Bold().Alignment = Alignment.center;
 doc.InsertParagraph();

 var clientName = rental.Client?.ToString() ?? "";
 var car = rental.Car?.ToString() ?? "";
 var p = doc.InsertParagraph();
 p.AppendLine($"Клиент: {clientName}");
 p.AppendLine($"Автомобиль: {car}");
 p.AppendLine($"Дата выдачи: {rental.DateOut:d}");
 p.AppendLine($"Планируемая дата возврата: {rental.PlannedReturnDate:d}");
 p.AppendLine($"Цена в день: {rental.PricePerDay}");
 p.AppendLine();

 // simple table with details
 var t = doc.AddTable(2,4);
 t.Design = TableDesign.LightListAccent1;
 t.Rows[0].Cells[0].Paragraphs[0].Append("Параметр").Bold();
 t.Rows[0].Cells[1].Paragraphs[0].Append("Значение").Bold();
 t.Rows[0].Cells[2].Paragraphs[0].Append("").Bold();
 t.Rows[0].Cells[3].Paragraphs[0].Append("").Bold();
 t.Rows[1].Cells[0].Paragraphs[0].Append("Примечания");
 t.Rows[1].Cells[1].Paragraphs[0].Append(rental.Notes ?? "");
 doc.InsertTable(t);

 doc.Save();
 Logger.Info($"Generated Word agreement {filePath}");
 return filePath;
 }
 catch (Exception ex)
 {
 Logger.Error("GenerateRentalAgreementAsync error: " + ex);
 throw;
 }
 }
 }
}
