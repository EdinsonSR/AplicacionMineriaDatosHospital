namespace TesisHospital.Reportes
{
	partial class FrmReportes
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportes));
			this.CrReportes = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
			this.SuspendLayout();
			// 
			// CrReportes
			// 
			this.CrReportes.ActiveViewIndex = -1;
			this.CrReportes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.CrReportes.Cursor = System.Windows.Forms.Cursors.Default;
			this.CrReportes.Dock = System.Windows.Forms.DockStyle.Fill;
			this.CrReportes.Location = new System.Drawing.Point(0, 0);
			this.CrReportes.Name = "CrReportes";
			this.CrReportes.ShowCloseButton = false;
			this.CrReportes.ShowGroupTreeButton = false;
			this.CrReportes.Size = new System.Drawing.Size(634, 410);
			this.CrReportes.TabIndex = 3;
			this.CrReportes.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
			// 
			// FrmReportes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(634, 410);
			this.Controls.Add(this.CrReportes);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmReportes";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmReportes";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.FrmReportes_Load);
			this.ResumeLayout(false);

		}

		#endregion

		public CrystalDecisions.Windows.Forms.CrystalReportViewer CrReportes;
	}
}