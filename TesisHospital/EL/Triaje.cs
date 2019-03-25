using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
	public class Triaje
	{
		private int _idTriaje;
		private string _temperatura;
		private string _frecuenciaCardiaca;
		private string _presionArterial;
		private float _peso;
		private string _talla;
		private int _idMedicoTj;
		private int _idPacienteTj;

		public int IdTriaje { get => _idTriaje; set => _idTriaje = value; }
		public string Temperatura { get => _temperatura; set => _temperatura = value; }
		public string FrecuenciaCardiaca { get => _frecuenciaCardiaca; set => _frecuenciaCardiaca = value; }
		public string PresionArterial { get => _presionArterial; set => _presionArterial = value; }
		public float Peso { get => _peso; set => _peso = value; }
		public string Talla { get => _talla; set => _talla = value; }
		public int IdMedicoTj { get => _idMedicoTj; set => _idMedicoTj = value; }
		public int IdPacienteTj { get => _idPacienteTj; set => _idPacienteTj = value; }
	}
}
