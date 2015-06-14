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

        private void btnmin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Frmprincipal_Load(object sender, EventArgs e)
        {
            lblfecha.Text = DateTime.Now.ToShortDateString();
            //lbluser.Text = "Usuario: " + Program.usuario;
            lblhora.Text = DateTime.Now.ToLongTimeString();
        }

       

        private void administraciònToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registrarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_registarproveedor proveedor = new Frm_registarproveedor();
            proveedor.Show();
        }

        private void reguistraClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_RegisraClente cliente = new Frm_RegisraClente();
            cliente.Show();
        }

        private void registrarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Producto pro = new Frm_Producto();
            pro.Show();
        }

        

        
       

        
    }
}