using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ffccSimulacion.Dominio
{
    public class Traza
    {
        private int _idTraza;
        private string _nombre;
        private List<Servicio> _serviciosOtorgados;
        //List<Relacion> relaciones;
        //List<Nodo> nodos; //TODO Hacer solamente una lista de servicios.

        public Traza() { }

        public int IdTraza
        {
            get { return _idTraza; }
            set { _idTraza = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public List<Servicio> ServiciosOtorgados
        {
            get { return _serviciosOtorgados; }
            set { _serviciosOtorgados = value; }
        }

        /*public Traza()
        {
            relaciones = new List<Relacion>();
            nodos = new List<Nodo>();
        }*/

        /*public void agregarNodo(Nodo nodo)
        {
            nodos.Add(nodo);
        }*/

        /*public void relacionarNodos(Relacion relacion)
        {
            //A partir de una relacion, chequea que los nodos pertenezcan a la traza, y agrega la relacion a la lista de relaciones.
            if (nodos.Contains(relacion.anterior) && nodos.Contains(relacion.siguiente))
            {
                relaciones.Add(relacion);

                relacion.anterior.agregarRelacionSiguiente(relacion);
                relacion.siguiente.agregarRelacionAnterior(relacion);
            }
            else
            {
                throw new ApplicationException("Las estaciones relacionadas no pertenecen a la traza.");
            }
        }*/

        /*public void relacionarNodos(Nodo nodoInicial, Nodo nodoFinal)
        {
            //A partir de dos nodos, chequea que  pertenezcan a la traza, crea una relacion y la agrega a la lista de relaciones.
            if (nodos.Contains(nodoInicial) && nodos.Contains(nodoFinal))
            {
                Relacion relacion = new Relacion(nodoInicial, nodoFinal);
                relaciones.Add(relacion);
            }
            else
            {
                throw new ApplicationException("Las estaciones relacionadas no pertenecen a la traza.");
            }
        }*/

        /*public Relacion relacionEntre(Nodo nodoInicial, Nodo nodoFinal)
        {
            foreach (Relacion relacion in relaciones)
            {
                if (relacion.relaciona(nodoInicial, nodoFinal))
                {
                    return relacion;
                }
            }
            throw new ApplicationException("No se encontró relacion entre nodos.");
        }*/
    }
}
