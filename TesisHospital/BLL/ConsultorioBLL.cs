using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EL;
using DAL;

namespace BLL
{
	public class ConsultorioBLL
	{
		#region Patron Singleton
		private static ConsultorioBLL _instancia = null;

		public ConsultorioBLL()
		{
		}

		public static ConsultorioBLL Instancia
		{
			get
			{
				if (_instancia == null)
				{
					_instancia = new ConsultorioBLL();
				}
				return _instancia;
			}
		}
		#endregion
		private static ConsultorioDAL oConsultorioDAL = new ConsultorioDAL();

		public Boolean InsertarConsultorio(Consultorio oConsultorio)
		{
			if (oConsultorioDAL == null)
			{
				return false;
			}
			try
			{
				Boolean exito = oConsultorioDAL.InsertarConsultorio(oConsultorio);
				return exito;
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		public List<Consultorio> listadoConsultorio()
		{
			try
			{
				List<Consultorio> lista = oConsultorioDAL.listadoConsultorio();
				return lista;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

	}
}
