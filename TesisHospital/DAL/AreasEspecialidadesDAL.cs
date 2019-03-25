using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EL;

namespace DAL
{
	public class AreasEspecialidadesDAL
	{
		public Boolean InsertarAreas(AreasEspecialidades oAreasEspecialidad)
		{
			SqlConnection _conexion = new SqlConnection(Conexion.cadenaConexion);
			SqlCommand _comando = new SqlCommand("PA_AreaEspecialidad", _conexion) { CommandType = CommandType.StoredProcedure };
			_comando.Parameters.AddWithValue("@idAreaEspecialidades", SqlDbType.Int).Value = oAreasEspecialidad.IdAreaEspecialidades;
			_comando.Parameters.AddWithValue("@nombreAreasEspecialidades", SqlDbType.VarChar).Value = oAreasEspecialidad.NombreAreasEspecialidades;
			_comando.Parameters.AddWithValue("@tipo", SqlDbType.TinyInt).Value = 1;
			Boolean exito = false;
			try
			{
				if (_conexion.State == ConnectionState.Closed)
				{
					_conexion.Open();
				}
				_comando.ExecuteNonQuery();
				exito = true;
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				_conexion.Close();
			}
			return exito;
		}
		public List<AreasEspecialidades> ListarNombreArea()
		{
			SqlConnection _conexion = new SqlConnection(Conexion.cadenaConexion);
			SqlCommand _comando = new SqlCommand("PA_AreaEspecialidad", _conexion) { CommandType = CommandType.StoredProcedure };
			_comando.Parameters.AddWithValue("tipo", SqlDbType.TinyInt).Value = 2;
			AreasEspecialidades oAreaEspecialidad = null;
			List<AreasEspecialidades> lista = new List<AreasEspecialidades>();
			try
			{
				if (_conexion.State == ConnectionState.Closed)
				{
					_conexion.Open();
				}
				SqlDataReader dr = _comando.ExecuteReader();
				while (dr.Read())
				{
					oAreaEspecialidad = new AreasEspecialidades();
					oAreaEspecialidad.IdAreaEspecialidades = Convert.ToInt32(dr["idAreaEspecialidades"]);
					oAreaEspecialidad.NombreAreasEspecialidades = dr["nombreAreasEspecialidades"].ToString();
					lista.Add(oAreaEspecialidad);
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				_conexion.Close();
			}
			return lista;
		}
	}
}
