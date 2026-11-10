using System.Collections.Generic;
using CapaEntidad;
using CapaAccesoDatos;

namespace CapaLogicaNegocio
{
    public class logInsumoProducto
    {
        #region singleton
        private static readonly logInsumoProducto _instancia = new logInsumoProducto();
        public static logInsumoProducto Instancia
        {
            get { return logInsumoProducto._instancia; }
        }
        #endregion singleton

        #region metodos
        public List<entInsumoProducto> ListarInsumoProducto()
        {
            return datInsumoProducto.Instancia.ListarInsumoProducto();
        }

        public void InsertaInsumoProducto(entInsumoProducto Ins)
        {
            datInsumoProducto.Instancia.InsertarInsumoProducto(Ins);
        }

        public void EditaInsumoProducto(entInsumoProducto Ins)
        {
            datInsumoProducto.Instancia.EditarInsumoProducto(Ins);
        }

        public void DeshabilitarInsumoProducto(entInsumoProducto Ins)
        {
            datInsumoProducto.Instancia.DeshabilitarInsumoProducto(Ins);
        }
        #endregion metodos
    }
}
