using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EL;
using TesisHospital;

namespace BLL
{
    public class MedicamentosBLL
    {
        #region Patron Singleton
        private static MedicamentosBLL _instancia = null;

        public MedicamentosBLL()
        {
        }

        public static MedicamentosBLL Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new MedicamentosBLL();
                }
                return _instancia;
            }
        }
        #endregion
        private static MedicamentosDAL oMedicamentosDAL = new MedicamentosDAL();

        public List<ListaMedicamentos> listarNombreMedicamento()
        {
            try
            {
                List<ListaMedicamentos> lista = oMedicamentosDAL.listarNombreMedicamento();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<MedicamentosAlmacen> listarMedicamentosPorNombre(string nombreMedicamento, string concentMedicamento)
        {
            try
            {
                List<MedicamentosAlmacen> lista = oMedicamentosDAL.listarMedicamentosPorNombre(nombreMedicamento, concentMedicamento);
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Boolean InsertarMedicamentoDeGuia(MedicamentosAlmacen oMedicamentosAlmacen)
        {
            if (oMedicamentosDAL == null)
            {
                return false;
            }
            try
            {
                Boolean exito = oMedicamentosDAL.InsertarMedicamentoDeGuia(oMedicamentosAlmacen);
                return exito;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Boolean InsertarMedicamentoLista(ListaMedicamentos oListaMedicamentos)
        {
            if (oMedicamentosDAL == null)
            {
                return false;
            }
            try
            {
                Boolean exito = oMedicamentosDAL.InsertarMedicamentoLista(oListaMedicamentos);
                return exito;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
