using System.Drawing.Drawing2D;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnImprimirNombre_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text;

            tbInvitaciones.Text += $"\r\n{nombre}";

            
            tbNombre.Clear();
        }
    }
}
