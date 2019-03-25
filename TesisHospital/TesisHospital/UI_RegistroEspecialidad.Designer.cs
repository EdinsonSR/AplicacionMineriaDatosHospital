namespace TesisHospital
{
	partial class UI_RegistroEspecialidad
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI_RegistroEspecialidad));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreEspecialidad = new System.Windows.Forms.TextBox();
            this.dgvEspecialidades = new System.Windows.Forms.DataGridView();
            this.idEspecialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreEsp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codEspecialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbGuardarEspecialidad = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodEspecialidad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidades)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.label1.Location = new System.Drawing.Point(202, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Especialidad:";
            // 
            // txtNombreEspecialidad
            // 
            this.txtNombreEspecialidad.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.txtNombreEspecialidad.Location = new System.Drawing.Point(291, 40);
            this.txtNombreEspecialidad.Name = "txtNombreEspecialidad";
            this.txtNombreEspecialidad.Size = new System.Drawing.Size(336, 23);
            this.txtNombreEspecialidad.TabIndex = 1;
            // 
            // dgvEspecialidades
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEspecialidades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvEspecialidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEspecialidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEspecialidad,
            this.nombreEsp,
            this.codEspecialidad});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEspecialidades.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvEspecialidades.Location = new System.Drawing.Point(16, 76);
            this.dgvEspecialidades.Name = "dgvEspecialidades";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEspecialidades.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvEspecialidades.RowHeadersVisible = false;
            this.dgvEspecialidades.Size = new System.Drawing.Size(611, 212);
            this.dgvEspecialidades.TabIndex = 2;
            // 
            // idEspecialidad
            // 
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idEspecialidad.DefaultCellStyle = dataGridViewCellStyle8;
            this.idEspecialidad.HeaderText = "Nro. Especialidad";
            this.idEspecialidad.Name = "idEspecialidad";
            this.idEspecialidad.Width = 70;
            // 
            // nombreEsp
            // 
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreEsp.DefaultCellStyle = dataGridViewCellStyle9;
            this.nombreEsp.HeaderText = "Nombre Especialidad";
            this.nombreEsp.Name = "nombreEsp";
            this.nombreEsp.Width = 450;
            // 
            // codEspecialidad
            // 
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codEspecialidad.DefaultCellStyle = dataGridViewCellStyle10;
            this.codEspecialidad.HeaderText = "Código Especialidad";
            this.codEspecialidad.Name = "codEspecialidad";
            this.codEspecialidad.Width = 70;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightGray;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbGuardarEspecialidad});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(637, 32);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "tspMenuEspecialidad";
            // 
            // tsbGuardarEspecialidad
            // 
            this.tsbGuardarEspecialidad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbGuardarEspecialidad.Image = ((System.Drawing.Image)(resources.GetObject("tsbGuardarEspecialidad.Image")));
            this.tsbGuardarEspecialidad.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbGuardarEspecialidad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGuardarEspecialidad.Name = "tsbGuardarEspecialidad";
            this.tsbGuardarEspecialidad.Size = new System.Drawing.Size(29, 29);
            this.tsbGuardarEspecialidad.Text = "tsbGuardarEspecialidad";
            this.tsbGuardarEspecialidad.Click += new System.EventHandler(this.tsbGuardarEspecialidad_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.label2.Location = new System.Drawing.Point(19, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cod. Especialidad:";
            // 
            // txtCodEspecialidad
            // 
            this.txtCodEspecialidad.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.txtCodEspecialidad.Location = new System.Drawing.Point(142, 40);
            this.txtCodEspecialidad.Name = "txtCodEspecialidad";
            this.txtCodEspecialidad.Size = new System.Drawing.Size(43, 23);
            this.txtCodEspecialidad.TabIndex = 0;
            // 
            // UI_RegistroEspecialidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 301);
            this.Controls.Add(this.txtCodEspecialidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvEspecialidades);
            this.Controls.Add(this.txtNombreEspecialidad);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UI_RegistroEspecialidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Especialidades Medicas";
            this.Load += new System.EventHandler(this.UI_RegistroEspecialidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidades)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNombreEspecialidad;
		private System.Windows.Forms.DataGridView dgvEspecialidades;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton tsbGuardarEspecialidad;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtCodEspecialidad;
		private System.Windows.Forms.DataGridViewTextBoxColumn idEspecialidad;
		private System.Windows.Forms.DataGridViewTextBoxColumn nombreEsp;
		private System.Windows.Forms.DataGridViewTextBoxColumn codEspecialidad;
    }
}