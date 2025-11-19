namespace AutoRent.UI.Forms
{
 partial class ReportsForm
 {
 private System.ComponentModel.IContainer components = null;
 protected override void Dispose(bool disposing)
 {
 if (disposing && (components != null))
 {
 components.Dispose();
 }
 base.Dispose(disposing);
 }
 
 #region Windows Form Designer generated code
 private void InitializeComponent()
 {
 this.components = new System.ComponentModel.Container();
 this.buttonExportExcel = new System.Windows.Forms.Button();
 this.buttonExportHtml = new System.Windows.Forms.Button();
 this.buttonGenerateWord = new System.Windows.Forms.Button();
 this.buttonImportClients = new System.Windows.Forms.Button();
 this.buttonImportCars = new System.Windows.Forms.Button();
 this.buttonExportCarsJson = new System.Windows.Forms.Button();
 this.buttonExportClientsJson = new System.Windows.Forms.Button();
 this.buttonImportCarsJson = new System.Windows.Forms.Button();
 this.buttonImportClientsJson = new System.Windows.Forms.Button();
 this.progressBar = new System.Windows.Forms.ProgressBar();
 this.labelStatus = new System.Windows.Forms.Label();
 this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
 this.toolTip = new System.Windows.Forms.ToolTip(this.components);
 this.SuspendLayout();
 // 
 // buttonExportExcel
 // 
 this.buttonExportExcel.Location = new System.Drawing.Point(12,12);
 this.buttonExportExcel.Name = "buttonExportExcel";
 this.buttonExportExcel.Size = new System.Drawing.Size(220,40);
 this.buttonExportExcel.Text = "Export All Data to Excel";
 this.buttonExportExcel.Click += new System.EventHandler(this.buttonExportExcel_Click);
 // 
 // buttonExportHtml
 // 
 this.buttonExportHtml.Location = new System.Drawing.Point(12,62);
 this.buttonExportHtml.Name = "buttonExportHtml";
 this.buttonExportHtml.Size = new System.Drawing.Size(220,40);
 this.buttonExportHtml.Text = "Export Rentals to HTML";
 this.buttonExportHtml.Click += new System.EventHandler(this.buttonExportHtml_Click);
 // 
 // buttonGenerateWord
 // 
 this.buttonGenerateWord.Location = new System.Drawing.Point(12,112);
 this.buttonGenerateWord.Name = "buttonGenerateWord";
 this.buttonGenerateWord.Size = new System.Drawing.Size(220,40);
 this.buttonGenerateWord.Text = "Generate Rental Agreement (Word)";
 this.buttonGenerateWord.Click += new System.EventHandler(this.buttonGenerateWord_Click);
 // 
 // buttonImportClients
 // 
 this.buttonImportClients.Location = new System.Drawing.Point(12,162);
 this.buttonImportClients.Name = "buttonImportClients";
 this.buttonImportClients.Size = new System.Drawing.Size(220,40);
 this.buttonImportClients.Text = "Import Clients from Excel";
 this.buttonImportClients.Click += new System.EventHandler(this.buttonImportClients_Click);
 // 
 // buttonImportCars
 // 
 this.buttonImportCars.Location = new System.Drawing.Point(12,212);
 this.buttonImportCars.Name = "buttonImportCars";
 this.buttonImportCars.Size = new System.Drawing.Size(220,40);
 this.buttonImportCars.Text = "Import Cars from Excel";
 this.buttonImportCars.Click += new System.EventHandler(this.buttonImportCars_Click);
 // 
 // buttonExportCarsJson
 // 
 this.buttonExportCarsJson.Location = new System.Drawing.Point(260,12);
 this.buttonExportCarsJson.Name = "buttonExportCarsJson";
 this.buttonExportCarsJson.Size = new System.Drawing.Size(220,40);
 this.buttonExportCarsJson.Text = "Export Cars to JSON";
 this.buttonExportCarsJson.Click += new System.EventHandler(this.buttonExportCarsJson_Click);
 // 
 // buttonExportClientsJson
 // 
 this.buttonExportClientsJson.Location = new System.Drawing.Point(260,62);
 this.buttonExportClientsJson.Name = "buttonExportClientsJson";
 this.buttonExportClientsJson.Size = new System.Drawing.Size(220,40);
 this.buttonExportClientsJson.Text = "Export Clients to JSON";
 this.buttonExportClientsJson.Click += new System.EventHandler(this.buttonExportClientsJson_Click);
 // 
 // buttonImportCarsJson
 // 
 this.buttonImportCarsJson.Location = new System.Drawing.Point(260,112);
 this.buttonImportCarsJson.Name = "buttonImportCarsJson";
 this.buttonImportCarsJson.Size = new System.Drawing.Size(220,40);
 this.buttonImportCarsJson.Text = "Import Cars from JSON";
 this.buttonImportCarsJson.Click += new System.EventHandler(this.buttonImportCarsJson_Click);
 // 
 // buttonImportClientsJson
 // 
 this.buttonImportClientsJson.Location = new System.Drawing.Point(260,162);
 this.buttonImportClientsJson.Name = "buttonImportClientsJson";
 this.buttonImportClientsJson.Size = new System.Drawing.Size(220,40);
 this.buttonImportClientsJson.Text = "Import Clients from JSON";
 this.buttonImportClientsJson.Click += new System.EventHandler(this.buttonImportClientsJson_Click);
 // 
 // progressBar
 // 
 this.progressBar.Location = new System.Drawing.Point(12,270);
 this.progressBar.Name = "progressBar";
 this.progressBar.Size = new System.Drawing.Size(520,20);
 this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Blocks;
 // 
 // labelStatus
 // 
 this.labelStatus.Location = new System.Drawing.Point(12,300);
 this.labelStatus.Name = "labelStatus";
 this.labelStatus.Size = new System.Drawing.Size(520,23);
 this.labelStatus.Text = "Готово";
 // 
 // errorProvider
 // 
 this.errorProvider.ContainerControl = this;
 // 
 // toolTip
 // 
 this.toolTip.SetToolTip(this.buttonExportExcel, "Экспорт всех данных в Excel (Cars, Clients, Rentals)");
 this.toolTip.SetToolTip(this.buttonImportClients, "Импорт клиентов из xlsx (колонки: LastName, FirstName, MiddleName, Address, Phone)");
 this.toolTip.SetToolTip(this.buttonImportCars, "Импорт автомобилей из xlsx (Make, Type, PurchasePrice, RentalPricePerDay, IsAvailable)");
 this.toolTip.SetToolTip(this.buttonExportCarsJson, "Экспорт списка автомобилей в JSON");
 this.toolTip.SetToolTip(this.buttonExportClientsJson, "Экспорт списка клиентов в JSON");
 this.toolTip.SetToolTip(this.buttonImportCarsJson, "Импорт автомобилей из JSON");
 this.toolTip.SetToolTip(this.buttonImportClientsJson, "Импорт клиентов из JSON");
 // 
 // ReportsForm
 // 
 this.ClientSize = new System.Drawing.Size(560,340);
 this.Controls.Add(this.labelStatus);
 this.Controls.Add(this.progressBar);
 this.Controls.Add(this.buttonImportClients);
 this.Controls.Add(this.buttonImportCars);
 this.Controls.Add(this.buttonGenerateWord);
 this.Controls.Add(this.buttonExportHtml);
 this.Controls.Add(this.buttonExportExcel);
 this.Controls.Add(this.buttonExportCarsJson);
 this.Controls.Add(this.buttonExportClientsJson);
 this.Controls.Add(this.buttonImportCarsJson);
 this.Controls.Add(this.buttonImportClientsJson);
 this.Name = "ReportsForm";
 this.Text = "Reports";
 this.ResumeLayout(false);
 }
 #endregion
 private System.Windows.Forms.Button buttonExportExcel;
 private System.Windows.Forms.Button buttonExportHtml;
 private System.Windows.Forms.Button buttonGenerateWord;
 private System.Windows.Forms.Button buttonImportClients;
 private System.Windows.Forms.Button buttonImportCars;
 private System.Windows.Forms.Button buttonExportCarsJson;
 private System.Windows.Forms.Button buttonExportClientsJson;
 private System.Windows.Forms.Button buttonImportCarsJson;
 private System.Windows.Forms.Button buttonImportClientsJson;
 private System.Windows.Forms.ProgressBar progressBar;
 private System.Windows.Forms.Label labelStatus;
 private System.Windows.Forms.ErrorProvider errorProvider;
 private System.Windows.Forms.ToolTip toolTip;
 }
}
