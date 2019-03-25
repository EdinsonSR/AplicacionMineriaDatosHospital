using System;
using System.Windows.Forms;
using BLL;

namespace TesisHospital
{
    public partial class UI_AgregarMedicamentos : Form
    {
        public UI_AgregarMedicamentos()
        {
            InitializeComponent();
        }
        public static UI_AgregarMedicamentos frmHijo;
        public static UI_AgregarMedicamentos CreateInstance(System.Windows.Forms.Form FormParent)
        {
            if (frmHijo == null || frmHijo.IsDisposed)
            {
                frmHijo = new UI_AgregarMedicamentos();
            }
            frmHijo.BringToFront();
            frmHijo.Show();
            return frmHijo;
        }
        public void limpiar()
        {
            this.txtNombreArticulo.Clear();
            this.txtConcent.Clear();
        }
        private void UI_AgregarMedicamentos_Load(object sender, EventArgs e)
        {
       
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarMedico_Click(object sender, EventArgs e)
        {
            ListaMedicamentos oGuiaMedicamentos = new ListaMedicamentos();

            oGuiaMedicamentos.IdListaMedicamentos = oGuiaMedicamentos.IdListaMedicamentos;
            oGuiaMedicamentos.NombreMedicamento = this.txtNombreArticulo.Text.Trim();
            oGuiaMedicamentos.Concent = this.txtConcent.Text;

            Boolean RegistrarNuevoMedicamento = MedicamentosBLL.Instancia.InsertarMedicamentoLista(oGuiaMedicamentos);
            if (RegistrarNuevoMedicamento == true)
            {
                MessageBox.Show("Medicamento Registrado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                limpiar();
            }
        }
    }
}
