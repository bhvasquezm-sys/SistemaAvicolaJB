using System;

namespace CapaEntidad
{
    public class entCondicionPago
    {
        public int idCondicionPago { get; set; }
        public string descripcion { get; set; }
        public int diasCredito { get; set; }
        public string modalidadEntrega { get; set; }
        public DateTime fecRegCondicion { get; set; }
        public Boolean estCondicionPago { get; set; }
    }
}