using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using facturacion.vista.modeloTabla;
using facturacion.controlador;

namespace facturacion.vista
{
    partial class frm_listarProducto : Form
    {
        private ModeloTablaProducto modelo = new ModeloTablaProducto();
        private AccesoProducto ap = new AccesoProducto();
        public frm_listarProducto()
        {
            InitializeComponent();
            this.cargarProducto();
        }

       
        public void cargarProducto()
        {
            this.modelo.Tabla = this.tbl_tabla;
            this.modelo.Lista = this.ap.listar();
            this.modelo.llenarTabla();
            this.tbl_tabla.Update();
        }
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (cbx_criterio.Text.Equals("Todos"))
            {
                this.cargarProducto();
            }
            else
            {
                //this.modelo.Tabla = this.tbl_tabla;
                this.modelo.Lista = this.ap.buscar(cbx_criterio.Text,txt_texto.Text);
                this.modelo.llenarTabla();
                this.tbl_tabla.Update();
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            AccesoProducto ac1 = this.rescatarObjeto();

            if (ac1 != null)
            {
                new Frm_Producto(ac1, this).ShowDialog();
            }
        }
        private AccesoProducto rescatarObjeto()
        {
            int aux = this.modelo.Lista.Count;
            AccesoProducto ac1 = null;
            if (aux > 0)
            {
                ac1 = new AccesoProducto();
                ac1.setProducto((facturacion.modelo.Producto)this.tbl_tabla.CurrentRow.DataBoundItem);
            }
            return ac1;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        
    }
}
