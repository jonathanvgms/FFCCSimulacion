using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ffccSimulacion.Dominio
{
    public class Servicio
    {
        private Nodo _desde; //Terminal de donde sale la formacion.
        
        private Nodo _hasta; //Terminal hacia la que va la formacion.

        private List<Relacion> _relaciones;

        struct Parada
        {
            public Nodo nodo;
            public bool para;
        }

        private List<Parada> _paradas; //Estaciones en las que para la formacion.

        private Formacion _formacion; //Formacion que prestara este servicio. //TODO cambiar por una lista de formaciones.

        private List<int> _programacion; //Tiempos de salida de la terminal.

        public Servicio(Nodo terminalInicial, Nodo terminalFinal)
        {
            _desde = terminalInicial;
            _hasta = terminalFinal;
            _relaciones = new List<Relacion>();
            _paradas = new List<Parada>();
            _programacion = new List<int>();
        }

        public Nodo Desde
        {
            get { return _desde; }
            set { _desde = value; }
        }

        public Nodo Hasta
        {
            get { return _hasta; }
            set { _hasta = value; }
        }

        public List<Relacion> Relaciones
        {
            get { return _relaciones; }
            set { _relaciones = value; }
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

        /*A partir de la lista de relaciones definidas para el servicio se configuran las distitnas estaciones*/
        public void ConfigurarEstaciones()
        {
            Relacion r;
            Nodo nodoRelacion;

            /*Se cargan todas las relaciones siguientes de los nodos. Se recorre de atras para adelante*/
            Nodo nodoActual = this.Desde;
            while (nodoActual != null)
            {
                nodoRelacion = nodoActual;
                while(nodoRelacion != this.Hasta)
                {
                    r = BuscarRelacionSiguiente(nodoRelacion);
                    nodoActual.agregarRelacionSiguiente(r);
                    nodoRelacion = r.siguiente;
                }

                if (nodoActual != this.Hasta)
                {
                    r = BuscarRelacionSiguiente(nodoActual);
                    nodoActual = r.siguiente;
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
                    nodoRelacion = r.anterior;
                }

                if (nodoActual != this.Desde)
                {
                    r = BuscarRelacionAnterior(nodoActual);
                    nodoActual = r.anterior;
                }
                else
                    nodoActual = null;
            }
        }

        public Relacion BuscarRelacionSiguiente(Nodo n)
        {
            return Relaciones.Where(x => x.anterior == n).FirstOrDefault();
        }

        public Relacion BuscarRelacionAnterior(Nodo n)
        {
            return Relaciones.Where(x => x.siguiente == n).FirstOrDefault();
        }

        public void agregarParada(Nodo nodo, bool para)
        {
            Parada parada = new Parada();
            parada.nodo = nodo;
            parada.para = para;
            _paradas.Add(parada);
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

        public Relacion relacionEntre(Nodo nodoInicial, Nodo nodoFinal)
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

        public Nodo proximoNodo(Nodo nodoActual)
        {
            foreach (Relacion proximaRelacion in nodoActual.siguientes)
            {
                foreach (Parada parada in _paradas)
                {
                    if (proximaRelacion.siguiente == parada.nodo)
                    {
                        return parada.nodo;
                    }
                }
            }
            foreach (Relacion proximaRelacion in nodoActual.anteriores)
            {
                foreach (Parada parada in _paradas)
                {
                    if (proximaRelacion.anterior == parada.nodo)
                    {
                        return parada.nodo;
                    }
                }
            }
            throw new ApplicationException("Error de configuración de nodos del servicio.");
        }
    }
}
