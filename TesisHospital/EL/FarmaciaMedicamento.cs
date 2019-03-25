using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
	public class FarmaciaMedicamento
	{
		private int _idFarmMeds;
		private int _idMedicamentosFM;
		private int _idFarmaciaFM;
		private int _stock;

		public int IdFarmMeds { get => _idFarmMeds; set => _idFarmMeds = value; }
		public int IdMedicamentosFM { get => _idMedicamentosFM; set => _idMedicamentosFM = value; }
		public int IdFarmaciaFM { get => _idFarmaciaFM; set => _idFarmaciaFM = value; }
		public int Stock { get => _stock; set => _stock = value; }
	}
}
