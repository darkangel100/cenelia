using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace facturacion.modelo
{
    class Rol
    {
        private int id_rol;
        private string nombre;

        public int Id_rol
        {
            get { return id_rol; }
            set { id_rol = value; }
        }


        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        override
        public string ToString()
        {
            return this.nombre;
        }
    }
}
