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
    public partial class UI_RegistroMedicos : Form
    {
        public UI_RegistroMedicos()
        {
            InitializeComponent();
        }
        public static UI_RegistroMedicos frmHijo;
        public static UI_RegistroMedicos CreateInstance(System.Windows.Forms.Form FormParent)
        {
            if (frmHijo == null || frmHijo.IsDisposed)
            {
                frmHijo = new UI_RegistroMedicos();
            }
            frmHijo.BringToFront();
            frmHijo.Show();
            return frmHijo;
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
        public void limpiar()
        {
            txtCmp.Clear();
            txtDni.Clear();
            txtPaternoMed.Clear();
            txtMaternoMed.Clear();
            txtNombresMed.Clear();
            txtTelefono.Clear();
            txtCelular.Clear();
            txtDireccion.Clear();
        }
        private void btnGuardarMedico_Click(object sender, EventArgs e)
        {
            Medico oMedico = new Medico();

            oMedico.IdMedico = oMedico.IdMedico;
            oMedico.CmpMedico = this.txtCmp.Text;
            oMedico.DniMedico = this.txtDni.Text;
            oMedico.PaternoMedico = this.txtPaternoMed.Text.Trim();
            oMedico.MaternoMedico = this.txtMaternoMed.Text.Trim();
            oMedico.NombresMedico = this.txtNombresMed.Text.Trim();
            oMedico.TelefonoMedico = this.txtTelefono.Text;
            oMedico.CelularMedico = this.txtCelular.Text;
            oMedico.DireccionMedico = this.txtDireccion.Text;
            oMedico.Especialidad = this.cbxEspecialidadMedico.Text.Trim();
            oMedico.FechaRegistro = DateTime.Now;

            Boolean InsertarNuevoMedico = MedicoBLL.Instancia.InsertarNuevoMedico(oMedico);
            if (InsertarNuevoMedico == true)
            {
                MessageBox.Show("Medico Registrado", "Información", MessageBoxButtons.OK);
                limpiar();
            }

        }

        private void txtCmp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UI_RegistroMedicos_Load(object sender, EventArgs e)
        {
            LlenarEspecialidadMedico();
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
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

        private void txtCelular_TextChanged(object sender, EventArgs e)
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

        private void txtTelefono_TextChanged(object sender, EventArgs e)
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
