using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace facturacion.modelo
{
    class detalleFactura
    {

        private int id_detalle;
        private int cantidad;
        private double pvp;
        private Factura factura;
       // private Lote lote;
        private String detalle;
        private double total;
        private double iva;
        private double descuento;

        public double Descuento
        {
            get { return descuento; }
            set { descuento = value; }
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

        public int Id_detalle
        {
            get { return id_detalle; }
            set { id_detalle = value; }
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
