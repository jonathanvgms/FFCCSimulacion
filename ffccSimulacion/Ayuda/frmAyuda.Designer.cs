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
            this.pnlAyuda = new System.Windows.Forms.Panel();
            this.txtAyuda = new System.Windows.Forms.TextBox();
            this.btnAyudaCerrar = new System.Windows.Forms.Button();
            this.pnlAyuda.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAyuda
            // 
            this.pnlAyuda.Controls.Add(this.btnAyudaCerrar);
            this.pnlAyuda.Controls.Add(this.txtAyuda);
            this.pnlAyuda.Location = new System.Drawing.Point(1, 3);
            this.pnlAyuda.Name = "pnlAyuda";
            this.pnlAyuda.Size = new System.Drawing.Size(988, 500);
            this.pnlAyuda.TabIndex = 0;
            // 
            // txtAyuda
            // 
            this.txtAyuda.Location = new System.Drawing.Point(11, 9);
            this.txtAyuda.Multiline = true;
            this.txtAyuda.Name = "txtAyuda";
            this.txtAyuda.Size = new System.Drawing.Size(964, 144);
            this.txtAyuda.TabIndex = 0;
            this.txtAyuda.Text = "Aca deberia estar explicada la lógica del sistema, como crear formaciones, servic" +
    "ios, trazas y demas....";
            // 
            // btnAyudaCerrar
            // 
            this.btnAyudaCerrar.Location = new System.Drawing.Point(900, 467);
            this.btnAyudaCerrar.Name = "btnAyudaCerrar";
            this.btnAyudaCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnAyudaCerrar.TabIndex = 1;
            this.btnAyudaCerrar.Text = "Cerrar";
            this.btnAyudaCerrar.UseVisualStyleBackColor = true;
            this.btnAyudaCerrar.Click += new System.EventHandler(this.btnAyudaCerrar_Click);
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

        private System.Windows.Forms.Button btnAyudaCerrar;
        private System.Windows.Forms.TextBox txtAyuda;
        public System.Windows.Forms.Panel pnlAyuda;
    }
}