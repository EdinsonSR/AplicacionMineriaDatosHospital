namespace TesisHospital
{
    partial class UI_BuscarPaciente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI_BuscarPaciente));
            this.dgvProveedor = new System.Windows.Forms.DataGridView();
            this.rdbPaciente = new System.Windows.Forms.RadioButton();
            this.rdbDNI = new System.Windows.Forms.RadioButton();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.iconcerrar = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Prefactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacienteNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaAtencion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProveedor
            // 
            this.dgvProveedor.AllowUserToAddRows = false;
            this.dgvProveedor.AllowUserToDeleteRows = false;
            this.dgvProveedor.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProveedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Prefactura,
            this.pacienteNombres,
            this.dniPaciente,
            this.fechaAtencion});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift Light", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProveedor.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProveedor.Location = new System.Drawing.Point(13, 99);
            this.dgvProveedor.MultiSelect = false;
            this.dgvProveedor.Name = "dgvProveedor";
            this.dgvProveedor.RowHeadersVisible = false;
            this.dgvProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProveedor.Size = new System.Drawing.Size(471, 153);
            this.dgvProveedor.TabIndex = 22;
            // 
            // rdbPaciente
            // 
            this.rdbPaciente.AutoSize = true;
            this.rdbPaciente.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.rdbPaciente.Location = new System.Drawing.Point(13, 70);
            this.rdbPaciente.Name = "rdbPaciente";
            this.rdbPaciente.Size = new System.Drawing.Size(75, 20);
            this.rdbPaciente.TabIndex = 20;
            this.rdbPaciente.TabStop = true;
            this.rdbPaciente.Text = "Paciente";
            this.rdbPaciente.UseVisualStyleBackColor = true;
            this.rdbPaciente.CheckedChanged += new System.EventHandler(this.rdbPaciente_CheckedChanged);
            // 
            // rdbDNI
            // 
            this.rdbDNI.AutoSize = true;
            this.rdbDNI.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.rdbDNI.Location = new System.Drawing.Point(13, 43);
            this.rdbDNI.Name = "rdbDNI";
            this.rdbDNI.Size = new System.Drawing.Size(48, 20);
            this.rdbDNI.TabIndex = 19;
            this.rdbDNI.TabStop = true;
            this.rdbDNI.Text = "DNI";
            this.rdbDNI.UseVisualStyleBackColor = true;
            this.rdbDNI.CheckedChanged += new System.EventHandler(this.rdbDNI_CheckedChanged);
            // 
            // txtPaciente
            // 
            this.txtPaciente.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtPaciente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPaciente.Enabled = false;
            this.txtPaciente.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaciente.Location = new System.Drawing.Point(94, 69);
            this.txtPaciente.MaxLength = 100;
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Size = new System.Drawing.Size(379, 22);
            this.txtPaciente.TabIndex = 18;
            // 
            // txtDNI
            // 
            this.txtDNI.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtDNI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDNI.Enabled = false;
            this.txtDNI.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNI.Location = new System.Drawing.Point(94, 42);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(145, 22);
            this.txtDNI.TabIndex = 17;
            this.txtDNI.TextChanged += new System.EventHandler(this.txtDNI_TextChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.LightGray;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(494, 30);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 23;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // iconcerrar
            // 
            this.iconcerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconcerrar.BackColor = System.Drawing.Color.LightGray;
            this.iconcerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconcerrar.Image = ((System.Drawing.Image)(resources.GetObject("iconcerrar.Image")));
            this.iconcerrar.Location = new System.Drawing.Point(456, 3);
            this.iconcerrar.Name = "iconcerrar";
            this.iconcerrar.Size = new System.Drawing.Size(28, 23);
            this.iconcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconcerrar.TabIndex = 24;
            this.iconcerrar.TabStop = false;
            this.iconcerrar.Click += new System.EventHandler(this.iconcerrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(261, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "DE PREFERENCIA BUSCAR POR DNI";
            // 
            // Prefactura
            // 
            this.Prefactura.HeaderText = "Prefactura";
            this.Prefactura.Name = "Prefactura";
            this.Prefactura.Width = 80;
            // 
            // pacienteNombres
            // 
            this.pacienteNombres.HeaderText = "Paciente";
            this.pacienteNombres.Name = "pacienteNombres";
            this.pacienteNombres.Width = 200;
            // 
            // dniPaciente
            // 
            this.dniPaciente.HeaderText = "DNI";
            this.dniPaciente.Name = "dniPaciente";
            this.dniPaciente.Width = 80;
            // 
            // fechaAtencion
            // 
            this.fechaAtencion.HeaderText = "Fecha de Atención";
            this.fechaAtencion.Name = "fechaAtencion";
            // 
            // UI_BuscarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 263);
            this.Controls.Add(this.iconcerrar);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvProveedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rdbPaciente);
            this.Controls.Add(this.rdbDNI);
            this.Controls.Add(this.txtPaciente);
            this.Controls.Add(this.txtDNI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UI_BuscarPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UI_BuscarPaciente";
            this.Load += new System.EventHandler(this.UI_BuscarPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProveedor;
        private System.Windows.Forms.RadioButton rdbPaciente;
        private System.Windows.Forms.RadioButton rdbDNI;
        private System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prefactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacienteNombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaAtencion;
        private System.Windows.Forms.PictureBox iconcerrar;
        private System.Windows.Forms.Label label2;
    }
}