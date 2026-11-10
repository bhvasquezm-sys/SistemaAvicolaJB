using System;

namespace CapaEntidad
{
    public class entProveedor
    {
        public int idProveedor { get; set; }
        public string rucProveedor { get; set; }
        public string razonSocial { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public DateTime fecRegProveedor { get; set; }
        public Boolean estProveedor { get; set; }
    }
}