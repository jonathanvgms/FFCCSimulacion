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
        private string _nombre;
        private Estacion _desde; //Terminal de donde sale la formacion.
        private Estacion _hasta; //Terminal hacia la que va la formacion.
        private EntitySet<Relacion> _relaciones;
        private List<Parada> _paradas; //Estaciones en las que para la formacion.
        private Formacion _formacion; //Formacion que prestara este servicio. //TODO cambiar por una lista de formaciones.
        private List<int> _programacion; //Tiempos de salida de la terminal.
        
        struct Parada
        {
            public Estacion nodo;
            public bool para;
        }

        public Servicio() { }

        public Servicio(string nom, Estacion terminalInicial, Estacion terminalFinal)
        {
            _nombre = nom;
            _desde = terminalInicial;
            _hasta = terminalFinal;
            _relaciones = new EntitySet<Relacion>();
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
        public List<Relacion> Relaciones
        {
            get { return _relaciones.ToList<Relacion>(); }
            set { _relaciones.Assign(value); }
        }

        public Formacion Formacion
        {
            get { return _formacion; }
            set { _formacion = value; }
        }

        public List<int> Programacion
        {
            get { return _programacion; }
            set { _programacion = value; }
        }

        #endregion

        #region Metodos

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
            Relacion relacionActual = Relaciones.First();
            Estacion estacionActual = relacionActual.Anterior;
            while (relacionActual != null)
            {
                relacionActual = BuscarRelacionAnterior(estacionActual);
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

        /*Esta funcion configura todos los campos que no vienen por base y que dependen del conjunto de relaciones definido para el servicio*/
        public void ConfigurarServicio()
        {
            this.Desde = BuscarEstacionDesde();
            this.Hasta = BuscarEstacionHasta();
            ConfigurarEstaciones();
            CargarParadas();
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
