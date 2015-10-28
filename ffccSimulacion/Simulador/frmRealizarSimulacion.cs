using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ffccSimulacion.Modelo;
using ffccSimulacion.Resultados;

namespace ffccSimulacion.Simulador
{
    public partial class frmRealizarSimulacion : Form
    {

        ffccSimulacionEntities context;

        private Simulaciones simulacion;

        public ResultadoSimulacion resultadoSimulacion;

        public frmRealizarSimulacion()
        {
            InitializeComponent();

            context = new ffccSimulacionEntities();

            buscarTrazasDisponibles();

            //buscarServiciosDisponibles();
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
                    //simulacion = frmBuscar.simulacionSeleccionada;
                    simulacion = context.Simulaciones.Where(x => x.Id == frmBuscar.simulacionSeleccionada.Id).FirstOrDefault();
                    cargarCamposSimulacion();

//                    this.btnSimGuardar.Enabled = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tbSimNombre.Clear();

            this.tbSimFrecuencia.Clear();

            this.tbSimDuracion.Clear();

            buscarTrazasDisponibles();

            //buscarServiciosDisponibles();

            this.lBoxSimServicios.Items.Clear();
        }

        private void cargarCamposSimulacion()
        {
            tbSimNombre.Text = simulacion.Nombre;

            tbSimFrecuencia.Text = simulacion.Frecuencia_Salida.ToString();

            tbSimDuracion.Text = simulacion.Tiempo_Final.ToString();

            lBoxSimTrazas.Items.Clear();

            lBoxSimTrazas.Items.Add(simulacion.Trazas);

            lBoxSimServicios.Items.Clear();

            foreach (Trazas_X_Servicios ts in context.Trazas_X_Servicios.Where(x => x.Id_Traza == simulacion.Id_Traza))
                lBoxSimServicios.Items.Add(ts.Servicios);

            //List<Servicios> serviciosTraza = simulacion.Trazas.ServiciosDisponibles;

            //foreach (Servicios servicio in serviciosTraza)
            //{
            //    lBoxSimServicios.Items.Add(servicio);
            //}
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            string errorMsj = "";
            Trazas trazaSeleccionada = (Trazas)lBoxSimTrazas.SelectedItem;

            if (!Util.EsAlfaNumerico(tbSimNombre.Text))
                errorMsj += "Nombre: incompleto o incorrecto.\n";
            if (!Util.EsNumerico(tbSimFrecuencia.Text))
                errorMsj += "Frecuencia: incompleto o incorrecta.\n";
            if (!Util.EsNumerico(tbSimDuracion.Text))
                errorMsj += "Duración: incompleto o incorrecta.\n";
            if (trazaSeleccionada == null)
                errorMsj += "Ninguna traza ha sido seleccionada.\n";

            if (string.IsNullOrEmpty(errorMsj))
            {
                //esto es de Facu
                //simulacion = new Simulaciones();
                //simulacion.Trazas = trazaSeleccionada;
                //simulacion.Tiempo_Final = Convert.ToInt32(tbSimDuracion.Text) * 60;//Paso la duracion de la simulacion a minutos
                //simulacion.Frecuencia_Salida = Convert.ToInt32(tbSimFrecuencia.Text);
                //simulacion.EjecutarSimulacion();
                //reportar();
                simulacion = new Simulaciones();
                simulacion.Trazas = trazaSeleccionada;
                simulacion.Tiempo_Final = Convert.ToInt32(tbSimDuracion.Text) * 60; //Paso la duracion de la simulacion a minutos
                simulacion.Frecuencia_Salida = Convert.ToInt32(tbSimFrecuencia.Text);
                //simulacion.EjecutarSimulacion(); esto es de Facu
                Thread threadSimulacion = new Thread(new ThreadStart(simulacion.EjecutarSimulacion)); // creo el hilo de la simulacion
                threadSimulacion.Start(); //arranco el hilo
                frmBarraProgreso barra = new frmBarraProgreso(threadSimulacion); //creo la barra de progreso
                barra.ShowDialog(); //muestro la barra
                threadSimulacion.Join(); //espero a que el hilo termine ya sea porque 1)termino bien 2) o le dieon cancelar               
                if (barra.estado) //si la simulacion termino correctamente muestro el reportar
                {
                    reportar();
                }
            }
            else
                MessageBox.Show(errorMsj);
        }

        private void btnSimGuardar_Click(object sender, EventArgs e)
        {
            string errorStr = "";

            if (!Util.EsAlfaNumerico(tbSimNombre.Text))
            {
                errorStr += "Nombre: Incompleto ó Incorrecto\n";
            }

            if (!Util.EsNumerico(tbSimFrecuencia.Text))
            {
                errorStr += "Frecuencia: Incompleta ó Incorrecta\n";
            }

            if (!Util.EsNumerico(tbSimDuracion.Text))
            {
                errorStr += "Duracion: Incompleta ó Incorrecta\n";
            }

            if(lBoxSimTrazas.SelectedItem == null)
            {
                errorStr += "Falta Seleccionar una Traza";
            }

            //TODO revisar listbox, quizas el de servicios deberia ser un combobox

            if (errorStr.Length == 0)
            {
                try
                {   /*si la simulacion es null o su id es igual a 0 quiere decir que la misma no existe en la bd*/
                    if (simulacion == null || simulacion.Id == 0)
                    {
                        simulacion = new Simulaciones();

                        simulacion.Nombre = tbSimNombre.Text;

                        simulacion.Frecuencia_Salida = Convert.ToInt32(tbSimFrecuencia.Text);

                        simulacion.Tiempo_Final = Convert.ToInt32(tbSimDuracion.Text);

                        simulacion.Trazas = (Trazas)lBoxSimTrazas.SelectedItem;

                        //TODO cargar servicios

                        context.Simulaciones.Add(simulacion);
                    }
                    else
                    {
                        //Simulaciones s;
                        //s = new Simulaciones();//simulacion = context.Simulaciones.Where(x => x.Nombre.Equals(tbSimNombre.Text)).FirstOrDefault();

                        simulacion.Nombre = tbSimNombre.Text;

                        simulacion.Frecuencia_Salida = Convert.ToInt32(tbSimFrecuencia.Text);

                        simulacion.Tiempo_Final = Convert.ToInt32(tbSimDuracion.Text);

                        simulacion.Trazas = (Trazas)lBoxSimTrazas.SelectedItem;
                    }

                    context.SaveChanges();

                    MessageBox.Show("Simulación Guardada");

                }
                catch (Exception exc)
                {
                    MessageBox.Show("Simulación No Guardada\nError:\n" + exc.ToString());
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

        /*private void buscarServiciosDisponibles()
        {
            lBoxSimServicios.Items.Clear();

            context.Servicios.ToList().ForEach(x => { lBoxSimServicios.Items.Add(x); });
        }*/

        private void lBoxSimTrazas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lBoxSimTrazas.SelectedIndex > -1)
            {
                Servicios s;
                lBoxSimServicios.Items.Clear();
                lbxFormaciones.Items.Clear();

                Trazas trazaSeleccionada = (Trazas)lBoxSimTrazas.SelectedItem;

                foreach (Trazas_X_Servicios ts in context.Trazas_X_Servicios.Where(x => x.Id_Traza == trazaSeleccionada.Id))
                {
                    s = ts.Servicios;
                    lBoxSimServicios.Items.Add(s);

                    foreach (Servicios_X_Formaciones sf in context.Servicios_X_Formaciones.Where(x => x.Id_Servicio == s.Id))
                    {
                        if (!lbxFormaciones.Items.Contains(sf.Formaciones))
                            lbxFormaciones.Items.Add(sf.Formaciones);
                    }
                }

            }
        }

        private void reportar()
        {
            /*
             * Se obtienen los siguientes resultados de cada formacion:
             *      distanciaTotalRecorrida;
             *      pasajerosTotalesTransportados;
             *      vecesSuperoCapLegal;
             *      vecesNoHabiaPasajerosParados;
             *      tiempoTotalDemoradoIncidente;
             *      tiempoTotalDemoradoAtencion;
             *      tiempoTotalEnMovimiento;
             * 
             * Se calculan los siguientes resultados finales:
             *      Porcentaje de trenes que superaron el maximo de pasajeros permitido.
             *      Tiempo promedio de demora por incidentes.
             *      Promedio de pasajeros por formacion.
             *      Promedio de demora por tiempo de atencion en formacion.
             *      Costo por km.
             *      Costo por pasajero.
             *      Consumo promedio por km.
             *      Consumo promedio por pasajero.
             * */

            int totalFormaciones = simulacion.ResultadosFormacionesSimulacion.Count();
            int totalKm = 0;
            int totalPasajeros = 0;

            resultadoSimulacion.id = simulacion.Id;
            resultadoSimulacion.nombre = simulacion.Nombre;
            resultadoSimulacion.fecha = DateTime.Now;
            resultadoSimulacion.porcentajeSobrecarga = 0;
            resultadoSimulacion.promedioDemoraIncidentes = 0;
            resultadoSimulacion.promedioPasajeros = 0;
            resultadoSimulacion.promedioDemoraAtencion = 0;
            resultadoSimulacion.costoKm = 0;
            resultadoSimulacion.costoPasajero = 0;
            resultadoSimulacion.consumoElectricoKm = 0;
            resultadoSimulacion.consumoDieselKm = 0;
            resultadoSimulacion.consumoElectricoPasajero = 0;
            resultadoSimulacion.consumoDieselPasajero = 0;

            foreach (ResultadoFormacion resultadoFormacion in simulacion.ResultadosFormacionesSimulacion)
            {
                if (resultadoFormacion.vecesSuperoCapLegal > 0)
                {
                    //Si esta formacion en su recorrido supero la capacidad legal, se incrementa el contador.
                    resultadoSimulacion.porcentajeSobrecarga++;
                }

                //Por ahora los promedios son acumuladores, luego se dividen por los totales.
                resultadoSimulacion.promedioDemoraIncidentes += resultadoFormacion.tiempoTotalDemoradoIncidente;
                resultadoSimulacion.promedioPasajeros += resultadoFormacion.pasajerosTotalesTransportados;
                resultadoSimulacion.promedioDemoraAtencion += resultadoFormacion.tiempoTotalDemoradoAtencion;
                
                totalKm += resultadoFormacion.distanciaTotalRecorrida;
                totalPasajeros += resultadoFormacion.pasajerosTotalesTransportados;
                foreach (Formaciones_X_Coches formacion_coche in context.Formaciones_X_Coches.Where(x => x.Id_Formacion == resultadoFormacion.id_formacion))
                {
                    //Busco los coches de la formacion y obtengo el consumo.
                    Coches coche = context.Coches.Where(x => x.Id == formacion_coche.Id_Coche).FirstOrDefault();
                    
                    if (coche.EsLocomotora == 1)
                    {
                        /*TODO No se porque rompe esto*/
                        if (coche.TipoConsumo == (int)TipoConsumo.Electrico)
                        {
                            resultadoSimulacion.consumoElectricoKm += (double)coche.ConsumoMovimiento * resultadoFormacion.tiempoTotalEnMovimiento + (double)coche.ConsumoParado * (resultadoFormacion.tiempoTotalDemoradoAtencion + resultadoFormacion.tiempoTotalDemoradoIncidente);
                        }
                        else if (coche.TipoConsumo == (int)TipoConsumo.Disel)
                        {
                            resultadoSimulacion.consumoDieselKm += (double)coche.ConsumoMovimiento * resultadoFormacion.tiempoTotalEnMovimiento + (double)coche.ConsumoParado * (resultadoFormacion.tiempoTotalDemoradoAtencion + resultadoFormacion.tiempoTotalDemoradoIncidente);
                        }
                    }
                }
            }

            //Se terminan de calcular porcentajes y promedios.
            resultadoSimulacion.porcentajeSobrecarga = (double)resultadoSimulacion.porcentajeSobrecarga * 100 / (double) totalFormaciones;
            resultadoSimulacion.promedioDemoraIncidentes = (double)resultadoSimulacion.promedioDemoraIncidentes / (double) totalFormaciones;
            resultadoSimulacion.promedioPasajeros = (double)resultadoSimulacion.promedioPasajeros / (double)totalFormaciones;
            resultadoSimulacion.promedioDemoraAtencion = (double)resultadoSimulacion.promedioDemoraAtencion / (double) totalFormaciones;

            //La acumulacion de consumo es igual para Km y Pasajeros, luego se divide por los totales correspondientes
            resultadoSimulacion.consumoElectricoPasajero = resultadoSimulacion.consumoElectricoKm;
            resultadoSimulacion.consumoDieselPasajero = resultadoSimulacion.consumoDieselKm;

            //Se dividen los consumos por los totales de Km y Pasajeros
            resultadoSimulacion.consumoElectricoKm = (double) resultadoSimulacion.consumoElectricoKm / (double) totalKm;
            resultadoSimulacion.consumoDieselKm = (double)resultadoSimulacion.consumoDieselKm / (double)totalKm;
            resultadoSimulacion.consumoElectricoPasajero = (double)resultadoSimulacion.consumoElectricoPasajero / (double)totalPasajeros;
            resultadoSimulacion.consumoDieselPasajero = (double)resultadoSimulacion.consumoDieselPasajero / (double)totalPasajeros;

            resultadoSimulacion.nombreSimulacion = tbSimNombre.Text;

            resultadoSimulacion.idTraza = ((Trazas)lBoxSimTrazas.SelectedItem).Id;

            //using (frmResultados frmResultados = new frmResultados(resultadoSimulacion))
            //{
            //    frmResultados.ShowDialog();
            //}
            frmResultados frmResultados = new frmResultados(resultadoSimulacion);
            frmResultados.ShowDialog(this);
        }
    }
}
