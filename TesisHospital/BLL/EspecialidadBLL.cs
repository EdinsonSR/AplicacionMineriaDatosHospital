using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EL;

namespace BLL
{
	public class EspecialidadBLL
	{
		#region Patron Singleton
		private static EspecialidadBLL _instancia = null;

		public EspecialidadBLL()
		{
		}

		public static EspecialidadBLL Instancia
		{
			get
			{
				if (_instancia == null)
				{
					_instancia = new EspecialidadBLL();
				}
				return _instancia;
			}
		}
		#endregion
		private static EspecialidadDAL oEspecialidadDAL = new EspecialidadDAL();

		public Boolean InsertarEspecialidad(Especialidad oEspecialidad)
		{
			if (oEspecialidadDAL == null)
			{
				return false;
			}
			try
			{
				Boolean exito = oEspecialidadDAL.InsertarEspecialidad(oEspecialidad);
				return exito;
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		public List<Especialidad> listadoEspecialidad()
		{
			try
			{
				List<Especialidad> lista = oEspecialidadDAL.listadoEspecialidad();
				return lista;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public List<Especialidad> ListarNombreEspecialidad()
		{
			try
			{
				List<Especialidad> lista = oEspecialidadDAL.ListarNombreEspecialidad();
				return lista;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
