using System;

namespace CapaEntidad
{
    public class entCliente
    {
        public int idCliente { get; set; }
        public string rucDniCliente { get; set; }
        public string razonSocial { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public DateTime fecRegCliente { get; set; }
        public Boolean estCliente { get; set; }
    }
}