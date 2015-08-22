using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ffccSimulacion.ABMCoche
{
    public partial class frmABMCoche : Form
    {
        public frmABMCoche()
        {
            InitializeComponent();
        }

        private void btnCocheNuevoCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
