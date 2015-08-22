using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ffccSimulacion.Dominio.DataBase.ClasesJoins
{
    [Table(Name = "Trazas_X_Servicios")]
    public class Traza_X_Servicio
    {
        private int _id_Servicio;
        private int _id_Traza;
        private EntityRef<Servicio> _unServicio;

        public Traza_X_Servicio() { }

        [Column(Name = "Id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        [Column(Name = "Id_Servicio", DbType = "int", CanBeNull = false)]
        public int Id_Servicio
        {
            get { return _id_Servicio; }
            set { _id_Servicio = value; }
        }

        [Column(Name = "Id_Traza", DbType = "int", CanBeNull = false)]
        public int Id_Traza
        {
            get { return _id_Traza; }
            set { _id_Traza = value; }
        }

        [Association(Storage = "_unServicio", OtherKey = "Id", ThisKey = "Id_Servicio", IsForeignKey = true)]
        public Servicio UnServicio
        {
            get { return _unServicio.Entity; }
            set { _unServicio.Entity = value; }
        }
    }
}
