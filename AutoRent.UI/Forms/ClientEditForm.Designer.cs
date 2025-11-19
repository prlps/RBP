namespace AutoRent.UI.Forms
{
 partial class ClientEditForm
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
 this.labelLastName = new System.Windows.Forms.Label();
 this.textBoxLastName = new System.Windows.Forms.TextBox();
 this.labelFirstName = new System.Windows.Forms.Label();
 this.textBoxFirstName = new System.Windows.Forms.TextBox();
 this.labelMiddleName = new System.Windows.Forms.Label();
 this.textBoxMiddleName = new System.Windows.Forms.TextBox();
 this.labelAddress = new System.Windows.Forms.Label();
 this.textBoxAddress = new System.Windows.Forms.TextBox();
 this.labelPhone = new System.Windows.Forms.Label();
 this.textBoxPhone = new System.Windows.Forms.TextBox();
 this.buttonOk = new System.Windows.Forms.Button();
 this.buttonCancel = new System.Windows.Forms.Button();
 this.SuspendLayout();
 // 
 // labelLastName
 // 
 this.labelLastName.Text = "Last name:";
 this.labelLastName.AutoSize = true;
 this.labelLastName.Location = new System.Drawing.Point(12,12);
 // 
 // textBoxLastName
 // 
 this.textBoxLastName.Location = new System.Drawing.Point(12,32);
 this.textBoxLastName.Width =300;
 // 
 // labelFirstName
 // 
 this.labelFirstName.Text = "First name:";
 this.labelFirstName.AutoSize = true;
 this.labelFirstName.Location = new System.Drawing.Point(12,68);
 // 
 // textBoxFirstName
 // 
 this.textBoxFirstName.Location = new System.Drawing.Point(12,88);
 this.textBoxFirstName.Width =300;
 // 
 // labelMiddleName
 // 
 this.labelMiddleName.Text = "Middle name:";
 this.labelMiddleName.AutoSize = true;
 this.labelMiddleName.Location = new System.Drawing.Point(12,124);
 // 
 // textBoxMiddleName
 // 
 this.textBoxMiddleName.Location = new System.Drawing.Point(12,144);
 this.textBoxMiddleName.Width =300;
 // 
 // labelAddress
 // 
 this.labelAddress.Text = "Address:";
 this.labelAddress.AutoSize = true;
 this.labelAddress.Location = new System.Drawing.Point(12,180);
 // 
 // textBoxAddress
 // 
 this.textBoxAddress.Location = new System.Drawing.Point(12,200);
 this.textBoxAddress.Width =300;
 // 
 // labelPhone
 // 
 this.labelPhone.Text = "Phone:";
 this.labelPhone.AutoSize = true;
 this.labelPhone.Location = new System.Drawing.Point(12,236);
 // 
 // textBoxPhone
 // 
 this.textBoxPhone.Location = new System.Drawing.Point(12,256);
 this.textBoxPhone.Width =300;
 // 
 // buttonOk
 // 
 this.buttonOk.Text = "OK";
 this.buttonOk.Location = new System.Drawing.Point(12,296);
 this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
 // 
 // buttonCancel
 // 
 this.buttonCancel.Text = "Cancel";
 this.buttonCancel.Location = new System.Drawing.Point(120,296);
 this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
 // 
 // ClientEditForm
 // 
 this.ClientSize = new System.Drawing.Size(340,340);
 this.Controls.Add(this.buttonCancel);
 this.Controls.Add(this.buttonOk);
 this.Controls.Add(this.textBoxPhone);
 this.Controls.Add(this.labelPhone);
 this.Controls.Add(this.textBoxAddress);
 this.Controls.Add(this.labelAddress);
 this.Controls.Add(this.textBoxMiddleName);
 this.Controls.Add(this.labelMiddleName);
 this.Controls.Add(this.textBoxFirstName);
 this.Controls.Add(this.labelFirstName);
 this.Controls.Add(this.textBoxLastName);
 this.Controls.Add(this.labelLastName);
 this.Name = "ClientEditForm";
 this.Text = "Edit Client";
 this.Load += new System.EventHandler(this.ClientEditForm_Load);
 this.ResumeLayout(false);
 this.PerformLayout();
 }
 #endregion
 private System.Windows.Forms.Label labelLastName;
 private System.Windows.Forms.TextBox textBoxLastName;
 private System.Windows.Forms.Label labelFirstName;
 private System.Windows.Forms.TextBox textBoxFirstName;
 private System.Windows.Forms.Label labelMiddleName;
 private System.Windows.Forms.TextBox textBoxMiddleName;
 private System.Windows.Forms.Label labelAddress;
 private System.Windows.Forms.TextBox textBoxAddress;
 private System.Windows.Forms.Label labelPhone;
 private System.Windows.Forms.TextBox textBoxPhone;
 private System.Windows.Forms.Button buttonOk;
 private System.Windows.Forms.Button buttonCancel;
 }
}
