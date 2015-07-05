using facturacion.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

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
        public int insertaProducto(Produccto producto)
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            int resp;
            try
            {
                string comandoSql = "Insert producto Values ('" + producto.Codigo + "','" + producto.Nombre + "','" + producto.Marca + "','" + producto.Unidad + "','" + producto.Presentacion +  "')";
                cmd = new MySqlCommand(comandoSql, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                resp = cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                resp = 0;
                throw ex;
            }
            catch (Exception ex)
            {
                resp = 0;
                throw ex;
            }
            cn.Close();
            cmd = null;
            cn = null;
            return resp;
        }

        //poner parametro revisar
        public List<Produccto> traerProductos(string cod)
        {
            ProductoDB p = null;
            List<Produccto> listaPro = new List<Produccto>();
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            try
            {
                string comandoSql = "Select * from producto where id_Producto='" + cod + "'";
                cmd = new MySqlCommand(comandoSql, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    p = new ProductoDB();
                    p.getProductos().Codigo = dr[0].ToString();
                    p.getProductos().Nombre = dr[1].ToString();
                    p.getProductos().Marca = dr[2].ToString();
                    p.getProductos().Unidad = dr[3].ToString();
                    p.getProductos().Presentacion = dr[4].ToString();
                    listaPro.Add(p.getProductos());
                }
                dr.Close();
            }
            catch (MySqlException ex)
            {
                p = null;
                throw ex;
            }
            catch (Exception ex)
            {
                p = null;
                throw ex;
            }
            cn.Close();
            cmd = null;
            return listaPro;
        }
        public int actualizaProductoStock(Produccto p)
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            int resp;
            try
            {
                string comandoSql = "Update producto set nombre_prod='" + p.Nombre + "' WHERE id_Producto='" + p.Codigo+ "'";
                cmd = new MySqlCommand(comandoSql, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                resp = cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                resp = 0;
                throw ex;
            }
            catch (Exception ex)
            {
                resp = 0;
                throw ex;
            }
            cn.Close();
            cmd = null;
            return resp;
        }
    }
}
