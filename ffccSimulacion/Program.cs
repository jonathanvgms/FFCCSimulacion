using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ffccSimulacion.Dominio;
using ffccSimulacion.Dominio.DataBase;
using System.Windows.Forms;

namespace ffccSimulacion
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*DataBaseManager db = new DataBaseManager();
            db.PruebasBD();*/
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Escritorio());
            //Simulacion simulador = new Simulacion(1);
            //simulador.EstrategiaDeSimulacion = new TiempoComprometido(0, 100);
            //simulador.EjecutarSimulacion();   
        }

        public static void PruebaSimuladorSinBd()
        {
            int _tiempoInicial = 0;
            int _tiempoFinal = 100;
            int _frecuenciaSalida = 10;

            Formacion formacion1 = new Formacion("FormacionPrueba");
            formacion1.agregarCoche(new Coche("", false, TipoConsumo.Disel, 0, 0, 30, 50, 100), 5);
            formacion1.CargarCochesDeLaFormacion();

            Estacion estacion1 = new Estacion("Estacion1", 50, 200, TipoFDP.Normal);
            Estacion estacion2 = new Estacion("Estacion2", 50, 200, TipoFDP.Normal);
            Estacion estacion3 = new Estacion("Estacion3", 50, 200, TipoFDP.Normal);

            Relacion relacion1 = new Relacion(estacion1, estacion2, 0, 1, 10, 1);
            Relacion relacion2 = new Relacion(estacion2, estacion3, 0, 1, 10, 1);

            Servicio servicio1 = new Servicio("Servicio1", estacion1, estacion3);
            servicio1.agregarParada(estacion1, true);
            servicio1.agregarParada(estacion2, true);
            servicio1.agregarParada(estacion3, true);
            servicio1.Relaciones.Add(relacion1);
            servicio1.Relaciones.Add(relacion2);
            servicio1.AgregarFormacionDispoble(formacion1);

            Traza _traza = new Traza("TrazaPrueba");
            _traza.AgregarServicio(servicio1);

            Simulacion simulador = new Simulacion("simulacionPrueba", _tiempoInicial, _tiempoFinal, _traza, _frecuenciaSalida);
            simulador.EjecutarSimulacion();
        }
    }
}
