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
    public partial class MantenedorProducto : Form
    {
        public MantenedorProducto()
        {
            InitializeComponent();
            listarProducto();
            grupBoxDatos.Enabled = false;
            txtidProducto.Enabled = false;
        }
        public void listarProducto()
        {
            dgvProducto.DataSource = logProducto.Instancia.ListarProducto();
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
                entProducto p = new entProducto();
                p.nombreProducto = txtNombreProducto.Text.Trim();
                p.presentacion = txtPresentacion.Text.Trim();
                p.pesoKg = decimal.Parse(txtPesoKg.Text.Trim());
                p.precioUnitario = decimal.Parse(txtPrecioUnitario.Text.Trim());
                p.fecRegProducto = dtPickerRegProducto.Value;
                p.estProducto = cbkEstadoProducto.Checked;
                logProducto.Instancia.InsertaProducto(p);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grupBoxDatos.Enabled = false;
            listarProducto();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void LimpiarVariables()
        {
            txtidProducto.Text = "";
            txtNombreProducto.Text = "";
            txtPresentacion.Text = "";
            txtPesoKg.Text = "";
            txtPrecioUnitario.Text = "";
        }

        private void dgvProducto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvProducto.Rows[e.RowIndex];
            txtidProducto.Text = filaActual.Cells[0].Value.ToString();
            txtNombreProducto.Text = filaActual.Cells[1].Value.ToString();
            txtPresentacion.Text = filaActual.Cells[2].Value.ToString();
            txtPesoKg.Text = filaActual.Cells[3].Value.ToString();
            txtPrecioUnitario.Text = filaActual.Cells[4].Value.ToString();
            dtPickerRegProducto.Text = filaActual.Cells[5].Value.ToString();
            cbkEstadoProducto.Checked = Convert.ToBoolean(filaActual.Cells[6].Value);
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
                entProducto p = new entProducto();
                p.idProducto = int.Parse(txtidProducto.Text.Trim());
                p.nombreProducto = txtNombreProducto.Text.Trim();
                p.presentacion = txtPresentacion.Text.Trim();
                p.pesoKg = decimal.Parse(txtPesoKg.Text.Trim());
                p.precioUnitario = decimal.Parse(txtPrecioUnitario.Text.Trim());
                p.fecRegProducto = dtPickerRegProducto.Value;
                p.estProducto = cbkEstadoProducto.Checked;
                logProducto.Instancia.EditaProducto(p);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grupBoxDatos.Enabled = false;
            listarProducto();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            grupBoxDatos.Enabled = false;
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entProducto p = new entProducto();
                p.idProducto = int.Parse(txtidProducto.Text.Trim());
                cbkEstadoProducto.Checked = false;
                logProducto.Instancia.DeshabilitarProducto(p);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grupBoxDatos.Enabled = false;
            listarProducto();
        }
    }
}
