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
    public class patronesDAL
    {
        public List<Cita> InsertarGraficoPatron()
        { 
            SqlConnection _conexion = new SqlConnection(Conexion.cadenaConexion);
            SqlCommand _comando = new SqlCommand(string.Format(@"SELECT especialidadCita,
                                                                   COUNT(especialidadCita) AS cantidadCitas
                                                            FROM cita
                                                            GROUP BY especialidadCita"), _conexion);
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
                    oCita.EspecialidadCita =  dr["especialidadCita"].ToString();
                    oCita.CantidadCitas = Convert.ToInt32(dr["cantidadCitas"]);
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

    }
}
