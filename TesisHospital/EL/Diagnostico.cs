using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
	public class Diagnostico
	{
		private int _idDiagnostico;
		private DateTime _fechaDg;
		private string _descripcionDg;

		public int IdDiagnostico { get => _idDiagnostico; set => _idDiagnostico = value; }
		public DateTime FechaDg { get => _fechaDg; set => _fechaDg = value; }
		public string DescripcionDg { get => _descripcionDg; set => _descripcionDg = value; }
	}
}
