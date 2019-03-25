using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
	public class AreasEspecialidades
	{
		private int _idAreaEspecialidades;
		private string _nombreAreasEspecialidades;

		public int IdAreaEspecialidades { get => _idAreaEspecialidades; set => _idAreaEspecialidades = value; }
		public string NombreAreasEspecialidades { get => _nombreAreasEspecialidades; set => _nombreAreasEspecialidades = value; }
	}
}
