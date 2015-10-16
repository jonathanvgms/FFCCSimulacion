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
            this.txtCostPorKm.Text = resultadoSimulacion.costoKm.ToString();
            this.txtCostPorPasajero.Text = resultadoSimulacion.costoPasajero.ToString();
            this.txtConsPorKm.Text = resultadoSimulacion.consumoKm.ToString();
            this.txtConsPorPasajero.Text = resultadoSimulacion.consumoPasajero.ToString();

            this.Name = "RESULTADOS DE SIMULACION " + resultadoSimulacion.nombreSimulacion;
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
    }
}
