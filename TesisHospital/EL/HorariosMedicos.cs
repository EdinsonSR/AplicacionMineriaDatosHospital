using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
	public class HorariosMedicos
	{
		private int _idMedico;
		private int _medCod;
		private string _nombreMedico;
		private string _nombre;
		private string _medCol;
		private int _idEspecialidadMedico;
		private int _idEntidadMed;
		private string _medEspecialidad;
		private string _paternoMed;
		private string _maternoMed;
		private string _consultorio;
		private DateTime _fechaInicio;
		private DateTime _fechaFin;
		private string _horaInicio;
		private string _horaFin;
		private DateTime _fecharegistro;

        /**/
        private string _horaInicialMedico;
        private string _horaFinalMedico;

        public int IdMedico { get => _idMedico; set => _idMedico = value; }
		public int MedCod { get => _medCod; set => _medCod = value; }
		public string NombreMedico { get => _nombreMedico; set => _nombreMedico = value; }
		public string MedCol { get => _medCol; set => _medCol = value; }
		public int IdEspecialidadMedico { get => _idEspecialidadMedico; set => _idEspecialidadMedico = value; }
		public int IdEntidadMed { get => _idEntidadMed; set => _idEntidadMed = value; }
		public string MedEspecialidad { get => _medEspecialidad; set => _medEspecialidad = value; }
		public string PaternoMed { get => _paternoMed; set => _paternoMed = value; }
		public string MaternoMed { get => _maternoMed; set => _maternoMed = value; }
		public string Consultorio { get => _consultorio; set => _consultorio = value; }
		public DateTime FechaInicio { get => _fechaInicio; set => _fechaInicio = value; }
		public DateTime FechaFin { get => _fechaFin; set => _fechaFin = value; }
		public string HoraInicio { get => _horaInicio; set => _horaInicio = value; }
		public string HoraFin { get => _horaFin; set => _horaFin = value; }
		public DateTime Fecharegistro { get => _fecharegistro; set => _fecharegistro = value; }
		public string Nombre { get => _nombre; set => _nombre = value; }
        public string HoraInicialMedico { get => _horaInicialMedico; set => _horaInicialMedico = value; }
        public string HoraFinalMedico { get => _horaFinalMedico; set => _horaFinalMedico = value; }
    }
}
