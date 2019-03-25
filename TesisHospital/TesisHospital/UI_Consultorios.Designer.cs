namespace TesisHospital
{
	partial class UI_Consultorios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI_Consultorios));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbGuardarConsultorio = new System.Windows.Forms.ToolStripButton();
            this.dgvConsultorios = new System.Windows.Forms.DataGridView();
            this.idEspecialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreEsp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombreConsultorio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxArea = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultorios)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightGray;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbGuardarConsultorio});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(410, 32);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "tspMenuEspecialidad";
            // 
            // tsbGuardarConsultorio
            // 
            this.tsbGuardarConsultorio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbGuardarConsultorio.Image = ((System.Drawing.Image)(resources.GetObject("tsbGuardarConsultorio.Image")));
            this.tsbGuardarConsultorio.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbGuardarConsultorio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGuardarConsultorio.Name = "tsbGuardarConsultorio";
            this.tsbGuardarConsultorio.Size = new System.Drawing.Size(29, 29);
            this.tsbGuardarConsultorio.Text = "tsbGuardarConsultorio";
            this.tsbGuardarConsultorio.Click += new System.EventHandler(this.tsbGuardarConsultorio_Click);
            // 
            // dgvConsultorios
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.dgvConsultorios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsultorios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvConsultorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultorios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEspecialidad,
            this.nombreEsp});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvConsultorios.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvConsultorios.Location = new System.Drawing.Point(23, 92);
            this.dgvConsultorios.Name = "dgvConsultorios";
            this.dgvConsultorios.RowHeadersVisible = false;
            this.dgvConsultorios.Size = new System.Drawing.Size(363, 212);
            this.dgvConsultorios.TabIndex = 11;
            // 
            // idEspecialidad
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idEspecialidad.DefaultCellStyle = dataGridViewCellStyle3;
            this.idEspecialidad.HeaderText = "Nombre Consultorio";
            this.idEspecialidad.Name = "idEspecialidad";
            this.idEspecialidad.Width = 90;
            // 
            // nombreEsp
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreEsp.DefaultCellStyle = dataGridViewCellStyle4;
            this.nombreEsp.HeaderText = "Area";
            this.nombreEsp.Name = "nombreEsp";
            this.nombreEsp.Width = 450;
            // 
            // txtNombreConsultorio
            // 
            this.txtNombreConsultorio.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.txtNombreConsultorio.Location = new System.Drawing.Point(87, 46);
            this.txtNombreConsultorio.Name = "txtNombreConsultorio";
            this.txtNombreConsultorio.Size = new System.Drawing.Size(109, 23);
            this.txtNombreConsultorio.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.label1.Location = new System.Drawing.Point(20, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.label2.Location = new System.Drawing.Point(231, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Area:";
            // 
            // cbxArea
            // 
            this.cbxArea.BackColor = System.Drawing.SystemColors.Window;
            this.cbxArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxArea.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.cbxArea.FormattingEnabled = true;
            this.cbxArea.Location = new System.Drawing.Point(277, 45);
            this.cbxArea.Name = "cbxArea";
            this.cbxArea.Size = new System.Drawing.Size(109, 24);
            this.cbxArea.TabIndex = 15;
            // 
            // UI_Consultorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 326);
            this.Controls.Add(this.cbxArea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvConsultorios);
            this.Controls.Add(this.txtNombreConsultorio);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UI_Consultorios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultorios";
            this.Load += new System.EventHandler(this.UI_Consultorios_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultorios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton tsbGuardarConsultorio;
		private System.Windows.Forms.DataGridView dgvConsultorios;
		private System.Windows.Forms.TextBox txtNombreConsultorio;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridViewTextBoxColumn idEspecialidad;
		private System.Windows.Forms.DataGridViewTextBoxColumn nombreEsp;
        private System.Windows.Forms.ComboBox cbxArea;
    }
}