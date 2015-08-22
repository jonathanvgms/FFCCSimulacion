using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ffccSimulacion.Dominio
{
    class TiempoComprometido : ITiempoComprometido
    {
        private int _tiempoInicial;
        private int _tiempoFinal;
        private Traza _traza;

        public TiempoComprometido(int tiempoInicial, int tiempoFinal,Traza unaTraza)
        {
            TiempoInicial = tiempoInicial;
            TiempoFinal = tiempoFinal;
            Traza = unaTraza;
        }

        #region Propiedades

        public int TiempoInicial
        {
            get { return _tiempoInicial; }
            set { _tiempoInicial = value; }
        }

        public int TiempoFinal
        {
            get { return _tiempoFinal; }
            set { _tiempoFinal = value; }
        }
        
        public Traza Traza
        {
            get { return _traza; }
            set { _traza = value; }
        }

        #endregion

        #region Metodos

        public void EjecutarSimulacion()
        {
            //VARIABLES DE SALIDA
            //TODO variables de salida

            //EJECUCION
            int tiempoActual;
            Formacion formacionActual;
            Servicio servicioActual;

            actualizarSiguienteServicio(out tiempoActual, out servicioActual); //Actualiza el tiempo actual a partir del primer servicio a prestar.
            formacionActual = servicioActual.GetFormacionRandom(); //Se asigna la formacion que realizara el servicio actual

            Console.WriteLine("tiempoActual={0} | tiempoFinal={1}", tiempoActual, TiempoFinal);

            while (tiempoActual < TiempoFinal)
            {
                Estacion nodoActual = servicioActual.Desde; //Empiezo en la terminal.
                int tiempoFormacionActual = tiempoActual; //El tren sale a la hora indicada en la programacion del servicio.
                //TODO atencion en la terminal.

                //ATENCION DE UN SERVICIO
                while (nodoActual != servicioActual.Hasta)
                {
                    Estacion nodoSiguiente = servicioActual.proximoNodo(nodoActual); //Busco el siguiente nodo en el recorrido.

                    Relacion relacionSiguiente = servicioActual.relacionEntre(nodoActual, nodoSiguiente); //Obtengo el camino a recorrer hasta el proximo nodo.

                    int tiempoViaje = relacionSiguiente.calcularTiempoViaje(); //La relacion me indica el tiempo de viaje.

                    int demoraPorAccidentesEnViaje = relacionSiguiente.demoraPorAccidentes(); //Calculo el tiempo de demora en el viaje.

                    int tiempoLlegadaProximoNodo = tiempoViaje + demoraPorAccidentesEnViaje; //Llego al proximo nodo al sumar el tiempo de viaje y las demoras.

                    int tiempoInicioAtencion = tiempoLlegadaProximoNodo; //Si no hay demoras en la estacion, el tiempo de atencion sera el de llegada, si hay demoras se actualiza.

                    int tiempoAtencion = nodoSiguiente.atenderFormacion(formacionActual, ref tiempoInicioAtencion);

                    nodoActual = nodoSiguiente; //Actualizo el nodo que será el inicial en la siguiente iteracion.

                    tiempoFormacionActual = tiempoInicioAtencion + tiempoAtencion; //Actualizo el tiempo de la formacion para la siguiente iteracion.

                    Console.WriteLine("tiempoViaje={0} | demoraPorAccidenteEnViaje={1} | tiempoLlegadaProximoNodo={2} | tiempoInicioAtencion={3} | tiempoAtencion={4}", tiempoViaje, demoraPorAccidentesEnViaje, tiempoLlegadaProximoNodo, tiempoInicioAtencion, tiempoAtencion);
                }

                actualizarSiguienteServicio(out tiempoActual, out servicioActual); //Actualiza el tiempo actual a partir del proximo servicio a prestar.
                formacionActual = servicioActual.GetFormacionRandom(); //Se asigna la formacion que realizara el servicio actual

                Console.WriteLine("tiempoActual={0}", tiempoActual);
            }
            //TODO faltan las variables de salida
        }

        private void actualizarSiguienteServicio(out int siguienteSalida, out Servicio siguienteServicio)
        {
            /*Actualiza las variables siguienteSalida y siguienteServicio con los valores del proximo servicio a salir. */
            siguienteServicio = Traza.ServiciosOtorgados.First();
            siguienteSalida = siguienteServicio.proximoHorarioSalida();
            foreach (Servicio servicio in Traza.ServiciosOtorgados)
            {
                int salidaAux = servicio.proximoHorarioSalida();
                if (salidaAux < siguienteSalida)
                {
                    siguienteServicio = servicio;
                    siguienteSalida = salidaAux;
                }
            }
            siguienteServicio.removerSalida(siguienteSalida); //Al haber usado el horario siguienteSalida lo remuevo del servicio.
        }

        #endregion
    }
}
