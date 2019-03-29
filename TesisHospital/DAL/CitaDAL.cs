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
    public class CitaDAL
    {
        public List<Cita> listarCitasPorMedicoYFecha (DateTime fecha, string medico)
        {
            SqlConnection _conexion = new SqlConnection(Conexion.cadenaConexion);
            SqlCommand _comando = new SqlCommand("PA_CitasMedicas", _conexion) { CommandType = CommandType.StoredProcedure };
            _comando.Parameters.AddWithValue("@MedicoCita", SqlDbType.VarChar).Value = medico;
            _comando.Parameters.AddWithValue("@fechaCita", SqlDbType.Date).Value = fecha;
            _comando.Parameters.AddWithValue("tipo", SqlDbType.TinyInt).Value = 1;
            Cita oCita = null;
            List<Cita> lista = new List<Cita>();
            try
            {
                if (_conexion.State == ConnectionState.Closed)
                {
                    _conexion.Open();
                }
                SqlDataReader dr = _comando.ExecuteReader();
                while (dr.Read())
                {
                    oCita = new Cita();
                    oCita.HoraCita = dr["horaCita"].ToString();
                    oCita.NombrePaciente = dr["nombrePaciente"].ToString();
                    oCita.AtendidaCit = Convert.ToInt32(dr["atendidaCit"].ToString());

                    lista.Add(oCita);
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

        public Boolean RegistrarCita(Cita oCita)
        {
            SqlConnection _conexion = new SqlConnection(Conexion.cadenaConexion);
            SqlCommand _comando = new SqlCommand("PA_CitasMedicas", _conexion) { CommandType = CommandType.StoredProcedure };
            _comando.Parameters.AddWithValue("@idCita", SqlDbType.Int).Value = oCita.IdCita;
            _comando.Parameters.AddWithValue("@fechaCita", SqlDbType.Date).Value = oCita.FechaCita;
            _comando.Parameters.AddWithValue("@atendidaCit", SqlDbType.Int).Value = oCita.AtendidaCit;
            _comando.Parameters.AddWithValue("@horaCita", SqlDbType.VarChar).Value = oCita.HoraCita;
            _comando.Parameters.AddWithValue("@MedicoCita", SqlDbType.VarChar).Value = oCita.MedicoCita;
            _comando.Parameters.AddWithValue("@especialidadCita", SqlDbType.VarChar).Value = oCita.EspecialidadCita;
            _comando.Parameters.AddWithValue("@nombrePaciente", SqlDbType.VarChar).Value = oCita.NombrePaciente;
            _comando.Parameters.AddWithValue("@tipo", SqlDbType.TinyInt).Value = 2;
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


        public Boolean eliminarCita (Cita oCita)
        {
            SqlConnection _conexion = new SqlConnection(Conexion.cadenaConexion);
            SqlCommand _comando = new SqlCommand("PA_CitasMedicas", _conexion) { CommandType = CommandType.StoredProcedure };
            _comando.Parameters.AddWithValue("@nombrePaciente", SqlDbType.Int).Value = oCita.NombrePaciente;
            _comando.Parameters.AddWithValue("@horaCita", SqlDbType.Int).Value = oCita.HoraCita;
            _comando.Parameters.AddWithValue("@fechaCita", SqlDbType.Int).Value = oCita.FechaCita;
            _comando.Parameters.AddWithValue("@tipo", SqlDbType.TinyInt).Value = 3;
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
    }
}
