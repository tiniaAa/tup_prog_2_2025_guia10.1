using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Despachador
    {
        Repartidor camion { get; set; }
        Queue<Paquete> depositos = new Queue<Paquete>();

        public Paquete RecibirCorrespondencia(int dni, string nombre,string direccion)
        {
            Paquete paquete = new Paquete(dni,nombre,direccion);
            depositos.Enqueue(paquete);
            return paquete;
        }
        public Repartidor PrepararCamion(int capacidad)
        {
            camion = new Repartidor(capacidad);
            return camion;
        } 
        public Paquete CargarPaqueteAlCamion()
        {
            if (camion.TieneCapacidadDisponible()==true)
            {
                Paquete paquete = depositos.Dequeue();

                camion.Cargar(paquete);
                return paquete;
            }
            return null;
        }
    }
}
