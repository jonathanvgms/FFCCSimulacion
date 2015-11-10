namespace ffccSimulacion.ABMIncidente
{
    partial class frmABMIncidente
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
            this.cmbModProb = new System.Windows.Forms.ComboBox();
            this.txtModNombre = new System.Windows.Forms.TextBox();
            this.txtModDes = new System.Windows.Forms.TextBox();
            this.txtModDem = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCrear = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.lstIncidenteCrear = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIncCreBuscar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtincCreDes = new System.Windows.Forms.TextBox();
            this.txtIncCreNom = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbmIncCrePro = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbIncCreTiem = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tabModificar = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.lstIncMod = new System.Windows.Forms.ListBox();
            this.txtIncModBuscar = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.lblModMensajeError = new System.Windows.Forms.Label();
            this.tabEliminar = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lstIncEliEstaciones = new System.Windows.Forms.ListBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.btnEliminarIncidente = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lstIncEli = new System.Windows.Forms.ListBox();
            this.txtIncEliBuscar = new System.Windows.Forms.TextBox();
            this.pnlInicidente = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabCrear.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabModificar.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabEliminar.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.pnlInicidente.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Descripción";
            // 
            // cmbModProb
            // 
            this.cmbModProb.AutoCompleteCustomSource.AddRange(new string[] {
            "0%",
            "10%",
            "20%",
            "30%",
            "40%",
            "50%",
            "60%",
            "70%",
            "80%",
            "90%",
            "100%"});
            this.cmbModProb.FormattingEnabled = true;
            this.cmbModProb.Items.AddRange(new object[] {
            "0",
            "2",
            "5",
            "7",
            "10",
            "15",
            "20",
            "25",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100"});
            this.cmbModProb.Location = new System.Drawing.Point(198, 320);
            this.cmbModProb.Name = "cmbModProb";
            this.cmbModProb.Size = new System.Drawing.Size(111, 23);
            this.cmbModProb.TabIndex = 1;
            // 
            // txtModNombre
            // 
            this.txtModNombre.Location = new System.Drawing.Point(110, 27);
            this.txtModNombre.MaxLength = 99;
            this.txtModNombre.Name = "txtModNombre";
            this.txtModNombre.Size = new System.Drawing.Size(296, 21);
            this.txtModNombre.TabIndex = 2;
            // 
            // txtModDes
            // 
            this.txtModDes.Location = new System.Drawing.Point(110, 71);
            this.txtModDes.MaxLength = 499;
            this.txtModDes.Multiline = true;
            this.txtModDes.Name = "txtModDes";
            this.txtModDes.Size = new System.Drawing.Size(296, 207);
            this.txtModDes.TabIndex = 2;
            // 
            // txtModDem
            // 
            this.txtModDem.Location = new System.Drawing.Point(198, 385);
            this.txtModDem.MaxLength = 9;
            this.txtModDem.Name = "txtModDem";
            this.txtModDem.Size = new System.Drawing.Size(111, 21);
            this.txtModDem.TabIndex = 2;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(3, 536);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(90, 30);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(904, 536);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 30);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(808, 536);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(90, 30);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCrear);
            this.tabControl1.Controls.Add(this.tabModificar);
            this.tabControl1.Controls.Add(this.tabEliminar);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.ShowToolTips = true;
            this.tabControl1.Size = new System.Drawing.Size(991, 527);
            this.tabControl1.TabIndex = 4;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.selecionarPestaña);
            // 
            // tabCrear
            // 
            this.tabCrear.Controls.Add(this.groupBox1);
            this.tabCrear.Controls.Add(this.label5);
            this.tabCrear.Controls.Add(this.label6);
            this.tabCrear.Controls.Add(this.txtincCreDes);
            this.tabCrear.Controls.Add(this.txtIncCreNom);
            this.tabCrear.Controls.Add(this.groupBox2);
            this.tabCrear.Location = new System.Drawing.Point(4, 24);
            this.tabCrear.Name = "tabCrear";
            this.tabCrear.Padding = new System.Windows.Forms.Padding(3);
            this.tabCrear.Size = new System.Drawing.Size(983, 499);
            this.tabCrear.TabIndex = 0;
            this.tabCrear.Text = "Nuevo Incidente";
            this.tabCrear.ToolTipText = "Crea un nuevo incidente que no aparezca en el listado";
            this.tabCrear.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.lstIncidenteCrear);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtIncCreBuscar);
            this.groupBox1.Location = new System.Drawing.Point(465, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 438);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Incidente";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(333, 53);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(138, 30);
            this.label19.TabIndex = 18;
            this.label19.Text = "Listado de incidentes \r\nexistentes en el sistema";
            // 
            // lstIncidenteCrear
            // 
            this.lstIncidenteCrear.DisplayMember = "Nombre";
            this.lstIncidenteCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstIncidenteCrear.FormattingEnabled = true;
            this.lstIncidenteCrear.ItemHeight = 15;
            this.lstIncidenteCrear.Location = new System.Drawing.Point(22, 53);
            this.lstIncidenteCrear.Name = "lstIncidenteCrear";
            this.lstIncidenteCrear.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstIncidenteCrear.Size = new System.Drawing.Size(291, 364);
            this.lstIncidenteCrear.Sorted = true;
            this.lstIncidenteCrear.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 15);
            this.label10.TabIndex = 17;
            this.label10.Text = "Nombre";
            // 
            // txtIncCreBuscar
            // 
            this.txtIncCreBuscar.Location = new System.Drawing.Point(119, 25);
            this.txtIncCreBuscar.MaxLength = 99;
            this.txtIncCreBuscar.Name = "txtIncCreBuscar";
            this.txtIncCreBuscar.Size = new System.Drawing.Size(194, 21);
            this.txtIncCreBuscar.TabIndex = 16;
            this.txtIncCreBuscar.TextChanged += new System.EventHandler(this.buscarIncidente);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Descripción";
            // 
            // txtincCreDes
            // 
            this.txtincCreDes.Location = new System.Drawing.Point(136, 103);
            this.txtincCreDes.MaxLength = 499;
            this.txtincCreDes.Multiline = true;
            this.txtincCreDes.Name = "txtincCreDes";
            this.txtincCreDes.Size = new System.Drawing.Size(280, 184);
            this.txtincCreDes.TabIndex = 9;
            // 
            // txtIncCreNom
            // 
            this.txtIncCreNom.Location = new System.Drawing.Point(136, 60);
            this.txtIncCreNom.MaxLength = 99;
            this.txtIncCreNom.Name = "txtIncCreNom";
            this.txtIncCreNom.Size = new System.Drawing.Size(280, 21);
            this.txtIncCreNom.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbmIncCrePro);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtbIncCreTiem);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(19, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(419, 441);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Incidente";
            // 
            // cbmIncCrePro
            // 
            this.cbmIncCrePro.AutoCompleteCustomSource.AddRange(new string[] {
            "0%",
            "10%",
            "20%",
            "30%",
            "40%",
            "50%",
            "60%",
            "70%",
            "80%",
            "90%",
            "100%"});
            this.cbmIncCrePro.FormattingEnabled = true;
            this.cbmIncCrePro.Items.AddRange(new object[] {
            "0",
            "2",
            "5",
            "7",
            "10",
            "15",
            "20",
            "25",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100"});
            this.cbmIncCrePro.Location = new System.Drawing.Point(177, 295);
            this.cbmIncCrePro.Name = "cbmIncCrePro";
            this.cbmIncCrePro.Size = new System.Drawing.Size(113, 23);
            this.cbmIncCrePro.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 30);
            this.label7.TabIndex = 5;
            this.label7.Text = "Porcentaje de Ocurencia \r\ndel Incidente\r\n";
            // 
            // txtbIncCreTiem
            // 
            this.txtbIncCreTiem.Location = new System.Drawing.Point(177, 384);
            this.txtbIncCreTiem.MaxLength = 9;
            this.txtbIncCreTiem.Name = "txtbIncCreTiem";
            this.txtbIncCreTiem.Size = new System.Drawing.Size(113, 21);
            this.txtbIncCreTiem.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(296, 298);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 15);
            this.label12.TabIndex = 14;
            this.label12.Text = "%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 375);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 30);
            this.label8.TabIndex = 6;
            this.label8.Text = "Tiempo de Demora \r\ndel Servicio";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(296, 387);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 15);
            this.label13.TabIndex = 15;
            this.label13.Text = "Minutos";
            // 
            // tabModificar
            // 
            this.tabModificar.Controls.Add(this.groupBox5);
            this.tabModificar.Controls.Add(this.groupBox4);
            this.tabModificar.Controls.Add(this.lblModMensajeError);
            this.tabModificar.Location = new System.Drawing.Point(4, 24);
            this.tabModificar.Name = "tabModificar";
            this.tabModificar.Padding = new System.Windows.Forms.Padding(3);
            this.tabModificar.Size = new System.Drawing.Size(983, 499);
            this.tabModificar.TabIndex = 1;
            this.tabModificar.Text = "       Modificar";
            this.tabModificar.ToolTipText = "Muestra un listado de incidentes para su modificación";
            this.tabModificar.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.txtModDes);
            this.groupBox5.Controls.Add(this.txtModNombre);
            this.groupBox5.Controls.Add(this.cmbModProb);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.txtModDem);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Location = new System.Drawing.Point(525, 30);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(430, 447);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Incidente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Minutos";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(23, 376);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(114, 30);
            this.label15.TabIndex = 8;
            this.label15.Text = "Tiempo de Demora\r\ndel Servcio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "%";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(23, 310);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(146, 30);
            this.label14.TabIndex = 7;
            this.label14.Text = "Porcentaje de Ocurrencia\r\ndel Incidente";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.lstIncMod);
            this.groupBox4.Controls.Add(this.txtIncModBuscar);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Location = new System.Drawing.Point(17, 30);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(485, 447);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Buscar Incidente a Modificar";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(335, 58);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(144, 75);
            this.label20.TabIndex = 20;
            this.label20.Text = "Listado de incidentes \r\nexistentes en el sistema, \r\nseleccione un incidente \r\npar" +
    "a modificar sus \r\natributos";
            // 
            // lstIncMod
            // 
            this.lstIncMod.DisplayMember = "Nombre";
            this.lstIncMod.FormattingEnabled = true;
            this.lstIncMod.ItemHeight = 15;
            this.lstIncMod.Location = new System.Drawing.Point(22, 58);
            this.lstIncMod.Name = "lstIncMod";
            this.lstIncMod.Size = new System.Drawing.Size(294, 364);
            this.lstIncMod.Sorted = true;
            this.lstIncMod.TabIndex = 3;
            this.lstIncMod.SelectedIndexChanged += new System.EventHandler(this.seleccionarIncidente);
            // 
            // txtIncModBuscar
            // 
            this.txtIncModBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIncModBuscar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtIncModBuscar.Location = new System.Drawing.Point(117, 29);
            this.txtIncModBuscar.MaxLength = 99;
            this.txtIncModBuscar.Name = "txtIncModBuscar";
            this.txtIncModBuscar.Size = new System.Drawing.Size(199, 21);
            this.txtIncModBuscar.TabIndex = 18;
            this.txtIncModBuscar.TextChanged += new System.EventHandler(this.buscarIncidente);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(19, 30);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 15);
            this.label16.TabIndex = 19;
            this.label16.Text = "Nombre";
            // 
            // lblModMensajeError
            // 
            this.lblModMensajeError.AutoSize = true;
            this.lblModMensajeError.Location = new System.Drawing.Point(334, 229);
            this.lblModMensajeError.Name = "lblModMensajeError";
            this.lblModMensajeError.Size = new System.Drawing.Size(0, 15);
            this.lblModMensajeError.TabIndex = 6;
            // 
            // tabEliminar
            // 
            this.tabEliminar.Controls.Add(this.groupBox9);
            this.tabEliminar.Controls.Add(this.groupBox8);
            this.tabEliminar.Controls.Add(this.groupBox7);
            this.tabEliminar.Location = new System.Drawing.Point(4, 24);
            this.tabEliminar.Name = "tabEliminar";
            this.tabEliminar.Padding = new System.Windows.Forms.Padding(3);
            this.tabEliminar.Size = new System.Drawing.Size(983, 499);
            this.tabEliminar.TabIndex = 2;
            this.tabEliminar.Text = "       Eliminar";
            this.tabEliminar.ToolTipText = "Muestra un listado que incidentes para su eliminación";
            this.tabEliminar.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.label9);
            this.groupBox9.Controls.Add(this.lstIncEliEstaciones);
            this.groupBox9.Location = new System.Drawing.Point(580, 171);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(335, 311);
            this.groupBox9.TabIndex = 26;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Listado de Estaciones";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(222, 30);
            this.label9.TabIndex = 23;
            this.label9.Text = "Muestra aquellas estaciones en donde \r\nel incidente se ha seleccionado";
            // 
            // lstIncEliEstaciones
            // 
            this.lstIncEliEstaciones.DisplayMember = "Nombre";
            this.lstIncEliEstaciones.Enabled = false;
            this.lstIncEliEstaciones.FormattingEnabled = true;
            this.lstIncEliEstaciones.ItemHeight = 15;
            this.lstIncEliEstaciones.Location = new System.Drawing.Point(23, 67);
            this.lstIncEliEstaciones.Name = "lstIncEliEstaciones";
            this.lstIncEliEstaciones.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstIncEliEstaciones.Size = new System.Drawing.Size(290, 229);
            this.lstIncEliEstaciones.Sorted = true;
            this.lstIncEliEstaciones.TabIndex = 22;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label23);
            this.groupBox8.Controls.Add(this.btnEliminarIncidente);
            this.groupBox8.Location = new System.Drawing.Point(580, 27);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(335, 123);
            this.groupBox8.TabIndex = 25;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Eliminar Incidente";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(23, 26);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(297, 30);
            this.label23.TabIndex = 24;
            this.label23.Text = "Elimina el incidente del sistema, solo se podrán \r\neliminar aquellos que no perte" +
    "nezcan a una estación";
            // 
            // btnEliminarIncidente
            // 
            this.btnEliminarIncidente.Image = global::ffccSimulacion.Properties.Resources.bin_icon_1488050992;
            this.btnEliminarIncidente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarIncidente.Location = new System.Drawing.Point(165, 75);
            this.btnEliminarIncidente.Name = "btnEliminarIncidente";
            this.btnEliminarIncidente.Size = new System.Drawing.Size(150, 30);
            this.btnEliminarIncidente.TabIndex = 7;
            this.btnEliminarIncidente.Text = "Eliminar";
            this.btnEliminarIncidente.UseVisualStyleBackColor = true;
            this.btnEliminarIncidente.Click += new System.EventHandler(this.btnEliminarIncidente_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label24);
            this.groupBox7.Controls.Add(this.label17);
            this.groupBox7.Controls.Add(this.lstIncEli);
            this.groupBox7.Controls.Add(this.txtIncEliBuscar);
            this.groupBox7.Location = new System.Drawing.Point(62, 27);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(494, 455);
            this.groupBox7.TabIndex = 24;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Buscar Incidente a Eliminar";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(342, 75);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(144, 60);
            this.label24.TabIndex = 22;
            this.label24.Text = "Listado de incidentes \r\nexistentes en el sistema, \r\nseleccione un incidente \r\npar" +
    "a eliminarlo.";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(19, 41);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 15);
            this.label17.TabIndex = 21;
            this.label17.Text = "Nombre";
            // 
            // lstIncEli
            // 
            this.lstIncEli.DisplayMember = "Nombre";
            this.lstIncEli.FormattingEnabled = true;
            this.lstIncEli.ItemHeight = 15;
            this.lstIncEli.Location = new System.Drawing.Point(22, 75);
            this.lstIncEli.Name = "lstIncEli";
            this.lstIncEli.Size = new System.Drawing.Size(307, 364);
            this.lstIncEli.Sorted = true;
            this.lstIncEli.TabIndex = 6;
            this.lstIncEli.SelectedIndexChanged += new System.EventHandler(this.estacionesAsociadas);
            // 
            // txtIncEliBuscar
            // 
            this.txtIncEliBuscar.Location = new System.Drawing.Point(107, 38);
            this.txtIncEliBuscar.MaxLength = 99;
            this.txtIncEliBuscar.Name = "txtIncEliBuscar";
            this.txtIncEliBuscar.Size = new System.Drawing.Size(222, 21);
            this.txtIncEliBuscar.TabIndex = 20;
            this.txtIncEliBuscar.TextChanged += new System.EventHandler(this.buscarIncidente);
            // 
            // pnlInicidente
            // 
            this.pnlInicidente.BackColor = System.Drawing.SystemColors.Control;
            this.pnlInicidente.Controls.Add(this.tabControl1);
            this.pnlInicidente.Controls.Add(this.btnLimpiar);
            this.pnlInicidente.Controls.Add(this.btnAceptar);
            this.pnlInicidente.Controls.Add(this.btnCancelar);
            this.pnlInicidente.Location = new System.Drawing.Point(12, 12);
            this.pnlInicidente.Name = "pnlInicidente";
            this.pnlInicidente.Size = new System.Drawing.Size(999, 571);
            this.pnlInicidente.TabIndex = 5;
            // 
            // frmABMIncidente
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(1020, 596);
            this.Controls.Add(this.pnlInicidente);
            this.Name = "frmABMIncidente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Incidente";
            this.tabControl1.ResumeLayout(false);
            this.tabCrear.ResumeLayout(false);
            this.tabCrear.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabModificar.ResumeLayout(false);
            this.tabModificar.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabEliminar.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.pnlInicidente.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbModProb;
        private System.Windows.Forms.TextBox txtModNombre;
        private System.Windows.Forms.TextBox txtModDes;
        private System.Windows.Forms.TextBox txtModDem;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCrear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbIncCreTiem;
        private System.Windows.Forms.ComboBox cbmIncCrePro;
        private System.Windows.Forms.TextBox txtincCreDes;
        private System.Windows.Forms.TextBox txtIncCreNom;
        private System.Windows.Forms.TabPage tabModificar;
        private System.Windows.Forms.ListBox lstIncMod;
        private System.Windows.Forms.TabPage tabEliminar;
        private System.Windows.Forms.Button btnEliminarIncidente;
        private System.Windows.Forms.ListBox lstIncEli;
        public System.Windows.Forms.Panel pnlInicidente;
        private System.Windows.Forms.Label lblModMensajeError;
        private System.Windows.Forms.ListBox lstIncidenteCrear;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtIncModBuscar;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtIncEliBuscar;
        private System.Windows.Forms.ListBox lstIncEliEstaciones;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIncCreBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label24;
    }
}