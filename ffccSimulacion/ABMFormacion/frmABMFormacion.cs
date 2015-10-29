using ffccSimulacion.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ffccSimulacion.ABMFormacion
{
    public partial class frmABMFormacion : Form
    {
        ffccSimulacionEntities context;
        private List<Formaciones_X_Coches> auxCochesFormacion;

        public frmABMFormacion()
        {
            InitializeComponent();

            context = new ffccSimulacionEntities();
            auxCochesFormacion = new List<Formaciones_X_Coches>();
            CargarListasEstaciones();
            CargarListasFormaciones();
        }

        private void CargarListasEstaciones()
        {
            foreach (Coches c in context.Coches)
            {
                lbxCochesExistentes.Items.Add(c);
                lbxCochesExistentesMod.Items.Add(c);
            }
        }

        private void CargarListasFormaciones()
        {
            foreach(Formaciones f in context.Formaciones)
            {
                lbxFormacionesEliminar.Items.Add(f);
                lbxFormacionesModificar.Items.Add(f);
            }
        }
        private void RecalcularTotalesFormacion()
        {
            if (tabControl1.SelectedTab == tabCrearFormacion)
            {
                txtConsumoFormacionParado.Text = auxCochesFormacion.Select(x => x.Coches.ConsumoParado * x.VecesRepetido).Sum().ToString();
                txtConsumoFormacionMov.Text = auxCochesFormacion.Select(x => x.Coches.ConsumoMovimiento * x.VecesRepetido).Sum().ToString();
                txtTotalCoches.Text = auxCochesFormacion.Select(x => x.VecesRepetido).Sum().ToString();
                txtTotalAsientos.Text = auxCochesFormacion.Select(x => x.Coches.CantidadAsientos * x.VecesRepetido).Sum().ToString();
                txtMaxPasajerosLegal.Text = auxCochesFormacion.Select(x => x.Coches.MaximoLegalPasajeros * x.VecesRepetido).Sum().ToString();
                txtMaxRealPasajeros.Text = auxCochesFormacion.Select(x => x.Coches.CapacidadMaximaPasajeros * x.VecesRepetido).Sum().ToString();
            }
            else if(tabControl1.SelectedTab == tabModificarFormacion)
            {
                Formaciones f = (Formaciones)lbxFormacionesModificar.SelectedItem;
                if (f == null)
                {
                    txtConsumoFormacionMovMod.Text = "0";
                    txtConsumoFormacionParadoMod.Text = "0";
                    txtTotalCochesMod.Text = "0";
                    txtTotalAsientosMod.Text = "0";
                    txtMaximoPasajerlosLegalMod.Text = "0";
                    txtMaximoPasajerosRealMod.Text = "0";
                    return;
                }

                txtConsumoFormacionMovMod.Text = f.Formaciones_X_Coches.Select(x => x.Coches.ConsumoMovimiento * x.VecesRepetido).Sum().ToString();
                txtConsumoFormacionParadoMod.Text = f.Formaciones_X_Coches.Select(x => x.Coches.ConsumoParado * x.VecesRepetido).Sum().ToString();
                txtTotalCochesMod.Text = f.Formaciones_X_Coches.Select(x => x.VecesRepetido).Sum().ToString();
                txtTotalAsientosMod.Text = f.Formaciones_X_Coches.Select(x => x.Coches.CantidadAsientos * x.VecesRepetido).Sum().ToString();
                txtMaximoPasajerlosLegalMod.Text = f.Formaciones_X_Coches.Select(x => x.Coches.MaximoLegalPasajeros * x.VecesRepetido).Sum().ToString();
                txtMaximoPasajerosRealMod.Text = f.Formaciones_X_Coches.Select(x => x.Coches.CapacidadMaximaPasajeros * x.VecesRepetido).Sum().ToString();
            }
        }

        private void LimpiarTabCrearFormacion()
        {
            lbxFormacionesModificar.Items.Clear();
            lbxFormacionesEliminar.Items.Clear();
            CargarListasFormaciones();
            txtNombreFormacion.Text = "";
            txtCantidadCoches.Text = "";
            lbxCochesFormacion.Items.Clear();
            auxCochesFormacion = new List<Formaciones_X_Coches>();
            lbxCochesExistentes.SelectedIndex = -1;
            txtCantidadCoches.Enabled = true;
            RecalcularTotalesFormacion();
        }

        private void LimpiarTabModificarFormacion(bool inhabilitarControles = false)
        {
            if (inhabilitarControles)
            {
                txtNombreFormacionMod.Enabled = false;
                lbxCochesExistentesMod.Enabled = false;
                txtCantidadCochesMod.Enabled = false;
                lbxCochesFormacionMod.Enabled = false;
            }

            lbxFormacionesModificar.Items.Clear();
            lbxFormacionesEliminar.Items.Clear();
            CargarListasFormaciones();
            txtNombreFormacionMod.Text = "";
            txtCantidadCochesMod.Text = "";
            lbxCochesFormacionMod.Items.Clear();
            lbxCochesExistentesMod.SelectedIndex = -1;
            lbxFormacionesModificar.SelectedIndex = -1;
            //txtCantidadCochesMod.Enabled = true;
            RecalcularTotalesFormacion();
        }

        private void btnAgregarFormacion_Click(object sender, EventArgs e)
        {
            Coches unCoche = (Coches)lbxCochesExistentes.SelectedItem;

            if (unCoche == null) return;

            string errorMsj = "";
            if (!Util.EsNumerico(txtCantidadCoches.Text))
                errorMsj += "Cantidad: Incompleto ó Incorrecto.\n";
            else if (int.Parse(txtCantidadCoches.Text) < 1)
                errorMsj += "Cantidad: El Valor debe ser Positivo.\n";
            if(lbxCochesExistentes.SelectedItem == null)
                errorMsj += "No se seleccionó ningun coche para agregar a la formación.\n";
            if (auxCochesFormacion.Where(x => x.Id_Coche == unCoche.Id).Count() != 0)
                errorMsj += "El coche ya existe dentro de esta formación.\n";

            if (String.IsNullOrEmpty(errorMsj))
            {
                Formaciones_X_Coches fc = new Formaciones_X_Coches();
                fc.Coches = unCoche;
                fc.Id_Coche = unCoche.Id;
                fc.VecesRepetido = Convert.ToInt32(txtCantidadCoches.Text);
                auxCochesFormacion.Add(fc);
                lbxCochesFormacion.Items.Add(unCoche);
                RecalcularTotalesFormacion();
            }
            else
                MessageBox.Show(errorMsj);
        }

        private void btnBorrarCocheFormacion_Click(object sender, EventArgs e)
        {
            string errorMsj = "";
            if (lbxCochesFormacion.SelectedItem == null)
                errorMsj += "No se seleccionó ningun coche para sacar de la formación.\n";

            if (String.IsNullOrEmpty(errorMsj))
            {
                Coches unCoche = (Coches)lbxCochesFormacion.SelectedItem;
                auxCochesFormacion.Remove(auxCochesFormacion.Where(x => x.Id_Coche == unCoche.Id).First());
                lbxCochesFormacion.Items.Remove(unCoche);
                RecalcularTotalesFormacion();
            }
            else
                MessageBox.Show(errorMsj);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabCrearFormacion)
                CrearNuevaFormacion();

            if (tabControl1.SelectedTab == tabModificarFormacion)
                GuardarModificacionesFormacion();
        }

        private void CrearNuevaFormacion()
        {
            int cantidadLocomotoras = auxCochesFormacion.Where(x => x.Coches.EsLocomotora == 1).Sum(x => x.VecesRepetido);
            string errorMsj = "";

            if (cantidadLocomotoras > 1)
            {
                if (MessageBox.Show("Atención: la formación tiene mas de una locomotora.¿Desea Continuar?", "", MessageBoxButtons.OKCancel) == DialogResult.Cancel) return;
            }

            if (!Util.EsAlfaNumerico(txtNombreFormacion.Text))
                errorMsj += "Nombre: Incompleto/Incorrecto.\n";
            else if (context.Formaciones.Where(x => x.NombreFormacion == txtNombreFormacion.Text).Count() > 0)
                errorMsj += "Nombre: ya existe una formación con el mismo nombre.\n";

            if(auxCochesFormacion.Count == 0)
                errorMsj += "La formación no tiene coches.\n";
            
            if (cantidadLocomotoras == 0)
                errorMsj += "No hay ninguna locomotora en la formación.\n";

            if (String.IsNullOrEmpty(errorMsj))
            {
                try
                {
                    Formaciones nuevaFormacion = new Formaciones();
                    nuevaFormacion.NombreFormacion = txtNombreFormacion.Text;
                    nuevaFormacion.Formaciones_X_Coches = auxCochesFormacion;
                    context.Formaciones.Add(nuevaFormacion);
                    context.SaveChanges();
                    MessageBox.Show("La formación se ha creado exitosamente.\n");
                    LimpiarTabCrearFormacion();

                }
                catch (Exception exc)
                {
                    MessageBox.Show("No se guardo la formación \n\n" + exc.ToString());
                }
            }
            else
                MessageBox.Show(errorMsj);
        }

        private void GuardarModificacionesFormacion()
        {
            Formaciones formacionSeleccionada = (Formaciones)lbxFormacionesModificar.SelectedItem;
            string errorMsj = "";
            List<Formaciones_X_Coches> auxFormacionCochesMod = new List<Formaciones_X_Coches>();

            if (formacionSeleccionada == null)
            {
                MessageBox.Show("Se ha deseleccionado la formación que iba a ser modificada.\n");
                return;
            }

            List<string> nombresFormaciones = context.Formaciones.Where(x => x.Id != formacionSeleccionada.Id).Select(x => x.NombreFormacion).ToList<string>();

            foreach (Formaciones_X_Coches fc in lbxCochesFormacionMod.Items)
                auxFormacionCochesMod.Add(fc);

            int cantidadLocomotoras = auxFormacionCochesMod.Where(x => x.Coches.EsLocomotora == 1).Sum(x => x.VecesRepetido);

            if (cantidadLocomotoras > 1)
            {
                if (MessageBox.Show("Atención: la formación tiene mas de una locomotora.¿Desea Continuar?", "", MessageBoxButtons.OKCancel) == DialogResult.Cancel) return;
            }

            if (!Util.EsAlfaNumerico(txtNombreFormacionMod.Text))
                errorMsj += "Nombre: Incompleto/Incorrecto.\n";
            else if (nombresFormaciones.Contains(txtNombreFormacionMod.Text))
                errorMsj += "Nombre: ya existe una formación con el mismo nombre.\n";

            if (auxFormacionCochesMod.Count == 0)
                errorMsj += "La formación no tiene coches.\n";
            if (cantidadLocomotoras == 0)
                errorMsj += "La formación debe tener al menos una locomotora.\n";

            if (string.IsNullOrEmpty(errorMsj))
            {
                try
                {
                    formacionSeleccionada.NombreFormacion = txtNombreFormacionMod.Text;
                    /*Los coches se fueron guardando en la formacion en el momento que el coche se agrega a la lista dentro del metodo "btnAgregarCocheMod_Click()"
                     o en "btnEliminarCocheMod_Click()"*/

                    context.SaveChanges();
                    MessageBox.Show("La formación se ha guardado exitosamente.\n");
                    LimpiarTabModificarFormacion();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("No se guardo la formación \n\n" + exc.ToString());
                }
            }
            else
                MessageBox.Show(errorMsj);

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabCrearFormacion)
                LimpiarTabCrearFormacion();

            if (tabControl1.SelectedTab == tabModificarFormacion)
                LimpiarTabModificarFormacion(true);
        }

        private void lbxCochesFormacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            Coches unCoche = (Coches)lbxCochesFormacion.SelectedItem;
            if (unCoche == null) return;
            txtCantidadCoches.Text = auxCochesFormacion.Where(x => x.Id_Coche == unCoche.Id).First().VecesRepetido.ToString();
            txtCantidadCoches.Enabled = false;
        }

        private void lbxCochesExistentes_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCantidadCoches.Text = "";
            txtCantidadCoches.Enabled = true;
            lbxCochesFormacion.SelectedIndex = -1;
        }

        private void btnBorrarFormacion_Click(object sender, EventArgs e)
        {
            string errorMsj = "";
            Formaciones unaFormacion = (Formaciones)lbxFormacionesEliminar.SelectedItem;
            
            if (lbxFormacionesEliminar.SelectedItem == null)
                errorMsj += "No se ha seleccionado ninguna formación para eliminar.\n";
            else if (context.Servicios_X_Formaciones.Where(x => x.Formaciones.Id == unaFormacion.Id).Count() != 0)
                    errorMsj += "La formación no puede borrarse porque pertenece a un servicio.\n";

            if (string.IsNullOrEmpty(errorMsj))
            {
                try
                {
                    if (MessageBox.Show("La formación se eliminará de manera permanente.¿Desea continuar?", "", MessageBoxButtons.OKCancel) == DialogResult.Cancel) return;
                    Formaciones f = (Formaciones)lbxFormacionesEliminar.SelectedItem;

                    foreach (Formaciones_X_Coches fc in context.Formaciones_X_Coches.Where(x => x.Id_Formacion == f.Id))
                        context.Formaciones_X_Coches.Remove(fc);
                    
                    context.Formaciones.Remove(f);
                    context.SaveChanges();

                    lbxFormacionesEliminar.Items.Remove(f);
                    lbxFormacionesModificar.Items.Remove(f);
                    //para que limpie los otras pestañas y que no quede info inconsistente
                    LimpiarTabCrearFormacion();
                    LimpiarTabModificarFormacion();
                    MessageBox.Show("La formación se ha borrado exitosamente.");
                }
                catch (Exception exc)
                {
                    MessageBox.Show("No se borró la formación \n\n" + exc.ToString());
                }
            }
            else
                MessageBox.Show(errorMsj);
        }

        private void lbxFormacionesModificar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxFormacionesModificar.SelectedIndex > -1)
            {
                txtNombreFormacionMod.Enabled = true;
                lbxCochesExistentesMod.Enabled = true;
                txtCantidadCochesMod.Enabled = true;
                lbxCochesFormacionMod.Enabled = true;

                txtCantidadCochesMod.Text = "";

                Formaciones unaFormacion = (Formaciones)lbxFormacionesModificar.SelectedItem;
                txtNombreFormacionMod.Text = unaFormacion.NombreFormacion;
                lbxCochesFormacionMod.Items.Clear();
                foreach (Formaciones_X_Coches fc in unaFormacion.Formaciones_X_Coches)
                    lbxCochesFormacionMod.Items.Add(fc);
                RecalcularTotalesFormacion();
            }
        }

        private void lbxCochesFormacionMod_SelectedIndexChanged(object sender, EventArgs e)
        {
            Formaciones_X_Coches fc = (Formaciones_X_Coches)lbxCochesFormacionMod.SelectedItem;
            if (fc != null)
            {
                txtCantidadCochesMod.Text = fc.VecesRepetido.ToString();
                txtCantidadCochesMod.Enabled = false;
            }
        }

        private void lbxCochesExistentesMod_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbxCochesFormacionMod.SelectedIndex = -1;
            txtCantidadCochesMod.Text = "";
            txtCantidadCochesMod.Enabled = true;
        }

        private void btnAgregarCocheMod_Click(object sender, EventArgs e)
        {
            string errorMsj = "";
            Coches cocheSeleccionado = (Coches)lbxCochesExistentesMod.SelectedItem;
            Formaciones formacionSeleccionada = (Formaciones)lbxFormacionesModificar.SelectedItem;
            
            if (formacionSeleccionada == null)
                errorMsj += "No se seleccionó ninguna formación para ser modificada.\n";
            if (cocheSeleccionado == null)
                errorMsj += "No se seleccionó ningún coche para ser agregado.\n";
            if (!Util.EsNumerico(txtCantidadCochesMod.Text))
                errorMsj += "Cantidad de coches: Incompleto/Incorrecto.\n";
            if (formacionSeleccionada.Formaciones_X_Coches.Where(x => x.Coches.Modelo == cocheSeleccionado.Modelo).Count() != 0)
                errorMsj += "El coche ya pertenece a la formación.\n";
            
            if (string.IsNullOrEmpty(errorMsj))
            {
                Formaciones_X_Coches fc = new Formaciones_X_Coches();
                fc.Coches = cocheSeleccionado;
                fc.Id_Coche = cocheSeleccionado.Id;
                fc.VecesRepetido = Convert.ToInt32(txtCantidadCochesMod.Text);
                formacionSeleccionada.Formaciones_X_Coches.Add(fc);
                lbxCochesFormacionMod.Items.Add(fc);
                txtCantidadCochesMod.Text = "";
                RecalcularTotalesFormacion();
            }
            else
                MessageBox.Show(errorMsj);
        }

        private void btnEliminarCocheMod_Click(object sender, EventArgs e)
        {
            string errorMsj = "";
            Formaciones_X_Coches fc = (Formaciones_X_Coches)lbxCochesFormacionMod.SelectedItem;
            Formaciones formacionSeleccionada = (Formaciones)lbxFormacionesModificar.SelectedItem;

            if (fc == null)
                errorMsj += "No se seleccionó ningún coche para ser eliminado.\n";
            if (formacionSeleccionada == null)
                errorMsj += "No se seleccionó ninguna formación para ser modificada.\n";

            if (string.IsNullOrEmpty(errorMsj))
            {
                lbxCochesFormacionMod.SelectedIndex = -1;
                formacionSeleccionada.Formaciones_X_Coches.Remove(fc);
                
                /*Esto se hace asi en caso de que el objeto todavia no haya sido agregado/guadado en el contexto de la bd*/
                try { context.Formaciones_X_Coches.Remove(fc); }
                catch (Exception exc) { }

                lbxCochesFormacionMod.Items.Remove(fc);
                RecalcularTotalesFormacion();
            }
            else
                MessageBox.Show(errorMsj);
        }

        private void seleccionarPestaña(object sender, TabControlEventArgs e)
        {
            if (tabControl1.SelectedTab == tabCrearFormacion)
            {
                btnAceptar.Enabled = true;
                btnLimpiar.Enabled = true;
            }
            if (tabControl1.SelectedTab == tabModificarFormacion)
            {
                btnAceptar.Enabled = true;
                btnLimpiar.Enabled = true;
            }
            if (tabControl1.SelectedTab == tabPage3)
            {
                btnAceptar.Enabled = false;
                btnLimpiar.Enabled = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlFormacion.Controls.Clear();
        }

        private void lbxFormacionesEliminar_SelectedIndexChanged(object sender, EventArgs e)
        {
            Formaciones f = (Formaciones)lbxFormacionesEliminar.SelectedItem;
            
            if (f == null)
                return;

            lbxServiciosAsociadosEliminar.Items.Clear();
            List<Servicios_X_Formaciones> serviciosFormacionesAsociados = context.Servicios_X_Formaciones.Where(x => x.Id_Formacion == f.Id).ToList<Servicios_X_Formaciones>();

            foreach (Servicios_X_Formaciones sf in serviciosFormacionesAsociados)
                lbxServiciosAsociadosEliminar.Items.Add(sf.Servicios);
        }
    }
}
