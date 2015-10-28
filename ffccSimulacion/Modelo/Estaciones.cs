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
    using System.Data.Linq;
    using System.Data.Linq.Mapping;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    
    public partial class Estaciones
    {
        //private List<Relaciones> _anteriores = new List<Relaciones>();
        //private List<Relaciones> _siguientes = new List<Relaciones>();
        private int _genteEsperando = 0;
        private int _ultimaAtencion = 0;
        private int _tiempoComprometido = 0;
        private int _pasajerosQueSubieronAlTren = 0;

        public Estaciones()
        {
            this.Relaciones = new HashSet<Relaciones>();
            this.Relaciones1 = new HashSet<Relaciones>();
            this.Estaciones_X_Incidentes = new HashSet<Estaciones_X_Incidentes>();
        }
    
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int PersonasEsperandoMin { get; set; }
        public int PersonasEsperandoMax { get; set; }
        public int TipoFDP { get; set; }
    
        public virtual ICollection<Relaciones> Relaciones { get; set; }
        public virtual ICollection<Relaciones> Relaciones1 { get; set; }
        public virtual ICollection<Estaciones_X_Incidentes> Estaciones_X_Incidentes { get; set; }

        /*Estas propiedades no tienen que estar mapeadas en la base*/
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

        public int PasajerosQueSubieronAlTren { get { return _pasajerosQueSubieronAlTren; } }

        /*public List<Relaciones> RelacionesAnteriores
        {
            get { return _anteriores; }
        }*/

        /*public List<Relaciones> RelacionesSiguientes
        {
            get { return _siguientes; }
        }*/

        public List<Incidentes> ListaIncidentes
        {
            get { return Estaciones_X_Incidentes.Select(x => x.Incidentes).ToList<Incidentes>(); }
        }


        public void AgregarIncidente(Incidentes i)
        {
            Estaciones_X_Incidentes ie = new Estaciones_X_Incidentes();
            ie.Incidentes = i;
            ie.Id_Estacion = this.Id;
            Estaciones_X_Incidentes.Add(ie);
        }

        /*public void agregarRelacionAnterior(Relaciones relacion)
        {
            _anteriores.Add(relacion);
        }*/

        /*public void agregarRelacionSiguiente(Relaciones relacion)
        {
            _siguientes.Add(relacion);
        }*/

        /*Retorna cual fue el tiempo de atencion de la formacion*/
        public int atenderFormacion(Formaciones formacion, ref int tiempoLlegada)
        {
            //CALCULO LA LLEGADA
            if (_tiempoComprometido < tiempoLlegada)
                _tiempoComprometido = tiempoLlegada;
            else
                tiempoLlegada = _tiempoComprometido; //El tiempo de llegada se actualiza.

            //ATIENDO LOS PASAJEROS
            actualizarGenteEsperando(tiempoLlegada);

            Flujo_Pasajeros fp = formacion.recibir(_genteEsperando);
            _pasajerosQueSubieronAlTren = fp.pasajerosQueSubieronAlTren;
            _genteEsperando = fp.pasajerosQueNoSubieronAlTren;

            //ACTUALIZO EL TIEMPO COMPROMETIDO Y LA ULTIMA ATENCION
            int tiempoAtencionActual = tiempoAtencion();
            _tiempoComprometido += tiempoAtencionActual;
            _ultimaAtencion = _tiempoComprometido; //Por ahora son iguales.

            //RETORNO EL TIEMPO DE ATENCION EN LA ESTACION
            return tiempoAtencionActual;
        }

        private void actualizarGenteEsperando(int tiempoActual)
        {
            //TODO: para esto en el futuro hay que utilizar la FDP que se define en el ABM de estacion
            //Calculo de la gente que hay esperando en la estacion.
            //_genteEsperando += 20 * (tiempoActual - _ultimaAtencion);
            switch (TipoFDP)
            {
                case 0:
                    _genteEsperando = Fdp.Normal(PersonasEsperandoMin, PersonasEsperandoMax);
                    break;
                case 1:
                    //TODO calculo el delta en horas
                    //double horasDeEspera = ((double)(tiempoActual - _ultimaAtencion)) / 60;
                    //_genteEsperando = Fdp.Gamma(PersonasEsperandoMin, PersonasEsperandoMax, horasDeEspera);
                    break;
                case 2:
                    //TODO: Definir gente por minuto.
                    //_genteEsperando = Fdp.Poisson(_personasEsperandoMin, _personasEsperandoMax);
                    _genteEsperando += 20 * (tiempoActual - _ultimaAtencion);
                    break;
            }
        }

        /*Retorna el tiempo que lo toma a la estacion para atener al tren y despacharlo en minutos*/
        private int tiempoAtencion()
        {
            //Calculo del tiempo de atencion en la estacion.
            int segundosEspera = Fdp.Normal(30, 120);
            return segundosEspera / 60;
        }
    }
}
