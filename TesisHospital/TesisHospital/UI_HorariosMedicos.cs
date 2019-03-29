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
	public partial class UI_HorariosMedicos : Form
	{
		public UI_HorariosMedicos()
		{
			InitializeComponent();
		}
		


		private void limpiar()
		{
			this.txtPaternoMed.Clear();
			this.txtMaternoMed.Clear();
			this.txtNombresMed.Clear();
			this.txtNroColegiaturaMed.Clear();
			this.cbxEspecialidadMedico.SelectedIndex = -1;
			this.cbxConsultorio.SelectedIndex = -1;
		}

		public void LlenarEspecialidadMedico()
		{
			this.cbxEspecialidadMedico.DataSource = null;
			this.cbxEspecialidadMedico.Items.Clear();

			List<Especialidad> listaEspecialidad = EspecialidadBLL.Instancia.ListarNombreEspecialidad();
			if (listaEspecialidad!= null)
			{
				this.cbxEspecialidadMedico.DataSource = listaEspecialidad;
				this.cbxEspecialidadMedico.DisplayMember = "nombreEsp";
			}
			cbxEspecialidadMedico.SelectedIndex = -1;
		}

		public void llenarConsultorio()
		{
			this.cbxConsultorio.DataSource = null;
			this.cbxConsultorio.Items.Clear();

			List<Consultorio> listaConsultorio = ConsultorioBLL.Instancia.listadoConsultorio();
			if (listaConsultorio != null)
			{
				this.cbxConsultorio.DataSource = listaConsultorio;
				this.cbxConsultorio.DisplayMember = "nombreConsultorio";
			}
			cbxConsultorio.SelectedIndex = -1;
		}

		public void llenarTabla()
		{
			this.dgvMedicos.DataSource = null;
			this.dgvMedicos.Rows.Clear();
			List<HorariosMedicos> lista = new List<HorariosMedicos>();
			lista = MedicoBLL.Instancia.listaMedicos();
			for (int i = 0; i < lista.Count; i++)
			{
				HorariosMedicos oConsultorio = lista[i];
				DataGridViewRow row = new DataGridViewRow();
				row.CreateCells(this.dgvMedicos);
				row.Cells[0].Value = oConsultorio.MedCol;
				row.Cells[1].Value = oConsultorio.PaternoMed;
				row.Cells[2].Value = oConsultorio.MaternoMed;
				row.Cells[3].Value = oConsultorio.NombreMedico;
				row.Cells[4].Value = oConsultorio.FechaInicio;
				row.Cells[5].Value = oConsultorio.FechaFin;
				row.Cells[6].Value = oConsultorio.HoraInicio;
				row.Cells[7].Value = oConsultorio.HoraFin;
				row.Cells[8].Value = oConsultorio.Consultorio;
				this.dgvMedicos.Rows.Add(row);
			}
		}
		private void UI_MedicosActivos_Load(object sender, EventArgs e)
		{
			txtMaternoMed.Enabled = false;
			txtPaternoMed.Enabled = false;
			txtNombresMed.Enabled = false; 

			LlenarEspecialidadMedico();
			llenarConsultorio();
			llenarTabla();
			limpiar();
			
		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnHorariosMedicos_Click(object sender, EventArgs e)
		{
			UI_HorariosPorMedicos.CreateInstance(this);
		}
		

		private void tspGuardarMedico_Click(object sender, EventArgs e)
		{
			HorariosMedicos oMedico = new HorariosMedicos();

			oMedico.IdMedico = oMedico.IdMedico;
			oMedico.MedCol = this.txtNroColegiaturaMed.Text.Trim();
			oMedico.MedEspecialidad = this.cbxEspecialidadMedico.Text.Trim();
			oMedico.NombreMedico = this.txtNombresMed.Text.Trim();
			oMedico.PaternoMed = this.txtPaternoMed.Text.Trim();
			oMedico.MaternoMed = this.txtMaternoMed.Text.Trim();
			oMedico.Consultorio = this.cbxConsultorio.Text.Trim();
			oMedico.FechaInicio = Convert.ToDateTime(this.dtFechaInicio.Text.Trim());
			oMedico.FechaFin = Convert.ToDateTime(this.dtFechaFinal.Text.Trim());
			oMedico.HoraInicio = this.dtpHoraInicio.Text.Trim();
			oMedico.HoraFin = this.dtpHoraFinal.Text.Trim();
			oMedico.Fecharegistro = DateTime.Now;

			Boolean InsertarMedico = MedicoBLL.Instancia.InsertarMedico(oMedico);

			limpiar();
			llenarTabla();
		}

		private void tsbBuscarMedico_Click(object sender, EventArgs e)
		{
			 UI_HorariosPorMedicos.CreateInstance(this);
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
            UI_RegistroMedicos.CreateInstance(this);
		}

		private void txtNroColegiaturaMed_KeyPress(object sender, KeyPressEventArgs e)
		{
			string medCod = txtNroColegiaturaMed.Text.Trim(); 
			HorariosMedicos datosMedico = MedicoBLL.Instancia.busquedaMedico(medCod);
			if ((int)e.KeyChar == (int)Keys.Enter)
			{
				if (datosMedico != null)
				{
					this.txtPaternoMed.Text = datosMedico.PaternoMed;
					this.txtMaternoMed.Text = datosMedico.MaternoMed;
					this.txtNombresMed.Text = datosMedico.Nombre;
					this.cbxEspecialidadMedico.Text = datosMedico.MedEspecialidad;
				}
				else
				{
					MessageBox.Show("Médico no registrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}

		}

        private void txtNroColegiaturaMed_TextChanged(object sender, EventArgs e)
        {
            Exception X = new Exception();
            TextBox T = (TextBox)sender;
            T.Text = T.Text.Trim();
            try
            {
                if (T.Text != "-")
                {
                    int x = int.Parse(T.Text);
                }
            }
            catch (Exception)
            {
                try
                {
                    int CursorIndex = T.SelectionStart - 1;
                    T.Text = T.Text.Remove(CursorIndex, 1);
                    //Align Cursor to same index
                    T.SelectionStart = CursorIndex;
                    T.SelectionLength = 0;
                }
                catch (Exception) { }
            }
        }
    }
}
