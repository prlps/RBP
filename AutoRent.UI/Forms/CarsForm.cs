using System;
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
 await _context.Cars.LoadAsync();
 dataGridViewCars.DataSource = _context.Cars.Local.ToBindingList();
 }

 private async void buttonAdd_Click(object sender, EventArgs e)
 {
 try
 {
 var make = textBoxMake.Text.Trim();
 var type = textBoxType.Text.Trim();
 if (string.IsNullOrEmpty(make) || string.IsNullOrEmpty(type))
 {
 MessageBox.Show("Введите Make и Type для автомобиля.");
 return;
 }

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

 // Refresh binding
 dataGridViewCars.Refresh();
 MessageBox.Show("Автомобиль добавлен");
 }
 catch (Exception ex)
 {
 MessageBox.Show("Ошибка: " + ex.Message);
 Logger.Error("CarsForm.buttonAdd_Click: " + ex);
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
 dataGridViewCars.Refresh();
 }
 }
 catch (Exception ex)
 {
 MessageBox.Show("Ошибка: " + ex.Message);
 Logger.Error("CarsForm.buttonDelete_Click: " + ex);
 }
 }
 }
}
