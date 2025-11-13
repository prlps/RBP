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
 this.dataGridViewRentals = new System.Windows.Forms.DataGridView();
 this.comboBoxCars = new System.Windows.Forms.ComboBox();
 this.comboBoxClients = new System.Windows.Forms.ComboBox();
 this.dateTimePickerDateOut = new System.Windows.Forms.DateTimePicker();
 this.dateTimePickerPlannedReturn = new System.Windows.Forms.DateTimePicker();
 this.dateTimePickerActualReturn = new System.Windows.Forms.DateTimePicker();
 this.numericUpDownPricePerDay = new System.Windows.Forms.NumericUpDown();
 this.textBoxNotes = new System.Windows.Forms.TextBox();
 this.buttonCreate = new System.Windows.Forms.Button();
 this.buttonClose = new System.Windows.Forms.Button();
 this.labelCar = new System.Windows.Forms.Label();
 this.labelClient = new System.Windows.Forms.Label();
 this.labelDateOut = new System.Windows.Forms.Label();
 this.labelPlannedReturn = new System.Windows.Forms.Label();
 this.labelActualReturn = new System.Windows.Forms.Label();
 this.labelPrice = new System.Windows.Forms.Label();
 this.labelNotes = new System.Windows.Forms.Label();
 this.textBoxFilterClient = new System.Windows.Forms.TextBox();
 this.labelFilterClient = new System.Windows.Forms.Label();
 ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRentals)).BeginInit();
 ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPricePerDay)).BeginInit();
 this.SuspendLayout();
 // 
 // dataGridViewRentals
 // 
 this.dataGridViewRentals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
 this.dataGridViewRentals.Location = new System.Drawing.Point(12,40);
 this.dataGridViewRentals.Name = "dataGridViewRentals";
 this.dataGridViewRentals.RowTemplate.Height =25;
 this.dataGridViewRentals.Size = new System.Drawing.Size(600,350);
 this.dataGridViewRentals.TabIndex =0;
 // 
 // comboBoxCars
 // 
 this.comboBoxCars.FormattingEnabled = true;
 this.comboBoxCars.Location = new System.Drawing.Point(630,30);
 this.comboBoxCars.Name = "comboBoxCars";
 this.comboBoxCars.Size = new System.Drawing.Size(200,23);
 this.comboBoxCars.TabIndex =1;
 // 
 // comboBoxClients
 // 
 this.comboBoxClients.FormattingEnabled = true;
 this.comboBoxClients.Location = new System.Drawing.Point(630,70);
 this.comboBoxClients.Name = "comboBoxClients";
 this.comboBoxClients.Size = new System.Drawing.Size(200,23);
 this.comboBoxClients.TabIndex =2;
 // 
 // dateTimePickerDateOut
 // 
 this.dateTimePickerDateOut.Location = new System.Drawing.Point(630,110);
 this.dateTimePickerDateOut.Name = "dateTimePickerDateOut";
 this.dateTimePickerDateOut.Size = new System.Drawing.Size(200,23);
 this.dateTimePickerDateOut.TabIndex =3;
 // 
 // dateTimePickerPlannedReturn
 // 
 this.dateTimePickerPlannedReturn.Location = new System.Drawing.Point(630,150);
 this.dateTimePickerPlannedReturn.Name = "dateTimePickerPlannedReturn";
 this.dateTimePickerPlannedReturn.Size = new System.Drawing.Size(200,23);
 this.dateTimePickerPlannedReturn.TabIndex =4;
 // 
 // dateTimePickerActualReturn
 // 
 this.dateTimePickerActualReturn.Location = new System.Drawing.Point(630,230);
 this.dateTimePickerActualReturn.Name = "dateTimePickerActualReturn";
 this.dateTimePickerActualReturn.Size = new System.Drawing.Size(200,23);
 this.dateTimePickerActualReturn.TabIndex =5;
 // 
 // numericUpDownPricePerDay
 // 
 this.numericUpDownPricePerDay.DecimalPlaces =2;
 this.numericUpDownPricePerDay.Location = new System.Drawing.Point(630,190);
 this.numericUpDownPricePerDay.Maximum = new decimal(new int[] {100000,0,0,0 });
 this.numericUpDownPricePerDay.Name = "numericUpDownPricePerDay";
 this.numericUpDownPricePerDay.Size = new System.Drawing.Size(200,23);
 this.numericUpDownPricePerDay.TabIndex =6;
 // 
 // textBoxNotes
 // 
 this.textBoxNotes.Location = new System.Drawing.Point(630,270);
 this.textBoxNotes.Multiline = true;
 this.textBoxNotes.Name = "textBoxNotes";
 this.textBoxNotes.Size = new System.Drawing.Size(200,60);
 this.textBoxNotes.TabIndex =7;
 // 
 // buttonCreate
 // 
 this.buttonCreate.Location = new System.Drawing.Point(630,340);
 this.buttonCreate.Name = "buttonCreate";
 this.buttonCreate.Size = new System.Drawing.Size(95,32);
 this.buttonCreate.TabIndex =8;
 this.buttonCreate.Text = "Создать";
 this.buttonCreate.UseVisualStyleBackColor = true;
 this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
 // 
 // buttonClose
 // 
 this.buttonClose.Location = new System.Drawing.Point(735,340);
 this.buttonClose.Name = "buttonClose";
 this.buttonClose.Size = new System.Drawing.Size(95,32);
 this.buttonClose.TabIndex =9;
 this.buttonClose.Text = "Закрыть аренду";
 this.buttonClose.UseVisualStyleBackColor = true;
 this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
 // 
 // Labels
 //
 this.labelCar.Location = new System.Drawing.Point(630,10);
 this.labelCar.Text = "Автомобиль:";
 this.labelClient.Location = new System.Drawing.Point(630,50);
 this.labelClient.Text = "Клиент:";
 this.labelDateOut.Location = new System.Drawing.Point(630,90);
 this.labelDateOut.Text = "Дата выдачи:";
 this.labelPlannedReturn.Location = new System.Drawing.Point(630,130);
 this.labelPlannedReturn.Text = "Планируемая дата возврата:";
 this.labelPrice.Location = new System.Drawing.Point(630,170);
 this.labelPrice.Text = "Цена/день:";
 this.labelActualReturn.Location = new System.Drawing.Point(630,210);
 this.labelActualReturn.Text = "Фактическая дата возврата:";
 this.labelNotes.Location = new System.Drawing.Point(630,250);
 this.labelNotes.Text = "Примечания:";
 
 // Filter controls
 this.textBoxFilterClient.Location = new System.Drawing.Point(12,12);
 this.textBoxFilterClient.Name = "textBoxFilterClient";
 this.textBoxFilterClient.Size = new System.Drawing.Size(200,23);
 this.labelFilterClient.Location = new System.Drawing.Point(12,-2);
 this.labelFilterClient.Text = "Фильтр по фамилии клиента:";
 this.textBoxFilterClient.TextChanged += new System.EventHandler(this.textBoxFilterClient_TextChanged);

 // 
 // RentalsForm
 // 
 this.AutoScaleDimensions = new System.Drawing.SizeF(7F,15F);
 this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
 this.ClientSize = new System.Drawing.Size(860,380);
 this.Controls.Add(this.labelFilterClient);
 this.Controls.Add(this.textBoxFilterClient);
 this.Controls.Add(this.labelNotes);
 this.Controls.Add(this.labelActualReturn);
 this.Controls.Add(this.labelPrice);
 this.Controls.Add(this.labelPlannedReturn);
 this.Controls.Add(this.labelDateOut);
 this.Controls.Add(this.labelClient);
 this.Controls.Add(this.labelCar);
 this.Controls.Add(this.buttonClose);
 this.Controls.Add(this.buttonCreate);
 this.Controls.Add(this.textBoxNotes);
 this.Controls.Add(this.numericUpDownPricePerDay);
 this.Controls.Add(this.dateTimePickerActualReturn);
 this.Controls.Add(this.dateTimePickerPlannedReturn);
 this.Controls.Add(this.dateTimePickerDateOut);
 this.Controls.Add(this.comboBoxClients);
 this.Controls.Add(this.comboBoxCars);
 this.Controls.Add(this.dataGridViewRentals);
 this.Name = "RentalsForm";
 this.Text = "Rentals";
 this.Load += new System.EventHandler(this.RentalsForm_Load);
 ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRentals)).EndInit();
 ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPricePerDay)).EndInit();
 this.ResumeLayout(false);
 this.PerformLayout();

 }

 #endregion

 private System.Windows.Forms.DataGridView dataGridViewRentals;
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
 }
}
