namespace facturacion.vista
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reguistraClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administraciònToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarMarcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarMarcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarMarcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaciònToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pruebaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pruebaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarReportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarLotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.administraciònToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.proveedorToolStripMenuItem,
            this.pruebaToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(829, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reguistraClienteToolStripMenuItem,
            this.buscarClienteToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.clientesToolStripMenuItem.Text = "Administra Clientes";
            // 
            // reguistraClienteToolStripMenuItem
            // 
            this.reguistraClienteToolStripMenuItem.Name = "reguistraClienteToolStripMenuItem";
            this.reguistraClienteToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.reguistraClienteToolStripMenuItem.Text = "Reguistra Cliente";
            this.reguistraClienteToolStripMenuItem.Click += new System.EventHandler(this.reguistraClienteToolStripMenuItem_Click);
            // 
            // buscarClienteToolStripMenuItem
            // 
            this.buscarClienteToolStripMenuItem.Name = "buscarClienteToolStripMenuItem";
            this.buscarClienteToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.buscarClienteToolStripMenuItem.Text = "Buscar Cliente";
            this.buscarClienteToolStripMenuItem.Click += new System.EventHandler(this.buscarClienteToolStripMenuItem_Click);
            // 
            // administraciònToolStripMenuItem
            // 
            this.administraciònToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarProductoToolStripMenuItem,
            this.administrarMarcasToolStripMenuItem,
            this.administrarLotesToolStripMenuItem});
            this.administraciònToolStripMenuItem.Name = "administraciònToolStripMenuItem";
            this.administraciònToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.administraciònToolStripMenuItem.Text = "Administra Productos";
            // 
            // administrarProductoToolStripMenuItem
            // 
            this.administrarProductoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarProductosToolStripMenuItem,
            this.registrarProductosToolStripMenuItem});
            this.administrarProductoToolStripMenuItem.Name = "administrarProductoToolStripMenuItem";
            this.administrarProductoToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.administrarProductoToolStripMenuItem.Text = "Administrar Producto";
            // 
            // listarProductosToolStripMenuItem
            // 
            this.listarProductosToolStripMenuItem.Name = "listarProductosToolStripMenuItem";
            this.listarProductosToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.listarProductosToolStripMenuItem.Text = "Listar productos";
            this.listarProductosToolStripMenuItem.Click += new System.EventHandler(this.listarProductosToolStripMenuItem_Click);
            // 
            // registrarProductosToolStripMenuItem
            // 
            this.registrarProductosToolStripMenuItem.Name = "registrarProductosToolStripMenuItem";
            this.registrarProductosToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.registrarProductosToolStripMenuItem.Text = "Registrar Productos";
            this.registrarProductosToolStripMenuItem.Click += new System.EventHandler(this.registrarProductosToolStripMenuItem_Click);
            // 
            // administrarMarcasToolStripMenuItem
            // 
            this.administrarMarcasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarMarcasToolStripMenuItem,
            this.registrarMarcasToolStripMenuItem});
            this.administrarMarcasToolStripMenuItem.Name = "administrarMarcasToolStripMenuItem";
            this.administrarMarcasToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.administrarMarcasToolStripMenuItem.Text = "Administrar Marcas";
            // 
            // listarMarcasToolStripMenuItem
            // 
            this.listarMarcasToolStripMenuItem.Name = "listarMarcasToolStripMenuItem";
            this.listarMarcasToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.listarMarcasToolStripMenuItem.Text = "Listar Marcas";
            this.listarMarcasToolStripMenuItem.Click += new System.EventHandler(this.listarMarcasToolStripMenuItem_Click);
            // 
            // registrarMarcasToolStripMenuItem
            // 
            this.registrarMarcasToolStripMenuItem.Name = "registrarMarcasToolStripMenuItem";
            this.registrarMarcasToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.registrarMarcasToolStripMenuItem.Text = "Registrar Marcas";
            this.registrarMarcasToolStripMenuItem.Click += new System.EventHandler(this.registrarMarcasToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturaciònToolStripMenuItem,
            this.listarToolStripMenuItem});
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // facturaciònToolStripMenuItem
            // 
            this.facturaciònToolStripMenuItem.Name = "facturaciònToolStripMenuItem";
            this.facturaciònToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.facturaciònToolStripMenuItem.Text = "Facturaciòn";
            this.facturaciònToolStripMenuItem.Click += new System.EventHandler(this.facturaciònToolStripMenuItem_Click);
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.listarToolStripMenuItem.Text = "Listar";
            // 
            // proveedorToolStripMenuItem
            // 
            this.proveedorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarProveedorToolStripMenuItem,
            this.listarProveedorToolStripMenuItem});
            this.proveedorToolStripMenuItem.Name = "proveedorToolStripMenuItem";
            this.proveedorToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.proveedorToolStripMenuItem.Text = "Administra Proveedor";
            // 
            // registrarProveedorToolStripMenuItem
            // 
            this.registrarProveedorToolStripMenuItem.Name = "registrarProveedorToolStripMenuItem";
            this.registrarProveedorToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.registrarProveedorToolStripMenuItem.Text = "Registrar Proveedor";
            this.registrarProveedorToolStripMenuItem.Click += new System.EventHandler(this.registrarProveedorToolStripMenuItem_Click);
            // 
            // listarProveedorToolStripMenuItem
            // 
            this.listarProveedorToolStripMenuItem.Name = "listarProveedorToolStripMenuItem";
            this.listarProveedorToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.listarProveedorToolStripMenuItem.Text = "Listar Proveedor";
            this.listarProveedorToolStripMenuItem.Click += new System.EventHandler(this.listarProveedorToolStripMenuItem_Click);
            // 
            // pruebaToolStripMenuItem
            // 
            this.pruebaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pruebaToolStripMenuItem1});
            this.pruebaToolStripMenuItem.Name = "pruebaToolStripMenuItem";
            this.pruebaToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.pruebaToolStripMenuItem.Text = "Prueba";
            // 
            // pruebaToolStripMenuItem1
            // 
            this.pruebaToolStripMenuItem1.Name = "pruebaToolStripMenuItem1";
            this.pruebaToolStripMenuItem1.Size = new System.Drawing.Size(111, 22);
            this.pruebaToolStripMenuItem1.Text = "Prueba";
            this.pruebaToolStripMenuItem1.Click += new System.EventHandler(this.pruebaToolStripMenuItem1_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarReportesToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // listarReportesToolStripMenuItem
            // 
            this.listarReportesToolStripMenuItem.Name = "listarReportesToolStripMenuItem";
            this.listarReportesToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.listarReportesToolStripMenuItem.Text = "Listar Reportes";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // administrarLotesToolStripMenuItem
            // 
            this.administrarLotesToolStripMenuItem.Name = "administrarLotesToolStripMenuItem";
            this.administrarLotesToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.administrarLotesToolStripMenuItem.Text = "Administrar Lotes";
            this.administrarLotesToolStripMenuItem.Click += new System.EventHandler(this.administrarLotesToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(829, 266);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administraciònToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaciònToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarMarcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarMarcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarMarcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pruebaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pruebaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reguistraClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarReportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarLotesToolStripMenuItem;
    }
}