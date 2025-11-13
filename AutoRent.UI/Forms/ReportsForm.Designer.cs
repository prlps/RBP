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
 this.buttonExportExcel = new System.Windows.Forms.Button();
 this.buttonExportHtml = new System.Windows.Forms.Button();
 this.buttonGenerateWord = new System.Windows.Forms.Button();
 this.buttonImportClients = new System.Windows.Forms.Button();
 this.buttonImportCars = new System.Windows.Forms.Button();
 this.SuspendLayout();
 // 
 // buttonExportExcel
 // 
 this.buttonExportExcel.Location = new System.Drawing.Point(12,12);
 this.buttonExportExcel.Name = "buttonExportExcel";
 this.buttonExportExcel.Size = new System.Drawing.Size(200,40);
 this.buttonExportExcel.Text = "Export All Data to Excel";
 this.buttonExportExcel.Click += new System.EventHandler(this.buttonExportExcel_Click);
 // 
 // buttonExportHtml
 // 
 this.buttonExportHtml.Location = new System.Drawing.Point(12,62);
 this.buttonExportHtml.Name = "buttonExportHtml";
 this.buttonExportHtml.Size = new System.Drawing.Size(200,40);
 this.buttonExportHtml.Text = "Export Rentals to HTML";
 this.buttonExportHtml.Click += new System.EventHandler(this.buttonExportHtml_Click);
 // 
 // buttonGenerateWord
 // 
 this.buttonGenerateWord.Location = new System.Drawing.Point(12,112);
 this.buttonGenerateWord.Name = "buttonGenerateWord";
 this.buttonGenerateWord.Size = new System.Drawing.Size(200,40);
 this.buttonGenerateWord.Text = "Generate Rental Agreement (Word)";
 this.buttonGenerateWord.Click += new System.EventHandler(this.buttonGenerateWord_Click);
 // 
 // buttonImportClients
 // 
 this.buttonImportClients.Location = new System.Drawing.Point(12,162);
 this.buttonImportClients.Name = "buttonImportClients";
 this.buttonImportClients.Size = new System.Drawing.Size(200,40);
 this.buttonImportClients.Text = "Import Clients from Excel";
 this.buttonImportClients.Click += new System.EventHandler(this.buttonImportClients_Click);
 // 
 // buttonImportCars
 // 
 this.buttonImportCars.Location = new System.Drawing.Point(12,212);
 this.buttonImportCars.Name = "buttonImportCars";
 this.buttonImportCars.Size = new System.Drawing.Size(200,40);
 this.buttonImportCars.Text = "Import Cars from Excel";
 this.buttonImportCars.Click += new System.EventHandler(this.buttonImportCars_Click);
 // 
 // ReportsForm
 // 
 this.ClientSize = new System.Drawing.Size(240,270);
 this.Controls.Add(this.buttonImportCars);
 this.Controls.Add(this.buttonImportClients);
 this.Controls.Add(this.buttonGenerateWord);
 this.Controls.Add(this.buttonExportHtml);
 this.Controls.Add(this.buttonExportExcel);
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
 }
}
