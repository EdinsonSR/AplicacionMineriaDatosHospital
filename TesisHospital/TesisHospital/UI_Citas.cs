using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using EL;

namespace TesisHospital
{
    public partial class UI_Citas : Form
    {
        public UI_Citas()
        {
            InitializeComponent();

        }
        
        public void LlenarEspecialidadMedico()
        {
            this.cbxEspecialidadMedico.DataSource = null;
            this.cbxEspecialidadMedico.Items.Clear();

            List<Especialidad> listaEspecialidad = EspecialidadBLL.Instancia.ListarNombreEspecialidad();
            if (listaEspecialidad != null)
            {
                this.cbxEspecialidadMedico.DataSource = listaEspecialidad;
                this.cbxEspecialidadMedico.DisplayMember = "nombreEsp";
            }
            cbxEspecialidadMedico.SelectedIndex = -1;
        }
       
        public void LlenarNombreMedico()
        {
            this.cbxMedico.DataSource = null;
            this.cbxMedico.Items.Clear();

            List<Medico> listaMedico = MedicoBLL.Instancia.ListarNombreMedicoPorEspecialidadYFecha(this.cbxEspecialidadMedico.Text.Trim(), Convert.ToDateTime(this.dtpFechaCita.Text));
            if (listaMedico != null)
            {
                this.cbxMedico.DataSource = listaMedico;
                this.cbxMedico.DisplayMember = "MedNam";
                
            }
            cbxMedico.SelectedIndex = -1;
        }
        
        public void llenarTablaCitas()
        {
            this.dgvCitas.DataSource = null;
            this.dgvCitas.Rows.Clear();
            List<Cita> lista = new List<Cita>();
            lista = CitasBLL.Instancia.listarCitasPorMedicoYFecha(Convert.ToDateTime(this.dtpFechaCita.Text), this.cbxMedico.Text.Trim());
            for (int i = 0; i < lista.Count; i++)
            {
                Cita oCita = lista[i];
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(this.dgvCitas);
                row.Cells[0].Value = oCita.HoraCita;
                row.Cells[1].Value = oCita.NombrePaciente;
                row.Cells[2].Value = oCita.AtendidaCit;
                this.dgvCitas.Rows.Add(row);
            }
        }
        private void UI_Citas_Load(object sender, EventArgs e)
        {
            LlenarEspecialidadMedico();

        }

        private void tspGuardarCitas_Click(object sender, EventArgs e)
        {

        }

        private void dtpFechaCita_ValueChanged(object sender, EventArgs e)
        {
            LlenarNombreMedico();
        }

        private void cbxMedico_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarTablaCitas();
           
        }

        private void cbxMedico_ValueMemberChanged(object sender, EventArgs e)
        {

        }

        private void cbxMedico_SelectedValueChanged(object sender, EventArgs e)
        {
            HorariosMedicos lista = MedicoBLL.Instancia.busquedaHorariosMedicosCitas(Convert.ToDateTime(this.dtpFechaCita.Text), this.cbxMedico.Text.Trim());
            if (lista != null)
            {
                this.txtHoraInicial.Text = lista.HoraInicialMedico;
                this.txtHoraFinal.Text = lista.HoraFinalMedico;
            }
        }

        private void btnAbrirFormRegistrarCita_Click(object sender, EventArgs e)
        {
            UI_RegistrarCita.CreateInstance(this);
            VariablesGlobales.fechaCita = Convert.ToDateTime(this.dtpFechaCita.Text);
            VariablesGlobales.nombreMedico = this.cbxMedico.Text.Trim();
            VariablesGlobales.especialidadMedicoCita = this.cbxEspecialidadMedico.Text.Trim();

            llenarTablaCitas();
        }
    }
}
