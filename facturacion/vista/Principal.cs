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

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.inicio.Close();
        }

        private void registrarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Frm_Producto().ShowDialog();
        }

       
        private void listarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_listarProducto().ShowDialog();
        }

      
        private void registrarMarcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Frm_marca().ShowDialog();
        }

        private void listarMarcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Frm_listarMarca().ShowDialog();
        }

        private void facturaciònToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Frm_factura().ShowDialog();
        }

        private void pruebaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new Frm_componentes().ShowDialog();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            //this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            //this.Size = Screen.PrimaryScreen.WorkingArea.Size;

        }

        private void buscarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Frm_listarCliente().ShowDialog();
        }

        private void reguistraClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Frm_cliente().ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void registrarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Frm_registarproveedor().ShowDialog();
        }

        private void listarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Frm_listarproveedor().ShowDialog();
        }

        private void administrarLotesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       

        
    }
}