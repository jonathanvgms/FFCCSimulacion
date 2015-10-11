using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ffccSimulacion.ABMServicio;
using ffccSimulacion.Modelo;

namespace ffccSimulacion.ABMTraza
{
    public partial class frmABMTraza : Form
    {
        ffccSimulacionEntities context;

        Trazas trazaSeleccionada;

        public frmABMTraza()
        {
            InitializeComponent();

            context = new ffccSimulacionEntities();

            clbTraCreServicios.DisplayMember = "Nombre";

            clbTraModServicios.DisplayMember = "Nombre";

            cargarServicios();

            cargarTrazas();
        }

        #region Acciones de los Botones
        /*
         * Accion al pulsar el boton 'Cancelar'
         */ 
        private void btnTraCancelar_Click(object sender, EventArgs e)
        {
            this.pnlTraza.Controls.Clear();
            this.Close();
        }

        /*
         * Accion al pulsar el boton 'Limpiar'
         */
        private void btnTraLimpiar_Click(object sender, EventArgs e)
        {
            limpiarFormulario();
        }

        /*
         * Accion al pulsar el boton 'Agregar Servicio'
         */
        private void btnTraCreAgregarServicio_Click(object sender, EventArgs e)
        {
            agregarNuevoServicio();
        }

        private void btnTraModAgregarServicio_Click(object sender, EventArgs e)
        {
            agregarNuevoServicio();
        }

        /*
         * Accion al pulsar 'Borrar Traza'
         */ 
        private void btnTraElBorrarTraza_Click(object sender, EventArgs e)
        {
            eliminarTraza();
        }

        /*
         * Accion al pulsar el boton 'Aceptar'
         */
        private void btnTraAceptar_Click(object sender, EventArgs e)
        {
            if(tclTraza.SelectedTab == tabCrearTraza)
            {
                agregarTraza();
            }
            else if (tclTraza.SelectedTab == tabModificarTraza)
            {
                modificarTraza();
            }
        }

        #endregion

        #region Casos de Uso

        /*
         * Caso de Uso: 'Agregar Traza'
         */ 
        private void agregarTraza()
        {
            string errorStr = "";

            if(!Util.EsAlfaNumerico(txtTraCreNombre.Text))
            {
                errorStr += "Nombre: Incompleto/Incorrecto\n";
            }

            if (clbTraCreServicios.CheckedItems.Count == 0)
            {
                errorStr += "Servicios: Seleccionar";
            }

            if (errorStr.Length == 0)
            {
                try
                {
                    Trazas nuevaTraza = new Trazas();

                    nuevaTraza.Nombre = txtTraCreNombre.Text;

                    foreach (Servicios s in clbTraCreServicios.CheckedItems)
                    {
                        nuevaTraza.AgregarServicio(s);
                    }

                    context.Trazas.Add(nuevaTraza);

                    context.SaveChanges();

                    MessageBox.Show("Traza Guardada");

                    cargarTrazas();

                    limpiarFormulario();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Traza No Guardada\n\nError\n\n" + exc.Message);
                }
           }
        }

        /*
         * Caso de Uso: 'Modificar Traza'
         */
        private void modificarTraza()
        {
            string errorStr = "";

            if (!Util.EsAlfaNumerico(txtTraModNombre.Text))
            {
                errorStr += "Nombre: Incompleto/Incorrecto\n";
            }

            if (clbTraModServicios.CheckedItems.Count == 0)
            {
                errorStr += "Servicio: Seleccionar";
            }

            if (errorStr.Length == 0)
            {
                try
                {
                    trazaSeleccionada = (Trazas)lstTraModTrazas.SelectedItem;

                    trazaSeleccionada.Nombre = txtTraModNombre.Text;

                    //borro las relaciones existentes en la base de datos
                    context.Trazas_X_Servicios.Where(x => x.Id_Traza == trazaSeleccionada.Id).ToList().ForEach(y => context.Trazas_X_Servicios.Remove(y));

                    //agrego la configuracion del checklistbox
                    foreach (Servicios s in clbTraModServicios.CheckedItems)
                    {
                        trazaSeleccionada.AgregarServicio(s);
                    }

                    context.SaveChanges();

                    MessageBox.Show("Traza Guardada");

                    cargarTrazas();

                    limpiarFormulario();
                }
                catch(Exception exc)
                {
                    MessageBox.Show("Traza No Guardada\n\nError\n\n" + exc.Message);
                }
            }
            else
            {
                MessageBox.Show(errorStr);
            }
        }
        
        /*
         * Caso de Uso: 'Eliminar Traza'
         */
        private void eliminarTraza()
        {
            try
            {
                trazaSeleccionada = context.Trazas.Where(x => x.Nombre == lstTraEliTrazas.SelectedItem.ToString()).FirstOrDefault();

                context.Trazas.Remove(trazaSeleccionada);

                context.SaveChanges();

                MessageBox.Show("Traza Eliminada");

                cargarTrazas();
            }
            catch(Exception exc)
            {
                MessageBox.Show("Traza No Eliminada\n\nCausa\n\n1) Hay Servicios Asignados a esta Traza\n2) La Traza está Asignada a una Simulación");
            }
        }

        #endregion

        #region Cargar Listas de Servicios y Trazas
        private void cargarServicios()
        {
            clbTraCreServicios.Items.Clear();

            clbTraModServicios.Items.Clear();

            context.Servicios.ToList().ForEach(x => { clbTraCreServicios.Items.Add(x); clbTraModServicios.Items.Add(x); });
        }

        private void cargarTrazas()
        {
            lstTraEliTrazas.Items.Clear();

            lstTraModTrazas.Items.Clear();

            context.Trazas.ToList().ForEach(x => { lstTraModTrazas.Items.Add(x); lstTraEliTrazas.Items.Add(x); });
        }

        #endregion

        #region Metodos Auxiliares

        /*
         * Evento que sucede cuando se selecciona una Traza de la lista
         */
        private void seleccionarTraza(object sender, EventArgs e)
        {
            trazaSeleccionada = (Trazas)lstTraModTrazas.SelectedItem;
            
            txtTraModNombre.Text = trazaSeleccionada.Nombre;

            for (int i = 0; i < clbTraModServicios.Items.Count; i++)
            {
                clbTraModServicios.SetItemChecked(i, false);
            }

            foreach (Servicios s in trazaSeleccionada.ServiciosDisponibles)
            {
                clbTraModServicios.SetItemChecked(clbTraModServicios.Items.IndexOf(s), true);
            }
        }

        private void agregarNuevoServicio()
        {
            frmABMServicio frmServicio = new frmABMServicio();

            frmServicio.ShowDialog(this);

            cargarServicios();
        }

        private void limpiarFormulario()
        {
            txtTraCreNombre.Clear();

            txtTraModNombre.Clear();

            for (int i = 0; i < clbTraCreServicios.Items.Count; i++)
            {
                clbTraCreServicios.SetItemChecked(i, false);

                clbTraModServicios.SetItemChecked(i, false);
            }
        }

        #endregion
               
    }
}