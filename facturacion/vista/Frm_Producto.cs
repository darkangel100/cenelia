using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using facturacion.controlador;

namespace facturacion.vista
{
    partial class Frm_Producto : Form
    {
        
        public Frm_Producto()
        {
            InitializeComponent();
           
        }
        
        private void cargarVista()
        {
            
        }
      
      

        private void txt_pc_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utiles.soloDoubles(sender,e, this.txt_pc);
            
        }

        private void txt_pvp_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utiles.soloDoubles(sender, e, this.txt_pvp);

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

       

        private void Frm_Producto_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
        }
    }
}
