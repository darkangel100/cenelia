using System;
using System.Collections.Generic;
using System.Text;
using facturacion.modelo;

namespace facturacion.controlador
{
    class AccesoDetalleFactura:AccesoDatos
    {
        private DetalleFactura detalle = null;
        public AccesoDetalleFactura():base("detalle.obj")
        {
        }
        public DetalleFactura getDetalle()
        {
            if(this.detalle==null)
            {
                this.detalle = new DetalleFactura();
            }
            return this.detalle;
        }
        public void setDetalle(DetalleFactura dt)
        {
            this.detalle = dt;
        }
    }
}
