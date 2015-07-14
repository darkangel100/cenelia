using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace facturacion.vista
{
    public partial class Principal : Form
    {
        private Frm_inicio inicio;

        internal Frm_inicio Inicio
        {
            get { return inicio; }
            set { inicio = value; }
        }

        public Principal()
        {
            InitializeComponent();
        }
        private void Principal_Load(object sender, EventArgs e)
        {
             lblfecha.Text = DateTime.Now.ToShortDateString();
            //lbluser.Text = "Usuario: " + Program.usuario;
            lblhora.Text = DateTime.Now.ToLongTimeString();
        
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registrarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_registarproveedor proveedor = new Frm_registarproveedor();
           proveedor.MdiParent = this;
            proveedor.Show();
        }

        private void reguistraClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_RegisraClente cliente = new Frm_RegisraClente();
            cliente.MdiParent = this;
            cliente.Show();
        }

        private void registrarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Producto pro = new Frm_Producto();
            pro.MdiParent = this;
            pro.Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario usuario = new FrmUsuario();
            usuario.MdiParent = this;
            usuario.Show();
        }

        private void btnmin_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void buscarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_listarCliente listacliente = new Frm_listarCliente();
            listacliente.MdiParent = this;
            listacliente.Show();
        }

        private void registrarEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_RegistroEmpresa empreas = new Frm_RegistroEmpresa();
            empreas.MdiParent = this;
            empreas.Show();
        }
        private void facturaciònToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_factura factura = new Frm_factura();
            factura.MdiParent = this;
            factura.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToLongTimeString();
        }

        private void listarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_listarProducto listar = new frm_listarProducto();
           listar.MdiParent = this;
            listar.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
      
    }
}