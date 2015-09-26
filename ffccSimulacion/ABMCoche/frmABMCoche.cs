using ffccSimulacion.Dominio;
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

namespace ffccSimulacion.ABMCoche
{
    public partial class frmABMCoche : Form
    {
        ffccSimulacionEntities context;

        public frmABMCoche()
        {
            InitializeComponent();

            context = new ffccSimulacionEntities();
            rndEsLocomotoraNo.Checked = true;
            cbxTipoConsumo.Enabled = false;
            txtConsumoMov.Enabled = false;
            txtConsumoParado.Enabled = false;

            cargarCochesEnListas();
        }

        private void btnCocheNuevoCancelar_Click(object sender, EventArgs e)
        {
            this.pnlCoche.Controls.Clear();
        }

        private void btnCocheNuevoAceptar_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabCrear)
                GuardarNuevoCoche();
        }
        
        private void GuardarNuevoCoche()
        {
            string errorMsj = "";

            if (!Util.EsAlfaNumerico(txtModelo.Text))
                errorMsj += "Modelo: Incompleto/Incorrecto.\n";

            if(rndEsLocomotoraSi.Checked)
            {
                if(cbxTipoConsumo.SelectedItem == "")
                    errorMsj += "Tipo Consumo: Incompleto/Incorrecto.\n";

                if(!Util.EsNumerico(txtConsumoMov.Text))
                    errorMsj += "Consumo en movimiento: Incompleto/Incorrecto.\n";

                if (!Util.EsNumerico(txtConsumoParado.Text))
                    errorMsj += "Consumo parado: Incompleto/Incorrecto.\n";
            }

            if (!Util.EsNumerico(txtCantidadAsientos.Text))
                errorMsj += "Cantidad Asientos: Incompleto/Incorrecto.\n";

            if (!Util.EsNumerico(txtMaxLegal.Text))
                errorMsj += "Capacidad maxima legal: Incompleto/Incorrecto.\n";

            if (!Util.EsNumerico(txtMaxReal.Text))
                errorMsj += "Capacidad maxima real: Incompleto/Incorrecto.\n";

            if (String.IsNullOrEmpty(errorMsj))
            {
                try
                {
                    Coches nuevoCoche = new Coches();
                    nuevoCoche.Modelo = txtModelo.Text;
                    if (rndEsLocomotoraSi.Checked)
                    {
                        nuevoCoche.EsLocomotora = 1;
                        nuevoCoche.ConsumoMovimiento = Convert.ToInt32(txtConsumoMov.Text);
                        nuevoCoche.ConsumoParado = Convert.ToInt32(txtConsumoParado.Text);
                        if (cbxTipoConsumo.SelectedItem == "Electrico")
                            nuevoCoche.TipoConsumo = (int)TipoConsumo.Electrico;
                        else
                            nuevoCoche.TipoConsumo = (int)TipoConsumo.Disel;
                    }
                    else
                    {
                        nuevoCoche.EsLocomotora = 0;
                        nuevoCoche.ConsumoMovimiento = 0;
                        nuevoCoche.ConsumoParado = 0;
                    }
                    nuevoCoche.CantidadAsientos = Convert.ToInt32(txtCantidadAsientos.Text);
                    nuevoCoche.MaximoLegalPasajeros = Convert.ToInt32(txtMaxLegal.Text);
                    nuevoCoche.CapacidadMaximaPasajeros = Convert.ToInt32(txtMaxReal.Text);

                    context.Coches.Add(nuevoCoche);
                    context.SaveChanges();
                    lbxCochesBorrar.Items.Add(nuevoCoche);
                    lbxCochesModificar.Items.Add(nuevoCoche);
                    LimpiarTabNuevoCoche();
                    MessageBox.Show("Coche Guardado.");
                }
                catch (Exception exc)
                {
                    MessageBox.Show("No se Guardo el Coche \n\n" + exc.ToString());
                }
            }
            else
            {
                MessageBox.Show(errorMsj);
            }
        }

        private void rndEsLocomotoraSi_CheckedChanged(object sender, EventArgs e)
        {
            if (rndEsLocomotoraSi.Checked)
            {
                cbxTipoConsumo.Enabled = true;
                txtConsumoMov.Enabled = true;
                txtConsumoParado.Enabled = true;
            }
            else
            {
                cbxTipoConsumo.Enabled = false;
                txtConsumoMov.Enabled = false;
                txtConsumoParado.Enabled = false;
            }

        }

        private void btnCocheNuevoLimpiar_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabCrear)
                LimpiarTabNuevoCoche();

            /*if (tabControl1.SelectedTab == tabEliminar)
                context.SaveChanges();*/
        }

        private void LimpiarTabNuevoCoche()
        {
            txtModelo.Text = "";
            rndEsLocomotoraNo.Checked = true;
            cbxTipoConsumo.SelectedItem = "";
            txtConsumoMov.Text = "";
            txtConsumoParado.Text = "";
            txtCantidadAsientos.Text = "";
            txtMaxLegal.Text = "";
            txtMaxReal.Text = "";
            cbxTipoConsumo.Enabled = false;
            txtConsumoMov.Enabled = false;
            txtConsumoParado.Enabled = false;
        }

        private void cargarCochesEnListas()
        {
            List<Coches> listaCoches = context.Coches.ToList<Coches>();
            foreach(Coches c in listaCoches)
            {
                lbxCochesBorrar.Items.Add(c);
                lbxCochesModificar.Items.Add(c);
            }

            /*Se define cual propiedad de los objeto que estan dentro de las list box se van a mostrar*/
            //lbxCochesBorrar.DisplayMember = "Modelo";
            //lbxCochesModificar.DisplayMember = "Modelo";
        }

        private void btnBorrarCoche_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("El coche se eliminará de manera permanente.¿Desea continuar?", "", MessageBoxButtons.OKCancel) == DialogResult.Cancel) return;
            Coches unCoche = (Coches)lbxCochesBorrar.SelectedItem;
            try
            {
                /*Se verifica que el coche no pertenezca a ninguna formacion antes de borrarlo*/
                if (context.Formaciones_X_Coches.Where(x => x.Id_Coche == unCoche.Id).Count() == 0)
                {
                    context.Coches.Remove(unCoche);
                    context.SaveChanges();
                    lbxCochesBorrar.Items.Remove(unCoche);
                    lbxCochesModificar.Items.Remove(unCoche);
                    MessageBox.Show("El Coche ha sido borrado");
                }
                else
                    MessageBox.Show("El coche no puede borrarse porque pertenece a una o mas formaciones");
            }
            catch (Exception exc)
            {
                MessageBox.Show("No se borro el Coche \n\n" + exc.ToString());
            }
        }

    }
}
