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

        public frmABMTraza()
        {
            InitializeComponent();

            context = new ffccSimulacionEntities();

            Trazas trazaSeleccionada;

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
            txtTraCreNombre.Clear();

            txtTraModNombre.Clear();

            for (int i = 0; i < clbTraCreServicios.Items.Count; i++)
            {
                clbTraCreServicios.SetItemChecked(i, false);

                clbTraModServicios.SetItemChecked(i, false);
            }
        }

        /*
         * Accion al pulsar el boton 'Agregar Servicio'
         */
        private void btnTraCreAgregarServicio_Click(object sender, EventArgs e)
        {
            frmABMServicio frmServicio = new frmABMServicio();

            frmServicio.ShowDialog(this);

            cargarServicios();
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
            else
            {
                modificarTraza();
            }
        }

        #endregion

        #region ABM Traza

        /*
         * Accion que se realiza cuando se agrega una Nueva Traza a la Base De Datos
         */ 
        private void agregarTraza()
        {
            string errorStr = "";

            if(!Util.EsAlfaNumerico(txtTraCreNombre.Text))
            {
                errorStr += "Nombre: Incompleto/Incorrecto\n";
            }

            try
            {
                Trazas nuevaTraza = new Trazas();

                nuevaTraza.Nombre = txtTraCreNombre.Text;

                foreach (var servicio in clbTraCreServicios.CheckedItems)
                {
                    nuevaTraza.AgregarServicio(context.Servicios.Where(x => x.Nombre == servicio).FirstOrDefault());
                }

                context.Trazas.Add(nuevaTraza);

                cargarTrazas();

                MessageBox.Show("Traza Guardada");
            }
            catch(Exception exc)
            {

            }
        }

        /*
         * Accion que se realiza cuando se modificar una Traza Existente en la Base de Datos
         */
        private void modificarTraza()
        {
            throw new NotImplementedException();
        }

        /*
         * Accion que se realiza cuando se elimina una Traza Existente en la Base de Datos
         */
        private void eliminarTraza()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Cargar Listas de Servicios y Trazas
        private void cargarServicios()
        {
            clbTraCreServicios.Items.Clear();

            clbTraModServicios.Items.Clear();

            context.Servicios.ToList().ForEach(x => { clbTraCreServicios.Items.Add(x.Nombre); clbTraModServicios.Items.Add(x.Nombre); });
        }

        private void cargarTrazas()
        {
            lstTraEliTrazas.Items.Clear();

            lstTraModTrazas.Items.Clear();

            context.Trazas.ToList().ForEach(x => { lstTraModTrazas.Items.Add(x.Nombre); lstTraEliTrazas.Items.Add(x.Nombre); });
        }

        #endregion
    }
}
