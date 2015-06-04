using System;
using System.Collections.Generic;
using System.Text;
using facturacion.modelo;

namespace facturacion.controlador
{
    class AccesoRol:AccesoDatos
    {
        private Rol rol = null;
        public AccesoRol()
            :base("rol.obj")
        {
        }
        public Rol getRol()
        {
            if (this.rol == null)
            {
                this.rol = new Rol();
            }
            return this.rol;
        }
        public void setRol(Rol rol)
        {
            this.rol = rol;
        }

        public void crearNuevosRoles()
        {
            Rol r1 = new Rol();
            r1.Nombre=("Gerente");
            r1.Id_rol = this.generarId();
            this.guardar(r1);
            Rol r2 = new Rol();
            r2.Nombre=("Vendedor");
            r2.Id_rol = this.generarId();
            this.guardar(r2);
        }
    }
}
