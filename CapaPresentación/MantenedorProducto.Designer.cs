namespace CapaPresentación
{
    partial class MantenedorProducto
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
            this.dgvProducto = new System.Windows.Forms.DataGridView();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblPresentacion = new System.Windows.Forms.Label();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblidProducto = new System.Windows.Forms.Label();
            this.cbkEstadoProducto = new System.Windows.Forms.CheckBox();
            this.dtPickerRegProducto = new System.Windows.Forms.DateTimePicker();
            this.txtPesoKg = new System.Windows.Forms.TextBox();
            this.txtPresentacion = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.txtidProducto = new System.Windows.Forms.TextBox();
            this.grupBoxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // grupBoxDatos
            // 
            this.grupBoxDatos.Controls.Add(this.btnNuevo);
            this.grupBoxDatos.Controls.Add(this.btnSalir);
            this.grupBoxDatos.Controls.Add(this.btnAgregar);
            this.grupBoxDatos.Controls.Add(this.btnCancelar);
            this.grupBoxDatos.Controls.Add(this.btnEditar);
            this.grupBoxDatos.Controls.Add(this.btnDeshabilitar);
            this.grupBoxDatos.Controls.Add(this.btnModificar);
            this.grupBoxDatos.Location = new System.Drawing.Point(680, 12);
            this.grupBoxDatos.Name = "grupBoxDatos";
            this.grupBoxDatos.Size = new System.Drawing.Size(108, 408);
            this.grupBoxDatos.TabIndex = 8;
            this.grupBoxDatos.TabStop = false;
            this.grupBoxDatos.Text = "Datos";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(6, 19);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(97, 31);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(6, 370);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(97, 32);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(6, 131);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(97, 32);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(6, 186);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(97, 32);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(6, 56);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(97, 31);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Location = new System.Drawing.Point(6, 237);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(97, 31);
            this.btnDeshabilitar.TabIndex = 4;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            this.btnDeshabilitar.Click += new System.EventHandler(this.btnDeshabilitar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(6, 93);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(97, 32);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dgvProducto
            // 
            this.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducto.Location = new System.Drawing.Point(12, 12);
            this.dgvProducto.Name = "dgvProducto";
            this.dgvProducto.Size = new System.Drawing.Size(662, 287);
            this.dgvProducto.TabIndex = 16;
            this.dgvProducto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducto_CellDoubleClick);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(269, 355);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 34;
            this.lblFecha.Text = "Fecha";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(94, 355);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(100, 13);
            this.lblTelefono.TabIndex = 33;
            this.lblTelefono.Text = "Peso en Kilogramos";
            // 
            // lblPresentacion
            // 
            this.lblPresentacion.AutoSize = true;
            this.lblPresentacion.Location = new System.Drawing.Point(15, 401);
            this.lblPresentacion.Name = "lblPresentacion";
            this.lblPresentacion.Size = new System.Drawing.Size(69, 13);
            this.lblPresentacion.TabIndex = 32;
            this.lblPresentacion.Text = "Presentación";
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Location = new System.Drawing.Point(161, 316);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(105, 13);
            this.lblNombreProducto.TabIndex = 31;
            this.lblNombreProducto.Text = "Nombre de Producto";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(12, 355);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(76, 13);
            this.lblPrecio.TabIndex = 30;
            this.lblPrecio.Text = "Precio Unitario";
            // 
            // lblidProducto
            // 
            this.lblidProducto.AutoSize = true;
            this.lblidProducto.Location = new System.Drawing.Point(12, 314);
            this.lblidProducto.Name = "lblidProducto";
            this.lblidProducto.Size = new System.Drawing.Size(64, 13);
            this.lblidProducto.TabIndex = 29;
            this.lblidProducto.Text = "ID Producto";
            // 
            // cbkEstadoProducto
            // 
            this.cbkEstadoProducto.AutoSize = true;
            this.cbkEstadoProducto.Location = new System.Drawing.Point(94, 332);
            this.cbkEstadoProducto.Name = "cbkEstadoProducto";
            this.cbkEstadoProducto.Size = new System.Drawing.Size(59, 17);
            this.cbkEstadoProducto.TabIndex = 28;
            this.cbkEstadoProducto.Text = "Estado";
            this.cbkEstadoProducto.UseVisualStyleBackColor = true;
            // 
            // dtPickerRegProducto
            // 
            this.dtPickerRegProducto.Location = new System.Drawing.Point(272, 371);
            this.dtPickerRegProducto.Name = "dtPickerRegProducto";
            this.dtPickerRegProducto.Size = new System.Drawing.Size(200, 20);
            this.dtPickerRegProducto.TabIndex = 27;
            // 
            // txtPesoKg
            // 
            this.txtPesoKg.Location = new System.Drawing.Point(97, 371);
            this.txtPesoKg.Name = "txtPesoKg";
            this.txtPesoKg.Size = new System.Drawing.Size(169, 20);
            this.txtPesoKg.TabIndex = 26;
            // 
            // txtPresentacion
            // 
            this.txtPresentacion.Location = new System.Drawing.Point(15, 418);
            this.txtPresentacion.Name = "txtPresentacion";
            this.txtPresentacion.Size = new System.Drawing.Size(524, 20);
            this.txtPresentacion.TabIndex = 25;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(164, 332);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(375, 20);
            this.txtNombreProducto.TabIndex = 24;
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.Location = new System.Drawing.Point(15, 371);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.Size = new System.Drawing.Size(73, 20);
            this.txtPrecioUnitario.TabIndex = 23;
            // 
            // txtidProducto
            // 
            this.txtidProducto.Location = new System.Drawing.Point(15, 330);
            this.txtidProducto.Name = "txtidProducto";
            this.txtidProducto.Size = new System.Drawing.Size(73, 20);
            this.txtidProducto.TabIndex = 22;
            // 
            // MantenedorProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblPresentacion);
            this.Controls.Add(this.lblNombreProducto);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblidProducto);
            this.Controls.Add(this.cbkEstadoProducto);
            this.Controls.Add(this.dtPickerRegProducto);
            this.Controls.Add(this.txtPesoKg);
            this.Controls.Add(this.txtPresentacion);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.txtPrecioUnitario);
            this.Controls.Add(this.txtidProducto);
            this.Controls.Add(this.dgvProducto);
            this.Controls.Add(this.grupBoxDatos);
            this.Name = "MantenedorProducto";
            this.Text = "MantenedorProducto";
            this.grupBoxDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.DataGridView dgvProducto;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblPresentacion;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblidProducto;
        private System.Windows.Forms.CheckBox cbkEstadoProducto;
        private System.Windows.Forms.DateTimePicker dtPickerRegProducto;
        private System.Windows.Forms.TextBox txtPesoKg;
        private System.Windows.Forms.TextBox txtPresentacion;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtPrecioUnitario;
        private System.Windows.Forms.TextBox txtidProducto;
    }
}