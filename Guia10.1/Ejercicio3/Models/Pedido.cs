using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.Models
{
    public class Pedido
    {
        public string Telefono { get; private set; }
        public string Direccion { get; private set; }

        public Pedido(string telefono, string direccion) 
        {
            this.Direccion = direccion;
            this.Telefono = telefono;
        }
        public override string ToString()
        {
            return $"Telefono:{Telefono}- Direccion:{Direccion}";
        }
    }
}
