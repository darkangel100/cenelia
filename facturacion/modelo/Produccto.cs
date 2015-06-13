using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace facturacion.modelo
{
    class Produccto
    {
        private int id_producto;
        private string nombre;
        private string presentacion;
        private string unidad;
        private string codigo;       
        private List<Produccto> listaProductos = new List<Produccto>();
        
        private string estado = "activo";
         public string Presentacion
        {
            get { return presentacion; }
            set { presentacion = value; }
        }
      
        public string Unidad
        {
            get { return unidad; }
            set { unidad = value; }
        }
       
        

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        
       


        //internal Marca Marca
        //{
        //    get { return marca; }
        //    set { marca = value; }
        //}

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


        public List<Produccto> ListaProductos
        {
            get { return listaProductos; }
            set { listaProductos = value; }
        }
       

        
        override
        public string ToString()
        {
            return this.codigo + " " + this.nombre;
        }
    }
}
