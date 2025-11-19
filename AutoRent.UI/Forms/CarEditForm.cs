using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoRent.Data;
using AutoRent.Data.Models;

namespace AutoRent.UI.Forms
{
 public partial class CarEditForm : Form
 {
 private readonly AutoRentContext _context;
 private readonly Car _car;
 private readonly bool _isNew;

 public CarEditForm(AutoRentContext context, Car? car = null)
 {
 _context = context ?? throw new ArgumentNullException(nameof(context));
 _car = car ?? new Car();
 _isNew = car == null;
 InitializeComponent();
 }

 private void CarEditForm_Load(object sender, EventArgs e)
 {
 textBoxMake.Text = _car.Make;
 textBoxType.Text = _car.Type;
 numericUpDownPurchasePrice.Value = _car.PurchasePrice;
 numericUpDownRentalPrice.Value = _car.RentalPricePerDay;
 checkBoxAvailable.Checked = _car.IsAvailable;
 }

 private void buttonOk_Click(object sender, EventArgs e)
 {
 if (string.IsNullOrWhiteSpace(textBoxMake.Text) || string.IsNullOrWhiteSpace(textBoxType.Text))
 {
 MessageBox.Show("Make and Type required");
 return;
 }

 _car.Make = textBoxMake.Text.Trim();
 _car.Type = textBoxType.Text.Trim();
 _car.PurchasePrice = numericUpDownPurchasePrice.Value;
 _car.RentalPricePerDay = numericUpDownRentalPrice.Value;
 _car.IsAvailable = checkBoxAvailable.Checked;

 if (_isNew)
 {
 _context.Cars.Add(_car);
 }
 else
 {
 _context.Cars.Update(_car);
 }
 DialogResult = DialogResult.OK;
 Close();
 }
 }
}
