using ffccSimulacion.Dominio.DataBase.ClasesJoins;
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

        #region Formaciones y Coches

        /*obtiene una lista de todas las formaciones existentes en la bd*/
        public List<Formacion> GetAllFormaciones()
        {
            return (from formaciones in _dataContext.GetTable<Formacion>()
                    select formaciones).ToList<Formacion>();
        }

        /*obtiene una formacion especifica a paritr de su id en la base*/
        public Formacion GetFormacionById(int id_formacion)
        {
            return (from formaciones in _dataContext.GetTable<Formacion>()
                    where formaciones.Id == id_formacion
                    select formaciones).FirstOrDefault();
        }

        /*Esta funciona permite guarda cualquier modificacion que se le haga a un objeto traido de la bd. Es el update*/
        public int GuardarModificacionesObjeto()
        {
            try
            {

                _dataContext.SubmitChanges();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Source);
                return -1;
            }
        }

        /*Guarda una formacion nueva en la bd junto con las relaciones entre dicha formacion y los coches que la componen*/
        public int GuardarNuevaFormacion(Formacion unaFormacion)
        {
            try
            {
                /*se crea una formacion auxiliar para poder guardar por separado primero la formacion y luego las relaciones con los coches.
                 en caso contrario fallaria por error de FK*/
                Formacion auxFormacion = new Formacion(unaFormacion.NombreFormacion);

                /*Aca se guarda unicamente la formacion para que la base autogenere el Id de la misma necesario para la FK*/
                _dataContext.GetTable<Formacion>().InsertOnSubmit(auxFormacion);
                _dataContext.SubmitChanges();

                /*se asigna el id de la formacion que se guardo a las relaciones ente los coches*/
                foreach (Formacion_X_Coche fc in unaFormacion.AuxCoches_LINQ.ToList<Formacion_X_Coche>())
                    fc.IdFormacion = auxFormacion.Id;

                /*Se guardan las relaciones entre la formacion y los coches*/
                auxFormacion.AuxCoches_LINQ = unaFormacion.AuxCoches_LINQ;
                _dataContext.SubmitChanges();

                return auxFormacion.Id;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Source);
                return -1;
            }
        }

        /*Borra a una formacion y la relacion entre dicha formacion y los coches. NO borra al coche*/
        public int BorrarFormacion(int id_formacion)
        {
            try
            {
                Formacion unaFormacion = (from fcs in _dataContext.GetTable<Formacion>()
                                        where fcs.Id == id_formacion
                                        select fcs).FirstOrDefault();

                foreach (Formacion_X_Coche fc in unaFormacion.AuxCoches_LINQ.ToList<Formacion_X_Coche>())
                    BorrarJoinFormacionCoche(fc.Id);

                _dataContext.GetTable<Formacion>().DeleteOnSubmit(unaFormacion);
                _dataContext.SubmitChanges();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Source);
                return -1;
            }
        }

        /*Guarda la relacion entre una formacion existente y un coche existente. Sirve para agregar coches una una formacion determinada*/
        public int GuardarJoinFormacionCoche(Formacion unaFormacion = null)
        {
            return GuardarModificacionesObjeto();
        }

        /*Borra la relacion entre una formacion y un coche sin eliminar a ninguno de los dos*/
        public int BorrarJoinFormacionCoche(int id_Formacion_X_Coche)
        {
            try
            {
                Formacion_X_Coche fc = (from fcs in _dataContext.GetTable<Formacion_X_Coche>()
                                        where fcs.Id == id_Formacion_X_Coche
                                        select fcs).FirstOrDefault();
                _dataContext.GetTable<Formacion_X_Coche>().DeleteOnSubmit(fc);
                _dataContext.SubmitChanges();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Source);
                return -1;
            }
        }

        /*Guarda un nuevo coche en la bd*/
        public int GuardarNuevoCoche(Coche unCoche)
        {
            try
            {
                _dataContext.GetTable<Coche>().InsertOnSubmit(unCoche);
                _dataContext.SubmitChanges();
                return unCoche.Id;
            }
            catch (Exception e)
            {
                //TODO: Poner el mensaje de error en un log de errores e.Source
                MessageBox.Show(e.Source);
                return -1;
            }
        }

        /*Borra un coche existente en la bd*/
        public int BorrarCoche(int id_coche)
        {
            try
            {
                Coche unCoche = this.GetCocheById(id_coche);
                _dataContext.GetTable<Coche>().DeleteOnSubmit(unCoche);
                _dataContext.SubmitChanges();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Source);
                return -1;
            }
        }

        /*obtiene una lista de todos los coches existentes en la bd*/
        public List<Coche> GetTodosLosCoches()
        {
            return (from coche in _dataContext.GetTable<Coche>()
                    select coche).ToList<Coche>();
        }

        /*obtiene un coche de la bd a partir de conocer su id*/
        public Coche GetCocheById(int id)
        {
            return (from coche in _dataContext.GetTable<Coche>()
                              where coche.Id == id
                              select coche).FirstOrDefault();
        }

#endregion

        /*Esta funcion la utilizo para hacer pruebas contra la base. No se usa en el modelo*/
        public void PruebasBD()
        {

        }
    }
}
