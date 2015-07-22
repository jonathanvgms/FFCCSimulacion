using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ffccSimulacion.Dominio
{
    class Estacion : Nodo
    {
        int genteEsperando;
        int ultimaAtencion;
        int tiempoComprometido; //TODO Analizar si no es necesario manejar una lista de tiempos comprometidos.
        List<Incidente> incidentesPosibles;
        public Estacion()
        {
            genteEsperando = 0;
            ultimaAtencion = 0;
            tiempoComprometido = 0;
            incidentesPosibles = new List<Incidente>();
        }

        public override int atenderFormacion(Formacion formacion, ref int tiempoLlegada)
        {
            //CALCULO LA LLEGADA
            if (tiempoComprometido < tiempoLlegada)
            {
                tiempoComprometido = tiempoLlegada;
            }
            else
            {
                tiempoLlegada = tiempoComprometido; //El tiempo de llegada se actualiza.
            }

            //ATIENDO LOS PASAJEROS
            actualizarGenteEsperando(tiempoLlegada);

            genteEsperando = formacion.recibir(genteEsperando);

            //ACTUALIZO EL TIEMPO COMPROMETIDO Y LA ULTIMA ATENCION
            tiempoComprometido += tiempoAtencion();
            ultimaAtencion = tiempoComprometido; //Por ahora son iguales.

            //RETORNO EL TIEMPO DE ATENCION EN LA ESTACION
            return tiempoAtencion();
        }

        private void actualizarGenteEsperando(int tiempoActual)
        {
            //Calculo de la gente que hay esperando en la estacion.
            genteEsperando += 20 * (tiempoActual - ultimaAtencion);
        }

        private int tiempoAtencion()
        {
            //Calculo del tiempo de atencion en la estacion.
            return 5;
        }
    }
}
