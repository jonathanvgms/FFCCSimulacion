using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ffccSimulacion.Dominio
{
    interface IEstrategiaDeSimulador
    {
        void EjecutarSimulacion(Traza traza);
    }
}
