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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResultados));
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
            this.btnResultadosPdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultadosPdf.Location = new System.Drawing.Point(15, 326);
            this.btnResultadosPdf.Name = "btnResultadosPdf";
            this.btnResultadosPdf.Size = new System.Drawing.Size(118, 32);
            this.btnResultadosPdf.TabIndex = 1;
            this.btnResultadosPdf.Text = "Guardar Informe";
            this.btnResultadosPdf.UseVisualStyleBackColor = true;
            this.btnResultadosPdf.Click += new System.EventHandler(this.btnResultadosPdf_Click);
            // 
            // btnResultadosCerrar
            // 
            this.btnResultadosCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnResultadosCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultadosCerrar.Location = new System.Drawing.Point(794, 326);
            this.btnResultadosCerrar.Name = "btnResultadosCerrar";
            this.btnResultadosCerrar.Size = new System.Drawing.Size(84, 32);
            this.btnResultadosCerrar.TabIndex = 2;
            this.btnResultadosCerrar.Text = "Cerrar";
            this.btnResultadosCerrar.UseVisualStyleBackColor = true;
            this.btnResultadosCerrar.Click += new System.EventHandler(this.btnResultadosCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Procentaje de Trenes que Superó \r\nel Máximo de Pasajeros Permitidos";
            // 
            // txtPorcTrenes
            // 
            this.txtPorcTrenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorcTrenes.Location = new System.Drawing.Point(307, 29);
            this.txtPorcTrenes.Name = "txtPorcTrenes";
            this.txtPorcTrenes.Size = new System.Drawing.Size(100, 21);
            this.txtPorcTrenes.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tiempo Promedio de Demora por Incidentes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Promedio de Pasajeros por Formacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "Promedio de Demora por Tiempo\r\nde Atención en Estacion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(510, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Consumo Promedio por Kilómetro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(510, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Consumo Promedio por Pasajero";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Costo por Kilómetro";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Costo por Pasajero";
            // 
            // txtTiemPro
            // 
            this.txtTiemPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTiemPro.Location = new System.Drawing.Point(307, 80);
            this.txtTiemPro.Name = "txtTiemPro";
            this.txtTiemPro.Size = new System.Drawing.Size(100, 21);
            this.txtTiemPro.TabIndex = 13;
            // 
            // txtPromPasaj
            // 
            this.txtPromPasaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPromPasaj.Location = new System.Drawing.Point(307, 128);
            this.txtPromPasaj.Name = "txtPromPasaj";
            this.txtPromPasaj.Size = new System.Drawing.Size(100, 21);
            this.txtPromPasaj.TabIndex = 14;
            // 
            // txtPromDem
            // 
            this.txtPromDem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPromDem.Location = new System.Drawing.Point(307, 174);
            this.txtPromDem.Name = "txtPromDem";
            this.txtPromDem.Size = new System.Drawing.Size(100, 21);
            this.txtPromDem.TabIndex = 15;
            // 
            // txtConsPorKm
            // 
            this.txtConsPorKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsPorKm.Location = new System.Drawing.Point(724, 233);
            this.txtConsPorKm.Name = "txtConsPorKm";
            this.txtConsPorKm.Size = new System.Drawing.Size(100, 21);
            this.txtConsPorKm.TabIndex = 16;
            // 
            // txtCostPorKm
            // 
            this.txtCostPorKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostPorKm.Location = new System.Drawing.Point(307, 233);
            this.txtCostPorKm.Name = "txtCostPorKm";
            this.txtCostPorKm.Size = new System.Drawing.Size(100, 21);
            this.txtCostPorKm.TabIndex = 17;
            // 
            // txtCostPorPasajero
            // 
            this.txtCostPorPasajero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostPorPasajero.Location = new System.Drawing.Point(307, 283);
            this.txtCostPorPasajero.Name = "txtCostPorPasajero";
            this.txtCostPorPasajero.Size = new System.Drawing.Size(100, 21);
            this.txtCostPorPasajero.TabIndex = 18;
            // 
            // txtConsPorPasajero
            // 
            this.txtConsPorPasajero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsPorPasajero.Location = new System.Drawing.Point(724, 286);
            this.txtConsPorPasajero.Name = "txtConsPorPasajero";
            this.txtConsPorPasajero.Size = new System.Drawing.Size(100, 21);
            this.txtConsPorPasajero.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(413, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "Minutos";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(413, 286);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 15);
            this.label10.TabIndex = 22;
            this.label10.Text = "$";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(413, 236);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 15);
            this.label11.TabIndex = 23;
            this.label11.Text = "$";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(413, 131);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 15);
            this.label12.TabIndex = 24;
            this.label12.Text = "Pasajeros";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(413, 177);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 15);
            this.label13.TabIndex = 25;
            this.label13.Text = "Minutos";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(830, 236);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 15);
            this.label14.TabIndex = 27;
            this.label14.Text = "$";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(830, 289);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(14, 15);
            this.label15.TabIndex = 26;
            this.label15.Text = "$";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(413, 32);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(18, 15);
            this.label16.TabIndex = 28;
            this.label16.Text = "%";
            // 
            // frmResultados
            // 
            this.AcceptButton = this.btnResultadosPdf;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnResultadosCerrar;
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmResultados";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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