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
    [Table(Name = "Servicios")]
    public class Servicio
    {
        struct Parada
        {
            public Estacion nodo;
            public bool para;
        }

        private string _nombre;
        private Estacion _desde; //Terminal de donde sale la formacion.
        private Estacion _hasta; //Terminal hacia la que va la formacion.
        private EntitySet<Relacion> _relaciones = new EntitySet<Relacion>();
        private List<Parada> _paradas = new List<Parada>(); //Estaciones en las que para la formacion.
        private EntitySet<Servicio_X_Formacion> _listaFormaciones_LINQ = new EntitySet<Servicio_X_Formacion>(); //Lista de los distintos tipos de formaciones que prestaran dicho servicio
        //private List<Formacion> _formacionesDisponibles = new List<Formacion>(); 
        private List<int> _programacion; //Tiempos de salida de la terminal.
       
        public Servicio() { }

        public Servicio(string nom)
        {
            _nombre = nom;
            _relaciones = new EntitySet<Relacion>();
        }

        public Servicio(string nom, Estacion terminalInicial, Estacion terminalFinal)
        {
            _nombre = nom;
            _desde = terminalInicial;
            _hasta = terminalFinal;
            _paradas = new List<Parada>();
            _programacion = new List<int>();
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

        public Estacion Desde
        {
            get { return _desde; }
            set { _desde = value; }
        }

        public Estacion Hasta
        {
            get { return _hasta; }
            set { _hasta = value; }
        }

        [Association(Storage = "_relaciones", OtherKey = "Id_Servicio", ThisKey = "Id", IsForeignKey = true)]
        public EntitySet<Relacion> Relaciones
        {
            get { return _relaciones; }
            set { _relaciones.Assign(value); }
        }

        [Association(Storage = "_listaFormaciones_LINQ", OtherKey = "Id_Servicio", ThisKey = "Id", IsForeignKey = true)]
        public EntitySet<Servicio_X_Formacion> ListaFormaciones_LINQ
        {
            get { return _listaFormaciones_LINQ; }
            set { _listaFormaciones_LINQ.Assign(value); }
        }

        public List<Formacion> FormacionesDisponibles
        {
            get { return _listaFormaciones_LINQ.Select(x => x.UnaFormacion).ToList<Formacion>(); }
        }

        public List<int> Programacion
        {
            get { return _programacion; }
            set { _programacion = value; }
        }

        #endregion

        #region Metodos

        public void LimpiarListaLINQParaPoderGuardar()
        {
            _relaciones = new EntitySet<Relacion>();
            _listaFormaciones_LINQ = new EntitySet<Servicio_X_Formacion>();
        }

        /*A partir de la lista de relaciones definidas para el servicio se configuran las distitnas estaciones*/
        public void ConfigurarEstaciones()
        {
            Relacion r;
            Estacion nodoRelacion;
            
            /*Se cargan todas las relaciones siguientes de los nodos. Se recorre de atras para adelante*/
            Estacion nodoActual = this.Desde;
            while (nodoActual != null)
            {
                nodoRelacion = nodoActual;
                while(nodoRelacion != this.Hasta)
                {
                    r = BuscarRelacionSiguiente(nodoRelacion);
                    nodoActual.agregarRelacionSiguiente(r);
                    nodoRelacion = r.Siguiente;
                }

                if (nodoActual != this.Hasta)
                {
                    r = BuscarRelacionSiguiente(nodoActual);
                    nodoActual = r.Siguiente;
                }
                else
                    nodoActual = null;
            }

            nodoActual = this.Hasta;
            while(nodoActual != null)
            {
                nodoRelacion = nodoActual;
                while(nodoRelacion != this.Desde)
                {
                    r = BuscarRelacionAnterior(nodoRelacion);
                    nodoActual.agregarRelacionAnterior(r);
                    nodoRelacion = r.Anterior;
                }

                if (nodoActual != this.Desde)
                {
                    r = BuscarRelacionAnterior(nodoActual);
                    nodoActual = r.Anterior;
                }
                else
                    nodoActual = null;
            }

            /*Se cargan las listas de incidentes de cada estacion de atras para adelante*/
            /*nodoActual = this.Desde;
            while(nodoActual!=this.Hasta)
            {
                nodoActual.CargarIncidentesPosibles();
                r = BuscarRelacionSiguiente(nodoActual);
                nodoActual = r.Siguiente;
            }
            this.Hasta.CargarIncidentesPosibles();*/
        }

        /*Dada una estacion retorna aquella relacion donde dicha estacion es la estacion anterior*/
        public Relacion BuscarRelacionSiguiente(Estacion n)
        {
            return Relaciones.Where(x => x.Anterior == n).FirstOrDefault();
        }

        public Relacion BuscarRelacionAnterior(Estacion n)
        {
            return Relaciones.Where(x => x.Siguiente == n).FirstOrDefault();
        }

        /*A partir de la lista de relaciones retorna aquella estacion que es el origen del servicio*/
        public Estacion BuscarEstacionDesde()
        {
            Relacion relacionActual = _relaciones.First();
            Estacion estacionActual = relacionActual.Anterior;
            while (relacionActual != null)
            {
                relacionActual = BuscarRelacionAnterior(estacionActual);
                if (relacionActual != null)
                    estacionActual = relacionActual.Anterior;
            }

            return estacionActual;
        }

        public Estacion BuscarEstacionHasta()
        {
            Relacion relacionActual = Relaciones.First();
            Estacion estacionActual = relacionActual.Siguiente;
            while (relacionActual != null)
            {
                relacionActual = BuscarRelacionSiguiente(estacionActual);
                if (relacionActual != null)
                    estacionActual = relacionActual.Siguiente;
            }

            return estacionActual;
        }

        public void CargarParadas()
        {
            Estacion estacionActual = Desde;
            agregarParada(estacionActual, true);
            Relacion relacionActual = BuscarRelacionSiguiente(estacionActual);
            while (estacionActual != Hasta)
            {
                estacionActual = relacionActual.Siguiente;
                agregarParada(estacionActual, relacionActual.Estacion_Sig_Es_Parada == 1);
                relacionActual = BuscarRelacionSiguiente(estacionActual);
            }
            relacionActual = BuscarRelacionAnterior(Hasta);
            agregarParada(Hasta, relacionActual.Estacion_Sig_Es_Parada == 1);
        }

        public void agregarParada(Estacion nodo, bool para)
        {
            Parada parada = new Parada();
            parada.nodo = nodo;
            parada.para = para;
            _paradas.Add(parada);
        }

        public void ConfigurarFormacionesDelServicio()
        {
            foreach (Servicio_X_Formacion sf in _listaFormaciones_LINQ)
                sf.UnaFormacion.ConfigurarFormacion();
        }

        /*Esta funcion configura todos los campos que no vienen por base y que dependen del conjunto de relaciones definido para el servicio*/
        public void ConfigurarServicio()
        {
            this.Desde = BuscarEstacionDesde();
            this.Hasta = BuscarEstacionHasta();
            ConfigurarEstaciones();
            CargarParadas();
            //CargarFormacionesDelServicio();
        }

        /*Permite agregar un tipo de formacion que prestara el servicio*/
        public void AgregarFormacionDispoble(Formacion unaFormacion)
        {
            Servicio_X_Formacion sf = new Servicio_X_Formacion();
            sf.Id_Servicio = this.Id;
            sf.UnaFormacion = unaFormacion;
            _listaFormaciones_LINQ.Add(sf);

            //_formacionesDisponibles.Add(unaFormacion);
        }

        /*Retorna cada vez una instancia nueva (replica) de alguna de las formaciones disponibles para prestar un servicio*/
        public Formacion GetFormacionRandom()
        {
            Random rd = new Random();
            int num = rd.Next(0, FormacionesDisponibles.Count - 1);
            Formacion unaFormacion = FormacionesDisponibles[num];
            return unaFormacion.ClonarFormacion();
        }

        public void agregarHorarioSalida(int horarioSalida)
        {
            _programacion.Add(horarioSalida);
            //No es necesario ordenar, devuelvo el menor luego.
        }

        public void agregarProgramacionSalida(List<int> programacionSalida)
        {
            foreach (int horarioSalida in programacionSalida)
            {
                _programacion.Add(horarioSalida);
            }
            //No es necesario ordenar, devuelvo el menor luego.
        }

        public int proximoHorarioSalida()
        {
            //Obtiene la proxima salida para este servicio.
            if (_programacion.Count != 0)
            {
                return _programacion.Min();
            }

            return 1000;
        }

        public void removerSalida(int salida)
        {
            //Remueve de la programacion una salida ya utilizada.
            _programacion.Remove(salida);
        }

        public Relacion relacionEntre(Estacion nodoInicial, Estacion nodoFinal)
        {
            foreach (Relacion relacion in _relaciones)
            {
                if (relacion.relaciona(nodoInicial, nodoFinal))
                {
                    return relacion;
                }
            }
            throw new ApplicationException("No se encontró relacion entre nodos.");
        }

        public Estacion proximoNodo(Estacion nodoActual)
        {
            foreach (Relacion proximaRelacion in nodoActual.Siguientes)
            {
                foreach (Parada parada in _paradas)
                {
                    if (proximaRelacion.Siguiente == parada.nodo)
                    {
                        return parada.nodo;
                    }
                }
            }
            foreach (Relacion proximaRelacion in nodoActual.Anteriores)
            {
                foreach (Parada parada in _paradas)
                {
                    if (proximaRelacion.Anterior == parada.nodo)
                    {
                        return parada.nodo;
                    }
                }
            }
            throw new ApplicationException("Error de configuración de nodos del servicio.");
        }

#endregion

    }
}
