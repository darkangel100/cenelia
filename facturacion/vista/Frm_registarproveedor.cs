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
       private string estado = "";
        int fila = -1;
        private void Frm_registarproveedor_Load(object sender, EventArgs e)
        {
            label8.BackColor = Color.Transparent;
            groupBox1.BackColor = Color.Transparent;
        }

        //private void btnguardar_Click(object sender, EventArgs e)
        //{
        //    if (estado == "N")
        //    {
        //        Adiciona();
        //    }
        //    if (estado == "E")
        //    {
        //        Editar();
        //    }
        //    Utiles.limpiar(panel1.Controls);
        //    panel1.Enabled = false;
        //    //chkeliminados.Checked = false;
        //    llenaClientes("A");
        //}
        private void Adiciona()
        {
            try
            {
                ClienteDB objC = new ClienteDB();
                int resp;
                llenaCliente(objC);
                resp = objC.InsertaCliente(objC.getPersona());
                if (resp == 0)
                {
                    MessageBox.Show("No se ingreso datos del Cliente", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Cliente Ingresado", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    estado = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Ingresar Datos," + ex.Message, "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Editar()
        {
            try
            {
                ProveedorDB  objP = new ProveedorDB();
                int resp;
                llenaCliente(objC);
                resp = objP.ActualizaCliente(objP.getPersona());
                if (resp == 0)
                {
                    MessageBox.Show("No se modifico datos del Cliente", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Cliente Modificado", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    estado = "";
                    llenaClientes("A");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Ingresar Datos," + ex.Message, "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private ProveedorDB llenaCliente(ProveedorDB lec)
        {
            lec.getPersona().Cedula = txtced.Text.Trim();
            lec.getPersona().Apellido = txtape.Text.Trim();
            lec.getPersona().Nombre = txtnom.Text.Trim();
            lec.getPersona().Direccion = txtdir.Text.Trim();
            lec.getPersona().Telefono= txttel.Text.Trim();
           
            if (radioButton1. Checked == true)
                lec.getPersona().Estado = "A";
            else
                lec.getPersona().Estado = "P";
            return lec;
        }
      
        
    }
}
