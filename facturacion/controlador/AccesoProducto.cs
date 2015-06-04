using System;
using System.Collections.Generic;
using System.Text;
using facturacion.modelo;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace facturacion.controlador
{
    class AccesoProducto:AccesoDatos
    {
        private Producto producto = null;
        public AccesoProducto():base("producto.obj")
        {
        }
        public void setProducto(Producto producto)
        {
            this.producto = producto;
        }
        public Producto getProducto()
        {
            if(this.producto==null){
                this.producto = new Producto();
            }
            return this.producto;
        }
        public bool modificar(Producto p)
        {
            bool bandera = false;
            try
            {
                int pos = p.Id_producto - 1;
                List<Object> lista = this.listar();
                lista.RemoveAt(pos);
                lista.Insert(pos, p);
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
        public List<object> buscar(string criterio, string texto)
        {
            List<object> lista = new List<object>();

            foreach (Producto p in this.listar())
            {
                if (criterio.Equals("Nombre") == true)
                {

                    if (texto.ToUpper().StartsWith(p.Nombre.ToUpper()))
                    {
                        lista.Add(p);

                    }
                }
                else
                {
                    if (texto.Equals(p.Codigo))
                    {
                        lista.Add(p);
                    }
                }
            }
            return lista;
        }
    }
}
