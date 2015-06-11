using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using facturacion.controlador;

namespace facturacion.vista
{
    partial class Frm_marca : Form
    {
        private AccesoMarca am = new AccesoMarca();
        private Frm_listarMarca flm=null;
        private int accion = 0;
        public Frm_marca()
        {
            InitializeComponent();          
        }
        public Frm_marca(AccesoMarca am,Frm_listarMarca flm)
        {
            InitializeComponent();
            this.am = am;
            this.flm = flm;
            this.cargarVista();
            this.accion = 1;
        }
       
        private void cargarVista()
        {
            this.txt_nombre.Text = this.am.getMarca().Nombre;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if(Utiles.requerido(this.txt_nombre,errorProvider1)==true)
            {
                this.cargarObjeto();
                if (this.accion == 0)
                {
                    if (this.am.guardar(this.am.getMarca()) == true)
                    {
                        MessageBox.Show("Se ha registrado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("No se ha registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (this.am.modificar(this.am.getMarca()) == true)
                    {
                        MessageBox.Show("Se ha modificado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.flm.cargarLista();
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("No se ha modificado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void cargarObjeto()
        {
            this.am.getMarca().Nombre = this.txt_nombre.Text.ToUpper();
            if(this.accion==0){
                this.am.getMarca().Id_marca = this.am.generarId();
            }
        }
    }
}
