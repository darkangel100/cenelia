﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using facturacion.modelo;
using facturacion.controlador;

namespace facturacion.vista
{
 
 public partial  class Frm_RegisraClente : Form
    {
       public Frm_RegisraClente()
        {
            InitializeComponent();
        }
       

        private void pictureBox2_Click(object sender, EventArgs e)
        {


           if (Utiles.requerido(this.txt_cedula, errorProvider1) && Utiles.requerido(this.txt_apellido, errorProvider1) && Utiles.requerido(this.txt_nombre, errorProvider1) && Utiles.requerido(this.txt_direccion, errorProvider1))
            {
                Adiciona();
                Utiles.limpiar(panel1.Controls);
            }
            else
            {
                MessageBox.Show("Debe llenar los capos aque son obligatorios", "Koreano-Chino", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            
          
            
          
        }
        private void Adiciona()
        {
            try
            {
                PersonaDB objC = new PersonaDB();
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
                   // estado = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Ingresar Datos," + ex.Message, "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private PersonaDB llenaCliente(PersonaDB lec)
        {
            lec.getPersona().Cedula = txt_cedula .Text.Trim();
            lec.getPersona().Apellido = txt_apellido .Text.Trim();
            lec.getPersona().Nombre =txt_nombre .Text.Trim();
            lec.getPersona().Direccion = txt_direccion. Text.Trim();
            lec.getPersona().Telefono = txt_telefono. Text.Trim();
           // lec.getPersona().Estado = "A";
      
            
            return lec;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Frm_RegisraClente_Load(object sender, EventArgs e)
        {

        }
    }
}
