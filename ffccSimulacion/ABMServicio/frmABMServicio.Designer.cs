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
            this.txtNombreServicioMod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregarRelacionMod = new System.Windows.Forms.Button();
            this.btnBorrarRelacionMod = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCrearServicio = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxEsParadaCrear = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.label11 = new System.Windows.Forms.Label();
            this.clbxFormacionesCrear = new System.Windows.Forms.CheckedListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNombreServicio = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnAgregarRelacionTabCrear = new System.Windows.Forms.Button();
            this.btnBorrarRelacionTabCrear = new System.Windows.Forms.Button();
            this.tabModificarServicio = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxEsParadaMod = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvRelacionesMod = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_EstacionOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_EstacionDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtVelocidadRelacionMod = new System.Windows.Forms.TextBox();
            this.txtDistanciaRelacionMod = new System.Windows.Forms.TextBox();
            this.lbxEstacionesDestinoMod = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbxEstacionesOrigenMod = new System.Windows.Forms.ListBox();
            this.label23 = new System.Windows.Forms.Label();
            this.clbxFormacionesMod = new System.Windows.Forms.CheckedListBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lbxServiciosModificar = new System.Windows.Forms.ListBox();
            this.tabEliminarServicio = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.lbxTrazasAsociadasEliminar = new System.Windows.Forms.ListBox();
            this.btnBorrarServicio = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.lbxServiciosEliminar = new System.Windows.Forms.ListBox();
            this.pnlServicio = new System.Windows.Forms.Panel();
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
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txtNombreServicioMod
            // 
            this.txtNombreServicioMod.Location = new System.Drawing.Point(362, 40);
            this.txtNombreServicioMod.MaxLength = 99;
            this.txtNombreServicioMod.Name = "txtNombreServicioMod";
            this.txtNombreServicioMod.Size = new System.Drawing.Size(203, 21);
            this.txtNombreServicioMod.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Estaciones Origen";
            // 
            // btnAgregarRelacionMod
            // 
            this.btnAgregarRelacionMod.Location = new System.Drawing.Point(498, 153);
            this.btnAgregarRelacionMod.Name = "btnAgregarRelacionMod";
            this.btnAgregarRelacionMod.Size = new System.Drawing.Size(97, 42);
            this.btnAgregarRelacionMod.TabIndex = 6;
            this.btnAgregarRelacionMod.Text = "Agregar Relación";
            this.btnAgregarRelacionMod.UseVisualStyleBackColor = true;
            this.btnAgregarRelacionMod.Click += new System.EventHandler(this.btnAgregarRelacionMod_Click);
            // 
            // btnBorrarRelacionMod
            // 
            this.btnBorrarRelacionMod.Location = new System.Drawing.Point(498, 278);
            this.btnBorrarRelacionMod.Name = "btnBorrarRelacionMod";
            this.btnBorrarRelacionMod.Size = new System.Drawing.Size(97, 44);
            this.btnBorrarRelacionMod.TabIndex = 6;
            this.btnBorrarRelacionMod.Text = "Borrar Relación";
            this.btnBorrarRelacionMod.UseVisualStyleBackColor = true;
            this.btnBorrarRelacionMod.Click += new System.EventHandler(this.btnBorrarRelacionMod_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(14, 546);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 25);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(1074, 546);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 25);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(993, 546);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 25);
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
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.seleccionarPestaña);
            // 
            // tabCrearServicio
            // 
            this.tabCrearServicio.Controls.Add(this.label9);
            this.tabCrearServicio.Controls.Add(this.label8);
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
            this.tabCrearServicio.Controls.Add(this.label11);
            this.tabCrearServicio.Controls.Add(this.clbxFormacionesCrear);
            this.tabCrearServicio.Controls.Add(this.label12);
            this.tabCrearServicio.Controls.Add(this.label13);
            this.tabCrearServicio.Controls.Add(this.txtNombreServicio);
            this.tabCrearServicio.Controls.Add(this.label14);
            this.tabCrearServicio.Controls.Add(this.btnAgregarRelacionTabCrear);
            this.tabCrearServicio.Controls.Add(this.btnBorrarRelacionTabCrear);
            this.tabCrearServicio.Location = new System.Drawing.Point(4, 24);
            this.tabCrearServicio.Name = "tabCrearServicio";
            this.tabCrearServicio.Padding = new System.Windows.Forms.Padding(3);
            this.tabCrearServicio.Size = new System.Drawing.Size(1129, 500);
            this.tabCrearServicio.TabIndex = 0;
            this.tabCrearServicio.Text = "Nuevo Servicio";
            this.tabCrearServicio.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(400, 430);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 15);
            this.label9.TabIndex = 39;
            this.label9.Text = "( km / h )";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(400, 401);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 15);
            this.label8.TabIndex = 38;
            this.label8.Text = "( km )";
            // 
            // cbxEsParadaCrear
            // 
            this.cbxEsParadaCrear.AutoSize = true;
            this.cbxEsParadaCrear.Location = new System.Drawing.Point(294, 463);
            this.cbxEsParadaCrear.Name = "cbxEsParadaCrear";
            this.cbxEsParadaCrear.Size = new System.Drawing.Size(15, 14);
            this.cbxEsParadaCrear.TabIndex = 37;
            this.cbxEsParadaCrear.UseVisualStyleBackColor = true;
            this.cbxEsParadaCrear.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 463);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 15);
            this.label4.TabIndex = 36;
            this.label4.Text = "Estacion Destino es parada";
            this.label4.Visible = false;
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
            this.dgvRelacionesCrear.Size = new System.Drawing.Size(244, 420);
            this.dgvRelacionesCrear.TabIndex = 35;
            this.dgvRelacionesCrear.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRelacionesCrear_CellContentClick);
            this.dgvRelacionesCrear.Leave += new System.EventHandler(this.dgvRelacionesCrear_Leave);
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
            this.lbxEstacionesDestinoCrear.ItemHeight = 15;
            this.lbxEstacionesDestinoCrear.Location = new System.Drawing.Point(243, 64);
            this.lbxEstacionesDestinoCrear.Name = "lbxEstacionesDestinoCrear";
            this.lbxEstacionesDestinoCrear.Size = new System.Drawing.Size(216, 304);
            this.lbxEstacionesDestinoCrear.Sorted = true;
            this.lbxEstacionesDestinoCrear.TabIndex = 34;
            // 
            // lbxEstacionesOrigenCrear
            // 
            this.lbxEstacionesOrigenCrear.DisplayMember = "Nombre";
            this.lbxEstacionesOrigenCrear.FormattingEnabled = true;
            this.lbxEstacionesOrigenCrear.ItemHeight = 15;
            this.lbxEstacionesOrigenCrear.Location = new System.Drawing.Point(18, 64);
            this.lbxEstacionesOrigenCrear.Name = "lbxEstacionesOrigenCrear";
            this.lbxEstacionesOrigenCrear.Size = new System.Drawing.Size(216, 304);
            this.lbxEstacionesOrigenCrear.Sorted = true;
            this.lbxEstacionesOrigenCrear.TabIndex = 33;
            // 
            // txtVelocidadRelacionCrear
            // 
            this.txtVelocidadRelacionCrear.Location = new System.Drawing.Point(294, 430);
            this.txtVelocidadRelacionCrear.MaxLength = 9;
            this.txtVelocidadRelacionCrear.Name = "txtVelocidadRelacionCrear";
            this.txtVelocidadRelacionCrear.Size = new System.Drawing.Size(100, 21);
            this.txtVelocidadRelacionCrear.TabIndex = 31;
            // 
            // txtDistanciaRelacionCrear
            // 
            this.txtDistanciaRelacionCrear.Location = new System.Drawing.Point(294, 398);
            this.txtDistanciaRelacionCrear.MaxLength = 9;
            this.txtDistanciaRelacionCrear.Name = "txtDistanciaRelacionCrear";
            this.txtDistanciaRelacionCrear.Size = new System.Drawing.Size(100, 21);
            this.txtDistanciaRelacionCrear.TabIndex = 32;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(110, 430);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(149, 15);
            this.label20.TabIndex = 29;
            this.label20.Text = "Velocidad de la formación";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(110, 398);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(170, 15);
            this.label25.TabIndex = 30;
            this.label25.Text = "Distancia entre las estaciones";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 48);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(107, 15);
            this.label15.TabIndex = 27;
            this.label15.Text = "Estaciones Origen";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(823, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 15);
            this.label11.TabIndex = 25;
            this.label11.Text = "Formaciones";
            // 
            // clbxFormacionesCrear
            // 
            this.clbxFormacionesCrear.FormattingEnabled = true;
            this.clbxFormacionesCrear.Location = new System.Drawing.Point(826, 64);
            this.clbxFormacionesCrear.Name = "clbxFormacionesCrear";
            this.clbxFormacionesCrear.Size = new System.Drawing.Size(284, 420);
            this.clbxFormacionesCrear.Sorted = true;
            this.clbxFormacionesCrear.TabIndex = 24;
            this.clbxFormacionesCrear.SelectedIndexChanged += new System.EventHandler(this.seleccionarFormaciones);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(573, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(146, 15);
            this.label12.TabIndex = 23;
            this.label12.Text = "Estaciones Relacionadas";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 15);
            this.label13.TabIndex = 13;
            this.label13.Text = "Nombre";
            // 
            // txtNombreServicio
            // 
            this.txtNombreServicio.Location = new System.Drawing.Point(89, 18);
            this.txtNombreServicio.MaxLength = 99;
            this.txtNombreServicio.Name = "txtNombreServicio";
            this.txtNombreServicio.Size = new System.Drawing.Size(203, 21);
            this.txtNombreServicio.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(240, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(112, 15);
            this.label14.TabIndex = 15;
            this.label14.Text = "Estaciones Destino";
            // 
            // btnAgregarRelacionTabCrear
            // 
            this.btnAgregarRelacionTabCrear.Location = new System.Drawing.Point(465, 118);
            this.btnAgregarRelacionTabCrear.Name = "btnAgregarRelacionTabCrear";
            this.btnAgregarRelacionTabCrear.Size = new System.Drawing.Size(106, 38);
            this.btnAgregarRelacionTabCrear.TabIndex = 21;
            this.btnAgregarRelacionTabCrear.Text = "Agregar Relación";
            this.btnAgregarRelacionTabCrear.UseVisualStyleBackColor = true;
            this.btnAgregarRelacionTabCrear.Click += new System.EventHandler(this.btnAgregarRelacionTabCrear_Click);
            // 
            // btnBorrarRelacionTabCrear
            // 
            this.btnBorrarRelacionTabCrear.Location = new System.Drawing.Point(465, 191);
            this.btnBorrarRelacionTabCrear.Name = "btnBorrarRelacionTabCrear";
            this.btnBorrarRelacionTabCrear.Size = new System.Drawing.Size(106, 31);
            this.btnBorrarRelacionTabCrear.TabIndex = 22;
            this.btnBorrarRelacionTabCrear.Text = "Borrar Relación";
            this.btnBorrarRelacionTabCrear.UseVisualStyleBackColor = true;
            this.btnBorrarRelacionTabCrear.Click += new System.EventHandler(this.btnBorrarRelacionTabCrear_Click);
            // 
            // tabModificarServicio
            // 
            this.tabModificarServicio.Controls.Add(this.label10);
            this.tabModificarServicio.Controls.Add(this.label16);
            this.tabModificarServicio.Controls.Add(this.label6);
            this.tabModificarServicio.Controls.Add(this.label7);
            this.tabModificarServicio.Controls.Add(this.cbxEsParadaMod);
            this.tabModificarServicio.Controls.Add(this.label5);
            this.tabModificarServicio.Controls.Add(this.dgvRelacionesMod);
            this.tabModificarServicio.Controls.Add(this.txtVelocidadRelacionMod);
            this.tabModificarServicio.Controls.Add(this.txtDistanciaRelacionMod);
            this.tabModificarServicio.Controls.Add(this.lbxEstacionesDestinoMod);
            this.tabModificarServicio.Controls.Add(this.label3);
            this.tabModificarServicio.Controls.Add(this.lbxEstacionesOrigenMod);
            this.tabModificarServicio.Controls.Add(this.label23);
            this.tabModificarServicio.Controls.Add(this.clbxFormacionesMod);
            this.tabModificarServicio.Controls.Add(this.label22);
            this.tabModificarServicio.Controls.Add(this.label21);
            this.tabModificarServicio.Controls.Add(this.lbxServiciosModificar);
            this.tabModificarServicio.Controls.Add(this.label1);
            this.tabModificarServicio.Controls.Add(this.txtNombreServicioMod);
            this.tabModificarServicio.Controls.Add(this.label2);
            this.tabModificarServicio.Controls.Add(this.btnBorrarRelacionMod);
            this.tabModificarServicio.Controls.Add(this.btnAgregarRelacionMod);
            this.tabModificarServicio.Location = new System.Drawing.Point(4, 24);
            this.tabModificarServicio.Name = "tabModificarServicio";
            this.tabModificarServicio.Padding = new System.Windows.Forms.Padding(3);
            this.tabModificarServicio.Size = new System.Drawing.Size(1129, 500);
            this.tabModificarServicio.TabIndex = 1;
            this.tabModificarServicio.Text = "Modificar";
            this.tabModificarServicio.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(793, 427);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 15);
            this.label10.TabIndex = 47;
            this.label10.Text = "( km / h )";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(793, 398);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 15);
            this.label16.TabIndex = 46;
            this.label16.Text = "( km )";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(507, 424);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 15);
            this.label6.TabIndex = 44;
            this.label6.Text = "Velocidad de la formación";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(507, 395);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 15);
            this.label7.TabIndex = 45;
            this.label7.Text = "Distancia entre las estaciones";
            // 
            // cbxEsParadaMod
            // 
            this.cbxEsParadaMod.AutoSize = true;
            this.cbxEsParadaMod.Location = new System.Drawing.Point(683, 453);
            this.cbxEsParadaMod.Name = "cbxEsParadaMod";
            this.cbxEsParadaMod.Size = new System.Drawing.Size(15, 14);
            this.cbxEsParadaMod.TabIndex = 43;
            this.cbxEsParadaMod.UseVisualStyleBackColor = true;
            this.cbxEsParadaMod.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(507, 453);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 15);
            this.label5.TabIndex = 42;
            this.label5.Text = "Estacion Destino es parada";
            this.label5.Visible = false;
            // 
            // dgvRelacionesMod
            // 
            this.dgvRelacionesMod.AllowUserToAddRows = false;
            this.dgvRelacionesMod.AllowUserToDeleteRows = false;
            this.dgvRelacionesMod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelacionesMod.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Id_EstacionOrigen,
            this.Id_EstacionDestino});
            this.dgvRelacionesMod.Location = new System.Drawing.Point(599, 83);
            this.dgvRelacionesMod.MultiSelect = false;
            this.dgvRelacionesMod.Name = "dgvRelacionesMod";
            this.dgvRelacionesMod.ReadOnly = true;
            this.dgvRelacionesMod.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRelacionesMod.Size = new System.Drawing.Size(244, 293);
            this.dgvRelacionesMod.TabIndex = 41;
            this.dgvRelacionesMod.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRelacionesMod_CellContentClick);
            this.dgvRelacionesMod.Leave += new System.EventHandler(this.dgvRelacionesMod_Leave);
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
            // Id_EstacionOrigen
            // 
            this.Id_EstacionOrigen.HeaderText = "Id_EstacionOrigen";
            this.Id_EstacionOrigen.Name = "Id_EstacionOrigen";
            this.Id_EstacionOrigen.ReadOnly = true;
            this.Id_EstacionOrigen.Visible = false;
            // 
            // Id_EstacionDestino
            // 
            this.Id_EstacionDestino.HeaderText = "Id_EstacionDestino";
            this.Id_EstacionDestino.Name = "Id_EstacionDestino";
            this.Id_EstacionDestino.ReadOnly = true;
            this.Id_EstacionDestino.Visible = false;
            // 
            // txtVelocidadRelacionMod
            // 
            this.txtVelocidadRelacionMod.Location = new System.Drawing.Point(683, 424);
            this.txtVelocidadRelacionMod.MaxLength = 9;
            this.txtVelocidadRelacionMod.Name = "txtVelocidadRelacionMod";
            this.txtVelocidadRelacionMod.Size = new System.Drawing.Size(104, 21);
            this.txtVelocidadRelacionMod.TabIndex = 39;
            // 
            // txtDistanciaRelacionMod
            // 
            this.txtDistanciaRelacionMod.Location = new System.Drawing.Point(683, 395);
            this.txtDistanciaRelacionMod.MaxLength = 9;
            this.txtDistanciaRelacionMod.Name = "txtDistanciaRelacionMod";
            this.txtDistanciaRelacionMod.Size = new System.Drawing.Size(104, 21);
            this.txtDistanciaRelacionMod.TabIndex = 40;
            // 
            // lbxEstacionesDestinoMod
            // 
            this.lbxEstacionesDestinoMod.DisplayMember = "Nombre";
            this.lbxEstacionesDestinoMod.FormattingEnabled = true;
            this.lbxEstacionesDestinoMod.ItemHeight = 15;
            this.lbxEstacionesDestinoMod.Location = new System.Drawing.Point(284, 278);
            this.lbxEstacionesDestinoMod.Name = "lbxEstacionesDestinoMod";
            this.lbxEstacionesDestinoMod.Size = new System.Drawing.Size(208, 169);
            this.lbxEstacionesDestinoMod.Sorted = true;
            this.lbxEstacionesDestinoMod.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Estaciones Destino";
            // 
            // lbxEstacionesOrigenMod
            // 
            this.lbxEstacionesOrigenMod.DisplayMember = "Nombre";
            this.lbxEstacionesOrigenMod.FormattingEnabled = true;
            this.lbxEstacionesOrigenMod.ItemHeight = 15;
            this.lbxEstacionesOrigenMod.Location = new System.Drawing.Point(284, 83);
            this.lbxEstacionesOrigenMod.Name = "lbxEstacionesOrigenMod";
            this.lbxEstacionesOrigenMod.Size = new System.Drawing.Size(208, 169);
            this.lbxEstacionesOrigenMod.Sorted = true;
            this.lbxEstacionesOrigenMod.TabIndex = 14;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(849, 67);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(79, 15);
            this.label23.TabIndex = 12;
            this.label23.Text = "Formaciones";
            // 
            // clbxFormacionesMod
            // 
            this.clbxFormacionesMod.FormattingEnabled = true;
            this.clbxFormacionesMod.Location = new System.Drawing.Point(852, 83);
            this.clbxFormacionesMod.Name = "clbxFormacionesMod";
            this.clbxFormacionesMod.Size = new System.Drawing.Size(270, 356);
            this.clbxFormacionesMod.Sorted = true;
            this.clbxFormacionesMod.TabIndex = 11;
            this.clbxFormacionesMod.SelectedIndexChanged += new System.EventHandler(this.seleccionarFormaciones);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(598, 67);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(146, 15);
            this.label22.TabIndex = 10;
            this.label22.Text = "Estaciones Relacionadas";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(7, 24);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(116, 15);
            this.label21.TabIndex = 8;
            this.label21.Text = "Listado de Servicios";
            // 
            // lbxServiciosModificar
            // 
            this.lbxServiciosModificar.DisplayMember = "Nombre";
            this.lbxServiciosModificar.FormattingEnabled = true;
            this.lbxServiciosModificar.ItemHeight = 15;
            this.lbxServiciosModificar.Location = new System.Drawing.Point(6, 43);
            this.lbxServiciosModificar.Name = "lbxServiciosModificar";
            this.lbxServiciosModificar.Size = new System.Drawing.Size(267, 439);
            this.lbxServiciosModificar.Sorted = true;
            this.lbxServiciosModificar.TabIndex = 7;
            this.lbxServiciosModificar.SelectedIndexChanged += new System.EventHandler(this.lbxServiciosModificar_SelectedIndexChanged);
            // 
            // tabEliminarServicio
            // 
            this.tabEliminarServicio.Controls.Add(this.label17);
            this.tabEliminarServicio.Controls.Add(this.lbxTrazasAsociadasEliminar);
            this.tabEliminarServicio.Controls.Add(this.btnBorrarServicio);
            this.tabEliminarServicio.Controls.Add(this.label26);
            this.tabEliminarServicio.Controls.Add(this.lbxServiciosEliminar);
            this.tabEliminarServicio.Location = new System.Drawing.Point(4, 24);
            this.tabEliminarServicio.Name = "tabEliminarServicio";
            this.tabEliminarServicio.Padding = new System.Windows.Forms.Padding(3);
            this.tabEliminarServicio.Size = new System.Drawing.Size(1129, 500);
            this.tabEliminarServicio.TabIndex = 2;
            this.tabEliminarServicio.Text = "Eliminar";
            this.tabEliminarServicio.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(612, 10);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(103, 15);
            this.label17.TabIndex = 14;
            this.label17.Text = "Trazas Asociadas";
            // 
            // lbxTrazasAsociadasEliminar
            // 
            this.lbxTrazasAsociadasEliminar.DisplayMember = "Nombre";
            this.lbxTrazasAsociadasEliminar.Enabled = false;
            this.lbxTrazasAsociadasEliminar.FormattingEnabled = true;
            this.lbxTrazasAsociadasEliminar.ItemHeight = 15;
            this.lbxTrazasAsociadasEliminar.Location = new System.Drawing.Point(612, 26);
            this.lbxTrazasAsociadasEliminar.Name = "lbxTrazasAsociadasEliminar";
            this.lbxTrazasAsociadasEliminar.Size = new System.Drawing.Size(339, 454);
            this.lbxTrazasAsociadasEliminar.Sorted = true;
            this.lbxTrazasAsociadasEliminar.TabIndex = 13;
            // 
            // btnBorrarServicio
            // 
            this.btnBorrarServicio.Location = new System.Drawing.Point(510, 26);
            this.btnBorrarServicio.Name = "btnBorrarServicio";
            this.btnBorrarServicio.Size = new System.Drawing.Size(95, 25);
            this.btnBorrarServicio.TabIndex = 12;
            this.btnBorrarServicio.Text = "Borrar Servicio";
            this.btnBorrarServicio.UseVisualStyleBackColor = true;
            this.btnBorrarServicio.Click += new System.EventHandler(this.btnBorrarServicio_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(180, 10);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(116, 15);
            this.label26.TabIndex = 11;
            this.label26.Text = "Listado de Servicios";
            // 
            // lbxServiciosEliminar
            // 
            this.lbxServiciosEliminar.DisplayMember = "Nombre";
            this.lbxServiciosEliminar.FormattingEnabled = true;
            this.lbxServiciosEliminar.ItemHeight = 15;
            this.lbxServiciosEliminar.Location = new System.Drawing.Point(183, 28);
            this.lbxServiciosEliminar.Name = "lbxServiciosEliminar";
            this.lbxServiciosEliminar.Size = new System.Drawing.Size(321, 454);
            this.lbxServiciosEliminar.Sorted = true;
            this.lbxServiciosEliminar.TabIndex = 10;
            this.lbxServiciosEliminar.SelectedIndexChanged += new System.EventHandler(this.lbxServiciosEliminar_SelectedIndexChanged);
            // 
            // pnlServicio
            // 
            this.pnlServicio.Controls.Add(this.tabControl1);
            this.pnlServicio.Controls.Add(this.btnLimpiar);
            this.pnlServicio.Controls.Add(this.btnAceptar);
            this.pnlServicio.Controls.Add(this.btnCancelar);
            this.pnlServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlServicio.Location = new System.Drawing.Point(100, 62);
            this.pnlServicio.Name = "pnlServicio";
            this.pnlServicio.Size = new System.Drawing.Size(1164, 584);
            this.pnlServicio.TabIndex = 11;
            // 
            // frmABMServicio
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(1362, 732);
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
        private System.Windows.Forms.TextBox txtNombreServicioMod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregarRelacionMod;
        private System.Windows.Forms.Button btnBorrarRelacionMod;
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
        private System.Windows.Forms.TabPage tabEliminarServicio;
        private System.Windows.Forms.Button btnBorrarServicio;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ListBox lbxServiciosEliminar;
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
        private System.Windows.Forms.TextBox txtVelocidadRelacionMod;
        private System.Windows.Forms.TextBox txtDistanciaRelacionMod;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtEstacionOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtEstacionDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtId_EstacionOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtId_EstacionDestino;
        private System.Windows.Forms.DataGridView dgvRelacionesMod;
        private System.Windows.Forms.CheckBox cbxEsParadaCrear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbxEsParadaMod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_EstacionOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_EstacionDestino;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ListBox lbxTrazasAsociadasEliminar;
    }
}