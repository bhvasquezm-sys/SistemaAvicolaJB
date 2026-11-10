using System;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogicaNegocio;

namespace CapaPresentación
{
    public partial class MantenedorCliente : Form
    {
        public MantenedorCliente()
        {
            InitializeComponent();
            listarCliente();
            grupBoxDatos.Enabled = false;
            txtidCliente.Enabled = false;
        }
        public void listarCliente()
        {
            dgvCliente.DataSource = logCliente.Instancia.ListarCliente();
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
                entCliente c = new entCliente();
                c.rucDniCliente = txtRucDni.Text.Trim();
                c.razonSocial = txtRazonSocial.Text.Trim();
                c.direccion = txtDireccion.Text.Trim();
                c.telefono = txtTelefono.Text.Trim();
                c.fecRegCliente = dtPickerRegCliente.Value;
                c.estCliente = cbkEstadoCliente.Checked;
                logCliente.Instancia.InsertaCliente(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grupBoxDatos.Enabled = false;
            listarCliente();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void LimpiarVariables()
        {
            txtidCliente.Text = "";
            txtRucDni.Text = "";
            txtRazonSocial.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
        }

        private void dgvCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvCliente.Rows[e.RowIndex];
            txtidCliente.Text = filaActual.Cells[0].Value.ToString();
            txtRucDni.Text = filaActual.Cells[1].Value.ToString();
            txtRazonSocial.Text = filaActual.Cells[2].Value.ToString();
            txtDireccion.Text = filaActual.Cells[3].Value.ToString();
            txtTelefono.Text = filaActual.Cells[4].Value.ToString();
            dtPickerRegCliente.Text = filaActual.Cells[5].Value.ToString();
            cbkEstadoCliente.Checked = Convert.ToBoolean(filaActual.Cells[6].Value);
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
                entCliente c = new entCliente();
                c.idCliente = int.Parse(txtidCliente.Text.Trim());
                c.rucDniCliente = txtRucDni.Text.Trim();
                c.razonSocial = txtRazonSocial.Text.Trim();
                c.direccion = txtDireccion.Text.Trim();
                c.telefono = txtTelefono.Text.Trim();
                c.fecRegCliente = dtPickerRegCliente.Value;
                c.estCliente = cbkEstadoCliente.Checked;
                logCliente.Instancia.EditaCliente(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grupBoxDatos.Enabled = false;
            listarCliente();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            grupBoxDatos.Enabled = false;
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entCliente c = new entCliente();
                c.idCliente = int.Parse(txtidCliente.Text.Trim());
                cbkEstadoCliente.Checked = false;
                logCliente.Instancia.DeshabilitarCliente(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grupBoxDatos.Enabled = false;
            listarCliente();
        }
    }
}
