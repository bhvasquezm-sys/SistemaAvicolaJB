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
    public partial class MantenedorRequerimientoCompra : Form
    {
        public MantenedorRequerimientoCompra()
        {
            InitializeComponent();
            listarRequerimientoCompra();
            grupBoxDatos.Enabled = false;
            txtidRequerimiento.Enabled = false;
        }
        public void listarRequerimientoCompra()
        {
            dgvRequerimientoCompra.DataSource = logRequerimientoCompra.Instancia.ListarRequerimientoCompra();
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
                entRequerimientoCompra r = new entRequerimientoCompra();
                r.insumoSolicitado = txtInsumoSolicitado.Text.Trim();
                r.cantidadSolicitada = decimal.Parse(txtCantidadSolicitada.Text.Trim());
                r.prioridad = txtPrioridad.Text.Trim();
                r.fecRegRequerimiento = dtPickerRegRequerimiento.Value;
                r.estRequerimiento = cbkEstadoRequerimiento.Checked;
                logRequerimientoCompra.Instancia.InsertaRequerimientoCompra(r);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grupBoxDatos.Enabled = false;
            listarRequerimientoCompra();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void LimpiarVariables()
        {
            txtidRequerimiento.Text = "";
            txtInsumoSolicitado.Text = "";
            txtCantidadSolicitada.Text = "";
            txtPrioridad.Text = "";
        }

        private void dgvRequerimientoCompra_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvRequerimientoCompra.Rows[e.RowIndex];
            txtidRequerimiento.Text = filaActual.Cells[0].Value.ToString();
            txtInsumoSolicitado.Text = filaActual.Cells[1].Value.ToString();
            txtCantidadSolicitada.Text = filaActual.Cells[2].Value.ToString();
            txtPrioridad.Text = filaActual.Cells[3].Value.ToString();
            dtPickerRegRequerimiento.Text = filaActual.Cells[4].Value.ToString();
            cbkEstadoRequerimiento.Checked = Convert.ToBoolean(filaActual.Cells[5].Value);
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
                entRequerimientoCompra r = new entRequerimientoCompra();
                r.idRequerimiento = int.Parse(txtidRequerimiento.Text.Trim());
                r.insumoSolicitado = txtInsumoSolicitado.Text.Trim();
                r.cantidadSolicitada = decimal.Parse(txtCantidadSolicitada.Text.Trim());
                r.prioridad = txtPrioridad.Text.Trim();
                r.fecRegRequerimiento = dtPickerRegRequerimiento.Value;
                r.estRequerimiento = cbkEstadoRequerimiento.Checked;
                logRequerimientoCompra.Instancia.EditaRequerimientoCompra(r);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grupBoxDatos.Enabled = false;
            listarRequerimientoCompra();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            grupBoxDatos.Enabled = false;
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entRequerimientoCompra r = new entRequerimientoCompra();
                r.idRequerimiento = int.Parse(txtidRequerimiento.Text.Trim());
                cbkEstadoRequerimiento.Checked = false;
                logRequerimientoCompra.Instancia.DeshabilitarRequerimientoCompra(r);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grupBoxDatos.Enabled = false;
            listarRequerimientoCompra();
        }
    }
}
