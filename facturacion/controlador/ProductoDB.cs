using facturacion.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace facturacion.controlador
{
    class ProductoDB
    {
        Conexion con = new Conexion();
        Produccto pro = null;

        public Produccto getProductos()
        {
            if (this.pro == null)
            {
                this.pro = new Produccto();
            }
            return this.pro;
        }
        public void setProductos(Produccto prod)
        {
            this.pro = prod;
        }
        public void limpiar()
        {
            this.pro = null;
        }
        public int Traecodigo()
        {
            int nro = 0;
            MySqlConnection cn = con.GetConnection();
            MySqlCommand cmd;
            try
            {
                string sqlcad = "Select max(SUBSTRING(id_Producto,3))as nro from producto";
                cmd = new MySqlCommand(sqlcad, cn);
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (DBNull.Value == dr["nro"])
                    {
                        nro = 0;
                    }
                    else
                    {
                        nro = Convert.ToInt32(dr["nro"]);
                    }
                }
                dr.Close();
            }
            catch (MySqlException ex)
            {
                nro = 0;
                throw ex;
            }
            catch (Exception ex)
            {
                nro = 0;
                throw ex;
            }
            cn.Close();
            cmd = null;
            return nro;
        }


    }
}
