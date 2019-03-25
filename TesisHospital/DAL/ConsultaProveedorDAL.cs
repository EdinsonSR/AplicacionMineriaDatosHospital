using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using EL;

namespace DAL
{
    public class ConsultaProveedorDAL
    {
        public LaboratorioProovedor consultaPorRuc(string ruc)
        {
            SqlConnection _conexion = new SqlConnection(Conexion.cadenaConexion);
            SqlCommand _comando = new SqlCommand("PA_Proveedor", _conexion) { CommandType = CommandType.StoredProcedure };
            _comando.Parameters.AddWithValue("@RUC", SqlDbType.VarChar).Value = ruc;
            _comando.Parameters.AddWithValue("@tipo", SqlDbType.TinyInt).Value = 1;
            LaboratorioProovedor oLaboratorioProovedor = null;
            try
            {
                if (_conexion.State == ConnectionState.Closed)
                {
                    _conexion.Open();
                }
                SqlDataReader dr = _comando.ExecuteReader();
                if (dr.Read())
                {
                    oLaboratorioProovedor = new LaboratorioProovedor();
                    oLaboratorioProovedor.DescripcionLabProov = dr["descripcionLabProov"].ToString();
                    oLaboratorioProovedor.DireccionLabProov = dr["direccionLabProov"].ToString();
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
            return oLaboratorioProovedor;

        }

        public List<LaboratorioProovedor> listarPorRuc (String filtro, int opcion)
        {
            string consulta = string.Empty;
            if (opcion == 1)
            {
                consulta = string.Format(@"select RUC, descripcionLabProov, telefonoLabProov, direccionLabProov from Proovedores where RUC = '{0}'", filtro);
            }
            else if(opcion == 2)
            {
                consulta = string.Format(@"select RUC, descripcionLabProov, telefonoLabProov, direccionLabProov from Proovedores where descripcionLabProov like '%{0}%'", filtro);
            }

            SqlConnection _conexion = new SqlConnection(Conexion.cadenaConexion);
            SqlCommand _comando = new SqlCommand(consulta, _conexion);
            List<LaboratorioProovedor> lista = new List<LaboratorioProovedor>();
            LaboratorioProovedor oLaboratorioProovedor = null;
            try
            {
                if (_conexion.State == ConnectionState.Closed)
                {
                    _conexion.Open();
                }
                SqlDataReader dr = _comando.ExecuteReader();
                while (dr.Read())
                {
                    oLaboratorioProovedor = new LaboratorioProovedor();
                    oLaboratorioProovedor.Ruc = dr["RUC"].ToString();
                    oLaboratorioProovedor.DescripcionLabProov = dr["descripcionLabProov"].ToString();
                    oLaboratorioProovedor.TelefonoProv = dr["telefonoLabProov"].ToString();
                    oLaboratorioProovedor.DireccionLabProov = dr["direccionLabProov"].ToString();
                    lista.Add(oLaboratorioProovedor);
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
