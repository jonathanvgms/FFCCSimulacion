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
    [Table(Name = "Trazas")]
    public class Traza
    {
        private string _nombre;
        private EntitySet<Traza_X_Servicio> _listaServicios_LINQ = new EntitySet<Traza_X_Servicio>();
        //private List<Servicio> _serviciosOtorgados = new List<Servicio>();

        public Traza() { }

        public Traza(string nombre)
        {
            _nombre = nombre;
        }

        #region Propiedades

        [Column(Name = "Id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        [Column(Name = "Nombre", DbType = "varchar(100)", CanBeNull = false)]
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        [Association(Storage = "_listaServicios_LINQ", OtherKey = "Id_Traza", ThisKey = "Id", IsForeignKey = true)]
        public EntitySet<Traza_X_Servicio> AuxServicios_LINQ
        {
            get { return _listaServicios_LINQ; }
            set { _listaServicios_LINQ.Assign(value); }
        }

        public List<Servicio> ServiciosOtorgados
        {
            get { return _listaServicios_LINQ.Select(x => x.UnServicio).ToList<Servicio>(); }
        }

        #endregion

        #region Metodos

        public void ConfigurarLosServiciosDeLaTraza()
        {
            foreach (Traza_X_Servicio ts in _listaServicios_LINQ)
                ts.UnServicio.ConfigurarServicio();
        }

        public void AgregarServicio(Servicio unServicio)
        {
            Traza_X_Servicio ts = new Traza_X_Servicio();
            ts.Id = this.Id;
            ts.UnServicio = unServicio;

            //_serviciosOtorgados.Add(unServicio);
        }

        #endregion
    }
}
