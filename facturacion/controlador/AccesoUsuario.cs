using System;
using System.Collections.Generic;
using System.Text;
using facturacion.modelo;

namespace facturacion.controlador
{
    class AccesoUsuario:AccesoDatos
    {
        private Persona persona = null;
        public AccesoUsuario(): base("usuario.obj")
        {
        }
        public Persona getPersona()
        {
            if(this.persona==null){
                this.persona = new Persona();
                Direccion direccion = new Direccion();
                this.persona.Direccion = direccion;
            }
            return this.persona;
        }
        public void setPersona(Persona persona)
        {
            this.persona = persona;
        }
        
    }
}
