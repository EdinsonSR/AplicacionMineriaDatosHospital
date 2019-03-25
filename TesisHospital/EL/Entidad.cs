using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
	public class Entidad
	{
		private int _idEntidad;
		private string _nombreEnt;

		public int IdEntidad { get => _idEntidad; set => _idEntidad = value; }
		public string NombreEnt { get => _nombreEnt; set => _nombreEnt = value; }
	}
}
