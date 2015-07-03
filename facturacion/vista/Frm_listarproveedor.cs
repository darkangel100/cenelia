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
                dataGridView1.Rows.Clear();
            }
            if (comboBox1.SelectedIndex == 0)
            {
                txtbusacrproveedor.Text = "";
                dataGridView1.Rows.Clear();
                pictureBox4.Enabled = true;

            }
            if (comboBox1.SelectedIndex == 1)
            {
                txtbusacrproveedor.Text = "";
                dataGridView1.Rows.Clear();
                pictureBox4.Enabled = false;
            }
        }//Cambiar criterio de busqueda
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
        }//keyyy press buscar proveedores

        
        int fila;
        public void llenaProveedor(string est, byte tipoc)
        {
            try
            {
              dataGridView1. Rows.Clear();
               ProveedorDB objPro=new ProveedorDB();
                PersonaDB objper=new PersonaDB();
                EmpresaDB objE =new EmpresaDB();
                if (tipoc == 0) {
 
                    objper.getPersona().ListaPersonas = objPro.TraeProveedoresC(est);
                    objPro.getProveedor().ListaProveedorT = objPro.Tablaproveedor();
                    objE.getEmpresa().ListaEmpresas = objE.TraeEmpresas();
                }
                else 
                { 
                    objper.getPersona().ListaPersonas = objPro.Traeproveedores(est);
                    //objP.setPersona(objP.TraePersona(tbl_tabla.Rows[fila].Cells[0].Value.ToString()));
                    objPro.getProveedor().ListaProveedorT=objPro.Tablaproveedor();
                    objE.getEmpresa().ListaEmpresas = objE.TraeEmpresas();
                    //objPro.traeId(dataGridView1.Rows[fila].Cells[6].Value.ToString());
                     
                }

                if (objper.getPersona().ListaPersonas.Count == 0)
                {
                    MessageBox.Show("No existen Proveedores Registrados", "Koreano_Chino", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    fila = 0;
                    for (int i = 0; i < objper.getPersona().ListaPersonas.Count; i++)
                    {
                        dataGridView1. Rows.Add(1);
                        dataGridView1.Rows[i].Cells[0].Value = objper.getPersona().ListaPersonas[i].Cedula;
                       dataGridView1.Rows[i].Cells[1].Value = objper.getPersona().ListaPersonas[i].Apellido;
                        dataGridView1.Rows[i].Cells[2].Value = objper.getPersona().ListaPersonas[i].Nombre;
                        dataGridView1.Rows[i].Cells[3].Value = objper.getPersona().ListaPersonas[i].Direccion;
                        dataGridView1.Rows[i].Cells[4].Value = objper.getPersona().ListaPersonas[i].Telefono;
                        dataGridView1.Rows[i].Cells[5].Value =objper.getPersona().ListaPersonas[i].Estado;
                        dataGridView1.Rows[i].Cells[8].Value = objPro.getProveedor().ListaProveedorT[i].IdEmpresa;
                        string nombre = objE.TraeEmpresanombre(int.Parse(dataGridView1.Rows[i].Cells[8].Value.ToString()));
                     //   objE. setEmpresa(objE.TraeEmpresa(int.Parse(dataGridView1.Rows[fila].Cells[8].Value.ToString())));
                        dataGridView1.Rows[i].Cells[6].Value = nombre;
                        dataGridView1.Rows[i].Cells[7].Value = objper.getPersona().ListaPersonas[i].Id_persona;
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Al Presentar los Datos," + ex.Message, "Koreano-Chino", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//trae los proveedores

       

        private void pictureBox1_Click(object sender, EventArgs e)//modificar
        {
            groupBox2.Enabled = true;
            modificar();
            llenaempresa();
        }
        private void llenaempresa()
        {

            try
            {
                EmpresaDB objE = new EmpresaDB();
                objE.getEmpresa().ListaEmpresas = objE.TraeEmpresas();
                if (objE.getEmpresa().ListaEmpresas.Count == 0)
                {
                    MessageBox.Show("No existen registros de Categorias", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                comboBox2.DisplayMember = "nombreEmpresa";
                comboBox2.ValueMember = "idempresa";
                comboBox2.DataSource = objE.getEmpresa().ListaEmpresas;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Al Presentar los Datos," + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//llena  empresas combobox
        private void modificar()
        {
            try
            {
                PersonaDB objP = new PersonaDB();
                EmpresaDB objE= new EmpresaDB();
                objP.setPersona(objP.TraePersonaP(dataGridView1.Rows[fila].Cells[0].Value.ToString()));
                if (objP.getPersona().Cedula == "")
                {
                    MessageBox.Show("No existe registro del Proveedor", "Koreano-Chino", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    txtcedula.Text = objP.getPersona().Cedula;
                    txtapellido.Text = objP.getPersona().Apellido;
                    txtNombre.Text = objP.getPersona().Nombre;
                    txtdireccion.Text = objP.getPersona().Direccion;
                    txtTelefono.Text = objP.getPersona().Telefono;
                    if (objP.getPersona().Estado == "A")
                        rba.Checked = true;
                    else
                        rbp.Checked = true;
                    
                    txtcedula.Enabled = false;
                    groupBox2.Enabled = true;
                    txtapellido.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al presentar los datos," + ex.Message, "Koreano-Chino", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//metodo modificar
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = dataGridView1. CurrentRow.Index;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            Editar();

            Utiles.limpiar(groupBox2.Controls);
            
            groupBox2.Enabled = false;
            llenaProveedor(txtbusacrproveedor.Text.ToString(), tipoC);


        }//guardar modificaciones
        private void Editar()//meto para modificar proveedor
        {
            try
            {
                PersonaDB objC = new PersonaDB();
                ProveedorDB objPro = new ProveedorDB();
                int resp;
               int resp2;
                llenaCliente(objC);
                llenaproveedor(objPro);
                resp = objC.ActualizaCliente(objC.getPersona());
                resp2 = objPro.Actualizaprovedor(objPro.getProveedor());

                if (resp == 0)
                {
                    MessageBox.Show("No se modifico datos del Proveedor", "Koreano-Chino", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Proveedor Modificado", "Koreano-Chino", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Ingresar Datos," + ex.Message, "Koreano-Chino", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private PersonaDB llenaCliente(PersonaDB lec) //llena los datos a un objeto de tipo cliente
        {
            ProveedorDB objpro = new ProveedorDB();
            lec.getPersona().Cedula = txtcedula. Text.Trim();
            lec.getPersona().Apellido = txtapellido.Text.Trim();
            lec.getPersona().Nombre = txtNombre. Text.Trim();
            lec.getPersona().Direccion = txtdireccion.Text.Trim();
            lec.getPersona().Telefono = txtTelefono.Text.Trim();
            if (rba.Checked == true)
                lec.getPersona().Estado = "Activo";
            else
                lec.getPersona().Estado = "Pasivo";
            return lec;
            

        }
        private ProveedorDB llenaproveedor(ProveedorDB pro)
        {
pro.getProveedor().Idpersona = pro.traeidPersona(txtcedula.Text.ToString());
            pro.getProveedor().IdEmpresa =pro.traeidEmpresa(comboBox2.Text.ToString());
            return pro;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            llenaProveedor( txtbusacrproveedor.Text.ToString(), tipoC);
        }//busqueda por cedula

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Close();
        }//cerrar ventana

        private void pictureBox3_Click(object sender, EventArgs e)//cancekar modificacion
        {
            Utiles.limpiar(groupBox2.Controls);
            groupBox2.Enabled = false;
        }
        
    }
}
