using System.Collections.Generic;
using CapaEntidad;
using CapaAccesoDatos;

namespace CapaLogicaNegocio
{
    public class logRequerimientoCompra
    {
        #region singleton
        private static readonly logRequerimientoCompra _instancia = new logRequerimientoCompra();
        public static logRequerimientoCompra Instancia
        {
            get { return logRequerimientoCompra._instancia; }
        }
        #endregion singleton

        #region metodos
        public List<entRequerimientoCompra> ListarRequerimientoCompra()
        {
            return datRequerimientoCompra.Instancia.ListarRequerimientoCompra();
        }

        public void InsertaRequerimientoCompra(entRequerimientoCompra Req)
        {
            datRequerimientoCompra.Instancia.InsertarRequerimientoCompra(Req);
        }

        public void EditaRequerimientoCompra(entRequerimientoCompra Req)
        {
            datRequerimientoCompra.Instancia.EditarRequerimientoCompra(Req);
        }

        public void DeshabilitarRequerimientoCompra(entRequerimientoCompra Req)
        {
            datRequerimientoCompra.Instancia.DeshabilitarRequerimientoCompra(Req);
        }
        #endregion metodos
    }
}
