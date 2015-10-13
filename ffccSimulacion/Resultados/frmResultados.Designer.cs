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
            this.label1 = new System.Windows.Forms.Label();
            this.btnResultadosPdf = new System.Windows.Forms.Button();
            this.btnResultadosCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(375, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aca deberia ir los resultados de la simulacion";
            // 
            // btnResultadosPdf
            // 
            this.btnResultadosPdf.Location = new System.Drawing.Point(12, 470);
            this.btnResultadosPdf.Name = "btnResultadosPdf";
            this.btnResultadosPdf.Size = new System.Drawing.Size(110, 23);
            this.btnResultadosPdf.TabIndex = 1;
            this.btnResultadosPdf.Text = "Guardar en pdf";
            this.btnResultadosPdf.UseVisualStyleBackColor = true;
            // 
            // btnResultadosCerrar
            // 
            this.btnResultadosCerrar.Location = new System.Drawing.Point(919, 470);
            this.btnResultadosCerrar.Name = "btnResultadosCerrar";
            this.btnResultadosCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnResultadosCerrar.TabIndex = 2;
            this.btnResultadosCerrar.Text = "Cerrar";
            this.btnResultadosCerrar.UseVisualStyleBackColor = true;
            this.btnResultadosCerrar.Click += new System.EventHandler(this.btnResultadosCerrar_Click);
            // 
            // frmResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 505);
            this.Controls.Add(this.btnResultadosCerrar);
            this.Controls.Add(this.btnResultadosPdf);
            this.Controls.Add(this.label1);
            this.Name = "frmResultados";
            this.Text = "frmResultados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnResultadosPdf;
        private System.Windows.Forms.Button btnResultadosCerrar;
    }
}