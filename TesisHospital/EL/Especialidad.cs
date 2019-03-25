using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
	public class Especialidad
	{
		private int _idEspecialidad;
		private string _nombreEsp;
		private string _codEspecialidad;
		public int IdEspecialidad { get => _idEspecialidad; set => _idEspecialidad = value; }
		public string NombreEsp { get => _nombreEsp; set => _nombreEsp = value; }
		public string CodEspecialidad { get => _codEspecialidad; set => _codEspecialidad = value; }
	}
}
