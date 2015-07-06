using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;

using facturacion.controlador;

namespace facturacion.vista
{
    partial class frm_listarProducto : Form
    {
      
        public frm_listarProducto()
        {
            InitializeComponent();
            
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            modificar();
        }
        public void modificar()
        {
            try
            {
                ProductoDB pro = new ProductoDB();
                LotesDB l = new LotesDB();
                pro.setProductos(pro.traeProducto(tbl_tabla. Rows[fila].Cells[0].Value.ToString()));
                if (pro.getProductos().Codigo.Equals(""))
                {
                    MessageBox.Show("No existe registro del producto", "Facturacion", MessageBoxButtons.OK);
                }
                else
                {
                    txt_codigo.Text = pro.getProductos().Codigo;
                    txtnombre.Text = pro.getProductos().Nombre;
                    txtmarca.Text = pro.getProductos().Marca;
                    txtunidad.Text = pro.getProductos().Unidad;
                    txtpresentacio.Text = pro.getProductos().Presentacion;
                    //if (pro.getProducto().Iva_sn == "i")
                    //    chkIva.Checked = true;
                    //else
                    //    chkIva.Checked = true;
                    //txtPrecioVenta.Text = pro.getProducto().Pre_ven.ToString();
                    //dtpElaboracion.Value = Convert.ToDateTime(pro.getProducto().Fec_ela);
                    //cmbC.Enabled = false;
                    //indice = 1;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al presentar los datos, " + ex.Message, "Facturacion", MessageBoxButtons.OK);
            }
        }
        int fila = 0;
        private void tbl_tabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = tbl_tabla.CurrentRow.Index;
        }

        private void cbx_criterio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void tbl_tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        string nombre;
        byte tipoC;
        private void txt_texto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbx_criterio.SelectedIndex == 0)
            {
                tipoC = 0;
                Utiles.soloNumeros(sender, e, txt_texto, 10);

            }
            else
            {
                tipoC = 1;

                char letra = e.KeyChar;

                if ((letra >= 'a' & letra <= 'z') || (letra >= 'A' & letra <= 'Z') || letra == 8 || letra == 13)
                {
                    if (letra == 8)
                    {
                        if (nombre.Length > 0)
                        {
                            nombre = nombre.Remove(nombre.Length - 1);
                            llenaProdctosLote(nombre, tipoC);
                        }
                    }
                    else
                    {
                        nombre += letra;
                        llenaProdctosLote(nombre, tipoC);
                    }
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Solo Letras");
                }
            }
        }
        public void llenaProdctosLote(string cod, byte tipoc)
        {
            try
            {
                tbl_tabla.Rows.Clear();
                LotesDB objL = new LotesDB();
                ProductoDB objP = new ProductoDB();
                //if (tipoc == 0) { objP.getProductos().ListaProductos =   objP.traeProducto(cod); }
                //else { objP.getProductos().ListaProductos = objP.traeProducto(cod); }

                if (objP.getProductos().ListaProductos.Count == 0)
                {
                    MessageBox.Show("No existen Productos registrados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    fila = 0;
                    for (int i = 0; i < objL.getLote().ListaLote.Count; i++)
                    {
                        tbl_tabla.Rows.Add(1);
                        tbl_tabla.Rows[i].Cells[0].Value = objL.getLote().ListaLote[i].Fechcad;
                        tbl_tabla.Rows[i].Cells[1].Value = objL.getLote().ListaLote[i].Fechelab;
                        tbl_tabla.Rows[i].Cells[2].Value = objL.getLote().ListaLote[i].Stock;
                        //tbl_tabla.Rows[i].Cells[3].Value = objL.getPersona().ListaPersonas[i].Direccion;
                        //tbl_tabla.Rows[i].Cells[4].Value = objL.getPersona().ListaPersonas[i].Telefono;
                        //tbl_tabla.Rows[i].Cells[5].Value = objL.getPersona().ListaPersonas[i].Estado;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Al Presentar los Datos," + ex.Message, "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
