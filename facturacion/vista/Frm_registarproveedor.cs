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
    public partial class Frm_registarproveedor : Form
    {
        public Frm_registarproveedor()
        {
            InitializeComponent();
        }
       
        int fila = -1;
        private void Frm_registarproveedor_Load(object sender, EventArgs e)
        {
            llenaempresa();
        }

        private void llenaempresa()
        {
          
            try
            {
                EmpresaDB objE = new EmpresaDB();
                objE.getEmpresa().ListaEmpresas= objE.TraeEmpresas();
                if (objE.getEmpresa().ListaEmpresas.Count == 0)
                {
                    MessageBox.Show("No existen registros de Categorias", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                comboBoxE. DisplayMember = "nombreEmpresa";
               comboBoxE. ValueMember = "idempresa";
                comboBoxE. DataSource = objE.getEmpresa().ListaEmpresas;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Al Presentar los Datos," + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       public int id_persona;
        string num;
        
        
        private void Adiciona()
        {
           
            try
            {

             PersonaDB objP = new PersonaDB();
             ProveedorDB objPro = new ProveedorDB();
              
                int resp=0;
                int resp1 = 0;
                
                objP.getPersona().Cedula = txtced.Text.Trim();
                objP.getPersona().Nombre = txtnom.Text.Trim();
                objP.getPersona().Apellido = txtape. Text.Trim();
                objP.getPersona().Direccion = txtdir. Text.Trim();
                objP.getPersona().Telefono = txttel. Text.Trim();

                objP.getPersona().Id_rol = int.Parse("3");
                objPro.getProveedor().Ruc = txtruc.Text.Trim();
                objPro.getProveedor().Idpersona= id_persona;

                //falta revisar esto
            //    string aux = comboBoxE.SelectedText ;

                objPro.getProveedor().IdEmpresa = objPro.traeidEmpresa(comboBoxE.Text.ToString());

                 resp = objP.InsertaCliente(objP.getPersona());
                   resp1 = objPro.InsertaProveedor(objPro.getProveedor());

                
                if (resp == 0||resp1==0)
                {
                    MessageBox.Show("No se ingreso datos de Proveedor", "Koreano-Chino", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
              if(resp==1&resp1==1)
                {
                    MessageBox.Show("Proveedor Ingresado", "Koreano-Chino", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 
            
                   
                   Utiles.limpiar(panel1.Controls);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Ingresar Datos," + ex.Message, "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }
       

        private void label5_Click(object sender, EventArgs e)
        {
            Frm_RegistroEmpresa empresa = new Frm_RegistroEmpresa();
            empresa.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PersonaDB objP = new PersonaDB();
            num = objP.traenumero();
            if (num.Equals(""))
            {
                id_persona = 1;
            }
            else
            {
                id_persona = Convert.ToInt32(num);
                id_persona++;
            }
            Adiciona();
        }
        int idempresa;
       
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
      
        
    }
}
