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

            cargarIncidentes();

            cargarEstaciones();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.pnlEstacion.Controls.Clear();

            this.Close();
        }

        private void cargarIncidentes()
        {
            clbIncidentes.Items.Clear();

            clbModIncidentes.Items.Clear();

            context.Incidentes.ToList().ForEach(x => 
            {
                clbIncidentes.Items.Add(x.Nombre); 
                clbModIncidentes.Items.Add(x.Nombre);
            });
        }

        private void cargarEstaciones()
        {
            lstModEstaciones.Items.Clear();

            lstEliEstaciones.Items.Clear();

            context.Estaciones.ToList().ForEach(x =>
            {
                lstModEstaciones.Items.Add(x.Nombre);
                lstEliEstaciones.Items.Add(x.Nombre);
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmABMIncidente formIncidente = new frmABMIncidente();

            formIncidente.Show(this);

            cargarIncidentes();
        }

        private void btnEstacionAceptar_Click(object sender, EventArgs e)
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
                errorMsj += "Personas en Andén: El Mínimo\ndebe ser menor que el Máximo\n";
            }

            if (errorMsj.Length == 0)
            {
                if (context.Estaciones.Where(x => x.Nombre == txtEstModNombre.Text).Count() > 1)
                {
                    lblEstCreError.Text = "Nombre: Existente. Modidique el Nombre";
                }
                else
                {
                    try
                    {
                        estacionSeleccionada = context.Estaciones.Where(x => x.Nombre == lstModEstaciones.SelectedItem.ToString()).FirstOrDefault();

                        estacionSeleccionada.Nombre = txtEstModNombre.Text;

                        estacionSeleccionada.PersonasEsperandoMin = Convert.ToInt32(txtEstModMinimo.Text);

                        estacionSeleccionada.PersonasEsperandoMax = Convert.ToInt32(txtEstModMaximo.Text);

                        estacionSeleccionada.TipoFDP = cmbEstModFdp.SelectedIndex;

                        context.Estaciones_X_Incidentes.Where(x => x.Id_Estacion == estacionSeleccionada.Id).ToList().ForEach(y => context.Estaciones_X_Incidentes.Remove(y));

                        foreach (var incidente in clbModIncidentes.CheckedItems)
                        {
                            estacionSeleccionada.AgregarIncidente(context.Incidentes.Where(x => x.Nombre == incidente.ToString()).FirstOrDefault());
                        }

                        context.SaveChanges();

                        lblEstacionError.Text = "La Estación Se Guardo";

                        cargarEstaciones();
                    }
                    catch (Exception exc)
                    {
                        lblEstacionError.Text = "La Estación No Se Guardo";
                        MessageBox.Show(exc.ToString());
                    }
                }
            }
            else
            {
                lblEstCreError.Text = errorMsj;
            }
        }

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
                errorMsj += "Personas en Andén: El Mínimo\ndebe ser menor que el Máximo\n";
            }
                        
            if (errorMsj.Length == 0)
            {
                if (context.Estaciones.Any(x => x.Nombre == txtEstCreNombre.Text))
                {
                    lblEstCreError.Text = "Nombre: Existente. Modidique el nombre";
                }
                else
                {
                    try
                    {
                        Estaciones nuevaEstacion = new Estaciones();
                        
                        nuevaEstacion.Nombre = txtEstCreNombre.Text;
                        
                        nuevaEstacion.PersonasEsperandoMin = Convert.ToInt32(txtEstCreMinimo.Text);
                        
                        nuevaEstacion.PersonasEsperandoMax = Convert.ToInt32(txtEstCreMaximo.Text);
                        
                        nuevaEstacion.TipoFDP = cmbEstCreFdp.SelectedIndex;
                        
                        foreach (var incidente in clbIncidentes.CheckedItems)
                        {
                             nuevaEstacion.AgregarIncidente(context.Incidentes.Where(x => x.Nombre == incidente.ToString()).FirstOrDefault());                            
                        }

                        context.Estaciones.Add(nuevaEstacion);

                        context.SaveChanges();
                        
                        lblEstacionError.Text = "La estación se guardo";

                        cargarEstaciones();
                    }
                    catch(Exception exc)
                    {
                        lblEstacionError.Text = "La estación no se guardo";
                        //MessageBox.Show(exc.ToString());
                    }
                }
            }
            else
            {
                lblEstCreError.Text = errorMsj;
            }
        }

        private bool verificarRangoPersonas(TextBox minimo, TextBox maximo)
        {
            if (Convert.ToInt64(minimo.Text) < Convert.ToInt64(maximo.Text) + 1)
            {
                return true;
            }

            return false;
        }

        private void btnEstBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                estacionSeleccionada = context.Estaciones.Where(x => x.Nombre == lstEliEstaciones.SelectedItem.ToString()).FirstOrDefault();
                
                context.Estaciones_X_Incidentes.Where(x => x.Id_Estacion == estacionSeleccionada.Id).ToList().ForEach(y => context.Estaciones_X_Incidentes.Remove(y));
                
                context.Estaciones.Remove(estacionSeleccionada);

                context.SaveChanges();

                cargarEstaciones();

                lblEstacionError.Text = "La Estación Se Borró";
            }
            catch (Exception exc)
            {
                lblEstacionError.Text = "La Estación No Se Borró";

                MessageBox.Show(exc.ToString());
            }
        }

        private void seleccionarEstacion(object sender, EventArgs e)
        {
            estacionSeleccionada = context.Estaciones.Where(x => x.Nombre == lstModEstaciones.SelectedItem.ToString()).FirstOrDefault();

            txtEstModNombre.Text = estacionSeleccionada.Nombre;

            txtEstModMinimo.Text = estacionSeleccionada.PersonasEsperandoMin.ToString();

            txtEstModMaximo.Text = estacionSeleccionada.PersonasEsperandoMax.ToString();

            cmbEstModFdp.SelectedIndex = estacionSeleccionada.TipoFDP;

            //ver porque no funciona es método
            //clbModIncidentes.ClearSelected();
            for (int i = 0; i < clbModIncidentes.Items.Count; i++)
            {
                clbModIncidentes.SetItemChecked(i, false);
            }

            foreach(var incidente in estacionSeleccionada.ListaIncidentes)
            {
                clbModIncidentes.SetItemChecked(clbModIncidentes.Items.IndexOf(incidente.Nombre), true);
            }
        }

        private void btnEstLimpiar_Click(object sender, EventArgs e)
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
    }
}
