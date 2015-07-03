using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace facturacion.modelo
{
    class Proveedor
    {
        private string nomEmpresa;
        private string ruc;
        private List<Proveedor> listaProveedorT = new List<Proveedor>();
        private int idEmpresa;
        private string estado;
        private int idpersona;

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

    public int IdEmpresa
        {
            get { return idEmpresa; }
            set { idEmpresa = value; }
        }

        internal List<Proveedor> ListaProveedorT
        {
            get { return listaProveedorT; }
            set { listaProveedorT = value; }
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

        public int Idpersona
        {
            get
            {
                return idpersona;
            }

            set
            {
                idpersona = value;
            }
        }

       
    }
}
