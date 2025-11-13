using System;
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
 }

 private async void ClientsForm_Load(object sender, EventArgs e)
 {
 await _context.Clients.LoadAsync();
 dataGridViewClients.DataSource = _context.Clients.Local.ToBindingList();
 }

 private async void buttonAdd_Click(object sender, EventArgs e)
 {
 try
 {
 var last = textBoxLastName.Text.Trim();
 var first = textBoxFirstName.Text.Trim();
 if (string.IsNullOrEmpty(last) || string.IsNullOrEmpty(first))
 {
 MessageBox.Show("Введите фамилию и имя клиента.");
 return;
 }

 var client = new Client { LastName = last, FirstName = first, MiddleName = textBoxMiddleName.Text.Trim(), Address = textBoxAddress.Text.Trim(), Phone = textBoxPhone.Text.Trim() };
 _context.Clients.Add(client);
 await _context.SaveChangesAsync();
 dataGridViewClients.Refresh();
 }
 catch (Exception ex)
 {
 MessageBox.Show("Ошибка: " + ex.Message);
 Logger.Error("ClientsForm.buttonAdd_Click: " + ex);
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
 dataGridViewClients.Refresh();
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
