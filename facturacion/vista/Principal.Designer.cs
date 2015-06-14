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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblhora = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.btnmin = new System.Windows.Forms.Button();
            this.btncerrar = new System.Windows.Forms.Button();
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
            this.administrarLotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaciònToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarEmpresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarReportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.lblhora);
            this.panel2.Controls.Add(this.lblfecha);
            this.panel2.Controls.Add(this.btnmin);
            this.panel2.Controls.Add(this.btncerrar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 312);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(829, 40);
            this.panel2.TabIndex = 3;
            // 
            // lblhora
            // 
            this.lblhora.BackColor = System.Drawing.Color.Transparent;
            this.lblhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora.ForeColor = System.Drawing.SystemColors.Window;
            this.lblhora.Location = new System.Drawing.Point(3, 10);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(98, 20);
            this.lblhora.TabIndex = 0;
            this.lblhora.Text = "22:02:00";
            this.lblhora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblfecha
            // 
            this.lblfecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblfecha.BackColor = System.Drawing.Color.Transparent;
            this.lblfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.ForeColor = System.Drawing.SystemColors.Window;
            this.lblfecha.Location = new System.Drawing.Point(637, 10);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(115, 25);
            this.lblfecha.TabIndex = 2;
            this.lblfecha.Text = "28/10/2014";
            this.lblfecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnmin
            // 
            this.btnmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmin.BackColor = System.Drawing.Color.Maroon;
            this.btnmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmin.ForeColor = System.Drawing.Color.White;
            this.btnmin.Location = new System.Drawing.Point(758, 1);
            this.btnmin.Name = "btnmin";
            this.btnmin.Size = new System.Drawing.Size(36, 36);
            this.btnmin.TabIndex = 1;
            this.btnmin.Text = "--";
            this.btnmin.UseVisualStyleBackColor = false;
            // 
            // btncerrar
            // 
            this.btncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncerrar.BackColor = System.Drawing.Color.Maroon;
            this.btncerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncerrar.ForeColor = System.Drawing.Color.White;
            this.btncerrar.Location = new System.Drawing.Point(793, 1);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(36, 36);
            this.btncerrar.TabIndex = 2;
            this.btncerrar.Text = "X";
            this.btncerrar.UseVisualStyleBackColor = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.administraciònToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.proveedorToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(829, 24);
            this.menuStrip1.TabIndex = 4;
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
            this.reguistraClienteToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.reguistraClienteToolStripMenuItem.Text = "Registra Cliente";
            this.reguistraClienteToolStripMenuItem.Click += new System.EventHandler(this.reguistraClienteToolStripMenuItem_Click);
            // 
            // buscarClienteToolStripMenuItem
            // 
            this.buscarClienteToolStripMenuItem.Name = "buscarClienteToolStripMenuItem";
            this.buscarClienteToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.buscarClienteToolStripMenuItem.Text = "Buscar Cliente";
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
            this.administraciònToolStripMenuItem.Click += new System.EventHandler(this.administraciònToolStripMenuItem_Click);
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
            // 
            // registrarMarcasToolStripMenuItem
            // 
            this.registrarMarcasToolStripMenuItem.Name = "registrarMarcasToolStripMenuItem";
            this.registrarMarcasToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.registrarMarcasToolStripMenuItem.Text = "Registrar Marcas";
            // 
            // administrarLotesToolStripMenuItem
            // 
            this.administrarLotesToolStripMenuItem.Name = "administrarLotesToolStripMenuItem";
            this.administrarLotesToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.administrarLotesToolStripMenuItem.Text = "Administrar Lotes";
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
            this.listarProveedorToolStripMenuItem,
            this.registrarEmpresaToolStripMenuItem});
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
            // 
            // registrarEmpresaToolStripMenuItem
            // 
            this.registrarEmpresaToolStripMenuItem.Name = "registrarEmpresaToolStripMenuItem";
            this.registrarEmpresaToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.registrarEmpresaToolStripMenuItem.Text = "Registrar Empresa";
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
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::facturacion.Properties.Resources.Fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(829, 352);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Principal_Load);
            this.panel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Button btnmin;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reguistraClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administraciònToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarMarcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarMarcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarMarcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarLotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaciònToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarEmpresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarReportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;

    }
}