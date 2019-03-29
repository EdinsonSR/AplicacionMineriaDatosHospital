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
    public partial class UI_RegistrarCita : Form
    {
        public UI_RegistrarCita()
        {
            InitializeComponent();
        }
        public static UI_RegistrarCita frmHijo;
        public static UI_RegistrarCita CreateInstance(System.Windows.Forms.Form FormParent)
        {
            if (frmHijo == null || frmHijo.IsDisposed)
            {
                frmHijo = new UI_RegistrarCita();
            }
            frmHijo.BringToFront();
            frmHijo.Show();
            return frmHijo;
        }

        public void limpiar()
        {
            this.txtDni.Clear();
            this.txtPaternoMed.Clear();
            this.txtMaternoMed.Clear();
            this.txtNombresMed.Clear();
            this.dtpHoraCita.ResetText();
        }
        private void btnRegistrarCita_Click(object sender, EventArgs e)
        {
            
            Cita oCita = new Cita();
            oCita.IdCita = oCita.IdCita;
            oCita.FechaCita = VariablesGlobales.fechaCita;
            oCita.AtendidaCit = 0;
            oCita.HoraCita = this.dtpHoraCita.Text.Trim();
            oCita.MedicoCita = VariablesGlobales.nombreMedico;
            oCita.EspecialidadCita = VariablesGlobales.especialidadMedicoCita;
            oCita.NombrePaciente = this.txtPaternoMed.Text.Trim() + ' ' + this.txtMaternoMed.Text.Trim()+ ' ' + this.txtNombresMed.Text.Trim();

            Boolean RegistrarCita = CitasBLL.Instancia.RegistrarCita(oCita);
            if (RegistrarCita == true)
            {
                MessageBox.Show("Registro Correcto", "Información", MessageBoxButtons.OK);
                limpiar();
            }
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
