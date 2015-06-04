using System;
using System.Collections.Generic;
using System.Text;
using facturacion.modelo;

namespace facturacion.controlador
{
    class Sesiones
    {
        private static Cuenta cuenta = null;

        internal static Cuenta Cuenta
        {
            get { return Sesiones.cuenta; }
            set { Sesiones.cuenta = value; }
        }

    }
}
