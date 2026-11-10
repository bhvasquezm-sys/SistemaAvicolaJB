using System;

namespace CapaEntidad
{
    public class entRequerimientoCompra
    {
        public int idRequerimiento { get; set; }
        public string insumoSolicitado { get; set; }
        public decimal cantidadSolicitada { get; set; }
        public string prioridad { get; set; }
        public DateTime fecRegRequerimiento { get; set; }
        public Boolean estRequerimiento { get; set; }
    }
}
