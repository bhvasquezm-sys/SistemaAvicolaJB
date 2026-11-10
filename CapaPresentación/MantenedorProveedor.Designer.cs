namespace CapaPresentación
{
    partial class MantenedorProveedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grupBoxDatos = new System.Windows.Forms.GroupBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dgvProveedor = new System.Windows.Forms.DataGridView();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.lblRucProveedor = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.cbkEstadoProveedor = new System.Windows.Forms.CheckBox();
            this.dtPickerRegProveedor = new System.Windows.Forms.DateTimePicker();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.txtRucProveedor = new System.Windows.Forms.TextBox();
            this.txtidProveedor = new System.Windows.Forms.TextBox();
            this.grupBoxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // grupBoxDatos
            // 
            this.grupBoxDatos.Controls.Add(this.dtPickerRegProveedor);
            this.grupBoxDatos.Controls.Add(this.lblFecha);
            this.grupBoxDatos.Controls.Add(this.lblID);
            this.grupBoxDatos.Controls.Add(this.lblRucProveedor);
            this.grupBoxDatos.Controls.Add(this.txtidProveedor);
            this.grupBoxDatos.Controls.Add(this.lblRazonSocial);
            this.grupBoxDatos.Controls.Add(this.cbkEstadoProveedor);
            this.grupBoxDatos.Controls.Add(this.txtRucProveedor);
            this.grupBoxDatos.Controls.Add(this.txtTelefono);
            this.grupBoxDatos.Controls.Add(this.lblCorreo);
            this.grupBoxDatos.Controls.Add(this.lblTelefono);
            this.grupBoxDatos.Controls.Add(this.txtCorreo);
            this.grupBoxDatos.Controls.Add(this.txtRazonSocial);
            this.grupBoxDatos.Location = new System.Drawing.Point(3, 305);
            this.grupBoxDatos.Name = "grupBoxDatos";
            this.grupBoxDatos.Size = new System.Drawing.Size(671, 149);
            this.grupBoxDatos.TabIndex = 10;
            this.grupBoxDatos.TabStop = false;
            this.grupBoxDatos.Text = "Datos";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(690, 12);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(97, 31);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(690, 406);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(97, 32);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(690, 124);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(97, 32);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(690, 179);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(97, 32);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(690, 49);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(97, 31);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Location = new System.Drawing.Point(690, 230);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(97, 31);
            this.btnDeshabilitar.TabIndex = 4;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            this.btnDeshabilitar.Click += new System.EventHandler(this.btnDeshabilitar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(690, 86);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(97, 32);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dgvProveedor
            // 
            this.dgvProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedor.Location = new System.Drawing.Point(12, 12);
            this.dgvProveedor.Name = "dgvProveedor";
            this.dgvProveedor.Size = new System.Drawing.Size(662, 287);
            this.dgvProveedor.TabIndex = 18;
            this.dgvProveedor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedor_CellDoubleClick);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(331, 59);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 61;
            this.lblFecha.Text = "Fecha";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(171, 61);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 60;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(10, 107);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(94, 13);
            this.lblCorreo.TabIndex = 59;
            this.lblCorreo.Text = "Correo Electronico";
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(171, 20);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(70, 13);
            this.lblRazonSocial.TabIndex = 58;
            this.lblRazonSocial.Text = "Razon Social";
            // 
            // lblRucProveedor
            // 
            this.lblRucProveedor.AutoSize = true;
            this.lblRucProveedor.Location = new System.Drawing.Point(7, 61);
            this.lblRucProveedor.Name = "lblRucProveedor";
            this.lblRucProveedor.Size = new System.Drawing.Size(30, 13);
            this.lblRucProveedor.TabIndex = 57;
            this.lblRucProveedor.Text = "RUC";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(7, 20);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(70, 13);
            this.lblID.TabIndex = 56;
            this.lblID.Text = "ID Proveedor";
            // 
            // cbkEstadoProveedor
            // 
            this.cbkEstadoProveedor.AutoSize = true;
            this.cbkEstadoProveedor.Location = new System.Drawing.Point(109, 36);
            this.cbkEstadoProveedor.Name = "cbkEstadoProveedor";
            this.cbkEstadoProveedor.Size = new System.Drawing.Size(59, 17);
            this.cbkEstadoProveedor.TabIndex = 55;
            this.cbkEstadoProveedor.Text = "Estado";
            this.cbkEstadoProveedor.UseVisualStyleBackColor = true;
            // 
            // dtPickerRegProveedor
            // 
            this.dtPickerRegProveedor.Location = new System.Drawing.Point(334, 77);
            this.dtPickerRegProveedor.Name = "dtPickerRegProveedor";
            this.dtPickerRegProveedor.Size = new System.Drawing.Size(200, 20);
            this.dtPickerRegProveedor.TabIndex = 54;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(174, 77);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(146, 20);
            this.txtTelefono.TabIndex = 53;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(10, 124);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(524, 20);
            this.txtCorreo.TabIndex = 52;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(174, 36);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(360, 20);
            this.txtRazonSocial.TabIndex = 51;
            // 
            // txtRucProveedor
            // 
            this.txtRucProveedor.Location = new System.Drawing.Point(10, 77);
            this.txtRucProveedor.Name = "txtRucProveedor";
            this.txtRucProveedor.Size = new System.Drawing.Size(158, 20);
            this.txtRucProveedor.TabIndex = 50;
            // 
            // txtidProveedor
            // 
            this.txtidProveedor.Location = new System.Drawing.Point(10, 36);
            this.txtidProveedor.Name = "txtidProveedor";
            this.txtidProveedor.Size = new System.Drawing.Size(93, 20);
            this.txtidProveedor.TabIndex = 49;
            // 
            // MantenedorProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 450);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dgvProveedor);
            this.Controls.Add(this.grupBoxDatos);
            this.Name = "MantenedorProveedor";
            this.Text = "MantenedorProveedor";
            this.Load += new System.EventHandler(this.MantenedorProveedor_Load);
            this.grupBoxDatos.ResumeLayout(false);
            this.grupBoxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grupBoxDatos;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView dgvProveedor;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.Label lblRucProveedor;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.CheckBox cbkEstadoProveedor;
        private System.Windows.Forms.DateTimePicker dtPickerRegProveedor;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.TextBox txtRucProveedor;
        private System.Windows.Forms.TextBox txtidProveedor;
    }
}