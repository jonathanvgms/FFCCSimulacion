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
            this.clbTraCreServicios = new System.Windows.Forms.CheckedListBox();
            this.tabModificarTraza = new System.Windows.Forms.TabPage();
            this.clbTraModServicios = new System.Windows.Forms.CheckedListBox();
            this.lstTraModTrazas = new System.Windows.Forms.ListBox();
            this.txtTraModNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabEliminarTraza = new System.Windows.Forms.TabPage();
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
            this.label1.Location = new System.Drawing.Point(199, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Traza";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Servicios Disponibles";
            // 
            // txtTraCreNombre
            // 
            this.txtTraCreNombre.Location = new System.Drawing.Point(294, 17);
            this.txtTraCreNombre.Name = "txtTraCreNombre";
            this.txtTraCreNombre.Size = new System.Drawing.Size(280, 20);
            this.txtTraCreNombre.TabIndex = 3;
            // 
            // btnTraLimpiar
            // 
            this.btnTraLimpiar.Location = new System.Drawing.Point(12, 549);
            this.btnTraLimpiar.Name = "btnTraLimpiar";
            this.btnTraLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnTraLimpiar.TabIndex = 5;
            this.btnTraLimpiar.Text = "Limpiar";
            this.btnTraLimpiar.UseVisualStyleBackColor = true;
            this.btnTraLimpiar.Click += new System.EventHandler(this.btnTraLimpiar_Click);
            // 
            // btnTraCancelar
            // 
            this.btnTraCancelar.Location = new System.Drawing.Point(755, 553);
            this.btnTraCancelar.Name = "btnTraCancelar";
            this.btnTraCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnTraCancelar.TabIndex = 5;
            this.btnTraCancelar.Text = "Cancelar";
            this.btnTraCancelar.UseVisualStyleBackColor = true;
            this.btnTraCancelar.Click += new System.EventHandler(this.btnTraCancelar_Click);
            // 
            // btnTraAceptar
            // 
            this.btnTraAceptar.Location = new System.Drawing.Point(674, 553);
            this.btnTraAceptar.Name = "btnTraAceptar";
            this.btnTraAceptar.Size = new System.Drawing.Size(75, 23);
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
            // 
            // tabCrearTraza
            // 
            this.tabCrearTraza.Controls.Add(this.clbTraCreServicios);
            this.tabCrearTraza.Controls.Add(this.txtTraCreNombre);
            this.tabCrearTraza.Controls.Add(this.label1);
            this.tabCrearTraza.Controls.Add(this.label2);
            this.tabCrearTraza.Location = new System.Drawing.Point(4, 22);
            this.tabCrearTraza.Name = "tabCrearTraza";
            this.tabCrearTraza.Padding = new System.Windows.Forms.Padding(3);
            this.tabCrearTraza.Size = new System.Drawing.Size(810, 507);
            this.tabCrearTraza.TabIndex = 0;
            this.tabCrearTraza.Text = "Crear";
            this.tabCrearTraza.UseVisualStyleBackColor = true;
            // 
            // clbTraCreServicios
            // 
            this.clbTraCreServicios.FormattingEnabled = true;
            this.clbTraCreServicios.Location = new System.Drawing.Point(202, 72);
            this.clbTraCreServicios.Name = "clbTraCreServicios";
            this.clbTraCreServicios.Size = new System.Drawing.Size(372, 424);
            this.clbTraCreServicios.Sorted = true;
            this.clbTraCreServicios.TabIndex = 6;
            // 
            // tabModificarTraza
            // 
            this.tabModificarTraza.Controls.Add(this.clbTraModServicios);
            this.tabModificarTraza.Controls.Add(this.lstTraModTrazas);
            this.tabModificarTraza.Controls.Add(this.txtTraModNombre);
            this.tabModificarTraza.Controls.Add(this.label4);
            this.tabModificarTraza.Controls.Add(this.label5);
            this.tabModificarTraza.Controls.Add(this.label3);
            this.tabModificarTraza.Location = new System.Drawing.Point(4, 22);
            this.tabModificarTraza.Name = "tabModificarTraza";
            this.tabModificarTraza.Padding = new System.Windows.Forms.Padding(3);
            this.tabModificarTraza.Size = new System.Drawing.Size(810, 507);
            this.tabModificarTraza.TabIndex = 1;
            this.tabModificarTraza.Text = "Modificar";
            this.tabModificarTraza.UseVisualStyleBackColor = true;
            // 
            // clbTraModServicios
            // 
            this.clbTraModServicios.FormattingEnabled = true;
            this.clbTraModServicios.Location = new System.Drawing.Point(412, 81);
            this.clbTraModServicios.Name = "clbTraModServicios";
            this.clbTraModServicios.Size = new System.Drawing.Size(372, 409);
            this.clbTraModServicios.Sorted = true;
            this.clbTraModServicios.TabIndex = 14;
            // 
            // lstTraModTrazas
            // 
            this.lstTraModTrazas.DisplayMember = "Nombre";
            this.lstTraModTrazas.FormattingEnabled = true;
            this.lstTraModTrazas.Location = new System.Drawing.Point(9, 32);
            this.lstTraModTrazas.Name = "lstTraModTrazas";
            this.lstTraModTrazas.Size = new System.Drawing.Size(373, 459);
            this.lstTraModTrazas.Sorted = true;
            this.lstTraModTrazas.TabIndex = 12;
            this.lstTraModTrazas.SelectedIndexChanged += new System.EventHandler(this.seleccionarTraza);
            // 
            // txtTraModNombre
            // 
            this.txtTraModNombre.Location = new System.Drawing.Point(504, 29);
            this.txtTraModNombre.Name = "txtTraModNombre";
            this.txtTraModNombre.Size = new System.Drawing.Size(280, 20);
            this.txtTraModNombre.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(409, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nombre de Traza";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(409, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Servicios Disponibles";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Trazas Actuales";
            // 
            // tabEliminarTraza
            // 
            this.tabEliminarTraza.Controls.Add(this.lstTraEliTrazas);
            this.tabEliminarTraza.Controls.Add(this.btnTraElBorrarTraza);
            this.tabEliminarTraza.Controls.Add(this.label6);
            this.tabEliminarTraza.Location = new System.Drawing.Point(4, 22);
            this.tabEliminarTraza.Name = "tabEliminarTraza";
            this.tabEliminarTraza.Padding = new System.Windows.Forms.Padding(3);
            this.tabEliminarTraza.Size = new System.Drawing.Size(810, 507);
            this.tabEliminarTraza.TabIndex = 2;
            this.tabEliminarTraza.Text = "Eliminar";
            this.tabEliminarTraza.UseVisualStyleBackColor = true;
            // 
            // lstTraEliTrazas
            // 
            this.lstTraEliTrazas.DisplayMember = "Nombre";
            this.lstTraEliTrazas.FormattingEnabled = true;
            this.lstTraEliTrazas.Location = new System.Drawing.Point(203, 41);
            this.lstTraEliTrazas.Name = "lstTraEliTrazas";
            this.lstTraEliTrazas.Size = new System.Drawing.Size(373, 446);
            this.lstTraEliTrazas.Sorted = true;
            this.lstTraEliTrazas.TabIndex = 15;
            // 
            // btnTraElBorrarTraza
            // 
            this.btnTraElBorrarTraza.Location = new System.Drawing.Point(582, 41);
            this.btnTraElBorrarTraza.Name = "btnTraElBorrarTraza";
            this.btnTraElBorrarTraza.Size = new System.Drawing.Size(100, 23);
            this.btnTraElBorrarTraza.TabIndex = 14;
            this.btnTraElBorrarTraza.Text = "Borrar Traza";
            this.btnTraElBorrarTraza.UseVisualStyleBackColor = true;
            this.btnTraElBorrarTraza.Click += new System.EventHandler(this.btnTraElBorrarTraza_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(200, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Trazas Actuales";
            // 
            // pnlTraza
            // 
            this.pnlTraza.Controls.Add(this.tclTraza);
            this.pnlTraza.Controls.Add(this.btnTraLimpiar);
            this.pnlTraza.Controls.Add(this.btnTraCancelar);
            this.pnlTraza.Controls.Add(this.btnTraAceptar);
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
    }
}