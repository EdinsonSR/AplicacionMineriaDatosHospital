using System;
using System.Data;
using CrystalDecisions.CrystalReports.Engine;
using System.Windows.Forms;
using EL;
using BLL;
using TesisHospital.Reportes;
using System.Runtime.InteropServices;
using System.Drawing;

namespace TesisHospital
{
	public partial class UI_MenuPrincipal : Form
	{
		public UI_MenuPrincipal()
		{
			InitializeComponent();
		}
		Especialidad oEspecialidad = new Especialidad();

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void UI_MenuPrincipal_Load(object sender, EventArgs e)
		{
            btnFarmacia.Location = new Point(11, 153);
            btnNosotros.Location = new Point(11, 201);
            SubmenuFarmacia.Hide();
            subMenuNosotros.Hide();

        }
        public void AbrirFormInPanel(object Formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void btnFarmacia_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnFarmacia.Height;
            SidePanel.Top = btnFarmacia.Top;

            if (SubmenuFarmacia.Visible == true)
            {
                SubmenuFarmacia.Visible = false;
            }
            else
            {
                SubmenuFarmacia.Visible = true;
            }

            SubmenuFarmacia.Location = new Point(11, 200);

            SidePanel.Location = new Point(0, 153);
            btnFarmacia.Location = new Point(11, 153);
            btnNosotros.Location = new Point(11,301);
            btnAmbulatorio.Location = new Point(11, 346);
            btnUCI.Location = new Point(11, 395);
            btnEmergencia.Location = new Point(11, 444);
            btnReportes.Location = new Point(11, 493);
            btnPatrones.Location = new Point(11, 537);

            subMenuNosotros.Hide();
            submenuAmbulatorio.Hide();

            if (SubmenuFarmacia.Visible == false)
            {
                SidePanel.Location = new Point(0, 153);
                btnFarmacia.Location = new Point(11, 153);
                btnNosotros.Location = new Point(11, 201);
                btnAmbulatorio.Location = new Point(11, 246);
                btnUCI.Location = new Point(11, 295);
                btnEmergencia.Location = new Point(11, 344);
                btnReportes.Location = new Point(11, 393);
                btnPatrones.Location = new Point(11, 437);
            }
        }

        private void btnlogoInicio_Click(object sender, EventArgs e)
        {
        }

        private void btnNosotros_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnNosotros.Height;
            SidePanel.Top = btnNosotros.Top;

            if (subMenuNosotros.Visible == true )
            {
                subMenuNosotros.Visible = false;
            }
            else
            {
                subMenuNosotros.Visible = true;
            }

            subMenuNosotros.Location = new Point(11, 247);
            SidePanel.Location = new Point(0, 201);
            btnFarmacia.Location = new Point(11, 153);
            btnNosotros.Location = new Point(11, 201);
            btnAmbulatorio.Location = new Point(11, 386);
            btnUCI.Location = new Point(11, 435);
            btnEmergencia.Location = new Point(11, 484);
            btnReportes.Location = new Point(11, 533);
            btnPatrones.Location = new Point(11, 577);

            SubmenuFarmacia.Hide();
            submenuAmbulatorio.Hide();

            if (subMenuNosotros.Visible == false)
            {
                SidePanel.Location = new Point(0, 201);
                btnFarmacia.Location = new Point(11, 153);
                btnNosotros.Location = new Point(11, 201);
                btnAmbulatorio.Location = new Point(11, 246);
                btnUCI.Location = new Point(11, 295);
                btnEmergencia.Location = new Point(11, 344);
                btnReportes.Location = new Point(11, 393);
                btnPatrones.Location = new Point(11, 437);
            }
        }

        private void btnslide_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 223)
            {
                MenuVertical.Width = 70;
                if (subMenuNosotros.Visible == true || SubmenuFarmacia.Visible == true || submenuAmbulatorio.Visible == true)
                {
                    subMenuNosotros.Visible = false;
                    SubmenuFarmacia.Visible = false;
                    submenuAmbulatorio.Visible = false;
                }
                else
                {
                    subMenuNosotros.Visible = false;
                    SubmenuFarmacia.Visible = false;
                    submenuAmbulatorio.Visible = false;
                }
                if (subMenuNosotros.Visible == false || SubmenuFarmacia.Visible == true || submenuAmbulatorio.Visible == true)
                {
                    btnFarmacia.Location = new Point(11, 153);
                    btnNosotros.Location = new Point(11, 201);
                    btnAmbulatorio.Location = new Point(11, 246);
                    btnUCI.Location = new Point(11, 295);
                    btnEmergencia.Location = new Point(11, 344);
                    btnReportes.Location = new Point(11, 393);
                    btnPatrones.Location = new Point(11, 437);
                }
            }
            else
                MenuVertical.Width = 223;
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEmergencia_Click(object sender, EventArgs e)
        {
            
        }

        private void btnFarmacia_Guias_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new UI_RegistroGuias());
            lblOpcion.Text = "COMPRAS DE MEDICAMENTOS";
        }

        private void btnFarmacia_Ventas_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new UI_VentasFarmacia());
            lblOpcion.Text = "VENTAS DE MEDICAMENTOS";
        }

        private void btnNosotros_MedicosActivos_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new UI_HorariosMedicos());
            lblOpcion.Text = "HORARIOS MEDICOS";
        }

        private void btnConsultorio_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new UI_Consultorios());
            lblOpcion.Text = "CONSULTORIOS";
        }

        private void btnNosotros_EspecialidadesMedicas_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new UI_RegistroEspecialidad());
            lblOpcion.Text = "ESPECIALIDADES MÉDICAS";
        }

        private void btnNosotros_areas_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new UI_AreasEspecialidades());
            lblOpcion.Text = "AREAS MÉDICAS";
        }

        private void btnFarmacia_Almacen_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new UI_AlmacenMedicamentos());
            lblOpcion.Text = "ALMACEN DE MEDICAMENTOS";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void btnAmbulatorio_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnAmbulatorio.Height;
            SidePanel.Top = btnAmbulatorio.Top;

            if (submenuAmbulatorio.Visible == true)
            {
                submenuAmbulatorio.Visible = false;
            }
            else
            {
                submenuAmbulatorio.Visible = true;
            }

            submenuAmbulatorio.Location = new Point(11, 295);
            SidePanel.Location = new Point(0, 246);
            btnFarmacia.Location = new Point(11, 153);
            btnNosotros.Location = new Point(11, 201);
            btnAmbulatorio.Location = new Point(11, 246);
            btnUCI.Location = new Point(11, 402);
            btnEmergencia.Location = new Point(11, 451);
            btnReportes.Location = new Point(11, 500);
            btnPatrones.Location = new Point(11, 544);

            SubmenuFarmacia.Hide();
            subMenuNosotros.Hide();

            if (submenuAmbulatorio.Visible == false)
            {
                SidePanel.Location = new Point(0, 246);
                btnFarmacia.Location = new Point(11, 153);
                btnNosotros.Location = new Point(11, 201);
                btnAmbulatorio.Location = new Point(11, 246);
                btnUCI.Location = new Point(11, 295);
                btnEmergencia.Location = new Point(11, 344);
                btnReportes.Location = new Point(11, 393);
                btnPatrones.Location = new Point(11, 437);
            }
        }

        private void brnCitas_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new UI_Citas());
            lblOpcion.Text = "CITAS MÉDICAS";
        }

        private void btnPatrones_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new UI_Patrones());
            lblOpcion.Text = "CONOCIMIENTO ORGANIZACIONAL";
        }
    }
}
