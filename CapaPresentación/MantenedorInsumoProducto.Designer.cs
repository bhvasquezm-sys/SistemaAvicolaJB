namespace CapaPresentación
{
    partial class MantenedorInsumoProducto
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
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dgvInsumoProducto = new System.Windows.Forms.DataGridView();
            this.grupBoxDatos = new System.Windows.Forms.GroupBox();
            this.dtPickerRegInsumo = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblStockActual = new System.Windows.Forms.Label();
            this.txtidInsumo = new System.Windows.Forms.TextBox();
            this.lblNombreInsumo = new System.Windows.Forms.Label();
            this.cbkEstadoInsumo = new System.Windows.Forms.CheckBox();
            this.txtStockActual = new System.Windows.Forms.TextBox();
            this.txtUnidadMedida = new System.Windows.Forms.TextBox();
            this.lblUnidadMedida = new System.Windows.Forms.Label();
            this.txtNombreInsumo = new System.Windows.Forms.TextBox();
            this.txtTipoMaterial = new System.Windows.Forms.TextBox();
            this.lblTipoMaterial = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumoProducto)).BeginInit();
            this.grupBoxDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(691, 14);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(97, 31);
            this.btnNuevo.TabIndex = 7;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(691, 408);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(97, 32);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(691, 126);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(97, 32);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(691, 181);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(97, 32);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(691, 51);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(97, 31);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Location = new System.Drawing.Point(691, 232);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(97, 31);
            this.btnDeshabilitar.TabIndex = 11;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            this.btnDeshabilitar.Click += new System.EventHandler(this.btnDeshabilitar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(691, 88);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(97, 32);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dgvInsumoProducto
            // 
            this.dgvInsumoProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInsumoProducto.Location = new System.Drawing.Point(12, 12);
            this.dgvInsumoProducto.Name = "dgvInsumoProducto";
            this.dgvInsumoProducto.Size = new System.Drawing.Size(662, 276);
            this.dgvInsumoProducto.TabIndex = 19;
            this.dgvInsumoProducto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInsumoProducto_CellDoubleClick);
            // 
            // grupBoxDatos
            // 
            this.grupBoxDatos.Controls.Add(this.lblTipoMaterial);
            this.grupBoxDatos.Controls.Add(this.txtTipoMaterial);
            this.grupBoxDatos.Controls.Add(this.dtPickerRegInsumo);
            this.grupBoxDatos.Controls.Add(this.lblFecha);
            this.grupBoxDatos.Controls.Add(this.lblID);
            this.grupBoxDatos.Controls.Add(this.lblStockActual);
            this.grupBoxDatos.Controls.Add(this.txtidInsumo);
            this.grupBoxDatos.Controls.Add(this.lblNombreInsumo);
            this.grupBoxDatos.Controls.Add(this.cbkEstadoInsumo);
            this.grupBoxDatos.Controls.Add(this.txtStockActual);
            this.grupBoxDatos.Controls.Add(this.txtUnidadMedida);
            this.grupBoxDatos.Controls.Add(this.lblUnidadMedida);
            this.grupBoxDatos.Controls.Add(this.txtNombreInsumo);
            this.grupBoxDatos.Location = new System.Drawing.Point(12, 294);
            this.grupBoxDatos.Name = "grupBoxDatos";
            this.grupBoxDatos.Size = new System.Drawing.Size(662, 149);
            this.grupBoxDatos.TabIndex = 20;
            this.grupBoxDatos.TabStop = false;
            this.grupBoxDatos.Text = "Datos";
            // 
            // dtPickerRegInsumo
            // 
            this.dtPickerRegInsumo.Location = new System.Drawing.Point(221, 77);
            this.dtPickerRegInsumo.Name = "dtPickerRegInsumo";
            this.dtPickerRegInsumo.Size = new System.Drawing.Size(200, 20);
            this.dtPickerRegInsumo.TabIndex = 54;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(218, 61);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 61;
            this.lblFecha.Text = "Fecha";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(7, 20);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(55, 13);
            this.lblID.TabIndex = 56;
            this.lblID.Text = "ID Insumo";
            // 
            // lblStockActual
            // 
            this.lblStockActual.AutoSize = true;
            this.lblStockActual.Location = new System.Drawing.Point(7, 61);
            this.lblStockActual.Name = "lblStockActual";
            this.lblStockActual.Size = new System.Drawing.Size(35, 13);
            this.lblStockActual.TabIndex = 57;
            this.lblStockActual.Text = "Stock";
            // 
            // txtidInsumo
            // 
            this.txtidInsumo.Location = new System.Drawing.Point(10, 36);
            this.txtidInsumo.Name = "txtidInsumo";
            this.txtidInsumo.Size = new System.Drawing.Size(93, 20);
            this.txtidInsumo.TabIndex = 49;
            // 
            // lblNombreInsumo
            // 
            this.lblNombreInsumo.AutoSize = true;
            this.lblNombreInsumo.Location = new System.Drawing.Point(171, 20);
            this.lblNombreInsumo.Name = "lblNombreInsumo";
            this.lblNombreInsumo.Size = new System.Drawing.Size(44, 13);
            this.lblNombreInsumo.TabIndex = 58;
            this.lblNombreInsumo.Text = "Nombre";
            // 
            // cbkEstadoInsumo
            // 
            this.cbkEstadoInsumo.AutoSize = true;
            this.cbkEstadoInsumo.Location = new System.Drawing.Point(109, 36);
            this.cbkEstadoInsumo.Name = "cbkEstadoInsumo";
            this.cbkEstadoInsumo.Size = new System.Drawing.Size(59, 17);
            this.cbkEstadoInsumo.TabIndex = 55;
            this.cbkEstadoInsumo.Text = "Estado";
            this.cbkEstadoInsumo.UseVisualStyleBackColor = true;
            // 
            // txtStockActual
            // 
            this.txtStockActual.Location = new System.Drawing.Point(10, 77);
            this.txtStockActual.Name = "txtStockActual";
            this.txtStockActual.Size = new System.Drawing.Size(93, 20);
            this.txtStockActual.TabIndex = 50;
            // 
            // txtUnidadMedida
            // 
            this.txtUnidadMedida.Location = new System.Drawing.Point(109, 77);
            this.txtUnidadMedida.Name = "txtUnidadMedida";
            this.txtUnidadMedida.Size = new System.Drawing.Size(106, 20);
            this.txtUnidadMedida.TabIndex = 53;
            // 
            // lblUnidadMedida
            // 
            this.lblUnidadMedida.AutoSize = true;
            this.lblUnidadMedida.Location = new System.Drawing.Point(106, 61);
            this.lblUnidadMedida.Name = "lblUnidadMedida";
            this.lblUnidadMedida.Size = new System.Drawing.Size(93, 13);
            this.lblUnidadMedida.TabIndex = 60;
            this.lblUnidadMedida.Text = "Unidad de medida";
            // 
            // txtNombreInsumo
            // 
            this.txtNombreInsumo.Location = new System.Drawing.Point(174, 36);
            this.txtNombreInsumo.Name = "txtNombreInsumo";
            this.txtNombreInsumo.Size = new System.Drawing.Size(463, 20);
            this.txtNombreInsumo.TabIndex = 51;
            // 
            // txtTipoMaterial
            // 
            this.txtTipoMaterial.Location = new System.Drawing.Point(430, 77);
            this.txtTipoMaterial.Name = "txtTipoMaterial";
            this.txtTipoMaterial.Size = new System.Drawing.Size(207, 20);
            this.txtTipoMaterial.TabIndex = 62;
            // 
            // lblTipoMaterial
            // 
            this.lblTipoMaterial.AutoSize = true;
            this.lblTipoMaterial.Location = new System.Drawing.Point(427, 61);
            this.lblTipoMaterial.Name = "lblTipoMaterial";
            this.lblTipoMaterial.Size = new System.Drawing.Size(82, 13);
            this.lblTipoMaterial.TabIndex = 63;
            this.lblTipoMaterial.Text = "Tipo de material";
            // 
            // MantenedorInsumoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grupBoxDatos);
            this.Controls.Add(this.dgvInsumoProducto);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnModificar);
            this.Name = "MantenedorInsumoProducto";
            this.Text = "MantenedorInsumoProducto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumoProducto)).EndInit();
            this.grupBoxDatos.ResumeLayout(false);
            this.grupBoxDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView dgvInsumoProducto;
        private System.Windows.Forms.GroupBox grupBoxDatos;
        private System.Windows.Forms.DateTimePicker dtPickerRegInsumo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblStockActual;
        private System.Windows.Forms.TextBox txtidInsumo;
        private System.Windows.Forms.Label lblNombreInsumo;
        private System.Windows.Forms.CheckBox cbkEstadoInsumo;
        private System.Windows.Forms.TextBox txtStockActual;
        private System.Windows.Forms.TextBox txtUnidadMedida;
        private System.Windows.Forms.Label lblUnidadMedida;
        private System.Windows.Forms.TextBox txtNombreInsumo;
        private System.Windows.Forms.Label lblTipoMaterial;
        private System.Windows.Forms.TextBox txtTipoMaterial;
    }
}