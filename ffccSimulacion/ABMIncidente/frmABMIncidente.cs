using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ffccSimulacion.Modelo;

namespace ffccSimulacion.ABMIncidente
{
    public partial class frmABMIncidente : Form
    {
        ffccSimulacionEntities context;

        public frmABMIncidente()
        {
            InitializeComponent();

            context = new ffccSimulacionEntities();

            cargarIncidentes();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
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
            else
            {
                tab_EliminarIncidente();
            }

            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtIncCreNom.Clear();

            txtincCreDes.Clear();

            txtbIncCreTiem.Clear();
        }
        
        private void cargarIncidentes()
        {
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

                    MessageBox.Show("Incidente Guardado.");
                }
                catch (Exception exc)
                {
                    MessageBox.Show("No se Guardo el Incidente \n\n" + exc.ToString());
                }
            }
            else
            {
                MessageBox.Show(errorMsj);
            }
        }

        private void tab_ModificarIncidente()
        {

        }

        private void tab_EliminarIncidente()
        {

        }
    }
}
