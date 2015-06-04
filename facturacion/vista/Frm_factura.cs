using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using facturacion.controlador;
using facturacion.vista.modeloTabla;
using facturacion.modelo;
using System.Diagnostics;

namespace facturacion.vista
{
    partial class Frm_factura : Form
    {
        private AccesoCliente ac = new AccesoCliente();
        private List<Object> lista = new List<object>();
        private ModeloDetalleFactura modelo = new ModeloDetalleFactura();
        public Frm_factura()
        {
            InitializeComponent();
            this.cargarModeloTabla();
        }
        private void cargarModeloTabla()
        {
            if (this.lista.Count <= 0)
            {
                AccesoDetalleFactura ap = new AccesoDetalleFactura();
                modelo.Lista.Add(ap.getDetalle());
                this.lista.Clear();
            }
            else
            {                
                this.modelo.Lista = this.lista;           
            }            
            this.modelo.Tabla = this.tbl_tabla;            
            this.modelo.llenarTabla();
            this.tbl_tabla.Update();
            this.tbl_tabla.Refresh();              
        }
        #region Descriptores de acceso de atributos de ensamblado

        public string AssemblyTitle
        {
            get
            {
                // Obtener todos los atributos Title en este ensamblado
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                // Si hay al menos un atributo Title
                if (attributes.Length > 0)
                {
                    // Seleccione el primero
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    // Si no es una cadena vacía, devuélvalo
                    if (titleAttribute.Title != "")
                        return titleAttribute.Title;
                }
                // Si no había ningún atributo Title, o si el atributo Title era una cadena vacía, devuelva el nombre del archivo .exe
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                // Obtener todos los atributos de descripción de este ensamblado
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                // Si no hay ningún atributo de descripción, devuelva una cadena vacía
                if (attributes.Length == 0)
                    return "";
                // Si hay un atributo de descripción, devuelva su valor
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                // Obtenga todos los atributos del producto de este ensamblado
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                // Si no hay atributos del producto, devuelva una cadena vacía
                if (attributes.Length == 0)
                    return "";
                // Si hay un atributo de producto, devuelva su valor
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                // Obtenga todos los atributos de copyright de este ensamblado
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                // Si no hay atributos de copyright, devuelva una cadena vacía
                if (attributes.Length == 0)
                    return "";
                // Si hay un atributo de copyright, devuelva su valor
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                // Obtenga todos los atributos de compañía en este ensamblado
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                // Si no hay ningún atributo de compañía, devuelva una cadena vacía
                if (attributes.Length == 0)
                    return "";
                // Si hay un atributo de compañía, devuelva su valor
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            List<object> lista = this.ac.buscar("cedula",txt_cedula.Text);
            if (lista.Count <= 0)
            {
                MessageBox.Show("No existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                foreach(facturacion.modelo.Persona p in lista)
                {
                    this.ac.setCliente(p);
                }
                this.cargarDatosCliente();
            }
        }
        public void cargarDatosCliente()
        {
            txt_cliente.Text = this.ac.getCliente().Apellido + " " + this.ac.getCliente().Nombre;
            txt_direccion.Text = this.ac.getCliente().Direccion.Barrio;
            txt_telefono.Text = this.ac.getCliente().Telefono;
            txt_cedula.Text = this.ac.getCliente().Cedula;
        }
        public void setAccesoCliente(AccesoCliente ac1)
        {
            this.ac = ac1;
        }
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            new Frm_cliente(this).ShowDialog();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            AccesoProducto ap = new AccesoProducto();
            List<object> lista1 = ap.buscar("codigo", txt_codigo.Text);
            if (lista1.Count > 0)
            {
                foreach(facturacion.modelo.Producto p in lista1){
                    ap.setProducto(p);
                }
                AccesoDetalleFactura adf = new AccesoDetalleFactura();
                adf.getDetalle().Detalle = ap.getProducto().Nombre;
                adf.getDetalle().Producto = ap.getProducto();
                int cantidad = this.sumarCantidad(adf);
                adf.getDetalle().Cantidad = cantidad;                
                adf.getDetalle().Pvp = ap.getProducto().Pvp;
                adf.getDetalle().Total = adf.getDetalle().Cantidad * adf.getDetalle().Pvp;
                this.cargarDetalles(cantidad, adf);
                this.cargarModeloTabla();
                this.sumarPrecios();
            }
            else
            {
                MessageBox.Show("No existe el producto");
            }
        }
        private int sumarCantidad(AccesoDetalleFactura adf)
        {            
            int cant_ant = 0;
            foreach (facturacion.modelo.DetalleFactura df in this.lista)
            {
                if(df.Producto.Id_producto==adf.getDetalle().Producto.Id_producto){         
                    cant_ant = df.Cantidad;
                }
            }
            cant_ant ++;
            
            return cant_ant;
        }
        private void cargarDetalles(int cant, AccesoDetalleFactura adf){
            if (cant <= 1){
                this.lista.Add(adf.getDetalle());
            }else{
                int pos = 0;
                foreach (facturacion.modelo.DetalleFactura df in this.lista){
                    if (df.Producto.Id_producto == adf.getDetalle().Producto.Id_producto){
                        break;
                    }
                    pos++;
                }                
                this.lista.RemoveAt(pos);
                this.lista.Insert(pos, adf.getDetalle());                
            }
        }

        private void sumarPrecios()
        {
            double subtotal = 0.0;
            double total = 0.0;
            double descuento = 0.0;
            foreach (facturacion.modelo.DetalleFactura df in this.lista)
            {
                subtotal += df.Total;
            }
            txt_subtotal.Text = subtotal.ToString();
            total = subtotal * 1.12;
            if (cbx_descuento.Text != "Seleccione")
            {
                descuento = (total * Convert.ToDouble(cbx_descuento.Text))/100;
            }
            total = total - descuento;
            txt_total.Text = total.ToString();
        }

        private void cbx_descuento_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.sumarPrecios();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.lista.Count > 0)
            {
                int fila = this.tbl_tabla.CurrentRow.Index;
                this.lista.RemoveAt(fila);
                this.cargarModeloTabla();
                this.sumarPrecios();
            }
            else
            {
                MessageBox.Show("Solo se puede eliminar cuando existan datos");
            }
        }
        
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (this.ac.getCliente() != null && Utiles.requerido(txt_numFact, errorProvider1) == true && this.lista.Count > 0)
            {
                AccesoFactura accesoFact = new AccesoFactura();
                accesoFact.getFactura().Id_factura = accesoFact.generarId();
                accesoFact.getFactura().Num_factura = txt_numFact.Text;                
                accesoFact.getFactura().Persona = this.ac.getCliente();
                accesoFact.getFactura().Iva = Convert.ToDouble(txt_iva.Text);
                accesoFact.getFactura().Subtotal = Convert.ToDouble(txt_subtotal.Text);
                accesoFact.getFactura().Total = Convert.ToDouble(txt_total.Text);
                accesoFact.getFactura().Fecha = date_fecha.Value;
                List<DetalleFactura> listaAux = new List<DetalleFactura>();
                foreach(modelo.DetalleFactura df in this.lista){
                    df.Factura = accesoFact.getFactura();
                    listaAux.Add(df);
                    AccesoProducto auxP = new AccesoProducto();
                    auxP.setProducto(df.Producto);
                    auxP.getProducto().Stock = auxP.getProducto().Stock - df.Cantidad;
                    auxP.modificar(auxP.getProducto());
                }
                accesoFact.getFactura().ListaDetalle = listaAux;
                if (accesoFact.guardar(accesoFact.getFactura()) == true)
                {
                    MessageBox.Show("La factura se ha registrado correctamente");
                    btn_guardar.Enabled = false;
                    btn_imprimir.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No se pudo guardar");
                }
            }
            else
            {
                MessageBox.Show("Llene todos los campos");
            }
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
                    reporte += "<td>"+this.ac.getCliente().Cedula+"</td>";                    
                reporte += "</tr>";
                reporte += "<tr>";
                    reporte += "<td>Cliente: </td>";
                    reporte += "<td>" + this.ac.getCliente().Apellido +" "+this.ac.getCliente().Nombre+ "</td>";
                reporte += "</tr>";
                reporte += "<tr>";
                    reporte += "<td>Dirección: </td>";
                    reporte += "<td>" + this.ac.getCliente().Direccion.Barrio + "</td>";
                reporte += "</tr>";
                reporte += "<tr>";
                    reporte += "<td>Teléfono: </td>";
                    reporte += "<td>" + this.ac.getCliente().Telefono + "</td>";
                reporte += "</tr>";
                reporte += "</table>";
                reporte += "</br>";
                reporte += "<table class='tabla'>";
                    reporte += "<thead>";
                        reporte += "<th>Cantidad  </th><th>Detalles  </th><th>PU</th><th>Total</th>";
                    reporte += "</thead>";
                    reporte += "<tbody>";
                    foreach(modelo.DetalleFactura df in this.lista)
                    {
                        reporte += "<tr>";
                        reporte += "<td>" + df.Cantidad + "</td>" + "<td>" + df.Producto.Nombre + "</td>" + "<td>" + df.Pvp + "</td>" + "<td>" + df.Total + "</td>";
                        reporte += "</tr>";
                    }

       //reporte +="<table width="50%"; border="1" align="center">";
// reporte +=" <tr>";
//   reporte +=" <th>Sabado</td>";
//   reporte +=" <th>Domingo</td>";
// reporte +=" </tr>";
// reporte +=" <tr>";
//   reporte +=" <td>Curso HTML</td>";
//   reporte +=" <td>Curso Dreamweaver</td>";
//  reporte +="</tr>";
//  reporte +="<tr>";
//  reporte +="  <td>Curso Frontpage</td>";
//  reporte +="  <td>Curso Flash</td>";
// reporte +=" </tr>";
//reporte +="</table>";









                    reporte += "<tr>";
                    reporte += "<td>Subtotal:    </td>";
                    reporte += "<td colspan='4'>"+txt_subtotal.Text+"</td>";
                    reporte += "</tr>";
                    reporte += "<tr>";
                    reporte += "<td>Iva:         </td>";
                    reporte += "<td colspan='4'>" + txt_iva.Text + "</td>";
                    reporte += "</tr>";
                    reporte += "<tr>";
                    reporte += "<td>Descuento:   </td>";
                    reporte += "<td colspan='4'>" + cbx_descuento.Text + "</td>";
                    reporte += "</tr>";
                    reporte += "<tr>";
                    reporte += "<td>Total:       </td>";
                    reporte += "<td colspan='4'>" + txt_total.Text + "</td>";
                    reporte += "</tr>";
                    reporte += "</tbody>";
                reporte += "</table>";
            reporte += "</body>";
            reporte += "</html>";
            Utiles.guardarReporte(reporte, "reporte");
            Process.Start(Utiles.ObtenerRuta()+"/facturacion/reporte.html");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            label1.BackColor = Color.Transparent;
        }

       
       
    }
}
