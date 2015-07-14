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
                string comandoSql = "Insert producto Values ('" + producto.Codigo + "','" + producto.Nombre + "','" + producto.Unidad + "','" + producto.Presentacion + "','" + producto.Marca +  "')";
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
        public List<Produccto> traerProductosfai(string cod)
        {
            ProductoDB p = null;
            LotesDB L = null;
            List<Produccto> listaPro = new List<Produccto>();
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            try

            {
              //  apellido_per LIKE '%" + letra + "%'"
                string comandoSql = "Select * from produccto where nombre_prod LIKE '%" + cod + "%'";
                cmd = new MySqlCommand(comandoSql, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    p = new ProductoDB();
                    L = new LotesDB();
                    p.getProductos().Codigo = dr[0].ToString();
                    p.getProductos().Nombre = dr[1].ToString();
                    p.getProductos().Unidad = dr[2].ToString();
                    p.getProductos().Presentacion = dr[3].ToString();
                    p.getProductos().Marca= dr[4].ToString();
                    p.getProductos().Id_lote =int.Parse(dr[5].ToString());
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
        public Produccto traeProducto(string cod)
        {
            Produccto p = null;
            Lote l = null;
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            try
            {
                string comandoSql = "Select * from produccto where id_Producto='" + cod + "'";
                cmd = new MySqlCommand(comandoSql, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    p = new Produccto();
                    l = new Lote();
                    p.Codigo = dr["id_Producto"].ToString();
                    p.Nombre = dr["nombre_prod"].ToString();
                    p.Unidad = dr["unidad"].ToString();
                    p.Presentacion = dr["presentacion"].ToString();
                    p.Marca = dr["marca_prod"].ToString();
                    p.Id_lote= int.Parse(dr["idLote"].ToString());
                    
                    
                   
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
            
            return p;
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

        //public List<Produccto> listarProductos()
        //{
        //    ProductoDB p = null;
        //    List<Produccto> listaPro = new List<Produccto>();
        //    MySqlCommand cmd;
        //    MySqlConnection cn = con.GetConnection();
        //    try
        //    {
        //        string comandoSql = "SELECT produccto.*, lote.fechacadu_lote, lote.fechaelab, lote.stock_lote FROM produccto INNER JOIN lote ON lote.idLote = produccto.idLote";
        //        cmd = new MySqlCommand(comandoSql, cn);
        //        cmd.CommandType = CommandType.Text;
        //        cn.Open();
        //        MySqlDataReader dr = cmd.ExecuteReader();
        //        while (dr.Read())
        //        {

        //            p = new ProductoDB();

        //            p.getProductos().Id_producto = Convert.ToInt32(dr[0].ToString());
        //            p.getProductos().Nombre = dr[1].ToString();
        //            p.getProductos().Unidad = dr[2].ToString();
        //            p.getProductos().Presentacion = dr[3].ToString();
        //            p.getProductos().Marca = dr[4].ToString();

        //            p.getProductos().Id_producto = Convert.ToInt32(dr[5].ToString());
        //            p.getProductos().Lote_obj.Stock= dr[9].ToString();
        //            listaPro.Add(p.getProductos());
        //        }
        //        dr.Close();
        //    }
        //    catch (MySqlException ex)
        //    {
        //        p = null;
        //        throw ex;
        //    }
        //    catch (Exception ex)
        //    {
        //        p = null;
        //        throw ex;
        //    }
        //    cn.Close();
        //    cmd = null;
        //    return listaPro;
        //}

    }
}
