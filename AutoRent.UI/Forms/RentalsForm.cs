using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoRent.Data;
using AutoRent.Data.Models;
using AutoRent.Services;
using Microsoft.EntityFrameworkCore;

namespace AutoRent.UI.Forms
{
 public partial class RentalsForm : Form
 {
 private readonly AutoRentContext _context;
 private readonly RentalService _rentalService;

 public RentalsForm(AutoRentContext context)
 {
 _context = context;
 _rentalService = new RentalService(_context);
 InitializeComponent();

 comboBoxCars.SelectedIndexChanged += ComboBoxCars_SelectedIndexChanged;
 }

 private async void RentalsForm_Load(object sender, EventArgs e)
 {
 try
 {
 await LoadDataAsync();
 }
 catch (Exception ex)
 {
 MessageBox.Show("Ошибка при загрузке данных: " + ex.Message);
 Logger.Error("RentalsForm.LoadDataAsync: " + ex);
 }
 }

 private async Task LoadDataAsync()
 {
 await _context.Cars.LoadAsync();
 await _context.Clients.LoadAsync();
 await _context.Rentals.Include(r => r.Car).Include(r => r.Client).LoadAsync();

 // Привязка к DataGridView и ComboBox
 dataGridViewRentals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
 dataGridViewRentals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
 dataGridViewRentals.MultiSelect = false;
 dataGridViewRentals.ReadOnly = true;

 comboBoxCars.DisplayMember = "Make";
 comboBoxClients.DisplayMember = "LastName";

 dataGridViewRentals.DataSource = _context.Rentals.Local.ToBindingList();
 comboBoxCars.DataSource = _context.Cars.Local.ToBindingList();
 comboBoxClients.DataSource = _context.Clients.Local.ToBindingList();
 }

 private void ComboBoxCars_SelectedIndexChanged(object? sender, System.EventArgs e)
 {
 if (comboBoxCars.SelectedItem is Car car)
 {
 numericUpDownPricePerDay.Value = car.RentalPricePerDay;
 }
 }

 private async void buttonCreate_Click(object sender, System.EventArgs e)
 {
 buttonCreate.Enabled = false;
 try
 {
 if (comboBoxCars.SelectedItem is not Car car || comboBoxClients.SelectedItem is not Client client)
 {
 MessageBox.Show("Выберите автомобиль и клиента.");
 return;
 }

 var dateOut = dateTimePickerDateOut.Value.Date;
 var plannedReturn = dateTimePickerPlannedReturn.Value.Date;
 if (plannedReturn < dateOut)
 {
 MessageBox.Show("Планируемая дата возврата должна быть позже даты выдачи.");
 return;
 }
 var price = numericUpDownPricePerDay.Value;
 if (price <=0)
 {
 MessageBox.Show("Цена в день должна быть больше0.");
 return;
 }

 // optional quick check of availability flag
 if (!car.IsAvailable)
 {
 var ok = MessageBox.Show("Автомобиль помечен как недоступный. Попробовать создать аренду?", "Подтвердите", MessageBoxButtons.YesNo);
 if (ok != DialogResult.Yes) return;
 }

 var rental = await _rentalService.CreateRentalAsync(car.CarId, client.ClientId, dateOut, plannedReturn, price, textBoxNotes.Text);
 if (rental == null)
 {
 MessageBox.Show("Автомобиль недоступен в выбранный период.");
 return;
 }

 MessageBox.Show("Аренда создана");
 await RefreshListAsync();
 }
 catch (System.Exception ex)
 {
 MessageBox.Show("Ошибка: " + ex.Message);
 Logger.Error("RentalsForm.buttonCreate_Click: " + ex);
 }
 finally
 {
 buttonCreate.Enabled = true;
 }
 }

 private async void buttonClose_Click(object sender, System.EventArgs e)
 {
 buttonClose.Enabled = false;
 try
 {
 if (dataGridViewRentals.CurrentRow?.DataBoundItem is Rental rental)
 {
 var actualReturn = dateTimePickerActualReturn.Value.Date;
 if (actualReturn < rental.DateOut)
 {
 MessageBox.Show("Фактическая дата возврата не может быть раньше даты выдачи.");
 return;
 }
 await _rentalService.CloseRentalAsync(rental.RentalId, actualReturn);
 MessageBox.Show("Аренда закрыта");
 await RefreshListAsync();
 }
 }
 catch (System.Exception ex)
 {
 MessageBox.Show("Ошибка: " + ex.Message);
 Logger.Error("RentalsForm.buttonClose_Click: " + ex);
 }
 finally
 {
 buttonClose.Enabled = true;
 }
 }

 private async Task RefreshListAsync()
 {
 // reload fresh data
 await _context.Cars.LoadAsync();
 await _context.Clients.LoadAsync();
 await _context.Rentals.Include(r => r.Client).Include(r => r.Car).LoadAsync();

 dataGridViewRentals.DataSource = _context.Rentals.Local.ToBindingList();
 comboBoxCars.DataSource = _context.Cars.Local.ToBindingList();
 comboBoxClients.DataSource = _context.Clients.Local.ToBindingList();
 }

 private void textBoxFilterClient_TextChanged(object sender, EventArgs e)
 {
 ApplyFilters();
 }

 private void FilterControl_ValueChanged(object sender, EventArgs e)
 {
 ApplyFilters();
 }

 private void ApplyFilters()
 {
 var filter = textBoxFilterClient.Text.Trim();
 var from = dateTimePickerFilterFrom.Value.Date;
 var to = dateTimePickerFilterTo.Value.Date;
 var list = _context.Rentals.Local.AsEnumerable();

 if (!string.IsNullOrEmpty(filter))
 list = list.Where(r => r.Client != null && r.Client.LastName.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >=0);

 // Filter by date: rentals that intersect [from,to] period (DateOut <= to && PlannedReturnDate >= from)
 list = list.Where(r => r.DateOut <= to && r.PlannedReturnDate >= from);

 dataGridViewRentals.DataSource = null;
 dataGridViewRentals.DataSource = list.ToList();
 }
 }
}
