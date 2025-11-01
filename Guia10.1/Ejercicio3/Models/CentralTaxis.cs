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
            for (int n=0; n<=10; n++)
            {
                movilesDisponibles.Enqueue(new Movil(n));
            }
        }
        public int CantidadDisponible { get { return movilesDisponibles.Count(); } }


        public Pedido RecibirSolucitud(string direccion, string telefono)
        {
           Pedido pedido = new Pedido(telefono,direccion);

           pedidos.Enqueue(pedido);
            
            return pedido;

        }
        public Movil VerificarMovil(int n)
        {
            Movil movilDisponible = null;
            if (n>0 && n<CantidadDisponible)
            {
                movilDisponible = movilesDisponibles.ToArray()[n];
                return movilDisponible;
            }
            return movilDisponible;

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
        public Movil LiberarVehiculo(int numero)
        {
            LinkedListNode<Movil> nodo = movilesOcupados.First;

            while (nodo != null)
            {
                if (nodo.Value.Numero == numero)
                {
                    
                    Movil movilLibre = nodo.Value;
                    movilLibre.Pasajero = null;
                    movilesDisponibles.Enqueue(movilLibre);

                    
                    movilesOcupados.Remove(nodo);

                    return movilLibre;
                }
                nodo = nodo.Next;
            }
            return null;
        }
    }
}
