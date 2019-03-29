using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EL;
namespace BLL
{
    class PatronesBLL
    {
        #region Patron Singleton
        private static PatronesBLL _instancia = null;

        public PatronesBLL()
        {
        }

        public static PatronesBLL Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new PatronesBLL();
                }
                return _instancia;
            }
        }
        #endregion
        private static patronesDAL opatronesDAL = new patronesDAL();
        public List<Cita> InsertarGraficoPatron()
        {
            try
            {
                List<Cita> lista = opatronesDAL.InsertarGraficoPatron();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
