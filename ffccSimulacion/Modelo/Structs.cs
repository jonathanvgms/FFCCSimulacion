using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ffccSimulacion.Modelo
{
    public struct Parada
    {
        public Estaciones nodo;
        public bool para;
    }

    public struct Flujo_Pasajeros
    {
        public int pasajerosQueSubieronAlTren;
        public int pasajerosQueNoSubieronAlTren;
    }

    public struct Estacion_Info
    {
        public int id_estacion;
        public int ultima_Atencion;
        public int tiempo_comprometido;
        public int gente_esperando;
    }

    /*todos los tiempos de la estructura estan en minutos*/
    public struct ResultadoFormacion
    {
        public int id_formacion;
        public string nombreFormacion;
        public int distanciaTotalRecorrida;
        public int pasajerosTotalesTransportados;
        public int vecesSuperoCapLegal;
        public int vecesNoHabiaPasajerosParados;
        public int tiempoTotalDemoradoIncidente;
        public int tiempoTotalDemoradoAtencion;
        public int tiempoTotalEnMovimiento;
    }
}
