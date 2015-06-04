using System;
using System.Collections.Generic;
using System.Text;

namespace facturacion.modelo
{
    [Serializable()]
    class DetalleFactura
    {
        private int id_detalle;
        private int cantidad;        
        private double pvp;
        private Factura factura;
        private Producto producto;
        private String detalle;
        private double total;
        
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
        

        internal Producto Producto
        {
            get { return producto; }
            set { producto = value; }
        }

        

    }
}
