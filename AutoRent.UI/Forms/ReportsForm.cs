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
 private readonly JsonService _jsonService;

 public ReportsForm(AutoRentContext context)
 {
 _context = context;
 _reportService = new ReportService(_context);
 _importService = new ImportService(_context);
 _jsonService = new JsonService(_context);
 InitializeComponent();
 }

 private async Task RunWithProgressAsync(Func<Task> action, string startStatus = "Выполнение...", string doneStatus = "Готово")
 {
 try
 {
 labelStatus.Text = startStatus;
 progressBar.Style = ProgressBarStyle.Marquee;
 ToggleButtons(false);
 await action();
 labelStatus.Text = doneStatus;
 }
 catch (Exception ex)
 {
 labelStatus.Text = "Ошибка";
 MessageBox.Show("Ошибка: " + ex.Message);
 Logger.Error("ReportsForm.RunWithProgressAsync: " + ex);
 }
 finally
 {
 progressBar.Style = ProgressBarStyle.Blocks;
 ToggleButtons(true);
 }
 }

 private void ToggleButtons(bool enabled)
 {
 buttonExportExcel.Enabled = enabled;
 buttonExportHtml.Enabled = enabled;
 buttonGenerateWord.Enabled = enabled;
 buttonImportClients.Enabled = enabled;
 buttonImportCars.Enabled = enabled;
 }

 private async void buttonExportExcel_Click(object sender, EventArgs e)
 {
 using var sfd = new SaveFileDialog { Filter = "Excel files (*.xlsx)|*.xlsx", FileName = "AutoRent_AllData.xlsx" };
 if (sfd.ShowDialog(this) != DialogResult.OK) return;
 await RunWithProgressAsync(async () =>
 {
 await _reportService.ExportAllDataToExcelAsync(sfd.FileName);
 MessageBox.Show("Экспорт в Excel завершён");
 });
 }

 private async void buttonExportHtml_Click(object sender, EventArgs e)
 {
 using var sfd = new SaveFileDialog { Filter = "HTML files (*.html)|*.html", FileName = "RentalsReport.html" };
 if (sfd.ShowDialog(this) != DialogResult.OK) return;
 await RunWithProgressAsync(async () =>
 {
 await _reportService.ExportRentalsHtmlAsync(sfd.FileName);
 MessageBox.Show("HTML-отчёт создан");
 });
 }

 private async void buttonGenerateWord_Click(object sender, EventArgs e)
 {
 var idText = Microsoft.VisualBasic.Interaction.InputBox("Enter RentalId:", "Generate Agreement", "1");
 if (!int.TryParse(idText, out var id)) return;
 using var sfd = new SaveFileDialog { Filter = "Word Document (*.docx)|*.docx", FileName = $"agreement_{id}.docx" };
 if (sfd.ShowDialog(this) != DialogResult.OK) return;
 await RunWithProgressAsync(async () =>
 {
 await _reportService.GenerateRentalAgreementAsync(id, sfd.FileName);
 MessageBox.Show("Word-документ создан");
 });
 }

 private async void buttonImportClients_Click(object sender, EventArgs e)
 {
 using var ofd = new OpenFileDialog { Filter = "Excel files (*.xlsx)|*.xlsx", Title = "Select clients xlsx" };
 if (ofd.ShowDialog(this) != DialogResult.OK) return;
 await RunWithProgressAsync(async () =>
 {
 var res = await _importService.ImportClientsFromExcelAsync(ofd.FileName);
 MessageBox.Show($"Clients import finished. Added={res.Added}, Skipped={res.Skipped}, Errors={res.Errors.Count}");
 // refresh UI content if needed
 });
 }

 private async void buttonImportCars_Click(object sender, EventArgs e)
 {
 using var ofd = new OpenFileDialog { Filter = "Excel files (*.xlsx)|*.xlsx", Title = "Select cars xlsx" };
 if (ofd.ShowDialog(this) != DialogResult.OK) return;
 await RunWithProgressAsync(async () =>
 {
 var res = await _importService.ImportCarsFromExcelAsync(ofd.FileName);
 MessageBox.Show($"Cars import finished. Added={res.Added}, Skipped={res.Skipped}, Errors={res.Errors.Count}");
 });
 }

 private async void buttonExportCarsJson_Click(object sender, EventArgs e)
 {
 using var sfd = new SaveFileDialog { Filter = "JSON files (*.json)|*.json", FileName = "Cars.json" };
 if (sfd.ShowDialog(this) != DialogResult.OK) return;
 await RunWithProgressAsync(async () =>
 {
 await _jsonService.ExportCarsToJsonAsync(sfd.FileName);
 MessageBox.Show("Cars exported to JSON");
 });
 }

 private async void buttonExportClientsJson_Click(object sender, EventArgs e)
 {
 using var sfd = new SaveFileDialog { Filter = "JSON files (*.json)|*.json", FileName = "Clients.json" };
 if (sfd.ShowDialog(this) != DialogResult.OK) return;
 await RunWithProgressAsync(async () =>
 {
 await _jsonService.ExportClientsToJsonAsync(sfd.FileName);
 MessageBox.Show("Clients exported to JSON");
 });
 }

 private async void buttonImportCarsJson_Click(object sender, EventArgs e)
 {
 using var ofd = new OpenFileDialog { Filter = "JSON files (*.json)|*.json", Title = "Select cars json" };
 if (ofd.ShowDialog(this) != DialogResult.OK) return;
 await RunWithProgressAsync(async () =>
 {
 var res = await _jsonService.ImportCarsFromJsonAsync(ofd.FileName);
 MessageBox.Show($"Cars JSON import finished. Added={res.Added}, Skipped={res.Skipped}, Errors={res.Errors.Count}");
 });
 }

 private async void buttonImportClientsJson_Click(object sender, EventArgs e)
 {
 using var ofd = new OpenFileDialog { Filter = "JSON files (*.json)|*.json", Title = "Select clients json" };
 if (ofd.ShowDialog(this) != DialogResult.OK) return;
 await RunWithProgressAsync(async () =>
 {
 var res = await _jsonService.ImportClientsFromJsonAsync(ofd.FileName);
 MessageBox.Show($"Clients JSON import finished. Added={res.Added}, Skipped={res.Skipped}, Errors={res.Errors.Count}");
 });
 }
 }
}
