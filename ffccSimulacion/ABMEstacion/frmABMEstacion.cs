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
using ffccSimulacion.ABMIncidente;

namespace ffccSimulacion.ABMEstacion
{
    public partial class frmABMEstacion : Form
    {
        ffccSimulacionEntities context;

        public frmABMEstacion()
        {
            InitializeComponent();

            context = new ffccSimulacionEntities();

            cargarIncidentes();

            cargarEstaciones();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.pnlEstacion.Controls.Clear();
        }

        private void cargarIncidentes()
        {
            context.Incidentes.ToList().ForEach(x => 
            {
                clbIncidentes.Items.Add(x.Nombre); 
                clbModIncidentes.Items.Add(x.Nombre);
            });
        }

        private void cargarEstaciones()
        {
            context.Estaciones.ToList().ForEach(x =>
            {
                lstModEstaciones.Items.Add(x.Nombre);
                lstEliEstaciones.Items.Add(x.Nombre);
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmABMIncidente formIncidente = new frmABMIncidente();

            formIncidente.Show(this);
        }

        private void btnEstacionAceptar_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == CrearEstacion)
            {
                tabCrearEstacion();
            }
        }

        private void tabCrearEstacion()
        {
            throw new NotImplementedException();
        }
    }
}
