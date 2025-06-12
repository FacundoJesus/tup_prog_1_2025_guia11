namespace Ejercicio6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResponder_Click(object sender, EventArgs e)
        {
            if (chbOpcion1.Checked && chbOpcion2.Checked) {
                lbResultado.Text = $@"Respuesta Incorrecta:
No siemppre se debe inicializar. Falso.
Nunca debe inicializarse. Falso.
Siempre debe inicializarse. Verdadero.";
            }
            else
            if (chbOpcion1.Checked || chbOpcion2.Checked) {
                lbResultado.Text = $@"Respuesta Incorrecta:
No siemppre se debe inicializar. Falso.
Nunca debe inicializarse. Falso.
Siempre debe inicializarse. Verdadero.";
            }
            else
            if (chbOpcion3.Checked)
            {
                lbResultado.Text = $@"Respuesta Correcta:
Siempre debe inicializarse. Verdadero.";
            }
        
        }
    }
}
