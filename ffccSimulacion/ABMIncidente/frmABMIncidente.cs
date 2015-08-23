using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ffccSimulacion.ABMIncidente
{
    public partial class frmABMIncidente : Form
    {
        public frmABMIncidente()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.pnlInicidente.Controls.Clear();
        }
    }
}
