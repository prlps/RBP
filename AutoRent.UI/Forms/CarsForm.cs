using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoRent.Data;
using AutoRent.Data.Models;
using Microsoft.EntityFrameworkCore;
using AutoRent.Services;

namespace AutoRent.UI.Forms
{
 public partial class CarsForm : Form
 {
 private readonly AutoRentContext _context;

 public CarsForm(AutoRentContext context)
 {
 _context = context;
 InitializeComponent();
 }

 private async void CarsForm_Load(object sender, EventArgs e)
 {
 FormStyles.ApplyDefault(this);
 await _context.Cars.LoadAsync();
 dataGridViewCars.DataSource = _context.Cars.Local.ToBindingList();
 }

 private bool ValidateCarInputs()
 {
 errorProviderCars.Clear();
 var ok = true;
 if (string.IsNullOrWhiteSpace(textBoxMake.Text))
 {
 errorProviderCars.SetError(textBoxMake, "Make required");
 ok = false;
 }
 if (string.IsNullOrWhiteSpace(textBoxType.Text))
 {
 errorProviderCars.SetError(textBoxType, "Type required");
 ok = false;
 }
 if (numericUpDownRentalPrice.Value <=0)
 {
 errorProviderCars.SetError(numericUpDownRentalPrice, "Rental price must be >0");
 ok = false;
 }
 return ok;
 }

 private async void buttonAdd_Click(object sender, EventArgs e)
 {
 if (!ValidateCarInputs()) return;
 buttonAdd.Enabled = false;
 try
 {
 var make = textBoxMake.Text.Trim();
 var type = textBoxType.Text.Trim();
 var car = new Car
 {
 Make = make,
 Type = type,
 PurchasePrice = numericUpDownPurchasePrice.Value,
 RentalPricePerDay = numericUpDownRentalPrice.Value,
 IsAvailable = true
 };
 _context.Cars.Add(car);
 await _context.SaveChangesAsync();

 dataGridViewCars.DataSource = _context.Cars.Local.ToBindingList();
 MessageBox.Show("Автомобиль добавлен");
 }
 catch (Exception ex)
 {
 MessageBox.Show("Ошибка: " + ex.Message);
 Logger.Error("CarsForm.buttonAdd_Click: " + ex);
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
 if (dataGridViewCars.CurrentRow?.DataBoundItem is Car car)
 {
 var confirm = MessageBox.Show($"Удалить автомобиль {car.Make}?", "Подтвердите", MessageBoxButtons.YesNo);
 if (confirm != DialogResult.Yes) return;

 _context.Cars.Remove(car);
 await _context.SaveChangesAsync();
 dataGridViewCars.DataSource = _context.Cars.Local.ToBindingList();
 }
 }
 catch (Exception ex)
 {
 MessageBox.Show("Ошибка: " + ex.Message);
 Logger.Error("CarsForm.buttonDelete_Click: " + ex);
 }
 }

 private void textBoxFilterMake_TextChanged(object sender, EventArgs e)
 {
 ApplyFilters();
 }

 private void textBoxFilterType_TextChanged(object sender, EventArgs e)
 {
 ApplyFilters();
 }

 private void ApplyFilters()
 {
 var make = textBoxFilterMake.Text.Trim();
 var type = textBoxFilterType.Text.Trim();
 var list = _context.Cars.Local.AsEnumerable();
 if (!string.IsNullOrEmpty(make)) list = list.Where(c => c.Make.IndexOf(make, StringComparison.OrdinalIgnoreCase) >=0);
 if (!string.IsNullOrEmpty(type)) list = list.Where(c => c.Type.IndexOf(type, StringComparison.OrdinalIgnoreCase) >=0);
 dataGridViewCars.DataSource = null;
 dataGridViewCars.DataSource = list.ToList();
 }
 }
}
