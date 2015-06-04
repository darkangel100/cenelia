using System;
using System.Collections.Generic;
using System.Text;

namespace facturacion.modelo
{
    [Serializable()]
    class Direccion
    {
        private int id_direccion;        
        private string provincia;        
        private string canton;        
        private string barrio;
        private Persona persona;

        public int Id_direccion
        {
            get { return id_direccion; }
            set { id_direccion = value; }
        }

        public string Provincia
        {
            get { return provincia; }
            set { provincia = value; }
        }

        public string Canton
        {
            get { return canton; }
            set { canton = value; }
        }

        public string Barrio
        {
            get { return barrio; }
            set { barrio = value; }
        }
        
        internal Persona Persona
        {
            get { return persona; }
            set { persona = value; }
        }

        public override string  ToString()
        {
 	         return this.barrio;
        }

        
    }
}
