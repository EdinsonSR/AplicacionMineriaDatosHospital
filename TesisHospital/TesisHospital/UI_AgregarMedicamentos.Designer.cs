namespace TesisHospital
{
    partial class UI_AgregarMedicamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI_AgregarMedicamentos));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.txtConcent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNombreArticulo = new System.Windows.Forms.TextBox();
            this.iconcerrar = new System.Windows.Forms.PictureBox();
            this.btnGuardarMedico = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.LightGray;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(324, 30);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // txtConcent
            // 
            this.txtConcent.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtConcent.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConcent.Location = new System.Drawing.Point(85, 83);
            this.txtConcent.Name = "txtConcent";
            this.txtConcent.Size = new System.Drawing.Size(227, 22);
            this.txtConcent.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Concent:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(22, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "Artículo:";
            // 
            // txtNombreArticulo
            // 
            this.txtNombreArticulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreArticulo.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreArticulo.Location = new System.Drawing.Point(85, 50);
            this.txtNombreArticulo.Name = "txtNombreArticulo";
            this.txtNombreArticulo.Size = new System.Drawing.Size(227, 22);
            this.txtNombreArticulo.TabIndex = 2;
            // 
            // iconcerrar
            // 
            this.iconcerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconcerrar.BackColor = System.Drawing.Color.LightGray;
            this.iconcerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconcerrar.Image = ((System.Drawing.Image)(resources.GetObject("iconcerrar.Image")));
            this.iconcerrar.Location = new System.Drawing.Point(284, 4);
            this.iconcerrar.Name = "iconcerrar";
            this.iconcerrar.Size = new System.Drawing.Size(28, 23);
            this.iconcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconcerrar.TabIndex = 16;
            this.iconcerrar.TabStop = false;
            this.iconcerrar.Click += new System.EventHandler(this.iconcerrar_Click);
            // 
            // btnGuardarMedico
            // 
            this.btnGuardarMedico.BackColor = System.Drawing.Color.Teal;
            this.btnGuardarMedico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarMedico.FlatAppearance.BorderSize = 0;
            this.btnGuardarMedico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnGuardarMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarMedico.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarMedico.ForeColor = System.Drawing.Color.White;
            this.btnGuardarMedico.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarMedico.Image")));
            this.btnGuardarMedico.Location = new System.Drawing.Point(0, 123);
            this.btnGuardarMedico.Name = "btnGuardarMedico";
            this.btnGuardarMedico.Size = new System.Drawing.Size(324, 37);
            this.btnGuardarMedico.TabIndex = 17;
            this.btnGuardarMedico.Text = "Guardar";
            this.btnGuardarMedico.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarMedico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarMedico.UseVisualStyleBackColor = false;
            this.btnGuardarMedico.Click += new System.EventHandler(this.btnGuardarMedico_Click);
            // 
            // UI_AgregarMedicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 160);
            this.Controls.Add(this.txtConcent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardarMedico);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.iconcerrar);
            this.Controls.Add(this.txtNombreArticulo);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UI_AgregarMedicamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Medicamento";
            this.Load += new System.EventHandler(this.UI_AgregarMedicamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNombreArticulo;
        private System.Windows.Forms.TextBox txtConcent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox iconcerrar;
        private System.Windows.Forms.Button btnGuardarMedico;
    }
}