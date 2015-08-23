using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ffccSimulacion.ABMCoche;
using ffccSimulacion.ABMEstacion;
using ffccSimulacion.ABMFormacion;
using ffccSimulacion.ABMIncidente;
using ffccSimulacion.ABMServicio;
using ffccSimulacion.ABMTraza;
using ffccSimulacion.Simulador;

namespace ffccSimulacion
{
    public partial class Escritorio : Form
    {

        private int anchoBarraTitulo = 0;

        private int altoBarraTitulo = 60;

        public Escritorio()
        {
            InitializeComponent();
        }

        private void simulaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pnlEscritorio.Controls.Clear();

            frmRealizarSimulacion frmSimulacion = new frmRealizarSimulacion();

            this.pnlEscritorio.Controls.Add(frmSimulacion.pnlSimulador);

            frmSimulacion.pnlSimulador.Location = new Point(this.ClientSize.Width / 2 - frmSimulacion.pnlSimulador.Size.Width / 2 - anchoBarraTitulo, this.ClientSize.Height / 2 - frmSimulacion.pnlSimulador.Size.Height / 2 - altoBarraTitulo);

            this.pnlEscritorio.Dock = DockStyle.Fill;

            this.pnlEscritorio.Refresh();

            this.pnlEscritorio.Dock = DockStyle.Fill;
        }

        private void trazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pnlEscritorio.Controls.Clear();

            frmABMTraza frmTraza = new frmABMTraza();

            this.pnlEscritorio.Controls.Add(frmTraza.pnlTraza);

            frmTraza.pnlTraza.Location = new Point(this.ClientSize.Width / 2 - frmTraza.pnlTraza.Size.Width / 2 - anchoBarraTitulo, this.ClientSize.Height / 2 - frmTraza.pnlTraza.Size.Height / 2 - altoBarraTitulo);
        }

        private void servicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pnlEscritorio.Controls.Clear();

            frmABMServicio frmServicio = new frmABMServicio();

            this.pnlEscritorio.Controls.Add(frmServicio.pnlServicio);

            frmServicio.pnlServicio.Location = new Point(this.ClientSize.Width / 2 - frmServicio.pnlServicio.Size.Width / 2 - anchoBarraTitulo, this.ClientSize.Height / 2 - frmServicio.pnlServicio.Size.Height / 2 - altoBarraTitulo);
        }

        private void formaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pnlEscritorio.Controls.Clear();

            frmABMFormacion frmFormacion = new frmABMFormacion();

            this.pnlEscritorio.Controls.Add(frmFormacion.pnlFormacion);

            frmFormacion.pnlFormacion.Location = new Point(this.ClientSize.Width / 2 - frmFormacion.pnlFormacion.Size.Width / 2 - anchoBarraTitulo, this.ClientSize.Height / 2 - frmFormacion.pnlFormacion.Size.Height / 2 - altoBarraTitulo);
        }

        private void estaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pnlEscritorio.Controls.Clear();

            frmABMEstacion frmEstacion = new frmABMEstacion();

            this.pnlEscritorio.Controls.Add(frmEstacion.pnlEstacion);

            frmEstacion.pnlEstacion.Location = new Point(this.ClientSize.Width / 2 - frmEstacion.pnlEstacion.Size.Width / 2 - anchoBarraTitulo, this.ClientSize.Height / 2 - frmEstacion.pnlEstacion.Size.Height / 2 - altoBarraTitulo);
        }

        private void cocheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pnlEscritorio.Controls.Clear();

            frmABMCoche frmCoche = new frmABMCoche();

            this.pnlEscritorio.Controls.Add(frmCoche.pnlCoche);

            frmCoche.pnlCoche.Location = new Point(this.ClientSize.Width / 2 - frmCoche.pnlCoche.Size.Width / 2 - anchoBarraTitulo, this.ClientSize.Height / 2 - frmCoche.pnlCoche.Size.Height / 2 - altoBarraTitulo);
        }

        private void incidenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pnlEscritorio.Controls.Clear();

            frmABMIncidente frmIncidente = new frmABMIncidente();

            this.pnlEscritorio.Controls.Add(frmIncidente.pnlInicidente);

            frmIncidente.pnlInicidente.Location = new Point(this.ClientSize.Width / 2 - frmIncidente.pnlInicidente.Size.Width / 2 - anchoBarraTitulo, this.ClientSize.Height / 2 - frmIncidente.pnlInicidente.Size.Height / 2 - altoBarraTitulo);
        }

        private void redimencionarEscritorio(object sender, EventArgs e)
        {
      
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
