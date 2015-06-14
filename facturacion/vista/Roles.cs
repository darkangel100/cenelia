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
    public partial class Roles : Form
    {
        public Roles()
        {
            InitializeComponent();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            Adiciona();
        }
        private void MscRol_Load(object sender, EventArgs e)
        {
            llenaRoles("A");
            genId();
        }
        public void Adiciona()
        {
            try
            {
                RolDB objro = new RolDB();
                int resp;
                objro.getrol().Id_rol = Convert.ToInt32(txtidrol.Text.Trim());
                objro.getrol().Nombre = txtnomrol.Text.Trim();
                

                resp = objro.insertarol(objro.getrol());
                if (resp == 0)
                {
                    MessageBox.Show("No se ingresaron datos", "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Rol Ingresado", "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar datos," + ex.Message, "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void llenaRoles(string est)
        {
            try
            {
                RolDB objR = new RolDB();
                objR.getrol().ListaRol = objR.TraeRoles(est);
                if (objR.getrol().ListaRol.Count == 0)
                {
                    MessageBox.Show("No hay registro de Roles", "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                lstroles.DisplayMember = "Nombre";
                lstroles.ValueMember = "Nombre";
                lstroles.DataSource = objR.getrol().ListaRol;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al presentar datos," + ex.Message, "Productos y Servicios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void genId()
        {
            int nro;
            RolDB objr = new RolDB();
            nro = objr.traeid();
            txtidrol.Text = Utiles.generarid(nro).ToString();
        }

        
    }
}
