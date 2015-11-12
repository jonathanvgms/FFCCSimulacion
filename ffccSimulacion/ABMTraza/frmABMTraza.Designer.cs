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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.clbTraCreServicios = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lstTraCreResultados = new System.Windows.Forms.ListBox();
            this.txtTraCreBuscar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabModificarTraza = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.clbTraModServicios = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTraModNombre = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lstTraModTrazas = new System.Windows.Forms.ListBox();
            this.txtTraModBuscar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabEliminarTraza = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lstTraEliTrazas = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTraEliBuscar = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lstTraEliSimulaciones = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.btnTraElBorrarTraza = new System.Windows.Forms.Button();
            this.pnlTraza = new System.Windows.Forms.Panel();
            this.tclTraza.SuspendLayout();
            this.tabCrearTraza.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabModificarTraza.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabEliminarTraza.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.pnlTraza.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Listado de Servicios ";
            // 
            // txtTraCreNombre
            // 
            this.txtTraCreNombre.Location = new System.Drawing.Point(84, 38);
            this.txtTraCreNombre.MaxLength = 99;
            this.txtTraCreNombre.Name = "txtTraCreNombre";
            this.txtTraCreNombre.Size = new System.Drawing.Size(252, 21);
            this.txtTraCreNombre.TabIndex = 3;
            // 
            // btnTraLimpiar
            // 
            this.btnTraLimpiar.Location = new System.Drawing.Point(12, 549);
            this.btnTraLimpiar.Name = "btnTraLimpiar";
            this.btnTraLimpiar.Size = new System.Drawing.Size(90, 30);
            this.btnTraLimpiar.TabIndex = 5;
            this.btnTraLimpiar.Text = "Limpiar";
            this.btnTraLimpiar.UseVisualStyleBackColor = true;
            this.btnTraLimpiar.Click += new System.EventHandler(this.btnTraLimpiar_Click);
            // 
            // btnTraCancelar
            // 
            this.btnTraCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnTraCancelar.Location = new System.Drawing.Point(1058, 549);
            this.btnTraCancelar.Name = "btnTraCancelar";
            this.btnTraCancelar.Size = new System.Drawing.Size(90, 30);
            this.btnTraCancelar.TabIndex = 5;
            this.btnTraCancelar.Text = "Cancelar";
            this.btnTraCancelar.UseVisualStyleBackColor = true;
            this.btnTraCancelar.Click += new System.EventHandler(this.btnTraCancelar_Click);
            // 
            // btnTraAceptar
            // 
            this.btnTraAceptar.Location = new System.Drawing.Point(962, 549);
            this.btnTraAceptar.Name = "btnTraAceptar";
            this.btnTraAceptar.Size = new System.Drawing.Size(90, 30);
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
            this.tclTraza.Size = new System.Drawing.Size(1136, 529);
            this.tclTraza.TabIndex = 7;
            this.tclTraza.Selected += new System.Windows.Forms.TabControlEventHandler(this.seleccionarPestaña);
            // 
            // tabCrearTraza
            // 
            this.tabCrearTraza.Controls.Add(this.groupBox2);
            this.tabCrearTraza.Controls.Add(this.groupBox1);
            this.tabCrearTraza.Location = new System.Drawing.Point(4, 24);
            this.tabCrearTraza.Name = "tabCrearTraza";
            this.tabCrearTraza.Padding = new System.Windows.Forms.Padding(3);
            this.tabCrearTraza.Size = new System.Drawing.Size(1128, 501);
            this.tabCrearTraza.TabIndex = 0;
            this.tabCrearTraza.Text = "Nueva Traza";
            this.tabCrearTraza.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.clbTraCreServicios);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtTraCreNombre);
            this.groupBox2.Location = new System.Drawing.Point(17, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(539, 463);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Traza";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(355, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(175, 60);
            this.label10.TabIndex = 7;
            this.label10.Text = "Listado de servicios existentes \r\nen el sistema, una traza debe\r\ntener al menos u" +
    "n servicio \r\nseleccionado";
            // 
            // clbTraCreServicios
            // 
            this.clbTraCreServicios.FormattingEnabled = true;
            this.clbTraCreServicios.Location = new System.Drawing.Point(22, 100);
            this.clbTraCreServicios.Name = "clbTraCreServicios";
            this.clbTraCreServicios.Size = new System.Drawing.Size(314, 340);
            this.clbTraCreServicios.Sorted = true;
            this.clbTraCreServicios.TabIndex = 6;
            this.clbTraCreServicios.SelectedIndexChanged += new System.EventHandler(this.seleccionarServicios);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lstTraCreResultados);
            this.groupBox1.Controls.Add(this.txtTraCreBuscar);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(579, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 463);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Traza";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(375, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 30);
            this.label11.TabIndex = 8;
            this.label11.Text = "Listado de trazas \r\nexistentes en el sistema";
            // 
            // lstTraCreResultados
            // 
            this.lstTraCreResultados.DisplayMember = "Nombre";
            this.lstTraCreResultados.FormattingEnabled = true;
            this.lstTraCreResultados.ItemHeight = 15;
            this.lstTraCreResultados.Location = new System.Drawing.Point(21, 68);
            this.lstTraCreResultados.Name = "lstTraCreResultados";
            this.lstTraCreResultados.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstTraCreResultados.Size = new System.Drawing.Size(348, 379);
            this.lstTraCreResultados.Sorted = true;
            this.lstTraCreResultados.TabIndex = 17;
            // 
            // txtTraCreBuscar
            // 
            this.txtTraCreBuscar.Location = new System.Drawing.Point(117, 38);
            this.txtTraCreBuscar.MaxLength = 99;
            this.txtTraCreBuscar.Name = "txtTraCreBuscar";
            this.txtTraCreBuscar.Size = new System.Drawing.Size(252, 21);
            this.txtTraCreBuscar.TabIndex = 18;
            this.txtTraCreBuscar.TextChanged += new System.EventHandler(this.buscarTraza);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Nombre";
            // 
            // tabModificarTraza
            // 
            this.tabModificarTraza.Controls.Add(this.groupBox4);
            this.tabModificarTraza.Controls.Add(this.groupBox3);
            this.tabModificarTraza.Location = new System.Drawing.Point(4, 24);
            this.tabModificarTraza.Name = "tabModificarTraza";
            this.tabModificarTraza.Padding = new System.Windows.Forms.Padding(3);
            this.tabModificarTraza.Size = new System.Drawing.Size(1128, 501);
            this.tabModificarTraza.TabIndex = 1;
            this.tabModificarTraza.Text = "       Modificar";
            this.tabModificarTraza.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.clbTraModServicios);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtTraModNombre);
            this.groupBox4.Location = new System.Drawing.Point(569, 24);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(539, 453);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Traza";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(360, 96);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(175, 60);
            this.label13.TabIndex = 15;
            this.label13.Text = "Listado de servicios existentes \r\nen el sistema, una traza debe\r\ntener al menos u" +
    "n servicio \r\nseleccionado";
            // 
            // clbTraModServicios
            // 
            this.clbTraModServicios.FormattingEnabled = true;
            this.clbTraModServicios.Location = new System.Drawing.Point(23, 96);
            this.clbTraModServicios.Name = "clbTraModServicios";
            this.clbTraModServicios.Size = new System.Drawing.Size(331, 340);
            this.clbTraModServicios.Sorted = true;
            this.clbTraModServicios.TabIndex = 14;
            this.clbTraModServicios.SelectedIndexChanged += new System.EventHandler(this.seleccionarServicios);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Listado de Servicios";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nombre";
            // 
            // txtTraModNombre
            // 
            this.txtTraModNombre.Location = new System.Drawing.Point(115, 35);
            this.txtTraModNombre.MaxLength = 99;
            this.txtTraModNombre.Name = "txtTraModNombre";
            this.txtTraModNombre.Size = new System.Drawing.Size(239, 21);
            this.txtTraModNombre.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.lstTraModTrazas);
            this.groupBox3.Controls.Add(this.txtTraModBuscar);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(17, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(529, 453);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar Traza a Modificar";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(345, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(175, 60);
            this.label12.TabIndex = 16;
            this.label12.Text = "Listado de servicios existentes \r\nen el sistema, seleccione una\r\ntraza para modif" +
    "icar \r\nsus atrubutos";
            // 
            // lstTraModTrazas
            // 
            this.lstTraModTrazas.DisplayMember = "Nombre";
            this.lstTraModTrazas.FormattingEnabled = true;
            this.lstTraModTrazas.ItemHeight = 15;
            this.lstTraModTrazas.Location = new System.Drawing.Point(20, 62);
            this.lstTraModTrazas.Name = "lstTraModTrazas";
            this.lstTraModTrazas.Size = new System.Drawing.Size(319, 364);
            this.lstTraModTrazas.Sorted = true;
            this.lstTraModTrazas.TabIndex = 12;
            this.lstTraModTrazas.SelectedIndexChanged += new System.EventHandler(this.seleccionarTraza);
            // 
            // txtTraModBuscar
            // 
            this.txtTraModBuscar.Location = new System.Drawing.Point(116, 32);
            this.txtTraModBuscar.MaxLength = 99;
            this.txtTraModBuscar.Name = "txtTraModBuscar";
            this.txtTraModBuscar.Size = new System.Drawing.Size(223, 21);
            this.txtTraModBuscar.TabIndex = 15;
            this.txtTraModBuscar.TextChanged += new System.EventHandler(this.buscarTraza);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre";
            // 
            // tabEliminarTraza
            // 
            this.tabEliminarTraza.Controls.Add(this.groupBox7);
            this.tabEliminarTraza.Controls.Add(this.groupBox6);
            this.tabEliminarTraza.Controls.Add(this.groupBox5);
            this.tabEliminarTraza.Location = new System.Drawing.Point(4, 24);
            this.tabEliminarTraza.Name = "tabEliminarTraza";
            this.tabEliminarTraza.Padding = new System.Windows.Forms.Padding(3);
            this.tabEliminarTraza.Size = new System.Drawing.Size(1128, 501);
            this.tabEliminarTraza.TabIndex = 2;
            this.tabEliminarTraza.Text = "       Eliminar";
            this.tabEliminarTraza.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Controls.Add(this.lstTraEliTrazas);
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Controls.Add(this.txtTraEliBuscar);
            this.groupBox7.Location = new System.Drawing.Point(113, 24);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(526, 449);
            this.groupBox7.TabIndex = 22;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Buscar Traza a Eliminar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(341, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 45);
            this.label6.TabIndex = 18;
            this.label6.Text = "Listado de servicios existentes \r\nen el sistema, seleccione una\r\ntraza para elimi" +
    "narla";
            // 
            // lstTraEliTrazas
            // 
            this.lstTraEliTrazas.DisplayMember = "Nombre";
            this.lstTraEliTrazas.FormattingEnabled = true;
            this.lstTraEliTrazas.ItemHeight = 15;
            this.lstTraEliTrazas.Location = new System.Drawing.Point(20, 64);
            this.lstTraEliTrazas.Name = "lstTraEliTrazas";
            this.lstTraEliTrazas.Size = new System.Drawing.Size(315, 364);
            this.lstTraEliTrazas.Sorted = true;
            this.lstTraEliTrazas.TabIndex = 15;
            this.lstTraEliTrazas.SelectedIndexChanged += new System.EventHandler(this.simulacionesAsociadas);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Buscar Traza";
            // 
            // txtTraEliBuscar
            // 
            this.txtTraEliBuscar.Location = new System.Drawing.Point(116, 37);
            this.txtTraEliBuscar.MaxLength = 99;
            this.txtTraEliBuscar.Name = "txtTraEliBuscar";
            this.txtTraEliBuscar.Size = new System.Drawing.Size(219, 21);
            this.txtTraEliBuscar.TabIndex = 17;
            this.txtTraEliBuscar.TextChanged += new System.EventHandler(this.buscarTraza);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.lstTraEliSimulaciones);
            this.groupBox6.Location = new System.Drawing.Point(661, 177);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(347, 296);
            this.groupBox6.TabIndex = 21;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Simulaciones Asociadas";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(301, 15);
            this.label9.TabIndex = 28;
            this.label9.Text = "Muestra las simulaciones a las que pertenece la traza";
            // 
            // lstTraEliSimulaciones
            // 
            this.lstTraEliSimulaciones.DisplayMember = "Nombre";
            this.lstTraEliSimulaciones.Enabled = false;
            this.lstTraEliSimulaciones.FormattingEnabled = true;
            this.lstTraEliSimulaciones.ItemHeight = 15;
            this.lstTraEliSimulaciones.Location = new System.Drawing.Point(27, 55);
            this.lstTraEliSimulaciones.Name = "lstTraEliSimulaciones";
            this.lstTraEliSimulaciones.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstTraEliSimulaciones.Size = new System.Drawing.Size(301, 214);
            this.lstTraEliSimulaciones.Sorted = true;
            this.lstTraEliSimulaciones.TabIndex = 18;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label23);
            this.groupBox5.Controls.Add(this.btnTraElBorrarTraza);
            this.groupBox5.Location = new System.Drawing.Point(661, 33);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(347, 127);
            this.groupBox5.TabIndex = 20;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Eliminar Traza";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(24, 31);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(311, 30);
            this.label23.TabIndex = 25;
            this.label23.Text = "Elimina la traza del sistema, solo se podrán \r\neliminar aquellas que no pertenezc" +
    "an a una simulación";
            // 
            // btnTraElBorrarTraza
            // 
            this.btnTraElBorrarTraza.Image = global::ffccSimulacion.Properties.Resources.bin_icon_1488050992;
            this.btnTraElBorrarTraza.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTraElBorrarTraza.Location = new System.Drawing.Point(185, 70);
            this.btnTraElBorrarTraza.Name = "btnTraElBorrarTraza";
            this.btnTraElBorrarTraza.Size = new System.Drawing.Size(150, 30);
            this.btnTraElBorrarTraza.TabIndex = 14;
            this.btnTraElBorrarTraza.Text = "Eliminar";
            this.btnTraElBorrarTraza.UseVisualStyleBackColor = true;
            this.btnTraElBorrarTraza.Click += new System.EventHandler(this.btnTraElBorrarTraza_Click);
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
            this.pnlTraza.Size = new System.Drawing.Size(1160, 592);
            this.pnlTraza.TabIndex = 7;
            // 
            // frmABMTraza
            // 
            this.AcceptButton = this.btnTraAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnTraCancelar;
            this.ClientSize = new System.Drawing.Size(1184, 616);
            this.Controls.Add(this.pnlTraza);
            this.Name = "frmABMTraza";
            this.Text = "Traza";
            this.tclTraza.ResumeLayout(false);
            this.tabCrearTraza.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabModificarTraza.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabEliminarTraza.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
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
        private System.Windows.Forms.CheckedListBox clbTraCreServicios;
        private System.Windows.Forms.CheckedListBox clbTraModServicios;
        public System.Windows.Forms.Panel pnlTraza;
        private System.Windows.Forms.TextBox txtTraCreBuscar;
        private System.Windows.Forms.ListBox lstTraCreResultados;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTraModBuscar;
        private System.Windows.Forms.ListBox lstTraEliSimulaciones;
        private System.Windows.Forms.TextBox txtTraEliBuscar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label9;
    }
}