using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace facturacion.modelo
{
    class Factura
    {
        private int id_factura;
        private String fecha;
        private double iva;
        private double subtotal;
        private double total;
        private int num_factura;
       
        private List<Factura> listaFactura = new List<Factura>();
        private int idpersona;

        public int Idpersona       {
            get { return idpersona; }
            set { idpersona = value; }
        }

       
        //private List<DetalleFactura> listaDetalle = new List<DetalleFactura>();


        //internal List<DetalleFactura> ListaDetalle
        //{
        //    get { return listaDetalle; }
        //    set { listaDetalle = value; }
        //}


        



        
        public String Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public double Iva
        {
            get { return iva; }
            set { iva = value; }
        }

        public double Subtotal
        {
            get { return subtotal; }
            set { subtotal = value; }
        }

        public double Total
        {
            get { return total; }
            set { total = value; }
        }

        public int Num_factura
        {
            get { return num_factura; }
            set { num_factura = value; }
        }

    }
}
