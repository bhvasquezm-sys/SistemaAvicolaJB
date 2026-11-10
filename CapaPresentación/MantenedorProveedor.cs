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
    public partial class MantenedorProveedor : Form
    {
        public MantenedorProveedor()
        {
            InitializeComponent();
            listarProveedor();
            grupBoxDatos.Enabled = false;
            txtidProveedor.Enabled = false;
        }
        public void listarProveedor()
        {
            dgvProveedor.DataSource = logProveedor.Instancia.ListarProveedor();
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
                entProveedor p = new entProveedor();
                p.rucProveedor = txtRucProveedor.Text.Trim();
                p.razonSocial = txtRazonSocial.Text.Trim();
                p.telefono = txtTelefono.Text.Trim();
                p.correo = txtCorreo.Text.Trim();
                p.fecRegProveedor = dtPickerRegProveedor.Value;
                p.estProveedor = cbkEstadoProveedor.Checked;
                logProveedor.Instancia.InsertaProveedor(p);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grupBoxDatos.Enabled = false;
            listarProveedor();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void LimpiarVariables()
        {
            txtidProveedor.Text = "";
            txtRucProveedor.Text = "";
            txtRazonSocial.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
        }

        private void dgvProveedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvProveedor.Rows[e.RowIndex];
            txtidProveedor.Text = filaActual.Cells[0].Value.ToString();
            txtRucProveedor.Text = filaActual.Cells[1].Value.ToString();
            txtRazonSocial.Text = filaActual.Cells[2].Value.ToString();
            txtTelefono.Text = filaActual.Cells[3].Value.ToString();
            txtCorreo.Text = filaActual.Cells[4].Value.ToString();
            dtPickerRegProveedor.Text = filaActual.Cells[5].Value.ToString();
            cbkEstadoProveedor.Checked = Convert.ToBoolean(filaActual.Cells[6].Value);
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
                entProveedor p = new entProveedor();
                p.idProveedor = int.Parse(txtidProveedor.Text.Trim());
                p.rucProveedor = txtRucProveedor.Text.Trim();
                p.razonSocial = txtRazonSocial.Text.Trim();
                p.telefono = txtTelefono.Text.Trim();
                p.correo = txtCorreo.Text.Trim();
                p.fecRegProveedor = dtPickerRegProveedor.Value;
                p.estProveedor = cbkEstadoProveedor.Checked;
                logProveedor.Instancia.EditaProveedor(p);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grupBoxDatos.Enabled = false;
            listarProveedor();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            grupBoxDatos.Enabled = false;
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entProveedor p = new entProveedor();
                p.idProveedor = int.Parse(txtidProveedor.Text.Trim());
                cbkEstadoProveedor.Checked = false;
                logProveedor.Instancia.DeshabilitarProveedor(p);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grupBoxDatos.Enabled = false;
            listarProveedor();
        }
    }
}
