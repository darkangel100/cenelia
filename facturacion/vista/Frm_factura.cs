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
    partial class Frm_factura : Form
    {
       
        public Frm_factura()
        {
            InitializeComponent();
            
        }
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
         Frm_RegisraClente RCliente=new Frm_RegisraClente();
           RCliente.ShowDialog();
        }
        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            string reporte = "";
            reporte += "<html>";
            reporte += "<head>";
            reporte += "<title>FACTURA</title>";
            reporte += "<meta http-equiv='content-type' content='text/html; charset=utf-8'/>";
            reporte += "<link rel='stylesheet' href='estilo.css' type='text/css' media='all' />";
            reporte += "</head>";
            reporte += "<body>";
                reporte += "<table>";
                reporte += "<tr>";
                    reporte += "<td>Cédula: </td>";
                  //  reporte += "<td>"+this.ac.getCliente().Cedula+"</td>";                    
                reporte += "</tr>";
                reporte += "<tr>";
                    reporte += "<td>Cliente: </td>";
                 //   reporte += "<td>" + this.ac.getCliente().Apellido +" "+this.ac.getCliente().Nombre+ "</td>";
                reporte += "</tr>";
                reporte += "<tr>";
                    reporte += "<td>Dirección: </td>";
                   // reporte += "<td>" + this.ac.getCliente().Direccion.Barrio + "</td>";
                reporte += "</tr>";
                reporte += "<tr>";
                    reporte += "<td>Teléfono: </td>";
                    //reporte += "<td>" + this.ac.getCliente().Telefono + "</td>";
                reporte += "</tr>";
                reporte += "</table>";
                reporte += "</br>";
                reporte += "<table class='tabla'>";
                    reporte += "<thead>";
                        reporte += "<th>Cantidad  </th><th>Detalles  </th><th>PU</th><th>Total</th>";
                    reporte += "</thead>";
                    reporte += "<tbody>";
                    /*foreach(modelo.DetalleFactura df in this.lista)
                    {
                        reporte += "<tr>";
                        reporte += "<td>" + df.Cantidad + "</td>" + "<td>" + df.Producto.Nombre + "</td>" + "<td>" + df.Pvp + "</td>" + "<td>" + df.Total + "</td>";
                        reporte += "</tr>";
                    }*/

                              // reporte +="<table width="50%"; border="1" align="center">";
                         reporte +=" <tr>";
                           reporte +=" <th>Sabado</td>";
                           reporte +=" <th>Domingo</td>";
                         reporte +=" </tr>";
                         reporte +=" <tr>";
                           reporte +=" <td>Curso HTML</td>";
                           reporte +=" <td>Curso Dreamweaver</td>";
                          reporte +="</tr>";
                          reporte +="<tr>";
                          reporte +="  <td>Curso Frontpage</td>";
                          reporte +="  <td>Curso Flash</td>";
                         reporte +=" </tr>";
                        reporte +="</table>";
                    reporte += "<tr>";
                    reporte += "<td>Subtotal:    </td>";
                    reporte += "<td colspan='4'>"+txt_subtotal.Text+"</td>";
                    reporte += "</tr>";
                    reporte += "<tr>";
                    reporte += "<td>Iva:         </td>";
                    reporte += "<td colspan='4'>" + txt_iva.Text + "</td>";
                    reporte += "</tr>";
                    reporte += "<tr>";
                    
                    reporte += "<td>Total:       </td>";
                    reporte += "<td colspan='4'>" + txt_total.Text + "</td>";
                    reporte += "</tr>";
                    reporte += "</tbody>";
                reporte += "</table>";
            reporte += "</body>";
            reporte += "</html>";
            //Utiles.guardarReporte(reporte, "reporte");
            //Process.Start(Utiles.ObtenerRuta()+"/facturacion/reporte.html");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            label1.BackColor = Color.Transparent;    
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        string apellido;
        byte tipoC;
        private void txt_cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (comboBox1. SelectedIndex == 0||comboBox1.SelectedIndex<1)
            {
                tipoC = 0;
                Utiles.soloNumeros(sender, e, txt_cedula, 10);

            }
            else
            {
                tipoC = 1;

                char letra = e.KeyChar;
                if ((letra >= 'a' & letra <= 'z') || (letra >= 'A' & letra <= 'Z') || letra == 8 || letra == 13)
                {
                    if (letra == 8)
                    {

                        if (apellido.Length > 0)
                        {
                           apellido = apellido.Remove(apellido.Length - 1);
                           llenaClientes(apellido, tipoC);
                        }
                    }
                    else
                    {
                        apellido += letra;
                        llenaClientes(apellido, tipoC);
                    }
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Solo Letras");
                }

            }
        }

        public void llenaClientesF(string est)
        {

            try
            {
             
                PersonaDB objP = new PersonaDB();

              objP.setPersona(objP.TraePersonasC(est));

              if (objP.getPersona().Cedula == "")
                {
                    MessageBox.Show("No existen Clientes registrados", "Koreano-Chino", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    txt_cliente.Text=objP.getPersona().Nombre;
                   txt_direccion.Text=objP.getPersona().Telefono;
                   txt_telefono.Text=objP.getPersona().Estado;
                   txt_cedula.Text = objP.getPersona().Apellido;
                   txtidpersona.Text =Convert.ToString( objP.getPersona().Id_persona);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Al Presentar los Datos," + ex.Message, "Koreano-Chino", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
     
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
              

                label2.Text = "Apellido";
               label3.Text = "Cedula";
               listBox1.Visible = true;
               txt_cedula.Text = "";
              // limpiar();
            }
            if (comboBox1.SelectedIndex==0)
            {
                listBox1.Items.Clear();
                label2.Text = "Cedula";
               label3.Text = "Apellido";
               listBox1.Visible = false;
               limpiar();
            }
            
        }
        public void limpiar()
        {
            txt_cliente.Text = "";
            txt_cedula.Text = "";
            txt_direccion.Text = "";
            txt_telefono.Text = "";
        }
        public void llenaClientes(string est, byte tipoc)
        {
            try
            {
                
                PersonaDB objP = new PersonaDB();

                objP.getPersona().ListaPersonas = objP.TraePersonas(est);

                if (objP.getPersona().ListaPersonas.Count == 0)
                {
                    MessageBox.Show("No existen Clientes registrados", "Koreano-Chino", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    listBox1.DisplayMember = "nombre"; // esta relacionado a los nombres
                    listBox1.ValueMember = "Cedula"; // el id que esta relacionado con el usuario
                    listBox1.DataSource = objP.getPersona().ListaPersonas; // el contenido de la lista 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Al Presentar los Datos," + ex.Message, "Koreano-Chino", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0||comboBox1.SelectedIndex<0)
            {

                llenaClientesF(txt_cedula.Text);  
            }
            
           
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            llenaClientesF(listBox1.SelectedValue.ToString());
            label2.Text = "Cedula";
            label3.Text = "Apellido";
        }
        string producto="";
        private void txt_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char letra = e.KeyChar;
            if ((letra >= 'a' & letra <= 'z') || (letra >= 'A' & letra <= 'Z') || letra == 8 || letra == 13)
            {
                if (letra == 8)
                {

                    if (producto.Length > 0)
                    {
                      producto = producto.Remove(producto.Length - 1);
                        llenaproducto(producto);
                    }
                }
                else
                {
                    producto += letra;
                    llenaproducto(producto);
                }
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo Letras");
            }
        }

        private void llenaproducto(string producto)
        {
             try
            {
                tbl_tabla .Rows.Clear();
               ProductoDB objP = new ProductoDB();
              
            objP.getProductos().ListaProductos = objP.traerProductosfai(producto);  

                if (objP.getProductos().ListaProductos.Count == 0)
                {
                    MessageBox.Show("No existen Productos Registrados", "Koreano-Chino", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                   
                    for (int i = 0; i < objP.getProductos().ListaProductos.Count; i++)
                    {
                          dataGridView1. Rows.Add(1);
                          dataGridView1.Rows[i].Cells[0].Value = objP.getProductos().ListaProductos[i].Codigo;
                          dataGridView1.Rows[i].Cells[1].Value = objP.getProductos().ListaProductos[i].Nombre;
                          dataGridView1.Rows[i].Cells[2].Value = objP.getProductos().ListaProductos[i].Unidad;
                          dataGridView1.Rows[i].Cells[3].Value = objP.getProductos().ListaProductos[i].Presentacion;
                          dataGridView1.Rows[i].Cells[4].Value = objP.getProductos().ListaProductos[i].Marca;
                          dataGridView1.Rows[i].Cells[5].Value = objP.getProductos().ListaProductos[i].Id_lote;
                       
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Al Presentar los Datos," + ex.Message, "Koreano-Chino", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          }

       private void llenaproductoVenta(string producto)
        {
            
            try
            {
                tbl_tabla.Rows.Clear();
                ProductoDB objP = new ProductoDB();

                objP.getProductos().ListaProductos = objP.traerProductosfai(producto);

                if (objP.getProductos().ListaProductos.Count == 0)
                {
                    MessageBox.Show("No existen Clientes registrados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    fila = 0;
                    for (int i = 0; i < objP.getProductos().ListaProductos.Count; i++)
                    {
                        dataGridView1.Rows.Add(1);
                        dataGridView1.Rows[i].Cells[0].Value = objP.getProductos().ListaProductos[i].Codigo;
                        dataGridView1.Rows[i].Cells[1].Value = objP.getProductos().ListaProductos[i].Marca;
                        dataGridView1.Rows[i].Cells[2].Value = objP.getProductos().ListaProductos[i].Nombre;
                        dataGridView1.Rows[i].Cells[3].Value = objP.getProductos().ListaProductos[i].Presentacion;
                        dataGridView1.Rows[i].Cells[4].Value = objP.getProductos().ListaProductos[i].Unidad;

                        //dataGridView1.Rows[i].Cells[5].Value = objP.getProductos().ListaProductos[i].Lote_obj.;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Al Presentar los Datos," + ex.Message, "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        int pos = 0;
        int fila = 0;
        double total;
        int cant;
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            double subtotal=0;
            fila = dataGridView1.CurrentRow.Index;
            try
            {
                ProductoDB objP = new ProductoDB();
                objP.setProductos(objP.traeProducto(dataGridView1.Rows[fila].Cells[0].Value.ToString()));
               
                LotesDB objL = new LotesDB();
                objL.setLote(objL.traeLotefai(dataGridView1.Rows[fila].Cells[5].Value.ToString()));
                
                tbl_tabla.Rows.Add(1);
                
                tbl_tabla.Rows[pos].Cells[0].Value = objP.getProductos().Nombre;
                tbl_tabla.Rows[pos].Cells[1].Value = objL.getLote().Pv;
                tbl_tabla.Rows[pos].Cells[2].Value =" 1";
                cant = int.Parse(tbl_tabla.Rows[pos].Cells[2].Value.ToString()); 
                total = (double.Parse(tbl_tabla.Rows[pos].Cells[2].Value.ToString()) * double.Parse(tbl_tabla.Rows[pos].Cells[1].Value.ToString()));
                tbl_tabla.Rows[pos].Cells[3].Value =total.ToString();
                tbl_tabla.Rows[pos].Cells[4].Value = objL.getLote().Id_Lote;
                tbl_tabla.Rows[pos].Cells[5].Value = objP.getProductos().Id_producto;


                txt_subtotal.Text = Convert.ToString(sumar(subtotal));
                txt_iva.Text = Convert.ToString(sumar(subtotal) * 0.12);
                txt_total.Text = Convert.ToString((sumar(subtotal) * 0.12)+(sumar(subtotal)));
                pos++;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al presentar los datos," + ex.Message, "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public double sumar(double subtotal)
        {
                foreach (DataGridViewRow  row  in tbl_tabla.Rows)
                {
                    subtotal += Convert.ToDouble(row.Cells["Column9"].Value);
                }
                return subtotal;
        }


        int fila2 = 0;
        private void tbl_tabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila2 = tbl_tabla.CurrentRow.Index;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbl_tabla.Rows.RemoveAt(tbl_tabla.CurrentRow.Index);
            pos--;
        }

        private void tbl_tabla_KeyPress(object sender, KeyPressEventArgs e)
        {
            double subtotal=0;
            char letra = e.KeyChar;
            if (!char.IsDigit(letra) & letra != 13 & letra != 8 & letra != 44)
                e.Handled = true;
            if (letra == 13){
                total = (double.Parse(tbl_tabla.Rows[fila2].Cells[2].Value.ToString()) * double.Parse(tbl_tabla.Rows[fila2].Cells[1].Value.ToString()));
                tbl_tabla.Rows[fila2].Cells[3].Value = total.ToString();
                txt_subtotal.Text = Convert.ToString(sumar(subtotal));
                txt_iva.Text = Convert.ToString(sumar(subtotal) * 0.12);
                txt_total.Text = Convert.ToString((sumar(subtotal) * 0.12) * (sumar(subtotal)));
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (tbl_tabla.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos en la factura", "Koreano-Chino", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                guardarfactura();
               // limpiar();
                btn_imprimir.Enabled = true;
            }
        }
        public void guardarfactura()
        {
            try
            {
                FacturaDB objF = new FacturaDB();
                ItemFacturaDB objI = new ItemFacturaDB();
              LotesDB objL = new LotesDB();
                int resp;
                int resp1;
                int resp2;
                int cp ;
                int cca = 0;
                objF.getFacturas().Num_factura = int.Parse(txt_numFact.Text);
                objF.getFacturas().Idpersona=int.Parse( txtidpersona.Text.ToString());
                objF.getFacturas().Fecha = Utiles.girafecha(date_fecha.Value.Date.ToString());
                
                objF.getFacturas().Iva= Convert.ToDouble(txt_iva.Text);
                objF.getFacturas().Subtotal = Convert.ToDouble(txt_subtotal.Text);
                
                objF.getFacturas().Total = Convert.ToDouble(txt_total.Text);
               
                resp = objF.InsertaFacturas(objF.getFacturas());
                if (resp == 0)
                {
                    MessageBox.Show("No se ingreso datos de la Factura", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    for (int i = 0; i < pos; i++)
                    {
                        objI.getDetalleFactura().Cantidad=int.Parse(tbl_tabla.Rows[i].Cells[2].Value.ToString());
                        
                        objI.getDetalleFactura().Pvp=double.Parse(tbl_tabla.Rows[i].Cells[1].Value.ToString());
                        cca =int.Parse(tbl_tabla.Rows[i].Cells[2].Value.ToString());
                        cp = int.Parse(tbl_tabla.Rows[i].Cells[4].Value.ToString());
                        objI.getDetalleFactura().Subtotal = Convert.ToDouble(txt_subtotal.Text);
                        objI.getDetalleFactura().Iva= double.Parse(tbl_tabla.Rows[i].Cells[3].Value.ToString()) * 0.12;
                        objI.getDetalleFactura().Idfactura = Convert.ToInt16(txt_numFact.Text);
                        objI.getDetalleFactura().Idlote = int.Parse(tbl_tabla.Rows[i].Cells[4].Value.ToString());
                        resp1 = objI.InsertaItemFactura(objI.getDetalleFactura());
                        if (resp1 == 0)
                        {
                            MessageBox.Show("No se ingreso item de datos de la Factura", "Koreano-Chino", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        resp2 = objL.ActualizaCantidad(cp, cca);
                        if (resp2 == 0)
                        {
                            MessageBox.Show("No se actualizo Productos", "Koreano-Chino", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    MessageBox.Show("Factura Ingresado", "Koreano-Chino", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }           
        catch (Exception ex)
            {
                MessageBox.Show("Error al Ingresar Datos," + ex.Message, "Koreano-Chino", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           }

        private void Frm_factura_Load(object sender, EventArgs e)
        {
         int num;
            FacturaDB objp = new FacturaDB();
            num = objp.cuentaFacturas();
            //int aux = int.Parse(num);
            if (num==0)
            {
                txt_numFact.Text = Convert.ToString(1);
            }
            else
            {
                txt_numFact.Text = Convert.ToString(num + 1);

            }
        }

       }
   }
