using System;

namespace CapaEntidad
{
    public class entProducto
    {
        public int idProducto { get; set; }
        public string nombreProducto { get; set; }
        public string presentacion { get; set; }
        public decimal pesoKg { get; set; }
        public decimal precioUnitario { get; set; }
        public DateTime fecRegProducto { get; set; }
        public Boolean estProducto { get; set; }
    }
}