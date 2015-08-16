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
            /*Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());         */   
            Simulacion simulador = new Simulacion(1);
            simulador.EstrategiaDeSimulacion = new TiempoComprometido(0, 100);
            simulador.EjecutarSimulacion();   
        }
    }
}
