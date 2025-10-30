using Ejercicio1.Models;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        Despachador deposito = new Despachador();
        Repartidor camion;
        public Form1()
        {

            InitializeComponent();

            btnIniciarReparto.Enabled = false;
            btnEntregarPaquete.Enabled = false;

        }

        private void btnRecibir_Click(object sender, EventArgs e)
        {
            int dni = Convert.ToInt32(tbDNI.Text);
            string nombre = tbNombre.Text;
            string direccion = tbDireccion.Text;

            Paquete paquete = deposito.RecibirCorrespondencia(dni, nombre, direccion);

            lbxVerSectorCarga.Items.Add(paquete);

            tbDireccion.Text = " ";
            tbDNI.Text = " ";
            tbNombre.Text = " ";
        }

        private void btnPreparar_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            if (form2.ShowDialog() == DialogResult.OK)
            {
                int capacidad = Convert.ToInt32(form2.tbCapacidad.Text);

                camion = deposito.PrepararCamion(capacidad);

                Paquete paquete = deposito.CargarPaqueteAlCamion();
                lbxListadoAentregar.Items.Clear();
                while (paquete != null)
                {
                    lbxListadoAentregar.Items.Add(paquete);

                    lbxVerSectorCarga.Items.Remove(paquete);

                    paquete = deposito.CargarPaqueteAlCamion();

                }
                btnIniciarReparto.Enabled = true;
            }
        }

        private void btnIniciarReparto_Click(object sender, EventArgs e)
        {
            btnEntregarPaquete.Enabled = true;

            Paquete paquete = camion.Revisar();
            if (paquete != null)
            {
                tbDNI2.Text = paquete.DNIremitente.ToString();
                tbNombre2.Text = paquete.NombreRemitente;
                tbDireccion2.Text = paquete.Direccion;

                btnIniciarReparto.Enabled = false;
            }

        }

        private void btnEntregarPaquete_Click(object sender, EventArgs e)
        {
            Paquete paquete =camion.Descargar();
            lbxListadoAentregar.Items.Remove(paquete);

            paquete = camion.Revisar();
            if (paquete!=null)
            {
                    tbDNI2.Text = paquete.DNIremitente.ToString();
                    tbNombre2.Text = paquete.NombreRemitente;
                    tbDireccion2.Text = paquete.Direccion;
            }
            else
            {
                tbDNI2.Text = "";
                tbNombre2.Text = "";
                tbDireccion2.Text = "";
                btnIniciarReparto.Enabled = true;
                btnEntregarPaquete.Enabled = false;
            }
        }
    }
}
