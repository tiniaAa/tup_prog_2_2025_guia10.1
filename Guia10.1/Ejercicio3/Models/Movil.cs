using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.Models
{
    public class Movil:IComparable
    {
        public int Numero { get; private set; }
        public Pedido Pasajero { get; set;   }

        public Movil(int numero) 
        {
            this.Numero = numero;
        }

        public int CompareTo(object? obj)
        {
            Movil movil = obj as Movil;
            if (movil!=null)
            {
                return Numero.CompareTo(movil.Numero);
            }
            return -1;
        }
    }
}
