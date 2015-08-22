using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ffccSimulacion.Dominio.DataBase.ClasesJoins
{
    [Table(Name = "Servicios_X_Formaciones")]
    public class Servicio_X_Formacion
    {
        private int _id_Servicio;
        private int _id_Formacion;
        private EntityRef<Formacion> _unaFormacion;

        public Servicio_X_Formacion() { }

        #region Propiedades

        [Column(Name = "Id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        [Column(Name = "Id_Servicio", DbType = "int", CanBeNull = false)]
        public int Id_Servicio
        {
            get { return _id_Servicio; }
            set { _id_Servicio = value; }
        }

        [Column(Name = "Id_Formacion", DbType = "int", CanBeNull = false)]
        public int Id_Formacion
        {
            get { return _id_Formacion; }
            set { _id_Formacion = value; }
        }

        [Association(Storage = "_unaFormacion", OtherKey = "Id", ThisKey = "Id_Formacion", IsForeignKey = true)]
        public Formacion UnaFormacion
        {
            get { return _unaFormacion.Entity; }
            set { _unaFormacion.Entity = value; }
        }

        #endregion
    }
}
