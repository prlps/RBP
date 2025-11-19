using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoRent.Data;
using AutoRent.Data.Models;
using Microsoft.EntityFrameworkCore;
using AutoRent.Services;

namespace AutoRent.UI.Forms
{
 public partial class ClientsForm : Form
 {
 private readonly AutoRentContext _context;

 public ClientsForm(AutoRentContext context)
 {
 _context = context;
 InitializeComponent();
 // handle double-click to edit
 dataGridViewClients.CellDoubleClick += DataGridViewClients_CellDoubleClick;
 }

 private async void DataGridViewClients_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
 {
 if (e.RowIndex <0) return;
 if (dataGridViewClients.Rows[e.RowIndex].DataBoundItem is Client client)
 {
 await EditClientAsync(client);
 }
 }

 private async Task EditClientAsync(Client client)
 {
 using var dlg = new ClientEditForm(_context, client);
 if (dlg.ShowDialog(this) == DialogResult.OK)
 {
 try
 {
 await _context.SaveChangesAsync();
 await _context.Clients.LoadAsync();
 dataGridViewClients.DataSource = _context.Clients.Local.ToBindingList();
 }
 catch (Exception ex)
 {
 MessageBox.Show("Ошибка сохранения: " + ex.Message);
 Logger.Error("ClientsForm.EditClientAsync: " + ex);
 }
 }
 }

 private void buttonEdit_Click(object sender, EventArgs e)
 {
 if (dataGridViewClients.CurrentRow?.DataBoundItem is Client client)
 {
 _ = EditClientAsync(client);
 }
 }

 private async void ClientsForm_Load(object sender, EventArgs e)
 {
 FormStyles.ApplyDefault(this);
 await _context.Clients.LoadAsync();
 dataGridViewClients.DataSource = _context.Clients.Local.ToBindingList();
 }

 private bool ValidateClientInputs()
 {
 errorProviderClients.Clear();
 var ok = true;
 if (string.IsNullOrWhiteSpace(textBoxLastName.Text))
 {
 errorProviderClients.SetError(textBoxLastName, "Введите фамилию клиента.");
 ok = false;
 }
 if (string.IsNullOrWhiteSpace(textBoxFirstName.Text))
 {
 errorProviderClients.SetError(textBoxFirstName, "Введите имя клиента.");
 ok = false;
 }
 return ok;
 }

 private async void buttonAdd_Click(object sender, EventArgs e)
 {
 if (!ValidateClientInputs()) return;
 buttonAdd.Enabled = false;
 try
 {
 var client = new Client { LastName = textBoxLastName.Text.Trim(), FirstName = textBoxFirstName.Text.Trim(), MiddleName = string.IsNullOrWhiteSpace(textBoxMiddleName.Text) ? null : textBoxMiddleName.Text.Trim(), Address = textBoxAddress.Text.Trim(), Phone = textBoxPhone.Text.Trim() };
 _context.Clients.Add(client);
 await _context.SaveChangesAsync();
 dataGridViewClients.DataSource = _context.Clients.Local.ToBindingList();
 }
 catch (Exception ex)
 {
 MessageBox.Show("Ошибка: " + ex.Message);
 Logger.Error("ClientsForm.buttonAdd_Click: " + ex);
 }
 finally
 {
 buttonAdd.Enabled = true;
 }
 }

 private async void buttonDelete_Click(object sender, EventArgs e)
 {
 try
 {
 if (dataGridViewClients.CurrentRow?.DataBoundItem is Client client)
 {
 var confirm = MessageBox.Show($"Удалить клиента {client}?", "Подтвердите", MessageBoxButtons.YesNo);
 if (confirm != DialogResult.Yes) return;
 _context.Clients.Remove(client);
 await _context.SaveChangesAsync();
 dataGridViewClients.DataSource = _context.Clients.Local.ToBindingList();
 }
 }
 catch (Exception ex)
 {
 MessageBox.Show("Ошибка: " + ex.Message);
 Logger.Error("ClientsForm.buttonDelete_Click: " + ex);
 }
 }
 }
}
