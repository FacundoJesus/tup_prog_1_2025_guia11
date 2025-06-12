namespace Ejercicio9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cmbServicios.SelectedIndex != -1)
            {

                string servicioSeleccionado = cmbServicios.SelectedItem.ToString();

                lsbServiciosElegidos.Items.Add(servicioSeleccionado);
            }


        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (lsbServiciosElegidos.SelectedIndex != -1)
            {
                lsbServiciosElegidos.Items.RemoveAt(lsbServiciosElegidos.SelectedIndex);
            }

        }
    }
}
