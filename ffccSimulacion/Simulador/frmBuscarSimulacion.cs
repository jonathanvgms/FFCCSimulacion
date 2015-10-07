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

namespace ffccSimulacion.Simulador
{
    public partial class frmBuscarSimulacion : Form
    {

        ffccSimulacionEntities context;

        public Simulaciones simulacionSeleccionada;

        public frmBuscarSimulacion()
        {
            InitializeComponent();

            context = new ffccSimulacionEntities();

            buscarSimulacionesDisponibles();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Boton Cancelar
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Boton Seleccionar
            if (lBoxBuscSimList.SelectedIndex > -1)
            {
                //Se selecciono algun item
                simulacionSeleccionada = (Simulaciones)lBoxBuscSimList.Items[lBoxBuscSimList.SelectedIndex];
                this.DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Debe seleccionar alguna Simulacion.");
            }
            
        }

        private void buscarSimulacionesDisponibles()
        {
            lBoxBuscSimList.Items.Clear();

            context.Simulaciones.ToList().ForEach(x => { lBoxBuscSimList.Items.Add(x); });
        }
    }
}
