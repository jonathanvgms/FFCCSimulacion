using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ffccSimulacion.Dominio
{
    class Servicio
    {
        public Nodo desde; //Terminal de donde sale la formacion.
        
        public Nodo hasta; //Terminal hacia la que va la formacion.

        struct Parada
        {
            public Nodo nodo;
            public bool para;
        }

        List<Parada> paradas; //Estaciones en las que para la formacion.

        public Formacion formacion; //Formacion que prestara este servicio.

        List<int> programacion; //Tiempos de salida de la terminal.

        public Servicio(Nodo terminalInicial, Nodo terminalFinal)
        {
            desde = terminalInicial;
            hasta = terminalFinal;
            paradas = new List<Parada>();
            programacion = new List<int>();
        }

        public void agregarParada(Nodo nodo, bool para)
        {
            Parada parada = new Parada();
            parada.nodo = nodo;
            parada.para = para;
            paradas.Add(parada);
        }

        public void agregarHorarioSalida(int horarioSalida)
        {
            programacion.Add(horarioSalida);
            //No es necesario ordenar, devuelvo el menor luego.
        }

        public void agregarProgramacionSalida(List<int> programacionSalida)
        {
            foreach (int horarioSalida in programacionSalida)
            {
                programacion.Add(horarioSalida);
            }
            //No es necesario ordenar, devuelvo el menor luego.
        }

        public int proximoHorarioSalida()
        {
            //Obtiene la proxima salida para este servicio.
            if (programacion.Count != 0)
            {
                return programacion.Min();
            }

            return 1000;
        }

        public void removerSalida(int salida)
        {
            //Remueve de la programacion una salida ya utilizada.
            programacion.Remove(salida);
        }

        public Nodo proximoNodo(Nodo nodoActual)
        {
            foreach (Relacion proximaRelacion in nodoActual.siguientes)
            {
                foreach (Parada parada in paradas)
                {
                    if (proximaRelacion.siguiente == parada.nodo)
                    {
                        return parada.nodo;
                    }
                }
            }
            foreach (Relacion proximaRelacion in nodoActual.anteriores)
            {
                foreach (Parada parada in paradas)
                {
                    if (proximaRelacion.anterior == parada.nodo)
                    {
                        return parada.nodo;
                    }
                }
            }
            throw new ApplicationException("Error de configuración de nodos del servicio.");
        }
    }
}
