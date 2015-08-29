using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ffccSimulacion.Dominio
{
    [Table(Name = "Relaciones")]
    public class Relacion
    {
        /*Relaciona un unico nodo inicial con un unico nodo siguiente.
         *Contiene indicadores propios del transito entre un nodo y otro*/
        private EntityRef<Estacion> _anterior;
        private EntityRef<Estacion> _siguiente;

        private int _id_Estacion_Anterior;
        private int _id_Estacion_Siguiente;
        /*Si es 1 quiere decir que el tren para en la estacion siguiente si es 0 entonces sigue de largo y no hay que atenderlo*/
        private int _estacion_Sig_Es_Parada;
        private int _id_Servicio;
        private int _distancia;
        private int _velocidadPromedio;
        private int _tiempoViaje; //TODO: este campo va a estar fuera de uso cuando se calculo el tiempo de viaje a partir de la velocidad y la distancia

        public Relacion() { }

        public Relacion(Estacion nodoAnterior, Estacion nodoSiguiente, int dist, int velProm, int tiempoViaje, int sigEstEsParada)
        {
            Anterior = nodoAnterior;
            Siguiente = nodoSiguiente;
            _distancia = dist;
            _velocidadPromedio = velProm;
            _tiempoViaje = tiempoViaje;
            _estacion_Sig_Es_Parada = sigEstEsParada;
        }

        #region Propiedades

        [Column(Name = "Id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        [Association(Storage = "_anterior", OtherKey = "Id", ThisKey = "Id_Estacion_Anterior", IsForeignKey = true)]
        public Estacion Anterior
        {
            get { return _anterior.Entity; }
            set { _anterior.Entity = value; }
        }

        [Association(Storage = "_siguiente", OtherKey = "Id", ThisKey = "Id_Estacion_Siguiente", IsForeignKey = true)]
        public Estacion Siguiente
        {
            get { return _siguiente.Entity; }
            set { _siguiente.Entity = value; }
        }

        [Column(Name = "Id_Servicio", DbType = "int", CanBeNull = false)]
        public int Id_Servicio
        {
            get { return _id_Servicio; }
            set { _id_Servicio = value; }
        }

        [Column(Name = "Id_Estacion_Anterior", DbType = "int", CanBeNull = false)]
        public int Id_Estacion_Anterior
        {
            get { return _id_Estacion_Anterior; }
            set { _id_Estacion_Anterior = value; }
        }

        [Column(Name = "Id_Estacion_Siguiente", DbType = "int", CanBeNull = false)]
        public int Id_Estacion_Siguiente
        {
            get { return _id_Estacion_Siguiente; }
            set { _id_Estacion_Siguiente = value; }
        }

        [Column(Name = "Distancia", DbType = "int", CanBeNull = false)]
        public int Distancia
        {
            get { return _distancia; }
            set { _distancia = value; }
        }

        [Column(Name = "VelocidadPromedio", DbType = "int", CanBeNull = false)]
        public int VelocidadPromedio
        {
            get { return _velocidadPromedio; }
            set { _velocidadPromedio = value; }
        }

        /*[Column(Name = "TiempoViaje", DbType = "int", CanBeNull = false)]
        public int TiempoViaje
        {
            get { return _tiempoViaje; }
            set { _tiempoViaje = value; }
        }*/

        [Column(Name = "Est_Sig_Es_Parada", DbType = "int", CanBeNull = false)]
        public int Estacion_Sig_Es_Parada
        {
            get { return _estacion_Sig_Es_Parada; }
            set { _estacion_Sig_Es_Parada = value; }
        }

        #endregion

        #region Metodos

        public bool relaciona(Estacion nodoInicial, Estacion nodoFinal)
        {
            //TODO Revisar si la relacion es bidireccional.
            if ((Anterior == nodoInicial && Siguiente == nodoFinal) || (Anterior == nodoFinal && Siguiente == nodoInicial))
            {
                return true;
            }
            return false;
        }

        public int calcularTiempoViaje()
        {
            //TODO Modificar
            return _tiempoViaje;
        }

        public int demoraPorAccidentes()
        {
            int totalDemora = 0;
            foreach (Incidente incidentePosible in Siguiente.IncidentesProsibles)
            {
                if (incidentePosible.Ocurre())
                {
                    totalDemora += incidentePosible.TiempoDemora;
                }
            }
            return totalDemora;
        }

        #endregion
    }
}
