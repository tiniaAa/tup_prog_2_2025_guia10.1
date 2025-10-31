using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    public class OrdenReparacion
    {
        public DateTime Fecha { get; set; }
        public bool Solucionado { get; set; }
        public Reclamo Reclamo { get; set; }
        public OrdenReparacion(Reclamo reclamo)
        {
            this.Reclamo = reclamo;
            this.Fecha = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{Reclamo}";
        }
    }
}
