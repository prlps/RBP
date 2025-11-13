using System.Windows.Forms;

namespace AutoRent.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // Настройка формы после инициализации компонентов
            this.Text = "AutoRent";
            this.Width = 800;
            this.Height = 600;
        }
    }
}
