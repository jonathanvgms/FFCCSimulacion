using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ffccSimulacion.Dominio;
using ffccSimulacion.Dominio.DataBase;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace ffccSimulacion.Dominio
{
    [Table(Name = "Formaciones_X_Coches")]
    public class Simulacion 
    {
        private int _tiempoFinal;
        private int _tiempoInicial;
        private string _nombre;
        private int _id_TrazaActual;
        private EntityRef<Traza> _trazaActual;
        private int _frecuenciaSalida;
        private IEstrategiaDeSimulador _estrategiaDeSimulacion;

        public Simulacion() { }

        public Simulacion(string nombre, int timpoInicial, int tiempoFinal, Traza unaTraza, int frecuenciaSalida)
        {
            _nombre = nombre;
            _tiempoFinal = tiempoFinal;
            _tiempoInicial = timpoInicial;
            _trazaActual.Entity = unaTraza;
            _frecuenciaSalida = frecuenciaSalida;
        }

        #region Propiedades

        [Column(Name = "Id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        [Column(Name = "Tiempo_Final", DbType = "int", CanBeNull = false)]
        public int TiempoFinal
        {
            get { return _tiempoFinal; }
            set { _tiempoFinal = value; }
        }

        [Column(Name = "Tiempo_Inicial", DbType = "int", CanBeNull = false)]
        public int TiempoInicial
        {
            get { return _tiempoInicial; }
            set { _tiempoInicial = value; }
        }

        [Column(Name = "Nombre", DbType = "varchar(100)", CanBeNull = false)]
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        [Column(Name = "Tiempo_Inicial", DbType = "int", CanBeNull = false)]
        public int FrecuenciaSalida
        {
            get { return _frecuenciaSalida; }
            set { _frecuenciaSalida = value; }
        }

        [Column(Name = "Id_Traza", DbType = "int", CanBeNull = false)]
        public int Id_TrazaActual
        {
            get { return _id_TrazaActual; }
            set { _id_TrazaActual = value; }
        }

        [Association(Storage = "_trazaActual", OtherKey = "Id", ThisKey = "Id_TrazaActual", IsForeignKey = true)]
        public Traza TrazaActual
        {
            get { return _trazaActual.Entity; }
            set { _trazaActual.Entity = value; }
        }

        public IEstrategiaDeSimulador EstrategiaDeSimulacion
        {
            get { return _estrategiaDeSimulacion; }
            set { _estrategiaDeSimulacion = value; }
        }

        #endregion

        #region Metodos

        public void ConfigurarSimulador()
        {
            TrazaActual.CargarLosServicios();
            //Se crea y asgina la programacion de salida para los servicios
            List<int> programacion1 = new List<int>(); 
            for (int i = 0; i < 100; i += _frecuenciaSalida)
                programacion1.Add(i);

            foreach (Servicio s in TrazaActual.ServiciosOtorgados)
                s.agregarProgramacionSalida(programacion1);

            _estrategiaDeSimulacion = new TiempoComprometido(0, _tiempoFinal, TrazaActual);
        }

        public void EjecutarSimulacion()
        {
            EstrategiaDeSimulacion.EjecutarSimulacion();
        }

        #endregion
    }
}
