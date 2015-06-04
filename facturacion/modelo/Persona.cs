using System;
using System.Collections.Generic;
using System.Text;

namespace facturacion.modelo
{
    [Serializable()]
    class Persona
    {
        private int id_persona;
        private string cedula;
        private string apellido;
        private string nombre;
        private string telefono;
        private string celular;
        private List<Factura> listaFactura = new List<Factura>();
        private Rol rol;
        private Direccion direccion;
        private Cuenta cuenta;
        private string estado="activo";

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public Persona()
        {
            this.direccion = new Direccion();
        }
        public Cuenta Cuenta
        {
            get { return cuenta; }
            set { cuenta = value; }
        }


        public Direccion Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public Rol Rol
        {
            get { return rol; }
            set { rol = value; }
        }



        public List<Factura> ListaFactura
        {
            get { return listaFactura; }
            set { listaFactura = value; }
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


        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }
        override
        public string ToString()
        {
            return this.apellido + " " + this.nombre;
        }
    }
}
