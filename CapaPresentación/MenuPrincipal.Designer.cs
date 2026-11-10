namespace CapaPresentacion
{
    partial class MenuPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.menuStripPrincipal = new System.Windows.Forms.MenuStrip();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.condicionPagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.almacenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insumosProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requerimientoCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.grupBoxVentas = new System.Windows.Forms.GroupBox();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnCondicionPago = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.grupBoxAlmacen = new System.Windows.Forms.GroupBox();
            this.btnRequerimientoCompra = new System.Windows.Forms.Button();
            this.btnInsumosProductos = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.menuStripPrincipal.SuspendLayout();
            this.grupBoxVentas.SuspendLayout();
            this.grupBoxAlmacen.SuspendLayout();
            this.SuspendLayout();

            this.menuStripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasToolStripMenuItem,
            this.almacenToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStripPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuStripPrincipal.Name = "menuStripPrincipal";
            this.menuStripPrincipal.Size = new System.Drawing.Size(680, 24);
            this.menuStripPrincipal.TabIndex = 0;
            this.menuStripPrincipal.Text = "menuStrip1";

            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.condicionPagoToolStripMenuItem,
            this.productosToolStripMenuItem});
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.ventasToolStripMenuItem.Text = "Mantenedores Ventas";

            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.clientesToolStripMenuItem.Text = "Mantenedor Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.btnClientes_Click);

            this.condicionPagoToolStripMenuItem.Name = "condicionPagoToolStripMenuItem";
            this.condicionPagoToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.condicionPagoToolStripMenuItem.Text = "Mantenedor CondicionPago";
            this.condicionPagoToolStripMenuItem.Click += new System.EventHandler(this.btnCondicionPago_Click);

            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.productosToolStripMenuItem.Text = "Mantenedor Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.btnProductos_Click);

            this.almacenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proveedoresToolStripMenuItem,
            this.insumosProductosToolStripMenuItem,
            this.requerimientoCompraToolStripMenuItem});
            this.almacenToolStripMenuItem.Name = "almacenToolStripMenuItem";
            this.almacenToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.almacenToolStripMenuItem.Text = "Mantenedores Almacén";

            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.proveedoresToolStripMenuItem.Text = "Mantenedor Proveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.btnProveedores_Click);

            this.insumosProductosToolStripMenuItem.Name = "insumosProductosToolStripMenuItem";
            this.insumosProductosToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.insumosProductosToolStripMenuItem.Text = "Mantenedor InsumosProductos";
            this.insumosProductosToolStripMenuItem.Click += new System.EventHandler(this.btnInsumosProductos_Click);

            this.requerimientoCompraToolStripMenuItem.Name = "requerimientoCompraToolStripMenuItem";
            this.requerimientoCompraToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.requerimientoCompraToolStripMenuItem.Text = "Mantenedor RequerimientoCompra";
            this.requerimientoCompraToolStripMenuItem.Click += new System.EventHandler(this.btnRequerimientoCompra_Click);

            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.btnSalir_Click);

            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(175, 42);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(330, 30);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "SISTEMA AVÍCOLA J.B. S.A.C.";

            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.lblSubtitulo.Location = new System.Drawing.Point(215, 76);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(250, 19);
            this.lblSubtitulo.TabIndex = 2;
            this.lblSubtitulo.Text = "Gestión de Mantenedores del Sistema";

            this.grupBoxVentas.Controls.Add(this.btnProductos);
            this.grupBoxVentas.Controls.Add(this.btnCondicionPago);
            this.grupBoxVentas.Controls.Add(this.btnClientes);
            this.grupBoxVentas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.grupBoxVentas.Location = new System.Drawing.Point(40, 115);
            this.grupBoxVentas.Name = "grupBoxVentas";
            this.grupBoxVentas.Size = new System.Drawing.Size(280, 230);
            this.grupBoxVentas.TabIndex = 3;
            this.grupBoxVentas.TabStop = false;
            this.grupBoxVentas.Text = "Subsistema de Ventas";

            this.btnClientes.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular);
            this.btnClientes.Location = new System.Drawing.Point(25, 38);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(230, 45);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.Text = "Mantenedor Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);

            this.btnCondicionPago.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular);
            this.btnCondicionPago.Location = new System.Drawing.Point(25, 98);
            this.btnCondicionPago.Name = "btnCondicionPago";
            this.btnCondicionPago.Size = new System.Drawing.Size(230, 45);
            this.btnCondicionPago.TabIndex = 1;
            this.btnCondicionPago.Text = "Mantenedor CondicionPago";
            this.btnCondicionPago.UseVisualStyleBackColor = true;
            this.btnCondicionPago.Click += new System.EventHandler(this.btnCondicionPago_Click);

            this.btnProductos.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular);
            this.btnProductos.Location = new System.Drawing.Point(25, 158);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(230, 45);
            this.btnProductos.TabIndex = 2;
            this.btnProductos.Text = "Mantenedor Productos";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);

            this.grupBoxAlmacen.Controls.Add(this.btnRequerimientoCompra);
            this.grupBoxAlmacen.Controls.Add(this.btnInsumosProductos);
            this.grupBoxAlmacen.Controls.Add(this.btnProveedores);
            this.grupBoxAlmacen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.grupBoxAlmacen.Location = new System.Drawing.Point(360, 115);
            this.grupBoxAlmacen.Name = "grupBoxAlmacen";
            this.grupBoxAlmacen.Size = new System.Drawing.Size(280, 230);
            this.grupBoxAlmacen.TabIndex = 4;
            this.grupBoxAlmacen.TabStop = false;
            this.grupBoxAlmacen.Text = "Subsistema de Almacén";

            this.btnProveedores.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular);
            this.btnProveedores.Location = new System.Drawing.Point(25, 38);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(230, 45);
            this.btnProveedores.TabIndex = 0;
            this.btnProveedores.Text = "Mantenedor Proveedores";
            this.btnProveedores.UseVisualStyleBackColor = true;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);

            this.btnInsumosProductos.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular);
            this.btnInsumosProductos.Location = new System.Drawing.Point(25, 98);
            this.btnInsumosProductos.Name = "btnInsumosProductos";
            this.btnInsumosProductos.Size = new System.Drawing.Size(230, 45);
            this.btnInsumosProductos.TabIndex = 1;
            this.btnInsumosProductos.Text = "Mantenedor InsumosProductos";
            this.btnInsumosProductos.UseVisualStyleBackColor = true;
            this.btnInsumosProductos.Click += new System.EventHandler(this.btnInsumosProductos_Click);

            this.btnRequerimientoCompra.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular);
            this.btnRequerimientoCompra.Location = new System.Drawing.Point(25, 158);
            this.btnRequerimientoCompra.Name = "btnRequerimientoCompra";
            this.btnRequerimientoCompra.Size = new System.Drawing.Size(230, 45);
            this.btnRequerimientoCompra.TabIndex = 2;
            this.btnRequerimientoCompra.Text = "Mantenedor RequerimientoCompra";
            this.btnRequerimientoCompra.UseVisualStyleBackColor = true;
            this.btnRequerimientoCompra.Click += new System.EventHandler(this.btnRequerimientoCompra_Click);

            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSalir.Location = new System.Drawing.Point(520, 365);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(120, 35);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 420);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.grupBoxAlmacen);
            this.Controls.Add(this.grupBoxVentas);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.menuStripPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStripPrincipal;
            this.MaximizeBox = false;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Avícola J.B. S.A.C. - Menú Principal";
            this.menuStripPrincipal.ResumeLayout(false);
            this.menuStripPrincipal.PerformLayout();
            this.grupBoxVentas.ResumeLayout(false);
            this.grupBoxAlmacen.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripPrincipal;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem condicionPagoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem almacenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insumosProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requerimientoCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.GroupBox grupBoxVentas;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnCondicionPago;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.GroupBox grupBoxAlmacen;
        private System.Windows.Forms.Button btnRequerimientoCompra;
        private System.Windows.Forms.Button btnInsumosProductos;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnSalir;
    }
}