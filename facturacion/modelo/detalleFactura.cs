using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace facturacion.modelo
{
    class detalleFactura
    {

        
        private int cantidad;
        private double pvp;
        private Factura factura;
       // private Lote lote;
        private String detalle;
        private double total;
        private double iva;
        private double subtotal;
        private int idlote;

        public int Idlote
        {
            get { return idlote; }
            set { idlote = value; }
        }
        public double Subtotal
        {
            get { return subtotal; }
            set { subtotal = value; }
        }
       
        private int idfactura;

        public int Idfactura
        {
            get { return idfactura; }
            set { idfactura = value; }
        }
       
        public double Iva
        {
            get { return iva; }
            set { iva = value; }
        }
       
        public double Total
        {
            get { return total; }
            set { total = value; }
        }

        public String Detalle
        {
            get { return detalle; }
            set { detalle = value; }
        }

       

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public double Pvp
        {
            get { return pvp; }
            set { pvp = value; }
        }


        internal Factura Factura
        {
            get { return factura; }
            set { factura = value; }
        }


        //internal Produccto Produccto
        //{
        //    get { return produccto; }
        //    set { produccto = value; }
        //}

    }
}
