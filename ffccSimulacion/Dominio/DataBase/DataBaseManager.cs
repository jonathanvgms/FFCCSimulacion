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
                List<Formacion_X_Coche> listaCoches = unaFormacion.AuxCoches_LINQ.ToList<Formacion_X_Coche>();
                unaFormacion.BlanquearListaParaSave();
                _dataContext.GetTable<Formacion>().InsertOnSubmit(unaFormacion);
                _dataContext.SubmitChanges();

                foreach(Formacion_X_Coche fc in listaCoches)
                {
                    fc.IdFormacion = unaFormacion.Id;
                    _dataContext.GetTable<Formacion_X_Coche>().InsertOnSubmit(fc);
                }
                _dataContext.SubmitChanges();
                return unaFormacion.Id;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Source);
                return -1;
            }
        }

        public int GuardarModificacionesFormacion(Formacion unaFormacion)
        {
            try
            {
                List<Formacion_X_Coche> listaCoches = unaFormacion.AuxCoches_LINQ.ToList<Formacion_X_Coche>();
                unaFormacion.BlanquearListaParaSave();
                _dataContext.SubmitChanges();

                foreach (Formacion_X_Coche fc in listaCoches)
                {
                    if (fc.Id != 0)
                    {
                        Formacion_X_Coche auxFC = (from joins in _dataContext.GetTable<Formacion_X_Coche>() where joins.Id == fc.Id select joins).FirstOrDefault();
                        auxFC.IdCoche = fc.IdCoche;
                        auxFC.IdFormacion = fc.IdFormacion;
                        auxFC.VecesCocheRepetido = fc.VecesCocheRepetido;
                        auxFC.UnCoche = fc.UnCoche;
                        _dataContext.SubmitChanges();
                    }
                    else
                    {
                        fc.IdFormacion = unaFormacion.Id;
                        _dataContext.GetTable<Formacion_X_Coche>().InsertOnSubmit(fc);
                        _dataContext.SubmitChanges();
                    }
                }

                return 1;
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
                DataContext dc = new DataContext(_cadenaConexion);
                Formacion unaFormacion = (from fcs in dc.GetTable<Formacion>()
                                          where fcs.Id == id_formacion
                                          select fcs).FirstOrDefault();

                foreach (Formacion_X_Coche fc in unaFormacion.AuxCoches_LINQ.ToList<Formacion_X_Coche>())
                {
                    DataContext dc2 = new DataContext(_cadenaConexion);
                    Formacion_X_Coche fc2 = (from joins in dc2.GetTable<Formacion_X_Coche>()
                                             where joins.Id == fc.Id
                                             select joins).FirstOrDefault();
                    dc2.GetTable<Formacion_X_Coche>().DeleteOnSubmit(fc2);
                    dc2.SubmitChanges();
                    dc2.Dispose();
                }

                dc.Dispose();
                dc = new DataContext(_cadenaConexion);
                unaFormacion = (from fcs in dc.GetTable<Formacion>()
                                where fcs.Id == id_formacion
                                select fcs).FirstOrDefault();
                dc.GetTable<Formacion>().DeleteOnSubmit(unaFormacion);
                dc.SubmitChanges();
                dc.Dispose();
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

                foreach (Servicio_X_Formacion sf in unServicio.AuxCoches_LINQ)
                    sf.Id_Servicio = auxServicio.Id;

                auxServicio.Relaciones = unServicio.Relaciones;
                auxServicio.AuxCoches_LINQ = unServicio.AuxCoches_LINQ;

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

                foreach (Servicio_X_Formacion sf in s.AuxCoches_LINQ)
                    BorrarJoinServicioFormacion(sf.Id);

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

        public int BorrarJoinServicioFormacion(int id_join_servicio_formacion)
        {
            try
            {
                Servicio_X_Formacion sf = (from joins in _dataContext.GetTable<Servicio_X_Formacion>()
                                           where joins.Id == id_join_servicio_formacion
                                           select joins).FirstOrDefault();
                _dataContext.GetTable<Servicio_X_Formacion>().DeleteOnSubmit(sf);
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

        #region Trazas

        public List<Traza> GetTodasLasTrazas()
        {
            List<Traza> listaTrazas = (from trazas in _dataContext.GetTable<Traza>()
                                        select trazas).ToList<Traza>();
            foreach (Traza t in listaTrazas)
                t.CargarLosServicios();

            return listaTrazas;
        }

        public Traza GetTrazaById(int id_traza)
        {
            Traza t = (from trazas in _dataContext.GetTable<Traza>()
                       where trazas.Id == id_traza
                       select trazas).FirstOrDefault();
            t.CargarLosServicios();
            return t;
        }

        public int BorrarJoinTrazaServicio(int id_join_TrazaServicio)
        {
            try
            {
                Traza_X_Servicio ts = (from joins in _dataContext.GetTable<Traza_X_Servicio>()
                                       where joins.Id == id_join_TrazaServicio
                                       select joins).FirstOrDefault();
                _dataContext.GetTable<Traza_X_Servicio>().DeleteOnSubmit(ts);
                _dataContext.SubmitChanges();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Source);
                return -1;
            }
        }

        public int BorrarTraza(int id_traza)
        {
            try
            {
                Traza t = (from trazas in _dataContext.GetTable<Traza>()
                           where trazas.Id == id_traza
                           select trazas).FirstOrDefault();

                foreach (Traza_X_Servicio ts in t.AuxServicios_LINQ)
                    BorrarJoinTrazaServicio(ts.Id);

                _dataContext.GetTable<Traza>().DeleteOnSubmit(t);
                _dataContext.SubmitChanges();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Source);
                return -1;
            }
        }

        public int GuardarNuevaTraza(Traza unaTraza)
        {
            try
            {
                Traza auxTraza = new Traza(unaTraza.Nombre);
                _dataContext.GetTable<Traza>().InsertOnSubmit(auxTraza);
                _dataContext.SubmitChanges();

                foreach (Traza_X_Servicio ts in unaTraza.AuxServicios_LINQ)
                    ts.Id_Traza = auxTraza.Id;

                auxTraza.AuxServicios_LINQ = unaTraza.AuxServicios_LINQ;
                _dataContext.SubmitChanges();
                return auxTraza.Id;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Source);
                return -1;
            }
        }

        #endregion

        #region Simulaciones

        public List<Simulacion> GetTodasLasSimulaciones()
        {
            List<Simulacion> listaSimulaciones = (from simulaciones in _dataContext.GetTable<Simulacion>()
                                                  select simulaciones).ToList<Simulacion>();
            foreach (Simulacion s in listaSimulaciones)
                s.ConfigurarSimulador();

            return listaSimulaciones;
        }

        public Simulacion GetSimulacionById(int id_simulacion)
        {
            Simulacion s = (from simulaciones in _dataContext.GetTable<Simulacion>()
                            where simulaciones.Id == id_simulacion
                            select simulaciones).FirstOrDefault();
            s.ConfigurarSimulador();
            return s;
        }

        public int BorrarSimulacion(int id_simulacion)
        {
            try
            {
                Simulacion s = GetSimulacionById(id_simulacion);
                _dataContext.GetTable<Simulacion>().DeleteOnSubmit(s);
                _dataContext.SubmitChanges();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Source);
                return -1;
            }
        }

        public int GuardarNuevaSimulacion(Simulacion unaSimulacion)
        {
            try
            {
                _dataContext.GetTable<Simulacion>().InsertOnSubmit(unaSimulacion);
                _dataContext.SubmitChanges();
                return unaSimulacion.Id;
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
            int id_objeto;
            int resultado = 0;
            /*Prueba Guardar nuevo Coche*/
            /*Coche LocomotoraNuevo = new Coche("LocoQueen", true, TipoConsumo.Disel, 50, 20, 0, 0, 0);
            id_objeto = GuardarNuevoCoche(LocomotoraNuevo);
            Coche CocheNuevo = new Coche("CocheFredie", false, TipoConsumo.Disel, 0, 0, 50, 80, 150);
            id_objeto = GuardarNuevoCoche(CocheNuevo);*/

            /*Recuperar un coche existente, modificarlo y volverlo a guardar*/
            /*Coche cocheExistente = GetCocheById(4);
            cocheExistente.Modelo = "Locomotora Mod1";
            id_objeto = GuardarModificacionesObjeto();*/

            /*Crear un coche para luego eliminarlo*/
            /*Coche CocheParaEliminar = new Coche("Coche Elimina", true, TipoConsumo.Disel, 50, 20, 0, 0, 0);
            id_objeto = GuardarNuevoCoche(CocheParaEliminar);
            resultado = BorrarCoche(id_objeto);*/

            /*Se crea una nueva formacion, se le asignan coches y se guardan en la bd, opcionalmente se la puede borrar la formacion*/
            /*Formacion nuevaFormacion = new Formacion("FormacionPruebas");

            Coche Locomotora = GetCocheById(4);
            Coche VagonComun = GetCocheById(5);
            nuevaFormacion.agregarCoche(Locomotora, 1);
            nuevaFormacion.agregarCoche(VagonComun, 5);

            id_objeto = GuardarNuevaFormacion(nuevaFormacion);*/

            //BorrarFormacion(id_objeto);

            /*Obtener un formacion a partir de un ID, agregar un coche existente a la formacion y guardar*/
            /*Coche cocheExistente = GetCocheById(7);
            Formacion formacionExistente = GetFormacionById(41);
            formacionExistente.agregarCoche(cocheExistente, 2);

            GuardarModificacionesFormacion(formacionExistente);*/
            
            /*Se crea 2 incidentes y se guardan en la bd*/
            /*Incidente nuevoIncidente1 = new Incidente("Via Cortada", "se corto una via", 20, 10);
            Incidente nuevoIncidente2 = new Incidente("Piquite", "gente se manifiesta sobre las vias", 20, 10);
            GuardarNuevoIncidente(nuevoIncidente1);
            GuardarNuevoIncidente(nuevoIncidente2);*/

            /*Se crea incidente para borrarlo despues*/
            /*Incidente nuevoIncidente3 = new Incidente("IncidenteElimina", "", 20, 10);
            id_objeto = GuardarNuevoIncidente(nuevoIncidente3);
            BorrarUnIncidente(id_objeto);*/

            /*Se crea una estacion, se le asignan 2 incidentes existentes y se guarda en la bd*/
            /*Incidente incidente1 = GetIncidenteById(1);
            Incidente incidente2 = GetIncidenteById(2);
            Estacion nuevaEstacion = new Estacion("EstacionPirulito", 100, 300, TipoFDP.Normal);
            nuevaEstacion.AgregarIncidente(incidente1);
            nuevaEstacion.AgregarIncidente(incidente2);
            GuardarNuevaEstacion(nuevaEstacion);*/
        }
    }
}
