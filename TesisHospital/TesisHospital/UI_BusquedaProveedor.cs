using System;
using System.Windows.Forms;
using EL;
using BLL;
using System.Collections.Generic;

namespace TesisHospital
{
    public partial class UI_BusquedaProveedor : Form
    {
        public UI_BusquedaProveedor()
        {
            InitializeComponent();
        }
        private static UI_BusquedaProveedor frmHijo;


        public static UI_BusquedaProveedor CreateInstance(System.Windows.Forms.Form FormParent)
        {
            if (frmHijo == null || frmHijo.IsDisposed)
            {
                frmHijo = new UI_BusquedaProveedor();
            }
            frmHijo.BringToFront();
            frmHijo.Show();
            return frmHijo;
        }
        private void rdbRUC_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdbRUC.Checked)
            {
                txtRUC.Enabled = true;
                txtRazonSocial.Clear();
                txtRUC.Clear();
            }
            else
            {
                this.txtRUC.Enabled = false;
                this.dgvProveedor.Rows.Clear();
            }
        }

        private void rdbRazonSocial_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdbRazonSocial.Checked)
            {
                txtRazonSocial.Enabled = true;
                txtRUC.Clear();
                txtRazonSocial.Clear();
            }
            else
            {
                this.txtRazonSocial.Enabled = false;
                this.dgvProveedor.Rows.Clear();
            }
        }
        private void llenarTabla()
        {
            this.dgvProveedor.DataSource = null;
            this.dgvProveedor.Rows.Clear();
            List<LaboratorioProovedor> lista = new List<LaboratorioProovedor>();
            lista = ConsultaProveedorBLL.Instancia.listarPorRuc(txtRUC.Text, 1);
            for (int i = 0; i < lista.Count; i++)
            {
                LaboratorioProovedor oLaboratorioProovedor = lista[i];
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(this.dgvProveedor);
                row.Cells[0].Value = oLaboratorioProovedor.Ruc;
                row.Cells[1].Value = oLaboratorioProovedor.DescripcionLabProov;
                row.Cells[2].Value = oLaboratorioProovedor.TelefonoProv;
                row.Cells[3].Value = oLaboratorioProovedor.DireccionLabProov;
                this.dgvProveedor.Rows.Add(row);
            }
        }

        private void llenarTablaRazonSocial()
        {
            this.dgvProveedor.DataSource = null;
            this.dgvProveedor.Rows.Clear();
            List<LaboratorioProovedor> lista = new List<LaboratorioProovedor>();
            lista = ConsultaProveedorBLL.Instancia.listarPorRuc(txtRazonSocial.Text, 2);
            for (int i = 0; i < lista.Count; i++)
            {
                LaboratorioProovedor oLaboratorioProovedor = lista[i];
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(this.dgvProveedor);
                row.Cells[0].Value = oLaboratorioProovedor.Ruc;
                row.Cells[1].Value = oLaboratorioProovedor.DescripcionLabProov;
                row.Cells[2].Value = oLaboratorioProovedor.TelefonoProv;
                row.Cells[3].Value = oLaboratorioProovedor.DireccionLabProov;
                this.dgvProveedor.Rows.Add(row);
            }
        }
        private void UI_BusquedaProveedor_Load(object sender, EventArgs e)
        {
            this.rdbRUC.Checked = true;
            txtRUC.Focus();
        }

        private void txtRUC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)44 && e.KeyChar != (char)46 && !Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            if (this.txtRUC.Text.Trim().Length != 0)
            {
                if (e.KeyChar == (char)13)
                {
                    this.dgvProveedor.Rows.Clear();
                    llenarTabla();
                }
            }
        }

        private void dgvProveedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            VariablesGlobales.rucProveedor = this.dgvProveedor.CurrentRow.Cells[0].Value.ToString();
            VariablesGlobales.razonSocial = this.dgvProveedor.CurrentRow.Cells[1].Value.ToString();
            VariablesGlobales.direccionProvedor = this.dgvProveedor.CurrentRow.Cells[3].Value.ToString();

            this.DialogResult = DialogResult.OK;
        }

        private void txtRazonSocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.txtRazonSocial.Text.Trim().Length != 0)
            {
                if (e.KeyChar == (char)13)
                {
                    this.dgvProveedor.Rows.Clear();
                    llenarTablaRazonSocial();
                }
            }
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtRUC_TextChanged(object sender, EventArgs e)
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
