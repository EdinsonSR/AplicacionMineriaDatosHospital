namespace TesisHospital
{
    partial class UI_AlmacenMedicamentos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI_AlmacenMedicamentos));
            this.dgvStockMedicamentos = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNombreArticulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStockTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConcentMedicamento = new System.Windows.Forms.TextBox();
            this.MedicamentoAlmacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.concentAlmacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockMedicamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStockMedicamentos
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStockMedicamentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStockMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockMedicamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MedicamentoAlmacen,
            this.concentAlmacen,
            this.stockMedicamento});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStockMedicamentos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStockMedicamentos.Location = new System.Drawing.Point(17, 55);
            this.dgvStockMedicamentos.Name = "dgvStockMedicamentos";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStockMedicamentos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStockMedicamentos.RowHeadersVisible = false;
            this.dgvStockMedicamentos.Size = new System.Drawing.Size(503, 303);
            this.dgvStockMedicamentos.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.label11.Location = new System.Drawing.Point(22, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 16);
            this.label11.TabIndex = 12;
            this.label11.Text = "Medicamento:";
            // 
            // txtNombreArticulo
            // 
            this.txtNombreArticulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreArticulo.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.txtNombreArticulo.Location = new System.Drawing.Point(120, 22);
            this.txtNombreArticulo.Name = "txtNombreArticulo";
            this.txtNombreArticulo.Size = new System.Drawing.Size(204, 23);
            this.txtNombreArticulo.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.label1.Location = new System.Drawing.Point(337, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Stock Total:";
            // 
            // txtStockTotal
            // 
            this.txtStockTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtStockTotal.Enabled = false;
            this.txtStockTotal.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.txtStockTotal.Location = new System.Drawing.Point(432, 366);
            this.txtStockTotal.Name = "txtStockTotal";
            this.txtStockTotal.Size = new System.Drawing.Size(88, 23);
            this.txtStockTotal.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.label2.Location = new System.Drawing.Point(365, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Concent: ";
            // 
            // txtConcentMedicamento
            // 
            this.txtConcentMedicamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtConcentMedicamento.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.txtConcentMedicamento.Location = new System.Drawing.Point(428, 22);
            this.txtConcentMedicamento.Name = "txtConcentMedicamento";
            this.txtConcentMedicamento.Size = new System.Drawing.Size(92, 23);
            this.txtConcentMedicamento.TabIndex = 18;
            this.txtConcentMedicamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConcentMedicamento_KeyPress);
            // 
            // MedicamentoAlmacen
            // 
            this.MedicamentoAlmacen.HeaderText = "Medicamento";
            this.MedicamentoAlmacen.Name = "MedicamentoAlmacen";
            this.MedicamentoAlmacen.Width = 250;
            // 
            // concentAlmacen
            // 
            this.concentAlmacen.HeaderText = "Concent";
            this.concentAlmacen.Name = "concentAlmacen";
            // 
            // stockMedicamento
            // 
            this.stockMedicamento.HeaderText = "Stock Total";
            this.stockMedicamento.Name = "stockMedicamento";
            this.stockMedicamento.Width = 150;
            // 
            // UI_AlmacenMedicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 398);
            this.Controls.Add(this.txtConcentMedicamento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStockTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvStockMedicamentos);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtNombreArticulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UI_AlmacenMedicamentos";
            this.Text = "Almacen de Medicamentos";
            this.Load += new System.EventHandler(this.UI_AlmacenMedicamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockMedicamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStockMedicamentos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNombreArticulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStockTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConcentMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicamentoAlmacen;
        private System.Windows.Forms.DataGridViewTextBoxColumn concentAlmacen;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockMedicamento;
    }
}