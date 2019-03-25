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

namespace TesisHospital
{
	public partial class UI_AreasEspecialidades : Form
	{
		public UI_AreasEspecialidades()
		{
			InitializeComponent();
		}
		public static UI_AreasEspecialidades frmHijo;
		public static UI_AreasEspecialidades CreateInstance(System.Windows.Forms.Form FormParent)
		{
			if (frmHijo == null || frmHijo.IsDisposed)
			{
				frmHijo = new UI_AreasEspecialidades();
			}
			frmHijo.BringToFront();
			frmHijo.Show();
			return frmHijo;
		}

		private void llenarDatos()
		{
			this.dgvAreas.DataSource = null;
			this.dgvAreas.Rows.Clear();
			List<AreasEspecialidades> lista = new List<AreasEspecialidades>();
			lista = AreasEspecialidadesBLL.Instancia.ListarNombreArea();
			for (int i = 0; i < lista.Count; i++)
			{
				AreasEspecialidades oAreasEspecialidad = lista[i];
				DataGridViewRow row = new DataGridViewRow();
				row.CreateCells(this.dgvAreas);
				row.Cells[0].Value = oAreasEspecialidad.IdAreaEspecialidades;
				row.Cells[1].Value = oAreasEspecialidad.NombreAreasEspecialidades;
				this.dgvAreas.Rows.Add(row);
			}
		}

		private void Limpiar()
		{
			this.txtAreas.Clear();
		}

		private void UI_AreasEspecialidades_Load(object sender, EventArgs e)
		{
			llenarDatos();
		}

		private void tsbGuardarEspecialidad_Click(object sender, EventArgs e)
		{
			AreasEspecialidades oAreaEspecialidad = new AreasEspecialidades();

			oAreaEspecialidad.IdAreaEspecialidades = oAreaEspecialidad.IdAreaEspecialidades;
			oAreaEspecialidad.NombreAreasEspecialidades = this.txtAreas.Text.Trim();

			Boolean InsertarAreas = AreasEspecialidadesBLL.Instancia.InsertarAreas(oAreaEspecialidad);
			Limpiar();
			llenarDatos();
		}
	}
}
