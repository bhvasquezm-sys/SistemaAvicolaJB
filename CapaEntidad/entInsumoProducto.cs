using System;

namespace CapaEntidad
{
    public class entInsumoProducto
    {
        public int idInsumo { get; set; }
        public string nombreInsumo { get; set; }
        public string tipoMaterial { get; set; }
        public string unidadMedida { get; set; }
        public decimal stockActual { get; set; }
        public DateTime fecRegInsumo { get; set; }
        public Boolean estInsumo { get; set; }
    }
}