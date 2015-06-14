using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace facturacion.modelo
{
    class Persona
    {
        private int id_persona;
        private string cedula;
        private string apellido;
        private string nombre;
        private string telefono;
        private string direccion;
        private string estado = "activo";
        private Rol rol;
       private Usuario usuario;
       private Cuenta cuenta;
        private Proveedor proveedor;
      public
          Cuenta Cuenta
       {
           get { return cuenta; }
           set { cuenta = value; }
       }
       
        public Rol Rol
        {
            get { return rol; }
            set { rol = value; }
        }

        internal Usuario Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

    public Proveedor Proveedor
        {
            get { return proveedor; }
            set { proveedor = value; }
        }

       
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        
       

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

       
        public int Id_persona
        {
            get { return id_persona; }
            set { id_persona = value; }
        }

        public string Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }


        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }


        
        
    }
}
