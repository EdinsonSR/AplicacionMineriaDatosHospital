using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class GuiasMedicamentos
    {
        private int _idGuiaMedicamentos;
        private DateTime _fechaCompraGuia;
        private int _itemGuia;
        private string _descripcionMedicamentoGuia;
        private string _concentGuia;
        private DateTime _fechaFabricacionMedicamentoGuia;
        private DateTime _fechaVencimientoMedicamentoGuia;
        private double _precioUnitarioMedicamentoGuia;
        private double _precioTotalMedicamentoGuia;
        private string _nroGuia;
        private int _cantidadMedicamentoGuia;
        private string _rucProveedor;

        public int IdGuiaMedicamentos { get => _idGuiaMedicamentos; set => _idGuiaMedicamentos = value; }
        public DateTime FechaCompraGuia { get => _fechaCompraGuia; set => _fechaCompraGuia = value; }
        public int ItemGuia { get => _itemGuia; set => _itemGuia = value; }
        public string DescripcionMedicamentoGuia { get => _descripcionMedicamentoGuia; set => _descripcionMedicamentoGuia = value; }
        public string ConcentGuia { get => _concentGuia; set => _concentGuia = value; }
        public DateTime FechaFabricacionMedicamentoGuia { get => _fechaFabricacionMedicamentoGuia; set => _fechaFabricacionMedicamentoGuia = value; }
        public DateTime FechaVencimientoMedicamentoGuia { get => _fechaVencimientoMedicamentoGuia; set => _fechaVencimientoMedicamentoGuia = value; }
        public double PrecioUnitarioMedicamentoGuia { get => _precioUnitarioMedicamentoGuia; set => _precioUnitarioMedicamentoGuia = value; }
        public double PrecioTotalMedicamentoGuia { get => _precioTotalMedicamentoGuia; set => _precioTotalMedicamentoGuia = value; }
        public string NroGuia { get => _nroGuia; set => _nroGuia = value; }
        public int CantidadMedicamentoGuia { get => _cantidadMedicamentoGuia; set => _cantidadMedicamentoGuia = value; }
        public string RucProveedor { get => _rucProveedor; set => _rucProveedor = value; }
    }
}
