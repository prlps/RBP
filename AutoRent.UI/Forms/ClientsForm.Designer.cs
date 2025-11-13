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
 this.components = new System.ComponentModel.Container();
 this.dataGridViewClients = new System.Windows.Forms.DataGridView();
 this.textBoxLastName = new System.Windows.Forms.TextBox();
 this.textBoxFirstName = new System.Windows.Forms.TextBox();
 this.textBoxMiddleName = new System.Windows.Forms.TextBox();
 this.textBoxAddress = new System.Windows.Forms.TextBox();
 this.textBoxPhone = new System.Windows.Forms.TextBox();
 this.buttonAdd = new System.Windows.Forms.Button();
 this.buttonDelete = new System.Windows.Forms.Button();
 this.errorProviderClients = new System.Windows.Forms.ErrorProvider(this.components);
 this.toolTip = new System.Windows.Forms.ToolTip(this.components);
 ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
 ((System.ComponentModel.ISupportInitialize)(this.errorProviderClients)).BeginInit();
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
 this.textBoxLastName.Location = new System.Drawing.Point(630,30);
 this.textBoxLastName.Name = "textBoxLastName";
 this.textBoxLastName.Size = new System.Drawing.Size(200,23);
 // 
 // textBoxFirstName
 // 
 this.textBoxFirstName.Location = new System.Drawing.Point(630,70);
 this.textBoxFirstName.Name = "textBoxFirstName";
 this.textBoxFirstName.Size = new System.Drawing.Size(200,23);
 // 
 // textBoxMiddleName
 // 
 this.textBoxMiddleName.Location = new System.Drawing.Point(630,110);
 this.textBoxMiddleName.Name = "textBoxMiddleName";
 this.textBoxMiddleName.Size = new System.Drawing.Size(200,23);
 // 
 // textBoxAddress
 // 
 this.textBoxAddress.Location = new System.Drawing.Point(630,150);
 this.textBoxAddress.Name = "textBoxAddress";
 this.textBoxAddress.Size = new System.Drawing.Size(200,23);
 // 
 // textBoxPhone
 // 
 this.textBoxPhone.Location = new System.Drawing.Point(630,190);
 this.textBoxPhone.Name = "textBoxPhone";
 this.textBoxPhone.Size = new System.Drawing.Size(200,23);
 // 
 // buttonAdd
 // 
 this.buttonAdd.Location = new System.Drawing.Point(630,230);
 this.buttonAdd.Name = "buttonAdd";
 this.buttonAdd.Size = new System.Drawing.Size(95,32);
 this.buttonAdd.Text = "Добавить";
 this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
 // 
 // buttonDelete
 // 
 this.buttonDelete.Location = new System.Drawing.Point(735,230);
 this.buttonDelete.Name = "buttonDelete";
 this.buttonDelete.Size = new System.Drawing.Size(95,32);
 this.buttonDelete.Text = "Удалить";
 this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
 // 
 // errorProviderClients
 //
 this.errorProviderClients.ContainerControl = this;
 // 
 // toolTip
 //
 this.toolTip.SetToolTip(this.textBoxLastName, "Фамилия клиента (обязательно)");
 this.toolTip.SetToolTip(this.textBoxFirstName, "Имя клиента (обязательно)");
 this.toolTip.SetToolTip(this.textBoxPhone, "Телефон клиента");

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
 ((System.ComponentModel.ISupportInitialize)(this.errorProviderClients)).EndInit();
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
 private System.Windows.Forms.ErrorProvider errorProviderClients;
 private System.Windows.Forms.ToolTip toolTip;
 }
}
