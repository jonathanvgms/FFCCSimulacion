using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ffccSimulacion.Modelo;

namespace ffccSimulacion.ABMIncidente
{
    public partial class frmABMIncidente : Form
    {
        ffccSimulacionEntities context;

        Incidentes incidenteSeleccionado;

        public frmABMIncidente()
        {
            InitializeComponent();

            context = new ffccSimulacionEntities();
            
            cargarIncidentes();

            deshabilitarModificar();
        }

        #region Accion de apretar botones
        /*
         * Accion al pulsar el boton 'Cancelar'
         */  
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlInicidente.Controls.Clear();

            Close();
        }

        /*
         * Accion al pulsar el boton 'Aceptar'
         */ 
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(tabControl1.SelectedTab == tabCrear)
            {
                tab_CrearIncidente();

            }
            else if (tabControl1.SelectedTab == tabModificar)
            {
                tab_ModificarIncidente();
            }
        }

        /*
         * Accion al pulsar el boton 'Limpiar'
         */
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarFormulario();
        }

        /*
         * Accion al pulsar el boton 'Eliminar Incidente'
         */ 
        private void btnEliminarIncidente_Click(object sender, EventArgs e)
        {
            borrarIncidente();
        }

        #endregion

        #region Accion de Cargar Incidentes
        private void cargarIncidentes()
        {
            lstIncidenteCrear.Items.Clear();

            lstIncMod.Items.Clear();

            lstIncEli.Items.Clear();

            context.Incidentes.ToList().ForEach(x => { lstIncMod.Items.Add(x); lstIncEli.Items.Add(x); lstIncidenteCrear.Items.Add(x); });
        }

        #endregion

        #region Casos de Uso
        /*
         * Caso de Uso 'Crear Incidente'
         */ 
        private void tab_CrearIncidente()
        {
            string errorMsj = "";

            if (!Util.EsAlfaNumerico(txtIncCreNom.Text))
            {
                errorMsj += "Nombre: Incompleto ó Incorrecto.\n";
            }
            else if (context.Incidentes.Any(x => x.Nombre == txtIncCreNom.Text))
            {
                errorMsj += "El Incidente existe en el Sistema, ingrese otro.\n";
            }

            if (!Util.EsAlfabetico(txtincCreDes.Text))
            {
                errorMsj += "Descripción: Incompleta ó Incorrecta.\n";
            }

            if (!Util.EsNumerico(txtbIncCreTiem.Text))
            {
                errorMsj += "Tiempo de Demora: Incompleto ó Incorrecto.\n";
            }

            if ((cbmIncCrePro.SelectedIndex < 0) || (cbmIncCrePro.SelectedItem.ToString() == ""))
            {
                errorMsj += "Falta Seleccionar la Probabilidad de Ocurrencia.\n";
            }

            if (String.IsNullOrEmpty(errorMsj))
            {
                try
                {
                    context.Incidentes.Add(new Incidentes
                    {
                        Nombre = txtIncCreNom.Text,
                        Descripcion = txtincCreDes.Text,
                        ProbabilidadOcurrencia = Convert.ToInt32(cbmIncCrePro.SelectedItem.ToString()),
                        TiempoDemora = Convert.ToInt32(txtbIncCreTiem.Text)
                    });

                    context.SaveChanges();

                    cargarIncidentes();

                    limpiarFormulario();
                    
                    txtIncEliBuscar.Clear();

                    txtIncModBuscar.Clear();

                    MessageBox.Show("Incidente Guardado");
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Incidente No Guardado\n\nError\n\n" + exc.Message);
                }
            }
            else
            {
                MessageBox.Show(errorMsj);
            }
        }
        
        /*
        * Caso de Uso 'Modificar Incidente'
        */ 
        private void tab_ModificarIncidente()
        {
            string errorMsj = "";

            if (!Util.EsAlfaNumerico(txtModNombre.Text))
            {
                errorMsj += "Nombre: Incompleto ó Incorrecto.\n";
            }
            else if (context.Incidentes.Where(x => x.Nombre == txtModNombre.Text).Count() > 1)
            {
                errorMsj += "El Incidente existe en el Sistema, ingrese otro.\n";
            }

            if (!Util.EsAlfabetico(txtModDes.Text))
            {
                errorMsj += "Descripción: Incompleto ó Incorrecto.\n";
            }

            if (!Util.EsNumerico(txtModDem.Text))
            {
                errorMsj += "Tiempo de Demora: Incompleto ó Incorrecto.\n";
            }

            if (verificarRango(txtModDem.Text))
            {
                errorMsj += "Tiempo de Demora: El rango de tiempo deber ser, 0 a 999999999 (9 Cifras)\n";
            }

            if ((cmbModProb.SelectedIndex < 0) || (cmbModProb.SelectedItem.ToString().Length == 0))
            {
                errorMsj += "Falta Seleccionar la Probabilidad de Ocurrencia.\n";
            }

            if (String.IsNullOrEmpty(errorMsj))
            {
                try
                {
                    incidenteSeleccionado.Nombre = txtModNombre.Text;

                    incidenteSeleccionado.Descripcion = txtModDes.Text;

                    incidenteSeleccionado.ProbabilidadOcurrencia = Convert.ToInt32(cmbModProb.SelectedItem.ToString());

                    incidenteSeleccionado.TiempoDemora = Convert.ToInt32(txtModDem.Text);

                    context.SaveChanges();

                    cargarIncidentes();

                    txtIncEliBuscar.Clear();

                    txtIncModBuscar.Clear();

                    deshabilitarModificar();

                    limpiarFormulario();

                    MessageBox.Show("Las modificaciones han sido guardadas.");
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Incidente No Guardado\n\nError\n\n" + exc.Message);
                }
            }
            else
            {
                MessageBox.Show(errorMsj);
            }
        }

        /*
         * Caso de Uso 'Borrar Incidente' 
         */
        private void borrarIncidente()
        {
            string errorMsj = "";
            incidenteSeleccionado = (Incidentes) lstIncEli.SelectedItem;

            if (lstIncEli.SelectedItem == null)
            {
                errorMsj += "No se ha seleccionado ningun incidente para eliminar.\n";
            }
            else if (context.Estaciones_X_Incidentes.Any(x => x.Id_Incidente == incidenteSeleccionado.Id))
            {
                errorMsj += "El incidente no puede eliminarse porque pertenece a una estación.\n";
            }

            if (string.IsNullOrEmpty(errorMsj))
            {
                try
                {
                    if (MessageBox.Show("El incidente se eliminará de manera permanente. ¿Desea continuar?", "", MessageBoxButtons.OKCancel) == DialogResult.Cancel) return;

                    incidenteSeleccionado = (Incidentes)lstIncEli.SelectedItem;

                    context.Incidentes.Remove(incidenteSeleccionado);

                    context.SaveChanges();

                    cargarIncidentes();

                    limpiarFormulario();

                    txtIncEliBuscar.Clear();

                    txtIncModBuscar.Clear();

                    MessageBox.Show("Incidente Eliminado");
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

        #region Métodos Auxiliares
        /*
         * Evento que sucede cuando se selecciona un Incidente de la lista
         */ 
        private void seleccionarIncidente(object sender, EventArgs e)
        {
            if (lstIncMod.SelectedIndex > -1)
            {
                habilitarModificar();

                incidenteSeleccionado = (Incidentes)lstIncMod.SelectedItem;

                txtModNombre.Text = incidenteSeleccionado.Nombre;

                txtModDes.Text = incidenteSeleccionado.Descripcion;

                txtModDem.Text = incidenteSeleccionado.TiempoDemora.ToString();

                cmbModProb.SelectedIndex = cmbModProb.Items.IndexOf(incidenteSeleccionado.ProbabilidadOcurrencia.ToString());
            }
        }

        /*
         * Limpiar los TextBox y CheckBoxList de Crear Incidente y Modificar Incidente
         */ 
        private void limpiarFormulario()
        {
            txtIncCreNom.Clear();

            txtincCreDes.Clear();

            txtbIncCreTiem.Clear();

            cbmIncCrePro.SelectedIndex = 0;

            txtModNombre.Clear();

            txtModDem.Clear();

            txtModDes.Clear();

            cmbModProb.SelectedIndex = 0;
        }
        
        /*
         * verifica que el rango sea de hasta 9 cifras
         */ 
        private bool verificarRango(string cifra)
        {
            if (cifra.Length > 9)
            {
                return true;
            }

            return false;
        }

        #endregion               

        private void selecionarPestaña(object sender, TabControlEventArgs e)
        {
            if (tabControl1.SelectedTab == tabCrear)
            {
                btnLimpiar.Enabled = true;
                btnAceptar.Enabled = true;
                deshabilitarModificar();
                limpiarFormulario();
            }
            else if (tabControl1.SelectedTab == tabModificar)
            {
                btnLimpiar.Enabled = true;
                btnAceptar.Enabled = true;                
            }
            else
            {
                btnLimpiar.Enabled = false;
                btnAceptar.Enabled = false;
                deshabilitarModificar();
                limpiarFormulario();
                lstIncMod.SelectedIndex = -1;
            }
        }

        private void buscarIncidente(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabModificar)
            {
                actualizarListado(txtIncModBuscar, lstIncMod);
            }
            if (tabControl1.SelectedTab == tabEliminar)
            {
                actualizarListado(txtIncEliBuscar, lstIncEli);
            }
            else
            {
                actualizarListado(txtIncCreBuscar, lstIncidenteCrear);
            }

            limpiarFormulario();
        }

        private void actualizarListado(TextBox txtBuscar, ListBox resultado)
        {
            if (!String.IsNullOrEmpty(txtBuscar.Text) && Util.EsAlfaNumerico(txtBuscar.Text))
            {
                resultado.Items.Clear();
                context.Incidentes.Where(x => x.Nombre.Contains(txtBuscar.Text)).ToList().ForEach(y => resultado.Items.Add(y));
            }
            else
            {
                cargarIncidentes();
            }
            limpiarFormulario();
            deshabilitarModificar();
        }

        private void estacionesAsociadas(object sender, EventArgs e)
        {
            if(lstIncEli.SelectedIndex > -1)
            {
                lstIncEliEstaciones.Items.Clear();
                List<Estaciones_X_Incidentes> ei = context.Estaciones_X_Incidentes.Where(x => x.Id_Incidente == ((Incidentes)lstIncEli.SelectedItem).Id).ToList();
                foreach (var est in ei)
                {
                    lstIncEliEstaciones.Items.Add(context.Estaciones.Where(x => x.Id == est.Id_Estacion).FirstOrDefault());
                }
            }
        }

        private void deshabilitarModificar()
        {
            txtModDem.Enabled = false;
            txtModDes.Enabled = false;
            txtModNombre.Enabled = false;
            cmbModProb.Enabled = false;
        }

        private void habilitarModificar()
        {
            txtModDem.Enabled = true;
            txtModDes.Enabled = true;
            txtModNombre.Enabled = true;
            cmbModProb.Enabled = true;
        }
    }
}
