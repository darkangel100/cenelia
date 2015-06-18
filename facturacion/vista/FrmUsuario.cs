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
            if (estado == "N")
            {
              

               Adiciona();
                    Utiles.limpiar(tc1.Controls);
                
            }
            if (estado == "E")
            {
                //editar();
            }
        }
        private void Adiciona()
        {
            try
            {

               PersonaDB objU = new PersonaDB();
                RolDB rol=new  RolDB();
                CuentaDB objC = new CuentaDB();
                int resp;
                objU.getPersona().Cedula = txtced.Text.Trim();
                objU.getPersona().Nombre = txtnom.Text.Trim();
                objU.getPersona().Apellido = txtape. Text.Trim();
                objU.getPersona().Direccion = txtdir. Text.Trim();
                objU.getPersona().Telefono = txttel. Text.Trim();
              //  objU.getPersona().Estado = "Activo";
               
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
                resp = objC.ingresacuenta(objC.getCuenta());
                if (resp == 0)
                {
                    MessageBox.Show("No se ingreso datos de Usuario", "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
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
              lstusu.ValueMember = "cedula"; // el id que esta relacionado con el usuario
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
            
            Utiles.validacedula(txtced, e);
        }
    }
}
