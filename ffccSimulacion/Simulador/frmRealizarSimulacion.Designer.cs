﻿namespace ffccSimulacion.Simulador
{
    partial class frmRealizarSimulacion
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
            this.pnlSimulador = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.lbxFormaciones = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lBoxSimServicios = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSimDuracion = new System.Windows.Forms.TextBox();
            this.lBoxSimTrazas = new System.Windows.Forms.ListBox();
            this.btnReaSimCargSim = new System.Windows.Forms.Button();
            this.btnSimGuardar = new System.Windows.Forms.Button();
            this.btnSimular = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSimFrecuencia = new System.Windows.Forms.TextBox();
            this.tbSimNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSimulador.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSimulador
            // 
            this.pnlSimulador.AutoSize = true;
            this.pnlSimulador.Controls.Add(this.label8);
            this.pnlSimulador.Controls.Add(this.lbxFormaciones);
            this.pnlSimulador.Controls.Add(this.label7);
            this.pnlSimulador.Controls.Add(this.label6);
            this.pnlSimulador.Controls.Add(this.lBoxSimServicios);
            this.pnlSimulador.Controls.Add(this.label4);
            this.pnlSimulador.Controls.Add(this.tbSimDuracion);
            this.pnlSimulador.Controls.Add(this.lBoxSimTrazas);
            this.pnlSimulador.Controls.Add(this.btnReaSimCargSim);
            this.pnlSimulador.Controls.Add(this.btnSimGuardar);
            this.pnlSimulador.Controls.Add(this.btnSimular);
            this.pnlSimulador.Controls.Add(this.button2);
            this.pnlSimulador.Controls.Add(this.button1);
            this.pnlSimulador.Controls.Add(this.label5);
            this.pnlSimulador.Controls.Add(this.label3);
            this.pnlSimulador.Controls.Add(this.label2);
            this.pnlSimulador.Controls.Add(this.tbSimFrecuencia);
            this.pnlSimulador.Controls.Add(this.tbSimNombre);
            this.pnlSimulador.Controls.Add(this.label1);
            this.pnlSimulador.Location = new System.Drawing.Point(12, 12);
            this.pnlSimulador.Name = "pnlSimulador";
            this.pnlSimulador.Size = new System.Drawing.Size(1020, 385);
            this.pnlSimulador.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(777, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(196, 15);
            this.label8.TabIndex = 33;
            this.label8.Text = "Formaciones Asignadas a la Traza";
            // 
            // lbxFormaciones
            // 
            this.lbxFormaciones.DisplayMember = "NombreFormacion";
            this.lbxFormaciones.Enabled = false;
            this.lbxFormaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxFormaciones.FormattingEnabled = true;
            this.lbxFormaciones.ItemHeight = 15;
            this.lbxFormaciones.Location = new System.Drawing.Point(780, 21);
            this.lbxFormaciones.Name = "lbxFormaciones";
            this.lbxFormaciones.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbxFormaciones.Size = new System.Drawing.Size(225, 289);
            this.lbxFormaciones.Sorted = true;
            this.lbxFormaciones.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(180, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 15);
            this.label7.TabIndex = 31;
            this.label7.Text = "Horas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(180, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 30;
            this.label6.Text = "Minutos";
            // 
            // lBoxSimServicios
            // 
            this.lBoxSimServicios.DisplayMember = "Nombre";
            this.lBoxSimServicios.Enabled = false;
            this.lBoxSimServicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBoxSimServicios.FormattingEnabled = true;
            this.lBoxSimServicios.ItemHeight = 15;
            this.lBoxSimServicios.Location = new System.Drawing.Point(528, 21);
            this.lBoxSimServicios.Name = "lBoxSimServicios";
            this.lBoxSimServicios.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lBoxSimServicios.Size = new System.Drawing.Size(225, 289);
            this.lBoxSimServicios.Sorted = true;
            this.lBoxSimServicios.TabIndex = 29;
            this.lBoxSimServicios.ValueMember = "Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "Duración de la Simulación";
            // 
            // tbSimDuracion
            // 
            this.tbSimDuracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSimDuracion.Location = new System.Drawing.Point(25, 237);
            this.tbSimDuracion.MaxLength = 9;
            this.tbSimDuracion.Name = "tbSimDuracion";
            this.tbSimDuracion.Size = new System.Drawing.Size(149, 21);
            this.tbSimDuracion.TabIndex = 28;
            // 
            // lBoxSimTrazas
            // 
            this.lBoxSimTrazas.DisplayMember = "Nombre";
            this.lBoxSimTrazas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBoxSimTrazas.FormattingEnabled = true;
            this.lBoxSimTrazas.ItemHeight = 15;
            this.lBoxSimTrazas.Location = new System.Drawing.Point(272, 23);
            this.lBoxSimTrazas.Name = "lBoxSimTrazas";
            this.lBoxSimTrazas.Size = new System.Drawing.Size(225, 289);
            this.lBoxSimTrazas.Sorted = true;
            this.lBoxSimTrazas.TabIndex = 25;
            this.lBoxSimTrazas.ValueMember = "Id";
            this.lBoxSimTrazas.SelectedIndexChanged += new System.EventHandler(this.lBoxSimTrazas_SelectedIndexChanged);
            // 
            // btnReaSimCargSim
            // 
            this.btnReaSimCargSim.AccessibleDescription = "";
            this.btnReaSimCargSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReaSimCargSim.Location = new System.Drawing.Point(153, 343);
            this.btnReaSimCargSim.Name = "btnReaSimCargSim";
            this.btnReaSimCargSim.Size = new System.Drawing.Size(139, 35);
            this.btnReaSimCargSim.TabIndex = 24;
            this.btnReaSimCargSim.Text = "Buscar Simulación";
            this.btnReaSimCargSim.UseVisualStyleBackColor = true;
            this.btnReaSimCargSim.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnSimGuardar
            // 
            this.btnSimGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimGuardar.Location = new System.Drawing.Point(6, 343);
            this.btnSimGuardar.Name = "btnSimGuardar";
            this.btnSimGuardar.Size = new System.Drawing.Size(141, 35);
            this.btnSimGuardar.TabIndex = 23;
            this.btnSimGuardar.Text = "Guardar Simulación";
            this.btnSimGuardar.UseVisualStyleBackColor = true;
            this.btnSimGuardar.Click += new System.EventHandler(this.btnSimGuardar_Click);
            // 
            // btnSimular
            // 
            this.btnSimular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimular.Location = new System.Drawing.Point(783, 343);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(108, 35);
            this.btnSimular.TabIndex = 22;
            this.btnSimular.Text = "Simular";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(897, 343);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 35);
            this.button2.TabIndex = 21;
            this.button2.Text = "Cerrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(298, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 35);
            this.button1.TabIndex = 20;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 30);
            this.label5.TabIndex = 14;
            this.label5.Text = "Frecuencia de Salida de \r\nlas Formaciones";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(525, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Servicios Asignados a la Traza";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(269, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Trazas Existentes";
            // 
            // tbSimFrecuencia
            // 
            this.tbSimFrecuencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSimFrecuencia.Location = new System.Drawing.Point(25, 154);
            this.tbSimFrecuencia.MaxLength = 9;
            this.tbSimFrecuencia.Name = "tbSimFrecuencia";
            this.tbSimFrecuencia.Size = new System.Drawing.Size(149, 21);
            this.tbSimFrecuencia.TabIndex = 18;
            // 
            // tbSimNombre
            // 
            this.tbSimNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSimNombre.Location = new System.Drawing.Point(25, 74);
            this.tbSimNombre.MaxLength = 99;
            this.tbSimNombre.Name = "tbSimNombre";
            this.tbSimNombre.Size = new System.Drawing.Size(149, 21);
            this.tbSimNombre.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nombre";
            // 
            // frmRealizarSimulacion
            // 
            this.AcceptButton = this.btnSimular;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(1044, 405);
            this.Controls.Add(this.pnlSimulador);
            this.Name = "frmRealizarSimulacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Simulación";
            this.pnlSimulador.ResumeLayout(false);
            this.pnlSimulador.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSimDuracion;
        private System.Windows.Forms.ListBox lBoxSimTrazas;
        private System.Windows.Forms.Button btnReaSimCargSim;
        private System.Windows.Forms.Button btnSimGuardar;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSimFrecuencia;
        private System.Windows.Forms.TextBox tbSimNombre;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel pnlSimulador;
        private System.Windows.Forms.ListBox lBoxSimServicios;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lbxFormaciones;

    }
}