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
using ffccSimulacion.ABMIncidente;

namespace ffccSimulacion.ABMEstacion
{
    public partial class frmABMEstacion : Form
    {
        ffccSimulacionEntities context;

        Estaciones estacionSeleccionada;

        public frmABMEstacion()
        {
            InitializeComponent();

            context = new ffccSimulacionEntities();

            clbIncidentes.DisplayMember = "Nombre";

            clbModIncidentes.DisplayMember = "Nombre";

            cargarIncidentes();

            cargarEstaciones();

            deshabilitarModificar();
        }
        
        #region Accion de Pulsar botones
        /*
         * Accion de Pulsar el Boton 'Cancelar'
         */ 
        private void btnEstCancelar_Click(object sender, EventArgs e)
        {
            pnlEstacion.Controls.Clear();

            Close();
        }

        /*
         * Accion de Pulsar el Boton 'Aceptar'
         */ 
        private void btnEstAceptar_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == CrearEstacion)
            {
                tabCrearEstacion();
            }
            else
            {
                tabModificarEstacion();
            }
        }

        /*
         * Accion de Pulsar el Boton 'AgregarIncidente'
         */
        private void btnCreAgregarIncidente_Click(object sender, EventArgs e)
        {
            frmABMIncidente formIncidente = new frmABMIncidente();

            formIncidente.Show(this);

            cargarIncidentes();
        }

        /*
         * Accion de Pulsar el Boton 'Limpiar'
         */
        private void btnEstLimpiar_Click(object sender, EventArgs e)
        {
            limpiarFormulario();
        }

        /*
         * Accion de Pulsar el Boton 'Borrar Estacion'
         */
        private void btnEstBorrar_Click(object sender, EventArgs e)
        {
            borrarEstacion();
        }
        
        #endregion

        #region Accion de Cargar Incidentes y Estaciones
        private void cargarIncidentes()
        {
            clbIncidentes.Items.Clear();

            clbModIncidentes.Items.Clear();

            context.Incidentes.ToList().ForEach(x => { clbIncidentes.Items.Add(x); clbModIncidentes.Items.Add(x); });
        }

        private void cargarEstaciones()
        {
            lstModEstaciones.Items.Clear();

            lstEliEstaciones.Items.Clear();

            lstCreEstaciones.Items.Clear();

            context.Estaciones.ToList().ForEach(x => { lstModEstaciones.Items.Add(x); lstEliEstaciones.Items.Add(x); lstCreEstaciones.Items.Add(x); });
        }

        #endregion
        
        #region Casos de Uso
        
        /*
         * Caso de Uso 'Modificar Estacion'
         */ 
        private void tabModificarEstacion()
        {
            string errorMsj = "";
            bool numeroEntero = true;

            if (!Util.EsAlfaNumerico(txtEstModNombre.Text))
            {
                errorMsj += "Nombre: Valor Incompleto ó Incorrecto\n";
            }

            if (!Util.EsNumerico(txtEstModMinimo.Text))
            {
                errorMsj += "Personas Mínimas en Andén: Valor Incompleto ó Incorrecto\n";
                numeroEntero = false;
            }

            if (!Util.EsNumerico(txtEstModMaximo.Text))
            {
                errorMsj += "Personas Máximas en Andén: Valor Incompleto ó Incorrecto\n";
                numeroEntero = false;
            }

            if (cmbEstModFdp.SelectedIndex < 0)
            {
                errorMsj += "Distribución de Personas en Andén: Falta Seleccionar\n";
            }

            if (numeroEntero)
            {
                if (!verificarRangoPersonas(txtEstModMinimo, txtEstModMaximo))
                {
                    errorMsj += "Personas en Andén:\n\n1) El Mínimo debe ser menor que el Máximo\n2) El Rango de Personas debe ser: 0 a 999999999 (9 Cifras)";
                }
            }

            if (errorMsj.Length == 0)
            {
                try
                {
                    estacionSeleccionada = (Estaciones)lstModEstaciones.SelectedItem;

                    estacionSeleccionada.Nombre = txtEstModNombre.Text;

                    estacionSeleccionada.PersonasEsperandoMin = Convert.ToInt32(txtEstModMinimo.Text);

                    estacionSeleccionada.PersonasEsperandoMax = Convert.ToInt32(txtEstModMaximo.Text);

                    estacionSeleccionada.TipoFDP = cmbEstModFdp.SelectedIndex;

                    //borro todas los incidente asignados a la estacion
                    context.Estaciones_X_Incidentes.Where(x => x.Id_Estacion == estacionSeleccionada.Id).ToList().ForEach(y => context.Estaciones_X_Incidentes.Remove(y));

                    //asigo la configuracion de estaciones del checklistbox
                    foreach (Incidentes i in clbModIncidentes.CheckedItems)
                    {
                        estacionSeleccionada.AgregarIncidente(i);
                    }

                    context.SaveChanges();

                    cargarEstaciones();

                    limpiarFormulario();

                    deshabilitarModificar();

                    MessageBox.Show("Las Modificaciones se guardaron con Exito.");
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Estación No Guardada\n\nError\n\n" + exc.Message);
                }
            }
            else
            {
                MessageBox.Show(errorMsj);
            }
        }

        /*
         * Caso de Uso 'Crear Estacion'
         */
        private void tabCrearEstacion()
        {
            string errorMsj = "";
            bool numeroEntero = true;

            if(!Util.EsAlfaNumerico(txtEstCreNombre.Text))
            {
                errorMsj += "Nombre: Valor Incompleto ó Incorrecto.\n";
            }
            else if (context.Estaciones.Where(x => x.Nombre == txtEstCreNombre.Text).Count() > 1)
            {
                errorMsj += "La estación existe en el sistema, ingrese otra.\n";
            }

            if (cmbEstCreFdp.SelectedIndex < 0)
            {
                errorMsj += "Fdp: Falta Seleccionar\n";
            }

            if(!Util.EsNumerico(txtEstCreMinimo.Text))
            {
                errorMsj += "Personas Mínimas en Andén: Valor Incompleto ó Incorrecto.\n";
                numeroEntero = false;
            }

            if (!Util.EsNumerico(txtEstCreMaximo.Text))
            {
                errorMsj += "Personas Máximas en Andén: Valor Incompleto ó Incorrecto.\n";
                numeroEntero = false;
            }

            if (numeroEntero)
            {
                if (!verificarRangoPersonas(txtEstCreMinimo, txtEstCreMaximo))
                {
                    errorMsj += "Personas en Andén: El Mínimo debe ser menor que el Máximo";
                }
            }

            if (errorMsj.Length == 0)
            {
                try
                {
                    Estaciones nuevaEstacion = new Estaciones();

                    nuevaEstacion.Nombre = txtEstCreNombre.Text;

                    nuevaEstacion.PersonasEsperandoMin = Convert.ToInt32(txtEstCreMinimo.Text);

                    nuevaEstacion.PersonasEsperandoMax = Convert.ToInt32(txtEstCreMaximo.Text);

                    nuevaEstacion.TipoFDP = cmbEstCreFdp.SelectedIndex;

                    foreach (Incidentes i in clbIncidentes.CheckedItems)
                    {
                        nuevaEstacion.AgregarIncidente(i);
                    }

                    context.Estaciones.Add(nuevaEstacion);

                    context.SaveChanges();

                    cargarEstaciones();

                    limpiarFormulario();

                    MessageBox.Show("Estación Guardada");
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Estación No Guardada\n\nError\n\n" + exc.Message);
                }
            }
            else
            {
                MessageBox.Show(errorMsj);
            }
        }

        /*
         * Caso de Uso 'Borrar Estacion'
         */ 
        private void borrarEstacion()
        {
            string errorMsj = "";
            estacionSeleccionada = (Estaciones)lstEliEstaciones.SelectedItem;

            if (lstEliEstaciones.SelectedItem == null)
            {
                errorMsj += "No se ha seleccionado ninguna estación para eliminar.\n";
            }
            else if ((context.Relaciones.Any(x => x.Id_Estacion_Anterior == estacionSeleccionada.Id)) || (context.Relaciones.Any(y => y.Id_Estacion_Siguiente == estacionSeleccionada.Id)))
            {
                errorMsj += "La estación no puede borrarse porque pertenece a un servicio.\n";
            }

            if (string.IsNullOrEmpty(errorMsj))
            {
                try
                {
                    if (MessageBox.Show("La estación se eliminará de manera permanente. ¿Desea continuar?", "", MessageBoxButtons.OKCancel) == DialogResult.Cancel) return;

                    estacionSeleccionada = (Estaciones)lstEliEstaciones.SelectedItem;

                    //borro todos los incidentes relacionados
                    context.Estaciones_X_Incidentes.Where(x => x.Id_Estacion == estacionSeleccionada.Id).ToList().ForEach(y => context.Estaciones_X_Incidentes.Remove(y));

                    context.Estaciones.Remove(estacionSeleccionada);

                    context.SaveChanges();

                    cargarEstaciones();

                    MessageBox.Show("Estación Eliminada");
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
            else
            {
                MessageBox.Show(errorMsj);
            }
        }
        #endregion

        #region Metodos Auxiliares
        
        /*
         * Verifica que el minimo que personas sea menor al maximo de personas esperando en el anden
         */ 
        private bool verificarRangoPersonas(TextBox minimo, TextBox maximo)
        {
            if (Convert.ToInt32(minimo.Text) < Convert.ToInt32(maximo.Text) + 1)
            {
                return true;
            }

            return false;
        }

        /*
         * Evento que sucede cuando se selecciona una Estacion de la lista
         */ 
        private void seleccionarEstacion(object sender, EventArgs e)
        {
            if (lstModEstaciones.SelectedIndex > -1)
            {
                habilitarModificar();

                estacionSeleccionada = (Estaciones)lstModEstaciones.SelectedItem;

                txtEstModNombre.Text = estacionSeleccionada.Nombre;

                txtEstModMinimo.Text = estacionSeleccionada.PersonasEsperandoMin.ToString();

                txtEstModMaximo.Text = estacionSeleccionada.PersonasEsperandoMax.ToString();

                cmbEstModFdp.SelectedIndex = estacionSeleccionada.TipoFDP;

                //limpiar el checkboxlist
                for (int i = 0; i < clbModIncidentes.Items.Count; i++)
                {
                    clbModIncidentes.SetItemChecked(i, false);
                }

                foreach (Incidentes i in estacionSeleccionada.ListaIncidentes)
                {
                    clbModIncidentes.SetItemChecked(clbModIncidentes.Items.IndexOf(i), true);
                }
            }
        }

        /*
         * Metodo que limpia los formularios 'Crear Estacion' y 'Modificar Estacion'
         */
        private void limpiarFormulario()
        {
            txtEstCreNombre.Clear();

            txtEstCreMinimo.Clear();

            txtEstCreMaximo.Clear();

            txtEstModMaximo.Clear();

            txtEstModMinimo.Clear();

            txtEstModNombre.Clear();

            cmbEstCreFdp.SelectedIndex = 0;

            cmbEstModFdp.SelectedIndex = 0;

            for (int i = 0; i < clbModIncidentes.Items.Count; i++)
            {
                clbIncidentes.SetItemChecked(i, false);

                clbModIncidentes.SetItemChecked(i, false);
            }
        }

        private void seleccionarPestaña(object sender, TabControlEventArgs e)
        {
            if (tabControl1.SelectedTab == CrearEstacion)
            {
                btnEstAceptar.Enabled = true;
                btnEstLimpiar.Enabled = true;
                deshabilitarModificar();
                limpiarFormulario();
            }
            else if (tabControl1.SelectedTab == ModificarEstacion)
            {
                btnEstAceptar.Enabled = true;
                btnEstLimpiar.Enabled = true;
                txtEstacionesModBuscar.Clear();
                limpiarFormulario();
                lstModEstaciones.SelectedIndex = -1;
            }
            else
            {
                btnEstAceptar.Enabled = false;
                btnEstLimpiar.Enabled = false;
                deshabilitarModificar();
            }
        }

        #endregion

        private void buscarEstaciones(object sender, EventArgs e)
        {
            if(tabControl1.SelectedTab == CrearEstacion)
            {
                actualizarEstaciones(txtEstCreBuscar, lstCreEstaciones);
            }
            else if (tabControl1.SelectedTab == ModificarEstacion)
            {
                actualizarEstaciones(txtEstacionesModBuscar, lstModEstaciones);
            }
            else
            {
                actualizarEstaciones(txtEstEliBuscar, lstEliEstaciones);
            }
        }

        private void actualizarEstaciones(TextBox buscarEstacion, ListBox resultados)
        {
            if (!String.IsNullOrEmpty(buscarEstacion.Text) && Util.EsAlfaNumerico(buscarEstacion.Text))
            {
                resultados.Items.Clear();
                context.Estaciones.Where(x => x.Nombre.Contains(buscarEstacion.Text)).ToList().ForEach(y => resultados.Items.Add(y));
            }
            else
            {
                cargarEstaciones();
            }
            limpiarFormulario();
            deshabilitarModificar();
        }

        private void serviciosAsociadas(object sender, EventArgs e)
        {
            if (lstEliEstaciones.SelectedIndex > -1)
            {
                Servicios s;
                lstEstEliServicios.Items.Clear();
                List<Relaciones> se = context.Relaciones.Where(x => x.Id_Estacion_Anterior == ((Estaciones)lstEliEstaciones.SelectedItem).Id || x.Id_Estacion_Siguiente == ((Estaciones)lstEliEstaciones.SelectedItem).Id).ToList();
                foreach (var serv in se)
                {
                    s = context.Servicios.Where(x => x.Id == serv.Id_Servicio).FirstOrDefault();
                    if (lstEstEliServicios.FindStringExact(s.Nombre) < 0)
                    {
                        lstEstEliServicios.Items.Add(s);
                    }
                }
            }
        }

        private void habilitarModificar()
        {
            txtEstModNombre.Enabled = true;
            txtEstModMinimo.Enabled = true;
            txtEstModMaximo.Enabled = true;
            clbModIncidentes.Enabled = true;
            cmbEstModFdp.Enabled = true;
        }

        private void deshabilitarModificar()
        {
            txtEstModNombre.Enabled = false;
            txtEstModMinimo.Enabled = false;
            txtEstModMaximo.Enabled = false;
            clbModIncidentes.Enabled = false;
            cmbEstModFdp.Enabled = false;
        }

        private void seleccionarIncidentes(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == CrearEstacion)
            {
                checkIncidentes(clbIncidentes);
            }
            else
            {
                checkIncidentes(clbModIncidentes);
            }
        }

        private void checkIncidentes(CheckedListBox clb)
        {
            if(clb.GetItemChecked(clb.SelectedIndex))
            {
                clb.SetItemChecked(clb.SelectedIndex, false);
            }
            else
            {
                clb.SetItemChecked(clb.SelectedIndex, true);
            }
        }
    }
}
