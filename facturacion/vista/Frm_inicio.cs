using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using facturacion.controlador;
using facturacion.modelo;

using MySql.Data.MySqlClient;

using System.Data;

namespace facturacion.vista
{
   
    partial class Frm_inicio : Form
    {
      
        public Frm_inicio()
        {
            InitializeComponent();

        }

        
        

      
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            verificar();
        }

        private void btncerrar_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea Salir", "◄ AVISO ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnmin_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
       


        private void verificar()
        {
            if (textBox1. Text.Trim().Length > 0 && textBox2. Text.Trim().Length > 0)
            {
                try
                {

                    CuentaDB objB = new CuentaDB();
                    objB.setCuenta(objB.TraeContra(textBox1.Text));
                    
                    if (objB.getCuenta().Usuario21.Equals(textBox1.Text) && objB.getCuenta().Clave.Equals(textBox2.Text))
                    {

                        Principal prin = new Principal();
                        prin.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Cedula o Clave Incorrectas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Contraseña o Usuario Incorrecta "+ex.Message,"Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    textBox1.Focus();
                }
            }
            else
            {
                MessageBox.Show("Deve ingresar Llenar los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Focus();
            }
        }

        private void Frm_inicio_Load(object sender, EventArgs e)
        {
            //Mostrar Fecha y Hora
            lblFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToLongTimeString();
            CuentaDB objC = new CuentaDB();

            int numeroC = objC.cuentaE();
            if (numeroC == 0)
            {
                Frm_NuevoUsuario newUsu = new Frm_NuevoUsuario();
                newUsu.Show();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {lblHora.Text = DateTime.Now.ToLongTimeString();
            
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(120,80);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(100,72);
        }

        
    }
}
