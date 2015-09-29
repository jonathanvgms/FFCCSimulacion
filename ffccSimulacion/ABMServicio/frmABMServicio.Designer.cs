namespace ffccSimulacion.ABMServicio
{
    partial class frmABMServicio
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCrearServicio = new System.Windows.Forms.TabPage();
            this.dgvRelacionesCrear = new System.Windows.Forms.DataGridView();
            this.txtEstacionOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEstacionDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtId_EstacionOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtId_EstacionDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbxEstacionesDestinoCrear = new System.Windows.Forms.ListBox();
            this.lbxEstacionesOrigenCrear = new System.Windows.Forms.ListBox();
            this.txtVelocidadRelacionCrear = new System.Windows.Forms.TextBox();
            this.txtDistanciaRelacionCrear = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnAgregarFormacion = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.clbxFormacionesCrear = new System.Windows.Forms.CheckedListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNombreServicio = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnAgregarRelacionTabCrear = new System.Windows.Forms.Button();
            this.btnBorrarRelacionTabCrear = new System.Windows.Forms.Button();
            this.btnAgregarEstacion = new System.Windows.Forms.Button();
            this.tabModificarServicio = new System.Windows.Forms.TabPage();
            this.dgvRelacionesMod = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lbxEstacionesDestinoMod = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbxEstacionesOrigenMod = new System.Windows.Forms.ListBox();
            this.button12 = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.clbxFormacionesMod = new System.Windows.Forms.CheckedListBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lbxServiciosModificar = new System.Windows.Forms.ListBox();
            this.tabEliminarServicio = new System.Windows.Forms.TabPage();
            this.btnBorrarServicio = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.lbxServiciosEliminar = new System.Windows.Forms.ListBox();
            this.pnlServicio = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxEsParadaCrear = new System.Windows.Forms.CheckBox();
            this.cbxEsParadaMod = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabCrearServicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelacionesCrear)).BeginInit();
            this.tabModificarServicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelacionesMod)).BeginInit();
            this.tabEliminarServicio.SuspendLayout();
            this.pnlServicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(362, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Estaciones Origen";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(336, 466);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Agregar Estacion";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(498, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Agregar Relación";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(498, 209);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Borrar Relación";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(14, 546);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(1074, 546);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(993, 546);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCrearServicio);
            this.tabControl1.Controls.Add(this.tabModificarServicio);
            this.tabControl1.Controls.Add(this.tabEliminarServicio);
            this.tabControl1.Location = new System.Drawing.Point(14, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1137, 528);
            this.tabControl1.TabIndex = 10;
            // 
            // tabCrearServicio
            // 
            this.tabCrearServicio.Controls.Add(this.cbxEsParadaCrear);
            this.tabCrearServicio.Controls.Add(this.label4);
            this.tabCrearServicio.Controls.Add(this.dgvRelacionesCrear);
            this.tabCrearServicio.Controls.Add(this.lbxEstacionesDestinoCrear);
            this.tabCrearServicio.Controls.Add(this.lbxEstacionesOrigenCrear);
            this.tabCrearServicio.Controls.Add(this.txtVelocidadRelacionCrear);
            this.tabCrearServicio.Controls.Add(this.txtDistanciaRelacionCrear);
            this.tabCrearServicio.Controls.Add(this.label20);
            this.tabCrearServicio.Controls.Add(this.label25);
            this.tabCrearServicio.Controls.Add(this.label15);
            this.tabCrearServicio.Controls.Add(this.btnAgregarFormacion);
            this.tabCrearServicio.Controls.Add(this.label11);
            this.tabCrearServicio.Controls.Add(this.clbxFormacionesCrear);
            this.tabCrearServicio.Controls.Add(this.label12);
            this.tabCrearServicio.Controls.Add(this.label13);
            this.tabCrearServicio.Controls.Add(this.txtNombreServicio);
            this.tabCrearServicio.Controls.Add(this.label14);
            this.tabCrearServicio.Controls.Add(this.btnAgregarRelacionTabCrear);
            this.tabCrearServicio.Controls.Add(this.btnBorrarRelacionTabCrear);
            this.tabCrearServicio.Controls.Add(this.btnAgregarEstacion);
            this.tabCrearServicio.Location = new System.Drawing.Point(4, 22);
            this.tabCrearServicio.Name = "tabCrearServicio";
            this.tabCrearServicio.Padding = new System.Windows.Forms.Padding(3);
            this.tabCrearServicio.Size = new System.Drawing.Size(1129, 502);
            this.tabCrearServicio.TabIndex = 0;
            this.tabCrearServicio.Text = "Crear";
            this.tabCrearServicio.UseVisualStyleBackColor = true;
            // 
            // dgvRelacionesCrear
            // 
            this.dgvRelacionesCrear.AllowUserToAddRows = false;
            this.dgvRelacionesCrear.AllowUserToDeleteRows = false;
            this.dgvRelacionesCrear.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelacionesCrear.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtEstacionOrigen,
            this.txtEstacionDestino,
            this.txtId_EstacionOrigen,
            this.txtId_EstacionDestino});
            this.dgvRelacionesCrear.Location = new System.Drawing.Point(576, 64);
            this.dgvRelacionesCrear.MultiSelect = false;
            this.dgvRelacionesCrear.Name = "dgvRelacionesCrear";
            this.dgvRelacionesCrear.ReadOnly = true;
            this.dgvRelacionesCrear.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRelacionesCrear.Size = new System.Drawing.Size(244, 379);
            this.dgvRelacionesCrear.TabIndex = 35;
            this.dgvRelacionesCrear.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRelacionesCrear_CellContentClick);
            // 
            // txtEstacionOrigen
            // 
            this.txtEstacionOrigen.HeaderText = "Origen";
            this.txtEstacionOrigen.Name = "txtEstacionOrigen";
            this.txtEstacionOrigen.ReadOnly = true;
            // 
            // txtEstacionDestino
            // 
            this.txtEstacionDestino.HeaderText = "Destino";
            this.txtEstacionDestino.Name = "txtEstacionDestino";
            this.txtEstacionDestino.ReadOnly = true;
            // 
            // txtId_EstacionOrigen
            // 
            this.txtId_EstacionOrigen.HeaderText = "txtId_EstacionOrigen";
            this.txtId_EstacionOrigen.Name = "txtId_EstacionOrigen";
            this.txtId_EstacionOrigen.ReadOnly = true;
            this.txtId_EstacionOrigen.Visible = false;
            // 
            // txtId_EstacionDestino
            // 
            this.txtId_EstacionDestino.HeaderText = "txtId_EstacionDestino";
            this.txtId_EstacionDestino.Name = "txtId_EstacionDestino";
            this.txtId_EstacionDestino.ReadOnly = true;
            this.txtId_EstacionDestino.Visible = false;
            // 
            // lbxEstacionesDestinoCrear
            // 
            this.lbxEstacionesDestinoCrear.DisplayMember = "Nombre";
            this.lbxEstacionesDestinoCrear.FormattingEnabled = true;
            this.lbxEstacionesDestinoCrear.Location = new System.Drawing.Point(243, 64);
            this.lbxEstacionesDestinoCrear.Name = "lbxEstacionesDestinoCrear";
            this.lbxEstacionesDestinoCrear.Size = new System.Drawing.Size(216, 225);
            this.lbxEstacionesDestinoCrear.TabIndex = 34;
            // 
            // lbxEstacionesOrigenCrear
            // 
            this.lbxEstacionesOrigenCrear.DisplayMember = "Nombre";
            this.lbxEstacionesOrigenCrear.FormattingEnabled = true;
            this.lbxEstacionesOrigenCrear.Location = new System.Drawing.Point(18, 64);
            this.lbxEstacionesOrigenCrear.Name = "lbxEstacionesOrigenCrear";
            this.lbxEstacionesOrigenCrear.Size = new System.Drawing.Size(216, 225);
            this.lbxEstacionesOrigenCrear.TabIndex = 33;
            // 
            // txtVelocidadRelacionCrear
            // 
            this.txtVelocidadRelacionCrear.Location = new System.Drawing.Point(293, 369);
            this.txtVelocidadRelacionCrear.Name = "txtVelocidadRelacionCrear";
            this.txtVelocidadRelacionCrear.Size = new System.Drawing.Size(100, 20);
            this.txtVelocidadRelacionCrear.TabIndex = 31;
            // 
            // txtDistanciaRelacionCrear
            // 
            this.txtDistanciaRelacionCrear.Location = new System.Drawing.Point(293, 337);
            this.txtDistanciaRelacionCrear.Name = "txtDistanciaRelacionCrear";
            this.txtDistanciaRelacionCrear.Size = new System.Drawing.Size(100, 20);
            this.txtDistanciaRelacionCrear.TabIndex = 32;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(139, 369);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(129, 13);
            this.label20.TabIndex = 29;
            this.label20.Text = "Velocidad de la formación";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(139, 337);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(148, 13);
            this.label25.TabIndex = 30;
            this.label25.Text = "Distancia entre las estaciones";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 48);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "Estaciones Origen";
            // 
            // btnAgregarFormacion
            // 
            this.btnAgregarFormacion.Location = new System.Drawing.Point(826, 449);
            this.btnAgregarFormacion.Name = "btnAgregarFormacion";
            this.btnAgregarFormacion.Size = new System.Drawing.Size(111, 23);
            this.btnAgregarFormacion.TabIndex = 11;
            this.btnAgregarFormacion.Text = "Agregar Formación";
            this.btnAgregarFormacion.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(823, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Formaciones";
            // 
            // clbxFormacionesCrear
            // 
            this.clbxFormacionesCrear.FormattingEnabled = true;
            this.clbxFormacionesCrear.Location = new System.Drawing.Point(826, 64);
            this.clbxFormacionesCrear.Name = "clbxFormacionesCrear";
            this.clbxFormacionesCrear.Size = new System.Drawing.Size(284, 379);
            this.clbxFormacionesCrear.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(573, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Estaciones Relacionadas";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Nombre";
            // 
            // txtNombreServicio
            // 
            this.txtNombreServicio.Location = new System.Drawing.Point(66, 18);
            this.txtNombreServicio.Name = "txtNombreServicio";
            this.txtNombreServicio.Size = new System.Drawing.Size(203, 20);
            this.txtNombreServicio.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(240, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "Estaciones Destino";
            // 
            // btnAgregarRelacionTabCrear
            // 
            this.btnAgregarRelacionTabCrear.Location = new System.Drawing.Point(465, 142);
            this.btnAgregarRelacionTabCrear.Name = "btnAgregarRelacionTabCrear";
            this.btnAgregarRelacionTabCrear.Size = new System.Drawing.Size(106, 23);
            this.btnAgregarRelacionTabCrear.TabIndex = 21;
            this.btnAgregarRelacionTabCrear.Text = "Agregar Relación";
            this.btnAgregarRelacionTabCrear.UseVisualStyleBackColor = true;
            this.btnAgregarRelacionTabCrear.Click += new System.EventHandler(this.btnAgregarRelacionTabCrear_Click);
            // 
            // btnBorrarRelacionTabCrear
            // 
            this.btnBorrarRelacionTabCrear.Location = new System.Drawing.Point(465, 190);
            this.btnBorrarRelacionTabCrear.Name = "btnBorrarRelacionTabCrear";
            this.btnBorrarRelacionTabCrear.Size = new System.Drawing.Size(106, 23);
            this.btnBorrarRelacionTabCrear.TabIndex = 22;
            this.btnBorrarRelacionTabCrear.Text = "Borrar Relación";
            this.btnBorrarRelacionTabCrear.UseVisualStyleBackColor = true;
            this.btnBorrarRelacionTabCrear.Click += new System.EventHandler(this.btnBorrarRelacionTabCrear_Click);
            // 
            // btnAgregarEstacion
            // 
            this.btnAgregarEstacion.Location = new System.Drawing.Point(184, 295);
            this.btnAgregarEstacion.Name = "btnAgregarEstacion";
            this.btnAgregarEstacion.Size = new System.Drawing.Size(107, 23);
            this.btnAgregarEstacion.TabIndex = 20;
            this.btnAgregarEstacion.Text = "Agregar Estación";
            this.btnAgregarEstacion.UseVisualStyleBackColor = true;
            // 
            // tabModificarServicio
            // 
            this.tabModificarServicio.Controls.Add(this.label6);
            this.tabModificarServicio.Controls.Add(this.label7);
            this.tabModificarServicio.Controls.Add(this.cbxEsParadaMod);
            this.tabModificarServicio.Controls.Add(this.label5);
            this.tabModificarServicio.Controls.Add(this.dgvRelacionesMod);
            this.tabModificarServicio.Controls.Add(this.textBox5);
            this.tabModificarServicio.Controls.Add(this.textBox4);
            this.tabModificarServicio.Controls.Add(this.lbxEstacionesDestinoMod);
            this.tabModificarServicio.Controls.Add(this.label3);
            this.tabModificarServicio.Controls.Add(this.lbxEstacionesOrigenMod);
            this.tabModificarServicio.Controls.Add(this.button12);
            this.tabModificarServicio.Controls.Add(this.label23);
            this.tabModificarServicio.Controls.Add(this.clbxFormacionesMod);
            this.tabModificarServicio.Controls.Add(this.label22);
            this.tabModificarServicio.Controls.Add(this.label21);
            this.tabModificarServicio.Controls.Add(this.lbxServiciosModificar);
            this.tabModificarServicio.Controls.Add(this.label1);
            this.tabModificarServicio.Controls.Add(this.textBox1);
            this.tabModificarServicio.Controls.Add(this.label2);
            this.tabModificarServicio.Controls.Add(this.button3);
            this.tabModificarServicio.Controls.Add(this.button2);
            this.tabModificarServicio.Controls.Add(this.button1);
            this.tabModificarServicio.Location = new System.Drawing.Point(4, 22);
            this.tabModificarServicio.Name = "tabModificarServicio";
            this.tabModificarServicio.Padding = new System.Windows.Forms.Padding(3);
            this.tabModificarServicio.Size = new System.Drawing.Size(1129, 502);
            this.tabModificarServicio.TabIndex = 1;
            this.tabModificarServicio.Text = "Modificar";
            this.tabModificarServicio.UseVisualStyleBackColor = true;
            // 
            // dgvRelacionesMod
            // 
            this.dgvRelacionesMod.AllowUserToAddRows = false;
            this.dgvRelacionesMod.AllowUserToDeleteRows = false;
            this.dgvRelacionesMod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelacionesMod.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvRelacionesMod.Location = new System.Drawing.Point(599, 83);
            this.dgvRelacionesMod.MultiSelect = false;
            this.dgvRelacionesMod.Name = "dgvRelacionesMod";
            this.dgvRelacionesMod.ReadOnly = true;
            this.dgvRelacionesMod.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRelacionesMod.Size = new System.Drawing.Size(244, 293);
            this.dgvRelacionesMod.TabIndex = 41;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Origen";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Destino";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "txtId_EstacionOrigen";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "txtId_EstacionDestino";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(689, 424);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(104, 20);
            this.textBox5.TabIndex = 39;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(689, 395);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(104, 20);
            this.textBox4.TabIndex = 40;
            // 
            // lbxEstacionesDestinoMod
            // 
            this.lbxEstacionesDestinoMod.DisplayMember = "Nombre";
            this.lbxEstacionesDestinoMod.FormattingEnabled = true;
            this.lbxEstacionesDestinoMod.Location = new System.Drawing.Point(284, 279);
            this.lbxEstacionesDestinoMod.Name = "lbxEstacionesDestinoMod";
            this.lbxEstacionesDestinoMod.Size = new System.Drawing.Size(208, 173);
            this.lbxEstacionesDestinoMod.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Estaciones Destino";
            // 
            // lbxEstacionesOrigenMod
            // 
            this.lbxEstacionesOrigenMod.DisplayMember = "Nombre";
            this.lbxEstacionesOrigenMod.FormattingEnabled = true;
            this.lbxEstacionesOrigenMod.Location = new System.Drawing.Point(284, 84);
            this.lbxEstacionesOrigenMod.Name = "lbxEstacionesOrigenMod";
            this.lbxEstacionesOrigenMod.Size = new System.Drawing.Size(208, 173);
            this.lbxEstacionesOrigenMod.TabIndex = 14;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(852, 453);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(111, 23);
            this.button12.TabIndex = 13;
            this.button12.Text = "Crear Formación";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(849, 67);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(67, 13);
            this.label23.TabIndex = 12;
            this.label23.Text = "Formaciones";
            // 
            // clbxFormacionesMod
            // 
            this.clbxFormacionesMod.FormattingEnabled = true;
            this.clbxFormacionesMod.Location = new System.Drawing.Point(852, 83);
            this.clbxFormacionesMod.Name = "clbxFormacionesMod";
            this.clbxFormacionesMod.Size = new System.Drawing.Size(270, 364);
            this.clbxFormacionesMod.TabIndex = 11;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(598, 67);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(127, 13);
            this.label22.TabIndex = 10;
            this.label22.Text = "Estaciones Relacionadas";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(7, 24);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(102, 13);
            this.label21.TabIndex = 8;
            this.label21.Text = "Listado de Servicios";
            // 
            // lbxServiciosModificar
            // 
            this.lbxServiciosModificar.DisplayMember = "Nombre";
            this.lbxServiciosModificar.FormattingEnabled = true;
            this.lbxServiciosModificar.Location = new System.Drawing.Point(6, 43);
            this.lbxServiciosModificar.Name = "lbxServiciosModificar";
            this.lbxServiciosModificar.Size = new System.Drawing.Size(267, 446);
            this.lbxServiciosModificar.TabIndex = 7;
            // 
            // tabEliminarServicio
            // 
            this.tabEliminarServicio.Controls.Add(this.btnBorrarServicio);
            this.tabEliminarServicio.Controls.Add(this.label26);
            this.tabEliminarServicio.Controls.Add(this.lbxServiciosEliminar);
            this.tabEliminarServicio.Location = new System.Drawing.Point(4, 22);
            this.tabEliminarServicio.Name = "tabEliminarServicio";
            this.tabEliminarServicio.Padding = new System.Windows.Forms.Padding(3);
            this.tabEliminarServicio.Size = new System.Drawing.Size(1129, 502);
            this.tabEliminarServicio.TabIndex = 2;
            this.tabEliminarServicio.Text = "Eliminar";
            this.tabEliminarServicio.UseVisualStyleBackColor = true;
            // 
            // btnBorrarServicio
            // 
            this.btnBorrarServicio.Location = new System.Drawing.Point(708, 26);
            this.btnBorrarServicio.Name = "btnBorrarServicio";
            this.btnBorrarServicio.Size = new System.Drawing.Size(95, 23);
            this.btnBorrarServicio.TabIndex = 12;
            this.btnBorrarServicio.Text = "Borrar Servicio";
            this.btnBorrarServicio.UseVisualStyleBackColor = true;
            this.btnBorrarServicio.Click += new System.EventHandler(this.btnBorrarServicio_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(378, 10);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(102, 13);
            this.label26.TabIndex = 11;
            this.label26.Text = "Listado de Servicios";
            // 
            // lbxServiciosEliminar
            // 
            this.lbxServiciosEliminar.DisplayMember = "Nombre";
            this.lbxServiciosEliminar.FormattingEnabled = true;
            this.lbxServiciosEliminar.Location = new System.Drawing.Point(381, 26);
            this.lbxServiciosEliminar.Name = "lbxServiciosEliminar";
            this.lbxServiciosEliminar.Size = new System.Drawing.Size(321, 459);
            this.lbxServiciosEliminar.TabIndex = 10;
            // 
            // pnlServicio
            // 
            this.pnlServicio.Controls.Add(this.tabControl1);
            this.pnlServicio.Controls.Add(this.btnLimpiar);
            this.pnlServicio.Controls.Add(this.btnAceptar);
            this.pnlServicio.Controls.Add(this.btnCancelar);
            this.pnlServicio.Location = new System.Drawing.Point(100, 62);
            this.pnlServicio.Name = "pnlServicio";
            this.pnlServicio.Size = new System.Drawing.Size(1164, 584);
            this.pnlServicio.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 402);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Estacion Destino es parada";
            // 
            // cbxEsParadaCrear
            // 
            this.cbxEsParadaCrear.AutoSize = true;
            this.cbxEsParadaCrear.Location = new System.Drawing.Point(293, 402);
            this.cbxEsParadaCrear.Name = "cbxEsParadaCrear";
            this.cbxEsParadaCrear.Size = new System.Drawing.Size(15, 14);
            this.cbxEsParadaCrear.TabIndex = 37;
            this.cbxEsParadaCrear.UseVisualStyleBackColor = true;
            // 
            // cbxEsParadaMod
            // 
            this.cbxEsParadaMod.AutoSize = true;
            this.cbxEsParadaMod.Location = new System.Drawing.Point(689, 453);
            this.cbxEsParadaMod.Name = "cbxEsParadaMod";
            this.cbxEsParadaMod.Size = new System.Drawing.Size(15, 14);
            this.cbxEsParadaMod.TabIndex = 43;
            this.cbxEsParadaMod.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(523, 453);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Estacion Destino es parada";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(523, 424);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Velocidad de la formación";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(523, 395);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Distancia entre las estaciones";
            // 
            // frmABMServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 732);
            this.Controls.Add(this.pnlServicio);
            this.Name = "frmABMServicio";
            this.Text = "Servicio";
            this.tabControl1.ResumeLayout(false);
            this.tabCrearServicio.ResumeLayout(false);
            this.tabCrearServicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelacionesCrear)).EndInit();
            this.tabModificarServicio.ResumeLayout(false);
            this.tabModificarServicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelacionesMod)).EndInit();
            this.tabEliminarServicio.ResumeLayout(false);
            this.tabEliminarServicio.PerformLayout();
            this.pnlServicio.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCrearServicio;
        private System.Windows.Forms.TabPage tabModificarServicio;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ListBox lbxServiciosModificar;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.CheckedListBox clbxFormacionesMod;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckedListBox clbxFormacionesCrear;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtNombreServicio;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnAgregarRelacionTabCrear;
        private System.Windows.Forms.Button btnBorrarRelacionTabCrear;
        private System.Windows.Forms.Button btnAgregarEstacion;
        private System.Windows.Forms.TabPage tabEliminarServicio;
        private System.Windows.Forms.Button btnBorrarServicio;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ListBox lbxServiciosEliminar;
        private System.Windows.Forms.Button btnAgregarFormacion;
        private System.Windows.Forms.Button button12;
        public System.Windows.Forms.Panel pnlServicio;
        private System.Windows.Forms.TextBox txtVelocidadRelacionCrear;
        private System.Windows.Forms.TextBox txtDistanciaRelacionCrear;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ListBox lbxEstacionesDestinoCrear;
        private System.Windows.Forms.ListBox lbxEstacionesOrigenCrear;
        private System.Windows.Forms.DataGridView dgvRelacionesCrear;
        private System.Windows.Forms.ListBox lbxEstacionesDestinoMod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbxEstacionesOrigenMod;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtEstacionOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtEstacionDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtId_EstacionOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtId_EstacionDestino;
        private System.Windows.Forms.DataGridView dgvRelacionesMod;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.CheckBox cbxEsParadaCrear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbxEsParadaMod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}