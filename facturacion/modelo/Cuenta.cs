using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace facturacion.modelo
{
    class Cuenta:Persona
    {
        private int id_cuenta;
        private string usuario21;
 private string clave;
        private Persona persona;
        private DateTime ultimoacceso;
        private string estado = "Activo";
        private List<Cuenta> listacuentas = new List<Cuenta>();
        private int id_per;

        public int Id_per
        {
            get { return id_per; }
            set { id_per = value; }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        public string Usuario21
        {
            get { return usuario21; }
            set { usuario21 = value; }
        }
       

        public DateTime Ultimoacceso
        {
            get { return ultimoacceso; }
            set { ultimoacceso = value; }
        }

        public Persona Persona
        {
            get { return persona; }
            set { persona = value; }
        }
        public int Id_cuenta
        {
            get { return id_cuenta; }
            set { id_cuenta = value; }
        }

        

        public string Clave
        {
            get { return clave; }
            set { clave = value; }
        }
        override
        public string ToString()
        {
            return this.usuario21;
        }



    }
}
