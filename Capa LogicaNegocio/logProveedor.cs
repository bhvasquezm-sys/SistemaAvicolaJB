using System.Collections.Generic;
using CapaEntidad;
using CapaAccesoDatos;

namespace CapaLogicaNegocio
{
    public class logProveedor
    {
        #region singleton
        private static readonly logProveedor _instancia = new logProveedor();
        public static logProveedor Instancia
        {
            get { return logProveedor._instancia; }
        }
        #endregion singleton

        #region metodos
        public List<entProveedor> ListarProveedor()
        {
            return datProveedor.Instancia.ListarProveedor();
        }

        public void InsertaProveedor(entProveedor Prv)
        {
            datProveedor.Instancia.InsertarProveedor(Prv);
        }

        public void EditaProveedor(entProveedor Prv)
        {
            datProveedor.Instancia.EditarProveedor(Prv);
        }

        public void DeshabilitarProveedor(entProveedor Prv)
        {
            datProveedor.Instancia.DeshabilitarProveedor(Prv);
        }
        #endregion metodos
    }
}
