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
    public partial class UI_AlmacenMedicamentos : Form
    {
        public UI_AlmacenMedicamentos()
        {
            InitializeComponent();
        }

        private void UI_AlmacenMedicamentos_Load(object sender, EventArgs e)
        {

        }
        public void sumarColumnasStock()
        {
            int sumatoria = 0;
            foreach (DataGridViewRow row in dgvStockMedicamentos.Rows)
            {
                sumatoria += Convert.ToInt32(row.Cells["stockMedicamento"].Value);
            }
            txtStockTotal.Text = Convert.ToString(sumatoria);
        }
        public void llenarTablaStock()
        {
            this.dgvStockMedicamentos.DataSource = null;
            this.dgvStockMedicamentos.Rows.Clear();
            List<MedicamentosAlmacen> lista = new List<MedicamentosAlmacen>();
            lista = MedicamentosBLL.Instancia.listarMedicamentosPorNombre(this.txtNombreArticulo.Text, this.txtConcentMedicamento.Text);
            for (int i = 0; i < lista.Count; i++)
            {
                MedicamentosAlmacen oListaMedicamentos = lista[i];
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(this.dgvStockMedicamentos);
                row.Cells[0].Value = oListaMedicamentos.DescripcionMeds;
                row.Cells[1].Value = oListaMedicamentos.ConcentMedicamentoAlmacen;
                row.Cells[2].Value = oListaMedicamentos.StockMeds;
                this.dgvStockMedicamentos.Rows.Add(row);
            }
        }

        private void txtConcentMedicamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                llenarTablaStock();
                sumarColumnasStock();
            }
        }
    }
}
