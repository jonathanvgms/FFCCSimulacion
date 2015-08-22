using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ffccSimulacion.Dominio.DataBase.ClasesJoins
{
    [Table(Name = "Formaciones_X_Coches")]
    public class Formacion_X_Coche
    {
        private int _idFormacion;
        private int _idCoche;
        private int _vecesCocheRepetido;//Indica cuantas veces esta presenta en la formacion el coche
        private EntityRef<Coche> _unCoche;

        /*Constructor para LINQ. No modificar porque se rompe el mapeo con la base de datos*/
        public Formacion_X_Coche() { }

        #region Propiedades

        [Column(Name = "Id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        [Column(Name = "Id_Formacion", DbType = "int", CanBeNull = false)]
        public int IdFormacion
        {
            get { return _idFormacion; }
            set { _idFormacion = value; }
        }

        [Column(Name = "Id_Coche", DbType = "int", CanBeNull = false)]
        public int IdCoche
        {
            get { return _idCoche; }
            set { _idCoche = value; }
        }

        [Column(Name = "VecesRepetido", DbType = "int", CanBeNull = false)]
        public int VecesCocheRepetido
        {
            get { return _vecesCocheRepetido; }
            set { _vecesCocheRepetido = value; }
        }

        [Association(Storage = "_unCoche", OtherKey = "Id", ThisKey = "IdCoche", IsForeignKey = true)]
        public Coche UnCoche
        {
            get { return _unCoche.Entity; }
            set { _unCoche.Entity = value; }
        }

        #endregion
    }
}
