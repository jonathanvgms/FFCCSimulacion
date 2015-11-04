namespace ffccSimulacion.Ayuda
{
    partial class frmAyuda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAyuda));
            this.pnlAyuda = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlAyuda.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAyuda
            // 
            this.pnlAyuda.Controls.Add(this.textBox1);
            this.pnlAyuda.Controls.Add(this.label2);
            this.pnlAyuda.Controls.Add(this.label1);
            this.pnlAyuda.Location = new System.Drawing.Point(1, 3);
            this.pnlAyuda.Name = "pnlAyuda";
            this.pnlAyuda.Size = new System.Drawing.Size(988, 500);
            this.pnlAyuda.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(178, 74);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(689, 383);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(174, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(403, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bienvenido a la Ayuda de SimuladorFFCC\r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 182);
            this.label1.TabIndex = 2;
            this.label1.Text = "Accesos Directos\n\nCtrl + X = Simulación\nCtrl + T = Traza\nCtrl + S = Servicio\nCtrl" +
    " + F = Formación\nCtrl + D = Coche\nCtrl + E = Estación\nCtrl + I = Incidente\nCtrl " +
    "+ A = Ayuda\nCtrl + Q = Salir\n\n\n\n";
            // 
            // frmAyuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 505);
            this.Controls.Add(this.pnlAyuda);
            this.Name = "frmAyuda";
            this.Text = "frmAyuda";
            this.pnlAyuda.ResumeLayout(false);
            this.pnlAyuda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnlAyuda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}