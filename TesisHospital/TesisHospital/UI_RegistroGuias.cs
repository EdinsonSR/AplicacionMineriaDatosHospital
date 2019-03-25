using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.IO;
using tessnet2;
using BLL;
using EL;

namespace TesisHospital
{
	public partial class UI_RegistroGuias : Form
	{
		public UI_RegistroGuias()
		{
			InitializeComponent();
		}
		public static UI_RegistroGuias frmHijo;

        public static UI_RegistroGuias CreateInstance(System.Windows.Forms.Form FormParent)
		{
			if (frmHijo == null || frmHijo.IsDisposed)
			{
				frmHijo = new UI_RegistroGuias();
			}
			frmHijo.BringToFront();
			frmHijo.Show();
			return frmHijo;
		}
        int cantidadAdquirida;
        double precioUnitario;
        /*CONSULTA RUC A LA SUNAT*/
        string captcha = "";
		CookieContainer cokkie = new CookieContainer();
		string[] nrosRuc = new string[] { };

		private void genCaptcha()
		{

			try
			{
				HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://www.sunat.gob.pe/cl-ti-itmrconsruc/captcha?accion=image");
				ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;
				request.CookieContainer = cokkie;
				HttpWebResponse response = (HttpWebResponse)request.GetResponse();
				Stream responseStream = response.GetResponseStream();

				var image = new Bitmap(responseStream);
				var ocr = new Tesseract();
				ocr.Init(@"C:\Users\edins\source\repos\tesisHospital\TesisHospital\Content\tessdata", "eng", false);

				var result = ocr.DoOCR(image, Rectangle.Empty);
				foreach (Word word in result)
				{
					captcha = word.Text;
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/*private string getDatafromXML(string lineRead, int len = 0)
		{

			try
			{
				lineRead = lineRead.Trim();
				lineRead = lineRead.Remove(0, len);
				lineRead = lineRead.Replace("</td>", "");
				while (lineRead.Contains("  "))
				{
					lineRead = lineRead.Replace("  ", " ");
				}
				return lineRead;
			}
			catch (Exception)
			{
				return "NO SE ENCONTRO RESULTADO";
			}
		}*/
		/*private Dictionary<string, string> GetDistribuyentes(string nroDoc)
		{
			try
			{
				genCaptcha();

				string myurl = @"http://www.sunat.gob.pe/cl-ti-itmrconsruc/jcrS00Alias?accion=consPorRuc&nroRuc=" + nroDoc.Trim() + "&codigo=" + captcha.Trim().ToUpper() + "&tipdoc=1";
				HttpWebRequest myWebRequest = (HttpWebRequest)WebRequest.Create(myurl);
				myWebRequest.CookieContainer = cokkie;
				ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;

				HttpWebResponse myhttpWebResponse = (HttpWebResponse)myWebRequest.GetResponse();
				Stream myStream = myhttpWebResponse.GetResponseStream();
				StreamReader myStreamReader = new StreamReader(myStream);
				string xDat = ""; int pos = 0;

				Dictionary<string, string> datos = new Dictionary<string, string>();

				//  txtnroRucValue.Text = txtNroDoc.Text;
				datos.Add("RucContribuyente", nroDoc);
				while (!myStreamReader.EndOfStream)
				{
					xDat = myStreamReader.ReadLine();
					pos++;

					switch (pos)
					{
						/*case 126:
							datos.Add("TipoContribuyente", getDatafromXML(xDat, 25));
							break;
						case 131:
							datos.Add("NombreComercial", getDatafromXML(xDat, 25));
							break;
						/*case 136:
							datos.Add("FechaInscripcion", getDatafromXML(xDat, 25));
							break;
						case 138:
							datos.Add("FechaInicioActividad", getDatafromXML(xDat, 25));
							break;
						case 142:
							datos.Add("EstadoContribuyente", getDatafromXML(xDat, 25));
							break;
						/*case 152:
							datos.Add("CondicionContribuyente", getDatafromXML(xDat, 0));
							break;
						case 158:
							datos.Add("DireccionContribuyente", getDatafromXML(xDat, 25));
							break;
						/*case 176:
							datos.Add("AvtividadComercioEx", getDatafromXML(xDat, 25));
							break;
					}
				}
				return datos;
			}
			catch (Exception ex)
			{
				return new Dictionary<string, string>();
			}
		}*/
		/*public void ObtenerDatosSunat()
		{
			try
			{
				string myurl = @"http://www.sunat.gob.pe/cl-ti-itmrconsruc/jcrS00Alias?accion=consPorRuc&nroRuc" + txtNroFactura.Text.Trim() + "&codigo=" + captcha.Trim().ToUpper() + "&tipdoc=1";
				HttpWebRequest myWebRequest = (HttpWebRequest)WebRequest.Create(myurl);
				myWebRequest.CookieContainer = cokkie;
				ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;
				HttpWebResponse myhttpWebResponse = (HttpWebResponse)myWebRequest.GetResponse();
				Stream myStream = myhttpWebResponse.GetResponseStream();
				StreamReader myStreamReader = new StreamReader(myStream);
				string xDat = ""; int pos = 0;
				while (!myStreamReader.EndOfStream)
				{
					//txtnroRucValue.Text = txtNroDoc.Text;
					xDat = myStreamReader.ReadLine();
					pos++;

					switch (pos)
					{
						/*case 126:
							txtTipoContribuyente.Text = getDatafromXML(xDat, 25);
							break;
						case 131:
							lblProovedorNombre.Text = getDatafromXML(xDat, 25);
							break;
						/*case 136:
							txtFechaInscripcion.Text = getDatafromXML(xDat, 25);
							break;
						case 138:
							txtFechaInicioActividad.Text = getDatafromXML(xDat, 25);
							break;
						case 142:
							lblEstadoEmpresa.Text = getDatafromXML(xDat, 25);
							break;
						/*case 152:
							txtCondicionContribuyente.Text = getDatafromXML(xDat, 0);
							break;
						case 158:
							lblDireccionProovedor.Text = getDatafromXML(xDat, 25);
							break;
						/*case 176:
							txtAvtividadComercioEx.Text = getDatafromXML(xDat, 25);
							break;
					}

				}

			}
			catch (Exception ex)
			{
				throw ex;
			}

		}*/
        public void llenarTabla()
        {
            this.dgvNombreMedicamentos.DataSource = null;
            this.dgvNombreMedicamentos.Rows.Clear();
            List<ListaMedicamentos> lista = new List<ListaMedicamentos>();
            lista = MedicamentosBLL.Instancia.listarNombreMedicamento();
            for (int i = 0; i < lista.Count; i++)
            {
                ListaMedicamentos oListaMedicamentos = lista[i];
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(this.dgvNombreMedicamentos);
                row.Cells[0].Value = oListaMedicamentos.NombreMedicamento;
                row.Cells[1].Value = oListaMedicamentos.Concent;
                this.dgvNombreMedicamentos.Rows.Add(row);
            }
        }

        public void llenarTablaStock()
        {
            this.dgvStock.DataSource = null;
            this.dgvStock.Rows.Clear();
            List<MedicamentosAlmacen> lista = new List<MedicamentosAlmacen>();
            lista = MedicamentosBLL.Instancia.listarMedicamentosPorNombre(this.dgvNombreMedicamentos.CurrentRow.Cells[0].Value.ToString(), this.dgvNombreMedicamentos.CurrentRow.Cells[1].Value.ToString());
            for (int i = 0; i < lista.Count; i++)
            {
                MedicamentosAlmacen oListaMedicamentos = lista[i];
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(this.dgvStock);
                row.Cells[0].Value = oListaMedicamentos.DescripcionMeds;
                row.Cells[1].Value = oListaMedicamentos.StockMeds;
                this.dgvStock.Rows.Add(row);
            }
        }

        public void llenarTablaGuia()
        {
            this.dgvMedicamentosGuia.DataSource = null;
            this.dgvMedicamentosGuia.Rows.Clear();
            List<GuiasMedicamentos> lista = new List<GuiasMedicamentos>();
            lista = GuiaMedicamentoBLL.Instancia.llenarTablaStock(this.txtRucEmpresa.Text.Trim(), this.txtNroFactura.Text.Trim());
            for (int i = 0; i < lista.Count; i++)
            {
                GuiasMedicamentos oGuiasMedicamentos = lista[i];
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(this.dgvMedicamentosGuia);
                row.Cells[0].Value = oGuiasMedicamentos.ItemGuia;
                row.Cells[1].Value = oGuiasMedicamentos.DescripcionMedicamentoGuia;
                row.Cells[2].Value = oGuiasMedicamentos.ConcentGuia;
                row.Cells[3].Value = oGuiasMedicamentos.FechaFabricacionMedicamentoGuia;
                row.Cells[4].Value = oGuiasMedicamentos.FechaVencimientoMedicamentoGuia;
                row.Cells[5].Value = oGuiasMedicamentos.CantidadMedicamentoGuia;
                row.Cells[6].Value = oGuiasMedicamentos.PrecioUnitarioMedicamentoGuia;
                row.Cells[7].Value = oGuiasMedicamentos.PrecioTotalMedicamentoGuia;
                this.dgvMedicamentosGuia.Rows.Add(row);
            }
        }

        public void sumarColumnasStock()
        {
            int sumatoria = 0;
            foreach (DataGridViewRow row in dgvStock.Rows)
            {
                sumatoria += Convert.ToInt32(row.Cells["stockTotal"].Value);
            }
            txtStock.Text = Convert.ToString(sumatoria);
        }

        public void sumarTotalGuia()
        {
            double sumarotiaTotal = 0;
            foreach (DataGridViewRow row in dgvMedicamentosGuia.Rows)
            {
                sumarotiaTotal += Convert.ToDouble(row.Cells["precioTotalGuiaMedicamento"].Value);
            }
            txtCostoTotal.Text = Convert.ToString(sumarotiaTotal);
        }

        private bool validar()
        {
            if (string.IsNullOrEmpty(txtNroFactura.Text))
            {
                MessageBox.Show("Ingrese número de documento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (string.IsNullOrEmpty(txtRucEmpresa.Text))
            {
                MessageBox.Show("Ingrese número RUC", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (string.IsNullOrEmpty(txtNombreArticulo.Text))
            {
                MessageBox.Show("Indique que Medicamento desea registrar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return true;
        }

        public void limpiar()
        {
            this.txtNombreArticulo.Clear();
            this.txtConcent.Clear();
            this.txtCantidadAdquirida.Clear();
            this.txtPrecioUnitario.Clear();
            this.txtImporteTotal.Clear();
        }

        private void txtRucEmpresa_KeyPress(object sender, KeyPressEventArgs e)
		{
            string ruc = txtRucEmpresa.Text.Trim();
            LaboratorioProovedor consulta = ConsultaProveedorBLL.Instancia.consultaPorRuc(ruc);
			if ((int)e.KeyChar == (int)Keys.Enter)
			{
                if (consulta != null)
                {
                    this.lblProovedorNombre.Text = consulta.DescripcionLabProov;
                    this.lblDireccionProovedor.Text = consulta.DireccionLabProov;
                }
                else
                {
                    MessageBox.Show("Proveedor no se encuentra registrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
		}

        private void UI_AlmacenFarmacia_Load(object sender, EventArgs e)
        {
            this.txtNombreArticulo.Enabled = false;
            this.txtImporteTotal.Enabled = false;
            this.txtConcent.Enabled = false;
            this.txtStock.Enabled = false;

            llenarTabla();

            
        }
        private void btnAgregarMedicamento_Click(object sender, EventArgs e)
        {
            UI_AgregarMedicamentos form = new UI_AgregarMedicamentos();

            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                llenarTabla();
            }
        }

        private void dgvNombreMedicamentos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtNombreArticulo.Text = this.dgvNombreMedicamentos.CurrentRow.Cells[0].Value.ToString();
            this.txtConcent.Text = this.dgvNombreMedicamentos.CurrentRow.Cells[1].Value.ToString();

            this.txtCantidadAdquirida.Enabled = true;
            this.txtPrecioUnitario.Enabled = true;

            llenarTablaStock();
            sumarColumnasStock();
        }

        private void txtCantidadAdquirida_TextChanged(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txtCantidadAdquirida.Text))
            {
                cantidadAdquirida = 0;
            }
            else
            {
                cantidadAdquirida = Convert.ToInt32(txtCantidadAdquirida.Text);
            }
            
            if (string.IsNullOrEmpty(txtCantidadAdquirida.Text))
            {
                precioUnitario = 0;
            }
            else
            {
                precioUnitario = Convert.ToDouble(txtPrecioUnitario.Text);
            }
            this.txtImporteTotal.Text = string.Format("{0:f2}", cantidadAdquirida * precioUnitario);
 
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                GuiasMedicamentos oGuiaMedicamentos = new GuiasMedicamentos();

                oGuiaMedicamentos.IdGuiaMedicamentos = oGuiaMedicamentos.IdGuiaMedicamentos;
                oGuiaMedicamentos.FechaCompraGuia = Convert.ToDateTime(this.dtpFechaFactura.Text.Trim());
                oGuiaMedicamentos.RucProveedor = this.txtRucEmpresa.Text.Trim();
                oGuiaMedicamentos.NroGuia = this.txtNroFactura.Text.Trim();
                oGuiaMedicamentos.ItemGuia = oGuiaMedicamentos.ItemGuia;
                oGuiaMedicamentos.DescripcionMedicamentoGuia = this.txtNombreArticulo.Text.Trim();
                oGuiaMedicamentos.ConcentGuia = this.txtConcent.Text.Trim();
                oGuiaMedicamentos.PrecioUnitarioMedicamentoGuia = Convert.ToDouble(this.txtPrecioUnitario.Text.Trim());
                oGuiaMedicamentos.CantidadMedicamentoGuia = Convert.ToInt32( this.txtCantidadAdquirida.Text.Trim());
                oGuiaMedicamentos.FechaFabricacionMedicamentoGuia = Convert.ToDateTime(this.dtpFechaFabricacionMed.Text.Trim());
                oGuiaMedicamentos.FechaVencimientoMedicamentoGuia = Convert.ToDateTime(this.dtpFechaVencimientoMed.Text.Trim());
                oGuiaMedicamentos.PrecioTotalMedicamentoGuia = Convert.ToDouble(this.txtImporteTotal.Text.Trim());

                Boolean registrarGuia = GuiaMedicamentoBLL.Instancia.InsertarGuia(oGuiaMedicamentos);
                if (registrarGuia == true)
                {
                    MedicamentosAlmacen oMedicamentoAlmacen = new MedicamentosAlmacen();

                    oMedicamentoAlmacen.IdMedicamentos = oMedicamentoAlmacen.IdMedicamentos;
                    oMedicamentoAlmacen.FechaMeds = Convert.ToDateTime(this.dtpFechaFabricacionMed.Text.Trim());
                    oMedicamentoAlmacen.FechaVencimientoMeds = Convert.ToDateTime(this.dtpFechaVencimientoMed.Text.Trim());
                    oMedicamentoAlmacen.DescripcionMeds = this.txtNombreArticulo.Text.Trim();
                    oMedicamentoAlmacen.StockMeds = Convert.ToInt32( this.txtCantidadAdquirida.Text.Trim());
                    oMedicamentoAlmacen.ConcentMedicamentoAlmacen = this.txtConcent.Text.Trim();

                    Boolean registrarMedsAlmacen = MedicamentosBLL.Instancia.InsertarMedicamentoDeGuia(oMedicamentoAlmacen);

                }
                limpiar();
                llenarTablaStock();
                sumarColumnasStock();
                sumarTotalGuia();
                llenarTablaGuia();
            }

        }

        private void txtNroFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                llenarTablaGuia();
                sumarTotalGuia();
            }
        }

        private void txtRucEmpresa_DoubleClick(object sender, EventArgs e)
        {
            UI_BusquedaProveedor form = new UI_BusquedaProveedor();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                this.txtRucEmpresa.Text = VariablesGlobales.rucProveedor;
                this.lblProovedorNombre.Text = VariablesGlobales.razonSocial;
                this.lblDireccionProovedor.Text = VariablesGlobales.direccionProvedor;
            }
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tspGuardarMedico_Click(object sender, EventArgs e)
        {
            ListaGuias oListaGuias = new ListaGuias();
            oListaGuias.IdListaGuias = oListaGuias.IdListaGuias;
            oListaGuias.GuiaRuc = this.txtRucEmpresa.Text;
            oListaGuias.GuiaNroDoc = this.txtNroFactura.Text;
            oListaGuias.CostoTotal = Convert.ToDouble(this.txtCostoTotal.Text);
            oListaGuias.Fecha = Convert.ToDateTime(this.dtpFechaFactura.Text);
            oListaGuias.FechaGuardado = DateTime.Now;

            Boolean registrarListaGuias = GuiaMedicamentoBLL.Instancia.InsertarListaGuia(oListaGuias);
            if (registrarListaGuias == true)
            {
                MessageBox.Show("Compra registrada Correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
