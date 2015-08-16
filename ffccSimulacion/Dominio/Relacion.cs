using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ffccSimulacion.Dominio
{
    public class Relacion
    {
        /*Relaciona un unico nodo inicial con un unico nodo siguiente.
         *Contiene indicadores propios del transito entre un nodo y otro.
         */
        public Estacion anterior;
        public Estacion siguiente;

        int distancia;
        int velocidadPromedio;
        int tiempoViaje;
        List<Incidente> incidentesPosibles = new List<Incidente>();

        public Relacion(Estacion nodoAnterior, Estacion nodoSiguiente)
        {
            anterior = nodoAnterior;
            siguiente = nodoSiguiente;
            distancia = 0;
            velocidadPromedio = 1;
            tiempoViaje = 10;
        }

        public Relacion(Estacion nodoAnterior, Estacion nodoSiguiente, int tiempoViaje)
        {
            anterior = nodoAnterior;
            siguiente = nodoSiguiente;
            distancia = 0;
            velocidadPromedio = 1;
            this.tiempoViaje = tiempoViaje;
        }

        public void agregarIncidentePosible(Incidente incidentePosible)
        {
            incidentesPosibles.Add(incidentePosible);
        }

        public bool relaciona(Estacion nodoInicial, Estacion nodoFinal)
        {
            //TODO Revisar si la relacion es bidireccional.
            if ((anterior == nodoInicial && siguiente == nodoFinal) || (anterior == nodoFinal && siguiente == nodoInicial))
            {
                return true;
            }
            return false;
        }

        public int calcularTiempoViaje()
        {
            //TODO Modificar
            return tiempoViaje;
        }

        public int demoraPorAccidentes()
        {
            int totalDemora = 0;
            foreach (Incidente incidentePosible in incidentesPosibles)
            {
                if (incidentePosible.Ocurre())
                {
                    totalDemora += incidentePosible.TiempoDemora;
                }
            }
            return totalDemora;
        }
    }
}
