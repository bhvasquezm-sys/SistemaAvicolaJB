using System.Collections.Generic;
using CapaEntidad;
using CapaAccesoDatos;

namespace CapaLogicaNegocio
{
    public class logCliente
    {
        #region singleton
        private static readonly logCliente _instancia = new logCliente();
        public static logCliente Instancia
        {
            get { return logCliente._instancia; }
        }
        #endregion singleton

        #region metodos
        public List<entCliente> ListarCliente()
        {
            return datCliente.Instancia.ListarCliente();
        }

        public void InsertaCliente(entCliente Cli)
        {
            datCliente.Instancia.InsertarCliente(Cli);
        }

        public void EditaCliente(entCliente Cli)
        {
            datCliente.Instancia.EditarCliente(Cli);
        }

        public void DeshabilitarCliente(entCliente Cli)
        {
            datCliente.Instancia.DeshabilitarCliente(Cli);
        }
        #endregion metodos
    }
}