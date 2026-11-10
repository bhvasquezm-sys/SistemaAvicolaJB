using CapaPresentación;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            MantenedorCliente frm = new MantenedorCliente();
            frm.ShowDialog();
        }

        private void btnCondicionPago_Click(object sender, EventArgs e)
        {
            MantenedorCondicionPago frm = new MantenedorCondicionPago();
            frm.ShowDialog();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            MantenedorProducto frm = new MantenedorProducto();
            frm.ShowDialog();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            MantenedorProveedor frm = new MantenedorProveedor();
            frm.ShowDialog();
        }

        private void btnInsumosProductos_Click(object sender, EventArgs e)
        {
            MantenedorInsumoProducto frm = new MantenedorInsumoProducto();
            frm.ShowDialog();
        }

        private void btnRequerimientoCompra_Click(object sender, EventArgs e)
        {
            MantenedorRequerimientoCompra frm = new MantenedorRequerimientoCompra();
            frm.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}