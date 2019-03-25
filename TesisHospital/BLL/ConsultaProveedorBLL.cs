using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EL;


namespace BLL
{
    public class ConsultaProveedorBLL
    {
        #region Patron Singleton
        private static ConsultaProveedorBLL _instancia = null;

        public ConsultaProveedorBLL()
        {
        }

        public static ConsultaProveedorBLL Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new ConsultaProveedorBLL();
                }
                return _instancia;
            }
        }
        #endregion
        private static ConsultaProveedorDAL oConsultaProveedorDAL = new ConsultaProveedorDAL();

        public LaboratorioProovedor consultaPorRuc(string ruc)
        {
            try
            {
                return oConsultaProveedorDAL.consultaPorRuc(ruc);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<LaboratorioProovedor> listarPorRuc(string filtro, int opcion)
        {
            return oConsultaProveedorDAL.listarPorRuc(filtro, opcion);
        }
    }
}
