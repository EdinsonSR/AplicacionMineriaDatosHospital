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

            List<Medico> listaMedico = MedicoBLL.Instancia.ListarNombreMedicoPorEspecialidad(this.cbxEspecialidadMedico.Text.Trim());
            if (listaMedico != null)
            {
                this.cbxMedico.DataSource = listaMedico;
                this.cbxMedico.DisplayMember = "MedNam";
            }
            cbxMedico.SelectedIndex = -1;
        }
        private void UI_Citas_Load(object sender, EventArgs e)
        {
            LlenarEspecialidadMedico();
            LlenarNombreMedico();
        }
    }
}
