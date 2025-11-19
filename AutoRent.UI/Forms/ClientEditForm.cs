using System;
using System.Windows.Forms;
using AutoRent.Data;
using AutoRent.Data.Models;

namespace AutoRent.UI.Forms
{
 public partial class ClientEditForm : Form
 {
 private readonly AutoRentContext _context;
 private readonly Client _client;
 private readonly bool _isNew;

 public ClientEditForm(AutoRentContext context, Client? client = null)
 {
 _context = context ?? throw new ArgumentNullException(nameof(context));
 _client = client ?? new Client();
 _isNew = client == null;
 InitializeComponent();
 }

 private void ClientEditForm_Load(object sender, EventArgs e)
 {
 textBoxLastName.Text = _client.LastName;
 textBoxFirstName.Text = _client.FirstName;
 textBoxMiddleName.Text = _client.MiddleName;
 textBoxAddress.Text = _client.Address;
 textBoxPhone.Text = _client.Phone;
 }

 private void buttonOk_Click(object sender, EventArgs e)
 {
 if (string.IsNullOrWhiteSpace(textBoxLastName.Text) || string.IsNullOrWhiteSpace(textBoxFirstName.Text))
 {
 MessageBox.Show("LastName and FirstName required");
 return;
 }

 _client.LastName = textBoxLastName.Text.Trim();
 _client.FirstName = textBoxFirstName.Text.Trim();
 _client.MiddleName = string.IsNullOrWhiteSpace(textBoxMiddleName.Text) ? null : textBoxMiddleName.Text.Trim();
 _client.Address = textBoxAddress.Text.Trim();
 _client.Phone = textBoxPhone.Text.Trim();

 if (_isNew) _context.Clients.Add(_client); else _context.Clients.Update(_client);
 DialogResult = DialogResult.OK;
 Close();
 }
 }
}
