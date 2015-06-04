using System;
using System.Collections.Generic;
using System.Text;

namespace facturacion.modelo
{
    [Serializable()]
    class Proveedor:Persona
    {
        private string nomEmpresa;

        public string NomEmpresa
        {
            get { return nomEmpresa; }
            set { nomEmpresa = value; }
        }
        override
        public string ToString()
        {
            return this.Apellido +" "+this.Nombre;
        }
    }
}
