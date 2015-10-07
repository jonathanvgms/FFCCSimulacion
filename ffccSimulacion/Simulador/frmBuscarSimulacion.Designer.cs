namespace ffccSimulacion.Simulador
{
    partial class frmBuscarSimulacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarSimulacion));
            this.btnBuscSimSelec = new System.Windows.Forms.Button();
            this.lBoxBuscSimList = new System.Windows.Forms.ListBox();
            this.btnBuscSimCanc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBuscSimSelec
            // 
            this.btnBuscSimSelec.Location = new System.Drawing.Point(195, 321);
            this.btnBuscSimSelec.Name = "btnBuscSimSelec";
            this.btnBuscSimSelec.Size = new System.Drawing.Size(75, 23);
            this.btnBuscSimSelec.TabIndex = 0;
            this.btnBuscSimSelec.Text = "Seleccionar";
            this.btnBuscSimSelec.UseVisualStyleBackColor = true;
            this.btnBuscSimSelec.Click += new System.EventHandler(this.button1_Click);
            // 
            // lBoxBuscSimList
            // 
            this.lBoxBuscSimList.DisplayMember = "Nombre";
            this.lBoxBuscSimList.FormattingEnabled = true;
            this.lBoxBuscSimList.Location = new System.Drawing.Point(3, 38);
            this.lBoxBuscSimList.Name = "lBoxBuscSimList";
            this.lBoxBuscSimList.Size = new System.Drawing.Size(348, 277);
            this.lBoxBuscSimList.TabIndex = 1;
            this.lBoxBuscSimList.ValueMember = "Id";
            // 
            // btnBuscSimCanc
            // 
            this.btnBuscSimCanc.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBuscSimCanc.Location = new System.Drawing.Point(276, 321);
            this.btnBuscSimCanc.Name = "btnBuscSimCanc";
            this.btnBuscSimCanc.Size = new System.Drawing.Size(75, 23);
            this.btnBuscSimCanc.TabIndex = 2;
            this.btnBuscSimCanc.Text = "Cancelar";
            this.btnBuscSimCanc.UseVisualStyleBackColor = true;
            this.btnBuscSimCanc.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Listado de Simulaciones";
            // 
            // frmBuscarSimulacion
            // 
            this.AcceptButton = this.btnBuscSimSelec;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnBuscSimCanc;
            this.ClientSize = new System.Drawing.Size(356, 350);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscSimCanc);
            this.Controls.Add(this.lBoxBuscSimList);
            this.Controls.Add(this.btnBuscSimSelec);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBuscarSimulacion";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cargar Simulación";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscSimSelec;
        private System.Windows.Forms.ListBox lBoxBuscSimList;
        private System.Windows.Forms.Button btnBuscSimCanc;
        private System.Windows.Forms.Label label1;
    }
}