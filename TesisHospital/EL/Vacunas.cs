using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
	public class Vacunas
	{
		private int _idVacuna;
		private string _nombreVc;
		private string _responsableVc;
		private int _idPaciente;

		public int IdVacuna { get => _idVacuna; set => _idVacuna = value; }
		public string NombreVc { get => _nombreVc; set => _nombreVc = value; }
		public string ResponsableVc { get => _responsableVc; set => _responsableVc = value; }
		public int IdPaciente { get => _idPaciente; set => _idPaciente = value; }
	}
}
