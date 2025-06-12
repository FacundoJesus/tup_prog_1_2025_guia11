namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int numeroAleatorio = random.Next(1,101);

            lbIngresarNumero.Text = $"{numeroAleatorio}";

        }
    }
}
