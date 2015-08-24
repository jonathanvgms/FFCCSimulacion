﻿using ffccSimulacion.Dominio.DataBase.ClasesJoins;
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
        private EntitySet<Formacion_X_Coche> _listaCoches_LINQ = new EntitySet<Formacion_X_Coche>();
        //private List<Coche> _coches = new List<Coche>();

        /*Constructor para LINQ. No modificar porque se rompe el mapeo con la base de datos*/
        public Formacion() {  }

        public Formacion(string nombre)
        {
            _nombreFormacion = nombre;
            //_auxCoches_LINQ = new EntitySet<Formacion_X_Coche>();
        }

        #region Propiedades

        [Column(Name = "Id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        [Column(Name = "NombreFormacion", DbType = "varchar(100)", CanBeNull = false)]
        public string NombreFormacion
        {
            get { return _nombreFormacion; }
            set { _nombreFormacion = value; }
        }

        [Association(Storage = "_listaCoches_LINQ", OtherKey = "IdFormacion", ThisKey = "Id", IsForeignKey = true)]
        public EntitySet<Formacion_X_Coche> AuxCoches_LINQ
        {
            get { return _listaCoches_LINQ; }
            set { _listaCoches_LINQ.Assign(value); }
        }

        /*Es vez de poner un "set" a esta propiedad hay que usar la funcion de abajo "agregarCoche" para mantener la consistencia con la clase
         que se utiliza como vinculo entre la formacion y los coches*/
        /*public List<Coche> Coches
        {
            get { return _coches; }
        }*/

        #endregion

        #region Metodos

        /*public void CargarCochesDeLaFormacion()
        {
            if (_coches.Count == 0)
            {
                List<Formacion_X_Coche> listaCoches = _auxCoches_LINQ.ToList<Formacion_X_Coche>();
                foreach (Formacion_X_Coche fc in listaCoches)
                    for (int i = 0; i < fc.VecesCocheRepetido; i++)
                        _coches.Add(fc.UnCoche);
            }
        }*/

        public void LimpiarListaLINQParaPoderGuardar()
        {
            _listaCoches_LINQ = new EntitySet<Formacion_X_Coche>();
        }

        public void agregarCoche(Coche coche,int vecesRepetido)
        {
            /*Es necesario esto para poder guardar luego los nuevos coches que se vallan agregando a una formacion ya existente*/
            Formacion_X_Coche fc = new Formacion_X_Coche();
            fc.UnCoche = coche;
            fc.VecesCocheRepetido = vecesRepetido;
            fc.IdFormacion = this.Id;
            AuxCoches_LINQ.Add(fc);

            /*for (int i = 0; i < vecesRepetido;i++ )
                _coches.Add(coche);*/
        }

        /*Esta funcion retorna una nueva instancia de formacion exactamente igual a si misma. CLONA LA FORMACION*/
        public Formacion ClonarFormacion()
        {
            return (Formacion)this.MemberwiseClone();
        }

        public int pasajerosSentados()
        {
            int pasajerosSentados = 0;
            foreach (Formacion_X_Coche fc in _listaCoches_LINQ)
            {
                for (int i = 0; i < fc.VecesCocheRepetido; i++)
                    pasajerosSentados += fc.UnCoche.PasajerosSentados;
            }

            return pasajerosSentados;
        }

        public int pasajerosParados()
        {
            int pasajerosParados = 0;
            foreach (Formacion_X_Coche fc in _listaCoches_LINQ)
            {
                for (int i = 0; i < fc.VecesCocheRepetido; i++)
                    pasajerosParados += fc.UnCoche.PasajerosParados;
            }
            return pasajerosParados;
        }

        public int cantidadAsientos()
        {
            int cantidadAsientos = 0;
            foreach (Formacion_X_Coche fc in _listaCoches_LINQ)
            {
                for (int i = 0; i < fc.VecesCocheRepetido; i++)
                    cantidadAsientos += fc.UnCoche.CantidadAsientos;
            }
            return cantidadAsientos;
        }

        public int capacidadLegal()
        {
            int capacidadLegal = 0;
            foreach (Formacion_X_Coche fc in _listaCoches_LINQ)
            {
                for (int i = 0; i < fc.VecesCocheRepetido; i++)
                    capacidadLegal += fc.UnCoche.CapacidadLegal;
            }
            return capacidadLegal;
        }

        public int capacidadMaxima()
        {
            int capacidadMaxima = 0;
            foreach (Formacion_X_Coche fc in _listaCoches_LINQ)
            {
                for (int i = 0; i < fc.VecesCocheRepetido; i++)
                    capacidadMaxima += fc.UnCoche.CapacidadMaxima;
            }
            return capacidadMaxima;
        }

        public int recibir(int genteASubir)
        {
            int exceso = genteASubir;

            foreach (Formacion_X_Coche fc in _listaCoches_LINQ)
            {
                for (int i = 0; i < fc.VecesCocheRepetido; i++)
                {
                    if (exceso > 0)
                        exceso = fc.UnCoche.recibir(exceso);
                }
            }
            return exceso; //Se retorna la cantidad de gente que no pudo subir.
        }

        #endregion
    }
}
