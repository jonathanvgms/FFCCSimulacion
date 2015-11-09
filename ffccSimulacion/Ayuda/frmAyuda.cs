using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using iTextSharp.text;
using iTextSharp.text.pdf;
using ffccSimulacion.Modelo;

namespace ffccSimulacion.Ayuda
{
    public partial class frmAyuda : Form
    {
        public frmAyuda()
        {
            InitializeComponent();
        }

        private void btnAyudaCerrar_Click(object sender, EventArgs e)
        {
            pnlAyuda.Controls.Clear();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string path = Application.StartupPath + "\\Resources\\Manual.pdf";
            Process.Start(path);
        }       
    }
}
