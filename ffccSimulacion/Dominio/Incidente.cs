using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ffccSimulacion.Dominio
{
    [Table(Name = "Incidentes")]
    public class Incidente
    {
        private string _nomreIncidente;
        private string _descripcion;
        private int _probabilidadOcurrencia;
        private int _tiempoDemora;

        public Incidente() { }

        public Incidente(int ocurrencia, int demora)
        {
            _probabilidadOcurrencia = ocurrencia;
            _tiempoDemora = demora;
        }

        #region Propiedades

        [Column(Name = "Id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        [Column(Name = "Nombre", DbType = "varchar(100)", CanBeNull = false)]
        public string NombreIncidente
        {
            get { return _nomreIncidente; }
            set { _nomreIncidente = value; }
        }

        [Column(Name = "Descripcion", DbType = "varchar(500)", CanBeNull = false)]
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        [Column(Name = "ProbabilidadOcurrencia", DbType = "int", CanBeNull = false)]
        public int ProbabilidadOcurrencia
        {
            get { return _probabilidadOcurrencia; }
            set { _probabilidadOcurrencia = value; }
        }

        [Column(Name = "TiempoDemora", DbType = "int", CanBeNull = false)]
        public int TiempoDemora
        {
            get { return _tiempoDemora; }
            set { _tiempoDemora = value; }
        }

        #endregion

        public bool Ocurre()
        {
            Random random = new Random();

            if (random.Next(0, 100) <= _probabilidadOcurrencia)
            {
                return true;
            }
            return false;
        }
    }
}
