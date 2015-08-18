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
    /*NOTAS:
     - Todos los metodos de guardar retornar en casos exitos el id del objeto y en caso contrario -1
     - Todos los metodos borrar retorna 1 si fue exitoso o -1 en caso contrario*/
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

        /*Esta funciona permite guarda cualquier modificacion que se le haga a un objeto traido de la bd, asi como tambien permite agregar cualquier nuevo join
         de cualquier clase. Es el update*/
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

        #region Formaciones y Coches

        /*obtiene una lista de todas las formaciones existentes en la bd*/
        public List<Formacion> GetAllFormaciones()
        {
            List<Formacion> todaFormacion = (from formaciones in _dataContext.GetTable<Formacion>()
                                             select formaciones).ToList<Formacion>();
            foreach (Formacion f in todaFormacion)
                f.CargarCochesDeLaFormacion();
            return todaFormacion;
        }

        /*obtiene una formacion especifica a paritr de su id en la base*/
        public Formacion GetFormacionById(int id_formacion)
        {
            Formacion f = (from formaciones in _dataContext.GetTable<Formacion>()
                           where formaciones.Id == id_formacion
                           select formaciones).FirstOrDefault();
            f.CargarCochesDeLaFormacion();
            return f;
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

        #region Incidentes

        public List<Incidente> GetTodosLosIncidentes()
        {
            return (from incidentes in _dataContext.GetTable<Incidente>()
                    select incidentes).ToList<Incidente>();
        }

        public Incidente GetIncidenteById(int id_incidente)
        {
            return (from incidentes in _dataContext.GetTable<Incidente>()
                    where incidentes.Id == id_incidente
                    select incidentes).FirstOrDefault();
        }

        public int GuardarNuevoIncidente(Incidente unIncidente)
        {
            try
            {
                _dataContext.GetTable<Incidente>().InsertOnSubmit(unIncidente);
                _dataContext.SubmitChanges();
                return unIncidente.Id;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Source);
                return -1;
            }
        }

        public int BorrarUnIncidente(int id_incidente)
        {
            try
            {
                Incidente i = this.GetIncidenteById(id_incidente);
                _dataContext.GetTable<Incidente>().DeleteOnSubmit(i);
                _dataContext.SubmitChanges();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Source);
                return -1;
            }
        }

        public int BorrarJoinEstacionIncidente(int id_estacion_X_incidente)
        {
            try
            {
                Estacion_X_Incidente ei = (from eiJoins in _dataContext.GetTable<Estacion_X_Incidente>()
                                           where eiJoins.Id == id_estacion_X_incidente
                                           select eiJoins).FirstOrDefault();
                _dataContext.GetTable<Estacion_X_Incidente>().DeleteOnSubmit(ei);
                _dataContext.SubmitChanges();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Source);
                return -1;
            }
        }

        #endregion

        #region Estaciones

        public List<Estacion> GetTodasLasEstaciones()
        {
            List<Estacion> todasEstaciones = (from estaciones in _dataContext.GetTable<Estacion>()
                                               select estaciones).ToList<Estacion>();
            foreach (Estacion e in todasEstaciones)
                e.CargarIncidentesPosibles();
            
            return todasEstaciones;
        }

        public Estacion GetEstacionById(int id_estacion)
        {
            Estacion e = (from estaciones in _dataContext.GetTable<Estacion>()
                          where estaciones.Id == id_estacion
                          select estaciones).FirstOrDefault();
            e.CargarIncidentesPosibles();
            return e;
        }

        public int GuardarNuevaEstacion(Estacion unaEstacion)
        {
            try
            {
                Estacion estAux = new Estacion(unaEstacion.Nombre, unaEstacion.PersonasEsperandoMin, unaEstacion.PersonasEsperandoMax, unaEstacion.FDPEstacion);
                _dataContext.GetTable<Estacion>().InsertOnSubmit(estAux);

                foreach (Estacion_X_Incidente ei in unaEstacion.AuxIncidentes_LINQ.ToList<Estacion_X_Incidente>())
                    ei.Id_Estacion = estAux.Id;

                estAux.AuxIncidentes_LINQ = unaEstacion.AuxIncidentes_LINQ;
                _dataContext.SubmitChanges();
                return estAux.Id;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Source);
                return -1;
            }
        }

        public int BorrarUnaEstacion(int id_estacion)
        {
            try
            {
                Estacion e = this.GetEstacionById(id_estacion);
                foreach (Estacion_X_Incidente ei in e.AuxIncidentes_LINQ.ToList<Estacion_X_Incidente>())
                    this.BorrarJoinEstacionIncidente(ei.Id);

                _dataContext.GetTable<Estacion>().DeleteOnSubmit(e);
                _dataContext.SubmitChanges();

                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Source);
                return -1;
            }
        }

        #endregion

        #region Relacion (relacion entre las estaciones y los servicios)

        public int BorrarRelacion(int id_relacion)
        {
            try
            {
                Relacion r = (from relaciones in _dataContext.GetTable<Relacion>()
                              where relaciones.Id == id_relacion
                              select relaciones).FirstOrDefault();
                _dataContext.GetTable<Relacion>().DeleteOnSubmit(r);
                _dataContext.SubmitChanges();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Source);
                return -1;
            }
        }

        #endregion

        #region Servicios

        public List<Servicio> GetTodosLosServicios()
        {
            List<Servicio> ls = (from servicios in _dataContext.GetTable<Servicio>()
                                select servicios).ToList<Servicio>();

            foreach (Servicio s in ls)
                s.ConfigurarServicio();
            return ls;
        }

        public Servicio GetServicioById(int id_servicio)
        {
            Servicio unServicio = (from servicios in _dataContext.GetTable<Servicio>()
                                   where servicios.Id == id_servicio
                                   select servicios).FirstOrDefault();
            unServicio.ConfigurarServicio();
            return unServicio;
        }

        public int GuardarNuevoServicio(Servicio unServicio)
        {
            try
            {
                Servicio auxServicio = new Servicio(unServicio.Nombre);
                _dataContext.GetTable<Servicio>().InsertOnSubmit(auxServicio);
                _dataContext.SubmitChanges();

                foreach (Relacion r in unServicio.Relaciones)
                    r.Id_Servicio = auxServicio.Id;

                auxServicio.Relaciones = unServicio.Relaciones;
                _dataContext.SubmitChanges();
                return auxServicio.Id;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Source);
                return -1;
            }
        }

        public int BorrarServicio(int id_servicio)
        {
            try
            {
                Servicio s = GetServicioById(id_servicio);
                foreach (Relacion r in s.Relaciones)
                    BorrarRelacion(r.Id);
                _dataContext.GetTable<Servicio>().DeleteOnSubmit(s);
                _dataContext.SubmitChanges();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Source);
                return -1;
            }
        }

        #endregion

        /*Esta funcion la utilizo para hacer pruebas contra la base. No se usa en el modelo*/
        public void PruebasBD()
        {

        }
    }
}
