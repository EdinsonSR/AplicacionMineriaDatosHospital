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
	public partial class UI_Consultorios : Form
	{
		public UI_Consultorios()
		{
			InitializeComponent();
		}

		public static UI_Consultorios frmHijo;
		public static UI_Consultorios CreateInstance(System.Windows.Forms.Form FormParent)
		{
			if (frmHijo == null || frmHijo.IsDisposed)
			{
				frmHijo = new UI_Consultorios();
			}
			frmHijo.BringToFront();
			frmHijo.Show();
			return frmHijo;
		}

		public void Limpiar()
		{
			this.txtNombreConsultorio.Clear();
			this.cbxArea.SelectedIndex = -1;
		}

		public void llenarDatos()
		{
			this.dgvConsultorios.DataSource = null;
			this.dgvConsultorios.Rows.Clear();
			List<Consultorio> lista = new List<Consultorio>();
			lista = ConsultorioBLL.Instancia.listadoConsultorio();
			for (int i = 0; i < lista.Count; i++)
			{
				Consultorio oConsultorio = lista[i];
				DataGridViewRow row = new DataGridViewRow();
				row.CreateCells(this.dgvConsultorios);
				row.Cells[0].Value = oConsultorio.NombreConsultorio;
				row.Cells[1].Value = oConsultorio.NombreAreasEspecialidades;
				this.dgvConsultorios.Rows.Add(row);
			}
		}

		public void LlenarAreas()
		{
			this.cbxArea.DataSource = null;
			this.cbxArea.Items.Clear();

			List<AreasEspecialidades> listaEspecialidad = AreasEspecialidadesBLL.Instancia.ListarNombreArea();
			if (listaEspecialidad != null)
			{
				this.cbxArea.DataSource = listaEspecialidad;
				this.cbxArea.DisplayMember = "nombreAreasEspecialidades";
			}
			cbxArea.SelectedIndex = -1;
		}
		private void UI_Consultorios_Load(object sender, EventArgs e)
		{
			LlenarAreas();
			llenarDatos();
		}

		private void tsbGuardarConsultorio_Click(object sender, EventArgs e)
		{
			Consultorio oConsultorio = new Consultorio();

			oConsultorio.IdConsultorio = oConsultorio.IdConsultorio;
			oConsultorio.NombreConsultorio = this.txtNombreConsultorio.Text.Trim();
			oConsultorio.NombreAreasEspecialidades = this.cbxArea.Text.Trim();

			Boolean InsertarConsultorio = ConsultorioBLL.Instancia.InsertarConsultorio(oConsultorio);

			Limpiar();
			llenarDatos();
		}
	}
}
