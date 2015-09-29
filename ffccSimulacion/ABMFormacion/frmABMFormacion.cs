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
            CargarListaCochesCrearFormacion();
            CargarListasFormaciones();
        }

        private void CargarListaCochesCrearFormacion()
        {
            foreach (Coches c in context.Coches)
                lbxCochesExistentes.Items.Add(c);
            //lbxCochesExistentes.DisplayMember = "Modelo";
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
            txtConsumoFormacionParado.Text = auxCochesFormacion.Select(x => x.Coches.ConsumoParado * x.VecesRepetido).Sum().ToString();
            txtConsumoFormacionMov.Text = auxCochesFormacion.Select(x => x.Coches.ConsumoMovimiento * x.VecesRepetido).Sum().ToString();
            txtTotalCoches.Text = auxCochesFormacion.Select(x => x.VecesRepetido).Sum().ToString();
            txtTotalAsientos.Text = auxCochesFormacion.Select(x => x.Coches.CantidadAsientos * x.VecesRepetido).Sum().ToString();
            txtMaxPasajerosLegal.Text = auxCochesFormacion.Select(x => x.Coches.MaximoLegalPasajeros * x.VecesRepetido).Sum().ToString();
            txtMaxRealPasajeros.Text = auxCochesFormacion.Select(x => x.Coches.CapacidadMaximaPasajeros * x.VecesRepetido).Sum().ToString();
        }

        private void LimpiarTabCrearFormacion()
        {
            txtNombreFormacion.Text = "";
            txtCantidadCoches.Text = "";
            lbxCochesFormacion.Items.Clear();
            auxCochesFormacion = new List<Formaciones_X_Coches>();
            lbxCochesExistentes.SelectedIndex = -1;
            RecalcularTotalesFormacion();
        }

        private void btnAgregarFormacion_Click(object sender, EventArgs e)
        {
            string errorMsj = "";
            if (!Util.EsNumerico(txtCantidadCoches.Text))
                errorMsj += "Cantidad: Incompleto/Incorrecto.\n";
            if(lbxCochesExistentes.SelectedItem == null)
                errorMsj += "No se seleccionó ningun coche para agregar a la formación.\n";

            if (String.IsNullOrEmpty(errorMsj))
            {
                Formaciones_X_Coches fc = new Formaciones_X_Coches();
                Coches unCoche = (Coches)lbxCochesExistentes.SelectedItem;
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
        }

        private void CrearNuevaFormacion()
        {
            string errorMsj = "";
            if (!Util.EsAlfaNumerico(txtNombreFormacion.Text))
                errorMsj += "Nombre: Incompleto/Incorrecto.\n";
            if(auxCochesFormacion.Count == 0)
                errorMsj += "La formación no tiene coches.\n";
            if (auxCochesFormacion.Where(x => x.Coches.EsLocomotora == 1).Count() == 0)
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
                    lbxFormacionesModificar.Items.Add(nuevaFormacion);
                    lbxFormacionesEliminar.Items.Add(nuevaFormacion);
                    LimpiarTabCrearFormacion();
                    MessageBox.Show("La formación se ha creado exitosamente.\n");
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
        }

        private void lbxCochesFormacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            Coches unCoche = (Coches)lbxCochesFormacion.SelectedItem;
            txtCantidadCoches.Text = auxCochesFormacion.Where(x => x.Id_Coche == unCoche.Id).First().VecesRepetido.ToString();
        }

        private void lbxCochesExistentes_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCantidadCoches.Text = "";
        }

        private void btnBorrarFormacion_Click(object sender, EventArgs e)
        {
            string errorMsj = "";
            Formaciones unaFormacion = (Formaciones)lbxFormacionesEliminar.SelectedItem;

            if (context.Servicios_X_Formaciones.Where(x => x.Formaciones.Id == unaFormacion.Id).Count() != 0)
                errorMsj += "La formación no puede borrarse porque pertenece a un servicio.\n";

            if (lbxFormacionesEliminar.SelectedItem == null)
                errorMsj += "No se ha seleccionado ninguna formación para eliminar.\n";

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
                    MessageBox.Show("La formación se ha borrado exitosamente.");
                }
                catch (Exception exc)
                {
                    MessageBox.Show("No se borro la formación \n\n" + exc.ToString());
                }
            }
            else
                MessageBox.Show(errorMsj);
        }
    }
}
