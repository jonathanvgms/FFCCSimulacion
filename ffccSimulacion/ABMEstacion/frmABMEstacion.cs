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

            context.Estaciones.ToList().ForEach(x => { lstModEstaciones.Items.Add(x); lstEliEstaciones.Items.Add(x); });
        }

        #endregion
        
        #region Casos de Uso
        
        /*
         * Caso de Uso 'Modificar Estacion'
         */ 
        private void tabModificarEstacion()
        {
            string errorMsj = "";

            if (!Util.EsAlfaNumerico(txtEstModNombre.Text))
            {
                errorMsj += "Nombre: Valor Incompleto/Incorrecto\n";
            }

            if (!Util.EsNumerico(txtEstModMinimo.Text))
            {
                errorMsj += "Personas Mínimas en Andén: Valor Incompleto/Incorrecto\n";
            }

            if (!Util.EsNumerico(txtEstModMaximo.Text))
            {
                errorMsj += "Personas Máximas en Andén: Valor Incompleto/Incorrecto\n";
            }

            if (cmbEstModFdp.SelectedIndex < 0)
            {
                errorMsj += "Fdp: Falta Seleccionar\n";
            }

            if (!verificarRangoPersonas(txtEstModMinimo, txtEstModMaximo))
            {
                errorMsj += "Personas en Andén:\n\n1) El Mínimo debe ser menor que el Máximo\n2) El rango de personas debe ser 0 a 999999999 (9 Cifras)";
<<<<<<< .mine
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

                    MessageBox.Show("Estación Guardada");

                    cargarEstaciones();

                    limpiarFormulario();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Estación No Guardada\nError:\n" + exc.ToString());
                }
            }
            else
            {
                MessageBox.Show(errorMsj);
||||||| .r86
            }

            if (errorMsj.Length == 0)
            {
                try
                {
                    estacionSeleccionada = (Estaciones)clbModIncidentes.SelectedItem;

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

                    MessageBox.Show("Estación Guardada");

                    cargarEstaciones();

                    limpiarFormulario();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Estación No Guardada\nError:\n" + exc.ToString());
                }
            }
            else
            {
                MessageBox.Show(errorMsj);
=======
>>>>>>> .r87
            }

            if (errorMsj.Length == 0)
            {
                try
                {
                    estacionSeleccionada = (Estaciones)clbModIncidentes.SelectedItem;

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

                    MessageBox.Show("Estación Guardada");

                    cargarEstaciones();

                    limpiarFormulario();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Estación No Guardada\nError:\n" + exc.ToString());
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

            if(!Util.EsAlfaNumerico(txtEstCreNombre.Text))
            {
                errorMsj += "Nombre: Valor Incompleto/Incorrecto\n";
            }

            if(!Util.EsNumerico(txtEstCreMinimo.Text))
            {
                errorMsj += "Personas Mínimas en Andén: Valor Incompleto/Incorrecto\n";
            }

            if (!Util.EsNumerico(txtEstCreMaximo.Text))
            {
                errorMsj += "Personas Máximas en Andén: Valor Incompleto/Incorrecto\n";
            }

            if(cmbEstCreFdp.SelectedIndex < 0)
            {
                errorMsj += "Fdp: Falta Seleccionar\n";
            }

            if(!verificarRangoPersonas(txtEstCreMinimo, txtEstCreMaximo))
            {
                errorMsj += "Personas en Andén:\n\n1) El Mínimo debe ser menor que el Máximo\n2) El rango de personas deber ser, 0 a 999999999 (9 Cifras)";
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

                    MessageBox.Show("Estación Guardada");

                    cargarEstaciones();

                    limpiarFormulario();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Estación No Guardada\nError:\n" + exc.ToString());
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
            try
            {
                estacionSeleccionada = (Estaciones)lstEliEstaciones.SelectedItem;

                context.Estaciones_X_Incidentes.Where(x => x.Id_Estacion == estacionSeleccionada.Id).ToList().ForEach(y => context.Estaciones_X_Incidentes.Remove(y));

                context.Estaciones.Remove(estacionSeleccionada);

                context.SaveChanges();

                cargarEstaciones();

                MessageBox.Show("Estación Eliminada");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Estación No Eliminada\nError:\n" + exc.ToString());
            }
        }
        #endregion

        #region Metodos Auxiliares
        /*
         * Verifica que el minimo que personas sea menor al maximo de personas esperando en el anden
         */ 
        private bool verificarRangoPersonas(TextBox minimo, TextBox maximo)
        {
            if ((minimo.Text.Length > 9) || (maximo.Text.Length > 9))
            {
                return false;
            }

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
            estacionSeleccionada = (Estaciones)lstModEstaciones.SelectedItem;

            txtEstModNombre.Text = estacionSeleccionada.Nombre;

            txtEstModMinimo.Text = estacionSeleccionada.PersonasEsperandoMin.ToString();

            txtEstModMaximo.Text = estacionSeleccionada.PersonasEsperandoMax.ToString();

            cmbEstModFdp.SelectedIndex = estacionSeleccionada.TipoFDP;

            for (int i = 0; i < clbModIncidentes.Items.Count; i++)
            {
                clbModIncidentes.SetItemChecked(i, false);
            }

            foreach (Incidentes i in estacionSeleccionada.ListaIncidentes)
            {
                clbModIncidentes.SetItemChecked(clbModIncidentes.Items.IndexOf(i), true);
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

            //ver porque no funciona los métodos
            for (int i = 0; i < clbModIncidentes.Items.Count; i++)
            {
                clbIncidentes.SetItemChecked(i, false);

                clbModIncidentes.SetItemChecked(i, false);
            }
        }

        #endregion
    }
}
