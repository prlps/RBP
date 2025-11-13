namespace AutoRent.UI.Forms
{
partial class RentalsForm
{
/// <summary>
/// Required designer variable.
/// </summary>
private System.ComponentModel.IContainer components = null;

/// <summary>
/// Clean up any resources being used.
/// </summary>
/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
protected override void Dispose(bool disposing)
{
if (disposing && (components != null))
{
components.Dispose();
}
base.Dispose(disposing);
}

#region Windows Form Designer generated code

/// <summary>
/// Required method for Designer support - do not modify
/// the contents of this method with the code editor.
/// </summary>
private void InitializeComponent()
{
this.components = new System.ComponentModel.Container();
this.dataGridViewRentals = new System.Windows.Forms.DataGridView();
this.rightPanel = new System.Windows.Forms.FlowLayoutPanel();
this.labelFilterClient = new System.Windows.Forms.Label();
this.textBoxFilterClient = new System.Windows.Forms.TextBox();
this.labelFilterFrom = new System.Windows.Forms.Label();
this.dateTimePickerFilterFrom = new System.Windows.Forms.DateTimePicker();
this.labelFilterTo = new System.Windows.Forms.Label();
this.dateTimePickerFilterTo = new System.Windows.Forms.DateTimePicker();
this.labelCar = new System.Windows.Forms.Label();
this.comboBoxCars = new System.Windows.Forms.ComboBox();
this.labelClient = new System.Windows.Forms.Label();
this.comboBoxClients = new System.Windows.Forms.ComboBox();
this.labelDateOut = new System.Windows.Forms.Label();
this.dateTimePickerDateOut = new System.Windows.Forms.DateTimePicker();
this.labelPlannedReturn = new System.Windows.Forms.Label();
this.dateTimePickerPlannedReturn = new System.Windows.Forms.DateTimePicker();
this.labelPrice = new System.Windows.Forms.Label();
this.numericUpDownPricePerDay = new System.Windows.Forms.NumericUpDown();
this.labelActualReturn = new System.Windows.Forms.Label();
this.dateTimePickerActualReturn = new System.Windows.Forms.DateTimePicker();
this.labelNotes = new System.Windows.Forms.Label();
this.textBoxNotes = new System.Windows.Forms.TextBox();
this.buttonCreate = new System.Windows.Forms.Button();
this.buttonClose = new System.Windows.Forms.Button();
((System.ComponentModel.ISupportInitialize)(this.dataGridViewRentals)).BeginInit();
((System.ComponentModel.ISupportInitialize)(this.numericUpDownPricePerDay)).BeginInit();
this.SuspendLayout();
// 
// dataGridViewRentals
// 
this.dataGridViewRentals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
this.dataGridViewRentals.Dock = System.Windows.Forms.DockStyle.Fill;
this.dataGridViewRentals.Location = new System.Drawing.Point(12,12);
this.dataGridViewRentals.Name = "dataGridViewRentals";
this.dataGridViewRentals.RowTemplate.Height =25;
this.dataGridViewRentals.TabIndex =0;
// 
// rightPanel
// 
this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
this.rightPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
this.rightPanel.Padding = new System.Windows.Forms.Padding(8);
this.rightPanel.AutoScroll = true;
this.rightPanel.WrapContents = false;
this.rightPanel.Width =320;
// 
// labelFilterClient
// 
this.labelFilterClient.Text = "Фильтр по фамилии клиента:";
this.labelFilterClient.AutoSize = true;
this.labelFilterClient.Margin = new System.Windows.Forms.Padding(3,6,3,0);
// 
// textBoxFilterClient
// 
this.textBoxFilterClient.Width =280;
this.textBoxFilterClient.Margin = new System.Windows.Forms.Padding(3,0,3,6);
this.textBoxFilterClient.TextChanged += new System.EventHandler(this.textBoxFilterClient_TextChanged);
// 
// labelFilterFrom
// 
this.labelFilterFrom.Text = "Дата от:";
this.labelFilterFrom.AutoSize = true;
this.labelFilterFrom.Margin = new System.Windows.Forms.Padding(3,6,3,0);
// 
// dateTimePickerFilterFrom
// 
this.dateTimePickerFilterFrom.Width =150;
this.dateTimePickerFilterFrom.Margin = new System.Windows.Forms.Padding(3,0,3,6);
this.dateTimePickerFilterFrom.ValueChanged += new System.EventHandler(this.FilterControl_ValueChanged);
// 
// labelFilterTo
// 
this.labelFilterTo.Text = "Дата до:";
this.labelFilterTo.AutoSize = true;
this.labelFilterTo.Margin = new System.Windows.Forms.Padding(3,6,3,0);
// 
// dateTimePickerFilterTo
// 
this.dateTimePickerFilterTo.Width =150;
this.dateTimePickerFilterTo.Margin = new System.Windows.Forms.Padding(3,0,3,6);
this.dateTimePickerFilterTo.ValueChanged += new System.EventHandler(this.FilterControl_ValueChanged);
// 
// labelCar
// 
this.labelCar.Text = "Автомобиль:";
this.labelCar.AutoSize = true;
this.labelCar.Margin = new System.Windows.Forms.Padding(3,6,3,0);
// 
// comboBoxCars
// 
this.comboBoxCars.Width =280;
this.comboBoxCars.Margin = new System.Windows.Forms.Padding(3,0,3,6);
// 
// labelClient
// 
this.labelClient.Text = "Клиент:";
this.labelClient.AutoSize = true;
this.labelClient.Margin = new System.Windows.Forms.Padding(3,6,3,0);
// 
// comboBoxClients
// 
this.comboBoxClients.Width =280;
this.comboBoxClients.Margin = new System.Windows.Forms.Padding(3,0,3,6);
// 
// labelDateOut
// 
this.labelDateOut.Text = "Дата выдачи:";
this.labelDateOut.AutoSize = true;
this.labelDateOut.Margin = new System.Windows.Forms.Padding(3,6,3,0);
// 
// dateTimePickerDateOut
// 
this.dateTimePickerDateOut.Width =150;
this.dateTimePickerDateOut.Margin = new System.Windows.Forms.Padding(3,0,3,6);
// 
// labelPlannedReturn
// 
this.labelPlannedReturn.Text = "Планируемая дата возврата:";
this.labelPlannedReturn.AutoSize = true;
this.labelPlannedReturn.Margin = new System.Windows.Forms.Padding(3,6,3,0);
// 
// dateTimePickerPlannedReturn
// 
this.dateTimePickerPlannedReturn.Width =150;
this.dateTimePickerPlannedReturn.Margin = new System.Windows.Forms.Padding(3,0,3,6);
// 
// labelPrice
// 
this.labelPrice.Text = "Цена/день:";
this.labelPrice.AutoSize = true;
this.labelPrice.Margin = new System.Windows.Forms.Padding(3,6,3,0);
// 
// numericUpDownPricePerDay
// 
this.numericUpDownPricePerDay.DecimalPlaces =2;
this.numericUpDownPricePerDay.Maximum = new decimal(new int[] {100000,0,0,0});
this.numericUpDownPricePerDay.Width =120;
this.numericUpDownPricePerDay.Margin = new System.Windows.Forms.Padding(3,0,3,6);
// 
// labelActualReturn
// 
this.labelActualReturn.Text = "Фактическая дата возврата:";
this.labelActualReturn.AutoSize = true;
this.labelActualReturn.Margin = new System.Windows.Forms.Padding(3,6,3,0);
// 
// dateTimePickerActualReturn
// 
this.dateTimePickerActualReturn.Width =150;
this.dateTimePickerActualReturn.Margin = new System.Windows.Forms.Padding(3,0,3,6);
// 
// labelNotes
// 
this.labelNotes.Text = "Примечания:";
this.labelNotes.AutoSize = true;
this.labelNotes.Margin = new System.Windows.Forms.Padding(3,6,3,0);
// 
// textBoxNotes
// 
this.textBoxNotes.Width =280;
this.textBoxNotes.Height =60;
this.textBoxNotes.Multiline = true;
this.textBoxNotes.Margin = new System.Windows.Forms.Padding(3,0,3,6);
// 
// buttonCreate
// 
this.buttonCreate.Text = "Создать";
this.buttonCreate.Width =120;
this.buttonCreate.Margin = new System.Windows.Forms.Padding(3,6,3,6);
this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
// 
// buttonClose
// 
this.buttonClose.Text = "Закрыть аренду";
this.buttonClose.Width =120;
this.buttonClose.Margin = new System.Windows.Forms.Padding(3,0,3,6);
this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
// 
// add controls to rightPanel
// 
this.rightPanel.Controls.Add(this.labelFilterClient);
this.rightPanel.Controls.Add(this.textBoxFilterClient);
this.rightPanel.Controls.Add(this.labelFilterFrom);
this.rightPanel.Controls.Add(this.dateTimePickerFilterFrom);
this.rightPanel.Controls.Add(this.labelFilterTo);
this.rightPanel.Controls.Add(this.dateTimePickerFilterTo);
this.rightPanel.Controls.Add(this.labelCar);
this.rightPanel.Controls.Add(this.comboBoxCars);
this.rightPanel.Controls.Add(this.labelClient);
this.rightPanel.Controls.Add(this.comboBoxClients);
this.rightPanel.Controls.Add(this.labelDateOut);
this.rightPanel.Controls.Add(this.dateTimePickerDateOut);
this.rightPanel.Controls.Add(this.labelPlannedReturn);
this.rightPanel.Controls.Add(this.dateTimePickerPlannedReturn);
this.rightPanel.Controls.Add(this.labelPrice);
this.rightPanel.Controls.Add(this.numericUpDownPricePerDay);
this.rightPanel.Controls.Add(this.labelActualReturn);
this.rightPanel.Controls.Add(this.dateTimePickerActualReturn);
this.rightPanel.Controls.Add(this.labelNotes);
this.rightPanel.Controls.Add(this.textBoxNotes);
this.rightPanel.Controls.Add(this.buttonCreate);
this.rightPanel.Controls.Add(this.buttonClose);
// 
// RentalsForm
// 
this.AutoScaleDimensions = new System.Drawing.SizeF(7F,15F);
this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
this.Padding = new System.Windows.Forms.Padding(12);
this.ClientSize = new System.Drawing.Size(960,480);
this.Controls.Add(this.dataGridViewRentals);
this.Controls.Add(this.rightPanel);
this.Name = "RentalsForm";
this.Text = "Аренды";
this.Load += new System.EventHandler(this.RentalsForm_Load);
((System.ComponentModel.ISupportInitialize)(this.dataGridViewRentals)).EndInit();
((System.ComponentModel.ISupportInitialize)(this.numericUpDownPricePerDay)).EndInit();
this.ResumeLayout(false);
this.PerformLayout();

}

#endregion

private System.Windows.Forms.DataGridView dataGridViewRentals;
private System.Windows.Forms.FlowLayoutPanel rightPanel;
private System.Windows.Forms.ComboBox comboBoxCars;
private System.Windows.Forms.ComboBox comboBoxClients;
private System.Windows.Forms.DateTimePicker dateTimePickerDateOut;
private System.Windows.Forms.DateTimePicker dateTimePickerPlannedReturn;
private System.Windows.Forms.DateTimePicker dateTimePickerActualReturn;
private System.Windows.Forms.NumericUpDown numericUpDownPricePerDay;
private System.Windows.Forms.TextBox textBoxNotes;
private System.Windows.Forms.Button buttonCreate;
private System.Windows.Forms.Button buttonClose;
private System.Windows.Forms.Label labelCar;
private System.Windows.Forms.Label labelClient;
private System.Windows.Forms.Label labelDateOut;
private System.Windows.Forms.Label labelPlannedReturn;
private System.Windows.Forms.Label labelActualReturn;
private System.Windows.Forms.Label labelPrice;
private System.Windows.Forms.Label labelNotes;
private System.Windows.Forms.TextBox textBoxFilterClient;
private System.Windows.Forms.Label labelFilterClient;
private System.Windows.Forms.DateTimePicker dateTimePickerFilterFrom;
private System.Windows.Forms.DateTimePicker dateTimePickerFilterTo;
private System.Windows.Forms.Label labelFilterFrom;
private System.Windows.Forms.Label labelFilterTo;
}
}
