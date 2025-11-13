using System;
using System.Windows.Forms;

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

            // Запуск главной формы (если у тебя MainForm в том же namespace)
            Application.Run(new MainForm());
        }
    }
}
