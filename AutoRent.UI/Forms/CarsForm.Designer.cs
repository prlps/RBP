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
this.rightPanel = new System.Windows.Forms.FlowLayoutPanel();
this.labelMake = new System.Windows.Forms.Label();
this.textBoxMake = new System.Windows.Forms.TextBox();
this.labelType = new System.Windows.Forms.Label();
this.textBoxType = new System.Windows.Forms.TextBox();
this.labelPurchase = new System.Windows.Forms.Label();
this.numericUpDownPurchasePrice = new System.Windows.Forms.NumericUpDown();
this.labelRental = new System.Windows.Forms.Label();
this.numericUpDownRentalPrice = new System.Windows.Forms.NumericUpDown();
this.buttonAdd = new System.Windows.Forms.Button();
this.buttonDelete = new System.Windows.Forms.Button();
this.labelFilterMake = new System.Windows.Forms.Label();
this.textBoxFilterMake = new System.Windows.Forms.TextBox();
this.labelFilterType = new System.Windows.Forms.Label();
this.textBoxFilterType = new System.Windows.Forms.TextBox();
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
this.dataGridViewCars.Dock = System.Windows.Forms.DockStyle.Fill;
this.dataGridViewCars.Location = new System.Drawing.Point(12,12);
this.dataGridViewCars.Name = "dataGridViewCars";
this.dataGridViewCars.RowTemplate.Height =25;
this.dataGridViewCars.Size = new System.Drawing.Size(560,420);
this.dataGridViewCars.TabIndex =0;
// 
// rightPanel
// 
this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
this.rightPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
this.rightPanel.Padding = new System.Windows.Forms.Padding(8);
this.rightPanel.AutoScroll = true;
this.rightPanel.WrapContents = false;
this.rightPanel.Width =300;
// 
// labelFilterMake
// 
this.labelFilterMake.Text = "Фильтр по марке:";
this.labelFilterMake.Margin = new System.Windows.Forms.Padding(3,6,3,0);
this.labelFilterMake.AutoSize = true;
// 
// textBoxFilterMake
// 
this.textBoxFilterMake.Width =260;
this.textBoxFilterMake.Margin = new System.Windows.Forms.Padding(3,0,3,6);
this.textBoxFilterMake.TextChanged += new System.EventHandler(this.textBoxFilterMake_TextChanged);
// 
// labelFilterType
// 
this.labelFilterType.Text = "Фильтр по типу:";
this.labelFilterType.Margin = new System.Windows.Forms.Padding(3,6,3,0);
this.labelFilterType.AutoSize = true;
// 
// textBoxFilterType
// 
this.textBoxFilterType.Width =260;
this.textBoxFilterType.Margin = new System.Windows.Forms.Padding(3,0,3,6);
this.textBoxFilterType.TextChanged += new System.EventHandler(this.textBoxFilterType_TextChanged);
// 
// labelMake
// 
this.labelMake.Text = "Марка:";
this.labelMake.AutoSize = true;
this.labelMake.Margin = new System.Windows.Forms.Padding(3,6,3,0);
// 
// textBoxMake
// 
this.textBoxMake.Width =260;
this.textBoxMake.Margin = new System.Windows.Forms.Padding(3,0,3,6);
// 
// labelType
// 
this.labelType.Text = "Модель/Тип:";
this.labelType.AutoSize = true;
this.labelType.Margin = new System.Windows.Forms.Padding(3,6,3,0);
// 
// textBoxType
// 
this.textBoxType.Width =260;
this.textBoxType.Margin = new System.Windows.Forms.Padding(3,0,3,6);
// 
// labelPurchase
// 
this.labelPurchase.Text = "Цена покупки:";
this.labelPurchase.AutoSize = true;
this.labelPurchase.Margin = new System.Windows.Forms.Padding(3,6,3,0);
// 
// numericUpDownPurchasePrice
// 
this.numericUpDownPurchasePrice.DecimalPlaces =2;
this.numericUpDownPurchasePrice.Maximum = new decimal(new int[] {1000000,0,0,0});
this.numericUpDownPurchasePrice.Width =120;
this.numericUpDownPurchasePrice.Margin = new System.Windows.Forms.Padding(3,0,3,6);
// 
// labelRental
// 
this.labelRental.Text = "Цена (в день):";
this.labelRental.AutoSize = true;
this.labelRental.Margin = new System.Windows.Forms.Padding(3,6,3,0);
// 
// numericUpDownRentalPrice
// 
this.numericUpDownRentalPrice.DecimalPlaces =2;
this.numericUpDownRentalPrice.Maximum = new decimal(new int[] {100000,0,0,0});
this.numericUpDownRentalPrice.Width =120;
this.numericUpDownRentalPrice.Margin = new System.Windows.Forms.Padding(3,0,3,6);
// 
// buttonAdd
// 
this.buttonAdd.Text = "Добавить";
this.buttonAdd.Width =120;
this.buttonAdd.Margin = new System.Windows.Forms.Padding(3,6,3,6);
this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
// 
// buttonDelete
// 
this.buttonDelete.Text = "Удалить";
this.buttonDelete.Width =120;
this.buttonDelete.Margin = new System.Windows.Forms.Padding(3,0,3,6);
this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
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
this.toolTip.SetToolTip(this.buttonAdd, "Добавить автомобиль");
this.toolTip.SetToolTip(this.buttonDelete, "Удалить выбранный автомобиль");

// add controls to rightPanel in order
this.rightPanel.Controls.Add(this.labelFilterMake);
this.rightPanel.Controls.Add(this.textBoxFilterMake);
this.rightPanel.Controls.Add(this.labelFilterType);
this.rightPanel.Controls.Add(this.textBoxFilterType);
this.rightPanel.Controls.Add(this.labelMake);
this.rightPanel.Controls.Add(this.textBoxMake);
this.rightPanel.Controls.Add(this.labelType);
this.rightPanel.Controls.Add(this.textBoxType);
this.rightPanel.Controls.Add(this.labelPurchase);
this.rightPanel.Controls.Add(this.numericUpDownPurchasePrice);
this.rightPanel.Controls.Add(this.labelRental);
this.rightPanel.Controls.Add(this.numericUpDownRentalPrice);
this.rightPanel.Controls.Add(this.buttonAdd);
this.rightPanel.Controls.Add(this.buttonDelete);

// 
// CarsForm
// 
this.AutoScaleDimensions = new System.Drawing.SizeF(7F,15F);
this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
this.Padding = new System.Windows.Forms.Padding(12);
this.ClientSize = new System.Drawing.Size(900,440);
this.Controls.Add(this.dataGridViewCars);
this.Controls.Add(this.rightPanel);
this.Name = "CarsForm";
this.Text = "Автомобили";
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
private System.Windows.Forms.FlowLayoutPanel rightPanel;
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
