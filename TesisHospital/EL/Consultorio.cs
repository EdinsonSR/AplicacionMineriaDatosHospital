using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
	public class Consultorio
	{
		private int _idConsultorio;
		private string _nombreConsultorio;
		private string _nombreAreasEspecialidades;

		public int IdConsultorio { get => _idConsultorio; set => _idConsultorio = value; }
		public string NombreConsultorio { get => _nombreConsultorio; set => _nombreConsultorio = value; }
		public string NombreAreasEspecialidades { get => _nombreAreasEspecialidades; set => _nombreAreasEspecialidades = value; }
	}
}
