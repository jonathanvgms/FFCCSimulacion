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

            lblIncidenteMensaje.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.pnlInicidente.Controls.Clear();

            this.Close();
        }

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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabCrear)
            {
                txtIncCreNom.Clear();

                txtincCreDes.Clear();

                txtbIncCreTiem.Clear();

                cbmIncCrePro.SelectedIndex = 0;
            }
            else
            {
                txtModNombre.Clear();

                txtModDem.Clear();

                txtModDes.Clear();

                cmbModProb.SelectedIndex = 0;
            }
        }
        
        private void cargarIncidentes()
        {
            lstIncMod.Items.Clear();

            lstIncEli.Items.Clear();

            context.Incidentes.ToList().ForEach(x => {
                lstIncMod.Items.Add(x.Nombre); 
                lstIncEli.Items.Add(x.Nombre);
            });
        }

        private void tab_CrearIncidente()
        {
            string errorMsj = "";

            if (!Util.EsAlfabetico(txtIncCreNom.Text))
            {
                errorMsj += "Nombre: Incompleto/Incorrecto.\n";
            }

            if (!Util.EsAlfabetico(txtincCreDes.Text))
            {
                errorMsj += "Descripción: Incompleto/Incorrecto.\n";
            }

            if (!Util.EsNumerico(txtbIncCreTiem.Text))
            {
                errorMsj += "Tiempo de Ocurrencia: Incompleto/Incorrecto.\n";
            }

            if (cbmIncCrePro.SelectedIndex < 0)
            {
                errorMsj += "Probabilidad de Ocurrencia: Falta Seleccionar.\n";
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

                    lblCrearMensajeError.Text = "";
                    
                    lblIncidenteMensaje.Text = "Incidente Guardado";
                }
                catch (Exception exc)
                {
                    //MessageBox.Show("No se Guardo el Incidente \n\n" + exc.ToString());

                    lblIncidenteMensaje.Text = "Incidente No Guardado";
                }
            }
            else
            {
                //MessageBox.Show(errorMsj);

                lblCrearMensajeError.Text = errorMsj;
            }
        }

        private void tab_ModificarIncidente()
        {
            string errorMsj = "";

            if (!Util.EsAlfabetico(txtModNombre.Text))
            {
                errorMsj += "Nombre: Incompleto/Incorrecto.\n";
            }

            if (!Util.EsAlfabetico(txtModDes.Text))
            {
                errorMsj += "Descripción: Incompleto/Incorrecto.\n";
            }

            if (!Util.EsNumerico(txtModDem.Text))
            {
                errorMsj += "Tiempo de Ocurrencia: Incompleto/Incorrecto.\n";
            }

            if ((cmbModProb.SelectedIndex < 0) || (cmbModProb.SelectedItem.ToString().Length == 0))
            {
                errorMsj += "Probabilidad de Ocurrencia: Falta Seleccionar.\n";
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

                    lblModMensajeError.Text = "";

                    lblIncidenteMensaje.Text = "Incidente Guardado";
                }
                catch (Exception exc)
                {
                    //MessageBox.Show(exc.ToString());

                    lblIncidenteMensaje.Text = "Incidente No Guardado";
                }
            }
            else
            {
                lblModMensajeError.Text = errorMsj;
            }

        }

        private void seleccionarIncidente(object sender, EventArgs e)
        {
            incidenteSeleccionado = context.Incidentes.Where(x => x.Nombre == lstIncMod.SelectedItem.ToString()).FirstOrDefault();

            txtModNombre.Text = incidenteSeleccionado.Nombre;

            txtModDes.Text = incidenteSeleccionado.Descripcion;

            txtModDem.Text = incidenteSeleccionado.TiempoDemora.ToString();

            cmbModProb.SelectedIndex = cmbModProb.Items.IndexOf(incidenteSeleccionado.ProbabilidadOcurrencia.ToString());
        }

        private void btnEliminarIncidente_Click(object sender, EventArgs e)
        {
            try
            {
                incidenteSeleccionado = context.Incidentes.Where(x => x.Nombre == lstIncEli.SelectedItem.ToString()).FirstOrDefault();

                context.Incidentes.Remove(incidenteSeleccionado);

                context.SaveChanges();

                cargarIncidentes();

                lblIncidenteMensaje.Text = "Incidente Eliminado";
            }
            catch(Exception exc)
            {
                //MessageBox.Show(exc.ToString());

                lblIncidenteMensaje.Text = "Incidente No Eliminado";
            }
        }
    }
}
