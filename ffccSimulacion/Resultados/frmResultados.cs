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

namespace ffccSimulacion.Resultados
{
    public partial class frmResultados : Form
    {
        ResultadoSimulacion resultadoSimulacion;

        public frmResultados(ResultadoSimulacion resSim)
        {
            InitializeComponent();

            resultadoSimulacion = resSim;

            this.txtPorcTrenes.Text = resultadoSimulacion.porcentajeSobrecarga.ToString();
            this.txtTiemPro.Text = resultadoSimulacion.promedioDemoraIncidentes.ToString();
            this.txtPromPasaj.Text = resultadoSimulacion.promedioPasajeros.ToString();
            this.txtPromDem.Text = resultadoSimulacion.promedioDemoraAtencion.ToString();
            
            this.txtCostPorPasajero.Text = resultadoSimulacion.costoPasajero.ToString();
            this.txtConsEleKm.Text = resultadoSimulacion.consumoElectricoKm.ToString();
            this.txtConsDiKm.Text = resultadoSimulacion.consumoDieselKm.ToString();
            this.txtConsElePas.Text = resultadoSimulacion.consumoElectricoPasajero.ToString();
            this.txtConsDiPas.Text = resultadoSimulacion.consumoDieselPasajero.ToString();
            
            this.Text = "Resultados De " + resultadoSimulacion.nombreSimulacion;
        }

        private void btnResultadosCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnResultadosPdf_Click(object sender, EventArgs e)
        {
            /*
             * aca se tiene que llamar a generarInforme y pasar todas las variables de resultado
             * Necesito pasar el nombre de la simulacion, con el Id no basta pues la simulacion puede no guardarse
             * y con el IdTraza recupero toda la info de los servicios, formaciones, estaciones, coches e incidentes.
             * Lo agregré al struct de ResultadoSimulacion
             */
            Informe.generarInforme(resultadoSimulacion);            
        }

        private void txtCostoEle_TextChanged(object sender, EventArgs e)
        {
            this.txtCostPorKm.Text = (resultadoSimulacion.costoKm * Convert.ToDouble(this.txtCostoEle.Text)).ToString();
        }

        private void txtCostoDi_TextChanged(object sender, EventArgs e)
        {
            this.txtCostPorPasajero.Text = (resultadoSimulacion.costoPasajero * Convert.ToDouble(this.txtCostoDi.Text)).ToString();
        }
    }
}
