using ffccSimulacion.Dominio.DataBase.ClasesJoins;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ffccSimulacion.Dominio
{
    [Table(Name = "Formaciones")]
    public class Formacion
    {
        private string _nombreFormacion;
        private EntitySet<Formacion_X_Coche> _auxCoches_LINQ;
        private List<Coche> _coches = new List<Coche>();
        private bool _inicializoCoches = false;

        public Formacion() { }

        public Formacion(string nombre)
        {
            _nombreFormacion = nombre;
            _auxCoches_LINQ = new EntitySet<Formacion_X_Coche>();
        }

        [Column(Name = "Id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        [Column(Name = "NombreFormacion", DbType = "varchar(100)", CanBeNull = false)]
        public string NombreFormacion
        {
            get { return _nombreFormacion; }
            set { _nombreFormacion = value; }
        }

        [Association(Storage = "_auxCoches_LINQ", OtherKey = "IdFormacion", ThisKey = "Id")]
        public EntitySet<Formacion_X_Coche> AuxCoches_LINQ
        {
            get { return _auxCoches_LINQ; }
            set { _auxCoches_LINQ.Assign(value); }
        }

        /*Es vez de poner un "set" a esta propiedad hay que usar la funcion de abajo "agregarCoche"*/
        public List<Coche> Coches
        {
            get 
            {
                /*Tienen que pasar al menos una vez dentro del if para que se cargue los coches que vienen desde la base*/
                if (!_inicializoCoches)
                {
                    _inicializoCoches = true;
                    foreach (Formacion_X_Coche fc in AuxCoches_LINQ.ToList<Formacion_X_Coche>())
                        _coches.Add(fc.UnCoche);
                }
                return _coches; 
            }
        }

        public void agregarCoche(Coche coche)
        {
            /*Es necesario esto para poder guardar luego los nuevos coches que se vallan agregando a una formacion ya existente*/
            Formacion_X_Coche fc = new Formacion_X_Coche();
            fc.UnCoche = coche;
            _auxCoches_LINQ.Add(fc);

            _coches.Add(coche);
        }

        public int pasajerosSentados()
        {
            int pasajerosSentados = 0;
            foreach (Coche coche in _coches)
            {
                pasajerosSentados += coche.PasajerosSentados;
            }
            return pasajerosSentados;
        }

        public int pasajerosParados()
        {
            int pasajerosParados = 0;
            foreach (Coche coche in _coches)
            {
                pasajerosParados += coche.PasajerosParados;
            }
            return pasajerosParados;
        }

        public int cantidadAsientos()
        {
            int cantidadAsientos = 0;
            foreach (Coche coche in _coches)
            {
                cantidadAsientos += coche.CantidadAsientos;
            }
            return cantidadAsientos;
        }

        public int capacidadLegal()
        {
            int capacidadLegal = 0;
            foreach (Coche coche in _coches)
            {
                capacidadLegal += coche.CapacidadLegal;
            }
            return capacidadLegal;
        }

        public int capacidadMaxima()
        {
            int capacidadMaxima = 0;
            foreach (Coche coche in _coches)
            {
                capacidadMaxima += coche.CapacidadMaxima;
            }
            return capacidadMaxima;
        }

        public int recibir(int genteASubir)
        {
            int exceso = genteASubir;

            foreach (Coche coche in _coches)
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
