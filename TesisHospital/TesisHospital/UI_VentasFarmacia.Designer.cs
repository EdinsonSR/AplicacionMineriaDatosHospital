namespace TesisHospital
{
    partial class UI_VentasFarmacia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI_VentasFarmacia));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tspGuardarMedico = new System.Windows.Forms.ToolStripButton();
            this.tsbBuscarPaciente = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.LightGray;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbBuscarPaciente,
            this.tspGuardarMedico});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(870, 40);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tspGuardarMedico
            // 
            this.tspGuardarMedico.AutoSize = false;
            this.tspGuardarMedico.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tspGuardarMedico.Image = ((System.Drawing.Image)(resources.GetObject("tspGuardarMedico.Image")));
            this.tspGuardarMedico.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tspGuardarMedico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspGuardarMedico.Margin = new System.Windows.Forms.Padding(0);
            this.tspGuardarMedico.Name = "tspGuardarMedico";
            this.tspGuardarMedico.Size = new System.Drawing.Size(40, 40);
            this.tspGuardarMedico.Text = "Guardar";
            // 
            // tsbBuscarPaciente
            // 
            this.tsbBuscarPaciente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBuscarPaciente.Image = ((System.Drawing.Image)(resources.GetObject("tsbBuscarPaciente.Image")));
            this.tsbBuscarPaciente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbBuscarPaciente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBuscarPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.tsbBuscarPaciente.Name = "tsbBuscarPaciente";
            this.tsbBuscarPaciente.Size = new System.Drawing.Size(29, 32);
            this.tsbBuscarPaciente.Text = "Buscar ";
            this.tsbBuscarPaciente.Click += new System.EventHandler(this.tsbBuscarPaciente_Click);
            // 
            // UI_VentasFarmacia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 614);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UI_VentasFarmacia";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "UI_VentasFarmacia";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tspGuardarMedico;
        private System.Windows.Forms.ToolStripButton tsbBuscarPaciente;
    }
}