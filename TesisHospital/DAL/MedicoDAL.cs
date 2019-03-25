using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EL;

namespace DAL
{
	public class MedicoDAL
	{
		public Boolean InsertarMedico (HorariosMedicos oMedico)
		{
			SqlConnection _conexion = new SqlConnection(Conexion.cadenaConexion);
			SqlCommand _comando = new SqlCommand("PA_Medico", _conexion) { CommandType = CommandType.StoredProcedure };
			_comando.Parameters.AddWithValue("@idHorarioMedico", SqlDbType.Int).Value = oMedico.IdMedico;
			_comando.Parameters.AddWithValue("@medCol", SqlDbType.Int).Value = oMedico.MedCol;
			_comando.Parameters.AddWithValue("@medEspecialidad", SqlDbType.VarChar).Value = oMedico.MedEspecialidad;
			_comando.Parameters.AddWithValue("@NombresMed", SqlDbType.VarChar).Value = oMedico.NombreMedico;
			_comando.Parameters.AddWithValue("@PaternoMed", SqlDbType.VarChar).Value = oMedico.PaternoMed;
			_comando.Parameters.AddWithValue("@MaternoMed", SqlDbType.VarChar).Value = oMedico.MaternoMed;
			_comando.Parameters.AddWithValue("@consultorioMed", SqlDbType.VarChar).Value = oMedico.Consultorio;
			_comando.Parameters.AddWithValue("@fechaInicio", SqlDbType.VarChar).Value = oMedico.FechaInicio;
			_comando.Parameters.AddWithValue("@fechaFin", SqlDbType.VarChar).Value = oMedico.FechaFin;
			_comando.Parameters.AddWithValue("@horaInicio", SqlDbType.VarChar).Value = oMedico.HoraInicio;
			_comando.Parameters.AddWithValue("@horaFin", SqlDbType.VarChar).Value = oMedico.HoraFin;
			_comando.Parameters.AddWithValue("@fechaRegistro", SqlDbType.VarChar).Value = oMedico.Fecharegistro;
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

		public List<HorariosMedicos> listaMedicos()
		{
			SqlConnection _conexion = new SqlConnection(Conexion.cadenaConexion);
			SqlCommand _comando = new SqlCommand("PA_Medico", _conexion) { CommandType = CommandType.StoredProcedure };
			_comando.Parameters.AddWithValue("tipo", SqlDbType.TinyInt).Value = 2;
			HorariosMedicos oMedico = null;
			List<HorariosMedicos> lista = new List<HorariosMedicos>();
			try
			{
				if (_conexion.State == ConnectionState.Closed)
				{
					_conexion.Open();
				}
				SqlDataReader dr = _comando.ExecuteReader();
				while (dr.Read())
				{
					oMedico = new HorariosMedicos();
					oMedico.MedCol = dr["medCol"].ToString();
					oMedico.MedEspecialidad = dr["medEspecialidad"].ToString();
					oMedico.NombreMedico = dr["NombresMed"].ToString();
					oMedico.PaternoMed = dr["PaternoMed"].ToString();
					oMedico.MaternoMed = dr["MaternoMed"].ToString();
					oMedico.Consultorio = dr["consultorioMed"].ToString();
					oMedico.FechaInicio = dr["fechaInicio"].ToString();
					oMedico.FechaFin = dr["fechaFin"].ToString();
					oMedico.HoraInicio = dr["horaInicio"].ToString();
					oMedico.HoraFin = dr["horaFin"].ToString();
					lista.Add(oMedico);
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

		public List<HorariosMedicos> listaMedicosPorCMP (string medcol)
		{
			SqlConnection _conexion = new SqlConnection(Conexion.cadenaConexion);
			SqlCommand _comando = new SqlCommand("PA_Medico", _conexion) { CommandType = CommandType.StoredProcedure };
			_comando.Parameters.AddWithValue("@medCol", SqlDbType.VarChar).Value = medcol;
			_comando.Parameters.AddWithValue("@tipo", SqlDbType.TinyInt).Value = 3;
			HorariosMedicos oMedico = null;
			List<HorariosMedicos> lista = new List<HorariosMedicos>();
			try
			{
				if (_conexion.State == ConnectionState.Closed)
				{
					_conexion.Open();
				}
				SqlDataReader dr = _comando.ExecuteReader();
				while (dr.Read())
				{
					oMedico = new HorariosMedicos();
					oMedico.MedEspecialidad = dr["medEspecialidad"].ToString();
					oMedico.NombreMedico = dr["NombresMed"].ToString();
					oMedico.PaternoMed = dr["PaternoMed"].ToString();
					oMedico.MaternoMed = dr["MaternoMed"].ToString();
					oMedico.Consultorio = dr["consultorioMed"].ToString();
					oMedico.FechaInicio = dr["fechaInicio"].ToString();
					oMedico.FechaFin = dr["fechaFin"].ToString();
					oMedico.HoraInicio = dr["horaInicio"].ToString();
					oMedico.HoraFin = dr["horaFin"].ToString();
					lista.Add(oMedico);
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

		public List<HorariosMedicos> ReportePorCMP(string medcol)
		{
			SqlConnection _conexion = new SqlConnection(Conexion.cadenaConexion);
			SqlCommand _comando = new SqlCommand("PA_Medico", _conexion) { CommandType = CommandType.StoredProcedure };
			_comando.Parameters.AddWithValue("@medCol", SqlDbType.VarChar).Value = medcol;
			_comando.Parameters.AddWithValue("@tipo", SqlDbType.TinyInt).Value = 4;
			HorariosMedicos oMedico = null;
			List<HorariosMedicos> lista = new List<HorariosMedicos>();
			try
			{
				if (_conexion.State == ConnectionState.Closed)
				{
					_conexion.Open();
				}
				SqlDataReader dr = _comando.ExecuteReader();
				while (dr.Read())
				{
					oMedico = new HorariosMedicos();
					oMedico.MedEspecialidad = dr["medEspecialidad"].ToString();
					oMedico.Nombre = dr["Nombre"].ToString();
					oMedico.Consultorio = dr["consultorioMed"].ToString();
					oMedico.FechaInicio = dr["fechaInicio"].ToString();
					oMedico.FechaFin = dr["fechaFin"].ToString();
					oMedico.HoraInicio = dr["horaInicio"].ToString();
					oMedico.HoraFin = dr["horaFin"].ToString();
					lista.Add(oMedico);
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

		public HorariosMedicos busquedaMedico (string cmp)
		{
			SqlConnection _conexion = new SqlConnection(Conexion.cadenaConexion);
			SqlCommand _comando = new SqlCommand("PA_Medico", _conexion) { CommandType = CommandType.StoredProcedure };
			_comando.Parameters.AddWithValue("@medCol", SqlDbType.VarChar).Value = cmp;
			_comando.Parameters.AddWithValue("@tipo", SqlDbType.TinyInt).Value = 5;
			HorariosMedicos oMedico = null;
			try
			{
				if (_conexion.State == ConnectionState.Closed)
				{
					_conexion.Open();
				}
				SqlDataReader dr = _comando.ExecuteReader();
				if (dr.Read())
				{
					oMedico = new HorariosMedicos();
					oMedico.PaternoMed = dr["paternoMedico"].ToString();
					oMedico.MaternoMed = dr["maternoMedico"].ToString();
					oMedico.Nombre = dr["nombresMedico"].ToString();
					oMedico.MedEspecialidad = dr["Especialidad"].ToString();
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
			return oMedico;
		}

        public Boolean InsertarNuevoMedico (Medico oMedico)
        {
            SqlConnection _conexion = new SqlConnection(Conexion.cadenaConexion);
            SqlCommand _comando = new SqlCommand("PA_Medico", _conexion) { CommandType = CommandType.StoredProcedure };
            _comando.Parameters.AddWithValue("@idMedico", SqlDbType.Int).Value = oMedico.IdMedico;
            _comando.Parameters.AddWithValue("@medCol", SqlDbType.VarChar).Value = oMedico.CmpMedico;
            _comando.Parameters.AddWithValue("@DNIMedico", SqlDbType.VarChar).Value = oMedico.DniMedico;
            _comando.Parameters.AddWithValue("@PaternoMed", SqlDbType.VarChar).Value = oMedico.PaternoMedico;
            _comando.Parameters.AddWithValue("@MaternoMed", SqlDbType.VarChar).Value = oMedico.MaternoMedico;
            _comando.Parameters.AddWithValue("@NombresMed", SqlDbType.VarChar).Value = oMedico.NombresMedico;
            _comando.Parameters.AddWithValue("@telefonoMedico", SqlDbType.VarChar).Value = oMedico.TelefonoMedico;
            _comando.Parameters.AddWithValue("@celularMedico", SqlDbType.VarChar).Value = oMedico.CelularMedico;
            _comando.Parameters.AddWithValue("@direccionMedico", SqlDbType.VarChar).Value = oMedico.DireccionMedico;
            _comando.Parameters.AddWithValue("@medEspecialidad", SqlDbType.VarChar).Value = oMedico.Especialidad;
            _comando.Parameters.AddWithValue("@fechaRegistro", SqlDbType.Date).Value = oMedico.FechaRegistro;
            _comando.Parameters.AddWithValue("@tipo", SqlDbType.TinyInt).Value = 6;
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

        public List<Medico> ListarNombreMedicoPorEspecialidad(string especialidad)
        {
            SqlConnection _conexion = new SqlConnection(Conexion.cadenaConexion);
            SqlCommand _comando = new SqlCommand("PA_Medico", _conexion) { CommandType = CommandType.StoredProcedure };
            _comando.Parameters.AddWithValue("@medEspecialidad", SqlDbType.VarChar).Value = especialidad;
            _comando.Parameters.AddWithValue("tipo", SqlDbType.TinyInt).Value = 7;
            Medico oMedico = null;
            List<Medico> lista = new List<Medico>();
            try
            {
                if (_conexion.State == ConnectionState.Closed)
                {
                    _conexion.Open();
                }
                SqlDataReader dr = _comando.ExecuteReader();
                while (dr.Read())
                {
                    oMedico = new Medico();
                    oMedico.MedNam = dr["MedNam"].ToString();
                    lista.Add(oMedico);
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
