namespace ffccSimulacion.ABMEstacion
{
    partial class frmABMEstacion
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
            this.btnEstLimpiar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnEstacionAceptar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.CrearEstacion = new System.Windows.Forms.TabPage();
            this.lblEstCreError = new System.Windows.Forms.Label();
            this.clbIncidentes = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbEstCreFdp = new System.Windows.Forms.ComboBox();
            this.txtEstCreMaximo = new System.Windows.Forms.TextBox();
            this.txtEstCreMinimo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEstCreNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreAgregarIncidente = new System.Windows.Forms.Button();
            this.ModificarEstacion = new System.Windows.Forms.TabPage();
            this.clbModIncidentes = new System.Windows.Forms.CheckedListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lstModEstaciones = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbEstModFdp = new System.Windows.Forms.ComboBox();
            this.txtEstModMaximo = new System.Windows.Forms.TextBox();
            this.txtEstModMinimo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEstModNombre = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.EliminarEstacion = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.lstEliEstaciones = new System.Windows.Forms.ListBox();
            this.btnEstBorrar = new System.Windows.Forms.Button();
            this.pnlEstacion = new System.Windows.Forms.Panel();
            this.lblEstacionError = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.CrearEstacion.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.ModificarEstacion.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.EliminarEstacion.SuspendLayout();
            this.pnlEstacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEstLimpiar
            // 
            this.btnEstLimpiar.Location = new System.Drawing.Point(14, 461);
            this.btnEstLimpiar.Name = "btnEstLimpiar";
            this.btnEstLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnEstLimpiar.TabIndex = 3;
            this.btnEstLimpiar.Text = "Limpiar";
            this.btnEstLimpiar.UseVisualStyleBackColor = true;
            this.btnEstLimpiar.Click += new System.EventHandler(this.btnEstLimpiar_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(976, 461);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(77, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnEstacionAceptar
            // 
            this.btnEstacionAceptar.Location = new System.Drawing.Point(892, 461);
            this.btnEstacionAceptar.Name = "btnEstacionAceptar";
            this.btnEstacionAceptar.Size = new System.Drawing.Size(78, 23);
            this.btnEstacionAceptar.TabIndex = 3;
            this.btnEstacionAceptar.Text = "Aceptar";
            this.btnEstacionAceptar.UseVisualStyleBackColor = true;
            this.btnEstacionAceptar.Click += new System.EventHandler(this.btnEstacionAceptar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.CrearEstacion);
            this.tabControl1.Controls.Add(this.ModificarEstacion);
            this.tabControl1.Controls.Add(this.EliminarEstacion);
            this.tabControl1.Location = new System.Drawing.Point(14, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1040, 446);
            this.tabControl1.TabIndex = 4;
            // 
            // CrearEstacion
            // 
            this.CrearEstacion.Controls.Add(this.lblEstCreError);
            this.CrearEstacion.Controls.Add(this.clbIncidentes);
            this.CrearEstacion.Controls.Add(this.label1);
            this.CrearEstacion.Controls.Add(this.groupBox1);
            this.CrearEstacion.Controls.Add(this.txtEstCreNombre);
            this.CrearEstacion.Controls.Add(this.label2);
            this.CrearEstacion.Controls.Add(this.btnCreAgregarIncidente);
            this.CrearEstacion.Location = new System.Drawing.Point(4, 22);
            this.CrearEstacion.Name = "CrearEstacion";
            this.CrearEstacion.Padding = new System.Windows.Forms.Padding(3);
            this.CrearEstacion.Size = new System.Drawing.Size(1032, 420);
            this.CrearEstacion.TabIndex = 0;
            this.CrearEstacion.Text = "Crear";
            this.CrearEstacion.UseVisualStyleBackColor = true;
            // 
            // lblEstCreError
            // 
            this.lblEstCreError.AutoSize = true;
            this.lblEstCreError.Location = new System.Drawing.Point(793, 65);
            this.lblEstCreError.Name = "lblEstCreError";
            this.lblEstCreError.Size = new System.Drawing.Size(87, 13);
            this.lblEstCreError.TabIndex = 20;
            this.lblEstCreError.Text = "Mensaje de Error";
            // 
            // clbIncidentes
            // 
            this.clbIncidentes.FormattingEnabled = true;
            this.clbIncidentes.Location = new System.Drawing.Point(447, 43);
            this.clbIncidentes.Name = "clbIncidentes";
            this.clbIncidentes.Size = new System.Drawing.Size(301, 319);
            this.clbIncidentes.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nombre";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbEstCreFdp);
            this.groupBox1.Controls.Add(this.txtEstCreMaximo);
            this.groupBox1.Controls.Add(this.txtEstCreMinimo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(80, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 201);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personas Esperando en Andén";
            // 
            // cmbEstCreFdp
            // 
            this.cmbEstCreFdp.FormattingEnabled = true;
            this.cmbEstCreFdp.Items.AddRange(new object[] {
            "Normal",
            "Gamma",
            "Poission"});
            this.cmbEstCreFdp.Location = new System.Drawing.Point(76, 145);
            this.cmbEstCreFdp.Name = "cmbEstCreFdp";
            this.cmbEstCreFdp.Size = new System.Drawing.Size(220, 21);
            this.cmbEstCreFdp.TabIndex = 2;
            // 
            // txtEstCreMaximo
            // 
            this.txtEstCreMaximo.Location = new System.Drawing.Point(76, 92);
            this.txtEstCreMaximo.Name = "txtEstCreMaximo";
            this.txtEstCreMaximo.Size = new System.Drawing.Size(220, 20);
            this.txtEstCreMaximo.TabIndex = 1;
            // 
            // txtEstCreMinimo
            // 
            this.txtEstCreMinimo.Location = new System.Drawing.Point(76, 39);
            this.txtEstCreMinimo.Name = "txtEstCreMinimo";
            this.txtEstCreMinimo.Size = new System.Drawing.Size(220, 20);
            this.txtEstCreMinimo.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "FDP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Maximo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Minimo";
            // 
            // txtEstCreNombre
            // 
            this.txtEstCreNombre.Location = new System.Drawing.Point(156, 63);
            this.txtEstCreNombre.Name = "txtEstCreNombre";
            this.txtEstCreNombre.Size = new System.Drawing.Size(220, 20);
            this.txtEstCreNombre.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Incidentes";
            // 
            // btnCreAgregarIncidente
            // 
            this.btnCreAgregarIncidente.Location = new System.Drawing.Point(447, 368);
            this.btnCreAgregarIncidente.Name = "btnCreAgregarIncidente";
            this.btnCreAgregarIncidente.Size = new System.Drawing.Size(116, 23);
            this.btnCreAgregarIncidente.TabIndex = 15;
            this.btnCreAgregarIncidente.Text = "Agregar Incidente";
            this.btnCreAgregarIncidente.UseVisualStyleBackColor = true;
            this.btnCreAgregarIncidente.Click += new System.EventHandler(this.button1_Click);
            // 
            // ModificarEstacion
            // 
            this.ModificarEstacion.Controls.Add(this.clbModIncidentes);
            this.ModificarEstacion.Controls.Add(this.label11);
            this.ModificarEstacion.Controls.Add(this.lstModEstaciones);
            this.ModificarEstacion.Controls.Add(this.label6);
            this.ModificarEstacion.Controls.Add(this.label7);
            this.ModificarEstacion.Controls.Add(this.groupBox2);
            this.ModificarEstacion.Controls.Add(this.txtEstModNombre);
            this.ModificarEstacion.Controls.Add(this.button5);
            this.ModificarEstacion.Location = new System.Drawing.Point(4, 22);
            this.ModificarEstacion.Name = "ModificarEstacion";
            this.ModificarEstacion.Padding = new System.Windows.Forms.Padding(3);
            this.ModificarEstacion.Size = new System.Drawing.Size(1032, 420);
            this.ModificarEstacion.TabIndex = 1;
            this.ModificarEstacion.Text = "Modificar";
            this.ModificarEstacion.UseVisualStyleBackColor = true;
            // 
            // clbModIncidentes
            // 
            this.clbModIncidentes.FormattingEnabled = true;
            this.clbModIncidentes.Location = new System.Drawing.Point(725, 43);
            this.clbModIncidentes.Name = "clbModIncidentes";
            this.clbModIncidentes.Size = new System.Drawing.Size(301, 319);
            this.clbModIncidentes.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Listado de Estaciones";
            // 
            // lstModEstaciones
            // 
            this.lstModEstaciones.FormattingEnabled = true;
            this.lstModEstaciones.Location = new System.Drawing.Point(9, 43);
            this.lstModEstaciones.Name = "lstModEstaciones";
            this.lstModEstaciones.Size = new System.Drawing.Size(288, 342);
            this.lstModEstaciones.TabIndex = 11;
            this.lstModEstaciones.SelectedIndexChanged += new System.EventHandler(this.seleccionarEstacion);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(346, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Nombre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(722, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Incidentes";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbEstModFdp);
            this.groupBox2.Controls.Add(this.txtEstModMaximo);
            this.groupBox2.Controls.Add(this.txtEstModMinimo);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(349, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(329, 201);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personas Esperando en Andén";
            // 
            // cmbEstModFdp
            // 
            this.cmbEstModFdp.FormattingEnabled = true;
            this.cmbEstModFdp.Items.AddRange(new object[] {
            "Normal",
            "Gamma",
            "Poission"});
            this.cmbEstModFdp.Location = new System.Drawing.Point(76, 145);
            this.cmbEstModFdp.Name = "cmbEstModFdp";
            this.cmbEstModFdp.Size = new System.Drawing.Size(220, 21);
            this.cmbEstModFdp.TabIndex = 2;
            // 
            // txtEstModMaximo
            // 
            this.txtEstModMaximo.Location = new System.Drawing.Point(76, 92);
            this.txtEstModMaximo.Name = "txtEstModMaximo";
            this.txtEstModMaximo.Size = new System.Drawing.Size(220, 20);
            this.txtEstModMaximo.TabIndex = 1;
            // 
            // txtEstModMinimo
            // 
            this.txtEstModMinimo.Location = new System.Drawing.Point(76, 39);
            this.txtEstModMinimo.Name = "txtEstModMinimo";
            this.txtEstModMinimo.Size = new System.Drawing.Size(220, 20);
            this.txtEstModMinimo.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "FDP";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Maximo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Minimo";
            // 
            // txtEstModNombre
            // 
            this.txtEstModNombre.Location = new System.Drawing.Point(419, 82);
            this.txtEstModNombre.Name = "txtEstModNombre";
            this.txtEstModNombre.Size = new System.Drawing.Size(226, 20);
            this.txtEstModNombre.TabIndex = 7;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(725, 368);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(116, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "Agregar Incidente";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // EliminarEstacion
            // 
            this.EliminarEstacion.Controls.Add(this.label12);
            this.EliminarEstacion.Controls.Add(this.lstEliEstaciones);
            this.EliminarEstacion.Controls.Add(this.btnEstBorrar);
            this.EliminarEstacion.Location = new System.Drawing.Point(4, 22);
            this.EliminarEstacion.Name = "EliminarEstacion";
            this.EliminarEstacion.Padding = new System.Windows.Forms.Padding(3);
            this.EliminarEstacion.Size = new System.Drawing.Size(1032, 420);
            this.EliminarEstacion.TabIndex = 2;
            this.EliminarEstacion.Text = "Eliminar";
            this.EliminarEstacion.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(310, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Listado de Estaciones";
            // 
            // lstEliEstaciones
            // 
            this.lstEliEstaciones.FormattingEnabled = true;
            this.lstEliEstaciones.Location = new System.Drawing.Point(313, 31);
            this.lstEliEstaciones.Name = "lstEliEstaciones";
            this.lstEliEstaciones.Size = new System.Drawing.Size(334, 381);
            this.lstEliEstaciones.TabIndex = 14;
            // 
            // btnEstBorrar
            // 
            this.btnEstBorrar.Location = new System.Drawing.Point(653, 31);
            this.btnEstBorrar.Name = "btnEstBorrar";
            this.btnEstBorrar.Size = new System.Drawing.Size(93, 23);
            this.btnEstBorrar.TabIndex = 13;
            this.btnEstBorrar.Text = "Borrar Estación";
            this.btnEstBorrar.UseVisualStyleBackColor = true;
            this.btnEstBorrar.Click += new System.EventHandler(this.btnEstBorrar_Click);
            // 
            // pnlEstacion
            // 
            this.pnlEstacion.Controls.Add(this.lblEstacionError);
            this.pnlEstacion.Controls.Add(this.tabControl1);
            this.pnlEstacion.Controls.Add(this.btnEstLimpiar);
            this.pnlEstacion.Controls.Add(this.btnEstacionAceptar);
            this.pnlEstacion.Controls.Add(this.button3);
            this.pnlEstacion.Location = new System.Drawing.Point(12, 12);
            this.pnlEstacion.Name = "pnlEstacion";
            this.pnlEstacion.Size = new System.Drawing.Size(1068, 497);
            this.pnlEstacion.TabIndex = 5;
            // 
            // lblEstacionError
            // 
            this.lblEstacionError.AutoSize = true;
            this.lblEstacionError.Location = new System.Drawing.Point(108, 466);
            this.lblEstacionError.Name = "lblEstacionError";
            this.lblEstacionError.Size = new System.Drawing.Size(87, 13);
            this.lblEstacionError.TabIndex = 5;
            this.lblEstacionError.Text = "Mensaje de Error";
            // 
            // frmABMEstacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 515);
            this.Controls.Add(this.pnlEstacion);
            this.Name = "frmABMEstacion";
            this.Text = "Estación";
            this.tabControl1.ResumeLayout(false);
            this.CrearEstacion.ResumeLayout(false);
            this.CrearEstacion.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ModificarEstacion.ResumeLayout(false);
            this.ModificarEstacion.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.EliminarEstacion.ResumeLayout(false);
            this.EliminarEstacion.PerformLayout();
            this.pnlEstacion.ResumeLayout(false);
            this.pnlEstacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEstLimpiar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnEstacionAceptar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage CrearEstacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreAgregarIncidente;
        private System.Windows.Forms.TabPage ModificarEstacion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox lstModEstaciones;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbEstModFdp;
        private System.Windows.Forms.TextBox txtEstModMaximo;
        private System.Windows.Forms.TextBox txtEstModMinimo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEstModNombre;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbEstCreFdp;
        private System.Windows.Forms.TextBox txtEstCreMaximo;
        private System.Windows.Forms.TextBox txtEstCreMinimo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEstCreNombre;
        private System.Windows.Forms.TabPage EliminarEstacion;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox lstEliEstaciones;
        private System.Windows.Forms.Button btnEstBorrar;
        private System.Windows.Forms.CheckedListBox clbIncidentes;
        private System.Windows.Forms.CheckedListBox clbModIncidentes;
        public System.Windows.Forms.Panel pnlEstacion;
        private System.Windows.Forms.Label lblEstCreError;
        private System.Windows.Forms.Label lblEstacionError;
    }
}