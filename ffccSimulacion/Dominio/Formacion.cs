using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ffccSimulacion.Dominio
{
    public class Formacion
    {
        List<Coche> coches;
        public Formacion()
        {
            coches = new List<Coche>();
        }

        public void agregarCoche(Coche coche)
        {
            coches.Add(coche);
        }

        public int pasajerosSentados()
        {
            int pasajerosSentados = 0;
            foreach (Coche coche in coches)
            {
                pasajerosSentados += coche.pasajerosSentados;
            }
            return pasajerosSentados;
        }

        public int pasajerosParados()
        {
            int pasajerosParados = 0;
            foreach (Coche coche in coches)
            {
                pasajerosParados += coche.pasajerosParados;
            }
            return pasajerosParados;
        }

        public int cantidadAsientos()
        {
            int cantidadAsientos = 0;
            foreach (Coche coche in coches)
            {
                cantidadAsientos += coche.cantidadAsientos;
            }
            return cantidadAsientos;
        }

        public int capacidadLegal()
        {
            int capacidadLegal = 0;
            foreach (Coche coche in coches)
            {
                capacidadLegal += coche.capacidadLegal;
            }
            return capacidadLegal;
        }

        public int capacidadMaxima()
        {
            int capacidadMaxima = 0;
            foreach (Coche coche in coches)
            {
                capacidadMaxima += coche.capacidadMaxima;
            }
            return capacidadMaxima;
        }

        public int recibir(int genteASubir)
        {
            int exceso = genteASubir;

            foreach (Coche coche in coches)
            {
                if (exceso > 0)
                {
                    exceso = coche.recibir(exceso); //Cargo los coches.
                }
            }

            return exceso; //Se retorna la cantidad de gente que no pudo subir.
        }
    }
}
