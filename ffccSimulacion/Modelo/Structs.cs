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
        public int consumoMovimiento;
        public int consumoParado;
        public int pasajerosTotalesTransportados;
        public int vecesSuperoCapLegal;
        public int vecesNoHabiaPasajerosParados;
        public int tiempoTotalDemoradoIncidente;
        public int tiempoTotalDemoradoAtencion;
        public int tiempoTotalEnMovimiento;
    }

    public struct ResultadoSimulacion
    {
        public int id;
        public string nombre;
        public DateTime fecha;
        public double porcentajeSobrecarga;
        public double promedioDemoraIncidentes;
        public double promedioPasajeros;
        public double promedioDemoraAtencion;
        public double costoKm;
        public double costoPasajero;
        public double consumoKm;
        public double consumoPasajero;
        //necesito estos dos campos mas para generar el informe
        public string nombreSimulacion;
        public int idTraza;
    }
}
