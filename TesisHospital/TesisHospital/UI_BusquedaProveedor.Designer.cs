namespace TesisHospital
{
    partial class UI_BusquedaProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI_BusquedaProveedor));
            this.rdbRazonSocial = new System.Windows.Forms.RadioButton();
            this.rdbRUC = new System.Windows.Forms.RadioButton();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.txtRUC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvProveedor = new System.Windows.Forms.DataGridView();
            this.rucEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonSocialEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoProovedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionProv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.iconcerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbRazonSocial
            // 
            this.rdbRazonSocial.AutoSize = true;
            this.rdbRazonSocial.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.rdbRazonSocial.Location = new System.Drawing.Point(18, 65);
            this.rdbRazonSocial.Name = "rdbRazonSocial";
            this.rdbRazonSocial.Size = new System.Drawing.Size(74, 20);
            this.rdbRazonSocial.TabIndex = 14;
            this.rdbRazonSocial.TabStop = true;
            this.rdbRazonSocial.Text = "R. Social";
            this.rdbRazonSocial.UseVisualStyleBackColor = true;
            this.rdbRazonSocial.CheckedChanged += new System.EventHandler(this.rdbRazonSocial_CheckedChanged);
            // 
            // rdbRUC
            // 
            this.rdbRUC.AutoSize = true;
            this.rdbRUC.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.rdbRUC.Location = new System.Drawing.Point(18, 39);
            this.rdbRUC.Name = "rdbRUC";
            this.rdbRUC.Size = new System.Drawing.Size(51, 20);
            this.rdbRUC.TabIndex = 13;
            this.rdbRUC.TabStop = true;
            this.rdbRUC.Text = "RUC";
            this.rdbRUC.UseVisualStyleBackColor = true;
            this.rdbRUC.CheckedChanged += new System.EventHandler(this.rdbRUC_CheckedChanged);
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtRazonSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRazonSocial.Enabled = false;
            this.txtRazonSocial.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazonSocial.Location = new System.Drawing.Point(96, 66);
            this.txtRazonSocial.MaxLength = 100;
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(393, 22);
            this.txtRazonSocial.TabIndex = 12;
            this.txtRazonSocial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRazonSocial_KeyPress);
            // 
            // txtRUC
            // 
            this.txtRUC.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtRUC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRUC.Enabled = false;
            this.txtRUC.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRUC.Location = new System.Drawing.Point(96, 38);
            this.txtRUC.Name = "txtRUC";
            this.txtRUC.Size = new System.Drawing.Size(164, 22);
            this.txtRUC.TabIndex = 11;
            this.txtRUC.TextChanged += new System.EventHandler(this.txtRUC_TextChanged);
            this.txtRUC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRUC_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(266, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "DE PREFERENCIA BUSCAR POR RUC";
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
            this.rucEmpresa,
            this.razonSocialEmpresa,
            this.telefonoProovedor,
            this.direccionProv});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift Light", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProveedor.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProveedor.Location = new System.Drawing.Point(18, 95);
            this.dgvProveedor.MultiSelect = false;
            this.dgvProveedor.Name = "dgvProveedor";
            this.dgvProveedor.RowHeadersVisible = false;
            this.dgvProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProveedor.Size = new System.Drawing.Size(471, 153);
            this.dgvProveedor.TabIndex = 16;
            this.dgvProveedor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedor_CellDoubleClick);
            // 
            // rucEmpresa
            // 
            this.rucEmpresa.HeaderText = "RUC";
            this.rucEmpresa.Name = "rucEmpresa";
            this.rucEmpresa.Width = 80;
            // 
            // razonSocialEmpresa
            // 
            this.razonSocialEmpresa.HeaderText = "Razón Social";
            this.razonSocialEmpresa.Name = "razonSocialEmpresa";
            this.razonSocialEmpresa.Width = 200;
            // 
            // telefonoProovedor
            // 
            this.telefonoProovedor.HeaderText = "Telefono";
            this.telefonoProovedor.Name = "telefonoProovedor";
            this.telefonoProovedor.Width = 80;
            // 
            // direccionProv
            // 
            this.direccionProv.HeaderText = "Dirección";
            this.direccionProv.Name = "direccionProv";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.LightGray;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(501, 30);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // iconcerrar
            // 
            this.iconcerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconcerrar.BackColor = System.Drawing.Color.LightGray;
            this.iconcerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconcerrar.Image = ((System.Drawing.Image)(resources.GetObject("iconcerrar.Image")));
            this.iconcerrar.Location = new System.Drawing.Point(461, 3);
            this.iconcerrar.Name = "iconcerrar";
            this.iconcerrar.Size = new System.Drawing.Size(28, 23);
            this.iconcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconcerrar.TabIndex = 18;
            this.iconcerrar.TabStop = false;
            this.iconcerrar.Click += new System.EventHandler(this.iconcerrar_Click);
            // 
            // UI_BusquedaProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 261);
            this.Controls.Add(this.iconcerrar);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvProveedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rdbRazonSocial);
            this.Controls.Add(this.rdbRUC);
            this.Controls.Add(this.txtRazonSocial);
            this.Controls.Add(this.txtRUC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UI_BusquedaProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Búsqueda Proveedor";
            this.Load += new System.EventHandler(this.UI_BusquedaProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbRazonSocial;
        private System.Windows.Forms.RadioButton rdbRUC;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.TextBox txtRUC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn rucEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonSocialEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoProovedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionProv;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.PictureBox iconcerrar;
    }
}