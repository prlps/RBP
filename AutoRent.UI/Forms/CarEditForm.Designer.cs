namespace AutoRent.UI.Forms
{
 partial class CarEditForm
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
 this.labelMake = new System.Windows.Forms.Label();
 this.textBoxMake = new System.Windows.Forms.TextBox();
 this.labelType = new System.Windows.Forms.Label();
 this.textBoxType = new System.Windows.Forms.TextBox();
 this.labelPurchase = new System.Windows.Forms.Label();
 this.numericUpDownPurchasePrice = new System.Windows.Forms.NumericUpDown();
 this.labelRental = new System.Windows.Forms.Label();
 this.numericUpDownRentalPrice = new System.Windows.Forms.NumericUpDown();
 this.checkBoxAvailable = new System.Windows.Forms.CheckBox();
 this.buttonOk = new System.Windows.Forms.Button();
 this.buttonCancel = new System.Windows.Forms.Button();
 ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPurchasePrice)).BeginInit();
 ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRentalPrice)).BeginInit();
 this.SuspendLayout();
 // 
 // labelMake
 // 
 this.labelMake.Text = "Make:";
 this.labelMake.AutoSize = true;
 this.labelMake.Location = new System.Drawing.Point(12,12);
 // 
 // textBoxMake
 // 
 this.textBoxMake.Location = new System.Drawing.Point(12,32);
 this.textBoxMake.Width =300;
 // 
 // labelType
 // 
 this.labelType.Text = "Type:";
 this.labelType.AutoSize = true;
 this.labelType.Location = new System.Drawing.Point(12,68);
 // 
 // textBoxType
 // 
 this.textBoxType.Location = new System.Drawing.Point(12,88);
 this.textBoxType.Width =300;
 // 
 // labelPurchase
 // 
 this.labelPurchase.Text = "PurchasePrice:";
 this.labelPurchase.AutoSize = true;
 this.labelPurchase.Location = new System.Drawing.Point(12,124);
 // 
 // numericUpDownPurchasePrice
 // 
 this.numericUpDownPurchasePrice.Location = new System.Drawing.Point(12,144);
 this.numericUpDownPurchasePrice.DecimalPlaces =2;
 this.numericUpDownPurchasePrice.Maximum = new decimal(new int[] {1000000,0,0,0});
 // 
 // labelRental
 // 
 this.labelRental.Text = "RentalPricePerDay:";
 this.labelRental.AutoSize = true;
 this.labelRental.Location = new System.Drawing.Point(12,180);
 // 
 // numericUpDownRentalPrice
 // 
 this.numericUpDownRentalPrice.Location = new System.Drawing.Point(12,200);
 this.numericUpDownRentalPrice.DecimalPlaces =2;
 this.numericUpDownRentalPrice.Maximum = new decimal(new int[] {100000,0,0,0});
 // 
 // checkBoxAvailable
 // 
 this.checkBoxAvailable.Text = "Is Available";
 this.checkBoxAvailable.Location = new System.Drawing.Point(12,236);
 // 
 // buttonOk
 // 
 this.buttonOk.Text = "OK";
 this.buttonOk.Location = new System.Drawing.Point(12,270);
 this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
 // 
 // buttonCancel
 // 
 this.buttonCancel.Text = "Cancel";
 this.buttonCancel.Location = new System.Drawing.Point(120,270);
 this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
 // 
 // CarEditForm
 // 
 this.ClientSize = new System.Drawing.Size(340,320);
 this.Controls.Add(this.buttonCancel);
 this.Controls.Add(this.buttonOk);
 this.Controls.Add(this.checkBoxAvailable);
 this.Controls.Add(this.numericUpDownRentalPrice);
 this.Controls.Add(this.labelRental);
 this.Controls.Add(this.numericUpDownPurchasePrice);
 this.Controls.Add(this.labelPurchase);
 this.Controls.Add(this.textBoxType);
 this.Controls.Add(this.labelType);
 this.Controls.Add(this.textBoxMake);
 this.Controls.Add(this.labelMake);
 this.Name = "CarEditForm";
 this.Text = "Edit Car";
 this.Load += new System.EventHandler(this.CarEditForm_Load);
 ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPurchasePrice)).EndInit();
 ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRentalPrice)).EndInit();
 this.ResumeLayout(false);
 this.PerformLayout();
 }
 #endregion
 private System.Windows.Forms.Label labelMake;
 private System.Windows.Forms.TextBox textBoxMake;
 private System.Windows.Forms.Label labelType;
 private System.Windows.Forms.TextBox textBoxType;
 private System.Windows.Forms.Label labelPurchase;
 private System.Windows.Forms.NumericUpDown numericUpDownPurchasePrice;
 private System.Windows.Forms.Label labelRental;
 private System.Windows.Forms.NumericUpDown numericUpDownRentalPrice;
 private System.Windows.Forms.CheckBox checkBoxAvailable;
 private System.Windows.Forms.Button buttonOk;
 private System.Windows.Forms.Button buttonCancel;
 }
}
