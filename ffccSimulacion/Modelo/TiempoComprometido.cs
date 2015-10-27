using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ffccSimulacion.Modelo
{
    public class TiempoComprometido
    {
        private int _tiempoInicial;
        private int _tiempoFinal;
        private int _posServicio = 0;
        private Trazas _traza;
        /*Este diccionario se utiliza para mantener de manera comun los tiempos comprometidos, la gentes esperando y la hora de ultima atencion de todas las
         estaciones que existan en la simulacion. De otra forma cada estacion es una instancia distinta y por lo tanto sus campos son siempre 0 aunque se trate de la misma 
         estacion. Preguntar a Pablo*/
        private Dictionary<int, Estacion_Info> _estaciones_TC = new Dictionary<int, Estacion_Info>();//La clave que se utiliza es el id de la estacion
        private List<ResultadoFormacion> _resultadosFormaciones = new List<ResultadoFormacion>();

        public TiempoComprometido(int tiempoInicial, int tiempoFinal,Trazas unaTraza)
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

        /*El tiempo final se expresa en minutos*/
        public int TiempoFinal
        {
            get { return _tiempoFinal; }
            set { _tiempoFinal = value; }
        }
        
        public Trazas Traza
        {
            get { return _traza; }
            set { _traza = value; }
        }

        public List<ResultadoFormacion> ResultadosFormaciones { get { return _resultadosFormaciones; } }

        #endregion

        #region Metodos

        private ResultadoFormacion CrearEstructResultado(int id, string nombre,int distRecorrida,int pasajerosTotales,int vecesSupLegal,int vecesNoHayPardos,int tiempoIncidente, int tiempoAtencion,int tiempoMovimiento)
        {
            ResultadoFormacion r = new ResultadoFormacion();
            r.id_formacion = id;
            r.nombreFormacion = nombre;
            r.distanciaTotalRecorrida = distRecorrida;
            r.pasajerosTotalesTransportados = pasajerosTotales;
            r.vecesSuperoCapLegal = vecesSupLegal;
            r.vecesNoHabiaPasajerosParados = vecesNoHayPardos;
            r.tiempoTotalDemoradoIncidente = tiempoIncidente;
            r.tiempoTotalDemoradoAtencion = tiempoAtencion;
            r.tiempoTotalEnMovimiento = tiempoMovimiento;

            return r;
        }

        public void EjecutarSimulacion()
        {
            //EJECUCION
            int tiempoActual;
            Formaciones formacionActual;
            Servicios servicioActual;


            //VARIABLES DE SALIDA
            //TODO variables de salida

            int distanciaTotalRecorrida = 0;
            int pasajerosTotalesTransportados = 0;
            int vecesSupCapLegal = 0;
            int vecesNoHabiaPasajerosParados = 0;
            int tiempoTotalDemoraIncidente = 0;
            int tiempoTotalDemoraAtencion = 0;
            int tiempoTotalEnMovimiento = 0;

            actualizarSiguienteServicio(out tiempoActual, out servicioActual); //Actualiza el tiempo actual a partir del primer servicio a prestar.
            formacionActual = servicioActual.GetFormacionRandom(); //Se asigna la formacion que realizara el servicio actual

            Console.WriteLine("tiempoActual={0} | tiempoFinal={1}", tiempoActual, TiempoFinal);

            while (tiempoActual < TiempoFinal)
            {
                Estaciones nodoActual = servicioActual.Desde; //Empiezo en la terminal.
                int tiempoFormacionActual = tiempoActual; //El tren sale a la hora indicada en la programacion del servicio.
                //TODO atencion en la terminal.

                distanciaTotalRecorrida = 0;
                pasajerosTotalesTransportados = 0;
                vecesSupCapLegal = 0;
                vecesNoHabiaPasajerosParados = 0;
                tiempoTotalDemoraIncidente = 0;
                tiempoTotalDemoraAtencion = 0;
                tiempoTotalEnMovimiento = 0;

                //ATENCION DE UN SERVICIO
                while (nodoActual != servicioActual.Hasta)
                {
                    //Estaciones nodoSiguiente = servicioActual.proximoNodo(nodoActual); //Busco el siguiente nodo en el recorrido.
                    
                    //Relaciones relacionSiguiente = servicioActual.relacionEntre(nodoActual, nodoSiguiente); //Obtengo el camino a recorrer hasta el proximo nodo.

                    Relaciones relacionSiguiente = servicioActual.Relaciones.Where(x => x.Id_Estacion_Anterior == nodoActual.Id).First();

                    Estaciones nodoSiguiente = relacionSiguiente.Estaciones1;

                    distanciaTotalRecorrida += relacionSiguiente.Distancia;

                    int tiempoViaje = relacionSiguiente.calcularTiempoViaje(); //La relacion me indica el tiempo de viaje.

                    int demoraPorAccidentesEnViaje = relacionSiguiente.demoraPorAccidentes(); //Calculo el tiempo de demora en el viaje.

                    int tiempoLlegadaProximoNodo = tiempoViaje + demoraPorAccidentesEnViaje; //Llego al proximo nodo al sumar el tiempo de viaje y las demoras.

                    int tiempoInicioAtencion = tiempoLlegadaProximoNodo; //Si no hay demoras en la estacion, el tiempo de atencion sera el de llegada, si hay demoras se actualiza.
                                        
                    if (!_estaciones_TC.ContainsKey(nodoSiguiente.Id))
                    {
                        Estacion_Info ei = new Estacion_Info();
                        ei.id_estacion = nodoSiguiente.Id;
                        ei.tiempo_comprometido = 0;
                        ei.ultima_Atencion = 0;
                        ei.gente_esperando = 0;
                        _estaciones_TC.Add(nodoSiguiente.Id, ei);
                    }

                    Estacion_Info est_info = _estaciones_TC[nodoSiguiente.Id];
                    nodoSiguiente.TiempoComprometido = est_info.tiempo_comprometido;
                    nodoSiguiente.GenteEsperando = est_info.gente_esperando;
                    nodoSiguiente.UltimaAtencion = est_info.ultima_Atencion;

                    int tiempoAtencion = nodoSiguiente.atenderFormacion(formacionActual, ref tiempoInicioAtencion);

                    est_info.tiempo_comprometido = nodoSiguiente.TiempoComprometido;
                    est_info.gente_esperando = nodoSiguiente.GenteEsperando;
                    est_info.ultima_Atencion = nodoSiguiente.UltimaAtencion;
                    _estaciones_TC[nodoSiguiente.Id] = est_info;

                    pasajerosTotalesTransportados += nodoSiguiente.PasajerosQueSubieronAlTren;

                    if (formacionActual.FormacionSuperoCapLegal())
                        vecesSupCapLegal++;

                    if (!formacionActual.HayPasajerosParados())
                        vecesNoHabiaPasajerosParados++;

                    tiempoTotalDemoraAtencion += tiempoAtencion;
                    tiempoTotalDemoraIncidente += demoraPorAccidentesEnViaje;
                    tiempoTotalEnMovimiento += tiempoViaje;

                    nodoActual = nodoSiguiente; //Actualizo el nodo que será el inicial en la siguiente iteracion.

                    tiempoFormacionActual = tiempoInicioAtencion + tiempoAtencion; //Actualizo el tiempo de la formacion para la siguiente iteracion.

                    Console.WriteLine("tiempoViaje={0} | demoraPorAccidenteEnViaje={1} | tiempoLlegadaProximoNodo={2} | tiempoInicioAtencion={3} | tiempoAtencion={4}", tiempoViaje, demoraPorAccidentesEnViaje, tiempoLlegadaProximoNodo, tiempoInicioAtencion, tiempoAtencion);
                }
                
                ResultadoFormacion nuevoResultado = CrearEstructResultado(formacionActual.Id,formacionActual.NombreFormacion, distanciaTotalRecorrida, pasajerosTotalesTransportados, vecesSupCapLegal, vecesNoHabiaPasajerosParados, tiempoTotalDemoraIncidente, tiempoTotalDemoraAtencion, tiempoTotalEnMovimiento);
                _resultadosFormaciones.Add(nuevoResultado);
                actualizarSiguienteServicio(out tiempoActual, out servicioActual); //Actualiza el tiempo actual a partir del proximo servicio a prestar.
                formacionActual = servicioActual.GetFormacionRandom(); //Se asigna la formacion que realizara el servicio actual

                Console.WriteLine("tiempoActual={0}", tiempoActual);
            }
            //TODO faltan las variables de salida
        }

        private void actualizarSiguienteServicio(out int siguienteSalida, out Servicios siguienteServicio)
        {
            if (_posServicio > Traza.ServiciosDisponibles.Count - 1)
                _posServicio = 0;
            siguienteServicio = Traza.ServiciosDisponibles[_posServicio];
            _posServicio++;
            siguienteSalida = siguienteServicio.proximoHorarioSalida();

            /*Actualiza las variables siguienteSalida y siguienteServicio con los valores del proximo servicio a salir. */
            /*siguienteServicio = Traza.ServiciosDisponibles.First();
            siguienteSalida = siguienteServicio.proximoHorarioSalida();
            foreach (Servicios servicio in Traza.ServiciosDisponibles)
            {
                int salidaAux = servicio.proximoHorarioSalida();
                if (salidaAux < siguienteSalida)
                {
                    siguienteServicio = servicio;
                    siguienteSalida = salidaAux;
                }
            }*/
            siguienteServicio.removerSalida(siguienteSalida); //Al haber usado el horario siguienteSalida lo remuevo del servicio.
        }
        #endregion
    }
}
