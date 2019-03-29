using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EL;

namespace BLL
{
    public class CitasBLL
    {
        #region Patron Singleton
        private static CitasBLL _instancia = null;

        public CitasBLL()
        {
        }

        public static CitasBLL Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new CitasBLL();
                }
                return _instancia;
            }
        }
        #endregion
        private static CitaDAL oCitaDal = new CitaDAL();

        public List<Cita> listarCitasPorMedicoYFecha(DateTime fecha, string medico)
        {
            try
            {
                return oCitaDal.listarCitasPorMedicoYFecha(fecha, medico);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Boolean RegistrarCita(Cita oCita)
        {
            if (oCitaDal == null)
            {
                return false;
            }
            try
            {
                Boolean exito = oCitaDal.RegistrarCita(oCita);
                return exito;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Boolean eliminarCita(Cita oCita)
        {
            try
            {
                Boolean exito = oCitaDal.eliminarCita(oCita);
                return exito;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
