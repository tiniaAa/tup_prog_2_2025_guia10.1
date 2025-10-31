using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    public class CentroDeAtencion
    {
        int numeroReclamoGen { get; set;}
        Queue<OrdenReparacion> trabajosPendientes = new Queue<OrdenReparacion>();
        Queue<Reclamo> reclamosPendientes = new Queue<Reclamo>();

        public Reclamo RecibirReclamo(string nombrePersona,string motivo)
        {
            Reclamo nuevo = new Reclamo(++numeroReclamoGen,nombrePersona,motivo);
            reclamosPendientes.Enqueue(nuevo);
            return nuevo;
        }
        public OrdenReparacion ResolverReclamo()
        {
            OrdenReparacion orden = null;
            if (reclamosPendientes.Count > 0) 
            {
                Reclamo resuelto = reclamosPendientes.Dequeue();

                orden = new OrdenReparacion(resuelto);
                trabajosPendientes.Enqueue(orden);
                
                return orden;   
            }
            return null;
        }
        public OrdenReparacion EjecutarOrdenDeTrabajo()
        {
            if (trabajosPendientes.Count>0)
            {
                return trabajosPendientes.Dequeue();

            }
            return null;
        }

    }
}
