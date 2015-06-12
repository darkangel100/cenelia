using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using facturacion.controlador;

namespace facturacion.vista
{
    partial class Frm_cliente : Form
    {
        private void txt_cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
          
            Utiles.validacedula(txt_cedula, e, txt_apellido);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utiles.soloNumeros(sender, e, this.txt_telefono, 10);
        }

        private void txt_celular_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utiles.soloNumeros(sender, e, this.txt_celular, 10);
        }

        private void txt_apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utiles.soloLetras(sender, e, this.txt_celular, 0);
        }

        private void Frm_cliente_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

      
    }
}
