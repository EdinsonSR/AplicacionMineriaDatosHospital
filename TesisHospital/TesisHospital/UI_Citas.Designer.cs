namespace TesisHospital
{
    partial class UI_Citas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI_Citas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tspGuardarCitas = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpFechaCita = new System.Windows.Forms.DateTimePicker();
            this.cbxEspecialidadMedico = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMedicamentosGuia = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxMedico = new System.Windows.Forms.ComboBox();
            this.btnlogoInicio = new System.Windows.Forms.PictureBox();
            this.itemGuiaMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaCita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacienteCita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoCita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentosGuia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnlogoInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.LightGray;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspGuardarCitas});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(958, 40);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tspGuardarCitas
            // 
            this.tspGuardarCitas.AutoSize = false;
            this.tspGuardarCitas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tspGuardarCitas.Image = ((System.Drawing.Image)(resources.GetObject("tspGuardarCitas.Image")));
            this.tspGuardarCitas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tspGuardarCitas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspGuardarCitas.Margin = new System.Windows.Forms.Padding(0);
            this.tspGuardarCitas.Name = "tspGuardarCitas";
            this.tspGuardarCitas.Size = new System.Drawing.Size(40, 40);
            this.tspGuardarCitas.Text = "Guardar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.label2.Location = new System.Drawing.Point(6, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Especialidad:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnlogoInicio);
            this.panel1.Controls.Add(this.cbxMedico);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbxEspecialidadMedico);
            this.panel1.Controls.Add(this.dtpFechaCita);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 514);
            this.panel1.TabIndex = 12;
            // 
            // dtpFechaCita
            // 
            this.dtpFechaCita.CalendarFont = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.dtpFechaCita.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.dtpFechaCita.Location = new System.Drawing.Point(6, 95);
            this.dtpFechaCita.Name = "dtpFechaCita";
            this.dtpFechaCita.Size = new System.Drawing.Size(237, 23);
            this.dtpFechaCita.TabIndex = 12;
            this.dtpFechaCita.Value = new System.DateTime(2019, 3, 21, 20, 56, 0, 0);
            // 
            // cbxEspecialidadMedico
            // 
            this.cbxEspecialidadMedico.BackColor = System.Drawing.SystemColors.Window;
            this.cbxEspecialidadMedico.DropDownHeight = 86;
            this.cbxEspecialidadMedico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEspecialidadMedico.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.cbxEspecialidadMedico.FormattingEnabled = true;
            this.cbxEspecialidadMedico.IntegralHeight = false;
            this.cbxEspecialidadMedico.Location = new System.Drawing.Point(6, 31);
            this.cbxEspecialidadMedico.Name = "cbxEspecialidadMedico";
            this.cbxEspecialidadMedico.Size = new System.Drawing.Size(237, 24);
            this.cbxEspecialidadMedico.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.label1.Location = new System.Drawing.Point(6, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Fecha:";
            // 
            // dgvMedicamentosGuia
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMedicamentosGuia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMedicamentosGuia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicamentosGuia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemGuiaMedicamento,
            this.horaCita,
            this.pacienteCita,
            this.estadoCita});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift Light", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMedicamentosGuia.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMedicamentosGuia.Location = new System.Drawing.Point(270, 52);
            this.dgvMedicamentosGuia.Name = "dgvMedicamentosGuia";
            this.dgvMedicamentosGuia.RowHeadersVisible = false;
            this.dgvMedicamentosGuia.Size = new System.Drawing.Size(676, 514);
            this.dgvMedicamentosGuia.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.label3.Location = new System.Drawing.Point(6, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Médico";
            // 
            // cbxMedico
            // 
            this.cbxMedico.BackColor = System.Drawing.SystemColors.Window;
            this.cbxMedico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMedico.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.cbxMedico.FormattingEnabled = true;
            this.cbxMedico.Location = new System.Drawing.Point(6, 169);
            this.cbxMedico.Name = "cbxMedico";
            this.cbxMedico.Size = new System.Drawing.Size(237, 24);
            this.cbxMedico.TabIndex = 16;
            // 
            // btnlogoInicio
            // 
            this.btnlogoInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogoInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnlogoInicio.Image")));
            this.btnlogoInicio.Location = new System.Drawing.Point(1, 438);
            this.btnlogoInicio.Margin = new System.Windows.Forms.Padding(0);
            this.btnlogoInicio.Name = "btnlogoInicio";
            this.btnlogoInicio.Size = new System.Drawing.Size(250, 73);
            this.btnlogoInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnlogoInicio.TabIndex = 17;
            this.btnlogoInicio.TabStop = false;
            // 
            // itemGuiaMedicamento
            // 
            this.itemGuiaMedicamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.itemGuiaMedicamento.HeaderText = "Item";
            this.itemGuiaMedicamento.Name = "itemGuiaMedicamento";
            this.itemGuiaMedicamento.Width = 50;
            // 
            // horaCita
            // 
            this.horaCita.HeaderText = "Hora";
            this.horaCita.Name = "horaCita";
            // 
            // pacienteCita
            // 
            this.pacienteCita.HeaderText = "Paciente";
            this.pacienteCita.Name = "pacienteCita";
            this.pacienteCita.Width = 300;
            // 
            // estadoCita
            // 
            this.estadoCita.HeaderText = "Estado";
            this.estadoCita.Name = "estadoCita";
            this.estadoCita.Width = 150;
            // 
            // UI_Citas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 573);
            this.Controls.Add(this.dgvMedicamentosGuia);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UI_Citas";
            this.Text = "l";
            this.Load += new System.EventHandler(this.UI_Citas_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentosGuia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnlogoInicio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tspGuardarCitas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpFechaCita;
        private System.Windows.Forms.ComboBox cbxEspecialidadMedico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxMedico;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvMedicamentosGuia;
        private System.Windows.Forms.PictureBox btnlogoInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemGuiaMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaCita;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacienteCita;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoCita;
    }
}