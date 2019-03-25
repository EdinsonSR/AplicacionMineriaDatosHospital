using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class ListaGuias
    {
        private int _idListaGuias;
        private string _guiaRuc;
        private string _guiaNroDoc;
        private double _costoTotal;
        private DateTime _fecha;
        private DateTime _fechaGuardado;

        public string GuiaRuc { get => _guiaRuc; set => _guiaRuc = value; }
        public string GuiaNroDoc { get => _guiaNroDoc; set => _guiaNroDoc = value; }
        public double CostoTotal { get => _costoTotal; set => _costoTotal = value; }
        public DateTime Fecha { get => _fecha; set => _fecha = value; }
        public DateTime FechaGuardado { get => _fechaGuardado; set => _fechaGuardado = value; }
        public int IdListaGuias { get => _idListaGuias; set => _idListaGuias = value; }
    }
}
