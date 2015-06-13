using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace facturacion.modelo
{
    class Factura
    {
        private int id_factura;
        private DateTime fecha;
        private double iva;
        private double subtotal;
        private double total;
        private String num_factura;
        private Persona persona;
        //private List<DetalleFactura> listaDetalle = new List<DetalleFactura>();


        //internal List<DetalleFactura> ListaDetalle
        //{
        //    get { return listaDetalle; }
        //    set { listaDetalle = value; }
        //}


        internal Persona Persona
        {
            get { return persona; }
            set { persona = value; }
        }



        public int Id_factura
        {
            get { return id_factura; }
            set { id_factura = value; }
        }

        public DateTime Fecha
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

        public string Num_factura
        {
            get { return num_factura; }
            set { num_factura = value; }
        }

    }
}
