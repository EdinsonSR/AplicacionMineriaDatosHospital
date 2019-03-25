namespace TesisHospital
{
	partial class UI_HorariosPorMedicos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI_HorariosPorMedicos));
            this.label6 = new System.Windows.Forms.Label();
            this.txtmedCol = new System.Windows.Forms.TextBox();
            this.dgvMedicos = new System.Windows.Forms.DataGridView();
            this.paternoMed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaternoMed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresMed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consultorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbReporteMedico = new System.Windows.Forms.ToolStripButton();
            this.iconcerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.label6.Location = new System.Drawing.Point(9, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "CMP:";
            // 
            // txtmedCol
            // 
            this.txtmedCol.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtmedCol.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.txtmedCol.Location = new System.Drawing.Point(51, 47);
            this.txtmedCol.Name = "txtmedCol";
            this.txtmedCol.Size = new System.Drawing.Size(141, 23);
            this.txtmedCol.TabIndex = 11;
            this.txtmedCol.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtmedCol_KeyUp);
            // 
            // dgvMedicos
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.dgvMedicos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMedicos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.paternoMed,
            this.MaternoMed,
            this.nombresMed,
            this.fechaInicio,
            this.fechaFin,
            this.horaInicio,
            this.horaFinal,
            this.consultorio});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMedicos.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMedicos.Location = new System.Drawing.Point(12, 80);
            this.dgvMedicos.Name = "dgvMedicos";
            this.dgvMedicos.RowHeadersVisible = false;
            this.dgvMedicos.Size = new System.Drawing.Size(754, 257);
            this.dgvMedicos.TabIndex = 12;
            // 
            // paternoMed
            // 
            this.paternoMed.HeaderText = "Paterno";
            this.paternoMed.Name = "paternoMed";
            // 
            // MaternoMed
            // 
            this.MaternoMed.HeaderText = "Materno";
            this.MaternoMed.Name = "MaternoMed";
            // 
            // nombresMed
            // 
            this.nombresMed.HeaderText = "Nombres";
            this.nombresMed.Name = "nombresMed";
            this.nombresMed.Width = 200;
            // 
            // fechaInicio
            // 
            this.fechaInicio.HeaderText = "Fecha Inicio";
            this.fechaInicio.Name = "fechaInicio";
            this.fechaInicio.Width = 80;
            // 
            // fechaFin
            // 
            this.fechaFin.HeaderText = "Fecha Fin";
            this.fechaFin.Name = "fechaFin";
            this.fechaFin.Width = 80;
            // 
            // horaInicio
            // 
            this.horaInicio.HeaderText = "Hora Inicio";
            this.horaInicio.Name = "horaInicio";
            this.horaInicio.Width = 50;
            // 
            // horaFinal
            // 
            this.horaFinal.HeaderText = "Hora Final";
            this.horaFinal.Name = "horaFinal";
            this.horaFinal.Width = 50;
            // 
            // consultorio
            // 
            this.consultorio.HeaderText = "Consultorio";
            this.consultorio.Name = "consultorio";
            this.consultorio.Width = 80;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.LightGray;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbReporteMedico});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(777, 37);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbReporteMedico
            // 
            this.tsbReporteMedico.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbReporteMedico.Image = ((System.Drawing.Image)(resources.GetObject("tsbReporteMedico.Image")));
            this.tsbReporteMedico.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbReporteMedico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReporteMedico.Name = "tsbReporteMedico";
            this.tsbReporteMedico.Size = new System.Drawing.Size(29, 34);
            this.tsbReporteMedico.Text = "Exportar";
            this.tsbReporteMedico.Click += new System.EventHandler(this.tsbReporteMedico_Click);
            // 
            // iconcerrar
            // 
            this.iconcerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconcerrar.BackColor = System.Drawing.Color.LightGray;
            this.iconcerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconcerrar.Image = ((System.Drawing.Image)(resources.GetObject("iconcerrar.Image")));
            this.iconcerrar.Location = new System.Drawing.Point(743, 7);
            this.iconcerrar.Name = "iconcerrar";
            this.iconcerrar.Size = new System.Drawing.Size(21, 21);
            this.iconcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconcerrar.TabIndex = 16;
            this.iconcerrar.TabStop = false;
            this.iconcerrar.Click += new System.EventHandler(this.iconcerrar_Click);
            // 
            // UI_HorariosPorMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 350);
            this.Controls.Add(this.iconcerrar);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvMedicos);
            this.Controls.Add(this.txtmedCol);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UI_HorariosPorMedicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda por Médico";
            this.Load += new System.EventHandler(this.UI_HorariosMedicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtmedCol;
		private System.Windows.Forms.DataGridView dgvMedicos;
		private System.Windows.Forms.DataGridViewTextBoxColumn paternoMed;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaternoMed;
		private System.Windows.Forms.DataGridViewTextBoxColumn nombresMed;
		private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicio;
		private System.Windows.Forms.DataGridViewTextBoxColumn fechaFin;
		private System.Windows.Forms.DataGridViewTextBoxColumn horaInicio;
		private System.Windows.Forms.DataGridViewTextBoxColumn horaFinal;
		private System.Windows.Forms.DataGridViewTextBoxColumn consultorio;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton tsbReporteMedico;
        private System.Windows.Forms.PictureBox iconcerrar;
    }
}