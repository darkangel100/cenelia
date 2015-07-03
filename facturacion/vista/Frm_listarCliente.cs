using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;

using facturacion.controlador;

namespace facturacion.vista
{
    partial class Frm_listarCliente : Form
    {
       
        public Frm_listarCliente()
        {
            InitializeComponent();
           
        }
        string apellido;
        byte tipoC;
        private void txt_texto_KeyPress(object sender, KeyPressEventArgs e)
     {
         
            if (cbx_criterio.SelectedIndex==0)
            {
                tipoC = 0;
                Utiles.soloNumeros(sender, e, txt_texto, 10);
                
            }
            else
            {
                tipoC = 1;

                char letra = e.KeyChar;

                if ((letra >= 'a' & letra <= 'z') || (letra >= 'A' & letra <= 'Z') || letra == 8 || letra == 13)
                {
                    if (letra == 8)
                    {
                        if (apellido.Length > 0)
                        {
                            apellido = apellido.Remove(apellido.Length - 1);
                            llenaClientes(apellido,tipoC);
                        }                 
                    }
                    else
                    {
apellido += letra;
                    llenaClientes(apellido,tipoC);
                    }
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Solo Letras");
                }
            }
        }

       
        int fila = 0;
     public void   llenaClientes(string est, byte tipoc)
        {
            try
            {
                tbl_tabla .Rows.Clear();
                PersonaDB objP = new PersonaDB();
                if (tipoc == 0) { objP.getPersona().ListaPersonas = objP.TraePersonasC(est); }     
                else {  objP.getPersona().ListaPersonas = objP.TraePersonas(est);  }

                if (objP.getPersona().ListaPersonas.Count == 0)
                {
                    MessageBox.Show("No existen Clientes registrados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    fila = 0;
                    for (int i = 0; i < objP.getPersona().ListaPersonas.Count; i++)
                    {
                        tbl_tabla. Rows.Add(1);
                        tbl_tabla.Rows[i].Cells[0].Value = objP.getPersona().ListaPersonas[i].Cedula;
                        tbl_tabla.Rows[i].Cells[1].Value = objP.getPersona().ListaPersonas[i].Apellido;
                        tbl_tabla.Rows[i].Cells[2].Value = objP.getPersona().ListaPersonas[i].Nombre;
                        tbl_tabla.Rows[i].Cells[3].Value = objP.getPersona().ListaPersonas[i].Direccion;
                        tbl_tabla.Rows[i].Cells[4].Value = objP.getPersona().ListaPersonas[i].Telefono;
                        tbl_tabla.Rows[i].Cells[5].Value = objP.getPersona().ListaPersonas[i].Estado;
                       
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Al Presentar los Datos," + ex.Message, "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }

     
     private void cbx_criterio_SelectedIndexChanged(object sender, EventArgs e)
     {
         if (cbx_criterio. SelectedIndex >-1)
         {
             txt_texto.Enabled = true;
             txt_texto.Focus();
         }
         if (cbx_criterio.SelectedIndex==0)
         {
             txt_texto.Text = "";
             tbl_tabla.Rows.Clear();
             pictureBox2.Enabled = true;
         }
         if (cbx_criterio.SelectedIndex==1)
         {
             txt_texto.Text = "";
             tbl_tabla.Rows.Clear();
             pictureBox2.Enabled = false;
         }
     }

     private void pictureBox2_Click(object sender, EventArgs e)
     {
         llenaClientes(txt_texto.Text, tipoC);
     }

     private void tbl_tabla_CellClick(object sender, DataGridViewCellEventArgs e)
     {
         fila=tbl_tabla.CurrentRow.Index;
     }

     private void pictureBox1_Click(object sender, EventArgs e)
     {
         modificar();
     }
     private void modificar()
     {
         try
         {
             PersonaDB objP = new PersonaDB();
             objP.setPersona(objP.TraePersona(tbl_tabla. Rows[fila].Cells[0].Value.ToString()));
             if (objP.getPersona().Cedula == "")
             {
                 MessageBox.Show("No existe registro del Cliente", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
             }
             else
             {
                 txt_cedula. Text = objP.getPersona().Cedula;
                 txt_apellido. Text = objP.getPersona().Apellido;
                 txt_nombre .Text= objP.getPersona().Nombre;
                 txt_direccion .Text= objP.getPersona().Direccion;
                 txt_telefono.Text= objP.getPersona().Telefono;
                 if (objP.getPersona().Estado == "A")
                     rba.Checked = true;
                 else
                     rbp.Checked = true;
              ptbguardar. Enabled = true;
              txt_cedula.Enabled = false;
                 groupBox2. Enabled = true;
                 txt_apellido. Focus();
             }
         }
         catch (Exception ex)
         {
             MessageBox.Show("Error al presentar los datos," + ex.Message, "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
     }

     private void ptbguardar_Click(object sender, EventArgs e)
     { 
             Editar();
         
         Utiles.limpiar(groupBox2. Controls);
         tbl_tabla.Rows.Clear();
         llenaClientes(txt_texto.Text.ToString(), tipoC);
         groupBox2.Enabled = false;
     }
           private void Editar()
        {
            try
            {
                PersonaDB objC = new PersonaDB();
                int resp;
                llenaCliente(objC);
                resp = objC.ActualizaCliente(objC.getPersona());
                if (resp == 0)
                {
                    MessageBox.Show("No se modifico datos del Cliente", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Cliente Modificado", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Ingresar Datos," + ex.Message, "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
           private PersonaDB llenaCliente(PersonaDB lec)
           {
               lec.getPersona().Cedula = txt_cedula. Text.Trim();
               lec.getPersona().Apellido =txt_apellido. Text.Trim();
               lec.getPersona().Nombre=txt_nombre. Text.Trim();
               lec.getPersona().Direccion = txt_direccion. Text.Trim();
               lec.getPersona().Telefono =txt_telefono.Text. Trim();
               if (rba.Checked == true)
                   lec.getPersona().Estado = "Activo";
               else
                   lec.getPersona().Estado = "Pasivo";
               return lec;
           }

           private void pictureBox4_Click(object sender, EventArgs e)
           {
               Utiles.limpiar(groupBox2.Controls);
               groupBox2.Enabled = false;
           }

           private void txt_texto_TextChanged(object sender, EventArgs e)
           {

           }

           
    }
}
