namespace Ejercicio8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (lsbServicios.SelectedIndex != -1) // Asegura que haya un elemento seleccionado
            {
                // Obtener el elemento seleccionado
                string servicioSeleccionado = lsbServicios.SelectedItem.ToString();

                // Agregarlo en otra ListBox
                lsbServiciosElegidos.Items.Add(servicioSeleccionado);

                
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (lsbServiciosElegidos.SelectedIndex != -1) {
         
            lsbServiciosElegidos.Items.RemoveAt(lsbServiciosElegidos.SelectedIndex);
            }
        }
    }
}
