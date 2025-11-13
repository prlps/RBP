namespace AutoRent.UI.Forms
{
 partial class CarsForm
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
 this.dataGridViewCars = new System.Windows.Forms.DataGridView();
 this.textBoxMake = new System.Windows.Forms.TextBox();
 this.textBoxType = new System.Windows.Forms.TextBox();
 this.numericUpDownPurchasePrice = new System.Windows.Forms.NumericUpDown();
 this.numericUpDownRentalPrice = new System.Windows.Forms.NumericUpDown();
 this.buttonAdd = new System.Windows.Forms.Button();
 this.buttonDelete = new System.Windows.Forms.Button();
 ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCars)).BeginInit();
 ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPurchasePrice)).BeginInit();
 ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRentalPrice)).BeginInit();
 this.SuspendLayout();
 // 
 // dataGridViewCars
 // 
 this.dataGridViewCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
 this.dataGridViewCars.Location = new System.Drawing.Point(12,12);
 this.dataGridViewCars.Name = "dataGridViewCars";
 this.dataGridViewCars.RowTemplate.Height =25;
 this.dataGridViewCars.Size = new System.Drawing.Size(600,350);
 this.dataGridViewCars.TabIndex =0;
 // 
 // textBoxMake
 // 
 this.textBoxMake.Location = new System.Drawing.Point(630,12);
 this.textBoxMake.Name = "textBoxMake";
 this.textBoxMake.Size = new System.Drawing.Size(200,23);
 // 
 // textBoxType
 // 
 this.textBoxType.Location = new System.Drawing.Point(630,50);
 this.textBoxType.Name = "textBoxType";
 this.textBoxType.Size = new System.Drawing.Size(200,23);
 // 
 // numericUpDownPurchasePrice
 // 
 this.numericUpDownPurchasePrice.DecimalPlaces =2;
 this.numericUpDownPurchasePrice.Location = new System.Drawing.Point(630,90);
 this.numericUpDownPurchasePrice.Maximum = new decimal(new int[] {1000000,0,0,0});
 // 
 // numericUpDownRentalPrice
 // 
 this.numericUpDownRentalPrice.DecimalPlaces =2;
 this.numericUpDownRentalPrice.Location = new System.Drawing.Point(630,130);
 this.numericUpDownRentalPrice.Maximum = new decimal(new int[] {100000,0,0,0});
 // 
 // buttonAdd
 // 
 this.buttonAdd.Location = new System.Drawing.Point(630,170);
 this.buttonAdd.Name = "buttonAdd";
 this.buttonAdd.Size = new System.Drawing.Size(95,32);
 this.buttonAdd.Text = "Добавить";
 this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
 // 
 // buttonDelete
 // 
 this.buttonDelete.Location = new System.Drawing.Point(735,170);
 this.buttonDelete.Name = "buttonDelete";
 this.buttonDelete.Size = new System.Drawing.Size(95,32);
 this.buttonDelete.Text = "Удалить";
 this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
 // 
 // CarsForm
 // 
 this.ClientSize = new System.Drawing.Size(860,380);
 this.Controls.Add(this.buttonDelete);
 this.Controls.Add(this.buttonAdd);
 this.Controls.Add(this.numericUpDownRentalPrice);
 this.Controls.Add(this.numericUpDownPurchasePrice);
 this.Controls.Add(this.textBoxType);
 this.Controls.Add(this.textBoxMake);
 this.Controls.Add(this.dataGridViewCars);
 this.Name = "CarsForm";
 this.Text = "Cars";
 this.Load += new System.EventHandler(this.CarsForm_Load);
 ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCars)).EndInit();
 ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPurchasePrice)).EndInit();
 ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRentalPrice)).EndInit();
 this.ResumeLayout(false);
 this.PerformLayout();
 }
 #endregion
 private System.Windows.Forms.DataGridView dataGridViewCars;
 private System.Windows.Forms.TextBox textBoxMake;
 private System.Windows.Forms.TextBox textBoxType;
 private System.Windows.Forms.NumericUpDown numericUpDownPurchasePrice;
 private System.Windows.Forms.NumericUpDown numericUpDownRentalPrice;
 private System.Windows.Forms.Button buttonAdd;
 private System.Windows.Forms.Button buttonDelete;
 }
}
