using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EL;

namespace BLL
{
	public class AreasEspecialidadesBLL
	{
		#region Patron Singleton
		private static AreasEspecialidadesBLL _instancia = null;

		public AreasEspecialidadesBLL()
		{
		}

		public static AreasEspecialidadesBLL Instancia
		{
			get
			{
				if (_instancia == null)
				{
					_instancia = new AreasEspecialidadesBLL();
				}
				return _instancia;
			}
		}
		#endregion
		private static AreasEspecialidadesDAL oAreasEspecialidadDAL = new AreasEspecialidadesDAL();


		public Boolean InsertarAreas(AreasEspecialidades oAreasEspecialidad)
		{
			if (oAreasEspecialidadDAL == null)
			{
				return false;
			}
			try
			{
				Boolean exito = oAreasEspecialidadDAL.InsertarAreas(oAreasEspecialidad);
				return exito;
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		public List<AreasEspecialidades> ListarNombreArea()
		{
			try
			{
				List<AreasEspecialidades> lista = oAreasEspecialidadDAL.ListarNombreArea();
				return lista;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
