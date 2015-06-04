using System;
using System.Collections.Generic;
using System.Text;
using facturacion.modelo;

namespace facturacion.controlador
{
    class AccesoCuenta:AccesoDatos
    {
        private Cuenta cuenta = null;
        public AccesoCuenta()
            :base("cuenta.obj")
        {
        }
        public Cuenta getCuenta()
        {
            if(this.cuenta==null){
                this.cuenta = new Cuenta();
            }
            return this.cuenta;
        }
        public void setCuenta(Cuenta cuenta)
        {
            this.cuenta = cuenta;
        }
        public Cuenta iniciarSesion(string user, string passw)
        {
            Cuenta c = null;
            foreach(Cuenta aux in listar())
            {
                if (aux.Usuario.Equals(user) && aux.Clave.Equals(passw))
                {
                    c = aux;
                    break;
                }
            }
            return c;
        }
    }
}
