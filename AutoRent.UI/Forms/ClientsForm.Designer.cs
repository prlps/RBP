namespace AutoRent.UI.Forms
{
 partial class ClientsForm
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
 this.dataGridViewClients = new System.Windows.Forms.DataGridView();
 this.textBoxLastName = new System.Windows.Forms.TextBox();
 this.textBoxFirstName = new System.Windows.Forms.TextBox();
 this.textBoxMiddleName = new System.Windows.Forms.TextBox();
 this.textBoxAddress = new System.Windows.Forms.TextBox();
 this.textBoxPhone = new System.Windows.Forms.TextBox();
 this.buttonAdd = new System.Windows.Forms.Button();
 this.buttonDelete = new System.Windows.Forms.Button();
 ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
 this.SuspendLayout();
 // 
 // dataGridViewClients
 // 
 this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
 this.dataGridViewClients.Location = new System.Drawing.Point(12,12);
 this.dataGridViewClients.Name = "dataGridViewClients";
 this.dataGridViewClients.RowTemplate.Height =25;
 this.dataGridViewClients.Size = new System.Drawing.Size(600,350);
 this.dataGridViewClients.TabIndex =0;
 // 
 // textBoxLastName
 // 
 this.textBoxLastName.Location = new System.Drawing.Point(630,12);
 this.textBoxLastName.Name = "textBoxLastName";
 this.textBoxLastName.Size = new System.Drawing.Size(200,23);
 // 
 // textBoxFirstName
 // 
 this.textBoxFirstName.Location = new System.Drawing.Point(630,50);
 this.textBoxFirstName.Name = "textBoxFirstName";
 this.textBoxFirstName.Size = new System.Drawing.Size(200,23);
 // 
 // textBoxMiddleName
 // 
 this.textBoxMiddleName.Location = new System.Drawing.Point(630,90);
 this.textBoxMiddleName.Name = "textBoxMiddleName";
 this.textBoxMiddleName.Size = new System.Drawing.Size(200,23);
 // 
 // textBoxAddress
 // 
 this.textBoxAddress.Location = new System.Drawing.Point(630,130);
 this.textBoxAddress.Name = "textBoxAddress";
 this.textBoxAddress.Size = new System.Drawing.Size(200,23);
 // 
 // textBoxPhone
 // 
 this.textBoxPhone.Location = new System.Drawing.Point(630,170);
 this.textBoxPhone.Name = "textBoxPhone";
 this.textBoxPhone.Size = new System.Drawing.Size(200,23);
 // 
 // buttonAdd
 // 
 this.buttonAdd.Location = new System.Drawing.Point(630,210);
 this.buttonAdd.Name = "buttonAdd";
 this.buttonAdd.Size = new System.Drawing.Size(95,32);
 this.buttonAdd.Text = "Добавить";
 this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
 // 
 // buttonDelete
 // 
 this.buttonDelete.Location = new System.Drawing.Point(735,210);
 this.buttonDelete.Name = "buttonDelete";
 this.buttonDelete.Size = new System.Drawing.Size(95,32);
 this.buttonDelete.Text = "Удалить";
 this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
 // 
 // ClientsForm
 // 
 this.ClientSize = new System.Drawing.Size(860,380);
 this.Controls.Add(this.buttonDelete);
 this.Controls.Add(this.buttonAdd);
 this.Controls.Add(this.textBoxPhone);
 this.Controls.Add(this.textBoxAddress);
 this.Controls.Add(this.textBoxMiddleName);
 this.Controls.Add(this.textBoxFirstName);
 this.Controls.Add(this.textBoxLastName);
 this.Controls.Add(this.dataGridViewClients);
 this.Name = "ClientsForm";
 this.Text = "Clients";
 this.Load += new System.EventHandler(this.ClientsForm_Load);
 ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
 this.ResumeLayout(false);
 this.PerformLayout();
 }
 #endregion
 private System.Windows.Forms.DataGridView dataGridViewClients;
 private System.Windows.Forms.TextBox textBoxLastName;
 private System.Windows.Forms.TextBox textBoxFirstName;
 private System.Windows.Forms.TextBox textBoxMiddleName;
 private System.Windows.Forms.TextBox textBoxAddress;
 private System.Windows.Forms.TextBox textBoxPhone;
 private System.Windows.Forms.Button buttonAdd;
 private System.Windows.Forms.Button buttonDelete;
 }
}
