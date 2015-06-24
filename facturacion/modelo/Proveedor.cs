using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace facturacion.modelo
{
    class Proveedor:Persona
    {
        private string nomEmpresa;
        private string ruc;
        private List<Proveedor> listaProveedor = new List<Proveedor>();
        private int idEmpresa;

    public int IdEmpresa
        {
            get { return idEmpresa; }
            set { idEmpresa = value; }
        }

        internal List<Proveedor> ListaProveedor
        {
            get { return listaProveedor; }
            set { listaProveedor = value; }
        }


        public string Ruc
        {
            get { return ruc; }
            set { ruc = value; }
        }

        public string NomEmpresa
        {
            get { return nomEmpresa; }
            set { nomEmpresa = value; }
        }
        override
        public string ToString()
        {
            return this.Apellido + " " + this.Nombre;
        }
    }
}
