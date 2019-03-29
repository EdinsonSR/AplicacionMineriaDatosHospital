using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EL;

namespace BLL
{
	public class MedicoBLL
	{
		#region Patron Singleton
		private static MedicoBLL _instancia = null;

		public MedicoBLL()
		{
		}

		public static MedicoBLL Instancia
		{
			get
			{
				if (_instancia == null)
				{
					_instancia = new MedicoBLL();
				}
				return _instancia;
			}
		}
		#endregion
		private static MedicoDAL oMedicoDAL = new MedicoDAL();

		public Boolean InsertarMedico(HorariosMedicos oMedico)
		{
			if (oMedicoDAL == null)
			{
				return false;
			}
			try
			{
				Boolean exito = oMedicoDAL.InsertarMedico(oMedico);
				return exito;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public List<HorariosMedicos> listaMedicos()
		{
			try
			{
				List<HorariosMedicos> lista = oMedicoDAL.listaMedicos();
				return lista;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public List<HorariosMedicos> listaMedicosPorCMP(string medcol)
		{
			try
			{
				List<HorariosMedicos> lista = oMedicoDAL.listaMedicosPorCMP(medcol);
				return lista;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public List<HorariosMedicos> ReportePorCMP(string medcol)
		{
			try
			{
				List<HorariosMedicos> lista = oMedicoDAL.ReportePorCMP(medcol);
				return lista;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public HorariosMedicos busquedaMedico(string cmp)
		{
			try
			{
				return oMedicoDAL.busquedaMedico(cmp);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

        public Boolean InsertarNuevoMedico(Medico oMedico)
        {
            if (oMedicoDAL == null)
            {
                return false;
            }
            try
            {
                Boolean exito = oMedicoDAL.InsertarNuevoMedico(oMedico);
                return exito;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Medico> ListarNombreMedicoPorEspecialidadYFecha(string especialidad, DateTime fechaCita)
        {
            try
            {
                return oMedicoDAL.ListarNombreMedicoPorEspecialidadYFecha(especialidad, fechaCita);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public HorariosMedicos busquedaHorariosMedicosCitas(DateTime fechaCita, string nombreMedico)
        {
            try
            {
                return oMedicoDAL.busquedaHorariosMedicosCitas(fechaCita, nombreMedico);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
