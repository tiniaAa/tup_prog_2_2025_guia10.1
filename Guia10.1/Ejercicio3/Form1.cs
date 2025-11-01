using Ejercicio3.Models;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        CentralTaxis central = new CentralTaxis();

        private void Form1_Load(object sender, EventArgs e)
        {
            nupNumeroVehiculo.Maximum = central.CantidadDisponible;

            for (int n = 0; n < central.CantidadDisponible; n++)
            {
                Movil movil = central.VerificarMovil(n - 1);
                if (movil != null)
                {
                    lbDisponibles.Items.Add(movil);
                }
            }
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            string direccion = tbDireccion.Text;
            string telefono = tbTelefono.Text;

            Pedido pedido = central.RecibirSolucitud(direccion, telefono);

            lbPedidosEntrantes.Items.Add(pedido);


        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {

            Movil movilAsignado = central.AsignarCoche();
            lbDisponibles.Items.Remove(movilAsignado);
            lbOcupados.Items.Add(movilAsignado);
            lbPedidosEntrantes.Items.Remove(movilAsignado.Pasajero);


        }

        private void btnLiberar_Click(object sender, EventArgs e)
        {
            int numCoche = Convert.ToInt32(nupNumeroVehiculo.Value);
            
            Movil liberado =central.LiberarVehiculo(numCoche);

            if (liberado != null)
            {
                lbOcupados.Items.Remove(liberado);
                lbDisponibles.Items.Add(liberado);
            }
        }
    }
}
