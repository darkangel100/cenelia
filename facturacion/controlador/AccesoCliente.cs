using System;
using System.Collections.Generic;
using System.Text;
using facturacion.modelo;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace facturacion.controlador
{
    class AccesoCliente:AccesoDatos
    {
        private Persona cliente = null;
        public AccesoCliente(): base("cliente.obj")
        {
            
        }
        public Persona getCliente()
        {
            if(this.cliente==null)
            {
                this.cliente = new Persona();
                Direccion direccion = new Direccion();
                this.cliente.Direccion = direccion;
            }
            return this.cliente;
        }
        public void setCliente(Persona cliente)
        {
            this.cliente = cliente;
        }
        public void limpiar()
        {
            this.cliente = null;
        }
        public List<object> buscar(string criterio, string texto)
        {
            List<object> lista = new List<object>();
            
            foreach(Persona p in this.listar())
            {
                if (criterio.Equals("Apellido") == true)
                {
                    
                    if (texto.ToUpper().StartsWith(p.Apellido.ToUpper()))
                    {
                        lista.Add(p);
                        
                    }
                }
                else
                {
                    if(texto.Equals(p.Cedula))
                    {
                        lista.Add(p);
                    }
                }
            }
            return lista;
        }
        public bool modificar(Persona p)
        {
            bool bandera = false;
            try
            {
                int pos = p.Id_persona - 1;
                List<Object> lista = this.listar();
                lista.RemoveAt(pos);
                lista.Insert(pos,p);
                FileStream stream = new FileStream(this.Direccion, FileMode.Create);
                BinaryFormatter formato = new BinaryFormatter();                
                formato.Serialize(stream, lista);
                stream.Close();
                bandera = true;
            }
            catch (Exception ex)
            {
            }
            return bandera;
        }
    }
}
