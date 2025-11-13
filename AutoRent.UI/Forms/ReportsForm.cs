using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoRent.Data;
using AutoRent.Services;

namespace AutoRent.UI.Forms
{
 public partial class ReportsForm : Form
 {
 private readonly AutoRentContext _context;
 private readonly ReportService _reportService;
 private readonly ImportService _importService;

 public ReportsForm(AutoRentContext context)
 {
 _context = context;
 _reportService = new ReportService(_context);
 _importService = new ImportService(_context);
 InitializeComponent();
 }

 private async void buttonExportExcel_Click(object sender, EventArgs e)
 {
 using var sfd = new SaveFileDialog { Filter = "Excel files (*.xlsx)|*.xlsx", FileName = "AutoRent_AllData.xlsx" };
 if (sfd.ShowDialog(this) != DialogResult.OK) return;
 try
 {
 await _reportService.ExportAllDataToExcelAsync(sfd.FileName);
 MessageBox.Show("Экспорт в Excel завершён");
 }
 catch (Exception ex)
 {
 MessageBox.Show("Ошибка экспорта: " + ex.Message);
 }
 }

 private async void buttonExportHtml_Click(object sender, EventArgs e)
 {
 using var sfd = new SaveFileDialog { Filter = "HTML files (*.html)|*.html", FileName = "RentalsReport.html" };
 if (sfd.ShowDialog(this) != DialogResult.OK) return;
 try
 {
 await _reportService.ExportRentalsHtmlAsync(sfd.FileName);
 MessageBox.Show("HTML-отчёт создан");
 }
 catch (Exception ex)
 {
 MessageBox.Show("Ошибка: " + ex.Message);
 }
 }

 private async void buttonGenerateWord_Click(object sender, EventArgs e)
 {
 var idText = Microsoft.VisualBasic.Interaction.InputBox("Enter RentalId:", "Generate Agreement", "1");
 if (!int.TryParse(idText, out var id)) return;
 using var sfd = new SaveFileDialog { Filter = "Word Document (*.docx)|*.docx", FileName = $"agreement_{id}.docx" };
 if (sfd.ShowDialog(this) != DialogResult.OK) return;
 try
 {
 await _reportService.GenerateRentalAgreementAsync(id, sfd.FileName);
 MessageBox.Show("Word-документ создан");
 }
 catch (Exception ex)
 {
 MessageBox.Show("Ошибка: " + ex.Message);
 }
 }

 private async void buttonImportClients_Click(object sender, EventArgs e)
 {
 using var ofd = new OpenFileDialog { Filter = "Excel files (*.xlsx)|*.xlsx", Title = "Select clients xlsx" };
 if (ofd.ShowDialog(this) != DialogResult.OK) return;
 try
 {
 var res = await _importService.ImportClientsFromExcelAsync(ofd.FileName);
 MessageBox.Show($"Clients import finished. Added={res.Added}, Skipped={res.Skipped}, Errors={res.Errors.Count}");
 }
 catch (Exception ex)
 {
 MessageBox.Show("Ошибка импорта: " + ex.Message);
 }
 }

 private async void buttonImportCars_Click(object sender, EventArgs e)
 {
 using var ofd = new OpenFileDialog { Filter = "Excel files (*.xlsx)|*.xlsx", Title = "Select cars xlsx" };
 if (ofd.ShowDialog(this) != DialogResult.OK) return;
 try
 {
 var res = await _importService.ImportCarsFromExcelAsync(ofd.FileName);
 MessageBox.Show($"Cars import finished. Added={res.Added}, Skipped={res.Skipped}, Errors={res.Errors.Count}");
 }
 catch (Exception ex)
 {
 MessageBox.Show("Ошибка импорта: " + ex.Message);
 }
 }
 }
}
