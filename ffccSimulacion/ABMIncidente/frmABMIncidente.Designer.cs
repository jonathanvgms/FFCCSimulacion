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
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCrear = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbIncCreTiem = new System.Windows.Forms.TextBox();
            this.cbmIncCrePro = new System.Windows.Forms.ComboBox();
            this.txtincCreDes = new System.Windows.Forms.TextBox();
            this.txtIncCreNom = new System.Windows.Forms.TextBox();
            this.tabModificar = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.lstIncMod = new System.Windows.Forms.ListBox();
            this.tabEliminar = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
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
            this.label1.Location = new System.Drawing.Point(346, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Probabilidad";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
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
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(493, 169);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(346, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tiempo de Demora (min)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(493, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(493, 124);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(182, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(493, 214);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(182, 20);
            this.textBox3.TabIndex = 2;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(15, 389);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCancelar
            // 
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
            this.tabControl1.Location = new System.Drawing.Point(15, 15);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(714, 368);
            this.tabControl1.TabIndex = 4;
            // 
            // tabCrear
            // 
            this.tabCrear.Controls.Add(this.label5);
            this.tabCrear.Controls.Add(this.label6);
            this.tabCrear.Controls.Add(this.label7);
            this.tabCrear.Controls.Add(this.label8);
            this.tabCrear.Controls.Add(this.txtbIncCreTiem);
            this.tabCrear.Controls.Add(this.cbmIncCrePro);
            this.tabCrear.Controls.Add(this.txtincCreDes);
            this.tabCrear.Controls.Add(this.txtIncCreNom);
            this.tabCrear.Location = new System.Drawing.Point(4, 22);
            this.tabCrear.Name = "tabCrear";
            this.tabCrear.Padding = new System.Windows.Forms.Padding(3);
            this.tabCrear.Size = new System.Drawing.Size(706, 342);
            this.tabCrear.TabIndex = 0;
            this.tabCrear.Text = "Crear";
            this.tabCrear.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(151, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(151, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Descripcion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(151, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Probabilidad De Ocurencia";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(151, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Tiempo de Demora (min)";
            // 
            // txtbIncCreTiem
            // 
            this.txtbIncCreTiem.Location = new System.Drawing.Point(298, 207);
            this.txtbIncCreTiem.Name = "txtbIncCreTiem";
            this.txtbIncCreTiem.Size = new System.Drawing.Size(190, 20);
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
            "5",
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
            this.cbmIncCrePro.Location = new System.Drawing.Point(298, 155);
            this.cbmIncCrePro.Name = "cbmIncCrePro";
            this.cbmIncCrePro.Size = new System.Drawing.Size(190, 21);
            this.cbmIncCrePro.TabIndex = 7;
            // 
            // txtincCreDes
            // 
            this.txtincCreDes.Location = new System.Drawing.Point(298, 106);
            this.txtincCreDes.Name = "txtincCreDes";
            this.txtincCreDes.Size = new System.Drawing.Size(190, 20);
            this.txtincCreDes.TabIndex = 9;
            // 
            // txtIncCreNom
            // 
            this.txtIncCreNom.Location = new System.Drawing.Point(298, 56);
            this.txtIncCreNom.Name = "txtIncCreNom";
            this.txtIncCreNom.Size = new System.Drawing.Size(190, 20);
            this.txtIncCreNom.TabIndex = 10;
            // 
            // tabModificar
            // 
            this.tabModificar.Controls.Add(this.label9);
            this.tabModificar.Controls.Add(this.lstIncMod);
            this.tabModificar.Controls.Add(this.label1);
            this.tabModificar.Controls.Add(this.label2);
            this.tabModificar.Controls.Add(this.label3);
            this.tabModificar.Controls.Add(this.label4);
            this.tabModificar.Controls.Add(this.textBox3);
            this.tabModificar.Controls.Add(this.comboBox1);
            this.tabModificar.Controls.Add(this.textBox2);
            this.tabModificar.Controls.Add(this.textBox1);
            this.tabModificar.Location = new System.Drawing.Point(4, 22);
            this.tabModificar.Name = "tabModificar";
            this.tabModificar.Padding = new System.Windows.Forms.Padding(3);
            this.tabModificar.Size = new System.Drawing.Size(706, 342);
            this.tabModificar.TabIndex = 1;
            this.tabModificar.Text = "Modificar";
            this.tabModificar.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Listado de Inidentes";
            // 
            // lstIncMod
            // 
            this.lstIncMod.FormattingEnabled = true;
            this.lstIncMod.Location = new System.Drawing.Point(6, 30);
            this.lstIncMod.Name = "lstIncMod";
            this.lstIncMod.Size = new System.Drawing.Size(304, 303);
            this.lstIncMod.TabIndex = 3;
            // 
            // tabEliminar
            // 
            this.tabEliminar.Controls.Add(this.label10);
            this.tabEliminar.Controls.Add(this.button5);
            this.tabEliminar.Controls.Add(this.lstIncEli);
            this.tabEliminar.Location = new System.Drawing.Point(4, 22);
            this.tabEliminar.Name = "tabEliminar";
            this.tabEliminar.Padding = new System.Windows.Forms.Padding(3);
            this.tabEliminar.Size = new System.Drawing.Size(706, 342);
            this.tabEliminar.TabIndex = 2;
            this.tabEliminar.Text = "Eliminar";
            this.tabEliminar.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(200, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Listado de Inidentes";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(513, 32);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "Borrar Incidente";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // lstIncEli
            // 
            this.lstIncEli.FormattingEnabled = true;
            this.lstIncEli.Location = new System.Drawing.Point(203, 32);
            this.lstIncEli.Name = "lstIncEli";
            this.lstIncEli.Size = new System.Drawing.Size(304, 303);
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
            this.ClientSize = new System.Drawing.Size(768, 451);
            this.Controls.Add(this.pnlInicidente);
            this.Name = "frmABMIncidente";
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
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
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListBox lstIncEli;
        public System.Windows.Forms.Panel pnlInicidente;
    }
}