using System;
using System.Collections.Generic;
using System.Text;

namespace facturacion.modelo
{
    [Serializable()]
    class Marca
    {
        private int id_marca;        
        private string nombre;

        public int Id_marca
        {
            get { return id_marca; }
            set { id_marca = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        override
        public string ToString()
        {
            return this.id_marca+" : "+this.nombre;
        }
    }
}
