namespace Ejercicio7
{
    public partial class Form1 : Form
    {
        int cantidadTotal;
        int cantidadExcelente;
        int cantidadBueno;
        int cantidadInsuficiente;
        int cantidadBase;
        int cantidadFull;
        public Form1()
        {
            InitializeComponent();
            cantidadTotal = 0;
            cantidadExcelente = 0;
            cantidadBueno = 0;
            cantidadInsuficiente = 0;
            cantidadFull = 0;
            cantidadBase = 0;
        }

        private void btnVotar_Click(object sender, EventArgs e)
        {
            cantidadTotal++;
            lbTotal.Text = $"{cantidadTotal}";

            if (rbExcelente.Checked) {
                cantidadExcelente++;
                lbExcelentes.Text = $"{cantidadExcelente}";
            }
            else
            if (rbBueno.Checked)
            {
                cantidadBueno++;
                lbBuenos.Text = $"{cantidadBueno}";
            }
            else
            if (rbInsuficiente.Checked)
            {
                cantidadInsuficiente++;
                lbInsuficientes.Text = $"{cantidadInsuficiente}";
            }
            


            if (rbBase.Checked)
            {
                cantidadBase++;
                lbBase.Text = $"{cantidadBase}";
            }
            else
            if (rbFull.Checked)
            {
                cantidadFull++;
                lbFull.Text = $"{cantidadFull}";
            }
            


        }
    }
}
