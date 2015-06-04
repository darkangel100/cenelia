using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace facturacion.controlador
{
    class AccesoDatos
    {
        private String direccion = Utiles.ObtenerRuta();

        public String Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public AccesoDatos()
        {

        }
        public AccesoDatos(String dir)
        {
            this.direccion = this.direccion + "/facturacion/archivos/"+ dir;
        }
        public bool guardar(Object obj)
        {
            bool band = false;
            try
            {
                List<Object> lista = listar();
                FileStream stream = new FileStream(this.Direccion, FileMode.Create);
                BinaryFormatter formato = new BinaryFormatter();                
                lista.Add(obj);
                formato.Serialize(stream,lista);
                stream.Close();
                band = true;
            }
            catch (Exception ex)
            {                
            }
            return band;
        }
        public List<Object> listar()
        {
            List<Object> lista = new List<Object>();
            try
            {
                FileStream stream = new FileStream(this.Direccion,FileMode.Open);
                BinaryFormatter formato = new BinaryFormatter();
                lista = (List<Object>)(formato.Deserialize(stream));
                stream.Close();
            }
            catch (Exception ex)
            {

            }
            return lista;
        }

        public int generarId()
        {
            int id = 1;
            if(this.listar().Count>0)
            {
                id = this.listar().Count + 1;
            }
            return id;
        }
        
    }
}
