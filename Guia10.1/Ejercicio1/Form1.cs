using Ejercicio1.Models;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        Despachador deposito = new Despachador();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRecibir_Click(object sender, EventArgs e)
        {
            int dni = Convert.ToInt32(tbDNI.Text);
            string nombre = tbNombre.Text;
            string direccion = tbDireccion.Text;

            deposito.RecibirCorrespondencia(dni,nombre,direccion);

        }
    }
}
