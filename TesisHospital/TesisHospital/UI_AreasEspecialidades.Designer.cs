namespace TesisHospital
{
	partial class UI_AreasEspecialidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI_AreasEspecialidades));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbGuardarEspecialidad = new System.Windows.Forms.ToolStripButton();
            this.dgvAreas = new System.Windows.Forms.DataGridView();
            this.txtAreas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.idEspecialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreEsp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAreas)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightGray;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbGuardarEspecialidad});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(559, 32);
            this.toolStrip1.TabIndex = 3;
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
            // dgvAreas
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.dgvAreas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAreas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAreas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAreas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEspecialidad,
            this.nombreEsp});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAreas.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAreas.Location = new System.Drawing.Point(9, 71);
            this.dgvAreas.Name = "dgvAreas";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAreas.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAreas.RowHeadersVisible = false;
            this.dgvAreas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAreas.Size = new System.Drawing.Size(541, 543);
            this.dgvAreas.TabIndex = 8;
            // 
            // txtAreas
            // 
            this.txtAreas.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.txtAreas.Location = new System.Drawing.Point(145, 39);
            this.txtAreas.Name = "txtAreas";
            this.txtAreas.Size = new System.Drawing.Size(336, 23);
            this.txtAreas.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.label1.Location = new System.Drawing.Point(101, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Area:";
            // 
            // idEspecialidad
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.idEspecialidad.DefaultCellStyle = dataGridViewCellStyle3;
            this.idEspecialidad.HeaderText = "Nro. Especialidad";
            this.idEspecialidad.Name = "idEspecialidad";
            this.idEspecialidad.Width = 90;
            // 
            // nombreEsp
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.nombreEsp.DefaultCellStyle = dataGridViewCellStyle4;
            this.nombreEsp.HeaderText = "Nombre Area";
            this.nombreEsp.Name = "nombreEsp";
            this.nombreEsp.Width = 450;
            // 
            // UI_AreasEspecialidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 626);
            this.Controls.Add(this.dgvAreas);
            this.Controls.Add(this.txtAreas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UI_AreasEspecialidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Areas - Especialidades";
            this.Load += new System.EventHandler(this.UI_AreasEspecialidades_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAreas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton tsbGuardarEspecialidad;
		private System.Windows.Forms.DataGridView dgvAreas;
		private System.Windows.Forms.TextBox txtAreas;
		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEspecialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEsp;
    }
}