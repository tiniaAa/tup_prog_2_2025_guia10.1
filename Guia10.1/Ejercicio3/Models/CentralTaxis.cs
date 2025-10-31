using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.Models
{
    public class CentralTaxis
    {
        Queue<Movil> movilesDisponibles = new Queue<Movil>();
        LinkedList<Movil> movilesOcupados = new LinkedList<Movil>();

        Queue<Pedido> pedidos = new Queue<Pedido>();

        public CentralTaxis()
        {
            for (int n=0; n<4;n++)
            {
                movilesDisponibles.Enqueue(new Movil(n));
            }
        }
        public int CantidadDisponible { get {return movilesDisponibles.Count() } }

        public Pedido RecibirSolucitud(string direccion, string telefono)
        {
           Pedido pedido = new Pedido(telefono,direccion);

           pedidos.Enqueue(pedido);
            
            return pedido;

        }
        public Movil AsignarCoche()
        {
            if (movilesDisponibles.Count>0 && pedidos.Count>0)
            {
                Movil movilDisponible = movilesDisponibles.Dequeue();

                Pedido pedidoAAsignar = pedidos.Dequeue();

                movilDisponible.Pasajero = pedidoAAsignar;

                movilesOcupados.AddFirst(movilDisponible);
                return movilDisponible;  
            }
            return null;
        }
        public void LiberarVehiculo(int numero)
        {

            Movil MoviLibre = null;

            LinkedList<Movil> nodo = movilesOcupados.First as Movil ;
            while ()
            {

            }

        }

       
    }
}
