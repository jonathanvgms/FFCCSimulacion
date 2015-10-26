namespace ffccSimulacion.ABMTraza
{
    partial class frmABMTraza
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTraCreNombre = new System.Windows.Forms.TextBox();
            this.btnTraLimpiar = new System.Windows.Forms.Button();
            this.btnTraCancelar = new System.Windows.Forms.Button();
            this.btnTraAceptar = new System.Windows.Forms.Button();
            this.tclTraza = new System.Windows.Forms.TabControl();
            this.tabCrearTraza = new System.Windows.Forms.TabPage();
            this.txtTraCreBuscar = new System.Windows.Forms.TextBox();
            this.lstTraCreResultados = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.clbTraCreServicios = new System.Windows.Forms.CheckedListBox();
            this.tabModificarTraza = new System.Windows.Forms.TabPage();
            this.txtTraModBuscar = new System.Windows.Forms.TextBox();
            this.clbTraModServicios = new System.Windows.Forms.CheckedListBox();
            this.lstTraModTrazas = new System.Windows.Forms.ListBox();
            this.txtTraModNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabEliminarTraza = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.lstTraEliSimulaciones = new System.Windows.Forms.ListBox();
            this.txtTraEliBuscar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lstTraEliTrazas = new System.Windows.Forms.ListBox();
            this.btnTraElBorrarTraza = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlTraza = new System.Windows.Forms.Panel();
            this.tclTraza.SuspendLayout();
            this.tabCrearTraza.SuspendLayout();
            this.tabModificarTraza.SuspendLayout();
            this.tabEliminarTraza.SuspendLayout();
            this.pnlTraza.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Servicios";
            // 
            // txtTraCreNombre
            // 
            this.txtTraCreNombre.Location = new System.Drawing.Point(128, 15);
            this.txtTraCreNombre.MaxLength = 99;
            this.txtTraCreNombre.Name = "txtTraCreNombre";
            this.txtTraCreNombre.Size = new System.Drawing.Size(254, 21);
            this.txtTraCreNombre.TabIndex = 3;
            // 
            // btnTraLimpiar
            // 
            this.btnTraLimpiar.Location = new System.Drawing.Point(12, 549);
            this.btnTraLimpiar.Name = "btnTraLimpiar";
            this.btnTraLimpiar.Size = new System.Drawing.Size(75, 27);
            this.btnTraLimpiar.TabIndex = 5;
            this.btnTraLimpiar.Text = "Limpiar";
            this.btnTraLimpiar.UseVisualStyleBackColor = true;
            this.btnTraLimpiar.Click += new System.EventHandler(this.btnTraLimpiar_Click);
            // 
            // btnTraCancelar
            // 
            this.btnTraCancelar.Location = new System.Drawing.Point(755, 549);
            this.btnTraCancelar.Name = "btnTraCancelar";
            this.btnTraCancelar.Size = new System.Drawing.Size(75, 27);
            this.btnTraCancelar.TabIndex = 5;
            this.btnTraCancelar.Text = "Cancelar";
            this.btnTraCancelar.UseVisualStyleBackColor = true;
            this.btnTraCancelar.Click += new System.EventHandler(this.btnTraCancelar_Click);
            // 
            // btnTraAceptar
            // 
            this.btnTraAceptar.Location = new System.Drawing.Point(674, 549);
            this.btnTraAceptar.Name = "btnTraAceptar";
            this.btnTraAceptar.Size = new System.Drawing.Size(75, 27);
            this.btnTraAceptar.TabIndex = 5;
            this.btnTraAceptar.Text = "Aceptar";
            this.btnTraAceptar.UseVisualStyleBackColor = true;
            this.btnTraAceptar.Click += new System.EventHandler(this.btnTraAceptar_Click);
            // 
            // tclTraza
            // 
            this.tclTraza.Controls.Add(this.tabCrearTraza);
            this.tclTraza.Controls.Add(this.tabModificarTraza);
            this.tclTraza.Controls.Add(this.tabEliminarTraza);
            this.tclTraza.Location = new System.Drawing.Point(12, 14);
            this.tclTraza.Name = "tclTraza";
            this.tclTraza.SelectedIndex = 0;
            this.tclTraza.Size = new System.Drawing.Size(818, 533);
            this.tclTraza.TabIndex = 7;
            this.tclTraza.Selected += new System.Windows.Forms.TabControlEventHandler(this.seleccionarPestaña);
            // 
            // tabCrearTraza
            // 
            this.tabCrearTraza.Controls.Add(this.txtTraCreBuscar);
            this.tabCrearTraza.Controls.Add(this.lstTraCreResultados);
            this.tabCrearTraza.Controls.Add(this.label8);
            this.tabCrearTraza.Controls.Add(this.clbTraCreServicios);
            this.tabCrearTraza.Controls.Add(this.txtTraCreNombre);
            this.tabCrearTraza.Controls.Add(this.label1);
            this.tabCrearTraza.Controls.Add(this.label2);
            this.tabCrearTraza.Location = new System.Drawing.Point(4, 24);
            this.tabCrearTraza.Name = "tabCrearTraza";
            this.tabCrearTraza.Padding = new System.Windows.Forms.Padding(3);
            this.tabCrearTraza.Size = new System.Drawing.Size(810, 505);
            this.tabCrearTraza.TabIndex = 0;
            this.tabCrearTraza.Text = "Nueva Traza";
            this.tabCrearTraza.UseVisualStyleBackColor = true;
            // 
            // txtTraCreBuscar
            // 
            this.txtTraCreBuscar.Location = new System.Drawing.Point(517, 15);
            this.txtTraCreBuscar.MaxLength = 99;
            this.txtTraCreBuscar.Name = "txtTraCreBuscar";
            this.txtTraCreBuscar.Size = new System.Drawing.Size(277, 21);
            this.txtTraCreBuscar.TabIndex = 18;
            this.txtTraCreBuscar.TextChanged += new System.EventHandler(this.buscarTraza);
            // 
            // lstTraCreResultados
            // 
            this.lstTraCreResultados.DisplayMember = "Nombre";
            this.lstTraCreResultados.FormattingEnabled = true;
            this.lstTraCreResultados.ItemHeight = 15;
            this.lstTraCreResultados.Location = new System.Drawing.Point(421, 45);
            this.lstTraCreResultados.Name = "lstTraCreResultados";
            this.lstTraCreResultados.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstTraCreResultados.Size = new System.Drawing.Size(373, 439);
            this.lstTraCreResultados.Sorted = true;
            this.lstTraCreResultados.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(418, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Buscar Traza";
            // 
            // clbTraCreServicios
            // 
            this.clbTraCreServicios.FormattingEnabled = true;
            this.clbTraCreServicios.Location = new System.Drawing.Point(19, 61);
            this.clbTraCreServicios.Name = "clbTraCreServicios";
            this.clbTraCreServicios.Size = new System.Drawing.Size(372, 420);
            this.clbTraCreServicios.Sorted = true;
            this.clbTraCreServicios.TabIndex = 6;
            this.clbTraCreServicios.SelectedIndexChanged += new System.EventHandler(this.seleccionarServicios);
            // 
            // tabModificarTraza
            // 
            this.tabModificarTraza.Controls.Add(this.txtTraModBuscar);
            this.tabModificarTraza.Controls.Add(this.clbTraModServicios);
            this.tabModificarTraza.Controls.Add(this.lstTraModTrazas);
            this.tabModificarTraza.Controls.Add(this.txtTraModNombre);
            this.tabModificarTraza.Controls.Add(this.label4);
            this.tabModificarTraza.Controls.Add(this.label5);
            this.tabModificarTraza.Controls.Add(this.label3);
            this.tabModificarTraza.Location = new System.Drawing.Point(4, 24);
            this.tabModificarTraza.Name = "tabModificarTraza";
            this.tabModificarTraza.Padding = new System.Windows.Forms.Padding(3);
            this.tabModificarTraza.Size = new System.Drawing.Size(810, 505);
            this.tabModificarTraza.TabIndex = 1;
            this.tabModificarTraza.Text = "Modificar";
            this.tabModificarTraza.UseVisualStyleBackColor = true;
            // 
            // txtTraModBuscar
            // 
            this.txtTraModBuscar.Location = new System.Drawing.Point(105, 24);
            this.txtTraModBuscar.MaxLength = 99;
            this.txtTraModBuscar.Name = "txtTraModBuscar";
            this.txtTraModBuscar.Size = new System.Drawing.Size(277, 21);
            this.txtTraModBuscar.TabIndex = 15;
            this.txtTraModBuscar.TextChanged += new System.EventHandler(this.buscarTraza);
            // 
            // clbTraModServicios
            // 
            this.clbTraModServicios.FormattingEnabled = true;
            this.clbTraModServicios.Location = new System.Drawing.Point(412, 73);
            this.clbTraModServicios.Name = "clbTraModServicios";
            this.clbTraModServicios.Size = new System.Drawing.Size(372, 404);
            this.clbTraModServicios.Sorted = true;
            this.clbTraModServicios.TabIndex = 14;
            this.clbTraModServicios.SelectedIndexChanged += new System.EventHandler(this.seleccionarServicios);
            // 
            // lstTraModTrazas
            // 
            this.lstTraModTrazas.DisplayMember = "Nombre";
            this.lstTraModTrazas.FormattingEnabled = true;
            this.lstTraModTrazas.ItemHeight = 15;
            this.lstTraModTrazas.Location = new System.Drawing.Point(9, 54);
            this.lstTraModTrazas.Name = "lstTraModTrazas";
            this.lstTraModTrazas.Size = new System.Drawing.Size(373, 424);
            this.lstTraModTrazas.Sorted = true;
            this.lstTraModTrazas.TabIndex = 12;
            this.lstTraModTrazas.SelectedIndexChanged += new System.EventHandler(this.seleccionarTraza);
            // 
            // txtTraModNombre
            // 
            this.txtTraModNombre.Location = new System.Drawing.Point(529, 21);
            this.txtTraModNombre.MaxLength = 99;
            this.txtTraModNombre.Name = "txtTraModNombre";
            this.txtTraModNombre.Size = new System.Drawing.Size(255, 21);
            this.txtTraModNombre.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(409, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(409, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Servicios";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Buscar Traza";
            // 
            // tabEliminarTraza
            // 
            this.tabEliminarTraza.Controls.Add(this.label9);
            this.tabEliminarTraza.Controls.Add(this.lstTraEliSimulaciones);
            this.tabEliminarTraza.Controls.Add(this.txtTraEliBuscar);
            this.tabEliminarTraza.Controls.Add(this.label7);
            this.tabEliminarTraza.Controls.Add(this.lstTraEliTrazas);
            this.tabEliminarTraza.Controls.Add(this.btnTraElBorrarTraza);
            this.tabEliminarTraza.Controls.Add(this.label6);
            this.tabEliminarTraza.Location = new System.Drawing.Point(4, 24);
            this.tabEliminarTraza.Name = "tabEliminarTraza";
            this.tabEliminarTraza.Padding = new System.Windows.Forms.Padding(3);
            this.tabEliminarTraza.Size = new System.Drawing.Size(810, 505);
            this.tabEliminarTraza.TabIndex = 2;
            this.tabEliminarTraza.Text = "Eliminar";
            this.tabEliminarTraza.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(500, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "Simulaciones Asociadas";
            // 
            // lstTraEliSimulaciones
            // 
            this.lstTraEliSimulaciones.DisplayMember = "Nombre";
            this.lstTraEliSimulaciones.Enabled = false;
            this.lstTraEliSimulaciones.FormattingEnabled = true;
            this.lstTraEliSimulaciones.ItemHeight = 15;
            this.lstTraEliSimulaciones.Location = new System.Drawing.Point(503, 53);
            this.lstTraEliSimulaciones.Name = "lstTraEliSimulaciones";
            this.lstTraEliSimulaciones.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstTraEliSimulaciones.Size = new System.Drawing.Size(301, 424);
            this.lstTraEliSimulaciones.Sorted = true;
            this.lstTraEliSimulaciones.TabIndex = 18;
            // 
            // txtTraEliBuscar
            // 
            this.txtTraEliBuscar.Location = new System.Drawing.Point(105, 26);
            this.txtTraEliBuscar.MaxLength = 99;
            this.txtTraEliBuscar.Name = "txtTraEliBuscar";
            this.txtTraEliBuscar.Size = new System.Drawing.Size(277, 21);
            this.txtTraEliBuscar.TabIndex = 17;
            this.txtTraEliBuscar.TextChanged += new System.EventHandler(this.buscarTraza);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Buscar Traza";
            // 
            // lstTraEliTrazas
            // 
            this.lstTraEliTrazas.DisplayMember = "Nombre";
            this.lstTraEliTrazas.FormattingEnabled = true;
            this.lstTraEliTrazas.ItemHeight = 15;
            this.lstTraEliTrazas.Location = new System.Drawing.Point(9, 53);
            this.lstTraEliTrazas.Name = "lstTraEliTrazas";
            this.lstTraEliTrazas.Size = new System.Drawing.Size(373, 424);
            this.lstTraEliTrazas.Sorted = true;
            this.lstTraEliTrazas.TabIndex = 15;
            this.lstTraEliTrazas.SelectedIndexChanged += new System.EventHandler(this.simulacionesAsociadas);
            // 
            // btnTraElBorrarTraza
            // 
            this.btnTraElBorrarTraza.Location = new System.Drawing.Point(388, 53);
            this.btnTraElBorrarTraza.Name = "btnTraElBorrarTraza";
            this.btnTraElBorrarTraza.Size = new System.Drawing.Size(100, 27);
            this.btnTraElBorrarTraza.TabIndex = 14;
            this.btnTraElBorrarTraza.Text = "Borrar Traza";
            this.btnTraElBorrarTraza.UseVisualStyleBackColor = true;
            this.btnTraElBorrarTraza.Click += new System.EventHandler(this.btnTraElBorrarTraza_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(200, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Trazas Existentes";
            // 
            // pnlTraza
            // 
            this.pnlTraza.Controls.Add(this.tclTraza);
            this.pnlTraza.Controls.Add(this.btnTraLimpiar);
            this.pnlTraza.Controls.Add(this.btnTraCancelar);
            this.pnlTraza.Controls.Add(this.btnTraAceptar);
            this.pnlTraza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlTraza.Location = new System.Drawing.Point(12, 12);
            this.pnlTraza.Name = "pnlTraza";
            this.pnlTraza.Size = new System.Drawing.Size(840, 588);
            this.pnlTraza.TabIndex = 7;
            // 
            // frmABMTraza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 609);
            this.Controls.Add(this.pnlTraza);
            this.Name = "frmABMTraza";
            this.Text = "Traza";
            this.tclTraza.ResumeLayout(false);
            this.tabCrearTraza.ResumeLayout(false);
            this.tabCrearTraza.PerformLayout();
            this.tabModificarTraza.ResumeLayout(false);
            this.tabModificarTraza.PerformLayout();
            this.tabEliminarTraza.ResumeLayout(false);
            this.tabEliminarTraza.PerformLayout();
            this.pnlTraza.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTraCreNombre;
        private System.Windows.Forms.Button btnTraLimpiar;
        private System.Windows.Forms.Button btnTraCancelar;
        private System.Windows.Forms.Button btnTraAceptar;
        private System.Windows.Forms.TabControl tclTraza;
        private System.Windows.Forms.TabPage tabCrearTraza;
        private System.Windows.Forms.TabPage tabModificarTraza;
        private System.Windows.Forms.TextBox txtTraModNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstTraModTrazas;
        private System.Windows.Forms.TabPage tabEliminarTraza;
        private System.Windows.Forms.ListBox lstTraEliTrazas;
        private System.Windows.Forms.Button btnTraElBorrarTraza;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckedListBox clbTraCreServicios;
        private System.Windows.Forms.CheckedListBox clbTraModServicios;
        public System.Windows.Forms.Panel pnlTraza;
        private System.Windows.Forms.TextBox txtTraCreBuscar;
        private System.Windows.Forms.ListBox lstTraCreResultados;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTraModBuscar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lstTraEliSimulaciones;
        private System.Windows.Forms.TextBox txtTraEliBuscar;
        private System.Windows.Forms.Label label7;
    }
}