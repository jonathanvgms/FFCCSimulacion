namespace ffccSimulacion.Resultados
{
    partial class frmResultados
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
            this.btnResultadosPdf = new System.Windows.Forms.Button();
            this.btnResultadosCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPorcTrenes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTiemPro = new System.Windows.Forms.TextBox();
            this.txtPromPasaj = new System.Windows.Forms.TextBox();
            this.txtPromDem = new System.Windows.Forms.TextBox();
            this.txtConsPorKm = new System.Windows.Forms.TextBox();
            this.txtCostPorKm = new System.Windows.Forms.TextBox();
            this.txtCostPorPasajero = new System.Windows.Forms.TextBox();
            this.txtConsPorPasajero = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnResultadosPdf
            // 
            this.btnResultadosPdf.Location = new System.Drawing.Point(15, 335);
            this.btnResultadosPdf.Name = "btnResultadosPdf";
            this.btnResultadosPdf.Size = new System.Drawing.Size(110, 23);
            this.btnResultadosPdf.TabIndex = 1;
            this.btnResultadosPdf.Text = "Guardar en pdf";
            this.btnResultadosPdf.UseVisualStyleBackColor = true;
            this.btnResultadosPdf.Click += new System.EventHandler(this.btnResultadosPdf_Click);
            // 
            // btnResultadosCerrar
            // 
            this.btnResultadosCerrar.Location = new System.Drawing.Point(803, 335);
            this.btnResultadosCerrar.Name = "btnResultadosCerrar";
            this.btnResultadosCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnResultadosCerrar.TabIndex = 2;
            this.btnResultadosCerrar.Text = "Cerrar";
            this.btnResultadosCerrar.UseVisualStyleBackColor = true;
            this.btnResultadosCerrar.Click += new System.EventHandler(this.btnResultadosCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Procentaje de trenes que supero \r\nel maximo de pasajeros permitidos.";
            // 
            // txtPorcTrenes
            // 
            this.txtPorcTrenes.Location = new System.Drawing.Point(266, 26);
            this.txtPorcTrenes.Name = "txtPorcTrenes";
            this.txtPorcTrenes.Size = new System.Drawing.Size(100, 20);
            this.txtPorcTrenes.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tiempo promedio de demora por incidentes.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Promedio de pasajeros por formacion.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "Promedio de demora por tiempo\r\n de atencion en estacion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(456, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Consumo promedio por km";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(456, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Consumo promedio por pasajero";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Costo por km";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Costo por pasajero";
            // 
            // txtTiemPro
            // 
            this.txtTiemPro.Location = new System.Drawing.Point(266, 77);
            this.txtTiemPro.Name = "txtTiemPro";
            this.txtTiemPro.Size = new System.Drawing.Size(100, 20);
            this.txtTiemPro.TabIndex = 13;
            // 
            // txtPromPasaj
            // 
            this.txtPromPasaj.Location = new System.Drawing.Point(266, 125);
            this.txtPromPasaj.Name = "txtPromPasaj";
            this.txtPromPasaj.Size = new System.Drawing.Size(100, 20);
            this.txtPromPasaj.TabIndex = 14;
            // 
            // txtPromDem
            // 
            this.txtPromDem.Location = new System.Drawing.Point(266, 171);
            this.txtPromDem.Name = "txtPromDem";
            this.txtPromDem.Size = new System.Drawing.Size(100, 20);
            this.txtPromDem.TabIndex = 15;
            // 
            // txtConsPorKm
            // 
            this.txtConsPorKm.Location = new System.Drawing.Point(651, 227);
            this.txtConsPorKm.Name = "txtConsPorKm";
            this.txtConsPorKm.ReadOnly = true;
            this.txtConsPorKm.Size = new System.Drawing.Size(100, 20);
            this.txtConsPorKm.TabIndex = 16;
            // 
            // txtCostPorKm
            // 
            this.txtCostPorKm.Location = new System.Drawing.Point(266, 230);
            this.txtCostPorKm.Name = "txtCostPorKm";
            this.txtCostPorKm.Size = new System.Drawing.Size(100, 20);
            this.txtCostPorKm.TabIndex = 17;
            // 
            // txtCostPorPasajero
            // 
            this.txtCostPorPasajero.Location = new System.Drawing.Point(266, 280);
            this.txtCostPorPasajero.Name = "txtCostPorPasajero";
            this.txtCostPorPasajero.Size = new System.Drawing.Size(100, 20);
            this.txtCostPorPasajero.TabIndex = 18;
            // 
            // txtConsPorPasajero
            // 
            this.txtConsPorPasajero.Location = new System.Drawing.Point(651, 280);
            this.txtConsPorPasajero.Name = "txtConsPorPasajero";
            this.txtConsPorPasajero.ReadOnly = true;
            this.txtConsPorPasajero.Size = new System.Drawing.Size(100, 20);
            this.txtConsPorPasajero.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(396, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Minutos";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(396, 283);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "$";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(396, 233);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "$";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(396, 128);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Pasajeros";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(396, 174);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Minutos";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(771, 230);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "$";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(771, 283);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "$";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(396, 29);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(15, 13);
            this.label16.TabIndex = 28;
            this.label16.Text = "%";
            // 
            // frmResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 373);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtConsPorPasajero);
            this.Controls.Add(this.txtCostPorPasajero);
            this.Controls.Add(this.txtCostPorKm);
            this.Controls.Add(this.txtConsPorKm);
            this.Controls.Add(this.txtPromDem);
            this.Controls.Add(this.txtPromPasaj);
            this.Controls.Add(this.txtTiemPro);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPorcTrenes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnResultadosCerrar);
            this.Controls.Add(this.btnResultadosPdf);
            this.Name = "frmResultados";
            this.Text = "Resultados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnResultadosPdf;
        private System.Windows.Forms.Button btnResultadosCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPorcTrenes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTiemPro;
        private System.Windows.Forms.TextBox txtPromPasaj;
        private System.Windows.Forms.TextBox txtPromDem;
        private System.Windows.Forms.TextBox txtConsPorKm;
        private System.Windows.Forms.TextBox txtCostPorKm;
        private System.Windows.Forms.TextBox txtCostPorPasajero;
        private System.Windows.Forms.TextBox txtConsPorPasajero;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}