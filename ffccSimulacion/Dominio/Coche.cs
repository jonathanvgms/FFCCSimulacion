using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ffccSimulacion.Dominio
{
    class Coche
    {
        public int pasajerosSentados;
        public int pasajerosParados;
        public int cantidadAsientos;
        public int capacidadLegal;
        public int capacidadMaxima;

        public Coche(int cantidadAsientos, int capacidadLegal, int capacidadMaxima)
        {
            if (cantidadAsientos <= capacidadLegal && capacidadLegal <= capacidadMaxima)
            {
                pasajerosSentados = 0;
                pasajerosParados = 0;
                this.cantidadAsientos = cantidadAsientos;
                this.capacidadLegal = capacidadLegal;
                this.capacidadMaxima = capacidadMaxima;
            }
            else
            {
                throw new ApplicationException("Error de configuración de Coche.");
            }
        }

        public int asientosRestantes()
        {
            return cantidadAsientos - pasajerosSentados;
        }

        public int capacidadLegalRestante()
        {
            return capacidadLegal - pasajerosSentados - pasajerosParados;
        }

        public int capacidadMaximaRestante()
        {
            return capacidadMaxima - pasajerosSentados - pasajerosParados;
        }

        public int recibir(int pasajerosASubir)
        {
            int exceso = pasajerosASubir;

            //PRIMERO SE SIENTAN LA MAYOR CANTIDAD POSIBLE DE PASAJEROS
            int pasajerosASentar;
            if (exceso >= asientosRestantes())
            {
                pasajerosASentar = asientosRestantes();
            }
            else
            {
                pasajerosASentar = exceso;
            }
            exceso -= pasajerosASentar;
            pasajerosSentados += pasajerosASentar;

            //EL RESTO DE LOS PASAJEROS VAN PARADOS HASTA LA CAPACIDAD LEGAL
            int pasajerosAEntrar;
            if (exceso >= capacidadLegalRestante())
            {
                pasajerosAEntrar = capacidadLegalRestante();
            }
            else
            {
                pasajerosAEntrar = exceso;
            }
            exceso -= pasajerosAEntrar;
            pasajerosParados += pasajerosAEntrar;

            //EL RESTO DE LOS PASAJEROS VAN PARADOS HASTA LA CAPACIDAD MAXIMA
            if (exceso >= capacidadMaximaRestante())
            {
                pasajerosAEntrar = capacidadMaximaRestante();
            }
            else
            {
                pasajerosAEntrar = exceso;
            }
            exceso -= pasajerosAEntrar;
            pasajerosParados += pasajerosAEntrar;

            //EL RESTO DE LOS PASAJEROS NO PODRA ENTRAR
            return exceso;
        }
    }
}
