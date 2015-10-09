namespace ffccSimulacion.Simulador
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
            this.pnlSimulador.Size = new System.Drawing.Size(888, 383);
            this.pnlSimulador.TabIndex = 14;
            // 
            // lBoxSimServicios
            // 
            this.lBoxSimServicios.DisplayMember = "Nombre";
            this.lBoxSimServicios.FormattingEnabled = true;
            this.lBoxSimServicios.Location = new System.Drawing.Point(631, 21);
            this.lBoxSimServicios.Name = "lBoxSimServicios";
            this.lBoxSimServicios.Size = new System.Drawing.Size(247, 290);
            this.lBoxSimServicios.TabIndex = 29;
            this.lBoxSimServicios.ValueMember = "Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Duración";
            // 
            // tbSimDuracion
            // 
            this.tbSimDuracion.Location = new System.Drawing.Point(125, 186);
            this.tbSimDuracion.Name = "tbSimDuracion";
            this.tbSimDuracion.Size = new System.Drawing.Size(194, 20);
            this.tbSimDuracion.TabIndex = 28;
            // 
            // lBoxSimTrazas
            // 
            this.lBoxSimTrazas.DisplayMember = "Nombre";
            this.lBoxSimTrazas.FormattingEnabled = true;
            this.lBoxSimTrazas.Location = new System.Drawing.Point(351, 21);
            this.lBoxSimTrazas.Name = "lBoxSimTrazas";
            this.lBoxSimTrazas.Size = new System.Drawing.Size(247, 290);
            this.lBoxSimTrazas.TabIndex = 25;
            this.lBoxSimTrazas.ValueMember = "Id";
            this.lBoxSimTrazas.SelectedIndexChanged += new System.EventHandler(this.lBoxSimTrazas_SelectedIndexChanged);
            // 
            // btnReaSimCargSim
            // 
            this.btnReaSimCargSim.AccessibleDescription = "";
            this.btnReaSimCargSim.Location = new System.Drawing.Point(132, 355);
            this.btnReaSimCargSim.Name = "btnReaSimCargSim";
            this.btnReaSimCargSim.Size = new System.Drawing.Size(120, 23);
            this.btnReaSimCargSim.TabIndex = 24;
            this.btnReaSimCargSim.Text = "Cargar Simulacion";
            this.btnReaSimCargSim.UseVisualStyleBackColor = true;
            this.btnReaSimCargSim.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnSimGuardar
            // 
            this.btnSimGuardar.Location = new System.Drawing.Point(6, 355);
            this.btnSimGuardar.Name = "btnSimGuardar";
            this.btnSimGuardar.Size = new System.Drawing.Size(120, 23);
            this.btnSimGuardar.TabIndex = 23;
            this.btnSimGuardar.Text = "Guardar Simulacion";
            this.btnSimGuardar.UseVisualStyleBackColor = true;
            this.btnSimGuardar.Click += new System.EventHandler(this.btnSimGuardar_Click);
            // 
            // btnSimular
            // 
            this.btnSimular.Location = new System.Drawing.Point(727, 355);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(75, 23);
            this.btnSimular.TabIndex = 22;
            this.btnSimular.Text = "Simular";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(808, 355);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(258, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Frecuencia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(628, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Servicios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Trazas";
            // 
            // tbSimFrecuencia
            // 
            this.tbSimFrecuencia.Location = new System.Drawing.Point(125, 148);
            this.tbSimFrecuencia.Name = "tbSimFrecuencia";
            this.tbSimFrecuencia.Size = new System.Drawing.Size(194, 20);
            this.tbSimFrecuencia.TabIndex = 18;
            // 
            // tbSimNombre
            // 
            this.tbSimNombre.Location = new System.Drawing.Point(125, 104);
            this.tbSimNombre.Name = "tbSimNombre";
            this.tbSimNombre.Size = new System.Drawing.Size(194, 20);
            this.tbSimNombre.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nombre";
            // 
            // frmRealizarSimulacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 405);
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

    }
}