using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesisHospital
{
    public class ListaMedicamentos
    {
        private int _idListaMedicamentos;
        private string _nombreMedicamento;
        private string _concent;

        public int IdListaMedicamentos { get => _idListaMedicamentos; set => _idListaMedicamentos = value; }
        public string NombreMedicamento { get => _nombreMedicamento; set => _nombreMedicamento = value; }
        public string Concent { get => _concent; set => _concent = value; }
    }
}
