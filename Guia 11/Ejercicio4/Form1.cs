namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            int horas = Convert.ToInt32(nudHoras.Value);
            int minutos = Convert.ToInt32(nudMinutos.Value);

            lbMinutos.Text = $"{(horas*60) + minutos}";

            nudHoras.Value = 0;
            nudMinutos.Value = 0;
        }
    }
}
