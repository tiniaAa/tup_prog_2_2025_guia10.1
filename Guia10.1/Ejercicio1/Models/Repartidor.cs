using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Repartidor
    {
        public int Capacidad { get;private set; }
        public int Ocupacion { get { return entregas.Count(); } }
        
        Stack<Paquete> entregas = new Stack<Paquete>();

        public Repartidor(int capacidad) 
        {
            this.Capacidad = capacidad;
        }
        public Paquete Revisar()
        {
            if (entregas.Count()>0)
            {
                Paquete paquete =entregas.Peek();

            }
            return null ;
        }
        public void Cargar(Paquete paquete )
        {
            if (TieneCapacidadDisponible() == true)
            {
                entregas.Push(paquete);
            }

        }
        public Paquete Descargar()
        {
            if (entregas.Count>0)
            {
                return entregas.Pop();

            }
            return null;
        }
        public bool TieneCapacidadDisponible() 
        {
            if (Capacidad - Ocupacion > 0) { return true; } 
            return false;
        }
    }
}
