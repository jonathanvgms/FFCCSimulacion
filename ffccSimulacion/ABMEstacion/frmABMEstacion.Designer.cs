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
            this.btnEstCancelar = new System.Windows.Forms.Button();
            this.btnEstAceptar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.CrearEstacion = new System.Windows.Forms.TabPage();
            this.txtEstCreBuscar = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.lstCreEstaciones = new System.Windows.Forms.ListBox();
            this.cmbEstCreFdp = new System.Windows.Forms.ComboBox();
            this.clbIncidentes = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEstCreMaximo = new System.Windows.Forms.TextBox();
            this.txtEstCreMinimo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEstCreNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ModificarEstacion = new System.Windows.Forms.TabPage();
            this.txtEstacionesModBuscar = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbEstModFdp = new System.Windows.Forms.ComboBox();
            this.clbModIncidentes = new System.Windows.Forms.CheckedListBox();
            this.lstModEstaciones = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtEstModMaximo = new System.Windows.Forms.TextBox();
            this.txtEstModMinimo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEstModNombre = new System.Windows.Forms.TextBox();
            this.EliminarEstacion = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.lstEstEliServicios = new System.Windows.Forms.ListBox();
            this.txtEstEliBuscar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lstEliEstaciones = new System.Windows.Forms.ListBox();
            this.btnEstBorrar = new System.Windows.Forms.Button();
            this.pnlEstacion = new System.Windows.Forms.Panel();
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
            this.btnEstLimpiar.Size = new System.Drawing.Size(75, 28);
            this.btnEstLimpiar.TabIndex = 3;
            this.btnEstLimpiar.Text = "Limpiar";
            this.btnEstLimpiar.UseVisualStyleBackColor = true;
            this.btnEstLimpiar.Click += new System.EventHandler(this.btnEstLimpiar_Click);
            // 
            // btnEstCancelar
            // 
            this.btnEstCancelar.Location = new System.Drawing.Point(976, 461);
            this.btnEstCancelar.Name = "btnEstCancelar";
            this.btnEstCancelar.Size = new System.Drawing.Size(77, 28);
            this.btnEstCancelar.TabIndex = 3;
            this.btnEstCancelar.Text = "Cancelar";
            this.btnEstCancelar.UseVisualStyleBackColor = true;
            this.btnEstCancelar.Click += new System.EventHandler(this.btnEstCancelar_Click);
            // 
            // btnEstAceptar
            // 
            this.btnEstAceptar.Location = new System.Drawing.Point(892, 461);
            this.btnEstAceptar.Name = "btnEstAceptar";
            this.btnEstAceptar.Size = new System.Drawing.Size(78, 28);
            this.btnEstAceptar.TabIndex = 3;
            this.btnEstAceptar.Text = "Aceptar";
            this.btnEstAceptar.UseVisualStyleBackColor = true;
            this.btnEstAceptar.Click += new System.EventHandler(this.btnEstAceptar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.CrearEstacion);
            this.tabControl1.Controls.Add(this.ModificarEstacion);
            this.tabControl1.Controls.Add(this.EliminarEstacion);
            this.tabControl1.Location = new System.Drawing.Point(14, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.ShowToolTips = true;
            this.tabControl1.Size = new System.Drawing.Size(1040, 446);
            this.tabControl1.TabIndex = 4;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.seleccionarPestaña);
            // 
            // CrearEstacion
            // 
            this.CrearEstacion.Controls.Add(this.txtEstCreBuscar);
            this.CrearEstacion.Controls.Add(this.label18);
            this.CrearEstacion.Controls.Add(this.lstCreEstaciones);
            this.CrearEstacion.Controls.Add(this.cmbEstCreFdp);
            this.CrearEstacion.Controls.Add(this.clbIncidentes);
            this.CrearEstacion.Controls.Add(this.label1);
            this.CrearEstacion.Controls.Add(this.label3);
            this.CrearEstacion.Controls.Add(this.groupBox1);
            this.CrearEstacion.Controls.Add(this.txtEstCreNombre);
            this.CrearEstacion.Controls.Add(this.label2);
            this.CrearEstacion.Location = new System.Drawing.Point(4, 24);
            this.CrearEstacion.Name = "CrearEstacion";
            this.CrearEstacion.Padding = new System.Windows.Forms.Padding(3);
            this.CrearEstacion.Size = new System.Drawing.Size(1032, 418);
            this.CrearEstacion.TabIndex = 0;
            this.CrearEstacion.Text = "Nueva Estación";
            this.CrearEstacion.ToolTipText = "Crea un nueva estación";
            this.CrearEstacion.UseVisualStyleBackColor = true;
            // 
            // txtEstCreBuscar
            // 
            this.txtEstCreBuscar.Location = new System.Drawing.Point(110, 28);
            this.txtEstCreBuscar.MaxLength = 99;
            this.txtEstCreBuscar.Name = "txtEstCreBuscar";
            this.txtEstCreBuscar.Size = new System.Drawing.Size(190, 21);
            this.txtEstCreBuscar.TabIndex = 26;
            this.txtEstCreBuscar.TextChanged += new System.EventHandler(this.buscarEstaciones);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(9, 31);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(95, 15);
            this.label18.TabIndex = 25;
            this.label18.Text = "Buscar Estación";
            // 
            // lstCreEstaciones
            // 
            this.lstCreEstaciones.DisplayMember = "Nombre";
            this.lstCreEstaciones.FormattingEnabled = true;
            this.lstCreEstaciones.ItemHeight = 15;
            this.lstCreEstaciones.Location = new System.Drawing.Point(12, 59);
            this.lstCreEstaciones.Name = "lstCreEstaciones";
            this.lstCreEstaciones.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstCreEstaciones.Size = new System.Drawing.Size(288, 349);
            this.lstCreEstaciones.Sorted = true;
            this.lstCreEstaciones.TabIndex = 24;
            // 
            // cmbEstCreFdp
            // 
            this.cmbEstCreFdp.FormattingEnabled = true;
            this.cmbEstCreFdp.Items.AddRange(new object[] {
            "Normal",
            "Gamma",
            "Poission"});
            this.cmbEstCreFdp.Location = new System.Drawing.Point(494, 324);
            this.cmbEstCreFdp.Name = "cmbEstCreFdp";
            this.cmbEstCreFdp.Size = new System.Drawing.Size(147, 23);
            this.cmbEstCreFdp.TabIndex = 2;
            // 
            // clbIncidentes
            // 
            this.clbIncidentes.FormattingEnabled = true;
            this.clbIncidentes.Location = new System.Drawing.Point(712, 47);
            this.clbIncidentes.Name = "clbIncidentes";
            this.clbIncidentes.Size = new System.Drawing.Size(301, 356);
            this.clbIncidentes.Sorted = true;
            this.clbIncidentes.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Distribución de Arribo \r\nde Personas al Andén";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtEstCreMaximo);
            this.groupBox1.Controls.Add(this.txtEstCreMinimo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(345, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 140);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cantidad de Personas Esperando en Andén";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(245, 95);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 15);
            this.label14.TabIndex = 3;
            this.label14.Text = "Personas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(245, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Personas";
            // 
            // txtEstCreMaximo
            // 
            this.txtEstCreMaximo.Location = new System.Drawing.Point(76, 92);
            this.txtEstCreMaximo.MaxLength = 9;
            this.txtEstCreMaximo.Name = "txtEstCreMaximo";
            this.txtEstCreMaximo.Size = new System.Drawing.Size(151, 21);
            this.txtEstCreMaximo.TabIndex = 1;
            // 
            // txtEstCreMinimo
            // 
            this.txtEstCreMinimo.Location = new System.Drawing.Point(76, 39);
            this.txtEstCreMinimo.MaxLength = 9;
            this.txtEstCreMinimo.Name = "txtEstCreMinimo";
            this.txtEstCreMinimo.Size = new System.Drawing.Size(151, 21);
            this.txtEstCreMinimo.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Maximo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Minimo";
            // 
            // txtEstCreNombre
            // 
            this.txtEstCreNombre.Location = new System.Drawing.Point(421, 67);
            this.txtEstCreNombre.MaxLength = 99;
            this.txtEstCreNombre.Name = "txtEstCreNombre";
            this.txtEstCreNombre.Size = new System.Drawing.Size(220, 21);
            this.txtEstCreNombre.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(709, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Incidentes";
            // 
            // ModificarEstacion
            // 
            this.ModificarEstacion.Controls.Add(this.txtEstacionesModBuscar);
            this.ModificarEstacion.Controls.Add(this.label17);
            this.ModificarEstacion.Controls.Add(this.label13);
            this.ModificarEstacion.Controls.Add(this.cmbEstModFdp);
            this.ModificarEstacion.Controls.Add(this.clbModIncidentes);
            this.ModificarEstacion.Controls.Add(this.lstModEstaciones);
            this.ModificarEstacion.Controls.Add(this.label6);
            this.ModificarEstacion.Controls.Add(this.label7);
            this.ModificarEstacion.Controls.Add(this.groupBox2);
            this.ModificarEstacion.Controls.Add(this.txtEstModNombre);
            this.ModificarEstacion.Location = new System.Drawing.Point(4, 24);
            this.ModificarEstacion.Name = "ModificarEstacion";
            this.ModificarEstacion.Padding = new System.Windows.Forms.Padding(3);
            this.ModificarEstacion.Size = new System.Drawing.Size(1032, 418);
            this.ModificarEstacion.TabIndex = 1;
            this.ModificarEstacion.Text = "Modificar";
            this.ModificarEstacion.ToolTipText = "Muestra un listado de estaciones para su modificación";
            this.ModificarEstacion.UseVisualStyleBackColor = true;
            // 
            // txtEstacionesModBuscar
            // 
            this.txtEstacionesModBuscar.Location = new System.Drawing.Point(107, 27);
            this.txtEstacionesModBuscar.MaxLength = 99;
            this.txtEstacionesModBuscar.Name = "txtEstacionesModBuscar";
            this.txtEstacionesModBuscar.Size = new System.Drawing.Size(190, 21);
            this.txtEstacionesModBuscar.TabIndex = 23;
            this.txtEstacionesModBuscar.TextChanged += new System.EventHandler(this.buscarEstaciones);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 30);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(95, 15);
            this.label17.TabIndex = 22;
            this.label17.Text = "Buscar Estación";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(345, 327);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 30);
            this.label13.TabIndex = 21;
            this.label13.Text = "Distribución de Arribo \r\nde Personas al Andén";
            // 
            // cmbEstModFdp
            // 
            this.cmbEstModFdp.FormattingEnabled = true;
            this.cmbEstModFdp.Items.AddRange(new object[] {
            "Normal",
            "Gamma",
            "Poission"});
            this.cmbEstModFdp.Location = new System.Drawing.Point(499, 324);
            this.cmbEstModFdp.Name = "cmbEstModFdp";
            this.cmbEstModFdp.Size = new System.Drawing.Size(145, 23);
            this.cmbEstModFdp.TabIndex = 2;
            // 
            // clbModIncidentes
            // 
            this.clbModIncidentes.FormattingEnabled = true;
            this.clbModIncidentes.Location = new System.Drawing.Point(725, 43);
            this.clbModIncidentes.Name = "clbModIncidentes";
            this.clbModIncidentes.Size = new System.Drawing.Size(301, 356);
            this.clbModIncidentes.Sorted = true;
            this.clbModIncidentes.TabIndex = 20;
            // 
            // lstModEstaciones
            // 
            this.lstModEstaciones.DisplayMember = "Nombre";
            this.lstModEstaciones.FormattingEnabled = true;
            this.lstModEstaciones.ItemHeight = 15;
            this.lstModEstaciones.Location = new System.Drawing.Point(9, 58);
            this.lstModEstaciones.Name = "lstModEstaciones";
            this.lstModEstaciones.Size = new System.Drawing.Size(288, 349);
            this.lstModEstaciones.Sorted = true;
            this.lstModEstaciones.TabIndex = 11;
            this.lstModEstaciones.SelectedIndexChanged += new System.EventHandler(this.seleccionarEstacion);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(355, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Nombre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(722, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Incidentes";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtEstModMaximo);
            this.groupBox2.Controls.Add(this.txtEstModMinimo);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(348, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 141);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cantidad de Personas Esperando en Andén";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(245, 95);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 15);
            this.label16.TabIndex = 4;
            this.label16.Text = "Personas";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(245, 42);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 15);
            this.label15.TabIndex = 3;
            this.label15.Text = "Personas";
            // 
            // txtEstModMaximo
            // 
            this.txtEstModMaximo.Location = new System.Drawing.Point(76, 92);
            this.txtEstModMaximo.MaxLength = 9;
            this.txtEstModMaximo.Name = "txtEstModMaximo";
            this.txtEstModMaximo.Size = new System.Drawing.Size(147, 21);
            this.txtEstModMaximo.TabIndex = 1;
            // 
            // txtEstModMinimo
            // 
            this.txtEstModMinimo.Location = new System.Drawing.Point(76, 39);
            this.txtEstModMinimo.MaxLength = 9;
            this.txtEstModMinimo.Name = "txtEstModMinimo";
            this.txtEstModMinimo.Size = new System.Drawing.Size(147, 21);
            this.txtEstModMinimo.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Maximo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Minimo";
            // 
            // txtEstModNombre
            // 
            this.txtEstModNombre.Location = new System.Drawing.Point(418, 65);
            this.txtEstModNombre.MaxLength = 99;
            this.txtEstModNombre.Name = "txtEstModNombre";
            this.txtEstModNombre.Size = new System.Drawing.Size(226, 21);
            this.txtEstModNombre.TabIndex = 7;
            // 
            // EliminarEstacion
            // 
            this.EliminarEstacion.Controls.Add(this.label12);
            this.EliminarEstacion.Controls.Add(this.lstEstEliServicios);
            this.EliminarEstacion.Controls.Add(this.txtEstEliBuscar);
            this.EliminarEstacion.Controls.Add(this.label11);
            this.EliminarEstacion.Controls.Add(this.lstEliEstaciones);
            this.EliminarEstacion.Controls.Add(this.btnEstBorrar);
            this.EliminarEstacion.Location = new System.Drawing.Point(4, 24);
            this.EliminarEstacion.Name = "EliminarEstacion";
            this.EliminarEstacion.Padding = new System.Windows.Forms.Padding(3);
            this.EliminarEstacion.Size = new System.Drawing.Size(1032, 418);
            this.EliminarEstacion.TabIndex = 2;
            this.EliminarEstacion.Text = "Eliminar";
            this.EliminarEstacion.ToolTipText = "Muestra un listado de estaciones para su eliminación";
            this.EliminarEstacion.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(461, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 15);
            this.label12.TabIndex = 27;
            this.label12.Text = "Servicios Asociados";
            // 
            // lstEstEliServicios
            // 
            this.lstEstEliServicios.DisplayMember = "Nombre";
            this.lstEstEliServicios.FormattingEnabled = true;
            this.lstEstEliServicios.ItemHeight = 15;
            this.lstEstEliServicios.Location = new System.Drawing.Point(464, 55);
            this.lstEstEliServicios.Name = "lstEstEliServicios";
            this.lstEstEliServicios.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstEstEliServicios.Size = new System.Drawing.Size(279, 349);
            this.lstEstEliServicios.Sorted = true;
            this.lstEstEliServicios.TabIndex = 26;
            // 
            // txtEstEliBuscar
            // 
            this.txtEstEliBuscar.Location = new System.Drawing.Point(107, 28);
            this.txtEstEliBuscar.MaxLength = 99;
            this.txtEstEliBuscar.Name = "txtEstEliBuscar";
            this.txtEstEliBuscar.Size = new System.Drawing.Size(190, 21);
            this.txtEstEliBuscar.TabIndex = 25;
            this.txtEstEliBuscar.TextChanged += new System.EventHandler(this.buscarEstaciones);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 15);
            this.label11.TabIndex = 24;
            this.label11.Text = "Buscar Estación";
            // 
            // lstEliEstaciones
            // 
            this.lstEliEstaciones.DisplayMember = "Nombre";
            this.lstEliEstaciones.FormattingEnabled = true;
            this.lstEliEstaciones.ItemHeight = 15;
            this.lstEliEstaciones.Location = new System.Drawing.Point(9, 55);
            this.lstEliEstaciones.Name = "lstEliEstaciones";
            this.lstEliEstaciones.Size = new System.Drawing.Size(288, 349);
            this.lstEliEstaciones.Sorted = true;
            this.lstEliEstaciones.TabIndex = 14;
            this.lstEliEstaciones.SelectedIndexChanged += new System.EventHandler(this.serviciosAsociadas);
            // 
            // btnEstBorrar
            // 
            this.btnEstBorrar.Location = new System.Drawing.Point(303, 55);
            this.btnEstBorrar.Name = "btnEstBorrar";
            this.btnEstBorrar.Size = new System.Drawing.Size(112, 28);
            this.btnEstBorrar.TabIndex = 13;
            this.btnEstBorrar.Text = "Borrar Estación";
            this.btnEstBorrar.UseVisualStyleBackColor = true;
            this.btnEstBorrar.Click += new System.EventHandler(this.btnEstBorrar_Click);
            // 
            // pnlEstacion
            // 
            this.pnlEstacion.Controls.Add(this.tabControl1);
            this.pnlEstacion.Controls.Add(this.btnEstLimpiar);
            this.pnlEstacion.Controls.Add(this.btnEstAceptar);
            this.pnlEstacion.Controls.Add(this.btnEstCancelar);
            this.pnlEstacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlEstacion.Location = new System.Drawing.Point(12, 12);
            this.pnlEstacion.Name = "pnlEstacion";
            this.pnlEstacion.Size = new System.Drawing.Size(1068, 497);
            this.pnlEstacion.TabIndex = 5;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEstLimpiar;
        private System.Windows.Forms.Button btnEstCancelar;
        private System.Windows.Forms.Button btnEstAceptar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage CrearEstacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage ModificarEstacion;
        private System.Windows.Forms.ListBox lstModEstaciones;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbEstModFdp;
        private System.Windows.Forms.TextBox txtEstModMaximo;
        private System.Windows.Forms.TextBox txtEstModMinimo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEstModNombre;
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
        private System.Windows.Forms.ListBox lstEliEstaciones;
        private System.Windows.Forms.Button btnEstBorrar;
        private System.Windows.Forms.CheckedListBox clbIncidentes;
        private System.Windows.Forms.CheckedListBox clbModIncidentes;
        public System.Windows.Forms.Panel pnlEstacion;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtEstacionesModBuscar;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox lstEstEliServicios;
        private System.Windows.Forms.TextBox txtEstEliBuscar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEstCreBuscar;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ListBox lstCreEstaciones;
    }
}