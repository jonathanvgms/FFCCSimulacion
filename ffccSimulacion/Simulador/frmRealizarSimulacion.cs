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
    public partial class frmRealizarSimulacion : Form
    {

        ffccSimulacionEntities context;

        private Simulaciones simulacion;

        public frmRealizarSimulacion()
        {
            InitializeComponent();

            context = new ffccSimulacionEntities();

            buscarTrazasDisponibles();

            buscarServiciosDisponibles();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.pnlSimulador.Controls.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (frmBuscarSimulacion frmBuscar = new frmBuscarSimulacion())
            {

                var result = frmBuscar.ShowDialog();

                if (result == DialogResult.OK)
                {
                    simulacion = frmBuscar.simulacionSeleccionada;

                    cargarCamposSimulacion();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tbSimNombre.Clear();

            this.tbSimFrecuencia.Clear();

            this.tbSimDuracion.Clear();

            buscarTrazasDisponibles();

            buscarServiciosDisponibles();
        }

        private void cargarCamposSimulacion()
        {
            tbSimNombre.Text = simulacion.Nombre;

            tbSimFrecuencia.Text = simulacion.Frecuencia_Salida.ToString();

            tbSimDuracion.Text = simulacion.Tiempo_Final.ToString();

            lBoxSimTrazas.Items.Clear();

            lBoxSimTrazas.Items.Add(simulacion.Trazas);

            lBoxSimServicios.Items.Clear();

            List<Servicios> serviciosTraza = simulacion.Trazas.ServiciosDisponibles;

            foreach (Servicios servicio in serviciosTraza)
            {
                lBoxSimServicios.Items.Add(servicio);
            }
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            simulacion.EjecutarSimulacion();
        }

        private void btnSimGuardar_Click(object sender, EventArgs e)
        {
            string errorStr = "";

            if(!Util.EsAlfaNumerico(tbSimNombre.Text))
            {
                errorStr += "Nombre: Incompleto/Incorrecto\n";
            }

            if(!Util.EsNumerico(tbSimFrecuencia.Text))
            {
                errorStr += "Frecuencia: Incompleto/Incorrecto\n";
            }

            if(!Util.EsNumerico(tbSimDuracion.Text))
            {
                errorStr += "Duracion: Incompleto/Incorrecto\n";
            }

            //TODO revisar listbox, quizas el de servicios deberia ser un combobox

            if (errorStr.Length == 0)
            {
                try
                {
                    //Trazas nuevaTraza = new Trazas();
                    simulacion = new Simulaciones();

                    //nuevaTraza.Nombre = txtTraCreNombre.Text;
                    simulacion.Nombre = tbSimNombre.Text;

                    simulacion.Frecuencia_Salida = int.Parse(tbSimFrecuencia.Text);

                    simulacion.Tiempo_Final = int.Parse(tbSimDuracion.Text);

                    simulacion.Trazas = (Trazas) lBoxSimTrazas.SelectedItem;

                    //TODO cargar servicios

                    context.Simulaciones.Add(simulacion);

                    context.SaveChanges();

                    MessageBox.Show("Simulacion Guardada");

                }
                catch (Exception exc)
                {
                    MessageBox.Show("Simulacion No Guardada\nError:\n" + exc.ToString());
                }
            }
            else
            {
                MessageBox.Show(errorStr);
            }
        }

        private void buscarTrazasDisponibles()
        {
            lBoxSimTrazas.Items.Clear();

            context.Trazas.ToList().ForEach(x => { lBoxSimTrazas.Items.Add(x); });
        }

        private void buscarServiciosDisponibles()
        {
            lBoxSimServicios.Items.Clear();

            context.Servicios.ToList().ForEach(x => { lBoxSimServicios.Items.Add(x); });
        }
    }
}
