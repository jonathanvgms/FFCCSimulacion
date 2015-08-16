using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ffccSimulacion.Dominio.DataBase.ClasesJoins
{
    [Table(Name = "Estaciones_X_Incidentes")]
    public class Estacion_X_Incidente
    {
        private int _id_Incidente;
        private int _id_Estacion;
        private EntityRef<Incidente> _unIncidente;

        public Estacion_X_Incidente() { }

        #region Propiedades

        [Column(Name = "Id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        [Column(Name = "Id_Incidente", DbType = "int", CanBeNull = false)]
        public int Id_Incidente
        {
            get { return _id_Incidente; }
            set { _id_Incidente = value; }
        }

        [Column(Name = "Id_Estacion", DbType = "int", CanBeNull = false)]
        public int Id_Estacion
        {
            get { return _id_Estacion; }
            set { _id_Estacion = value; }
        }

        [Association(Storage = "_unIncidente", OtherKey = "Id", ThisKey = "Id_Incidente", IsForeignKey = true)]
        public Incidente UnIncidente
        {
            get { return _unIncidente.Entity; }
            set { _unIncidente.Entity = value; }
        }

        #endregion
    }
}
