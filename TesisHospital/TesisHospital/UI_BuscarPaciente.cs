using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesisHospital
{
    public partial class UI_BuscarPaciente : Form
    {
        public UI_BuscarPaciente()
        {
            InitializeComponent();
        }
        private static UI_BuscarPaciente frmHijo;


        public static UI_BuscarPaciente CreateInstance(System.Windows.Forms.Form FormParent)
        {
            if (frmHijo == null || frmHijo.IsDisposed)
            {
                frmHijo = new UI_BuscarPaciente();
            }
            frmHijo.BringToFront();
            frmHijo.Show();
            return frmHijo;
        }
        private void UI_BuscarPaciente_Load(object sender, EventArgs e)
        {

        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
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

        private void rdbDNI_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdbDNI.Checked)
            {
                txtDNI.Enabled = true;
                txtPaciente.Clear();
                txtDNI.Clear();
                txtPaciente.Enabled = false;
            }
            else
            {
                this.txtDNI.Enabled = false;
                this.dgvProveedor.Rows.Clear();
            }
        }

        private void rdbPaciente_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdbPaciente.Checked)
            {
                txtPaciente.Enabled = true;
                txtPaciente.Clear();
                txtDNI.Clear();
                txtDNI.Enabled = false;
            }
            else
            {
                this.txtPaciente.Enabled = false;
                this.dgvProveedor.Rows.Clear();
            }
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
