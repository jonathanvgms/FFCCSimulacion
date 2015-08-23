using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ffccSimulacion.Simulador
{
    public partial class frmRealizarSimulacion : Form
    {
        public frmRealizarSimulacion()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.pnlSimulador.Controls.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmBuscarSimulacion frmBuscar = new frmBuscarSimulacion();

            frmBuscar.ShowDialog(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();

            this.textBox2.Clear();

            this.textBox3.Clear();
        }
    }
}
