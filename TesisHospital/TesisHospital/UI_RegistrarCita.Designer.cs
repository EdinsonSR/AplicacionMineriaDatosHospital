namespace TesisHospital
{
    partial class UI_RegistrarCita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI_RegistrarCita));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.iconcerrar = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombresMed = new System.Windows.Forms.TextBox();
            this.txtMaternoMed = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPaternoMed = new System.Windows.Forms.TextBox();
            this.btnRegistrarCita = new System.Windows.Forms.Button();
            this.dtpHoraCita = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightGray;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(434, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "tspMenuEspecialidad";
            // 
            // iconcerrar
            // 
            this.iconcerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconcerrar.BackColor = System.Drawing.Color.LightGray;
            this.iconcerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconcerrar.Image = ((System.Drawing.Image)(resources.GetObject("iconcerrar.Image")));
            this.iconcerrar.Location = new System.Drawing.Point(400, 1);
            this.iconcerrar.Name = "iconcerrar";
            this.iconcerrar.Size = new System.Drawing.Size(24, 21);
            this.iconcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconcerrar.TabIndex = 18;
            this.iconcerrar.TabStop = false;
            this.iconcerrar.Click += new System.EventHandler(this.iconcerrar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.label7.Location = new System.Drawing.Point(52, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 16);
            this.label7.TabIndex = 53;
            this.label7.Text = "Hora:";
            // 
            // txtDni
            // 
            this.txtDni.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDni.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.txtDni.Location = new System.Drawing.Point(98, 34);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(124, 23);
            this.txtDni.TabIndex = 38;
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.label2.Location = new System.Drawing.Point(59, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 52;
            this.label2.Text = "DNI:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.label6.Location = new System.Drawing.Point(35, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 51;
            this.label6.Text = "Paterno:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.label1.Location = new System.Drawing.Point(27, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 47;
            this.label1.Text = "Nombres:";
            // 
            // txtNombresMed
            // 
            this.txtNombresMed.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombresMed.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.txtNombresMed.Location = new System.Drawing.Point(98, 96);
            this.txtNombresMed.Name = "txtNombresMed";
            this.txtNombresMed.Size = new System.Drawing.Size(324, 23);
            this.txtNombresMed.TabIndex = 41;
            // 
            // txtMaternoMed
            // 
            this.txtMaternoMed.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMaternoMed.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.txtMaternoMed.Location = new System.Drawing.Point(298, 65);
            this.txtMaternoMed.Name = "txtMaternoMed";
            this.txtMaternoMed.Size = new System.Drawing.Size(124, 23);
            this.txtMaternoMed.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.label5.Location = new System.Drawing.Point(232, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 50;
            this.label5.Text = "Materno:";
            // 
            // txtPaternoMed
            // 
            this.txtPaternoMed.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPaternoMed.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.txtPaternoMed.Location = new System.Drawing.Point(98, 65);
            this.txtPaternoMed.Name = "txtPaternoMed";
            this.txtPaternoMed.Size = new System.Drawing.Size(124, 23);
            this.txtPaternoMed.TabIndex = 39;
            // 
            // btnRegistrarCita
            // 
            this.btnRegistrarCita.BackColor = System.Drawing.Color.Teal;
            this.btnRegistrarCita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarCita.FlatAppearance.BorderSize = 0;
            this.btnRegistrarCita.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnRegistrarCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarCita.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarCita.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarCita.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrarCita.Image")));
            this.btnRegistrarCita.Location = new System.Drawing.Point(0, 170);
            this.btnRegistrarCita.Name = "btnRegistrarCita";
            this.btnRegistrarCita.Size = new System.Drawing.Size(434, 43);
            this.btnRegistrarCita.TabIndex = 46;
            this.btnRegistrarCita.Text = "  Registrar Cita";
            this.btnRegistrarCita.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrarCita.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrarCita.UseVisualStyleBackColor = false;
            this.btnRegistrarCita.Click += new System.EventHandler(this.btnRegistrarCita_Click);
            // 
            // dtpHoraCita
            // 
            this.dtpHoraCita.CalendarFont = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.dtpHoraCita.CustomFormat = "HH:mm";
            this.dtpHoraCita.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.dtpHoraCita.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraCita.Location = new System.Drawing.Point(98, 128);
            this.dtpHoraCita.Name = "dtpHoraCita";
            this.dtpHoraCita.ShowUpDown = true;
            this.dtpHoraCita.Size = new System.Drawing.Size(83, 23);
            this.dtpHoraCita.TabIndex = 54;
            // 
            // UI_RegistrarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 213);
            this.Controls.Add(this.dtpHoraCita);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombresMed);
            this.Controls.Add(this.txtMaternoMed);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPaternoMed);
            this.Controls.Add(this.btnRegistrarCita);
            this.Controls.Add(this.iconcerrar);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UI_RegistrarCita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UI_RegistrarCita";
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.PictureBox iconcerrar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombresMed;
        private System.Windows.Forms.TextBox txtMaternoMed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPaternoMed;
        private System.Windows.Forms.Button btnRegistrarCita;
        private System.Windows.Forms.DateTimePicker dtpHoraCita;
    }
}