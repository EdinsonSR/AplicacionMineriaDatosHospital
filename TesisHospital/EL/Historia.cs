using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
	public class Historia
	{
		private int _idHistoria;
		private int _nroHistoria;
		private string _prefacturaHist;
		private int _documentoHist;
		private string _direccionHist;
		private string _sexoHist;
		private int _edadHist;
		private DateTime _regFechaHist;
		private DateTime _regMovHist;
		private int _idMedicoHist;
		private int _idPacienteHist;

		public int IdHistoria { get => _idHistoria; set => _idHistoria = value; }
		public int NroHistoria { get => _nroHistoria; set => _nroHistoria = value; }
		public string PrefacturaHist { get => _prefacturaHist; set => _prefacturaHist = value; }
		public int DocumentoHist { get => _documentoHist; set => _documentoHist = value; }
		public string DireccionHist { get => _direccionHist; set => _direccionHist = value; }
		public string SexoHist { get => _sexoHist; set => _sexoHist = value; }
		public int EdadHist { get => _edadHist; set => _edadHist = value; }
		public DateTime RegFechaHist { get => _regFechaHist; set => _regFechaHist = value; }
		public DateTime RegMovHist { get => _regMovHist; set => _regMovHist = value; }
		public int IdMedicoHist { get => _idMedicoHist; set => _idMedicoHist = value; }
		public int IdPacienteHist { get => _idPacienteHist; set => _idPacienteHist = value; }
	}
}
