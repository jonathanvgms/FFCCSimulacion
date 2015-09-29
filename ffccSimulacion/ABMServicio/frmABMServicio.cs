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

namespace ffccSimulacion.ABMServicio
{
    public partial class frmABMServicio : Form
    {
        ffccSimulacionEntities context;
        List<Relaciones> auxRelaciones;

        public frmABMServicio()
        {
            InitializeComponent();

            context = new ffccSimulacionEntities();
            auxRelaciones = new List<Relaciones>();

            /*Por un error en el framework estas propiedades no aparecen en el diseñador de las vistas ni sugeridas cuando se escriben.
             Pero igualmente te deja usarlas*/
            clbxFormacionesCrear.DisplayMember = "NombreFormacion";
            clbxFormacionesMod.DisplayMember = "NombreFormacion";
            cbxEsParadaCrear.Checked = true;

            CargarListas();
        }

        private void CargarListas()
        {
            foreach (Estaciones e in context.Estaciones)
            {
                lbxEstacionesOrigenCrear.Items.Add(e);
                lbxEstacionesDestinoCrear.Items.Add(e);
                lbxEstacionesDestinoMod.Items.Add(e);
                lbxEstacionesOrigenMod.Items.Add(e);
            }

            foreach (Formaciones f in context.Formaciones)
            {
                clbxFormacionesCrear.Items.Add(f);
                clbxFormacionesMod.Items.Add(f);
            }

            foreach(Servicios s in context.Servicios)
            {
                lbxServiciosModificar.Items.Add(s);
                lbxServiciosEliminar.Items.Add(s);
            }
        }

        private void btnAgregarRelacionTabCrear_Click(object sender, EventArgs e)
        {
            string errorMsj = "";
            Estaciones estacionOrigen = (Estaciones)lbxEstacionesOrigenCrear.SelectedItem;
            Estaciones estacionDestino = (Estaciones)lbxEstacionesDestinoCrear.SelectedItem;

            if (!Util.EsNumerico(txtDistanciaRelacionCrear.Text))
                errorMsj += "Distancia entre estaciones: Incompleto/Incorrecto.\n";
            if(!Util.EsNumerico(txtVelocidadRelacionCrear.Text))
                errorMsj += "Velocidad: Incompleto/Incorrecto.\n";
            if (estacionOrigen == null)
                errorMsj += "Debe seleccionar una estación de origen.\n";
            if (estacionDestino == null)
                errorMsj += "Debe seleccionar una estación de destino.\n";
            if (BuscarRelacion(estacionOrigen.Id, estacionDestino.Id) != null)
                errorMsj += "Esa relación ya existe en el servicio.\n";
            if (estacionDestino.Id == estacionOrigen.Id)
                errorMsj += "Una estación no puede ser origen y destino al mismo tiempo.\n";

            if (string.IsNullOrEmpty(errorMsj))
            {
                Relaciones nuevaRelacion = new Relaciones();
                nuevaRelacion.Estaciones = estacionOrigen;
                nuevaRelacion.Id_Estacion_Anterior = estacionOrigen.Id;
                nuevaRelacion.Estaciones1 = estacionDestino;
                nuevaRelacion.Id_Estacion_Siguiente = estacionDestino.Id;
                nuevaRelacion.TiempoViaje = 0;
                nuevaRelacion.Distancia = Convert.ToInt32(txtDistanciaRelacionCrear.Text);
                nuevaRelacion.VelocidadPromedio = Convert.ToInt32(txtVelocidadRelacionCrear.Text);

                if (cbxEsParadaCrear.Checked)
                    nuevaRelacion.Est_Sig_Es_Parada = 1;
                else
                    nuevaRelacion.Est_Sig_Es_Parada = 0;

                auxRelaciones.Add(nuevaRelacion);
                dgvRelacionesCrear.Rows.Add(new string[] { estacionOrigen.Nombre, estacionDestino.Nombre, estacionOrigen.Id.ToString(), estacionDestino.Id.ToString() });
                txtDistanciaRelacionCrear.Text = "";
                txtVelocidadRelacionCrear.Text = "";
                lbxEstacionesOrigenCrear.SelectedIndex = -1;
                lbxEstacionesDestinoCrear.SelectedIndex = -1;
            }
            else
                MessageBox.Show(errorMsj);
        }

        private void btnBorrarRelacionTabCrear_Click(object sender, EventArgs e)
        {
            string errorMsj = "";

            if (dgvRelacionesCrear.SelectedRows.Count == 0)
                errorMsj += "Debe seleccionar un fila para poder ser borrada.\n";

            if (string.IsNullOrEmpty(errorMsj))
            {
                int id_estacionOrigen = Convert.ToInt32(dgvRelacionesCrear.SelectedRows[0].Cells["txtId_EstacionOrigen"].Value);
                int id_estacionDestino = Convert.ToInt32(dgvRelacionesCrear.SelectedRows[0].Cells["txtId_EstacionDestino"].Value);

                dgvRelacionesCrear.Rows.Remove(dgvRelacionesCrear.SelectedRows[0]);
                auxRelaciones.Remove(BuscarRelacion(id_estacionOrigen, id_estacionDestino));
            }
            else
                MessageBox.Show(errorMsj);
        }

        private Relaciones BuscarRelacion(int id_estacionOrigen,int id_estacionDentino)
        {
            return auxRelaciones.Where(x => x.Id_Estacion_Anterior == id_estacionOrigen && x.Id_Estacion_Siguiente == id_estacionDentino).First();
        }

        private void dgvRelacionesCrear_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id_estacionOrigen = Convert.ToInt32(dgvRelacionesCrear.SelectedRows[0].Cells["txtId_EstacionOrigen"].Value);
            int id_estacionDestino = Convert.ToInt32(dgvRelacionesCrear.SelectedRows[0].Cells["txtId_EstacionDestino"].Value);
            Relaciones r = BuscarRelacion(id_estacionOrigen, id_estacionDestino);

            lbxEstacionesOrigenCrear.SelectedItem = r.Estaciones;
            lbxEstacionesDestinoCrear.SelectedItem = r.Estaciones1;
            txtDistanciaRelacionCrear.Text = r.Distancia.ToString();
            txtVelocidadRelacionCrear.Text = r.VelocidadPromedio.ToString();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabCrearServicio)
                CrearNuevoServicio();
        }

        private void CrearNuevoServicio()
        {
            string errorMsj = "";
            Servicios nuevoServicio = new Servicios();

            if (!Util.EsAlfaNumerico(txtNombreServicio.Text))
                errorMsj += "Distancia entre estaciones: Incompleto/Incorrecto.\n";

            if (auxRelaciones.Count == 0)
                errorMsj += "El servicio no tiene estaciones relacionadas.\n";

            /*TODO: hacer un metodo dentro de la clase servicio para validar que todas las estaciones este conectadas en una sola linia*/

            if (clbxFormacionesCrear.CheckedItems.Count == 0)
                errorMsj += "El servicio no tiene formaciones asignadas.\n";

            if (string.IsNullOrEmpty(errorMsj))
            {
                nuevoServicio.Nombre = txtNombreServicio.Text;
                nuevoServicio.Relaciones = auxRelaciones;

                for (int pos = 0; pos <= clbxFormacionesCrear.CheckedItems.Count - 1; pos++)
                {
                    Formaciones f = (Formaciones)clbxFormacionesCrear.CheckedItems[pos];
                    Servicios_X_Formaciones sf = new Servicios_X_Formaciones();
                    sf.Id_Formacion = f.Id;
                    sf.Formaciones = f;
                    //sf.Servicios = nuevoServicio;
                    nuevoServicio.Servicios_X_Formaciones.Add(sf);
                }
                try
                {
                    context.Servicios.Add(nuevoServicio);
                    context.SaveChanges();
                    lbxServiciosModificar.Items.Add(nuevoServicio);
                    lbxServiciosEliminar.Items.Add(nuevoServicio);
                    LimpiarTabCrear();
                    MessageBox.Show("El servicio se ha creado exitosamente.\n");
                }
                catch (Exception exc)
                {
                    MessageBox.Show("No se guardo el servicio \n\n" + exc.ToString());
                }
            }
            else
                MessageBox.Show(errorMsj);
        }

        private void LimpiarTabCrear()
        {
            auxRelaciones = new List<Relaciones>();
            txtNombreServicio.Text = "";
            txtDistanciaRelacionCrear.Text = "";
            txtVelocidadRelacionCrear.Text = "";
            cbxEsParadaCrear.Checked = true;
            lbxEstacionesOrigenCrear.SelectedIndex = -1;
            lbxEstacionesDestinoCrear.SelectedIndex = -1;
            dgvRelacionesCrear.Rows.Clear();
            clbxFormacionesCrear.Items.Clear();
            foreach (Formaciones f in context.Formaciones)
                clbxFormacionesCrear.Items.Add(f);
        }

        private void btnBorrarServicio_Click(object sender, EventArgs e)
        {
            string errorMsj = "";
            Servicios s = (Servicios)lbxServiciosEliminar.SelectedItem;

            if (s == null)
                errorMsj += "No se ha seleccionado ningun servicio para ser borrado.\n";
            if (context.Trazas_X_Servicios.Where(x => x.Id_Servicio == s.Id).Count() != 0)
                errorMsj += "El servicio no puede ser borrado porque pertenece a una o mas trazas.\n";

            if (string.IsNullOrEmpty(errorMsj))
            {
                if (MessageBox.Show("El servicio se eliminará de manera permanente.¿Desea continuar?", "", MessageBoxButtons.OKCancel) == DialogResult.Cancel) return;

                try
                {
                    foreach (Servicios_X_Formaciones sf in context.Servicios_X_Formaciones.Where(x => x.Id_Servicio == s.Id))
                        context.Servicios_X_Formaciones.Remove(sf);

                    foreach (Relaciones r in context.Relaciones.Where(x => x.Id_Servicio == s.Id))
                        context.Relaciones.Remove(r);

                    context.Servicios.Remove(s);
                    context.SaveChanges();
                    lbxServiciosEliminar.Items.Remove(s);
                    lbxServiciosModificar.Items.Remove(s);
                    MessageBox.Show("El servicio se ha eliminado exitosamente.\n");
                }
                catch (Exception exc)
                {
                    MessageBox.Show("No se elimino el servicio \n\n" + exc.ToString());
                }
            }
            else
                MessageBox.Show(errorMsj);
        }
    }
}
