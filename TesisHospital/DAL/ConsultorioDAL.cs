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
	public class ConsultorioDAL
	{
		public Boolean InsertarConsultorio(Consultorio oConsultorio)
		{
			SqlConnection _conexion = new SqlConnection(Conexion.cadenaConexion);
			SqlCommand _comando = new SqlCommand("PA_Consultorio", _conexion) { CommandType = CommandType.StoredProcedure };
			_comando.Parameters.AddWithValue("@idConsultorio", SqlDbType.Int).Value = oConsultorio.IdConsultorio;
			_comando.Parameters.AddWithValue("@nombreConsultorio", SqlDbType.VarChar).Value = oConsultorio.NombreConsultorio;
			_comando.Parameters.AddWithValue("@nombreAreasEspecialidades", SqlDbType.VarChar).Value = oConsultorio.NombreAreasEspecialidades;
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

		public List<Consultorio> listadoConsultorio()
		{
			SqlConnection _conexion = new SqlConnection(Conexion.cadenaConexion);
			SqlCommand _comando = new SqlCommand("PA_Consultorio", _conexion) { CommandType = CommandType.StoredProcedure };
			_comando.Parameters.AddWithValue("tipo", SqlDbType.TinyInt).Value = 2;
			Consultorio oConsultorio = null;
			List<Consultorio> lista = new List<Consultorio>();
			try
			{
				if (_conexion.State == ConnectionState.Closed)
				{
					_conexion.Open();
				}
				SqlDataReader dr = _comando.ExecuteReader();
				while (dr.Read())
				{
					oConsultorio = new Consultorio();
					oConsultorio.NombreConsultorio = dr["nombreConsultorio"].ToString();
					oConsultorio.NombreAreasEspecialidades = dr["nombreAreasEspecialidades"].ToString();
					lista.Add(oConsultorio);
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
