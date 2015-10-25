namespace ffccSimulacion
{
    partial class Escritorio
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Escritorio));
            this.menuEscritorio = new System.Windows.Forms.MenuStrip();
            this.simulaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cocheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incidenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlEscritorio = new System.Windows.Forms.Panel();
            this.menuEscritorio.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuEscritorio
            // 
            this.menuEscritorio.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.menuEscritorio, "menuEscritorio");
            this.menuEscritorio.ImageScalingSize = new System.Drawing.Size(75, 75);
            this.menuEscritorio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simulaciónToolStripMenuItem,
            this.trazaToolStripMenuItem,
            this.servicioToolStripMenuItem,
            this.formaciónToolStripMenuItem,
            this.cocheToolStripMenuItem,
            this.estaciónToolStripMenuItem,
            this.incidenteToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuEscritorio.Name = "menuEscritorio";
            this.menuEscritorio.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            // 
            // simulaciónToolStripMenuItem
            // 
            resources.ApplyResources(this.simulaciónToolStripMenuItem, "simulaciónToolStripMenuItem");
            this.simulaciónToolStripMenuItem.Name = "simulaciónToolStripMenuItem";
            this.simulaciónToolStripMenuItem.Click += new System.EventHandler(this.simulaciónToolStripMenuItem_Click);
            // 
            // trazaToolStripMenuItem
            // 
            resources.ApplyResources(this.trazaToolStripMenuItem, "trazaToolStripMenuItem");
            this.trazaToolStripMenuItem.Name = "trazaToolStripMenuItem";
            this.trazaToolStripMenuItem.Click += new System.EventHandler(this.trazaToolStripMenuItem_Click);
            // 
            // servicioToolStripMenuItem
            // 
            resources.ApplyResources(this.servicioToolStripMenuItem, "servicioToolStripMenuItem");
            this.servicioToolStripMenuItem.Name = "servicioToolStripMenuItem";
            this.servicioToolStripMenuItem.Click += new System.EventHandler(this.servicioToolStripMenuItem_Click);
            // 
            // formaciónToolStripMenuItem
            // 
            resources.ApplyResources(this.formaciónToolStripMenuItem, "formaciónToolStripMenuItem");
            this.formaciónToolStripMenuItem.Name = "formaciónToolStripMenuItem";
            this.formaciónToolStripMenuItem.Click += new System.EventHandler(this.formaciónToolStripMenuItem_Click);
            // 
            // cocheToolStripMenuItem
            // 
            resources.ApplyResources(this.cocheToolStripMenuItem, "cocheToolStripMenuItem");
            this.cocheToolStripMenuItem.Name = "cocheToolStripMenuItem";
            this.cocheToolStripMenuItem.Click += new System.EventHandler(this.cocheToolStripMenuItem_Click);
            // 
            // estaciónToolStripMenuItem
            // 
            this.estaciónToolStripMenuItem.CheckOnClick = true;
            this.estaciónToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.estaciónToolStripMenuItem, "estaciónToolStripMenuItem");
            this.estaciónToolStripMenuItem.Name = "estaciónToolStripMenuItem";
            this.estaciónToolStripMenuItem.Click += new System.EventHandler(this.estaciónToolStripMenuItem_Click);
            // 
            // incidenteToolStripMenuItem
            // 
            resources.ApplyResources(this.incidenteToolStripMenuItem, "incidenteToolStripMenuItem");
            this.incidenteToolStripMenuItem.Name = "incidenteToolStripMenuItem";
            this.incidenteToolStripMenuItem.Click += new System.EventHandler(this.incidenteToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            resources.ApplyResources(this.ayudaToolStripMenuItem, "ayudaToolStripMenuItem");
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.salirToolStripMenuItem, "salirToolStripMenuItem");
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // pnlEscritorio
            // 
            resources.ApplyResources(this.pnlEscritorio, "pnlEscritorio");
            this.pnlEscritorio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlEscritorio.Name = "pnlEscritorio";
            // 
            // Escritorio
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlEscritorio);
            this.Controls.Add(this.menuEscritorio);
            this.MainMenuStrip = this.menuEscritorio;
            this.Name = "Escritorio";
            this.menuEscritorio.ResumeLayout(false);
            this.menuEscritorio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuEscritorio;
        private System.Windows.Forms.ToolStripMenuItem simulaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trazaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cocheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incidenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estaciónToolStripMenuItem;
        public System.Windows.Forms.Panel pnlEscritorio;



    }
}

