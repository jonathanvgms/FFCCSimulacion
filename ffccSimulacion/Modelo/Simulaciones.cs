//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ffccSimulacion.Modelo
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    
    public partial class Simulaciones
    {
        private List<ResultadoFormacion> _resultadosFormacionesSimulacion;

        public Simulaciones(){}

        public int Id { get; set; }
        public int Tiempo_Inicial { get; set; }
        public int Tiempo_Final { get; set; }
        public int Id_Traza { get; set; }
        public int Frecuencia_Salida { get; set; }
        public string Nombre { get; set; }

        public int _estrategiaDeSimulacion { get; set; }
    
        public virtual Trazas Trazas { get; set; }

        public List<ResultadoFormacion> ResultadosFormacionesSimulacion { get { return _resultadosFormacionesSimulacion; } }

        /*Este metodo configura todas las listas y propiedades del escenario que se va a simular por lo tento es necesario ejecutar este metodo antes de 
         correr la simulacion propiamente dicha*/
        public void ConfigurarSimulador()
        {
            Trazas.ConfigurarLosServiciosDeLaTraza();
            //Se crea y asgina la programacion de salida para los servicios
            List<int> programacion1 = new List<int>();
            for (int i = 0; i < Tiempo_Final; i += Frecuencia_Salida)
                programacion1.Add(i);

            foreach (Trazas_X_Servicios ts in Trazas.Trazas_X_Servicios)
                ts.Servicios.agregarProgramacionSalida(programacion1);

            _estrategiaDeSimulacion = 0;
        }

        public void EjecutarSimulacion()
        {
            /*Esta validaciones son necesarias porque antes de ejecutar el algoritmo de simulacion es necesario configurar el entorno*/
            string errorMsj = "";
            if (this.Trazas == null)
                errorMsj += "El simulador no tiene una traza asignada.\n";
            if (this.Tiempo_Final == 0)
                errorMsj += "No hay asignado ningún tiempo de simulación.\n";
            if (this.Frecuencia_Salida == 0)
                errorMsj += "No hay asignado ningún tiempo de frecuencia de salida.\n";

            if(string.IsNullOrEmpty(errorMsj))
            {
               try
               {
                   this.ConfigurarSimulador();
               }
               catch (Exception exc)
               {
                   MessageBox.Show("Ocurrió un error durante el proceso de configuración del escenario.\n" + exc.ToString());
                   return;
               }
            }
            else
            {
                MessageBox.Show(errorMsj);
                return;
            }

            switch (_estrategiaDeSimulacion)
            {
                case(0):
                    TiempoComprometido tiempoComprometido = new TiempoComprometido(0, Tiempo_Final, Trazas);
                    tiempoComprometido.EjecutarSimulacion();
                    _resultadosFormacionesSimulacion = tiempoComprometido.ResultadosFormaciones;
                    //MessageBox.Show("Done !");
                    break;
                case(1):
                    //Evento a evento
                    break;
            }
        }
    }
}
