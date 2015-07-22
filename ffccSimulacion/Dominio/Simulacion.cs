using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ffccSimulacion.Dominio
{
    class Simulacion
    {
        /*Datos a persistir.*/
        int idSimulacion;
        int tiempoFinal;

        /*Datos para ejecucion.*/
        Traza traza;
        
        List<Servicio> servicios;

        public Simulacion(int id)
        {
            /*CARGAR SIMULACION*/
            /*Se busca en la Base de Datos la simulacion segun idSimulacion y se obtienen sus propiedades*/
            idSimulacion = id;
            tiempoFinal = 100;
            /*CARGAR TRAZA*/
            /*Se busca en la Base de Datos la traza segun idSimulacion y se obtienen sus propiedades*/
            traza = new Traza();

            /*CARGAR ESTACIONES*/
            /*Se buscan en la Base de Datos todas las estaciones correspondientes a traza.idTraza y se obtienen sus propiedades*/
            Estacion estacion1 = new Estacion();
            Estacion estacion2 = new Estacion();
            Estacion estacion3 = new Estacion();
            //Estacion estacion4 = new Estacion();
            //Estacion estacion5 = new Estacion();

            traza.agregarNodo(estacion1);
            traza.agregarNodo(estacion2);
            traza.agregarNodo(estacion3);
            /*traza.agregarNodo(estacion4);
            traza.agregarNodo(estacion5);*/

            /*CARGAR RELACIONES*/
            /*Se buscan en la Base de Datos todos los servicios correspondientes a la idSimulacion y se obtienen sus propiedades.*/
            Relacion relacion1 = new Relacion(estacion1, estacion2);
            Relacion relacion2 = new Relacion(estacion2, estacion3);
            /*Relacion relacion3 = new Relacion(estacion3, estacion4);
            Relacion relacion4 = new Relacion(estacion4, estacion5);
            */
            traza.relacionarNodos(relacion1);
            traza.relacionarNodos(relacion2);
            /*traza.relacionarNodos(relacion3);
            traza.relacionarNodos(relacion4);
            */
            /*CARGAR SERVICIOS*/
            /*Se buscan en la Base de Datos todos los servicios correspondientes a la idSimulacion y se configuran apropiadamente.*/
            servicios = new List<Servicio>();

            Servicio servicio1 = new Servicio(estacion1, estacion3);
            /*Servicio servicio2 = new Servicio(estacion5, estacion1);
            Servicio servicio3 = new Servicio(estacion1, estacion5);
            Servicio servicio4 = new Servicio(estacion5, estacion1);*/
            
            servicio1.agregarParada(estacion1, true);
            servicio1.agregarParada(estacion2, true);
            servicio1.agregarParada(estacion3, true);
            //servicio1.agregarParada(estacion4, true);
            //servicio1.agregarParada(estacion5, true);
            /*
            servicio2.agregarParada(estacion5, true);
            servicio2.agregarParada(estacion4, true);
            servicio2.agregarParada(estacion3, true);
            servicio2.agregarParada(estacion2, true);
            servicio2.agregarParada(estacion1, true);

            servicio3.agregarParada(estacion1, true);
            servicio3.agregarParada(estacion2, false);
            servicio3.agregarParada(estacion3, true);
            servicio3.agregarParada(estacion4, false);
            servicio3.agregarParada(estacion5, true);

            servicio4.agregarParada(estacion5, true);
            servicio4.agregarParada(estacion4, false);
            servicio4.agregarParada(estacion3, true);
            servicio4.agregarParada(estacion2, false);
            servicio4.agregarParada(estacion1, true);
            */
            List<int> programacion1 = new List<int>();
            for (int i = 0; i < 100; i += 10)
            {
                int horario = i;
                programacion1.Add(horario);
            }
            servicio1.agregarProgramacionSalida(programacion1);

            /*
            List<int> programacion2 = new List<int>();
            for (int i = 0; i < 1440; i += 10)
            {
                int horario = i;
                programacion2.Add(horario);
            }
            servicio1.agregarProgramacionSalida(programacion2);


            List<int> programacion3 = new List<int>();
            for (int i = 15; i < 1440; i += 20)
            {
                int horario = i;
                programacion3.Add(horario);
            }
            servicio1.agregarProgramacionSalida(programacion3);


            List<int> programacion4 = new List<int>();
            for (int i = 15; i < 1440; i += 20)
            {
                int horario = i;
                programacion4.Add(horario);
            }
            servicio1.agregarProgramacionSalida(programacion4);
            */
            servicios.Add(servicio1);
            /*servicios.Add(servicio2);
            servicios.Add(servicio3);
            servicios.Add(servicio4);
            */
            /*CARGAR FORMACIONES*/
            /*Se buscan en la Base de Datos todas las formaciones correspondientes a cada servicio.idServicio y se obtienen sus propiedades*/
            Formacion formacion1 = new Formacion();
            /*Formacion formacion2 = new Formacion();
            Formacion formacion3 = new Formacion();
            Formacion formacion4 = new Formacion();
            */
            servicio1.formacion = formacion1;
            /*servicio1.formacion = formacion2;
            servicio1.formacion = formacion3;
            servicio1.formacion = formacion4;
            */
            /*CARGAR COCHES*/
            /*Se buscan en la Base de Datos todos los coches correspondientes a cada formacion.idFormacion y se obtienen sus propiedades.*/
            for (int i = 0; i < 5; i++)
            {
                formacion1.agregarCoche(new Coche(30, 50, 100));
            }
            /*
            for (int i = 0; i < 5; i++)
            {
                formacion2.agregarCoche(new Coche(30, 50, 100));
            }
            for (int i = 0; i < 5; i++)
            {
                formacion3.agregarCoche(new Coche(30, 50, 100));
            }
            for (int i = 0; i < 5; i++)
            {
                formacion4.agregarCoche(new Coche(30, 50, 100));
            }
             */

        }

        public void ejecutarSimulacion(){
            //VARIABLES DE SALIDA
            //TODO variables de salida

            //EJECUCION
            int tiempoActual;
            Servicio servicioActual;
            actualizarSiguienteServicio(out tiempoActual, out servicioActual); //Actualiza el tiempo actual a partir del primer servicio a prestar.
            Console.WriteLine("tiempoActual={0} | tiempoFinal={1}", tiempoActual, tiempoFinal);
            while (tiempoActual < tiempoFinal)
            {
                Nodo nodoActual = servicioActual.desde; //Empiezo en la terminal.
                int tiempoFormacionActual = tiempoActual; //El tren sale a la hora indicada en la programacion del servicio.
                //TODO atencion en la terminal.

                //ATENCION DE UN SERVICIO
                while (nodoActual != servicioActual.hasta)
                {
                    Nodo nodoSiguiente = servicioActual.proximoNodo(nodoActual); //Busco el siguiente nodo en el recorrido.

                    Relacion relacionSiguiente = traza.relacionEntre(nodoActual, nodoSiguiente); //Obtengo el camino a recorrer hasta el proximo nodo.

                    int tiempoViaje = relacionSiguiente.calcularTiempoViaje(); //La relacion me indica el tiempo de viaje.
                    
                    int demoraPorAccidentesEnViaje = relacionSiguiente.demoraPorAccidentes(); //Calculo el tiempo de demora en el viaje.
                    
                    int tiempoLlegadaProximoNodo = tiempoViaje + demoraPorAccidentesEnViaje; //Llego al proximo nodo al sumar el tiempo de viaje y las demoras.

                    int tiempoInicioAtencion = tiempoLlegadaProximoNodo; //Si no hay demoras en la estacion, el tiempo de atencion sera el de llegada, si hay demoras se actualiza.
                    
                    int tiempoAtencion = nodoSiguiente.atenderFormacion(servicioActual.formacion, ref tiempoInicioAtencion);

                    nodoActual = nodoSiguiente; //Actualizo el nodo que será el inicial en la siguiente iteracion.
                    
                    tiempoFormacionActual = tiempoInicioAtencion + tiempoAtencion; //Actualizo el tiempo de la formacion para la siguiente iteracion.

                    Console.WriteLine("tiempoViaje={0} | demoraPorAccidenteEnViaje={1} | tiempoLlegadaProximoNodo={2} | tiempoInicioAtencion={3} | tiempoAtencion={4}", tiempoViaje, demoraPorAccidentesEnViaje, tiempoLlegadaProximoNodo, tiempoInicioAtencion, tiempoAtencion);
                }
                
                actualizarSiguienteServicio(out tiempoActual, out servicioActual); //Actualiza el tiempo actual a partir del proximo servicio a prestar.

                Console.WriteLine("tiempoActual={0}", tiempoActual);
            }
            //TODO faltan las variables de salida
        }

        private void actualizarSiguienteServicio(out int siguienteSalida, out Servicio siguienteServicio)
        {
            /*Actualiza las variables siguienteSalida y siguienteServicio con los valores del proximo servicio a salir.*/
            siguienteServicio = servicios.First();
            siguienteSalida = siguienteServicio.proximoHorarioSalida();
            foreach (Servicio servicio in servicios)
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
    }
}
