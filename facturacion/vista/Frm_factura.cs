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
            //new Frm_cliente(this).ShowDialog();
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
                  //  reporte += "<td>" + this.ac.getCliente().Direccion.Barrio + "</td>";
                reporte += "</tr>";
                reporte += "<tr>";
                    reporte += "<td>Teléfono: </td>";
              //      reporte += "<td>" + this.ac.getCliente().Telefono + "</td>";
                reporte += "</tr>";
                reporte += "</table>";
                reporte += "</br>";
                reporte += "<table class='tabla'>";
                    reporte += "<thead>";
                        reporte += "<th>Cantidad  </th><th>Detalles  </th><th>PU</th><th>Total</th>";
                    reporte += "</thead>";
                //    reporte += "<tbody>";
                    /*foreach(modelo.DetalleFactura df in this.lista)
                    {
                        reporte += "<tr>";
                        reporte += "<td>" + df.Cantidad + "</td>" + "<td>" + df.Producto.Nombre + "</td>" + "<td>" + df.Pvp + "</td>" + "<td>" + df.Total + "</td>";
                        reporte += "</tr>";
                    }*/

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
            //Utiles.guardarReporte(reporte, "reporte");
            //Process.Start(Utiles.ObtenerRuta()+"/facturacion/reporte.html");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            label1.BackColor = Color.Transparent;
        }

       
       
    }
}
