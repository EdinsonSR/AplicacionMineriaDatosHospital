using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EL;
using TesisHospital;

namespace DAL
{
    public class MedicamentosDAL
    {
        public List<ListaMedicamentos> listarNombreMedicamento()
        {
            SqlConnection _conexion = new SqlConnection(Conexion.cadenaConexion);
            SqlCommand _comando = new SqlCommand("PA_Medicamentos", _conexion) { CommandType = System.Data.CommandType.StoredProcedure };
            _comando.Parameters.AddWithValue("@tipo", SqlDbType.TinyInt).Value = 1;
            ListaMedicamentos oListaMedicamento = null;
            List<ListaMedicamentos> lista = new List<ListaMedicamentos>();
            try
            {
                if (_conexion.State == ConnectionState.Closed)
                {
                    _conexion.Open();
                }
                SqlDataReader dr = _comando.ExecuteReader();
                while (dr.Read())
                {
                    oListaMedicamento = new ListaMedicamentos();
                    oListaMedicamento.NombreMedicamento = dr["nombreMedicamento"].ToString();
                    oListaMedicamento.Concent = dr["concent"].ToString();
                    lista.Add(oListaMedicamento);
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

        public List<MedicamentosAlmacen> listarMedicamentosPorNombre (string nombreMedicamento, string concentMedicamento)
        {
            SqlConnection _conexion = new SqlConnection(Conexion.cadenaConexion);
            SqlCommand _comando = new SqlCommand("PA_Medicamentos", _conexion) { CommandType = System.Data.CommandType.StoredProcedure };
            _comando.Parameters.AddWithValue("@nombreMedicamento", SqlDbType.VarChar).Value = nombreMedicamento;
            _comando.Parameters.AddWithValue("@concent", SqlDbType.VarChar).Value = concentMedicamento;
            _comando.Parameters.AddWithValue("@tipo", SqlDbType.TinyInt).Value = 2;
            MedicamentosAlmacen oMedicamentosAlmacen = null;
            List<MedicamentosAlmacen> lista = new List<MedicamentosAlmacen>();
            try
            {
                if (_conexion.State == ConnectionState.Closed)
                {
                    _conexion.Open();
                }
                SqlDataReader dr = _comando.ExecuteReader();
                while (dr.Read())
                {
                    oMedicamentosAlmacen = new MedicamentosAlmacen();
                    oMedicamentosAlmacen.DescripcionMeds = dr["descripcionMeds"].ToString();
                    oMedicamentosAlmacen.FechaMeds = Convert.ToDateTime( dr["fechaMeds"].ToString());
                    oMedicamentosAlmacen.FechaVencimientoMeds = Convert.ToDateTime( dr["fechaVencimientoMeds"].ToString());
                    oMedicamentosAlmacen.StockMeds = Convert.ToInt32(dr["stockMeds"].ToString());
                    oMedicamentosAlmacen.ConcentMedicamentoAlmacen = dr["concentMedAlmacen"].ToString();
                    lista.Add(oMedicamentosAlmacen);
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

        public Boolean InsertarMedicamentoDeGuia(MedicamentosAlmacen oMedicamentosAlmacen)
        {
            SqlConnection _conexion = new SqlConnection(Conexion.cadenaConexion);
            SqlCommand _comando = new SqlCommand("PA_Medicamentos", _conexion) { CommandType = CommandType.StoredProcedure };
            _comando.Parameters.AddWithValue("@idMedicamentos", SqlDbType.Int).Value = oMedicamentosAlmacen.IdMedicamentos;
            _comando.Parameters.AddWithValue("@fechaMeds", SqlDbType.DateTime).Value = oMedicamentosAlmacen.FechaMeds;
            _comando.Parameters.AddWithValue("@fechaVencimientoMeds", SqlDbType.DateTime).Value = oMedicamentosAlmacen.FechaVencimientoMeds;
            _comando.Parameters.AddWithValue("@descripcionMeds", SqlDbType.VarChar).Value = oMedicamentosAlmacen.DescripcionMeds;
            _comando.Parameters.AddWithValue("@stockMeds", SqlDbType.Int).Value = oMedicamentosAlmacen.StockMeds;
            _comando.Parameters.AddWithValue("@concentMedAlmacen", SqlDbType.VarChar).Value = oMedicamentosAlmacen.ConcentMedicamentoAlmacen;
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

        public Boolean InsertarMedicamentoLista (ListaMedicamentos oListaMedicamentos)
        {
            SqlConnection _conexion = new SqlConnection(Conexion.cadenaConexion);
            SqlCommand _comando = new SqlCommand("PA_Medicamentos", _conexion) { CommandType = CommandType.StoredProcedure };
            _comando.Parameters.AddWithValue("@idListaMedicamentos", SqlDbType.Int).Value = oListaMedicamentos.IdListaMedicamentos;
            _comando.Parameters.AddWithValue("@nombreMedicamento", SqlDbType.DateTime).Value = oListaMedicamentos.NombreMedicamento;
            _comando.Parameters.AddWithValue("@concent", SqlDbType.DateTime).Value = oListaMedicamentos.Concent;
            _comando.Parameters.AddWithValue("@tipo", SqlDbType.TinyInt).Value = 4;
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
