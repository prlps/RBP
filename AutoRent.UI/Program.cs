using System;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using AutoRent.Data;
using AutoRent.Data.Models;

namespace AutoRent.UI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Классический и совместимый код инициализации WinForms
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var options = new DbContextOptionsBuilder<AutoRentContext>()
                .UseSqlite("Data Source=autorent.db")
                .Options;

            using (var context = new AutoRentContext(options))
            {
                // Ensure database and seed data
                try
                {
                    context.Database.Migrate();
                    SeedData.Initialize(context);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка инициализации БД: " + ex.Message);
                }
            }

            // Create context again for UI lifetime
            var uiOptions = new DbContextOptionsBuilder<AutoRentContext>()
                .UseSqlite("Data Source=autorent.db")
                .Options;
            var uiContext = new AutoRentContext(uiOptions);

            // Запуск главной формы (если у тебя MainForm в том же namespace)
            Application.Run(new MainForm(uiContext));
        }
    }
}
