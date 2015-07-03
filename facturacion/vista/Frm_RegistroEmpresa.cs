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
    public partial class Frm_RegistroEmpresa : Form
    {
        public Frm_RegistroEmpresa()
        {
            InitializeComponent();
        }

        private void Frm_RegistroEmpresa_Load(object sender, EventArgs e)
        {
            llenaEmpresas();
        }
        int fila = 0;
        public void llenaEmpresas()
        {
            try
            {
                tbl_tabla. Rows.Clear();
               EmpresaDB objE = new EmpresaDB();
                objE.getEmpresa().ListaEmpresas = objE.TraeEmpresas();
                if (objE.getEmpresa().ListaEmpresas. Count == 0)
                {
                    MessageBox.Show("No existen Empresas Registradas", "Chino_Koreano", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    fila = 0;
                    for (int i = 0; i < objE.getEmpresa().ListaEmpresas.Count; i++)
                    {
                         tbl_tabla. Rows.Add(1);
                         tbl_tabla.Rows[i].Cells[0].Value = objE.getEmpresa().ListaEmpresas[i].NombreEmpresa;
                         tbl_tabla.Rows[i].Cells[1].Value = objE.getEmpresa().ListaEmpresas[i].Direccion;
                         tbl_tabla.Rows[i].Cells[2].Value = objE.getEmpresa().ListaEmpresas[i].Pais;
                         tbl_tabla.Rows[i].Cells[3].Value = objE.getEmpresa().ListaEmpresas[i].Telefono;
                         tbl_tabla.Rows[i].Cells[4].Value = objE.getEmpresa().ListaEmpresas[i].Estado;
                         tbl_tabla.Rows[i].Cells[5].Value = objE.getEmpresa().ListaEmpresas[i].IdEmpresa;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Al Presentar los Datos," + ex.Message, "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            
        }
        string estado = "";
        private void ptbguardar_Click(object sender, EventArgs e)
        {
             if (estado == "N")
            {
                Adiciona();
            }
             if (estado == "E")
             {
                 Editar();
             }
            Utiles.limpiar(groupBox1. Controls);
            groupBox1.Enabled = false;

            llenaEmpresas();
        }
        private void Adiciona()
        {
            try
            {
                EmpresaDB objE = new EmpresaDB();
                int resp;
                llenaEmpresa(objE);
                resp = objE.InsertaEmpresa(objE.getEmpresa());
                if (resp == 0)
                {
                    MessageBox.Show("No se ingreso datos de la Empresa", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Empresa Ingresada", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    estado = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Ingresar Datos," + ex.Message, "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }
        private EmpresaDB llenaEmpresa(EmpresaDB emp)
        {
            emp.getEmpresa().NombreEmpresa = textBox1.Text.Trim();
            emp.getEmpresa().Telefono = textBox2.Text.Trim();
            emp.getEmpresa().Direccion = textBox3.Text.Trim();
            emp.getEmpresa().Pais = textBox4.Text.Trim();
            emp.getEmpresa().IdEmpresa = int.Parse(tbl_tabla.Rows[fila].Cells[5].Value.ToString());
            
            if (rba.Checked == true)
                emp.getEmpresa().Estado = "A";
            else
                emp.getEmpresa().Estado = "P";
            return emp;
        }
        private void Editar()
        {
            try
            {
               EmpresaDB objE = new EmpresaDB();
                int resp;
                 llenaEmpresa (objE);
                resp = objE.ActualizaEmpresa(objE.getEmpresa());
                if (resp == 0)
                {
                    MessageBox.Show("No se modifico datos del Cliente", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Cliente Modificado", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    estado = "";
                    llenaEmpresas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Ingresar Datos," + ex.Message, "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbl_tabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila =tbl_tabla. CurrentRow.Index;
        }
        private void modificar()
        {
            try
            {
               EmpresaDB objE = new EmpresaDB();
               objE.setEmpresa(objE.TraeEmpresa(int.Parse(tbl_tabla.Rows[fila].Cells[5].Value.ToString())));
                if (objE.getEmpresa().IdEmpresa == 0)
                {
                    MessageBox.Show("No existe registro del Cliente", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    textBox1.Text = objE.getEmpresa().NombreEmpresa;
                    textBox2.Text = objE.getEmpresa().Telefono;
                    textBox3.Text = objE.getEmpresa().Direccion;
                    textBox4.Text = objE.getEmpresa().Pais;
                    
                    
                    if (objE.getEmpresa().Estado == "Activo")
                        rba.Checked = true;
                    else
                        rbp.Checked = true;
                    ptbguardar. Enabled = true;
                    estado = "E";
                   groupBox1. Enabled = true;
                  textBox1. Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al presentar los datos," + ex.Message, "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            modificar();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            estado = "";
            Utiles.limpiar(groupBox1. Controls);
           groupBox1. Enabled = false;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            estado = "N";
            groupBox1.Enabled = true;
            textBox1.Focus();
            ptbguardar.Enabled = true;
        }
    }
}
