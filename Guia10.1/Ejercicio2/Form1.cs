using Ejercicio2.Models;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        CentroDeAtencion centro = new CentroDeAtencion();
        Reclamo reclamo;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrarReclamo_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text;
            string motivo = tbMotivo.Text;

            reclamo = centro.RecibirReclamo(nombre, motivo);

            lbVerReclamos.Items.Add(reclamo);

            tbMotivo.Text = " ";
            tbNombre.Text = " ";
            
        }

        private void btnCrearOrden_Click(object sender, EventArgs e)
        {
            OrdenReparacion orden = centro.ResolverReclamo();
            if(orden!=null)
            lbVerOrdenesAEjecutar.Items.Add(orden);


        }

        private void btnEjecutarOrden_Click(object sender, EventArgs e)
        {
            OrdenReparacion ordenResuelta = centro.EjecutarOrdenDeTrabajo();

            if (ordenResuelta !=null )
            {
                lbVerOrdenesAEjecutar.Items.Remove(ordenResuelta);

            }


        }
    }
}
