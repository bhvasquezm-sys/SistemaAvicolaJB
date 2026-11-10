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
    public partial class MantenedorCondicionPago : Form
    {
        public MantenedorCondicionPago()
        {
            InitializeComponent();
            listarCondicionPago();
            grupBoxDatos.Enabled = false;
            txtidCondicionPago.Enabled = false;
        }
        public void listarCondicionPago()
        {
            dgvCondicionPago.DataSource = logCondicionPago.Instancia.ListarCondicionPago();
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
                entCondicionPago c = new entCondicionPago();
                c.descripcion = txtDescripcion.Text.Trim();
                c.diasCredito = int.Parse(txtDiasCredito.Text.Trim());
                c.modalidadEntrega = txtModalidadEntrega.Text.Trim();
                c.fecRegCondicion = dtPickerRegCondicion.Value;
                c.estCondicionPago = cbkEstadoCondicion.Checked;
                logCondicionPago.Instancia.InsertaCondicionPago(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grupBoxDatos.Enabled = false;
            listarCondicionPago();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void LimpiarVariables()
        {
            txtidCondicionPago.Text = "";
            txtDescripcion.Text = "";
            txtDiasCredito.Text = "";
            txtModalidadEntrega.Text = "";
        }

        private void dgvCondicionPago_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvCondicionPago.Rows[e.RowIndex];
            txtidCondicionPago.Text = filaActual.Cells[0].Value.ToString();
            txtDescripcion.Text = filaActual.Cells[1].Value.ToString();
            txtDiasCredito.Text = filaActual.Cells[2].Value.ToString();
            txtModalidadEntrega.Text = filaActual.Cells[3].Value.ToString();
            dtPickerRegCondicion.Text = filaActual.Cells[4].Value.ToString();
            cbkEstadoCondicion.Checked = Convert.ToBoolean(filaActual.Cells[5].Value);
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
                entCondicionPago c = new entCondicionPago();
                c.idCondicionPago = int.Parse(txtidCondicionPago.Text.Trim());
                c.descripcion = txtDescripcion.Text.Trim();
                c.diasCredito = int.Parse(txtDiasCredito.Text.Trim());
                c.modalidadEntrega = txtModalidadEntrega.Text.Trim();
                c.fecRegCondicion = dtPickerRegCondicion.Value;
                c.estCondicionPago = cbkEstadoCondicion.Checked;
                logCondicionPago.Instancia.EditaCondicionPago(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grupBoxDatos.Enabled = false;
            listarCondicionPago();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            grupBoxDatos.Enabled = false;
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entCondicionPago c = new entCondicionPago();
                c.idCondicionPago = int.Parse(txtidCondicionPago.Text.Trim());
                cbkEstadoCondicion.Checked = false;
                logCondicionPago.Instancia.DeshabilitarCondicionPago(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grupBoxDatos.Enabled = false;
            listarCondicionPago();
        }
    }
}
