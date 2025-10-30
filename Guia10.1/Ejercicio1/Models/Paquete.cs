using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Paquete
    {
        public int DNIremitente { get; set; }
        public string NombreRemitente { get; set;  }
        public string Direccion { get; set; }

        public Paquete(int dni, string nombre, string direccion) 
        {
            this.DNIremitente=dni;
            this.NombreRemitente=nombre;
            this.Direccion=direccion;
        }
        public override string ToString()
        {
            return $"{DNIremitente}-{NombreRemitente}-{Direccion}";
        }

    }
}
