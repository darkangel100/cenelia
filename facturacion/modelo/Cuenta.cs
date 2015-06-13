using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace facturacion.modelo
{
    class Cuenta
    {
        private int id_cuenta;
        private string usuario;
        private string clave;
        private Persona persona;
        private DateTime ultimoacceso;

        public DateTime Ultimoacceso
        {
            get { return ultimoacceso; }
            set { ultimoacceso = value; }
        }

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
        public string ToString()
        {
            return this.usuario;
        }



    }
}
