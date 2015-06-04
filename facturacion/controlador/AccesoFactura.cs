using System;
using System.Collections.Generic;
using System.Text;
using facturacion.modelo;

namespace facturacion.controlador
{
    class AccesoFactura:AccesoDatos
    {
        private Factura factura = null;
        public Factura getFactura()
        {
            if (this.factura == null)
            {
                this.factura = new Factura();                
            }
            return this.factura;
        }
        public void setFactura(Factura factura)
        {
            this.factura = factura;
        }
        public AccesoFactura():base("factura.obj")
        {
        }
    }
}
