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
	public partial class UI_RegistroEspecialidad : Form
	{
		public UI_RegistroEspecialidad()
		{
			InitializeComponent();
		}
		public static UI_RegistroEspecialidad frmHijo;
		public static UI_RegistroEspecialidad CreateInstance(System.Windows.Forms.Form FormParent)
		{
			if (frmHijo == null || frmHijo.IsDisposed)
			{
				frmHijo = new UI_RegistroEspecialidad();
			}
			frmHijo.BringToFront();
			frmHijo.Show();
			return frmHijo;
		}

		private void Limpiar()
		{
			this.txtCodEspecialidad.Clear();
			this.txtNombreEspecialidad.Clear();
		}

		private void llenarDatos()
		{
			this.dgvEspecialidades.DataSource = null;
			this.dgvEspecialidades.Rows.Clear();
			List<Especialidad> lista = new List<Especialidad>();
			lista = EspecialidadBLL.Instancia.listadoEspecialidad();
			for (int i = 0; i < lista.Count; i++)
			{
				Especialidad oEspecialidad = lista[i];
				DataGridViewRow row = new DataGridViewRow();
				row.CreateCells(this.dgvEspecialidades);
				row.Cells[0].Value = oEspecialidad.IdEspecialidad;
				row.Cells[1].Value = oEspecialidad.NombreEsp;
				row.Cells[2].Value = oEspecialidad.CodEspecialidad;
				this.dgvEspecialidades.Rows.Add(row);
			}
		}
		private void tsbGuardarEspecialidad_Click(object sender, EventArgs e)
		{
			Especialidad oEspecialidad = new Especialidad();

			oEspecialidad.IdEspecialidad = oEspecialidad.IdEspecialidad;
			oEspecialidad.CodEspecialidad = this.txtCodEspecialidad.Text.Trim();
			oEspecialidad.NombreEsp = this.txtNombreEspecialidad.Text.Trim();

			Boolean InsertarEspecialidad = EspecialidadBLL.Instancia.InsertarEspecialidad(oEspecialidad);

			Limpiar();
			llenarDatos();
		}

		private void UI_RegistroEspecialidad_Load(object sender, EventArgs e)
		{
			llenarDatos();
			Limpiar();
		}
	}
}
