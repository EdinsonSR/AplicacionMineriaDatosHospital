using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
	public class MedicamentosAlmacen
	{
		private int _idMedicamentos;
		private DateTime _fechaMeds;
		private DateTime _fechaVencimientoMeds;
        private string _descripcionMeds;
        private int stockMeds;
        private string concentMedicamentoAlmacen;

        public int IdMedicamentos { get => _idMedicamentos; set => _idMedicamentos = value; }
		public DateTime FechaMeds { get => _fechaMeds; set => _fechaMeds = value; }
		public DateTime FechaVencimientoMeds { get => _fechaVencimientoMeds; set => _fechaVencimientoMeds = value; }
		public string DescripcionMeds { get => _descripcionMeds; set => _descripcionMeds = value; }
        public int StockMeds { get => stockMeds; set => stockMeds = value; }
        public string ConcentMedicamentoAlmacen { get => concentMedicamentoAlmacen; set => concentMedicamentoAlmacen = value; }
    }
}
