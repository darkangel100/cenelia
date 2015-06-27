using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using facturacion.controlador;

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
        string apellido;
        byte tipoC;
        private void txtbusacrproveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                tipoC = 0;
               Utiles.soloNumeros(sender, e,txtbusacrproveedor , 10);

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
                            llenaProveedor(apellido, tipoC);
                        }
                    }
                    else
                    {
                        apellido += letra;
                        llenaProveedor(apellido, tipoC);
                    }
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Solo Letras");
                }
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {

        }
        int fila;
        public void llenaProveedor(string est, byte tipoc)
        {
            try
            {
              dataGridView1. Rows.Clear();
               ProveedorDB objPro=new ProveedorDB();
                EmpresaDB objE =new EmpresaDB();
                if (tipoc == 0) {
 
                    objPro.getProveedor().ListaPersonas = objPro.TraeProveedoresC(est);
                    objPro.traeId();
                    objE.getEmpresa().ListaEmpresas = objE.TraeEmpresa();
                }
                else { objPro.getProveedor().ListaPersonas = objPro.Traeproveedores(est); }

                if (objPro.getProveedor().ListaPersonas.Count == 0)
                {
                    MessageBox.Show("No existen Clientes registrados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    fila = 0;
                    for (int i = 0; i < objPro.getProveedor().ListaPersonas.Count; i++)
                    {
                        dataGridView1. Rows.Add(1);
                        dataGridView1.Rows[i].Cells[0].Value = objPro.getProveedor().ListaPersonas[i].Cedula;
                       dataGridView1.Rows[i].Cells[1].Value = objPro.getProveedor().ListaPersonas[i].Apellido;
                        dataGridView1.Rows[i].Cells[2].Value = objPro.getProveedor().ListaPersonas[i].Nombre;
                        dataGridView1.Rows[i].Cells[3].Value = objPro.getProveedor().ListaPersonas[i].Direccion;
                        dataGridView1.Rows[i].Cells[4].Value = objPro.getProveedor().ListaPersonas[i].Telefono;
                        dataGridView1.Rows[i].Cells[5].Value = objPro.getProveedor().ListaPersonas[i].Estado;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Al Presentar los Datos," + ex.Message, "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frm_listarproveedor_Load(object sender, EventArgs e)
        {

        }

     
    }
}
