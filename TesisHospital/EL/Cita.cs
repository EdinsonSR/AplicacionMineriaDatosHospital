using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
	public class Cita
	{
		private int _idCita;
		private DateTime _fechaCita;
		private string _paternoPacCit;
		private string _maternoPacCit;
		private string _nombresPacCit;
		private string _medicoCit;
		private int _atendidaCit;

		public int IdCita { get => _idCita; set => _idCita = value; }
		public DateTime FechaCita { get => _fechaCita; set => _fechaCita = value; }
		public string PaternoPacCit { get => _paternoPacCit; set => _paternoPacCit = value; }
		public string MaternoPacCit { get => _maternoPacCit; set => _maternoPacCit = value; }
		public string NombresPacCit { get => _nombresPacCit; set => _nombresPacCit = value; }
		public string MedicoCit { get => _medicoCit; set => _medicoCit = value; }
		public int AtendidaCit { get => _atendidaCit; set => _atendidaCit = value; }
	}
}
