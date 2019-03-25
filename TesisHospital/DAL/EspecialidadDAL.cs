using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EL;

namespace DAL
{
	public class EspecialidadDAL
	{
		public Boolean InsertarEspecialidad (Especialidad oEspecialidad)
		{
			SqlConnection _conexion = new SqlConnection(Conexion.cadenaConexion);
			SqlCommand _comando = new SqlCommand("PA_Especialidad", _conexion) { CommandType = CommandType.StoredProcedure };
			_comando.Parameters.AddWithValue("@idEspecialidad", SqlDbType.Int).Value = oEspecialidad.IdEspecialidad;
			_comando.Parameters.AddWithValue("@codEspecialidad", SqlDbType.VarChar).Value = oEspecialidad.CodEspecialidad;
			_comando.Parameters.AddWithValue("@nombreEsp", SqlDbType.VarChar).Value = oEspecialidad.NombreEsp;
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

		public List<Especialidad> listadoEspecialidad ()
		{
			SqlConnection _conexion = new SqlConnection(Conexion.cadenaConexion);
			SqlCommand _comando = new SqlCommand("PA_Especialidad", _conexion) { CommandType = CommandType.StoredProcedure };
			_comando.Parameters.AddWithValue("tipo", SqlDbType.TinyInt).Value = 2;
			Especialidad oEspecialidad = null;
			List<Especialidad> lista = new List<Especialidad>();
			try
			{
				if (_conexion.State == ConnectionState.Closed)
				{
					_conexion.Open();
				}
				SqlDataReader dr = _comando.ExecuteReader();
				while (dr.Read())
				{
					oEspecialidad = new Especialidad();
					oEspecialidad.IdEspecialidad =Convert.ToInt32(dr["idEspecialidad"]);
					oEspecialidad.NombreEsp = dr["nombreEsp"].ToString();
					oEspecialidad.CodEspecialidad = dr["codEspecialidad"].ToString();
					lista.Add(oEspecialidad);
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

		public List<Especialidad> ListarNombreEspecialidad()
		{
			SqlConnection _conexion = new SqlConnection(Conexion.cadenaConexion);
			SqlCommand _comando = new SqlCommand("PA_Especialidad", _conexion) { CommandType = CommandType.StoredProcedure };
			_comando.Parameters.AddWithValue("tipo", SqlDbType.TinyInt).Value = 3;
			Especialidad oEspecialidad = null;
			List<Especialidad> lista = new List<Especialidad>();
			try
			{
				if (_conexion.State == ConnectionState.Closed)
				{
					_conexion.Open();
				}
				SqlDataReader dr = _comando.ExecuteReader();
				while (dr.Read())
				{
					oEspecialidad = new Especialidad();
					oEspecialidad.NombreEsp = dr["nombreEsp"].ToString();
					lista.Add(oEspecialidad);
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
