using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
	public class Cita
	{
		private int _idCita;
		private DateTime _fechaCita;
        private int _atendidaCit;
        private string horaCita;
        private string medicoCita;
        private string especialidadCita;
        private string nombrePaciente;

        /**/


        public int IdCita { get => _idCita; set => _idCita = value; }
		public DateTime FechaCita { get => _fechaCita; set => _fechaCita = value; }
        public int AtendidaCit { get => _atendidaCit; set => _atendidaCit = value; }
        public string HoraCita { get => horaCita; set => horaCita = value; }
        public string MedicoCita { get => medicoCita; set => medicoCita = value; }
        public string EspecialidadCita { get => especialidadCita; set => especialidadCita = value; }
        public string NombrePaciente { get => nombrePaciente; set => nombrePaciente = value; }
    }
}
