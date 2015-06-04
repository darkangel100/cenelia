using System;
using System.Collections.Generic;
using System.Text;
using facturacion.modelo;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace facturacion.controlador
{
    class AccesoMarca:AccesoDatos
    {
        Marca marca = null;
        public AccesoMarca(): base("marca.obj")
        {

        }
        public void setMarca(Marca marca)
        {
            this.marca = marca;
        }
        public Marca getMarca()
        {
            if (this.marca == null)
            {
                this.marca = new Marca();
            }
            return this.marca;
        }
        public void limpiar()
        {
            this.marca = null;
        }
        public List<object> buscar(string criterio, string texto)
        {
            List<object> lista = new List<object>();

            foreach (Marca p in this.listar())
            {
                if (criterio.Equals("Nombre") == true)
                {

                    if (texto.ToUpper().StartsWith(p.Nombre.ToUpper()))
                    {
                        lista.Add(p);
                    }
                }
                
            }
            return lista;
        }
        public bool modificar(Marca p)
        {
            bool bandera = false;
            try
            {
                int pos = p.Id_marca - 1;
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
    }
}
