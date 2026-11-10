namespace CapaPresentación
{
    partial class MantenedorRequerimientoCompra
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
            this.dgvRequerimientoCompra = new System.Windows.Forms.DataGridView();
            this.grupBoxDatos = new System.Windows.Forms.GroupBox();
            this.dtPickerRegRequerimiento = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblCantidadSolicitada = new System.Windows.Forms.Label();
            this.txtidRequerimiento = new System.Windows.Forms.TextBox();
            this.lblNombreInsumo = new System.Windows.Forms.Label();
            this.cbkEstadoRequerimiento = new System.Windows.Forms.CheckBox();
            this.txtCantidadSolicitada = new System.Windows.Forms.TextBox();
            this.txtPrioridad = new System.Windows.Forms.TextBox();
            this.lblPrioridad = new System.Windows.Forms.Label();
            this.txtInsumoSolicitado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequerimientoCompra)).BeginInit();
            this.grupBoxDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(691, 12);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(97, 31);
            this.btnNuevo.TabIndex = 14;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(691, 406);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(97, 32);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(691, 124);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(97, 32);
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(691, 179);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(97, 32);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(691, 49);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(97, 31);
            this.btnEditar.TabIndex = 16;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Location = new System.Drawing.Point(691, 230);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(97, 31);
            this.btnDeshabilitar.TabIndex = 18;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            this.btnDeshabilitar.Click += new System.EventHandler(this.btnDeshabilitar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(691, 86);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(97, 32);
            this.btnModificar.TabIndex = 17;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dgvRequerimientoCompra
            // 
            this.dgvRequerimientoCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequerimientoCompra.Location = new System.Drawing.Point(12, 12);
            this.dgvRequerimientoCompra.Name = "dgvRequerimientoCompra";
            this.dgvRequerimientoCompra.Size = new System.Drawing.Size(662, 276);
            this.dgvRequerimientoCompra.TabIndex = 21;
            this.dgvRequerimientoCompra.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRequerimientoCompra_CellDoubleClick);
            // 
            // grupBoxDatos
            // 
            this.grupBoxDatos.Controls.Add(this.dtPickerRegRequerimiento);
            this.grupBoxDatos.Controls.Add(this.lblFecha);
            this.grupBoxDatos.Controls.Add(this.lblID);
            this.grupBoxDatos.Controls.Add(this.lblCantidadSolicitada);
            this.grupBoxDatos.Controls.Add(this.txtidRequerimiento);
            this.grupBoxDatos.Controls.Add(this.lblNombreInsumo);
            this.grupBoxDatos.Controls.Add(this.cbkEstadoRequerimiento);
            this.grupBoxDatos.Controls.Add(this.txtCantidadSolicitada);
            this.grupBoxDatos.Controls.Add(this.txtPrioridad);
            this.grupBoxDatos.Controls.Add(this.lblPrioridad);
            this.grupBoxDatos.Controls.Add(this.txtInsumoSolicitado);
            this.grupBoxDatos.Location = new System.Drawing.Point(12, 294);
            this.grupBoxDatos.Name = "grupBoxDatos";
            this.grupBoxDatos.Size = new System.Drawing.Size(662, 149);
            this.grupBoxDatos.TabIndex = 22;
            this.grupBoxDatos.TabStop = false;
            this.grupBoxDatos.Text = "Datos";
            // 
            // dtPickerRegRequerimiento
            // 
            this.dtPickerRegRequerimiento.Location = new System.Drawing.Point(221, 77);
            this.dtPickerRegRequerimiento.Name = "dtPickerRegRequerimiento";
            this.dtPickerRegRequerimiento.Size = new System.Drawing.Size(200, 20);
            this.dtPickerRegRequerimiento.TabIndex = 54;
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
            this.lblID.Size = new System.Drawing.Size(89, 13);
            this.lblID.TabIndex = 56;
            this.lblID.Text = "ID Requerimiento";
            // 
            // lblCantidadSolicitada
            // 
            this.lblCantidadSolicitada.AutoSize = true;
            this.lblCantidadSolicitada.Location = new System.Drawing.Point(7, 61);
            this.lblCantidadSolicitada.Name = "lblCantidadSolicitada";
            this.lblCantidadSolicitada.Size = new System.Drawing.Size(96, 13);
            this.lblCantidadSolicitada.TabIndex = 57;
            this.lblCantidadSolicitada.Text = "Cantidad solicitada";
            // 
            // txtidRequerimiento
            // 
            this.txtidRequerimiento.Location = new System.Drawing.Point(10, 36);
            this.txtidRequerimiento.Name = "txtidRequerimiento";
            this.txtidRequerimiento.Size = new System.Drawing.Size(93, 20);
            this.txtidRequerimiento.TabIndex = 49;
            // 
            // lblNombreInsumo
            // 
            this.lblNombreInsumo.AutoSize = true;
            this.lblNombreInsumo.Location = new System.Drawing.Point(171, 20);
            this.lblNombreInsumo.Name = "lblNombreInsumo";
            this.lblNombreInsumo.Size = new System.Drawing.Size(88, 13);
            this.lblNombreInsumo.TabIndex = 58;
            this.lblNombreInsumo.Text = "Insumo solicitado";
            // 
            // cbkEstadoRequerimiento
            // 
            this.cbkEstadoRequerimiento.AutoSize = true;
            this.cbkEstadoRequerimiento.Location = new System.Drawing.Point(109, 36);
            this.cbkEstadoRequerimiento.Name = "cbkEstadoRequerimiento";
            this.cbkEstadoRequerimiento.Size = new System.Drawing.Size(59, 17);
            this.cbkEstadoRequerimiento.TabIndex = 55;
            this.cbkEstadoRequerimiento.Text = "Estado";
            this.cbkEstadoRequerimiento.UseVisualStyleBackColor = true;
            // 
            // txtCantidadSolicitada
            // 
            this.txtCantidadSolicitada.Location = new System.Drawing.Point(10, 77);
            this.txtCantidadSolicitada.Name = "txtCantidadSolicitada";
            this.txtCantidadSolicitada.Size = new System.Drawing.Size(93, 20);
            this.txtCantidadSolicitada.TabIndex = 50;
            // 
            // txtPrioridad
            // 
            this.txtPrioridad.Location = new System.Drawing.Point(109, 77);
            this.txtPrioridad.Name = "txtPrioridad";
            this.txtPrioridad.Size = new System.Drawing.Size(106, 20);
            this.txtPrioridad.TabIndex = 53;
            // 
            // lblPrioridad
            // 
            this.lblPrioridad.AutoSize = true;
            this.lblPrioridad.Location = new System.Drawing.Point(106, 61);
            this.lblPrioridad.Name = "lblPrioridad";
            this.lblPrioridad.Size = new System.Drawing.Size(48, 13);
            this.lblPrioridad.TabIndex = 60;
            this.lblPrioridad.Text = "Prioridad";
            // 
            // txtInsumoSolicitado
            // 
            this.txtInsumoSolicitado.Location = new System.Drawing.Point(174, 36);
            this.txtInsumoSolicitado.Name = "txtInsumoSolicitado";
            this.txtInsumoSolicitado.Size = new System.Drawing.Size(463, 20);
            this.txtInsumoSolicitado.TabIndex = 51;
            // 
            // MantenedorRequerimientoCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grupBoxDatos);
            this.Controls.Add(this.dgvRequerimientoCompra);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnModificar);
            this.Name = "MantenedorRequerimientoCompra";
            this.Text = "MantenedorRequerimientoCompra";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequerimientoCompra)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvRequerimientoCompra;
        private System.Windows.Forms.GroupBox grupBoxDatos;
        private System.Windows.Forms.DateTimePicker dtPickerRegRequerimiento;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblCantidadSolicitada;
        private System.Windows.Forms.TextBox txtidRequerimiento;
        private System.Windows.Forms.Label lblNombreInsumo;
        private System.Windows.Forms.CheckBox cbkEstadoRequerimiento;
        private System.Windows.Forms.TextBox txtCantidadSolicitada;
        private System.Windows.Forms.TextBox txtPrioridad;
        private System.Windows.Forms.Label lblPrioridad;
        private System.Windows.Forms.TextBox txtInsumoSolicitado;
    }
}