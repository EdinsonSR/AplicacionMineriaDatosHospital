using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
	public class Horarios
	{
		private int _idHorario;
		private int _idPaciente;
		private string _descripcion;
		private int _idMedicoHor;

		public int IdHorario { get => _idHorario; set => _idHorario = value; }
		public int IdPaciente { get => _idPaciente; set => _idPaciente = value; }
		public string Descripcion { get => _descripcion; set => _descripcion = value; }
		public int IdMedicoHor { get => _idMedicoHor; set => _idMedicoHor = value; }
	}
}
