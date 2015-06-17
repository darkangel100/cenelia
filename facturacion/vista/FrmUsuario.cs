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
        //private void tp1_Click(object sender, EventArgs e)
        //{

        //}

        //private void btnNuevo_Click(object sender, EventArgs e)
        //{
        //    estado = "N";
        //    panel1.Enabled = true;
        //    Utiles.limpiar(tc1.Controls);
        //    indice = 1;
        //    tc1.SelectTab(indice);
        //    txtced.Enabled = true;
        //    txtced.Focus();
        //}

        //private void FrmUsuario_Load(object sender, EventArgs e)
        //{
        //    llenaRol(comboBox1);
        //    llenaUsuarioLista();
           
        //}

        //private void llenaRol(ComboBox cbo)
        //{
        //    try
        //    {
        //        RolDB objC = new RolDB();
        //        objC.getRol().ListaRol = objC.TraeRol();
        //        if (objC.getRol().ListaRol.Count == 0)
        //        {
        //            MessageBox.Show("No existen de Usuarios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //        }
        //    comboBox1. DisplayMember = "nombre";
        //  comboBox1. ValueMember = "idrol";
        //        cbo.DataSource = objC.getRol().ListaRol;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error Al Presentar los Datos," + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void llenar()
        //{

        //    try
        //    {
        //PersonaDB objusu = new PersonaDB();
        //        int resp;
        //        int resc;
        //        llenaUsuario(objusu);
        //        resp = objusu.InsertaCliente(objusu.getPersona());
        //     CuentaDB objc = new CuentaDB();
        //        llenacamcuen(objc);
        //        resc = objc.ingresacuenta(objc.getCuenta());

        //        if (resp == 0)
        //        {
        //            MessageBox.Show("No se ingresaron datos del Usuario", "USUARIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //        }
        //        else
        //        {
        //            MessageBox.Show("Usuario ingresado correctamente","USUARIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //           // estado = "";
        //           // LimpiarCampos();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error al Ingresar datos," + ex.Message, "USUARIO", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        //    }
        //}
        //private PersonaDB llenaUsuario(PersonaDB per)
        //{
        //    RolDB r = new RolDB();
        //    UsuarioDB U = new UsuarioDB();
        //    per.getPersona().Cedula = txtced .Text.Trim();
        //    per.getPersona().Apellido = txtape. Text.Trim();
        //    per.getPersona().Nombre= txtnom. Text.Trim();
        //    per.getPersona().Direccion =txtdir .Text.Trim();
        //    per.getPersona().Telefono =txttel. Text.Trim();

        //    if (rba. Checked == true)
        //        per.getPersona().Estado = "A";
        //    else
        //        per.getPersona().Estado = "D";
            
        //    per.getPersona().Usuario.clausu= txtcla.Text.Trim();
        //    per.getPersona().Id_persona = r. traeId(comboBox1.SelectedValue.ToString());

        //    return per;
        //}
        //private CuentaDB llenacamcuen(CuentaDB cuen)
        //{

        //    cuen.getCuenta().Clave = txtcla.Text.Trim();
        //    cuen.getCuenta().Usuario21 = txtnom.Text.Trim();
        //    if (rba.Checked == true)
        //        cuen.getCuenta().Estado = "A";
        //    else
        //        cuen.getCuenta().Estado = "D";
        //    return cuen;
        //}

        private void btnGuarda_Click(object sender, EventArgs e)
        {
            //llenar();
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
        
    }
}
