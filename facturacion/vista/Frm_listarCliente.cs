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
    partial class Frm_listarCliente : Form
    {
        private ModeloTablaCliente modelo = new ModeloTablaCliente();
        private AccesoCliente ac = new AccesoCliente();
        public Frm_listarCliente()
        {
            InitializeComponent();
            this.cargarTabla();
        }
        public void cargarTabla()
        {
            this.modelo.Tabla = this.tbl_tabla;
            this.modelo.Lista = this.ac.listar();
            this.modelo.llenarTabla();
            this.tbl_tabla.Update();
        }
       
        private AccesoCliente rescatarObjeto()
        {
            int aux = this.modelo.Lista.Count;
            AccesoCliente ac1 = null;
            if(aux > 0)
            {
                ac1 = new AccesoCliente();
                ac1.setCliente((facturacion.modelo.Persona)this.tbl_tabla.CurrentRow.DataBoundItem);
            }
            return ac1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AccesoCliente ac1 = this.rescatarObjeto();            
            
            if(ac1!=null)
            {
                new Frm_cliente(ac1, this).ShowDialog();
            }
        }

        private void btn_biuscar_Click(object sender, EventArgs e)
        {
            if (this.cbx_criterio.Text.Equals("Todos"))
            {
                this.cargarTabla();
            }
            else
            {
                this.modelo.Lista = this.ac.buscar(cbx_criterio.Text, this.txt_texto.Text);
                this.modelo.llenarTabla();
                this.lbl_resultado.Text = "Se han encontrado " + this.modelo.Lista.Count + " resultados";
                this.tbl_tabla.Update();
            }            
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void cambiarBoton(AccesoCliente auxC)
        {
            if (auxC.getCliente().Estado.Equals("activo"))
            {
                btn_activar.Text = "Desactivar";
            }
            else
            {
                btn_activar.Text = "Activar";
            }
        }

        

        private void tbl_tabla_CellEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            AccesoCliente ac1 = this.rescatarObjeto();
            if (ac1 != null)
            {
                this.cambiarBoton(ac1);
            }
        }

        private void btn_activar_Click(object sender, EventArgs e)
        {
            AccesoCliente ac1 = this.rescatarObjeto();
            if (ac1 != null)
            {
                if (ac1.getCliente().Estado.Equals("activo"))
                {
                    ac1.getCliente().Estado = "inactivo";
                }
                else
                {
                    ac1.getCliente().Estado = "activo";
                }
                DialogResult r = MessageBox.Show("Desea activar/desactivar el cliente "+ac1.getCliente().Nombre+" "+ac1.getCliente().Apellido,"Confirmación",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                string aux = r.ToString();
                if(aux.Equals("Yes"))
                {
                    ac1.modificar(ac1.getCliente());
                    MessageBox.Show("Se a actualizado correctamente");
                    this.cargarTabla();
                }
            }
        }

        private void Frm_listarCliente_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
        }

        private void btn_activar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
