using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using facturacion.controlador;

namespace facturacion.vista
{
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }
        string estado = "";
        int indice = 0;
     
        Utiles util = new Utiles();
        private void btnGuarda_Click(object sender, EventArgs e)
        {
            PersonaDB objp = new PersonaDB();
            if (estado == "N")
            {
                num = objp.traenumero();
                if (num.Equals(""))
                {
                    id_persona = 1;
                }
                else
                {
                    id_persona = Convert.ToInt32(num);
                    id_persona++;
                }
            }
            if (estado == "N")
            {
              

               Adiciona();
                  
                
            }
            if (estado == "E")
            {
                editar();
            }
            Utiles.limpiar(panel1.Controls);
            indice = 0;
            tc1.SelectTab(indice);

        }
        private void Adiciona()
        {
            try
            {

               PersonaDB objU = new PersonaDB();
                RolDB rol=new  RolDB();
                CuentaDB objC = new CuentaDB();
                int resp;
                int resp2;
                objU.getPersona().Cedula = txtced.Text.Trim();
                objU.getPersona().Nombre = txtnom.Text.Trim();
                objU.getPersona().Apellido = txtape. Text.Trim();
                objU.getPersona().Direccion = txtdir. Text.Trim();
                objU.getPersona().Telefono = txttel. Text.Trim();
                if (comboBox1.SelectedIndex == 0)
                {
                    objU.getPersona().Id_rol= objU.traeId("vendedor");

                }
                else
                {
                    objU.getPersona().Id_rol = objU.traeId("administrador");

                }

                objC.getCuenta().Usuario21 = txtusuario.Text.Trim();
                objC.getCuenta().Clave =txtcla. Text.Trim();
                objC.getCuenta().Id_per= id_persona;
                resp = objU.InsertaCliente(objU.getPersona());
                resp2 = objC.ingresacuenta(objC.getCuenta());
                if (resp == 0||resp2==0)
                {
                    MessageBox.Show("No se ingreso datos de Usuario", "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
              if(resp==1&&resp2==1)
                {
                    MessageBox.Show("Usuario Ingresado", "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 
                    estado = "";
                   llenausuario();
                   Utiles.limpiar(tc1.Controls);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Ingresar Datos," + ex.Message, "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cargarol(string est)
        {
            try
            {

                RolDB objr = new RolDB();
                objr.getRol().ListaRol = objr.TraeRol();
                if (objr.getRol().ListaRol.Count == 0)
                {
                    MessageBox.Show("No existen usuarios registrados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
              comboBox1. DisplayMember = "Nombre";
              comboBox1.ValueMember = "Nombre";
               comboBox1. DataSource = objr.getRol().ListaRol;
              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al presentar datos," + ex.Message, "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
      
        private void tc1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tc1.SelectTab(indice);
        }
        string num;
        int id_persona;
        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            
            llenaRol(comboBox1);
            llenausuario();

        }
        public void llenausuario()
        {
            try
            {
               UsuarioDB objU = new UsuarioDB();
               objU.getUsuario().ListaPersonas = objU.Traeusuarios(); ;
                if (objU.getUsuario().ListaPersonas.Count == 0)
                {
                    MessageBox.Show("No existen registros de usuarios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
              lstusu. DisplayMember = "nombre"; // esta relacionado a los nombres
              lstusu.ValueMember = "Id_persona"; // el id que esta relacionado con el usuario
              lstusu.DataSource = objU.getUsuario().ListaPersonas; // el contenido de la lista 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Al Presentar los Datos," + ex.Message, "VENTAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            estado = "N";
            panel1.Enabled = true;
            Utiles.limpiar(tc1.Controls);
            indice = 1;
            tc1.SelectTab(indice);
            txtced.Enabled = true;
            txtced.Focus();
        }
        private void llenaRol(ComboBox cbo)
        {
            try
            {
                RolDB objC = new RolDB();
                objC.getRol().ListaRol = objC.TraeRol();
                if (objC.getRol().ListaRol.Count == 0)
                {
                    MessageBox.Show("No existen de Usuarios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                comboBox1.DisplayMember = "nombre";
                comboBox1.ValueMember = "idrol";
                cbo.DataSource = objC.getRol().ListaRol;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Al Presentar los Datos," + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtced_KeyPress(object sender, KeyPressEventArgs e)
       {
            
          //  Utiles.validacedula(txtced, e);
        }
        private void editar()
        {
            try
            {////////////////////////////////////////////////////////
                PersonaDB objB = new PersonaDB();
                CuentaDB objC = new CuentaDB();
                int resp;
                int resp1=0;
                objB.getPersona().Cedula = txtced.Text;
                objC.getCuenta().Id_persona =int.Parse( lstusu.SelectedValue.ToString());
                llenapersona(objB);
                llenacuenta(objC);
                resp = objB.ActualizaCliente(objB.getPersona());
                resp1 = objC.ActualizaCuenta(objC.getCuenta());

                if ((resp == 0)||(resp1==0))
                {
                    MessageBox.Show("No se modifico datos del Usuario", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
             if(resp==1&&resp1==1)
                {
                    MessageBox.Show("Usuario Modificado", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    estado = "";
                    llenausuario();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Ingresar Datos," + ex.Message, "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdita_Click(object sender, EventArgs e)
        {
            modificar();
        }
        
        private void modificar()
        {
            try
            {
                PersonaDB objB = new PersonaDB();
                CuentaDB objC = new CuentaDB();
                objB.setPersona(objB.TraePersona(int.Parse( lstusu.SelectedValue.ToString())));
                objC.setCuenta(objC.Traecuenta((lstusu.SelectedValue.ToString())));
                if (objB.getPersona().Cedula == "")
                {
                    MessageBox.Show("No existe registro del Usuario", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    txtced.Text = objB.getPersona().Cedula;
                    txtape.Text = objB.getPersona().Apellido;
                    txtnom.Text = objB.getPersona().Nombre;
                    txtdir.Text = objB.getPersona().Direccion;
                    txttel.Text = objB.getPersona().Telefono;
                    if (objB.getPersona().Estado.Equals("Activo"))
                        rba.Checked = true;
                    else
                        rbp.Checked = true;
                    txtcla.Text = objC.getCuenta().Clave;
                    txtusuario.Text = objC.getCuenta().Usuario21;
                    btnGuarda.Enabled = true;
                    txtced.Enabled = false;
                    estado = "E";
                    panel1.Enabled = true;
                    indice = 1;
                    tc1.SelectTab(indice);
                    txtape.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al presentar los datos," + ex.Message, "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private PersonaDB llenapersona(PersonaDB usu)
        {
           
           usu.getPersona().Cedula = txtced.Text.Trim();
            usu.getPersona().Nombre = txtnom.Text.Trim();
            usu.getPersona().Apellido = txtape.Text.Trim();
            usu.getPersona().Direccion = txtdir.Text.Trim();
            usu.getPersona().Telefono = txttel.Text.Trim();
            if (comboBox1.SelectedIndex == 0)
            {
                usu.getPersona().Id_rol = usu.traeId("vendedor");

            }
            else
            {
                usu.getPersona().Id_rol = usu.traeId("administrador");

            }

            return usu;
        }
        private CuentaDB llenacuenta(CuentaDB cuen)
        {
            PersonaDB objp = new PersonaDB();
            cuen.getCuenta().Usuario21 = txtusuario.Text.Trim();
           cuen.getCuenta().Clave = txtcla.Text.Trim();
           cuen.getCuenta().Id_per =int.Parse(lstusu.SelectedValue.ToString());
            return cuen;
        }

        private void btnEdita_Click_1(object sender, EventArgs e)
        {
            modificar();
        }

        private void btnSal_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            estado = "";
            Utiles .limpiar(tc1.Controls);
            panel1.Enabled = false;
            indice = 0;
            tc1.SelectTab(indice);
        }
    }
}
