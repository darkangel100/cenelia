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
    public partial class Frm_NuevoUsuario : Form
    {
        public Frm_NuevoUsuario()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Adiciona()
        {
            try
            {

                PersonaDB objU = new PersonaDB();
                RolDB rol = new RolDB();
                CuentaDB objC = new CuentaDB();
                int resp;
                int resp2;
                objU.getPersona().Cedula = txtced.Text.Trim();
                objU.getPersona().Nombre = txtnom.Text.Trim();
                objU.getPersona().Apellido = txtape.Text.Trim();
                objU.getPersona().Direccion = txtdir.Text.Trim();
                objU.getPersona().Telefono = txttel.Text.Trim();
               
                    objU.getPersona().Id_rol = 2;

                objC.getCuenta().Usuario21 = txtusuario.Text.Trim();
                objC.getCuenta().Clave = txtcla.Text.Trim();
                objC.getCuenta().Id_per =1;
                resp = objU.InsertaCliente(objU.getPersona());
                resp2 = objC.ingresacuenta(objC.getCuenta());
                if (resp == 0 || resp2 == 0)
                {
                    MessageBox.Show("No se ingreso datos de Usuario", "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (resp == 1 && resp2 == 1)
                {
                    MessageBox.Show("Usuario Ingresado", "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Ingresar Datos," + ex.Message, "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuarda_Click(object sender, EventArgs e)
        {

            
            Adiciona();
            
            Close();
        }

        private void Frm_NuevoUsuario_Load(object sender, EventArgs e)
        {
            RolDB objR = new RolDB();
            objR.crearNuevosRoles();
        }
    }
}
