using System.Collections.Generic;
using CapaEntidad;
using CapaAccesoDatos;

namespace CapaLogicaNegocio
{
    public class logProducto
    {
        #region singleton
        private static readonly logProducto _instancia = new logProducto();
        public static logProducto Instancia
        {
            get { return logProducto._instancia; }
        }
        #endregion singleton

        #region metodos
        public List<entProducto> ListarProducto()
        {
            return datProducto.Instancia.ListarProducto();
        }

        public void InsertaProducto(entProducto Pro)
        {
            datProducto.Instancia.InsertarProducto(Pro);
        }

        public void EditaProducto(entProducto Pro)
        {
            datProducto.Instancia.EditarProducto(Pro);
        }

        public void DeshabilitarProducto(entProducto Pro)
        {
            datProducto.Instancia.DeshabilitarProducto(Pro);
        }
        #endregion metodos
    }
}