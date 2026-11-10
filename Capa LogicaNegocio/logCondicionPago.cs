using System.Collections.Generic;
using CapaEntidad;
using CapaAccesoDatos;

namespace CapaLogicaNegocio
{
    public class logCondicionPago
    {
        #region singleton
        private static readonly logCondicionPago _instancia = new logCondicionPago();
        public static logCondicionPago Instancia
        {
            get { return logCondicionPago._instancia; }
        }
        #endregion singleton

        #region metodos
        public List<entCondicionPago> ListarCondicionPago()
        {
            return datCondicionPago.Instancia.ListarCondicionPago();
        }

        public void InsertaCondicionPago(entCondicionPago Con)
        {
            datCondicionPago.Instancia.InsertarCondicionPago(Con);
        }

        public void EditaCondicionPago(entCondicionPago Con)
        {
            datCondicionPago.Instancia.EditarCondicionPago(Con);
        }

        public void DeshabilitarCondicionPago(entCondicionPago Con)
        {
            datCondicionPago.Instancia.DeshabilitarCondicionPago(Con);
        }
        #endregion metodos
    }
}