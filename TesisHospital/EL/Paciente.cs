using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
	public class Paciente
	{
		private int _idPaciente;
		private int _prefactura;
		private int _documento;
		private string _tipodoc;
		private string _paterno;
		private string _materno;
		private string _nombres;
		private int _edad;
		private string _peso;
		private string _sexo;
		private string _procedencia;
		private string _grupoSanguineo;
		private string _alergia;
		private DateTime registro;
		private int idMedicoPac;

		public int IdPaciente { get => _idPaciente; set => _idPaciente = value; }
		public int Prefactura { get => _prefactura; set => _prefactura = value; }
		public int Documento { get => _documento; set => _documento = value; }
		public string Tipodoc { get => _tipodoc; set => _tipodoc = value; }
		public string Paterno { get => _paterno; set => _paterno = value; }
		public string Materno { get => _materno; set => _materno = value; }
		public string Nombres { get => _nombres; set => _nombres = value; }
		public int Edad { get => _edad; set => _edad = value; }
		public string Peso { get => _peso; set => _peso = value; }
		public string Sexo { get => _sexo; set => _sexo = value; }
		public string Procedencia { get => _procedencia; set => _procedencia = value; }
		public string GrupoSanguineo { get => _grupoSanguineo; set => _grupoSanguineo = value; }
		public string Alergia { get => _alergia; set => _alergia = value; }
		public DateTime Registro { get => registro; set => registro = value; }
		public int IdMedicoPac { get => idMedicoPac; set => idMedicoPac = value; }
	}
}
