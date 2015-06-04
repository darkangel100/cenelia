using System;
using System.Collections.Generic;
using System.Text;

namespace facturacion.modelo
{
    [Serializable()]
    class Cuenta
    {
        private int id_cuenta;
        private string usuario;
        private string clave;
        private Persona persona;

        internal Persona Persona
        {
            get { return persona; }
            set { persona = value; }
        }
        public int Id_cuenta
        {
            get { return id_cuenta; }
            set { id_cuenta = value; }
        }
        
        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        
        public string Clave
        {
            get { return clave; }
            set { clave = value; }
        }
        override
        public  string ToString()
        {
            return this.usuario;
        }
    }
}
