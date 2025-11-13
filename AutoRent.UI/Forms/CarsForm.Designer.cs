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
 this.components = new System.ComponentModel.Container();
 this.dataGridViewCars = new System.Windows.Forms.DataGridView();
 this.textBoxMake = new System.Windows.Forms.TextBox();
 this.textBoxType = new System.Windows.Forms.TextBox();
 this.numericUpDownPurchasePrice = new System.Windows.Forms.NumericUpDown();
 this.numericUpDownRentalPrice = new System.Windows.Forms.NumericUpDown();
 this.buttonAdd = new System.Windows.Forms.Button();
 this.buttonDelete = new System.Windows.Forms.Button();
 this.labelMake = new System.Windows.Forms.Label();
 this.labelType = new System.Windows.Forms.Label();
 this.labelPurchase = new System.Windows.Forms.Label();
 this.labelRental = new System.Windows.Forms.Label();
 this.textBoxFilterMake = new System.Windows.Forms.TextBox();
 this.textBoxFilterType = new System.Windows.Forms.TextBox();
 this.labelFilterMake = new System.Windows.Forms.Label();
 this.labelFilterType = new System.Windows.Forms.Label();
 this.errorProviderCars = new System.Windows.Forms.ErrorProvider(this.components);
 this.toolTip = new System.Windows.Forms.ToolTip(this.components);
 ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCars)).BeginInit();
 ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPurchasePrice)).BeginInit();
 ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRentalPrice)).BeginInit();
 ((System.ComponentModel.ISupportInitialize)(this.errorProviderCars)).BeginInit();
 this.SuspendLayout();
 // 
 // dataGridViewCars
 // 
 this.dataGridViewCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
 this.dataGridViewCars.Location = new System.Drawing.Point(12,40);
 this.dataGridViewCars.Name = "dataGridViewCars";
 this.dataGridViewCars.RowTemplate.Height =25;
 this.dataGridViewCars.Size = new System.Drawing.Size(600,350);
 this.dataGridViewCars.TabIndex =0;
 // 
 // textBoxMake
 // 
 this.textBoxMake.Location = new System.Drawing.Point(630,30);
 this.textBoxMake.Name = "textBoxMake";
 this.textBoxMake.Size = new System.Drawing.Size(200,23);
 // 
 // textBoxType
 // 
 this.textBoxType.Location = new System.Drawing.Point(630,70);
 this.textBoxType.Name = "textBoxType";
 this.textBoxType.Size = new System.Drawing.Size(200,23);
 // 
 // numericUpDownPurchasePrice
 // 
 this.numericUpDownPurchasePrice.DecimalPlaces =2;
 this.numericUpDownPurchasePrice.Location = new System.Drawing.Point(630,110);
 this.numericUpDownPurchasePrice.Maximum = new decimal(new int[] {1000000,0,0,0});
 // 
 // numericUpDownRentalPrice
 // 
 this.numericUpDownRentalPrice.DecimalPlaces =2;
 this.numericUpDownRentalPrice.Location = new System.Drawing.Point(630,150);
 this.numericUpDownRentalPrice.Maximum = new decimal(new int[] {100000,0,0,0});
 // 
 // buttonAdd
 // 
 this.buttonAdd.Location = new System.Drawing.Point(630,190);
 this.buttonAdd.Name = "buttonAdd";
 this.buttonAdd.Size = new System.Drawing.Size(95,32);
 this.buttonAdd.Text = "Добавить";
 this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
 // 
 // buttonDelete
 // 
 this.buttonDelete.Location = new System.Drawing.Point(735,190);
 this.buttonDelete.Name = "buttonDelete";
 this.buttonDelete.Size = new System.Drawing.Size(95,32);
 this.buttonDelete.Text = "Удалить";
 this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
 // 
 // Labels for fields
 //
 this.labelMake.Location = new System.Drawing.Point(630,10);
 this.labelMake.Text = "Make:";
 this.labelType.Location = new System.Drawing.Point(630,50);
 this.labelType.Text = "Type:";
 this.labelPurchase.Location = new System.Drawing.Point(630,90);
 this.labelPurchase.Text = "PurchasePrice:";
 this.labelRental.Location = new System.Drawing.Point(630,130);
 this.labelRental.Text = "RentalPricePerDay:";

 // Filters
 this.labelFilterMake.Location = new System.Drawing.Point(12,12);
 this.labelFilterMake.Text = "Filter Make:";
 this.textBoxFilterMake.Location = new System.Drawing.Point(100,10);
 this.textBoxFilterMake.Size = new System.Drawing.Size(150,23);
 this.textBoxFilterMake.TextChanged += new System.EventHandler(this.textBoxFilterMake_TextChanged);

 this.labelFilterType.Location = new System.Drawing.Point(260,12);
 this.labelFilterType.Text = "Filter Type:";
 this.textBoxFilterType.Location = new System.Drawing.Point(330,10);
 this.textBoxFilterType.Size = new System.Drawing.Size(150,23);
 this.textBoxFilterType.TextChanged += new System.EventHandler(this.textBoxFilterType_TextChanged);

 // 
 // errorProviderCars
 //
 this.errorProviderCars.ContainerControl = this;

 // 
 // toolTip
 //
 this.toolTip.SetToolTip(this.textBoxMake, "Введите марку/модель автомобиля");
 this.toolTip.SetToolTip(this.textBoxType, "Введите тип автомобиля (седан, SUV и т.д.)");
 this.toolTip.SetToolTip(this.numericUpDownRentalPrice, "Стоимость аренды в день");
 this.toolTip.SetToolTip(this.buttonAdd, "Добавить или сохранить автомобиль");
 this.toolTip.SetToolTip(this.buttonDelete, "Удалить выбранный автомобиль");

 // 
 // CarsForm
 // 
 this.ClientSize = new System.Drawing.Size(860,420);
 this.Controls.Add(this.labelFilterType);
 this.Controls.Add(this.textBoxFilterType);
 this.Controls.Add(this.labelFilterMake);
 this.Controls.Add(this.textBoxFilterMake);
 this.Controls.Add(this.labelRental);
 this.Controls.Add(this.labelPurchase);
 this.Controls.Add(this.labelType);
 this.Controls.Add(this.labelMake);
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
 ((System.ComponentModel.ISupportInitialize)(this.errorProviderCars)).EndInit();
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
 private System.Windows.Forms.Label labelMake;
 private System.Windows.Forms.Label labelType;
 private System.Windows.Forms.Label labelPurchase;
 private System.Windows.Forms.Label labelRental;
 private System.Windows.Forms.TextBox textBoxFilterMake;
 private System.Windows.Forms.TextBox textBoxFilterType;
 private System.Windows.Forms.Label labelFilterMake;
 private System.Windows.Forms.Label labelFilterType;
 private System.Windows.Forms.ErrorProvider errorProviderCars;
 private System.Windows.Forms.ToolTip toolTip;
 }
}
