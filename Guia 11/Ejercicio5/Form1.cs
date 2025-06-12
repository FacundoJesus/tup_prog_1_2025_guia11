namespace Ejercicio5
{
    public partial class Form1 : Form
    {
        int contadorTotal = 0;
        int contadorExcelentes = 0;
        int contadorBuenos = 0;
        int contadorInsuficientes = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnVotar_Click(object sender, EventArgs e)
        {
            if (rbExcelente.Checked) {
                contadorExcelentes++;
                
                lbExcelentes.Text = $"{contadorExcelentes}";
            }
            else
            if (rbBueno.Checked) {
                
                contadorBuenos++;

                lbBuenos.Text = $"{contadorBuenos}";
            }
            else
            if (rbInsuficiente.Checked) {
            
                contadorInsuficientes++;
                lbInsuficientes.Text = $"{contadorInsuficientes}";
            }
            contadorTotal++;
            lbTotal.Text = $"{contadorTotal}";
        }
    }
}
