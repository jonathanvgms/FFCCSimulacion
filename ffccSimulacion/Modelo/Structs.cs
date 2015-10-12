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
