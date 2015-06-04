using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace facturacion
{
    public partial class Frm_listarproveedor : Form
    {
        public Frm_listarproveedor()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1)
            {
                txtbusacrproveedor.Enabled = true;
                txtbusacrproveedor.Focus();
            }
        }

        private void txtbusacrproveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                //Utiles.soloLetras(sender, e, this.txtbusacrproveedor, 0);
            }
        }
    }
}
