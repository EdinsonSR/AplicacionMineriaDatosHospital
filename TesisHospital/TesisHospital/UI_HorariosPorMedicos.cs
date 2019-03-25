using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EL;
using BLL;
using CrystalDecisions.CrystalReports.Engine;
using TesisHospital.Reportes;

namespace TesisHospital
{
	public partial class UI_HorariosPorMedicos : Form
	{
		public UI_HorariosPorMedicos()
		{
			InitializeComponent();
		}
		public static UI_HorariosPorMedicos frmHijo;
		public static UI_HorariosPorMedicos CreateInstance(System.Windows.Forms.Form FormParent)
		{
			if (frmHijo == null || frmHijo.IsDisposed)
			{
				frmHijo = new UI_HorariosPorMedicos();
			}
			frmHijo.BringToFront();
			frmHijo.Show();
			return frmHijo;
		}
		private void UI_HorariosMedicos_Load(object sender, EventArgs e)
		{

		}

		private void txtmedCol_KeyUp(object sender, KeyEventArgs e)
		{
			string medcol = this.txtmedCol.Text.Trim();
			this.dgvMedicos.DataSource = null;
			this.dgvMedicos.Rows.Clear();
			List<HorariosMedicos> lista = new List<HorariosMedicos>();
			lista = MedicoBLL.Instancia.listaMedicosPorCMP(medcol);
			for (int i = 0; i < lista.Count; i++)
			{
				HorariosMedicos oConsultorio = lista[i];
				DataGridViewRow row = new DataGridViewRow();
				row.CreateCells(this.dgvMedicos);
				row.Cells[0].Value = oConsultorio.PaternoMed;
				row.Cells[1].Value = oConsultorio.MaternoMed;
				row.Cells[2].Value = oConsultorio.NombreMedico;
				row.Cells[3].Value = oConsultorio.FechaInicio;
				row.Cells[4].Value = oConsultorio.FechaFin;
				row.Cells[5].Value = oConsultorio.HoraInicio;
				row.Cells[6].Value = oConsultorio.HoraFin;
				row.Cells[7].Value = oConsultorio.Consultorio;
				this.dgvMedicos.Rows.Add(row);
			}
		}

		private void tsbReporteMedico_Click(object sender, EventArgs e)
		{
			string medcol = this.txtmedCol.Text.Trim();
			ReportDocument objReporte = new ReportDocument();
			objReporte.Load(Application.StartupPath + "\\Reportes\\ReportePorMedico.rpt");
			objReporte.SetDataSource(MedicoBLL.Instancia.ReportePorCMP(medcol));
			FrmReportes Reporte = new FrmReportes();
			Reporte.CrReportes.ReportSource = objReporte;
			Reporte.Show();
		}

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
