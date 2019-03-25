using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class Medico
    {
        private int _idMedico;
        private string _cmpMedico;
        private string _dniMedico;
        private string _paternoMedico;
        private string _maternoMedico;
        private string _nombresMedico;
        private string _telefonoMedico;
        private string _celularMedico;
        private string _direccionMedico;
        private string _especialidad;
        private DateTime _fechaRegistro;

        private string _medNam;

        public int IdMedico { get => _idMedico; set => _idMedico = value; }
        public string CmpMedico { get => _cmpMedico; set => _cmpMedico = value; }
        public string DniMedico { get => _dniMedico; set => _dniMedico = value; }
        public string PaternoMedico { get => _paternoMedico; set => _paternoMedico = value; }
        public string MaternoMedico { get => _maternoMedico; set => _maternoMedico = value; }
        public string NombresMedico { get => _nombresMedico; set => _nombresMedico = value; }
        public string TelefonoMedico { get => _telefonoMedico; set => _telefonoMedico = value; }
        public string CelularMedico { get => _celularMedico; set => _celularMedico = value; }
        public string DireccionMedico { get => _direccionMedico; set => _direccionMedico = value; }
        public string Especialidad { get => _especialidad; set => _especialidad = value; }
        public DateTime FechaRegistro { get => _fechaRegistro; set => _fechaRegistro = value; }
        public string MedNam { get => _medNam; set => _medNam = value; }
    }
}
