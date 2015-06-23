using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace facturacion.modelo
{
    class Empresa
    {
        private int idEmpresa;
        private string nombreEmpresa;
        private string direccion;
        private string pais;
        private string telefono;
        private string estado = "Activo";
        private List<Empresa> listaEmpresas = new List<Empresa>();

      public List<Empresa> ListaEmpresas
        {
            get { return listaEmpresas; }
            set { listaEmpresas = value; }
        }

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
     
        public string NombreEmpresa
        {
            get { return nombreEmpresa; }
            set { nombreEmpresa = value; }
        }
        
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
       
        public string Pais
        {
            get { return pais; }
            set { pais = value; }
        }
       

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        




    }
}
