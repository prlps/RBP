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
 this.rightPanel = new System.Windows.Forms.FlowLayoutPanel();
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
 this.dataGridViewClients.Dock = System.Windows.Forms.DockStyle.Fill;
 this.dataGridViewClients.Location = new System.Drawing.Point(12,12);
 this.dataGridViewClients.Name = "dataGridViewClients";
 this.dataGridViewClients.RowTemplate.Height =25;
 this.dataGridViewClients.Size = new System.Drawing.Size(560,420);
 this.dataGridViewClients.TabIndex =0;
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
 // labelLastName
 // 
 this.labelLastName.Text = "Фамилия:";
 this.labelLastName.AutoSize = true;
 this.labelLastName.Margin = new System.Windows.Forms.Padding(3,6,3,0);
 // 
 // textBoxLastName
 // 
 this.textBoxLastName.Width =280;
 this.textBoxLastName.Margin = new System.Windows.Forms.Padding(3,0,3,6);
 // 
 // labelFirstName
 // 
 this.labelFirstName.Text = "Имя:";
 this.labelFirstName.AutoSize = true;
 this.labelFirstName.Margin = new System.Windows.Forms.Padding(3,6,3,0);
 // 
 // textBoxFirstName
 // 
 this.textBoxFirstName.Width =280;
 this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(3,0,3,6);
 // 
 // labelMiddleName
 // 
 this.labelMiddleName.Text = "Отчество:";
 this.labelMiddleName.AutoSize = true;
 this.labelMiddleName.Margin = new System.Windows.Forms.Padding(3,6,3,0);
 // 
 // textBoxMiddleName
 // 
 this.textBoxMiddleName.Width =280;
 this.textBoxMiddleName.Margin = new System.Windows.Forms.Padding(3,0,3,6);
 // 
 // labelAddress
 // 
 this.labelAddress.Text = "Адрес:";
 this.labelAddress.AutoSize = true;
 this.labelAddress.Margin = new System.Windows.Forms.Padding(3,6,3,0);
 // 
 // textBoxAddress
 // 
 this.textBoxAddress.Width =280;
 this.textBoxAddress.Margin = new System.Windows.Forms.Padding(3,0,3,6);
 // 
 // labelPhone
 // 
 this.labelPhone.Text = "Телефон:";
 this.labelPhone.AutoSize = true;
 this.labelPhone.Margin = new System.Windows.Forms.Padding(3,6,3,0);
 // 
 // textBoxPhone
 // 
 this.textBoxPhone.Width =280;
 this.textBoxPhone.Margin = new System.Windows.Forms.Padding(3,0,3,6);
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
 // add controls to rightPanel
 // 
 this.rightPanel.Controls.Add(this.labelLastName);
 this.rightPanel.Controls.Add(this.textBoxLastName);
 this.rightPanel.Controls.Add(this.labelFirstName);
 this.rightPanel.Controls.Add(this.textBoxFirstName);
 this.rightPanel.Controls.Add(this.labelMiddleName);
 this.rightPanel.Controls.Add(this.textBoxMiddleName);
 this.rightPanel.Controls.Add(this.labelAddress);
 this.rightPanel.Controls.Add(this.textBoxAddress);
 this.rightPanel.Controls.Add(this.labelPhone);
 this.rightPanel.Controls.Add(this.textBoxPhone);
 this.rightPanel.Controls.Add(this.buttonAdd);
 this.rightPanel.Controls.Add(this.buttonDelete);
 // 
 // ClientsForm
 // 
 this.AutoScaleDimensions = new System.Drawing.SizeF(7F,15F);
 this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
 this.Padding = new System.Windows.Forms.Padding(12);
 this.ClientSize = new System.Drawing.Size(920,440);
 this.Controls.Add(this.dataGridViewClients);
 this.Controls.Add(this.rightPanel);
 this.Name = "ClientsForm";
 this.Text = "Клиенты";
 this.Load += new System.EventHandler(this.ClientsForm_Load);
 ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
 ((System.ComponentModel.ISupportInitialize)(this.errorProviderClients)).EndInit();
 this.ResumeLayout(false);
 this.PerformLayout();
 }

 #endregion
 private System.Windows.Forms.DataGridView dataGridViewClients;
 private System.Windows.Forms.FlowLayoutPanel rightPanel;
 private System.Windows.Forms.TextBox textBoxLastName;
 private System.Windows.Forms.TextBox textBoxFirstName;
 private System.Windows.Forms.TextBox textBoxMiddleName;
 private System.Windows.Forms.TextBox textBoxAddress;
 private System.Windows.Forms.TextBox textBoxPhone;
 private System.Windows.Forms.Button buttonAdd;
 private System.Windows.Forms.Button buttonDelete;
 private System.Windows.Forms.Label labelLastName;
 private System.Windows.Forms.Label labelFirstName;
 private System.Windows.Forms.Label labelMiddleName;
 private System.Windows.Forms.Label labelAddress;
 private System.Windows.Forms.Label labelPhone;
 private System.Windows.Forms.ErrorProvider errorProviderClients;
 private System.Windows.Forms.ToolTip toolTip;
 }
}
