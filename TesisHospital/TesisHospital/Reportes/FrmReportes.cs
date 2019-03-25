using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesisHospital.Reportes
{
	public partial class FrmReportes : Form
	{
		public FrmReportes()
		{
			InitializeComponent();
		}
		public object CRViewer { get; internal set; }
		private void FrmReportes_Load(object sender, EventArgs e)
		{

		}
	}
}
