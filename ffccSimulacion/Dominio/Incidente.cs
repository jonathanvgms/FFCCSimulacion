using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ffccSimulacion.Dominio
{
    public class Incidente
    {
        int probabilidadOcurrencia;
        int tiempoDemora;

        public Incidente(int ocurrencia, int demora)
        {
            probabilidadOcurrencia = ocurrencia;
            tiempoDemora = demora;
        }

        public int CalcularDemora()
        {
            return tiempoDemora;
        }

        public bool Ocurre()
        {
            Random random = new Random();

            if (random.Next(0, 100) <= probabilidadOcurrencia)
            {
                return true;
            }
            return false;
        }
    }
}
