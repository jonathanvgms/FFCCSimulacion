using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ffccSimulacion.Resultados
{
    public partial class frmResultados : Form
    {
        public frmResultados()
        {
            InitializeComponent();
        }

        private void btnResultadosCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnResultadosPdf_Click(object sender, EventArgs e)
        {
            //aca se tiene que llamar a generarInforme y pasar todas las variables de resultado

            //Informe.generarInforme();
        }
    }
}
