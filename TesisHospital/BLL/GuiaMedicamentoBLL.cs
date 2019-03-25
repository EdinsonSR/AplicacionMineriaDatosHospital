using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EL;

namespace BLL
{
    public class GuiaMedicamentoBLL
    {
        #region Patron Singleton
        private static GuiaMedicamentoBLL _instancia = null;

        public GuiaMedicamentoBLL()
        {
        }

        public static GuiaMedicamentoBLL Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new GuiaMedicamentoBLL();
                }
                return _instancia;
            }
        }
        #endregion
        private static GuiaMedicamentosDAL oGuiaMedicamentosDAL = new GuiaMedicamentosDAL();

        public Boolean InsertarGuia(GuiasMedicamentos oGuiaMedicamentos)
        {
            if (oGuiaMedicamentosDAL == null)
            {
                return false;
            }
            try
            {
                Boolean exito = oGuiaMedicamentosDAL.InsertarGuia(oGuiaMedicamentos);
                return exito;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<GuiasMedicamentos> llenarTablaStock(string ruc, string nroDoc)
        {
            try
            {
                List<GuiasMedicamentos> lista = oGuiaMedicamentosDAL.llenarTablaStock(ruc, nroDoc);
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Boolean InsertarListaGuia(ListaGuias oListaGuias)
        {
            if (oGuiaMedicamentosDAL == null)
            {
                return false;
            }
            try
            {
                Boolean exito = oGuiaMedicamentosDAL.InsertarListaGuia(oListaGuias);
                return exito;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
