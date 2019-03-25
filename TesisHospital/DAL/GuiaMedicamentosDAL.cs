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
    public class GuiaMedicamentosDAL
    {
        public Boolean InsertarGuia(GuiasMedicamentos oGuiaMedicamentos)
        {
            SqlConnection _conexion = new SqlConnection(Conexion.cadenaConexion);
            SqlCommand _comando = new SqlCommand("PA_GuiaMedicamentos", _conexion) { CommandType = CommandType.StoredProcedure };
            _comando.Parameters.AddWithValue("@idGuiaMedicamentos", SqlDbType.Int).Value = oGuiaMedicamentos.IdGuiaMedicamentos;
            _comando.Parameters.AddWithValue("@fechaCompraGuia", SqlDbType.DateTime).Value = oGuiaMedicamentos.FechaCompraGuia;
            _comando.Parameters.AddWithValue("@itemGuia", SqlDbType.Int).Value = oGuiaMedicamentos.ItemGuia;
            _comando.Parameters.AddWithValue("@descripcionMedicamentoGuia", SqlDbType.VarChar).Value = oGuiaMedicamentos.DescripcionMedicamentoGuia;
            _comando.Parameters.AddWithValue("@concentGuia", SqlDbType.VarChar).Value = oGuiaMedicamentos.ConcentGuia;
            _comando.Parameters.AddWithValue("@fechaFabricacionMedicamentoGuia", SqlDbType.DateTime).Value = oGuiaMedicamentos.FechaFabricacionMedicamentoGuia;
            _comando.Parameters.AddWithValue("@fechaVencimientoMedicamentoGuia", SqlDbType.DateTime).Value = oGuiaMedicamentos.FechaVencimientoMedicamentoGuia;
            _comando.Parameters.AddWithValue("@precioUnitarioMedicamentoGuia", SqlDbType.Float).Value = oGuiaMedicamentos.PrecioUnitarioMedicamentoGuia;
            _comando.Parameters.AddWithValue("@precioTotalMedicamentoGuia", SqlDbType.Float).Value = oGuiaMedicamentos.PrecioTotalMedicamentoGuia;
            _comando.Parameters.AddWithValue("@nroGuia", SqlDbType.VarChar).Value = oGuiaMedicamentos.NroGuia;
            _comando.Parameters.AddWithValue("@cantidadMedicamentoGuia", SqlDbType.Int).Value = oGuiaMedicamentos.CantidadMedicamentoGuia;
            _comando.Parameters.AddWithValue("@rucProveedor", SqlDbType.VarChar).Value = oGuiaMedicamentos.RucProveedor;
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


        public List<GuiasMedicamentos> llenarTablaStock (string ruc, string nroDoc)
        {
            SqlConnection _conexion = new SqlConnection(Conexion.cadenaConexion);
            SqlCommand _comando = new SqlCommand("PA_GuiaMedicamentos", _conexion) { CommandType = CommandType.StoredProcedure };
            _comando.Parameters.AddWithValue("@rucProveedor", SqlDbType.VarChar).Value = ruc;
            _comando.Parameters.AddWithValue("@nroGuia", SqlDbType.VarChar).Value = nroDoc;
            _comando.Parameters.AddWithValue("@tipo", SqlDbType.TinyInt).Value = 2;
            List<GuiasMedicamentos> lista = new List<GuiasMedicamentos>();
            GuiasMedicamentos oGuiaMed = null;
            try
            {
                if (_conexion.State == ConnectionState.Closed)
                {
                    _conexion.Open();
                }
                SqlDataReader dr = _comando.ExecuteReader();
                while (dr.Read())
                {
                    oGuiaMed = new GuiasMedicamentos();
                    oGuiaMed.ItemGuia = Convert.ToInt32( dr["itemGuia"].ToString());
                    oGuiaMed.DescripcionMedicamentoGuia = dr["descripcionMedicamentoGuia"].ToString();
                    oGuiaMed.ConcentGuia = dr["concentGuia"].ToString();
                    oGuiaMed.FechaFabricacionMedicamentoGuia = Convert.ToDateTime( dr["fechaFabricacionMedicamentoGuia"].ToString());
                    oGuiaMed.FechaVencimientoMedicamentoGuia = Convert.ToDateTime( dr["fechaVencimientoMedicamentoGuia"].ToString());
                    oGuiaMed.CantidadMedicamentoGuia = Convert.ToInt32( dr["cantidadMedicamentoGuia"].ToString());
                    oGuiaMed.PrecioUnitarioMedicamentoGuia = Convert.ToDouble( dr["precioUnitarioMedicamentoGuia"].ToString());
                    oGuiaMed.PrecioTotalMedicamentoGuia = Convert.ToDouble( dr["precioTotalMedicamentoGuia"].ToString());
                    lista.Add(oGuiaMed);
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
        /*INSERTAR EN LISTA DE GUIAS*/
        public Boolean InsertarListaGuia(ListaGuias oListaGuias)
        {
            SqlConnection _conexion = new SqlConnection(Conexion.cadenaConexion);
            SqlCommand _comando = new SqlCommand("PA_GuiaMedicamentos", _conexion) { CommandType = CommandType.StoredProcedure };
            _comando.Parameters.AddWithValue("@idListaGuias", SqlDbType.Int).Value = oListaGuias.IdListaGuias;
            _comando.Parameters.AddWithValue("@rucProveedor", SqlDbType.VarChar).Value = oListaGuias.GuiaRuc;
            _comando.Parameters.AddWithValue("@nroGuia", SqlDbType.VarChar).Value = oListaGuias.GuiaNroDoc;
            _comando.Parameters.AddWithValue("@costoTotalGuia", SqlDbType.Float).Value = oListaGuias.CostoTotal;
            _comando.Parameters.AddWithValue("@fechaCompraGuia", SqlDbType.Date).Value = oListaGuias.Fecha;
            _comando.Parameters.AddWithValue("@fechaGuardado", SqlDbType.Date).Value = oListaGuias.FechaGuardado;
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
