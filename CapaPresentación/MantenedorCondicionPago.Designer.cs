namespace CapaPresentación
{
    partial class MantenedorCondicionPago
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
            this.dgvCondicionPago = new System.Windows.Forms.DataGridView();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblModalidad = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.lblDiasCredito = new System.Windows.Forms.Label();
            this.lblidCondicionPago = new System.Windows.Forms.Label();
            this.cbkEstadoCondicion = new System.Windows.Forms.CheckBox();
            this.dtPickerRegCondicion = new System.Windows.Forms.DateTimePicker();
            this.txtModalidadEntrega = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtDiasCredito = new System.Windows.Forms.TextBox();
            this.txtidCondicionPago = new System.Windows.Forms.TextBox();
            this.grupBoxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCondicionPago)).BeginInit();
            this.SuspendLayout();
            // 
            // grupBoxDatos
            // 
            this.grupBoxDatos.Controls.Add(this.txtDescripcion);
            this.grupBoxDatos.Controls.Add(this.lblFecha);
            this.grupBoxDatos.Controls.Add(this.txtidCondicionPago);
            this.grupBoxDatos.Controls.Add(this.txtDiasCredito);
            this.grupBoxDatos.Controls.Add(this.lblModalidad);
            this.grupBoxDatos.Controls.Add(this.txtNombreProducto);
            this.grupBoxDatos.Controls.Add(this.txtModalidadEntrega);
            this.grupBoxDatos.Controls.Add(this.lblDescripcion);
            this.grupBoxDatos.Controls.Add(this.dtPickerRegCondicion);
            this.grupBoxDatos.Controls.Add(this.cbkEstadoCondicion);
            this.grupBoxDatos.Controls.Add(this.lblNombreProducto);
            this.grupBoxDatos.Controls.Add(this.lblidCondicionPago);
            this.grupBoxDatos.Controls.Add(this.lblDiasCredito);
            this.grupBoxDatos.Location = new System.Drawing.Point(12, 297);
            this.grupBoxDatos.Name = "grupBoxDatos";
            this.grupBoxDatos.Size = new System.Drawing.Size(662, 152);
            this.grupBoxDatos.TabIndex = 9;
            this.grupBoxDatos.TabStop = false;
            this.grupBoxDatos.Text = "Datos";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(693, 12);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(97, 31);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(693, 408);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(97, 32);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(693, 124);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(97, 32);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(693, 179);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(97, 32);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(693, 49);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(97, 31);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Location = new System.Drawing.Point(693, 230);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(97, 31);
            this.btnDeshabilitar.TabIndex = 4;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            this.btnDeshabilitar.Click += new System.EventHandler(this.btnDeshabilitar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(693, 86);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(97, 32);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dgvCondicionPago
            // 
            this.dgvCondicionPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCondicionPago.Location = new System.Drawing.Point(12, 12);
            this.dgvCondicionPago.Name = "dgvCondicionPago";
            this.dgvCondicionPago.Size = new System.Drawing.Size(662, 279);
            this.dgvCondicionPago.TabIndex = 17;
            this.dgvCondicionPago.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCondicionPago_CellDoubleClick);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(260, 60);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 48;
            this.lblFecha.Text = "Fecha";
            // 
            // lblModalidad
            // 
            this.lblModalidad.AutoSize = true;
            this.lblModalidad.Location = new System.Drawing.Point(85, 60);
            this.lblModalidad.Name = "lblModalidad";
            this.lblModalidad.Size = new System.Drawing.Size(110, 13);
            this.lblModalidad.TabIndex = 47;
            this.lblModalidad.Text = "Modalidad de entrego";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(6, 106);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 46;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Location = new System.Drawing.Point(167, 19);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(105, 13);
            this.lblNombreProducto.TabIndex = 45;
            this.lblNombreProducto.Text = "Nombre de Producto";
            // 
            // lblDiasCredito
            // 
            this.lblDiasCredito.AutoSize = true;
            this.lblDiasCredito.Location = new System.Drawing.Point(3, 60);
            this.lblDiasCredito.Name = "lblDiasCredito";
            this.lblDiasCredito.Size = new System.Drawing.Size(79, 13);
            this.lblDiasCredito.TabIndex = 44;
            this.lblDiasCredito.Text = "Dias de Credito";
            // 
            // lblidCondicionPago
            // 
            this.lblidCondicionPago.AutoSize = true;
            this.lblidCondicionPago.Location = new System.Drawing.Point(3, 19);
            this.lblidCondicionPago.Name = "lblidCondicionPago";
            this.lblidCondicionPago.Size = new System.Drawing.Size(96, 13);
            this.lblidCondicionPago.TabIndex = 43;
            this.lblidCondicionPago.Text = "ID Condicion Pago";
            // 
            // cbkEstadoCondicion
            // 
            this.cbkEstadoCondicion.AutoSize = true;
            this.cbkEstadoCondicion.Location = new System.Drawing.Point(105, 35);
            this.cbkEstadoCondicion.Name = "cbkEstadoCondicion";
            this.cbkEstadoCondicion.Size = new System.Drawing.Size(59, 17);
            this.cbkEstadoCondicion.TabIndex = 42;
            this.cbkEstadoCondicion.Text = "Estado";
            this.cbkEstadoCondicion.UseVisualStyleBackColor = true;
            // 
            // dtPickerRegCondicion
            // 
            this.dtPickerRegCondicion.Location = new System.Drawing.Point(263, 76);
            this.dtPickerRegCondicion.Name = "dtPickerRegCondicion";
            this.dtPickerRegCondicion.Size = new System.Drawing.Size(200, 20);
            this.dtPickerRegCondicion.TabIndex = 41;
            // 
            // txtModalidadEntrega
            // 
            this.txtModalidadEntrega.Location = new System.Drawing.Point(88, 76);
            this.txtModalidadEntrega.Name = "txtModalidadEntrega";
            this.txtModalidadEntrega.Size = new System.Drawing.Size(169, 20);
            this.txtModalidadEntrega.TabIndex = 40;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(6, 123);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(524, 20);
            this.txtDescripcion.TabIndex = 39;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(170, 35);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(360, 20);
            this.txtNombreProducto.TabIndex = 38;
            // 
            // txtDiasCredito
            // 
            this.txtDiasCredito.Location = new System.Drawing.Point(6, 76);
            this.txtDiasCredito.Name = "txtDiasCredito";
            this.txtDiasCredito.Size = new System.Drawing.Size(76, 20);
            this.txtDiasCredito.TabIndex = 37;
            // 
            // txtidCondicionPago
            // 
            this.txtidCondicionPago.Location = new System.Drawing.Point(6, 35);
            this.txtidCondicionPago.Name = "txtidCondicionPago";
            this.txtidCondicionPago.Size = new System.Drawing.Size(93, 20);
            this.txtidCondicionPago.TabIndex = 36;
            // 
            // MantenedorCondicionPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 450);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dgvCondicionPago);
            this.Controls.Add(this.grupBoxDatos);
            this.Name = "MantenedorCondicionPago";
            this.Text = "MantenedorCondicionPago";
            this.grupBoxDatos.ResumeLayout(false);
            this.grupBoxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCondicionPago)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvCondicionPago;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblModalidad;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.Label lblDiasCredito;
        private System.Windows.Forms.Label lblidCondicionPago;
        private System.Windows.Forms.CheckBox cbkEstadoCondicion;
        private System.Windows.Forms.DateTimePicker dtPickerRegCondicion;
        private System.Windows.Forms.TextBox txtModalidadEntrega;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtDiasCredito;
        private System.Windows.Forms.TextBox txtidCondicionPago;
    }
}