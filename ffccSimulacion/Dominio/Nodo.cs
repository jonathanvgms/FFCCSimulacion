using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ffccSimulacion.Dominio
{
    class Nodo
    {
        /*Representa todo elemento que forma una traza
         *Se relacionan entre si a travez de una lista de Relacion siguientes y otra de anteriores
         */
        public string nombre;
        public List<Relacion> anteriores;
        public List<Relacion> siguientes;

        public Nodo()
        {
            anteriores = new List<Relacion>();
            siguientes = new List<Relacion>();
        }

        public void agregarRelacionAnterior(Relacion relacion)
        {
            anteriores.Add(relacion);
        }

        public void agregarRelacionSiguiente(Relacion relacion){
            siguientes.Add(relacion);
        }

        public virtual int atenderFormacion(Formacion formacion, ref int tiempoLlegada)
        {
            return 0;
        }
    }
}
