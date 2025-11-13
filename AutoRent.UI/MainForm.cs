using System;
using System.Windows.Forms;
using AutoRent.Data;
using AutoRent.UI.Forms;

namespace AutoRent.UI
{
    public partial class MainForm : Form
    {
        private readonly AutoRentContext _context;

        public MainForm(AutoRentContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));

            InitializeComponent();

            // Настройка формы после инициализации компонентов
            this.Text = "AutoRent";
            this.Width =1000;
            this.Height =700;

            var btnRentals = new Button { Text = "Rentals", Left =10, Top =10 };
            btnRentals.Click += (s, e) =>
            {
                var f = new RentalsForm(_context);
                f.ShowDialog(this);
            };
            this.Controls.Add(btnRentals);

            var btnCars = new Button { Text = "Cars", Left =100, Top =10 };
            btnCars.Click += (s, e) =>
            {
                var f = new CarsForm(_context);
                f.ShowDialog(this);
            };
            this.Controls.Add(btnCars);

            var btnClients = new Button { Text = "Clients", Left =190, Top =10 };
            btnClients.Click += (s, e) =>
            {
                var f = new ClientsForm(_context);
                f.ShowDialog(this);
            };
            this.Controls.Add(btnClients);

            var btnReports = new Button { Text = "Reports", Left =280, Top =10 };
            btnReports.Click += (s,e) =>
            {
                var f = new ReportsForm(_context);
                f.ShowDialog(this);
            };
            this.Controls.Add(btnReports);
        }
    }
}
