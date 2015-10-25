namespace ffccSimulacion.ABMFormacion
{
    partial class frmABMFormacion
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCrearFormacion = new System.Windows.Forms.TabPage();
            this.txtConsumoFormacionParado = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtMaxRealPasajeros = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtMaxPasajerosLegal = new System.Windows.Forms.TextBox();
            this.txtTotalAsientos = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCantidadCoches = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTotalCoches = new System.Windows.Forms.TextBox();
            this.txtConsumoFormacionMov = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreFormacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBorrarCocheFormacion = new System.Windows.Forms.Button();
            this.btnAgregarFormacion = new System.Windows.Forms.Button();
            this.lbxCochesFormacion = new System.Windows.Forms.ListBox();
            this.lbxCochesExistentes = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabModificarFormacion = new System.Windows.Forms.TabPage();
            this.txtConsumoFormacionParadoMod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaximoPasajerosRealMod = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaximoPasajerlosLegalMod = new System.Windows.Forms.TextBox();
            this.txtTotalAsientosMod = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtTotalCochesMod = new System.Windows.Forms.TextBox();
            this.txtConsumoFormacionMovMod = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtCantidadCochesMod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNombreFormacionMod = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnEliminarCocheMod = new System.Windows.Forms.Button();
            this.btnAgregarCocheMod = new System.Windows.Forms.Button();
            this.lbxCochesFormacionMod = new System.Windows.Forms.ListBox();
            this.lbxCochesExistentesMod = new System.Windows.Forms.ListBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lbxFormacionesModificar = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnBorrarFormacion = new System.Windows.Forms.Button();
            this.lbxFormacionesEliminar = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.pnlFormacion = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabCrearFormacion.SuspendLayout();
            this.tabModificarFormacion.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.pnlFormacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCrearFormacion);
            this.tabControl1.Controls.Add(this.tabModificarFormacion);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 14);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1169, 488);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.seleccionarPestaña);
            // 
            // tabCrearFormacion
            // 
            this.tabCrearFormacion.Controls.Add(this.txtConsumoFormacionParado);
            this.tabCrearFormacion.Controls.Add(this.label18);
            this.tabCrearFormacion.Controls.Add(this.txtMaxRealPasajeros);
            this.tabCrearFormacion.Controls.Add(this.label17);
            this.tabCrearFormacion.Controls.Add(this.txtMaxPasajerosLegal);
            this.tabCrearFormacion.Controls.Add(this.txtTotalAsientos);
            this.tabCrearFormacion.Controls.Add(this.label16);
            this.tabCrearFormacion.Controls.Add(this.label15);
            this.tabCrearFormacion.Controls.Add(this.txtCantidadCoches);
            this.tabCrearFormacion.Controls.Add(this.label11);
            this.tabCrearFormacion.Controls.Add(this.txtTotalCoches);
            this.tabCrearFormacion.Controls.Add(this.txtConsumoFormacionMov);
            this.tabCrearFormacion.Controls.Add(this.label10);
            this.tabCrearFormacion.Controls.Add(this.label8);
            this.tabCrearFormacion.Controls.Add(this.label1);
            this.tabCrearFormacion.Controls.Add(this.txtNombreFormacion);
            this.tabCrearFormacion.Controls.Add(this.label2);
            this.tabCrearFormacion.Controls.Add(this.btnBorrarCocheFormacion);
            this.tabCrearFormacion.Controls.Add(this.btnAgregarFormacion);
            this.tabCrearFormacion.Controls.Add(this.lbxCochesFormacion);
            this.tabCrearFormacion.Controls.Add(this.lbxCochesExistentes);
            this.tabCrearFormacion.Controls.Add(this.label7);
            this.tabCrearFormacion.Location = new System.Drawing.Point(4, 24);
            this.tabCrearFormacion.Name = "tabCrearFormacion";
            this.tabCrearFormacion.Padding = new System.Windows.Forms.Padding(3);
            this.tabCrearFormacion.Size = new System.Drawing.Size(1161, 460);
            this.tabCrearFormacion.TabIndex = 0;
            this.tabCrearFormacion.Text = "Nueva Formación";
            this.tabCrearFormacion.UseVisualStyleBackColor = true;
            // 
            // txtConsumoFormacionParado
            // 
            this.txtConsumoFormacionParado.Enabled = false;
            this.txtConsumoFormacionParado.Location = new System.Drawing.Point(1042, 107);
            this.txtConsumoFormacionParado.Name = "txtConsumoFormacionParado";
            this.txtConsumoFormacionParado.ReadOnly = true;
            this.txtConsumoFormacionParado.Size = new System.Drawing.Size(100, 21);
            this.txtConsumoFormacionParado.TabIndex = 41;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(852, 107);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(165, 15);
            this.label18.TabIndex = 40;
            this.label18.Text = "Consumo Formación Parado";
            // 
            // txtMaxRealPasajeros
            // 
            this.txtMaxRealPasajeros.Enabled = false;
            this.txtMaxRealPasajeros.Location = new System.Drawing.Point(1042, 239);
            this.txtMaxRealPasajeros.Name = "txtMaxRealPasajeros";
            this.txtMaxRealPasajeros.ReadOnly = true;
            this.txtMaxRealPasajeros.Size = new System.Drawing.Size(100, 21);
            this.txtMaxRealPasajeros.TabIndex = 39;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(852, 242);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(139, 15);
            this.label17.TabIndex = 38;
            this.label17.Text = "Máximo Real Pasajeros";
            // 
            // txtMaxPasajerosLegal
            // 
            this.txtMaxPasajerosLegal.Enabled = false;
            this.txtMaxPasajerosLegal.Location = new System.Drawing.Point(1042, 214);
            this.txtMaxPasajerosLegal.Name = "txtMaxPasajerosLegal";
            this.txtMaxPasajerosLegal.ReadOnly = true;
            this.txtMaxPasajerosLegal.Size = new System.Drawing.Size(100, 21);
            this.txtMaxPasajerosLegal.TabIndex = 35;
            // 
            // txtTotalAsientos
            // 
            this.txtTotalAsientos.Enabled = false;
            this.txtTotalAsientos.Location = new System.Drawing.Point(1042, 187);
            this.txtTotalAsientos.Name = "txtTotalAsientos";
            this.txtTotalAsientos.ReadOnly = true;
            this.txtTotalAsientos.Size = new System.Drawing.Size(100, 21);
            this.txtTotalAsientos.TabIndex = 37;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(852, 217);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(144, 15);
            this.label16.TabIndex = 34;
            this.label16.Text = "Máximo Legal Pasajeros";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(852, 190);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(145, 15);
            this.label15.TabIndex = 36;
            this.label15.Text = "Total Asientos Formación";
            // 
            // txtCantidadCoches
            // 
            this.txtCantidadCoches.Location = new System.Drawing.Point(399, 133);
            this.txtCantidadCoches.MaxLength = 9;
            this.txtCantidadCoches.Name = "txtCantidadCoches";
            this.txtCantidadCoches.Size = new System.Drawing.Size(118, 21);
            this.txtCantidadCoches.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(337, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 15);
            this.label11.TabIndex = 34;
            this.label11.Text = "Cantidad";
            // 
            // txtTotalCoches
            // 
            this.txtTotalCoches.Enabled = false;
            this.txtTotalCoches.Location = new System.Drawing.Point(1042, 160);
            this.txtTotalCoches.Name = "txtTotalCoches";
            this.txtTotalCoches.ReadOnly = true;
            this.txtTotalCoches.Size = new System.Drawing.Size(100, 21);
            this.txtTotalCoches.TabIndex = 33;
            // 
            // txtConsumoFormacionMov
            // 
            this.txtConsumoFormacionMov.Enabled = false;
            this.txtConsumoFormacionMov.Location = new System.Drawing.Point(1042, 133);
            this.txtConsumoFormacionMov.Name = "txtConsumoFormacionMov";
            this.txtConsumoFormacionMov.ReadOnly = true;
            this.txtConsumoFormacionMov.Size = new System.Drawing.Size(100, 21);
            this.txtConsumoFormacionMov.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(852, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 15);
            this.label10.TabIndex = 31;
            this.label10.Text = "Total de Coches";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(852, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 15);
            this.label8.TabIndex = 29;
            this.label8.Text = "Consumo Formación Movimiento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(554, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 27;
            this.label1.Text = "Formación";
            // 
            // txtNombreFormacion
            // 
            this.txtNombreFormacion.Location = new System.Drawing.Point(85, 23);
            this.txtNombreFormacion.MaxLength = 99;
            this.txtNombreFormacion.Name = "txtNombreFormacion";
            this.txtNombreFormacion.Size = new System.Drawing.Size(212, 21);
            this.txtNombreFormacion.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nombre";
            // 
            // btnBorrarCocheFormacion
            // 
            this.btnBorrarCocheFormacion.Location = new System.Drawing.Point(368, 315);
            this.btnBorrarCocheFormacion.Name = "btnBorrarCocheFormacion";
            this.btnBorrarCocheFormacion.Size = new System.Drawing.Size(118, 40);
            this.btnBorrarCocheFormacion.TabIndex = 24;
            this.btnBorrarCocheFormacion.Text = "Borrar de Formación";
            this.btnBorrarCocheFormacion.UseVisualStyleBackColor = true;
            this.btnBorrarCocheFormacion.Click += new System.EventHandler(this.btnBorrarCocheFormacion_Click);
            // 
            // btnAgregarFormacion
            // 
            this.btnAgregarFormacion.Location = new System.Drawing.Point(368, 190);
            this.btnAgregarFormacion.Name = "btnAgregarFormacion";
            this.btnAgregarFormacion.Size = new System.Drawing.Size(118, 39);
            this.btnAgregarFormacion.TabIndex = 23;
            this.btnAgregarFormacion.Text = "Agregar a Formación";
            this.btnAgregarFormacion.UseVisualStyleBackColor = true;
            this.btnAgregarFormacion.Click += new System.EventHandler(this.btnAgregarFormacion_Click);
            // 
            // lbxCochesFormacion
            // 
            this.lbxCochesFormacion.DisplayMember = "Modelo";
            this.lbxCochesFormacion.FormattingEnabled = true;
            this.lbxCochesFormacion.ItemHeight = 15;
            this.lbxCochesFormacion.Location = new System.Drawing.Point(557, 72);
            this.lbxCochesFormacion.Name = "lbxCochesFormacion";
            this.lbxCochesFormacion.Size = new System.Drawing.Size(280, 364);
            this.lbxCochesFormacion.TabIndex = 22;
            this.lbxCochesFormacion.SelectedIndexChanged += new System.EventHandler(this.lbxCochesFormacion_SelectedIndexChanged);
            // 
            // lbxCochesExistentes
            // 
            this.lbxCochesExistentes.DisplayMember = "Modelo";
            this.lbxCochesExistentes.FormattingEnabled = true;
            this.lbxCochesExistentes.ItemHeight = 15;
            this.lbxCochesExistentes.Location = new System.Drawing.Point(17, 72);
            this.lbxCochesExistentes.Name = "lbxCochesExistentes";
            this.lbxCochesExistentes.Size = new System.Drawing.Size(280, 364);
            this.lbxCochesExistentes.TabIndex = 21;
            this.lbxCochesExistentes.SelectedIndexChanged += new System.EventHandler(this.lbxCochesExistentes_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "Coches Existentes";
            // 
            // tabModificarFormacion
            // 
            this.tabModificarFormacion.Controls.Add(this.txtConsumoFormacionParadoMod);
            this.tabModificarFormacion.Controls.Add(this.label4);
            this.tabModificarFormacion.Controls.Add(this.txtMaximoPasajerosRealMod);
            this.tabModificarFormacion.Controls.Add(this.label6);
            this.tabModificarFormacion.Controls.Add(this.txtMaximoPasajerlosLegalMod);
            this.tabModificarFormacion.Controls.Add(this.txtTotalAsientosMod);
            this.tabModificarFormacion.Controls.Add(this.label19);
            this.tabModificarFormacion.Controls.Add(this.label20);
            this.tabModificarFormacion.Controls.Add(this.txtTotalCochesMod);
            this.tabModificarFormacion.Controls.Add(this.txtConsumoFormacionMovMod);
            this.tabModificarFormacion.Controls.Add(this.label21);
            this.tabModificarFormacion.Controls.Add(this.label22);
            this.tabModificarFormacion.Controls.Add(this.txtCantidadCochesMod);
            this.tabModificarFormacion.Controls.Add(this.label3);
            this.tabModificarFormacion.Controls.Add(this.label12);
            this.tabModificarFormacion.Controls.Add(this.txtNombreFormacionMod);
            this.tabModificarFormacion.Controls.Add(this.label13);
            this.tabModificarFormacion.Controls.Add(this.btnEliminarCocheMod);
            this.tabModificarFormacion.Controls.Add(this.btnAgregarCocheMod);
            this.tabModificarFormacion.Controls.Add(this.lbxCochesFormacionMod);
            this.tabModificarFormacion.Controls.Add(this.lbxCochesExistentesMod);
            this.tabModificarFormacion.Controls.Add(this.label14);
            this.tabModificarFormacion.Controls.Add(this.lbxFormacionesModificar);
            this.tabModificarFormacion.Controls.Add(this.label5);
            this.tabModificarFormacion.Location = new System.Drawing.Point(4, 24);
            this.tabModificarFormacion.Name = "tabModificarFormacion";
            this.tabModificarFormacion.Padding = new System.Windows.Forms.Padding(3);
            this.tabModificarFormacion.Size = new System.Drawing.Size(1161, 460);
            this.tabModificarFormacion.TabIndex = 1;
            this.tabModificarFormacion.Text = "Modificar";
            this.tabModificarFormacion.UseVisualStyleBackColor = true;
            // 
            // txtConsumoFormacionParadoMod
            // 
            this.txtConsumoFormacionParadoMod.Enabled = false;
            this.txtConsumoFormacionParadoMod.Location = new System.Drawing.Point(658, 370);
            this.txtConsumoFormacionParadoMod.Name = "txtConsumoFormacionParadoMod";
            this.txtConsumoFormacionParadoMod.ReadOnly = true;
            this.txtConsumoFormacionParadoMod.Size = new System.Drawing.Size(100, 21);
            this.txtConsumoFormacionParadoMod.TabIndex = 62;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(444, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 15);
            this.label4.TabIndex = 61;
            this.label4.Text = "Consumo Formación Parado";
            // 
            // txtMaximoPasajerosRealMod
            // 
            this.txtMaximoPasajerosRealMod.Enabled = false;
            this.txtMaximoPasajerosRealMod.Location = new System.Drawing.Point(976, 422);
            this.txtMaximoPasajerosRealMod.Name = "txtMaximoPasajerosRealMod";
            this.txtMaximoPasajerosRealMod.ReadOnly = true;
            this.txtMaximoPasajerosRealMod.Size = new System.Drawing.Size(100, 21);
            this.txtMaximoPasajerosRealMod.TabIndex = 60;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(810, 425);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 15);
            this.label6.TabIndex = 59;
            this.label6.Text = "Máximo Real Pasajeros";
            // 
            // txtMaximoPasajerlosLegalMod
            // 
            this.txtMaximoPasajerlosLegalMod.Enabled = false;
            this.txtMaximoPasajerlosLegalMod.Location = new System.Drawing.Point(976, 397);
            this.txtMaximoPasajerlosLegalMod.Name = "txtMaximoPasajerlosLegalMod";
            this.txtMaximoPasajerlosLegalMod.ReadOnly = true;
            this.txtMaximoPasajerlosLegalMod.Size = new System.Drawing.Size(100, 21);
            this.txtMaximoPasajerlosLegalMod.TabIndex = 56;
            // 
            // txtTotalAsientosMod
            // 
            this.txtTotalAsientosMod.Enabled = false;
            this.txtTotalAsientosMod.Location = new System.Drawing.Point(976, 370);
            this.txtTotalAsientosMod.Name = "txtTotalAsientosMod";
            this.txtTotalAsientosMod.ReadOnly = true;
            this.txtTotalAsientosMod.Size = new System.Drawing.Size(100, 21);
            this.txtTotalAsientosMod.TabIndex = 58;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(810, 400);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(144, 15);
            this.label19.TabIndex = 55;
            this.label19.Text = "Máximo Legal Pasajeros";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(810, 373);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(145, 15);
            this.label20.TabIndex = 57;
            this.label20.Text = "Total Asientos Formación";
            // 
            // txtTotalCochesMod
            // 
            this.txtTotalCochesMod.Enabled = false;
            this.txtTotalCochesMod.Location = new System.Drawing.Point(658, 423);
            this.txtTotalCochesMod.Name = "txtTotalCochesMod";
            this.txtTotalCochesMod.ReadOnly = true;
            this.txtTotalCochesMod.Size = new System.Drawing.Size(100, 21);
            this.txtTotalCochesMod.TabIndex = 54;
            // 
            // txtConsumoFormacionMovMod
            // 
            this.txtConsumoFormacionMovMod.Enabled = false;
            this.txtConsumoFormacionMovMod.Location = new System.Drawing.Point(658, 396);
            this.txtConsumoFormacionMovMod.Name = "txtConsumoFormacionMovMod";
            this.txtConsumoFormacionMovMod.ReadOnly = true;
            this.txtConsumoFormacionMovMod.Size = new System.Drawing.Size(100, 21);
            this.txtConsumoFormacionMovMod.TabIndex = 53;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(444, 426);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(95, 15);
            this.label21.TabIndex = 52;
            this.label21.Text = "Total de Coches";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(444, 396);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(189, 15);
            this.label22.TabIndex = 51;
            this.label22.Text = "Consumo Formación Movimiento";
            // 
            // txtCantidadCochesMod
            // 
            this.txtCantidadCochesMod.Location = new System.Drawing.Point(747, 156);
            this.txtCantidadCochesMod.MaxLength = 9;
            this.txtCantidadCochesMod.Name = "txtCantidadCochesMod";
            this.txtCantidadCochesMod.Size = new System.Drawing.Size(100, 21);
            this.txtCantidadCochesMod.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(679, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 49;
            this.label3.Text = "Cantidad";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(871, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 15);
            this.label12.TabIndex = 43;
            this.label12.Text = "Formación";
            // 
            // txtNombreFormacionMod
            // 
            this.txtNombreFormacionMod.Location = new System.Drawing.Point(444, 26);
            this.txtNombreFormacionMod.MaxLength = 99;
            this.txtNombreFormacionMod.Name = "txtNombreFormacionMod";
            this.txtNombreFormacionMod.Size = new System.Drawing.Size(212, 21);
            this.txtNombreFormacionMod.TabIndex = 42;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(373, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 15);
            this.label13.TabIndex = 41;
            this.label13.Text = "Nombre";
            // 
            // btnEliminarCocheMod
            // 
            this.btnEliminarCocheMod.Location = new System.Drawing.Point(712, 284);
            this.btnEliminarCocheMod.Name = "btnEliminarCocheMod";
            this.btnEliminarCocheMod.Size = new System.Drawing.Size(118, 40);
            this.btnEliminarCocheMod.TabIndex = 40;
            this.btnEliminarCocheMod.Text = "Borrar de Formación";
            this.btnEliminarCocheMod.UseVisualStyleBackColor = true;
            this.btnEliminarCocheMod.Click += new System.EventHandler(this.btnEliminarCocheMod_Click);
            // 
            // btnAgregarCocheMod
            // 
            this.btnAgregarCocheMod.Location = new System.Drawing.Point(712, 201);
            this.btnAgregarCocheMod.Name = "btnAgregarCocheMod";
            this.btnAgregarCocheMod.Size = new System.Drawing.Size(118, 38);
            this.btnAgregarCocheMod.TabIndex = 39;
            this.btnAgregarCocheMod.Text = "Agregar a Formación";
            this.btnAgregarCocheMod.UseVisualStyleBackColor = true;
            this.btnAgregarCocheMod.Click += new System.EventHandler(this.btnAgregarCocheMod_Click);
            // 
            // lbxCochesFormacionMod
            // 
            this.lbxCochesFormacionMod.DisplayMember = "NombreCoche";
            this.lbxCochesFormacionMod.FormattingEnabled = true;
            this.lbxCochesFormacionMod.ItemHeight = 15;
            this.lbxCochesFormacionMod.Location = new System.Drawing.Point(874, 74);
            this.lbxCochesFormacionMod.Name = "lbxCochesFormacionMod";
            this.lbxCochesFormacionMod.Size = new System.Drawing.Size(280, 274);
            this.lbxCochesFormacionMod.TabIndex = 38;
            this.lbxCochesFormacionMod.SelectedIndexChanged += new System.EventHandler(this.lbxCochesFormacionMod_SelectedIndexChanged);
            // 
            // lbxCochesExistentesMod
            // 
            this.lbxCochesExistentesMod.DisplayMember = "Modelo";
            this.lbxCochesExistentesMod.FormattingEnabled = true;
            this.lbxCochesExistentesMod.ItemHeight = 15;
            this.lbxCochesExistentesMod.Location = new System.Drawing.Point(376, 74);
            this.lbxCochesExistentesMod.Name = "lbxCochesExistentesMod";
            this.lbxCochesExistentesMod.Size = new System.Drawing.Size(280, 274);
            this.lbxCochesExistentesMod.TabIndex = 37;
            this.lbxCochesExistentesMod.SelectedIndexChanged += new System.EventHandler(this.lbxCochesExistentesMod_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(373, 58);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 15);
            this.label14.TabIndex = 36;
            this.label14.Text = "Coches Existentes";
            // 
            // lbxFormacionesModificar
            // 
            this.lbxFormacionesModificar.DisplayMember = "NombreFormacion";
            this.lbxFormacionesModificar.FormattingEnabled = true;
            this.lbxFormacionesModificar.ItemHeight = 15;
            this.lbxFormacionesModificar.Location = new System.Drawing.Point(16, 35);
            this.lbxFormacionesModificar.Name = "lbxFormacionesModificar";
            this.lbxFormacionesModificar.Size = new System.Drawing.Size(324, 409);
            this.lbxFormacionesModificar.TabIndex = 17;
            this.lbxFormacionesModificar.SelectedIndexChanged += new System.EventHandler(this.lbxFormacionesModificar_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Listado de Formaciones";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnBorrarFormacion);
            this.tabPage3.Controls.Add(this.lbxFormacionesEliminar);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1161, 460);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Eliminar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnBorrarFormacion
            // 
            this.btnBorrarFormacion.Location = new System.Drawing.Point(727, 55);
            this.btnBorrarFormacion.Name = "btnBorrarFormacion";
            this.btnBorrarFormacion.Size = new System.Drawing.Size(119, 28);
            this.btnBorrarFormacion.TabIndex = 21;
            this.btnBorrarFormacion.Text = "Borrar Formación";
            this.btnBorrarFormacion.UseVisualStyleBackColor = true;
            this.btnBorrarFormacion.Click += new System.EventHandler(this.btnBorrarFormacion_Click);
            // 
            // lbxFormacionesEliminar
            // 
            this.lbxFormacionesEliminar.DisplayMember = "NombreFormacion";
            this.lbxFormacionesEliminar.FormattingEnabled = true;
            this.lbxFormacionesEliminar.ItemHeight = 15;
            this.lbxFormacionesEliminar.Location = new System.Drawing.Point(397, 55);
            this.lbxFormacionesEliminar.Name = "lbxFormacionesEliminar";
            this.lbxFormacionesEliminar.Size = new System.Drawing.Size(324, 379);
            this.lbxFormacionesEliminar.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(394, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "Listado de Formaciones";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(17, 508);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 28);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(1107, 508);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 28);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(1026, 508);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 28);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // pnlFormacion
            // 
            this.pnlFormacion.Controls.Add(this.tabControl1);
            this.pnlFormacion.Controls.Add(this.btnAceptar);
            this.pnlFormacion.Controls.Add(this.btnLimpiar);
            this.pnlFormacion.Controls.Add(this.btnCancelar);
            this.pnlFormacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlFormacion.Location = new System.Drawing.Point(54, 55);
            this.pnlFormacion.Name = "pnlFormacion";
            this.pnlFormacion.Size = new System.Drawing.Size(1193, 544);
            this.pnlFormacion.TabIndex = 4;
            // 
            // frmABMFormacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 737);
            this.Controls.Add(this.pnlFormacion);
            this.Name = "frmABMFormacion";
            this.Text = "Formación";
            this.tabControl1.ResumeLayout(false);
            this.tabCrearFormacion.ResumeLayout(false);
            this.tabCrearFormacion.PerformLayout();
            this.tabModificarFormacion.ResumeLayout(false);
            this.tabModificarFormacion.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.pnlFormacion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCrearFormacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreFormacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBorrarCocheFormacion;
        private System.Windows.Forms.Button btnAgregarFormacion;
        private System.Windows.Forms.ListBox lbxCochesFormacion;
        private System.Windows.Forms.ListBox lbxCochesExistentes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabModificarFormacion;
        private System.Windows.Forms.ListBox lbxFormacionesModificar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotalCoches;
        private System.Windows.Forms.TextBox txtConsumoFormacionMov;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnBorrarFormacion;
        private System.Windows.Forms.ListBox lbxFormacionesEliminar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCantidadCoches;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCantidadCochesMod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNombreFormacionMod;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnEliminarCocheMod;
        private System.Windows.Forms.Button btnAgregarCocheMod;
        private System.Windows.Forms.ListBox lbxCochesFormacionMod;
        private System.Windows.Forms.ListBox lbxCochesExistentesMod;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.Panel pnlFormacion;
        private System.Windows.Forms.TextBox txtConsumoFormacionParado;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtMaxRealPasajeros;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtMaxPasajerosLegal;
        private System.Windows.Forms.TextBox txtTotalAsientos;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtConsumoFormacionParadoMod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaximoPasajerosRealMod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaximoPasajerlosLegalMod;
        private System.Windows.Forms.TextBox txtTotalAsientosMod;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtTotalCochesMod;
        private System.Windows.Forms.TextBox txtConsumoFormacionMovMod;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
    }
}