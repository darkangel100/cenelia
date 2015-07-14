using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;

using facturacion.controlador;
using System.Diagnostics;

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
                //if (tipoc == 0) { objP.getProductos().ListaProductos = objP.traeProducto(cod); }
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

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    string salida = "<html><head><title>Listado de productos</title><meta http-equiv='content-type' content='text/html; charset=utf-8'/><link rel='stylesheet' href='tablas.css' type='text/css' media='all' />";
        //    salida += "</head><body>";
        //    tbl_tabla.Rows.Clear();
        //    LotesDB objL = new LotesDB();
        //    ProductoDB objP = new ProductoDB();
        //    objP.getProductos().ListaProductos = objP.listarProductos();
        //    if (tipoc == 0) { objP.getProductos().ListaProductos = objP.traeProducto(cod); }
        //    else { objP.getProductos().ListaProductos = objP.traeProducto(cod); }
        //    salida += "<h1>Reporte de Productos</h1></br>";
        //    if (objP.getProductos().ListaProductos.Count == 0)
        //    {

        //        salida += "<p><span><strong>No existen datos que mostrar</strong></span></p></br>";
        //    }
        //    else
        //    {
        //        salida += "<table style='border: solid 1px; color= '#f0f'><thead bgcolor='RED'><tr><th>Nro</th><th>Nombre</th><th>Stock</th><th>Fecha Cad</th><th>Fecha Elab</th></tr></thead><tbody>";
        //        fila = 0;
        //        for (int i = 0; i < objP.getProductos().ListaProductos.Count; i++)
        //        {
        //            salida += "<tr>";
        //            salida += "<td>" + (i + 1) + "</td>";
        //            salida += "<td>" + objP.getProductos().ListaProductos[i].Nombre + "</td>";
        //            salida += "<td>" + objP.getProductos().ListaProductos[i].Lote_obj.Stock + "</td>";
        //            salida += "<td>" + objP.getProductos().ListaProductos[i].Lote_obj.Fechcad + "</td>";
        //            salida += "<td>" + objP.getProductos().ListaProductos[i].Lote_obj.Fechelab + "</td>";
        //            salida += "</tr>";

        //        }
        //    }
        //    salida += "</tbody></table>";
        //    salida += "</body></html>";
        //    Utiles.guardarReporte(salida, "producto");
        //    Process.Start(Utiles.ObtenerRuta() + "/cnch/producto.html");
        //}

        private void ptbguardar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string salida = "<html><head><title>Listado de productos</title><meta http-equiv='content-type' content='text/html; charset=utf-8'/><link rel='stylesheet' href='tablas.css' type='text/css' media='all' />";
            //    salida += "</head><body>";
            //    tbl_tabla.Rows.Clear();
            //    LotesDB objL = new LotesDB();
            //    ProductoDB objP = new ProductoDB();
            //    objP.getProductos().ListaProductos = objP.listarProductos();
            //    if (tipoc == 0) { objP.getProductos().ListaProductos = objP.traeProducto(cod); }
            //    else { objP.getProductos().ListaProductos = objP.traeProducto(cod); }
            //    salida += "<h1>Reporte de Productos</h1></br>";
            //    if (objP.getProductos().ListaProductos.Count == 0)
            //    {

            //        salida += "<p><span><strong>No existen datos que mostrar</strong></span></p></br>";
            //    }
            //    else
            //    {
            //        salida += "<table style='border: solid 1px; color= '#f0f'><thead bgcolor='RED'><tr><th>Nro</th><th>Nombre</th><th>Stock</th><th>Fecha Cad</th><th>Fecha Elab</th></tr></thead><tbody>";
            //        fila = 0;
            //        for (int i = 0; i < objP.getProductos().ListaProductos.Count; i++)
            //        {
            //            salida += "<tr>";
            //            salida += "<td>" + (i + 1) + "</td>";
            //            salida += "<td>" + objP.getProductos().ListaProductos[i].Nombre + "</td>";
            //            salida += "<td>" + objP.getProductos().ListaProductos[i].Lote_obj.Stock + "</td>";
            //            salida += "<td>" + objP.getProductos().ListaProductos[i].Lote_obj.Fechcad + "</td>";
            //            salida += "<td>" + objP.getProductos().ListaProductos[i].Lote_obj.Fechelab + "</td>";
            //            salida += "</tr>";

            //        }
            //    }
            //    salida += "</tbody></table>";
            //    salida += "</body></html>";
            //    Utiles.guardarReporte(salida, "producto");
            //    Process.Start(Utiles.ObtenerRuta() + "/cnch/producto.html");
            }
        }
    }
}
