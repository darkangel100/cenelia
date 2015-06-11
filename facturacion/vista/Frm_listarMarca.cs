using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using facturacion.controlador;

namespace facturacion.vista
{
    partial class Frm_listarMarca : Form
    {
        private AccesoMarca ac = new AccesoMarca();
        public Frm_listarMarca()
        {
            InitializeComponent();
            this.cargarLista();
        }
        public void cargarLista()
        {
            this.list_marca.DataSource = ac.listar();
        }
        

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string critecro = cbx_criiterio.Text;

            if (critecro.Equals("Todos"))
            {
                this.cargarLista();
            }
            else
            {
                this.list_marca.DataSource = ac.buscar(critecro, txt_marca.Text);
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            AccesoMarca am1 = this.rescatarObjeto();
            if(am1!=null)
            {
                new Frm_marca(am1,this).ShowDialog();
            }
        }
        private AccesoMarca rescatarObjeto()
        {
            int aux = this.ac.listar().Count;
            AccesoMarca ac1 = null;
            if (aux > 0)
            {
                ac1 = new AccesoMarca();
                ac1.setMarca((facturacion.modelo.Marca)this.list_marca.SelectedItem);//tbl_tabla.CurrentRow.DataBoundItem);
            }
            return ac1;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Frm_listarMarca_Load(object sender, EventArgs e)
        {

        }
    }
}
