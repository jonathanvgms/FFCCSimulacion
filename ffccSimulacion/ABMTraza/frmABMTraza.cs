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
            else
            {
                MessageBox.Show(errorStr);
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
            string errorMsj = "";
            trazaSeleccionada = (Trazas)lstTraEliTrazas.SelectedItem;

            if (lstTraEliTrazas.SelectedItem == null)
            {
                errorMsj += "No se ha seleccionado ninguna traza para eliminar.\n";
            }
            else if(context.Simulaciones.Any(x => x.Id_Traza == trazaSeleccionada.Id))
            {
                errorMsj += "La traza no puede eliminarse porque pertenece a una simulación.\n";
            }

            if (string.IsNullOrEmpty(errorMsj))
            {
                try
                {
                    if (MessageBox.Show("La traza se eliminará de manera permanente. ¿Desea continuar?", "", MessageBoxButtons.OKCancel) == DialogResult.Cancel) return;

                    trazaSeleccionada = (Trazas)lstTraEliTrazas.SelectedItem;

                    //borro todos los servicios asignados a la traza
                    context.Trazas_X_Servicios.Where(x => x.Id_Traza == trazaSeleccionada.Id).ToList().ForEach(y => context.Trazas_X_Servicios.Remove(y));

                    context.Trazas.Remove(trazaSeleccionada);

                    context.SaveChanges();

                    cargarTrazas();

                    limpiarFormulario();

                    MessageBox.Show("Traza Eliminada");
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
            else
            {
                MessageBox.Show(errorMsj);
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

            lstTraCreResultados.Items.Clear();

            context.Trazas.ToList().ForEach(x => { lstTraModTrazas.Items.Add(x); lstTraEliTrazas.Items.Add(x); lstTraCreResultados.Items.Add(x); });
        }

        #endregion

        #region Metodos Auxiliares

        /*
         * Evento que sucede cuando se selecciona una Traza de la lista para modificar                                                    
         */
        private void seleccionarTraza(object sender, EventArgs e)
        {
            if (lstTraModTrazas.SelectedIndex > -1)
            {
                habilitarModificar();

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

        private void seleccionarPestaña(object sender, TabControlEventArgs e)
        {
            if(tclTraza.SelectedTab == tabCrearTraza)
            {
                btnTraAceptar.Enabled = true;
                btnTraLimpiar.Enabled = true;
            }
            if (tclTraza.SelectedTab == tabModificarTraza)
            {
                btnTraAceptar.Enabled = true;
                btnTraLimpiar.Enabled = true;
                deshabilitarModificar();
            }
            if (tclTraza.SelectedTab == tabEliminarTraza)
            {
                btnTraAceptar.Enabled = false;
                btnTraLimpiar.Enabled = false;
            }
        }

        private void actualizarTraza(TextBox buscarTraza, ListBox resultados)
        {
            if (!String.IsNullOrEmpty(buscarTraza.Text) && Util.EsAlfaNumerico(buscarTraza.Text))
            {
                resultados.Items.Clear();
                context.Trazas.Where(x => x.Nombre.Contains(buscarTraza.Text)).ToList().ForEach(y => resultados.Items.Add(y));
            }
            else
            {
                cargarTrazas();
            }
            deshabilitarModificar();
            limpiarFormulario();
        }

        private void deshabilitarModificar()
        {
            txtTraModNombre.Enabled = false;
            clbTraModServicios.Enabled = false;
        }

        private void habilitarModificar()
        {
            txtTraModNombre.Enabled = true;
            clbTraModServicios.Enabled = true;
        }

        private void buscarTraza(object sender, EventArgs e)
        {
            if (tclTraza.SelectedTab == tabCrearTraza)
            {
                actualizarTraza(txtTraCreBuscar, lstTraCreResultados);
            }
            else if (tclTraza.SelectedTab == tabModificarTraza)
            {
                actualizarTraza(txtTraModBuscar, lstTraModTrazas);
            }
            else
            {
                actualizarTraza(txtTraEliBuscar, lstTraEliTrazas);
            }
        }

        #endregion

        private void simulacionesAsociadas(object sender, EventArgs e)
        {
            if (lstTraEliTrazas.SelectedIndex > -1)
            {
                Simulaciones s;
                lstTraEliSimulaciones.Items.Clear();
                context.Simulaciones.Where(x => x.Id_Traza == ((Trazas)lstTraEliTrazas.SelectedItem).Id).ToList().ForEach(y => lstTraEliSimulaciones.Items.Add(y));
            }
        }
    }
}