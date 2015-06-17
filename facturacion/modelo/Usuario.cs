using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace facturacion.modelo
{
    class Usuario
    {
        private string cla_usu;
        private Rol rol;

        public Rol Rol
        {
            get { return rol; }
            set { rol = value; }
        }

        public string clausu
        {
            get { return cla_usu; }
            set { cla_usu = value; }
        }
        


    }
}
