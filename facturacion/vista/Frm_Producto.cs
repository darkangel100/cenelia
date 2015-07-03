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
        int indice = 0;
        string estado = "";
      

        private void txt_pc_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utiles.soloDoubles(sender,e, this.txt_unidad);
            
        }

        private void txt_pvp_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utiles.soloDoubles(sender, e, this.txt_present);

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

       

        private void Frm_Producto_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (estado == "N")
            {
                Adiciona();
            }
            if (estado == "E")
            {
                //Editar();
            }
            //indice = 0;
            //tbc_Producto.SelectTab(indice);
        }
        private void Adiciona()
        {
            try
            {
                ProductoDB objP = new ProductoDB();
                //int resp;
                objP.getProductos().Id_producto = Convert.ToInt32(txt_codigo.Text.Trim());
                objP.getProductos().Nombre = txt_nombre.Text.Trim(); ;
                objP.getProductos().Presentacion= txt_present.Text.Trim();
                objP.getProductos().Unidad = txt_unidad.Text.Trim();
                objP.getProductos().Marca= txt_marca.Text.Trim();
                
            }
            catch (Exception ex)
            { }
        }

        private void txt_pc_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Lotes lote = new Frm_Lotes();
            lote.Show();

        }
    }
}
