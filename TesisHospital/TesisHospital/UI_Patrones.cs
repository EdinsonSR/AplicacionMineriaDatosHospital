using System;
using System.Windows.Forms;
using System.Collections;
using EL;
using BLL;
using System.Collections.Generic;

namespace TesisHospital
{
    public partial class UI_Patrones : Form
    {
        public UI_Patrones()
        {
            InitializeComponent();
        }

        ArrayList especialidadCita = new ArrayList();
        ArrayList CantidadCitas = new ArrayList();

        private void UI_Patrones_Load(object sender, EventArgs e)
        {

        }

        public void graficarBarras()
        {
            List<Cita> lista = new List<Cita>();
            lista = PatronesBLL.instance.
            //lista = CitasBLL.Instancia.listarCitasPorMedicoYFecha(Convert.ToDateTime(this.dtpFechaCita.Text), this.cbxMedico.Text.Trim());

        }
    }
}
