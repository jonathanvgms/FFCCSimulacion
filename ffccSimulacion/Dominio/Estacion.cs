using ffccSimulacion.Dominio.DataBase.ClasesJoins;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ffccSimulacion.Dominio
{
    [Table(Name = "Estaciones")]
    public class Estacion
    {
        private string _nombre;
        private int _personasEsperandoMin;
        private int _personasEsperandoMax;
        private TipoFDP _fdpEstacion;
        private EntitySet<Estacion_X_Incidente> _listaIncidentes_LINQ = new EntitySet<Estacion_X_Incidente>();
        private List<Relacion> _anteriores = new List<Relacion>();
        private List<Relacion> _siguientes = new List<Relacion>();
        private int _genteEsperando = 0;
        private int _ultimaAtencion = 0;
        private int _tiempoComprometido = 0;
        //private List<Incidente> _incidentesPosibles = new List<Incidente>();

        public Estacion() { }

        public Estacion(string nombreEst,int personasMin,int personasMax,TipoFDP fdp)
        {
            _nombre = nombreEst;
            _personasEsperandoMin = personasMin;
            _personasEsperandoMax = personasMax;
            _fdpEstacion = fdp;
        }

        #region Propiedades

        [Column(Name = "Id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        [Column(Name = "Nombre", DbType = "varchar(100)", CanBeNull = false)]
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        [Column(Name = "PersonasEsperandoMin", DbType = "int", CanBeNull = false)]
        public int PersonasEsperandoMin
        {
            get { return _personasEsperandoMin; }
            set { _personasEsperandoMin = value; }
        }

        [Column(Name = "PersonasEsperandoMax", DbType = "int", CanBeNull = false)]
        public int PersonasEsperandoMax
        {
            get { return _personasEsperandoMax; }
            set { _personasEsperandoMax = value; }
        }

        [Column(Name = "TipoFDP", DbType = "int", CanBeNull = false)]
        public TipoFDP FDPEstacion
        {
            get { return _fdpEstacion; }
            set { _fdpEstacion = value; }
        }

        public List<Relacion> Anteriores
        {
            get { return _anteriores; }
            set { _anteriores = value; }
        }

        public List<Relacion> Siguientes
        {
            get { return _siguientes; }
            set { _siguientes = value; }
        }

        public int GenteEsperando
        {
            get { return _genteEsperando; }
            set { _genteEsperando = value; }
        }

        public int UltimaAtencion
        {
            get { return _ultimaAtencion; }
            set { _ultimaAtencion = value; }
        }

        public int TiempoComprometido
        {
            get { return _tiempoComprometido; }
            set { _tiempoComprometido = value; }
        }

        [Association(Storage = "_listaIncidentes_LINQ", OtherKey = "Id_Estacion", ThisKey = "Id", IsForeignKey = true)]
        public EntitySet<Estacion_X_Incidente> ListaIncidentes_LINQ
        {
            get { return _listaIncidentes_LINQ; }
            set { _listaIncidentes_LINQ.Assign(value); }
        }

        public List<Incidente> IncidentesProsibles
        {
            get { return _listaIncidentes_LINQ.Select(x => x.UnIncidente).ToList<Incidente>(); }
        }

        #endregion

        #region Metodos

        /*public void CargarIncidentesPosibles()
        {
            if (_incidentesPosibles.Count == 0)
            {
                foreach (Estacion_X_Incidente ei in _auxIncidentes_LINQ.ToList<Estacion_X_Incidente>())
                    _incidentesPosibles.Add(ei.UnIncidente);
            }
        }*/

        public void AgregarIncidente(Incidente i)
        {
            Estacion_X_Incidente ie = new Estacion_X_Incidente();
            ie.UnIncidente = i;
            ie.Id_Estacion = this.Id;
            _listaIncidentes_LINQ.Add(ie);

            //_incidentesPosibles.Add(i);
        }

        public void LimpiarListaLINQParaPoderGuardar()
        {
            _listaIncidentes_LINQ = new EntitySet<Estacion_X_Incidente>(); 
        }

        public void agregarRelacionAnterior(Relacion relacion)
        {
            _anteriores.Add(relacion);
        }

        public void agregarRelacionSiguiente(Relacion relacion)
        {
            _siguientes.Add(relacion);
        }

        public int atenderFormacion(Formacion formacion, ref int tiempoLlegada)
        {
            //CALCULO LA LLEGADA
            if (_tiempoComprometido < tiempoLlegada)
            {
                _tiempoComprometido = tiempoLlegada;
            }
            else
            {
                tiempoLlegada = _tiempoComprometido; //El tiempo de llegada se actualiza.
            }

            //ATIENDO LOS PASAJEROS
            actualizarGenteEsperando(tiempoLlegada);

            _genteEsperando = formacion.recibir(_genteEsperando);

            //ACTUALIZO EL TIEMPO COMPROMETIDO Y LA ULTIMA ATENCION
            _tiempoComprometido += tiempoAtencion();
            _ultimaAtencion = _tiempoComprometido; //Por ahora son iguales.

            //RETORNO EL TIEMPO DE ATENCION EN LA ESTACION
            return tiempoAtencion();
        }

        private void actualizarGenteEsperando(int tiempoActual)
        {
            //TODO: para esto en el futuro hay que utilizar la FDP que se define en el ABM de estacion
            //Calculo de la gente que hay esperando en la estacion.
            //_genteEsperando += 20 * (tiempoActual - _ultimaAtencion);
            switch (_fdpEstacion)
            {
                case TipoFDP.Normal:
                    _genteEsperando = Fdp.Normal(_personasEsperandoMin, _personasEsperandoMax);
                    break;
                case TipoFDP.Gamma:
                    //calculo el delta en horas
                    double horasDeEspera = ((double)(tiempoActual - _ultimaAtencion)) / 60;
                    _genteEsperando = Fdp.Gamma(_personasEsperandoMin, _personasEsperandoMax, horasDeEspera);
                    break;
                case TipoFDP.Poisson:
                    //TODO: Definir gente por minuto.
                    //_genteEsperando = Fdp.Poisson(_personasEsperandoMin, _personasEsperandoMax);
                    _genteEsperando += 20 * (tiempoActual - _ultimaAtencion);
                    break;
            }
        }

        private int tiempoAtencion()
        {
            //TODO: cambiar esta constante por un numero random
            //Calculo del tiempo de atencion en la estacion.
            //return 5;
            int segundosEspera = Fdp.Normal(30, 120);
            return segundosEspera / 60;
        }

        #endregion
    }
}
