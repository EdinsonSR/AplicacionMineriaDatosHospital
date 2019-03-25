namespace TesisHospital
{
	partial class UI_HorariosMedicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI_HorariosMedicos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNuevoMedico = new System.Windows.Forms.ToolStripButton();
            this.tspGuardarMedico = new System.Windows.Forms.ToolStripButton();
            this.tsbBuscarMedico = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombresMed = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPaternoMed = new System.Windows.Forms.TextBox();
            this.txtMaternoMed = new System.Windows.Forms.TextBox();
            this.txtNroColegiaturaMed = new System.Windows.Forms.TextBox();
            this.dgvMedicos = new System.Windows.Forms.DataGridView();
            this.MedCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paternoMed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaternoMed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresMed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consultorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxEspecialidadMedico = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpHoraFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.cbxConsultorio = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dtFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.dtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iconcerrar = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.LightGray;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevoMedico,
            this.tspGuardarMedico,
            this.tsbBuscarMedico});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(902, 44);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbNuevoMedico
            // 
            this.tsbNuevoMedico.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNuevoMedico.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevoMedico.Image")));
            this.tsbNuevoMedico.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbNuevoMedico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevoMedico.Margin = new System.Windows.Forms.Padding(4);
            this.tsbNuevoMedico.Name = "tsbNuevoMedico";
            this.tsbNuevoMedico.Size = new System.Drawing.Size(29, 36);
            this.tsbNuevoMedico.Text = "Nuevo Médico";
            this.tsbNuevoMedico.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tspGuardarMedico
            // 
            this.tspGuardarMedico.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tspGuardarMedico.Image = ((System.Drawing.Image)(resources.GetObject("tspGuardarMedico.Image")));
            this.tspGuardarMedico.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tspGuardarMedico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspGuardarMedico.Margin = new System.Windows.Forms.Padding(4);
            this.tspGuardarMedico.Name = "tspGuardarMedico";
            this.tspGuardarMedico.Size = new System.Drawing.Size(29, 36);
            this.tspGuardarMedico.Text = "Guardar";
            this.tspGuardarMedico.Click += new System.EventHandler(this.tspGuardarMedico_Click);
            // 
            // tsbBuscarMedico
            // 
            this.tsbBuscarMedico.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBuscarMedico.Image = ((System.Drawing.Image)(resources.GetObject("tsbBuscarMedico.Image")));
            this.tsbBuscarMedico.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbBuscarMedico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBuscarMedico.Margin = new System.Windows.Forms.Padding(4);
            this.tsbBuscarMedico.Name = "tsbBuscarMedico";
            this.tsbBuscarMedico.Size = new System.Drawing.Size(29, 36);
            this.tsbBuscarMedico.Text = "Buscar ";
            this.tsbBuscarMedico.Click += new System.EventHandler(this.tsbBuscarMedico_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.label1.Location = new System.Drawing.Point(28, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombres:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.label3.Location = new System.Drawing.Point(243, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "N° de Colegiatura (*):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.label4.Location = new System.Drawing.Point(8, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Especialidad:";
            // 
            // txtNombresMed
            // 
            this.txtNombresMed.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombresMed.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.txtNombresMed.Location = new System.Drawing.Point(98, 45);
            this.txtNombresMed.Name = "txtNombresMed";
            this.txtNombresMed.Size = new System.Drawing.Size(131, 23);
            this.txtNombresMed.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.label5.Location = new System.Drawing.Point(217, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Materno:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.label6.Location = new System.Drawing.Point(37, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Paterno:";
            // 
            // txtPaternoMed
            // 
            this.txtPaternoMed.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPaternoMed.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.txtPaternoMed.Location = new System.Drawing.Point(98, 10);
            this.txtPaternoMed.Name = "txtPaternoMed";
            this.txtPaternoMed.Size = new System.Drawing.Size(100, 23);
            this.txtPaternoMed.TabIndex = 0;
            // 
            // txtMaternoMed
            // 
            this.txtMaternoMed.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMaternoMed.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.txtMaternoMed.Location = new System.Drawing.Point(283, 10);
            this.txtMaternoMed.Name = "txtMaternoMed";
            this.txtMaternoMed.Size = new System.Drawing.Size(159, 23);
            this.txtMaternoMed.TabIndex = 1;
            this.txtMaternoMed.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtNroColegiaturaMed
            // 
            this.txtNroColegiaturaMed.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNroColegiaturaMed.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.txtNroColegiaturaMed.Location = new System.Drawing.Point(378, 45);
            this.txtNroColegiaturaMed.Name = "txtNroColegiaturaMed";
            this.txtNroColegiaturaMed.Size = new System.Drawing.Size(64, 23);
            this.txtNroColegiaturaMed.TabIndex = 3;
            this.txtNroColegiaturaMed.TextChanged += new System.EventHandler(this.txtNroColegiaturaMed_TextChanged);
            this.txtNroColegiaturaMed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroColegiaturaMed_KeyPress);
            // 
            // dgvMedicos
            // 
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.dgvMedicos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMedicos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MedCol,
            this.paternoMed,
            this.MaternoMed,
            this.nombresMed,
            this.fechaInicio,
            this.fechaFin,
            this.horaInicio,
            this.horaFinal,
            this.consultorio});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMedicos.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvMedicos.Location = new System.Drawing.Point(12, 170);
            this.dgvMedicos.Name = "dgvMedicos";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMedicos.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvMedicos.RowHeadersVisible = false;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.dgvMedicos.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvMedicos.Size = new System.Drawing.Size(878, 343);
            this.dgvMedicos.TabIndex = 3;
            // 
            // MedCol
            // 
            this.MedCol.HeaderText = "Colegiatura";
            this.MedCol.Name = "MedCol";
            this.MedCol.Width = 80;
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
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbxEspecialidadMedico);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtNroColegiaturaMed);
            this.panel1.Controls.Add(this.txtNombresMed);
            this.panel1.Controls.Add(this.txtMaternoMed);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtPaternoMed);
            this.panel1.Location = new System.Drawing.Point(12, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 111);
            this.panel1.TabIndex = 0;
            // 
            // cbxEspecialidadMedico
            // 
            this.cbxEspecialidadMedico.BackColor = System.Drawing.SystemColors.Window;
            this.cbxEspecialidadMedico.DropDownHeight = 87;
            this.cbxEspecialidadMedico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEspecialidadMedico.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.cbxEspecialidadMedico.FormattingEnabled = true;
            this.cbxEspecialidadMedico.IntegralHeight = false;
            this.cbxEspecialidadMedico.Location = new System.Drawing.Point(99, 78);
            this.cbxEspecialidadMedico.Name = "cbxEspecialidadMedico";
            this.cbxEspecialidadMedico.Size = new System.Drawing.Size(343, 24);
            this.cbxEspecialidadMedico.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.label9.Location = new System.Drawing.Point(155, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "Rango de Horas: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.label8.Location = new System.Drawing.Point(172, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Desde:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dtpHoraFinal);
            this.panel2.Controls.Add(this.dtpHoraInicio);
            this.panel2.Controls.Add(this.cbxConsultorio);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.dtFechaFinal);
            this.panel2.Controls.Add(this.dtFechaInicio);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(471, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(419, 111);
            this.panel2.TabIndex = 1;
            // 
            // dtpHoraFinal
            // 
            this.dtpHoraFinal.CalendarFont = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.dtpHoraFinal.CustomFormat = "HH:mm";
            this.dtpHoraFinal.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.dtpHoraFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraFinal.Location = new System.Drawing.Point(226, 71);
            this.dtpHoraFinal.Name = "dtpHoraFinal";
            this.dtpHoraFinal.ShowUpDown = true;
            this.dtpHoraFinal.Size = new System.Drawing.Size(83, 23);
            this.dtpHoraFinal.TabIndex = 3;
            // 
            // dtpHoraInicio
            // 
            this.dtpHoraInicio.CalendarFont = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.dtpHoraInicio.CustomFormat = "HH:mm";
            this.dtpHoraInicio.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraInicio.Location = new System.Drawing.Point(226, 38);
            this.dtpHoraInicio.Name = "dtpHoraInicio";
            this.dtpHoraInicio.ShowUpDown = true;
            this.dtpHoraInicio.Size = new System.Drawing.Size(83, 23);
            this.dtpHoraInicio.TabIndex = 2;
            // 
            // cbxConsultorio
            // 
            this.cbxConsultorio.BackColor = System.Drawing.SystemColors.Window;
            this.cbxConsultorio.DropDownHeight = 87;
            this.cbxConsultorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxConsultorio.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.cbxConsultorio.FormattingEnabled = true;
            this.cbxConsultorio.IntegralHeight = false;
            this.cbxConsultorio.Location = new System.Drawing.Point(325, 37);
            this.cbxConsultorio.Name = "cbxConsultorio";
            this.cbxConsultorio.Size = new System.Drawing.Size(87, 24);
            this.cbxConsultorio.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.label12.Location = new System.Drawing.Point(321, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 16);
            this.label12.TabIndex = 24;
            this.label12.Text = "Consultorio: ";
            // 
            // dtFechaFinal
            // 
            this.dtFechaFinal.CalendarFont = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.dtFechaFinal.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.dtFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaFinal.Location = new System.Drawing.Point(69, 71);
            this.dtFechaFinal.Name = "dtFechaFinal";
            this.dtFechaFinal.Size = new System.Drawing.Size(86, 23);
            this.dtFechaFinal.TabIndex = 1;
            // 
            // dtFechaInicio
            // 
            this.dtFechaInicio.CalendarFont = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.dtFechaInicio.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.dtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaInicio.Location = new System.Drawing.Point(69, 38);
            this.dtFechaInicio.Name = "dtFechaInicio";
            this.dtFechaInicio.Size = new System.Drawing.Size(86, 23);
            this.dtFechaInicio.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.label10.Location = new System.Drawing.Point(18, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "Hasta:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.label11.Location = new System.Drawing.Point(15, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "Desde:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.label7.Location = new System.Drawing.Point(0, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Rango de Fechas: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.label2.Location = new System.Drawing.Point(172, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Hasta:";
            // 
            // iconcerrar
            // 
            this.iconcerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconcerrar.BackColor = System.Drawing.Color.LightGray;
            this.iconcerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconcerrar.Image = ((System.Drawing.Image)(resources.GetObject("iconcerrar.Image")));
            this.iconcerrar.Location = new System.Drawing.Point(869, 12);
            this.iconcerrar.Name = "iconcerrar";
            this.iconcerrar.Size = new System.Drawing.Size(21, 21);
            this.iconcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconcerrar.TabIndex = 16;
            this.iconcerrar.TabStop = false;
            // 
            // UI_HorariosMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 525);
            this.Controls.Add(this.iconcerrar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvMedicos);
            this.Controls.Add(this.toolStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UI_HorariosMedicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Médicos";
            this.Load += new System.EventHandler(this.UI_MedicosActivos_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton tspGuardarMedico;
		private System.Windows.Forms.ToolStripButton tsbBuscarMedico;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtNombresMed;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtPaternoMed;
		private System.Windows.Forms.TextBox txtMaternoMed;
		private System.Windows.Forms.TextBox txtNroColegiaturaMed;
		private System.Windows.Forms.DataGridView dgvMedicos;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ComboBox cbxEspecialidadMedico;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DateTimePicker dtFechaFinal;
		private System.Windows.Forms.DateTimePicker dtFechaInicio;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbxConsultorio;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.DateTimePicker dtpHoraInicio;
		private System.Windows.Forms.DateTimePicker dtpHoraFinal;
		private System.Windows.Forms.DataGridViewTextBoxColumn MedCol;
		private System.Windows.Forms.DataGridViewTextBoxColumn paternoMed;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaternoMed;
		private System.Windows.Forms.DataGridViewTextBoxColumn nombresMed;
		private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicio;
		private System.Windows.Forms.DataGridViewTextBoxColumn fechaFin;
		private System.Windows.Forms.DataGridViewTextBoxColumn horaInicio;
		private System.Windows.Forms.DataGridViewTextBoxColumn horaFinal;
		private System.Windows.Forms.DataGridViewTextBoxColumn consultorio;
		private System.Windows.Forms.ToolStripButton tsbNuevoMedico;
        private System.Windows.Forms.PictureBox iconcerrar;
    }
}