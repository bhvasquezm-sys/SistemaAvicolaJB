using CapaEntidad;
using CapaLogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentación
{
    public partial class MantenedorInsumoProducto : Form
    {
        public MantenedorInsumoProducto()
        {
            InitializeComponent();
            listarInsumoProducto();
            grupBoxDatos.Enabled = false;
            txtidInsumo.Enabled = false;
        }
        public void listarInsumoProducto()
        {
            dgvInsumoProducto.DataSource = logInsumoProducto.Instancia.ListarInsumoProducto();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            grupBoxDatos.Enabled = true;
            btnAgregar.Visible = true;
            LimpiarVariables();
            btnModificar.Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entInsumoProducto i = new entInsumoProducto();
                i.nombreInsumo = txtNombreInsumo.Text.Trim();
                i.tipoMaterial = txtTipoMaterial.Text.Trim();
                i.unidadMedida = txtUnidadMedida.Text.Trim();
                i.stockActual = decimal.Parse(txtStockActual.Text.Trim());
                i.fecRegInsumo = dtPickerRegInsumo.Value;
                i.estInsumo = cbkEstadoInsumo.Checked;
                logInsumoProducto.Instancia.InsertaInsumoProducto(i);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grupBoxDatos.Enabled = false;
            listarInsumoProducto();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void LimpiarVariables()
        {
            txtidInsumo.Text = "";
            txtNombreInsumo.Text = "";
            txtTipoMaterial.Text = "";
            txtUnidadMedida.Text = "";
            txtStockActual.Text = "";
        }

        private void dgvInsumoProducto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvInsumoProducto.Rows[e.RowIndex];
            txtidInsumo.Text = filaActual.Cells[0].Value.ToString();
            txtNombreInsumo.Text = filaActual.Cells[1].Value.ToString();
            txtTipoMaterial.Text = filaActual.Cells[2].Value.ToString();
            txtUnidadMedida.Text = filaActual.Cells[3].Value.ToString();
            txtStockActual.Text = filaActual.Cells[4].Value.ToString();
            dtPickerRegInsumo.Text = filaActual.Cells[5].Value.ToString();
            cbkEstadoInsumo.Checked = Convert.ToBoolean(filaActual.Cells[6].Value);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            grupBoxDatos.Enabled = true;
            btnModificar.Visible = true;
            btnAgregar.Visible = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entInsumoProducto i = new entInsumoProducto();
                i.idInsumo = int.Parse(txtidInsumo.Text.Trim());
                i.nombreInsumo = txtNombreInsumo.Text.Trim();
                i.tipoMaterial = txtTipoMaterial.Text.Trim();
                i.unidadMedida = txtUnidadMedida.Text.Trim();
                i.stockActual = decimal.Parse(txtStockActual.Text.Trim());
                i.fecRegInsumo = dtPickerRegInsumo.Value;
                i.estInsumo = cbkEstadoInsumo.Checked;
                logInsumoProducto.Instancia.EditaInsumoProducto(i);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grupBoxDatos.Enabled = false;
            listarInsumoProducto();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            grupBoxDatos.Enabled = false;
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entInsumoProducto i = new entInsumoProducto();
                i.idInsumo = int.Parse(txtidInsumo.Text.Trim());
                cbkEstadoInsumo.Checked = false;
                logInsumoProducto.Instancia.DeshabilitarInsumoProducto(i);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grupBoxDatos.Enabled = false;
            listarInsumoProducto();
        }
    }
}
