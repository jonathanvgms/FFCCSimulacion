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
            cbxEsParadaMod.Checked = true;

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

            if (estacionOrigen == null || estacionDestino==null)
            {
                MessageBox.Show("La estación de origen y/o la estación de destino no han sido seleccionadas.\n");
                return;
            }

            if (!Util.EsNumerico(txtDistanciaRelacionCrear.Text))
                errorMsj += "Distancia entre estaciones: Incompleto/Incorrecto.\n";
            if(!Util.EsNumerico(txtVelocidadRelacionCrear.Text))
                errorMsj += "Velocidad: Incompleto/Incorrecto.\n";
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
                nuevaRelacion.Est_Sig_Es_Parada = 1;
               
                auxRelaciones.Add(nuevaRelacion);
                dgvRelacionesCrear.Rows.Add(new string[] { estacionOrigen.Nombre, estacionDestino.Nombre, estacionOrigen.Id.ToString(), estacionDestino.Id.ToString() });
                txtDistanciaRelacionCrear.Text = "";
                txtVelocidadRelacionCrear.Text = "";
                //lbxEstacionesOrigenCrear.SelectedIndex = -1;
                lbxEstacionesDestinoCrear.SelectedIndex = -1;
                lbxEstacionesOrigenCrear.SelectedItem = estacionDestino;
            }
            else
                MessageBox.Show(errorMsj);
        }

        private void btnBorrarRelacionTabCrear_Click(object sender, EventArgs e)
        {
            string errorMsj = "";

            if (dgvRelacionesCrear.SelectedRows.Count != 1)
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
            if (auxRelaciones.Count == 0)
                return null;
            Relaciones r = auxRelaciones.Where(x => x.Id_Estacion_Anterior == id_estacionOrigen && x.Id_Estacion_Siguiente == id_estacionDentino).FirstOrDefault();

            return r;
        }

        private Relaciones BuscarRelacion2(int id_estacionOrigen, int id_estacionDentino, Servicios s)
        {
            Relaciones r = s.Relaciones.Where(x => x.Id_Estacion_Anterior == id_estacionOrigen && x.Id_Estacion_Siguiente == id_estacionDentino).FirstOrDefault();

            return r;
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
            txtDistanciaRelacionCrear.Enabled = false;
            txtVelocidadRelacionCrear.Enabled = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabCrearServicio)
                CrearNuevoServicio();

            if (tabControl1.SelectedTab == tabModificarServicio)
                GuardarCambiosServicio();
        }

        private void CrearNuevoServicio()
        {
            string errorMsj = "";
            Servicios nuevoServicio = new Servicios();

            if (!Util.EsAlfaNumerico(txtNombreServicio.Text))
                errorMsj += "Nombre de servicio: Incompleto/Incorrecto.\n";
            else if (context.Servicios.Where(x => x.Nombre == txtNombreServicio.Text).Count() > 0)
                errorMsj += "Nombre de servicio: ya existe un servicio con el mismo nombre.\n";

            if (auxRelaciones.Count == 0)
                errorMsj += "El servicio no tiene estaciones relacionadas.\n";

            if (!nuevoServicio.ServicioEsValido(auxRelaciones))
                errorMsj += "Las relaciones del servicio tienen errores.\n";

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
            else if (context.Trazas_X_Servicios.Where(x => x.Id_Servicio == s.Id).Count() != 0)
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabCrearServicio)
                LimpiarTabCrear();

            if (tabControl1.SelectedTab == tabModificarServicio)
                LimpiarTabModificar();
        }

        private void seleccionarPestaña(object sender, TabControlEventArgs e)
        {
            if (tabControl1.SelectedTab == tabCrearServicio)
            {
                btnAceptar.Enabled = true;
                btnLimpiar.Enabled = true;
            }
            if (tabControl1.SelectedTab == tabModificarServicio)
            {
                btnAceptar.Enabled = true;
                btnLimpiar.Enabled = true;
            }
            if (tabControl1.SelectedTab == tabEliminarServicio)
            {
                btnAceptar.Enabled = false;
                btnLimpiar.Enabled = false;
            }
        }

        private void LimpiarTabModificar()
        {
            cbxEsParadaMod.Checked = true;
            lbxEstacionesOrigenMod.SelectedIndex = -1;
            lbxEstacionesDestinoMod.SelectedIndex = -1;
            txtNombreServicioMod.Text = "";
            dgvRelacionesMod.Rows.Clear();
            for (int i = 0; i < clbxFormacionesMod.Items.Count; i++)
                clbxFormacionesMod.SetItemChecked(i, false);
        }

        private void lbxServiciosModificar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxServiciosModificar.SelectedItem == null)
                return;

            LimpiarTabModificar();

            Servicios servicioSeleccionado = (Servicios)lbxServiciosModificar.SelectedItem;

            foreach (Relaciones r in servicioSeleccionado.Relaciones)
                dgvRelacionesMod.Rows.Add(r.Estaciones.Nombre, r.Estaciones1.Nombre, r.Estaciones.Id, r.Estaciones1.Id);

            //clbxFormacionesMod.CheckedItems = servicioSeleccionado.Servicios_X_Formaciones.Select(x => x.Formaciones);
            foreach (Formaciones f in servicioSeleccionado.Servicios_X_Formaciones.Select(x => x.Formaciones))
                clbxFormacionesMod.SetItemChecked(clbxFormacionesMod.Items.IndexOf(f), true);

            txtNombreServicioMod.Text = servicioSeleccionado.Nombre;
        }

        private void btnBorrarRelacionMod_Click(object sender, EventArgs e)
        {
            Servicios servicioSeleccionado = (Servicios)lbxServiciosModificar.SelectedItem;
            string errorMsj = "";

            if (servicioSeleccionado == null)
                errorMsj += "No se ha seleccionado ningún servicio para ser modificado.\n";

            if (dgvRelacionesMod.SelectedRows.Count != 1)
                errorMsj += "Debe seleccionar un fila para poder ser borrada.\n";

            if (string.IsNullOrEmpty(errorMsj))
            {
                int id_estacionOrigen = Convert.ToInt32(dgvRelacionesMod.SelectedRows[0].Cells["Id_EstacionOrigen"].Value);
                int id_estacionDestino = Convert.ToInt32(dgvRelacionesMod.SelectedRows[0].Cells["Id_EstacionDestino"].Value);

                Relaciones r = servicioSeleccionado.Relaciones.Where(x => x.Estaciones.Id == id_estacionOrigen && x.Estaciones1.Id == id_estacionDestino).FirstOrDefault();
                if (r != null)
                {
                    servicioSeleccionado.Relaciones.Remove(r);

                    /*Esto lo hago con try catch xq si la relacion fue agregada durante la modificacion del servicio la misma
                     todavia no guardada en la base y por lo tanto tampoco pertenece al contexto. Recien va a aparecer en el contexto cuando se guarden los cambios en la bd*/
                    try
                    { context.Relaciones.Remove(r); }
                    catch
                    { }
                }

                dgvRelacionesMod.Rows.Remove(dgvRelacionesMod.SelectedRows[0]);
            }
            else
                MessageBox.Show(errorMsj);
        }

        private void btnAgregarRelacionMod_Click(object sender, EventArgs e)
        {
            string errorMsj = "";
            Servicios servicioSeleccionado = (Servicios)lbxServiciosModificar.SelectedItem;
            Estaciones estacionOrigen = (Estaciones)lbxEstacionesOrigenMod.SelectedItem;
            Estaciones estacionDestino = (Estaciones)lbxEstacionesDestinoMod.SelectedItem;

            if (estacionOrigen == null || estacionDestino==null)
            {
                MessageBox.Show("La estación de origen y/o la estación de destino no han sido seleccionadas.\n");
                return;
            }

            if (servicioSeleccionado == null)
            {
                MessageBox.Show("No se ha seleccionado ningún servicio para ser modificado.\n");
                return;
            }

            if (servicioSeleccionado == null)
                errorMsj += "No se ha seleccionado ningún servicio para ser modificado.\n";
            if (!Util.EsNumerico(txtDistanciaRelacionMod.Text))
                errorMsj += "Distancia entre estaciones: Incompleto/Incorrecto.\n";
            if (!Util.EsNumerico(txtVelocidadRelacionMod.Text))
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
                nuevaRelacion.Est_Sig_Es_Parada = 1;
                nuevaRelacion.Distancia = Convert.ToInt32(txtDistanciaRelacionMod.Text);
                nuevaRelacion.VelocidadPromedio = Convert.ToInt32(txtVelocidadRelacionMod.Text);
                nuevaRelacion.Id_Estacion_Anterior = estacionOrigen.Id;
                nuevaRelacion.Id_Estacion_Siguiente = estacionDestino.Id;
                nuevaRelacion.Estaciones = estacionOrigen;
                nuevaRelacion.Estaciones1 = estacionDestino;

                servicioSeleccionado.Relaciones.Add(nuevaRelacion);
                dgvRelacionesMod.Rows.Add(estacionOrigen.Nombre, estacionDestino.Nombre, estacionOrigen.Id, estacionDestino.Id);
                txtDistanciaRelacionMod.Text = "";
                txtVelocidadRelacionMod.Text = "";
                lbxEstacionesDestinoMod.SelectedIndex = -1;
                lbxEstacionesOrigenMod.SelectedItem = estacionDestino;
            }
            else
                MessageBox.Show(errorMsj);
        }

        private void GuardarCambiosServicio()
        {
            string errorMsj = "";
            Servicios servicioSeleccionado = (Servicios)lbxServiciosModificar.SelectedItem;

            if (servicioSeleccionado == null)
            {
                MessageBox.Show("Se ha deseleccionado la formación que iba a ser modificada.\n");
                return;
            }
                

            List<string> nombreDeServicios = context.Servicios.Where(x => x.Id != servicioSeleccionado.Id).Select(x => x.Nombre).ToList<string>();

            if (!Util.EsAlfaNumerico(txtNombreServicioMod.Text))
                errorMsj += "Nombre de servicio: Incompleto/Incorrecto.\n";
            else if (nombreDeServicios.Contains(txtNombreServicioMod.Text))
                errorMsj += "Nombre de servicio: ya existe un servicio con el mismo nombre.\n";

            if (servicioSeleccionado.Relaciones.Count == 0)
                errorMsj += "El servicio no tiene estaciones relacionadas.\n";

            if (!servicioSeleccionado.ServicioEsValido(servicioSeleccionado.Relaciones.ToList<Relaciones>()))
                errorMsj += "Las relaciones del servicio tienen errores.\n";

            if (clbxFormacionesMod.CheckedItems.Count == 0)
                errorMsj += "El servicio no tiene formaciones asignadas.\n";

            if (string.IsNullOrEmpty(errorMsj))
            {
                try
                {
                    List<Servicios_X_Formaciones> auxFormacionesServicio = servicioSeleccionado.Servicios_X_Formaciones.ToList<Servicios_X_Formaciones>();
                    servicioSeleccionado.Nombre = txtNombreServicioMod.Text;

                    /*Se quitan aquellas formaciones que ya no pertenezcan al servicio*/
                    foreach (Servicios_X_Formaciones sf in auxFormacionesServicio)
                    {
                        if (!clbxFormacionesMod.CheckedItems.Contains(sf.Formaciones))
                        {
                            servicioSeleccionado.Servicios_X_Formaciones.Remove(sf);
                            context.Servicios_X_Formaciones.Remove(sf);
                        }
                    }

                    /*Se agregan las nuevas formaciones al servicio*/
                    foreach (Formaciones f in clbxFormacionesMod.CheckedItems)
                    {
                        if (servicioSeleccionado.Servicios_X_Formaciones.Where(x => x.Id_Formacion == f.Id).Count() == 0)
                        {
                            Servicios_X_Formaciones servform = new Servicios_X_Formaciones();
                            servform.Id_Servicio = servicioSeleccionado.Id;
                            servform.Id_Formacion = f.Id;
                            servform.Formaciones = f;

                            servicioSeleccionado.Servicios_X_Formaciones.Add(servform);
                        }
                    }

                    /*Las modificaciones a la lista de relaciones se van guardando a medida que se agregan o sacan formaciones*/

                    context.SaveChanges();

                    lbxServiciosModificar.Items.Clear();
                    lbxServiciosEliminar.Items.Clear();
                    foreach (Servicios s in context.Servicios)
                    {
                        lbxServiciosModificar.Items.Add(s);
                        lbxServiciosEliminar.Items.Add(s);
                    }

                    MessageBox.Show("Los cambios han sido guardados exitosamente.\n");
                }
                catch (Exception exc)
                {
                    MessageBox.Show("No se guardo el servicio \n\n" + exc.ToString());
                }
            }
            else
                MessageBox.Show(errorMsj);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.pnlServicio.Controls.Clear();
        }

        private void dgvRelacionesMod_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Servicios servicioSeleccionado = (Servicios)lbxServiciosModificar.SelectedItem;
            int id_estacionOrigen = Convert.ToInt32(dgvRelacionesMod.SelectedRows[0].Cells["Id_EstacionOrigen"].Value);
            int id_estacionDestino = Convert.ToInt32(dgvRelacionesMod.SelectedRows[0].Cells["Id_EstacionDestino"].Value);
            
            if(servicioSeleccionado==null)
            {
                MessageBox.Show("Se ha desseleccionado el servicio ha modificar.\n");
                return;
            }
            
            Relaciones r = BuscarRelacion2(id_estacionOrigen, id_estacionDestino, servicioSeleccionado);

            if (r == null) return;
            

            lbxEstacionesOrigenMod.SelectedItem = r.Estaciones;
            lbxEstacionesDestinoMod.SelectedItem = r.Estaciones1;
            txtDistanciaRelacionMod.Text = r.Distancia.ToString();
            txtVelocidadRelacionMod.Text = r.VelocidadPromedio.ToString();
            txtDistanciaRelacionMod.Enabled = false;
            txtVelocidadRelacionMod.Enabled = false;
        }

        private void lbxServiciosEliminar_SelectedIndexChanged(object sender, EventArgs e)
        {
            Servicios s = (Servicios)lbxServiciosEliminar.SelectedItem;

            if (s == null) return;

            lbxTrazasAsociadasEliminar.Items.Clear();
            List<Trazas_X_Servicios> trazaServiciosAsociados = context.Trazas_X_Servicios.Where(x => x.Id_Servicio == s.Id).ToList<Trazas_X_Servicios>();

            foreach (Trazas_X_Servicios ts in trazaServiciosAsociados)
                lbxTrazasAsociadasEliminar.Items.Add(ts.Trazas);
        }

        private void dgvRelacionesCrear_Leave(object sender, EventArgs e)
        {
            txtDistanciaRelacionCrear.Enabled = true;
            txtVelocidadRelacionCrear.Enabled = true;
            txtDistanciaRelacionCrear.Text = "";
            txtVelocidadRelacionCrear.Text = "";
            if (dgvRelacionesCrear.Rows.Count != 0)
                dgvRelacionesCrear.CurrentCell = dgvRelacionesCrear[0, 0];
        }

        private void dgvRelacionesMod_Leave(object sender, EventArgs e)
        {
            txtDistanciaRelacionMod.Enabled = true;
            txtVelocidadRelacionMod.Enabled = true;
            txtDistanciaRelacionMod.Text = "";
            txtVelocidadRelacionMod.Text = "";
            if (dgvRelacionesMod.Rows.Count != 0)
                dgvRelacionesMod.CurrentCell = dgvRelacionesMod[0, 0];
        }

        private void seleccionarFormaciones(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabCrearServicio)
            {
                checkFormaciones(clbxFormacionesCrear);
            }
            else
            {
                checkFormaciones(clbxFormacionesMod);
            }
        }

        private void checkFormaciones(CheckedListBox clb)
        {
            if (clb.GetItemChecked(clb.SelectedIndex))
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
