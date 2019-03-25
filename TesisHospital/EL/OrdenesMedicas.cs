using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
	public class OrdenesMedicas
	{
		private int _idOrdenesMedicas;
		private DateTime _fechaOM;
		private int _prefacturaOM;
		private string _practicasDiagnostico;
		private int _idMedicoOM;
		private int _idPacienteOM;

		public int IdOrdenesMedicas { get => _idOrdenesMedicas; set => _idOrdenesMedicas = value; }
		public DateTime FechaOM { get => _fechaOM; set => _fechaOM = value; }
		public int PrefacturaOM { get => _prefacturaOM; set => _prefacturaOM = value; }
		public string PracticasDiagnostico { get => _practicasDiagnostico; set => _practicasDiagnostico = value; }
		public int IdMedicoOM { get => _idMedicoOM; set => _idMedicoOM = value; }
		public int IdPacienteOM { get => _idPacienteOM; set => _idPacienteOM = value; }
	}
}
