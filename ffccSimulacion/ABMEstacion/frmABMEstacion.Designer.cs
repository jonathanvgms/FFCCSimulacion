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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEstCreNombre = new System.Windows.Forms.TextBox();
            this.clbIncidentes = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEstCreFdp = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEstCreMaximo = new System.Windows.Forms.TextBox();
            this.txtEstCreMinimo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtEstCreBuscar = new System.Windows.Forms.TextBox();
            this.lstCreEstaciones = new System.Windows.Forms.ListBox();
            this.label18 = new System.Windows.Forms.Label();
            this.ModificarEstacion = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.clbModIncidentes = new System.Windows.Forms.CheckedListBox();
            this.txtEstModNombre = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtEstModMaximo = new System.Windows.Forms.TextBox();
            this.txtEstModMinimo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbEstModFdp = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.lstModEstaciones = new System.Windows.Forms.ListBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtEstacionesModBuscar = new System.Windows.Forms.TextBox();
            this.EliminarEstacion = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.lstEstEliServicios = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.btnEstBorrar = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label24 = new System.Windows.Forms.Label();
            this.lstEliEstaciones = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEstEliBuscar = new System.Windows.Forms.TextBox();
            this.pnlEstacion = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.CrearEstacion.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.ModificarEstacion.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.EliminarEstacion.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.pnlEstacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEstLimpiar
            // 
            this.btnEstLimpiar.Location = new System.Drawing.Point(3, 545);
            this.btnEstLimpiar.Name = "btnEstLimpiar";
            this.btnEstLimpiar.Size = new System.Drawing.Size(90, 30);
            this.btnEstLimpiar.TabIndex = 3;
            this.btnEstLimpiar.Text = "Limpiar";
            this.btnEstLimpiar.UseVisualStyleBackColor = true;
            this.btnEstLimpiar.Click += new System.EventHandler(this.btnEstLimpiar_Click);
            // 
            // btnEstCancelar
            // 
            this.btnEstCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEstCancelar.Location = new System.Drawing.Point(1226, 545);
            this.btnEstCancelar.Name = "btnEstCancelar";
            this.btnEstCancelar.Size = new System.Drawing.Size(90, 30);
            this.btnEstCancelar.TabIndex = 3;
            this.btnEstCancelar.Text = "Cancelar";
            this.btnEstCancelar.UseVisualStyleBackColor = true;
            this.btnEstCancelar.Click += new System.EventHandler(this.btnEstCancelar_Click);
            // 
            // btnEstAceptar
            // 
            this.btnEstAceptar.Location = new System.Drawing.Point(1130, 545);
            this.btnEstAceptar.Name = "btnEstAceptar";
            this.btnEstAceptar.Size = new System.Drawing.Size(90, 30);
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
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.ShowToolTips = true;
            this.tabControl1.Size = new System.Drawing.Size(1317, 536);
            this.tabControl1.TabIndex = 4;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.seleccionarPestaña);
            // 
            // CrearEstacion
            // 
            this.CrearEstacion.Controls.Add(this.groupBox4);
            this.CrearEstacion.Controls.Add(this.groupBox3);
            this.CrearEstacion.Location = new System.Drawing.Point(4, 24);
            this.CrearEstacion.Name = "CrearEstacion";
            this.CrearEstacion.Padding = new System.Windows.Forms.Padding(3);
            this.CrearEstacion.Size = new System.Drawing.Size(1309, 508);
            this.CrearEstacion.TabIndex = 0;
            this.CrearEstacion.Text = "Nueva Estación";
            this.CrearEstacion.ToolTipText = "Crea un nueva estación";
            this.CrearEstacion.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtEstCreNombre);
            this.groupBox4.Controls.Add(this.clbIncidentes);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.cmbEstCreFdp);
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(16, 33);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(771, 458);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Estación";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nombre";
            // 
            // txtEstCreNombre
            // 
            this.txtEstCreNombre.Location = new System.Drawing.Point(108, 62);
            this.txtEstCreNombre.MaxLength = 99;
            this.txtEstCreNombre.Name = "txtEstCreNombre";
            this.txtEstCreNombre.Size = new System.Drawing.Size(226, 21);
            this.txtEstCreNombre.TabIndex = 18;
            // 
            // clbIncidentes
            // 
            this.clbIncidentes.FormattingEnabled = true;
            this.clbIncidentes.Location = new System.Drawing.Point(375, 63);
            this.clbIncidentes.Name = "clbIncidentes";
            this.clbIncidentes.Size = new System.Drawing.Size(375, 372);
            this.clbIncidentes.Sorted = true;
            this.clbIncidentes.TabIndex = 19;
            this.clbIncidentes.SelectedIndexChanged += new System.EventHandler(this.seleccionarIncidentes);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Incidentes existentes en el sistema";
            // 
            // cmbEstCreFdp
            // 
            this.cmbEstCreFdp.FormattingEnabled = true;
            this.cmbEstCreFdp.Items.AddRange(new object[] {
            "Normal"});
            this.cmbEstCreFdp.Location = new System.Drawing.Point(187, 323);
            this.cmbEstCreFdp.Name = "cmbEstCreFdp";
            this.cmbEstCreFdp.Size = new System.Drawing.Size(147, 23);
            this.cmbEstCreFdp.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtEstCreMaximo);
            this.groupBox1.Controls.Add(this.txtEstCreMinimo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(20, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 140);
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
            this.txtEstCreMaximo.Location = new System.Drawing.Point(88, 92);
            this.txtEstCreMaximo.MaxLength = 9;
            this.txtEstCreMaximo.Name = "txtEstCreMaximo";
            this.txtEstCreMaximo.Size = new System.Drawing.Size(151, 21);
            this.txtEstCreMaximo.TabIndex = 1;
            // 
            // txtEstCreMinimo
            // 
            this.txtEstCreMinimo.Location = new System.Drawing.Point(88, 39);
            this.txtEstCreMinimo.MaxLength = 9;
            this.txtEstCreMinimo.Name = "txtEstCreMinimo";
            this.txtEstCreMinimo.Size = new System.Drawing.Size(151, 21);
            this.txtEstCreMinimo.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Máximo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mínimo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Distribución de Arribo \r\nde Personas al Andén";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.txtEstCreBuscar);
            this.groupBox3.Controls.Add(this.lstCreEstaciones);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Location = new System.Drawing.Point(807, 33);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(480, 458);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar Estación";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(324, 65);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(138, 30);
            this.label19.TabIndex = 27;
            this.label19.Text = "Listado de estaciones\r\nexistentes en el sistema";
            // 
            // txtEstCreBuscar
            // 
            this.txtEstCreBuscar.Location = new System.Drawing.Point(84, 34);
            this.txtEstCreBuscar.MaxLength = 99;
            this.txtEstCreBuscar.Name = "txtEstCreBuscar";
            this.txtEstCreBuscar.Size = new System.Drawing.Size(220, 21);
            this.txtEstCreBuscar.TabIndex = 26;
            this.txtEstCreBuscar.TextChanged += new System.EventHandler(this.buscarEstaciones);
            // 
            // lstCreEstaciones
            // 
            this.lstCreEstaciones.DisplayMember = "Nombre";
            this.lstCreEstaciones.FormattingEnabled = true;
            this.lstCreEstaciones.ItemHeight = 15;
            this.lstCreEstaciones.Location = new System.Drawing.Point(18, 65);
            this.lstCreEstaciones.Name = "lstCreEstaciones";
            this.lstCreEstaciones.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstCreEstaciones.Size = new System.Drawing.Size(286, 364);
            this.lstCreEstaciones.Sorted = true;
            this.lstCreEstaciones.TabIndex = 24;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(15, 37);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 15);
            this.label18.TabIndex = 25;
            this.label18.Text = "Nombre";
            // 
            // ModificarEstacion
            // 
            this.ModificarEstacion.Controls.Add(this.groupBox6);
            this.ModificarEstacion.Controls.Add(this.groupBox5);
            this.ModificarEstacion.Location = new System.Drawing.Point(4, 24);
            this.ModificarEstacion.Name = "ModificarEstacion";
            this.ModificarEstacion.Padding = new System.Windows.Forms.Padding(3);
            this.ModificarEstacion.Size = new System.Drawing.Size(1309, 508);
            this.ModificarEstacion.TabIndex = 1;
            this.ModificarEstacion.Text = "       Modificar";
            this.ModificarEstacion.ToolTipText = "Muestra un listado de estaciones para su modificación";
            this.ModificarEstacion.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.clbModIncidentes);
            this.groupBox6.Controls.Add(this.txtEstModNombre);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.groupBox2);
            this.groupBox6.Controls.Add(this.cmbEstModFdp);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Location = new System.Drawing.Point(522, 27);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(765, 459);
            this.groupBox6.TabIndex = 25;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Estación";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(368, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "Incidentes existentes en el sistema";
            // 
            // clbModIncidentes
            // 
            this.clbModIncidentes.FormattingEnabled = true;
            this.clbModIncidentes.Location = new System.Drawing.Point(371, 59);
            this.clbModIncidentes.Name = "clbModIncidentes";
            this.clbModIncidentes.Size = new System.Drawing.Size(375, 372);
            this.clbModIncidentes.Sorted = true;
            this.clbModIncidentes.TabIndex = 20;
            this.clbModIncidentes.SelectedIndexChanged += new System.EventHandler(this.seleccionarIncidentes);
            // 
            // txtEstModNombre
            // 
            this.txtEstModNombre.Location = new System.Drawing.Point(114, 63);
            this.txtEstModNombre.MaxLength = 99;
            this.txtEstModNombre.Name = "txtEstModNombre";
            this.txtEstModNombre.Size = new System.Drawing.Size(226, 21);
            this.txtEstModNombre.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 325);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 30);
            this.label13.TabIndex = 21;
            this.label13.Text = "Distribución de Arribo \r\nde Personas al Andén";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtEstModMaximo);
            this.groupBox2.Controls.Add(this.txtEstModMinimo);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(22, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 141);
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
            this.txtEstModMaximo.Location = new System.Drawing.Point(92, 92);
            this.txtEstModMaximo.MaxLength = 9;
            this.txtEstModMaximo.Name = "txtEstModMaximo";
            this.txtEstModMaximo.Size = new System.Drawing.Size(147, 21);
            this.txtEstModMaximo.TabIndex = 1;
            // 
            // txtEstModMinimo
            // 
            this.txtEstModMinimo.Location = new System.Drawing.Point(92, 39);
            this.txtEstModMinimo.MaxLength = 9;
            this.txtEstModMinimo.Name = "txtEstModMinimo";
            this.txtEstModMinimo.Size = new System.Drawing.Size(147, 21);
            this.txtEstModMinimo.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Máximo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Mínimo";
            // 
            // cmbEstModFdp
            // 
            this.cmbEstModFdp.FormattingEnabled = true;
            this.cmbEstModFdp.Items.AddRange(new object[] {
            "Normal"});
            this.cmbEstModFdp.Location = new System.Drawing.Point(174, 332);
            this.cmbEstModFdp.Name = "cmbEstModFdp";
            this.cmbEstModFdp.Size = new System.Drawing.Size(166, 23);
            this.cmbEstModFdp.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Nombre";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.lstModEstaciones);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.txtEstacionesModBuscar);
            this.groupBox5.Location = new System.Drawing.Point(20, 27);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(480, 459);
            this.groupBox5.TabIndex = 24;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Buscar Estación a Modificar";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(323, 59);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(144, 75);
            this.label20.TabIndex = 28;
            this.label20.Text = "Listado de estaciones\r\nexistentes en el sistema, \r\nseleccione una estación\r\npara " +
    "modificar sus \r\natributos";
            // 
            // lstModEstaciones
            // 
            this.lstModEstaciones.DisplayMember = "Nombre";
            this.lstModEstaciones.FormattingEnabled = true;
            this.lstModEstaciones.ItemHeight = 15;
            this.lstModEstaciones.Location = new System.Drawing.Point(21, 59);
            this.lstModEstaciones.Name = "lstModEstaciones";
            this.lstModEstaciones.Size = new System.Drawing.Size(288, 379);
            this.lstModEstaciones.Sorted = true;
            this.lstModEstaciones.TabIndex = 11;
            this.lstModEstaciones.SelectedIndexChanged += new System.EventHandler(this.seleccionarEstacion);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(18, 31);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 15);
            this.label17.TabIndex = 22;
            this.label17.Text = "Nombre";
            // 
            // txtEstacionesModBuscar
            // 
            this.txtEstacionesModBuscar.Location = new System.Drawing.Point(119, 28);
            this.txtEstacionesModBuscar.MaxLength = 99;
            this.txtEstacionesModBuscar.Name = "txtEstacionesModBuscar";
            this.txtEstacionesModBuscar.Size = new System.Drawing.Size(190, 21);
            this.txtEstacionesModBuscar.TabIndex = 23;
            this.txtEstacionesModBuscar.TextChanged += new System.EventHandler(this.buscarEstaciones);
            // 
            // EliminarEstacion
            // 
            this.EliminarEstacion.Controls.Add(this.groupBox9);
            this.EliminarEstacion.Controls.Add(this.groupBox8);
            this.EliminarEstacion.Controls.Add(this.groupBox7);
            this.EliminarEstacion.Location = new System.Drawing.Point(4, 24);
            this.EliminarEstacion.Name = "EliminarEstacion";
            this.EliminarEstacion.Padding = new System.Windows.Forms.Padding(3);
            this.EliminarEstacion.Size = new System.Drawing.Size(1309, 508);
            this.EliminarEstacion.TabIndex = 2;
            this.EliminarEstacion.Text = "       Eliminar";
            this.EliminarEstacion.ToolTipText = "Muestra un listado de estaciones para su eliminación";
            this.EliminarEstacion.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.lstEstEliServicios);
            this.groupBox9.Controls.Add(this.label12);
            this.groupBox9.Location = new System.Drawing.Point(749, 168);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(321, 320);
            this.groupBox9.TabIndex = 30;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Servicios Asociados";
            // 
            // lstEstEliServicios
            // 
            this.lstEstEliServicios.DisplayMember = "Nombre";
            this.lstEstEliServicios.Enabled = false;
            this.lstEstEliServicios.FormattingEnabled = true;
            this.lstEstEliServicios.ItemHeight = 15;
            this.lstEstEliServicios.Location = new System.Drawing.Point(22, 74);
            this.lstEstEliServicios.Name = "lstEstEliServicios";
            this.lstEstEliServicios.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstEstEliServicios.Size = new System.Drawing.Size(279, 214);
            this.lstEstEliServicios.Sorted = true;
            this.lstEstEliServicios.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(224, 30);
            this.label12.TabIndex = 27;
            this.label12.Text = "Muestra los servicios a los\r\nque pertenece la estación seleccionada";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label23);
            this.groupBox8.Controls.Add(this.btnEstBorrar);
            this.groupBox8.Location = new System.Drawing.Point(749, 25);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(321, 124);
            this.groupBox8.TabIndex = 29;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Eliminar Estación";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(18, 33);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(285, 30);
            this.label23.TabIndex = 25;
            this.label23.Text = "Elimina la estación del sistema, solo se podrán \r\neliminar aquellas que no perten" +
    "ezcan a un servicio";
            // 
            // btnEstBorrar
            // 
            this.btnEstBorrar.Image = global::ffccSimulacion.Properties.Resources.bin_icon_1488050992;
            this.btnEstBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstBorrar.Location = new System.Drawing.Point(151, 78);
            this.btnEstBorrar.Name = "btnEstBorrar";
            this.btnEstBorrar.Size = new System.Drawing.Size(150, 30);
            this.btnEstBorrar.TabIndex = 13;
            this.btnEstBorrar.Text = "Eliminar";
            this.btnEstBorrar.UseVisualStyleBackColor = true;
            this.btnEstBorrar.Click += new System.EventHandler(this.btnEstBorrar_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label24);
            this.groupBox7.Controls.Add(this.lstEliEstaciones);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Controls.Add(this.txtEstEliBuscar);
            this.groupBox7.Location = new System.Drawing.Point(225, 25);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(502, 463);
            this.groupBox7.TabIndex = 28;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Buscar Estación a Eliminar";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(349, 57);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(144, 60);
            this.label24.TabIndex = 26;
            this.label24.Text = "Listado de estaciones\r\nexistentes en el sistema, \r\nseleccione una estación\r\npara " +
    "eliminarla.";
            // 
            // lstEliEstaciones
            // 
            this.lstEliEstaciones.DisplayMember = "Nombre";
            this.lstEliEstaciones.FormattingEnabled = true;
            this.lstEliEstaciones.ItemHeight = 15;
            this.lstEliEstaciones.Location = new System.Drawing.Point(23, 57);
            this.lstEliEstaciones.Name = "lstEliEstaciones";
            this.lstEliEstaciones.Size = new System.Drawing.Size(320, 379);
            this.lstEliEstaciones.Sorted = true;
            this.lstEliEstaciones.TabIndex = 14;
            this.lstEliEstaciones.SelectedIndexChanged += new System.EventHandler(this.serviciosAsociadas);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 15);
            this.label11.TabIndex = 24;
            this.label11.Text = "Nombre";
            // 
            // txtEstEliBuscar
            // 
            this.txtEstEliBuscar.Location = new System.Drawing.Point(108, 30);
            this.txtEstEliBuscar.MaxLength = 99;
            this.txtEstEliBuscar.Name = "txtEstEliBuscar";
            this.txtEstEliBuscar.Size = new System.Drawing.Size(235, 21);
            this.txtEstEliBuscar.TabIndex = 25;
            this.txtEstEliBuscar.TextChanged += new System.EventHandler(this.buscarEstaciones);
            // 
            // pnlEstacion
            // 
            this.pnlEstacion.BackColor = System.Drawing.SystemColors.Control;
            this.pnlEstacion.Controls.Add(this.tabControl1);
            this.pnlEstacion.Controls.Add(this.btnEstLimpiar);
            this.pnlEstacion.Controls.Add(this.btnEstAceptar);
            this.pnlEstacion.Controls.Add(this.btnEstCancelar);
            this.pnlEstacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlEstacion.Location = new System.Drawing.Point(12, 12);
            this.pnlEstacion.Name = "pnlEstacion";
            this.pnlEstacion.Size = new System.Drawing.Size(1325, 582);
            this.pnlEstacion.TabIndex = 5;
            // 
            // frmABMEstacion
            // 
            this.AcceptButton = this.btnEstAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnEstCancelar;
            this.ClientSize = new System.Drawing.Size(1347, 606);
            this.Controls.Add(this.pnlEstacion);
            this.Name = "frmABMEstacion";
            this.Text = "Estación";
            this.tabControl1.ResumeLayout(false);
            this.CrearEstacion.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ModificarEstacion.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.EliminarEstacion.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
    }
}