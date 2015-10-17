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
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lstIncidenteCrear = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblCrearMensajeError = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbIncCreTiem = new System.Windows.Forms.TextBox();
            this.cbmIncCrePro = new System.Windows.Forms.ComboBox();
            this.txtincCreDes = new System.Windows.Forms.TextBox();
            this.txtIncCreNom = new System.Windows.Forms.TextBox();
            this.tabModificar = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblModMensajeError = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lstIncMod = new System.Windows.Forms.ListBox();
            this.tabEliminar = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.btnEliminarIncidente = new System.Windows.Forms.Button();
            this.lstIncEli = new System.Windows.Forms.ListBox();
            this.pnlInicidente = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabCrear.SuspendLayout();
            this.tabModificar.SuspendLayout();
            this.tabEliminar.SuspendLayout();
            this.pnlInicidente.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Descripcion";
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
            this.cmbModProb.Location = new System.Drawing.Point(426, 205);
            this.cmbModProb.Name = "cmbModProb";
            this.cmbModProb.Size = new System.Drawing.Size(111, 23);
            this.cmbModProb.TabIndex = 1;
            // 
            // txtModNombre
            // 
            this.txtModNombre.Location = new System.Drawing.Point(426, 30);
            this.txtModNombre.Name = "txtModNombre";
            this.txtModNombre.Size = new System.Drawing.Size(251, 21);
            this.txtModNombre.TabIndex = 2;
            // 
            // txtModDes
            // 
            this.txtModDes.Location = new System.Drawing.Point(426, 74);
            this.txtModDes.Multiline = true;
            this.txtModDes.Name = "txtModDes";
            this.txtModDes.Size = new System.Drawing.Size(251, 104);
            this.txtModDes.TabIndex = 2;
            // 
            // txtModDem
            // 
            this.txtModDem.Location = new System.Drawing.Point(426, 260);
            this.txtModDem.Name = "txtModDem";
            this.txtModDem.Size = new System.Drawing.Size(111, 21);
            this.txtModDem.TabIndex = 2;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(15, 389);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 24);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(654, 389);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 24);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(573, 389);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 24);
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
            this.tabControl1.Location = new System.Drawing.Point(15, 15);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.ShowToolTips = true;
            this.tabControl1.Size = new System.Drawing.Size(714, 368);
            this.tabControl1.TabIndex = 4;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.selecionarPestaña);
            // 
            // tabCrear
            // 
            this.tabCrear.Controls.Add(this.label13);
            this.tabCrear.Controls.Add(this.label12);
            this.tabCrear.Controls.Add(this.lstIncidenteCrear);
            this.tabCrear.Controls.Add(this.label11);
            this.tabCrear.Controls.Add(this.lblCrearMensajeError);
            this.tabCrear.Controls.Add(this.label5);
            this.tabCrear.Controls.Add(this.label6);
            this.tabCrear.Controls.Add(this.label7);
            this.tabCrear.Controls.Add(this.label8);
            this.tabCrear.Controls.Add(this.txtbIncCreTiem);
            this.tabCrear.Controls.Add(this.cbmIncCrePro);
            this.tabCrear.Controls.Add(this.txtincCreDes);
            this.tabCrear.Controls.Add(this.txtIncCreNom);
            this.tabCrear.Location = new System.Drawing.Point(4, 24);
            this.tabCrear.Name = "tabCrear";
            this.tabCrear.Padding = new System.Windows.Forms.Padding(3);
            this.tabCrear.Size = new System.Drawing.Size(706, 340);
            this.tabCrear.TabIndex = 0;
            this.tabCrear.Text = "Nuevo Incidente";
            this.tabCrear.ToolTipText = "Crea un nuevo incidente que no aparezca en el listado";
            this.tabCrear.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(248, 292);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 15);
            this.label13.TabIndex = 15;
            this.label13.Text = "Minutos";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(248, 237);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 15);
            this.label12.TabIndex = 14;
            this.label12.Text = "%";
            // 
            // lstIncidenteCrear
            // 
            this.lstIncidenteCrear.DisplayMember = "Nombre";
            this.lstIncidenteCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstIncidenteCrear.FormattingEnabled = true;
            this.lstIncidenteCrear.ItemHeight = 15;
            this.lstIncidenteCrear.Location = new System.Drawing.Point(416, 41);
            this.lstIncidenteCrear.Name = "lstIncidenteCrear";
            this.lstIncidenteCrear.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstIncidenteCrear.Size = new System.Drawing.Size(284, 289);
            this.lstIncidenteCrear.Sorted = true;
            this.lstIncidenteCrear.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(413, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 15);
            this.label11.TabIndex = 12;
            this.label11.Text = "Incidentes Existentes";
            // 
            // lblCrearMensajeError
            // 
            this.lblCrearMensajeError.AutoSize = true;
            this.lblCrearMensajeError.Location = new System.Drawing.Point(440, 78);
            this.lblCrearMensajeError.Name = "lblCrearMensajeError";
            this.lblCrearMensajeError.Size = new System.Drawing.Size(0, 15);
            this.lblCrearMensajeError.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Descripcion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 30);
            this.label7.TabIndex = 5;
            this.label7.Text = "Probabilidad \r\nDe Ocurencia";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 30);
            this.label8.TabIndex = 6;
            this.label8.Text = "Tiempo \r\nDe Demora";
            // 
            // txtbIncCreTiem
            // 
            this.txtbIncCreTiem.Location = new System.Drawing.Point(129, 289);
            this.txtbIncCreTiem.Name = "txtbIncCreTiem";
            this.txtbIncCreTiem.Size = new System.Drawing.Size(113, 21);
            this.txtbIncCreTiem.TabIndex = 8;
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
            this.cbmIncCrePro.Location = new System.Drawing.Point(129, 234);
            this.cbmIncCrePro.Name = "cbmIncCrePro";
            this.cbmIncCrePro.Size = new System.Drawing.Size(113, 23);
            this.cbmIncCrePro.TabIndex = 7;
            // 
            // txtincCreDes
            // 
            this.txtincCreDes.Location = new System.Drawing.Point(129, 92);
            this.txtincCreDes.Multiline = true;
            this.txtincCreDes.Name = "txtincCreDes";
            this.txtincCreDes.Size = new System.Drawing.Size(260, 111);
            this.txtincCreDes.TabIndex = 9;
            // 
            // txtIncCreNom
            // 
            this.txtIncCreNom.Location = new System.Drawing.Point(129, 49);
            this.txtIncCreNom.Name = "txtIncCreNom";
            this.txtIncCreNom.Size = new System.Drawing.Size(260, 21);
            this.txtIncCreNom.TabIndex = 10;
            // 
            // tabModificar
            // 
            this.tabModificar.Controls.Add(this.label3);
            this.tabModificar.Controls.Add(this.label4);
            this.tabModificar.Controls.Add(this.label14);
            this.tabModificar.Controls.Add(this.label15);
            this.tabModificar.Controls.Add(this.lblModMensajeError);
            this.tabModificar.Controls.Add(this.label9);
            this.tabModificar.Controls.Add(this.lstIncMod);
            this.tabModificar.Controls.Add(this.label1);
            this.tabModificar.Controls.Add(this.label2);
            this.tabModificar.Controls.Add(this.txtModDem);
            this.tabModificar.Controls.Add(this.cmbModProb);
            this.tabModificar.Controls.Add(this.txtModDes);
            this.tabModificar.Controls.Add(this.txtModNombre);
            this.tabModificar.Location = new System.Drawing.Point(4, 24);
            this.tabModificar.Name = "tabModificar";
            this.tabModificar.Padding = new System.Windows.Forms.Padding(3);
            this.tabModificar.Size = new System.Drawing.Size(706, 340);
            this.tabModificar.TabIndex = 1;
            this.tabModificar.Text = "Buscar";
            this.tabModificar.ToolTipText = "Muestra un listado de incidentes para su modificación";
            this.tabModificar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(551, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Minutos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(551, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "%";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(333, 201);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 30);
            this.label14.TabIndex = 7;
            this.label14.Text = "Probabilidad \r\nDe Ocurencia";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(335, 250);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 30);
            this.label15.TabIndex = 8;
            this.label15.Text = "Tiempo \r\nDe Demora";
            // 
            // lblModMensajeError
            // 
            this.lblModMensajeError.AutoSize = true;
            this.lblModMensajeError.Location = new System.Drawing.Point(334, 229);
            this.lblModMensajeError.Name = "lblModMensajeError";
            this.lblModMensajeError.Size = new System.Drawing.Size(0, 15);
            this.lblModMensajeError.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 15);
            this.label9.TabIndex = 5;
            this.label9.Text = "Incidentes Existentes";
            // 
            // lstIncMod
            // 
            this.lstIncMod.DisplayMember = "Nombre";
            this.lstIncMod.FormattingEnabled = true;
            this.lstIncMod.ItemHeight = 15;
            this.lstIncMod.Location = new System.Drawing.Point(6, 30);
            this.lstIncMod.Name = "lstIncMod";
            this.lstIncMod.Size = new System.Drawing.Size(304, 289);
            this.lstIncMod.Sorted = true;
            this.lstIncMod.TabIndex = 3;
            this.lstIncMod.SelectedIndexChanged += new System.EventHandler(this.seleccionarIncidente);
            // 
            // tabEliminar
            // 
            this.tabEliminar.Controls.Add(this.label10);
            this.tabEliminar.Controls.Add(this.btnEliminarIncidente);
            this.tabEliminar.Controls.Add(this.lstIncEli);
            this.tabEliminar.Location = new System.Drawing.Point(4, 24);
            this.tabEliminar.Name = "tabEliminar";
            this.tabEliminar.Padding = new System.Windows.Forms.Padding(3);
            this.tabEliminar.Size = new System.Drawing.Size(706, 340);
            this.tabEliminar.TabIndex = 2;
            this.tabEliminar.Text = "Eliminar";
            this.tabEliminar.ToolTipText = "Muestra un listado que incidentes para su eliminación";
            this.tabEliminar.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(200, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 15);
            this.label10.TabIndex = 8;
            this.label10.Text = "Incidentes Existentes";
            // 
            // btnEliminarIncidente
            // 
            this.btnEliminarIncidente.Location = new System.Drawing.Point(513, 32);
            this.btnEliminarIncidente.Name = "btnEliminarIncidente";
            this.btnEliminarIncidente.Size = new System.Drawing.Size(116, 26);
            this.btnEliminarIncidente.TabIndex = 7;
            this.btnEliminarIncidente.Text = "Borrar Incidente";
            this.btnEliminarIncidente.UseVisualStyleBackColor = true;
            this.btnEliminarIncidente.Click += new System.EventHandler(this.btnEliminarIncidente_Click);
            // 
            // lstIncEli
            // 
            this.lstIncEli.DisplayMember = "Nombre";
            this.lstIncEli.FormattingEnabled = true;
            this.lstIncEli.ItemHeight = 15;
            this.lstIncEli.Location = new System.Drawing.Point(203, 32);
            this.lstIncEli.Name = "lstIncEli";
            this.lstIncEli.Size = new System.Drawing.Size(304, 289);
            this.lstIncEli.Sorted = true;
            this.lstIncEli.TabIndex = 6;
            // 
            // pnlInicidente
            // 
            this.pnlInicidente.Controls.Add(this.tabControl1);
            this.pnlInicidente.Controls.Add(this.btnLimpiar);
            this.pnlInicidente.Controls.Add(this.btnAceptar);
            this.pnlInicidente.Controls.Add(this.btnCancelar);
            this.pnlInicidente.Location = new System.Drawing.Point(12, 12);
            this.pnlInicidente.Name = "pnlInicidente";
            this.pnlInicidente.Size = new System.Drawing.Size(743, 429);
            this.pnlInicidente.TabIndex = 5;
            // 
            // frmABMIncidente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 452);
            this.Controls.Add(this.pnlInicidente);
            this.Name = "frmABMIncidente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Incidente";
            this.tabControl1.ResumeLayout(false);
            this.tabCrear.ResumeLayout(false);
            this.tabCrear.PerformLayout();
            this.tabModificar.ResumeLayout(false);
            this.tabModificar.PerformLayout();
            this.tabEliminar.ResumeLayout(false);
            this.tabEliminar.PerformLayout();
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lstIncMod;
        private System.Windows.Forms.TabPage tabEliminar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnEliminarIncidente;
        private System.Windows.Forms.ListBox lstIncEli;
        public System.Windows.Forms.Panel pnlInicidente;
        private System.Windows.Forms.Label lblCrearMensajeError;
        private System.Windows.Forms.Label lblModMensajeError;
        private System.Windows.Forms.ListBox lstIncidenteCrear;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}