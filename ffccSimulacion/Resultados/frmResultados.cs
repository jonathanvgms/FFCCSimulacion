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

        double valorAnteriortxtCostoEle = 0;

        double valorAnteriortxtCostoDi = 0;

        public frmResultados(ResultadoSimulacion resSim)
        {
            InitializeComponent();

            resultadoSimulacion = resSim;

            this.txtPorcTrenes.Text = resultadoSimulacion.porcentajeSobrecarga.ToString();
            this.txtTiemPro.Text = resultadoSimulacion.promedioDemoraIncidentes.ToString();
            this.txtPromPasaj.Text = resultadoSimulacion.promedioPasajeros.ToString();
            this.txtPromDem.Text = resultadoSimulacion.promedioDemoraAtencion.ToString();
            
            this.txtConsEleKm.Text = resultadoSimulacion.consumoElectricoKm.ToString();
            this.txtConsDiKm.Text = resultadoSimulacion.consumoDieselKm.ToString();
            this.txtConsElePas.Text = resultadoSimulacion.consumoElectricoPasajero.ToString();
            this.txtConsDiPas.Text = resultadoSimulacion.consumoDieselPasajero.ToString();

            this.txtCostoEle.Text = "0";
            this.txtCostoDi.Text = "0";
            
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
            if (this.txtCostoEle.Text.Length > 0)
            {
                if (Util.EsDouble(this.txtCostoEle.Text))
                {
                    this.valorAnteriortxtCostoEle = Convert.ToDouble(this.txtCostoEle.Text);
                    actualizarCostos();
                }
                else
                {
                    MessageBox.Show(lblCostoEle.Text + ": Incompleto ó Incorrecto.");
                    this.txtCostoEle.Text = valorAnteriortxtCostoEle.ToString();
                }
            }
        }

        private void txtCostoDi_TextChanged(object sender, EventArgs e)
        {
            if (this.txtCostoDi.Text.Length > 0)
            {
                if (Util.EsDouble(this.txtCostoDi.Text))
                {
                    this.valorAnteriortxtCostoDi = Convert.ToDouble(this.txtCostoDi.Text);
                    actualizarCostos();
                }
                else
                {
                    MessageBox.Show(lblCostoDi.Text + ": Incompleto ó Incorrecto.");
                    this.txtCostoDi.Text = valorAnteriortxtCostoDi.ToString();
                }
            }
        }

        //TODO costo electrico o diesel, o ambos ??
        private void actualizarCostos()
        {
            if ((this.txtCostoEle.Text.Length > 0) && (Util.EsDouble(this.txtCostoEle.Text)) && (this.txtCostoDi.Text.Length > 0) && (Util.EsDouble(this.txtCostoDi.Text)))
            {
                resultadoSimulacion.costoKm = (double)resultadoSimulacion.consumoElectricoKm * Convert.ToDouble(this.txtCostoEle.Text) + (double)resultadoSimulacion.consumoDieselKm * Convert.ToDouble(this.txtCostoDi.Text);
                resultadoSimulacion.costoPasajero = (double)resultadoSimulacion.consumoElectricoPasajero * Convert.ToDouble(this.txtCostoEle.Text) + (double)resultadoSimulacion.consumoDieselPasajero * Convert.ToDouble(this.txtCostoDi.Text);
                this.txtCostPorKm.Text = resultadoSimulacion.costoKm.ToString();
                this.txtCostPorPasajero.Text = resultadoSimulacion.costoPasajero.ToString();
            }
        }
    }
}
