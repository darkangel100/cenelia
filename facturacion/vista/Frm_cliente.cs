﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using facturacion.controlador;

namespace facturacion.vista
{
    partial class Frm_cliente : Form
    {
        private AccesoCliente ac = new AccesoCliente();
        private Frm_listarCliente flc = null;
        private int accion = 0;//0 guadar 1 modificar
        private Frm_factura frm_factura = null;
        public Frm_cliente(Frm_factura frm)
        {
            InitializeComponent();
            this.frm_factura = frm;
        }
        public Frm_cliente()
        {
            InitializeComponent();            
        }
        public Frm_cliente(AccesoCliente ac, Frm_listarCliente flc)
        {
            InitializeComponent();
            this.ac = ac;
            this.flc = flc;
            this.accion = 1;
            this.label1.Text = "EDITAR CLIENTE";
            this.llenarFormulario();
        }
        private void llenarFormulario()
        {
            this.txt_apellido.Text = this.ac.getCliente().Apellido;
            this.txt_cedula.Text = this.ac.getCliente().Cedula;
            this.txt_nombre.Text = this.ac.getCliente().Nombre;
            this.txt_celular.Text = this.ac.getCliente().Celular;
            this.txt_direccion.Text = this.ac.getCliente().Direccion.Barrio;
            this.txt_telefono.Text = this.ac.getCliente().Telefono;
            
        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            if (Utiles.requerido(this.txt_cedula, errorProvider1) && Utiles.requerido(this.txt_apellido, errorProvider1) && Utiles.requerido(this.txt_nombre, errorProvider1) && Utiles.requerido(this.txt_telefono, errorProvider1) && Utiles.requerido(this.txt_celular, errorProvider1))
            {
                if(Utiles.min(this.txt_cedula,10,errorProvider1)==true){

                    this.cargarObjeto();
                    if(this.accion == 0)
                    {
                        if (ac.guardar(ac.getCliente()) == true)
                        {
                            MessageBox.Show("Se ha registrado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if(this.frm_factura!=null)
                            {
                                this.frm_factura.setAccesoCliente(ac);
                                this.frm_factura.cargarDatosCliente();
                            }
                            this.Dispose();
                        }
                        else
                        {
                            MessageBox.Show("No se ha registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }else if(this.accion==1)
                    {
                        //modificar
                        if (ac.modificar(ac.getCliente()) == true)
                        {
                            MessageBox.Show("Se ha editado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.flc.cargarTabla();
                            this.Dispose();
                        }
                        else
                        {
                            MessageBox.Show("No se ha editado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void cargarObjeto()
        {
            ac.getCliente().Apellido = this.txt_apellido.Text;
            ac.getCliente().Cedula = this.txt_cedula.Text;
            ac.getCliente().Nombre = this.txt_nombre.Text;
            ac.getCliente().Celular = this.txt_celular.Text;
            ac.getCliente().Telefono = this.txt_telefono.Text;
            if(this.accion == 0)
            {
                ac.getCliente().Id_persona = ac.generarId();
                ac.getCliente().Direccion.Id_direccion = ac.generarId();
            }
            ac.getCliente().Direccion.Barrio = this.txt_direccion.Text;
            ac.getCliente().Direccion.Persona = ac.getCliente();
            ac.getCliente().Direccion = ac.getCliente().Direccion;
        }

        private void txt_cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
          
            Utiles.validacedula(txt_cedula, e, txt_apellido);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utiles.soloNumeros(sender, e, this.txt_telefono, 10);
        }

        private void txt_celular_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utiles.soloNumeros(sender, e, this.txt_celular, 10);
        }

        private void txt_apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utiles.soloLetras(sender, e, this.txt_celular, 0);
        }

        private void Frm_cliente_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

      
    }
}
