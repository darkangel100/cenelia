using System;
using System.Collections.Generic;
using System.Text;

namespace facturacion.modelo
{
    [Serializable()]
    class Producto
    {
        private int id_producto;        
        private string nombre;
        private string codigo;               
        private int stock;
        private double pvp;
        private double p_compra;
        private string detalle;
        private Marca marca;
        private List<DetalleFactura> listaDetalle = new List<DetalleFactura>();
        private string estado = "activo";

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        internal List<DetalleFactura> ListaDetalle
        {
            get { return listaDetalle; }
            set { listaDetalle = value; }
        }


        internal Marca Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public int Id_producto
        {
            get { return id_producto; }
            set { id_producto = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }
        
        public double Pvp
        {
            get { return pvp; }
            set { pvp = value; }
        }
        
        public double P_compra
        {
            get { return p_compra; }
            set { p_compra = value; }
        }
        
        public string Detalle
        {
            get { return detalle; }
            set { detalle = value; }
        }
        override
        public string ToString()
        {
            return this.codigo + " "+this.nombre;
        }

    }
}
