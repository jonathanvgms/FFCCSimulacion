using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ffccSimulacion.Dominio.DataBase
{
    public class DataBaseManager
    {
        private string _cadenaConexion = ConfigurationManager.ConnectionStrings["ffcc_SimuladorTrazas"].ConnectionString;
        private DataContext _dataContext;

        public DataBaseManager()
        {
            _dataContext = new DataContext(_cadenaConexion);
        }

        public DataContext Datacontext
        {
            get { return _dataContext; }
        }

        public int GuardarCoche(Coche unCoche)
        {
            try
            {
                _dataContext.GetTable<Coche>().InsertOnSubmit(unCoche);
                _dataContext.SubmitChanges();
                return unCoche.Id;
            }
            catch(InvalidCastException e)
            {
                //Poner el mensaje de error en un log de errores e.Source
                MessageBox.Show(e.Source);
                return -1;
            }
        }

        public List<Coche> GetTodosLosCoches()
        {
            return (from coche in _dataContext.GetTable<Coche>()
                    select coche).ToList<Coche>();
        }

        public Coche GetCocheById(int id)
        {
            return (from coche in _dataContext.GetTable<Coche>()
                              where coche.Id == id
                              select coche).FirstOrDefault();
        }

        public void PruebasBD()
        {
            Formacion unaFormacion = (from formaciones in _dataContext.GetTable<Formacion>()
                                      select formaciones).FirstOrDefault();
        }
    }
}
