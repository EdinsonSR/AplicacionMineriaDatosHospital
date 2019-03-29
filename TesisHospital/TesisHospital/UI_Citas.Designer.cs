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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tspGuardarCitas = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxMedico = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxEspecialidadMedico = new System.Windows.Forms.ComboBox();
            this.dtpFechaCita = new System.Windows.Forms.DateTimePicker();
            this.dgvCitas = new System.Windows.Forms.DataGridView();
            this.horaCita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacienteCita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoCita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eliminarCita = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnAbrirFormRegistrarCita = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHoraInicial = new System.Windows.Forms.TextBox();
            this.txtHoraFinal = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.tspGuardarCitas.Click += new System.EventHandler(this.tspGuardarCitas_Click);
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
            this.panel1.Controls.Add(this.cbxMedico);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbxEspecialidadMedico);
            this.panel1.Controls.Add(this.dtpFechaCita);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 515);
            this.panel1.TabIndex = 12;
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
            this.cbxMedico.SelectedIndexChanged += new System.EventHandler(this.cbxMedico_SelectedIndexChanged);
            this.cbxMedico.ValueMemberChanged += new System.EventHandler(this.cbxMedico_ValueMemberChanged);
            this.cbxMedico.SelectedValueChanged += new System.EventHandler(this.cbxMedico_SelectedValueChanged);
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
            // dtpFechaCita
            // 
            this.dtpFechaCita.CalendarFont = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.dtpFechaCita.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.dtpFechaCita.Location = new System.Drawing.Point(6, 95);
            this.dtpFechaCita.Name = "dtpFechaCita";
            this.dtpFechaCita.Size = new System.Drawing.Size(237, 23);
            this.dtpFechaCita.TabIndex = 12;
            this.dtpFechaCita.Value = new System.DateTime(2019, 3, 21, 20, 56, 0, 0);
            this.dtpFechaCita.ValueChanged += new System.EventHandler(this.dtpFechaCita_ValueChanged);
            // 
            // dgvCitas
            // 
            this.dgvCitas.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.dgvCitas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCitas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.horaCita,
            this.pacienteCita,
            this.estadoCita,
            this.eliminarCita});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Bahnschrift Light", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCitas.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCitas.Location = new System.Drawing.Point(270, 85);
            this.dgvCitas.Name = "dgvCitas";
            this.dgvCitas.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCitas.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCitas.RowHeadersVisible = false;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.dgvCitas.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCitas.Size = new System.Drawing.Size(676, 481);
            this.dgvCitas.TabIndex = 13;
            this.dgvCitas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCitas_CellClick);
            this.dgvCitas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCitas_CellFormatting);
            // 
            // horaCita
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.horaCita.DefaultCellStyle = dataGridViewCellStyle3;
            this.horaCita.Frozen = true;
            this.horaCita.HeaderText = "Hora";
            this.horaCita.Name = "horaCita";
            this.horaCita.ReadOnly = true;
            // 
            // pacienteCita
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.pacienteCita.DefaultCellStyle = dataGridViewCellStyle4;
            this.pacienteCita.Frozen = true;
            this.pacienteCita.HeaderText = "Paciente";
            this.pacienteCita.Name = "pacienteCita";
            this.pacienteCita.ReadOnly = true;
            this.pacienteCita.Width = 300;
            // 
            // estadoCita
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.estadoCita.DefaultCellStyle = dataGridViewCellStyle5;
            this.estadoCita.Frozen = true;
            this.estadoCita.HeaderText = "Estado";
            this.estadoCita.Name = "estadoCita";
            this.estadoCita.ReadOnly = true;
            this.estadoCita.Width = 150;
            // 
            // eliminarCita
            // 
            this.eliminarCita.Frozen = true;
            this.eliminarCita.HeaderText = "Eliminar";
            this.eliminarCita.Image = ((System.Drawing.Image)(resources.GetObject("eliminarCita.Image")));
            this.eliminarCita.Name = "eliminarCita";
            this.eliminarCita.ReadOnly = true;
            this.eliminarCita.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.eliminarCita.Width = 60;
            // 
            // btnAbrirFormRegistrarCita
            // 
            this.btnAbrirFormRegistrarCita.BackColor = System.Drawing.Color.Teal;
            this.btnAbrirFormRegistrarCita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbrirFormRegistrarCita.FlatAppearance.BorderSize = 0;
            this.btnAbrirFormRegistrarCita.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btnAbrirFormRegistrarCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirFormRegistrarCita.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirFormRegistrarCita.ForeColor = System.Drawing.Color.White;
            this.btnAbrirFormRegistrarCita.Image = ((System.Drawing.Image)(resources.GetObject("btnAbrirFormRegistrarCita.Image")));
            this.btnAbrirFormRegistrarCita.Location = new System.Drawing.Point(865, 52);
            this.btnAbrirFormRegistrarCita.Name = "btnAbrirFormRegistrarCita";
            this.btnAbrirFormRegistrarCita.Size = new System.Drawing.Size(81, 29);
            this.btnAbrirFormRegistrarCita.TabIndex = 14;
            this.btnAbrirFormRegistrarCita.Text = " Agregar";
            this.btnAbrirFormRegistrarCita.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbrirFormRegistrarCita.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAbrirFormRegistrarCita.UseVisualStyleBackColor = false;
            this.btnAbrirFormRegistrarCita.Click += new System.EventHandler(this.btnAbrirFormRegistrarCita_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.label4.Location = new System.Drawing.Point(258, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Hora Inicial:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.label5.Location = new System.Drawing.Point(428, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Hora Final:";
            // 
            // txtHoraInicial
            // 
            this.txtHoraInicial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtHoraInicial.Enabled = false;
            this.txtHoraInicial.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.txtHoraInicial.Location = new System.Drawing.Point(340, 3);
            this.txtHoraInicial.Name = "txtHoraInicial";
            this.txtHoraInicial.Size = new System.Drawing.Size(64, 23);
            this.txtHoraInicial.TabIndex = 17;
            // 
            // txtHoraFinal
            // 
            this.txtHoraFinal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtHoraFinal.Enabled = false;
            this.txtHoraFinal.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.txtHoraFinal.Location = new System.Drawing.Point(504, 3);
            this.txtHoraFinal.Name = "txtHoraFinal";
            this.txtHoraFinal.Size = new System.Drawing.Size(64, 23);
            this.txtHoraFinal.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtHoraInicial);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtHoraFinal);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(270, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(580, 30);
            this.panel2.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.label6.Location = new System.Drawing.Point(3, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(234, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "HORARIO DEL MEDICO SELECCIONADO:";
            // 
            // UI_Citas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 573);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnAbrirFormRegistrarCita);
            this.Controls.Add(this.dgvCitas);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.DataGridView dgvCitas;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaCita;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacienteCita;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoCita;
        private System.Windows.Forms.DataGridViewImageColumn eliminarCita;
        private System.Windows.Forms.Button btnAbrirFormRegistrarCita;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHoraInicial;
        private System.Windows.Forms.TextBox txtHoraFinal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
    }
}