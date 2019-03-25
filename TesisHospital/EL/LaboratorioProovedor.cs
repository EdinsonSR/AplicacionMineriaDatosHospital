using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
	public class LaboratorioProovedor
	{
		private string _idLabProov;
		private string _descripcionLabProov;
        private string _direccionLabProov;
        private string _ruc;
        private string _telefonoProv;

		public string IdLabProov { get => _idLabProov; set => _idLabProov = value; }
		public string DescripcionLabProov { get => _descripcionLabProov; set => _descripcionLabProov = value; }
        public string DireccionLabProov { get => _direccionLabProov; set => _direccionLabProov = value; }
        public string Ruc { get => _ruc; set => _ruc = value; }
        public string TelefonoProv { get => _telefonoProv; set => _telefonoProv = value; }
    }
}
