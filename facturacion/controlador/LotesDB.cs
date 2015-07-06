using facturacion.modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace facturacion.controlador
{
    class LotesDB
    {
        Conexion con = new Conexion();
       Lote lote = null;

        public Lote getLote()
        {
            if (this.lote == null)
            {
                this.lote = new Lote();
            }
            return this.lote;
        }
        public void setLote(Lote lot)
        {
            this.lote = lot;
        }
        public void limpiar()
        {
            this.lote = null;
        }
        public int Traecodigo()
        {
            int nro = 0;
            MySqlConnection cn = con.GetConnection();
            MySqlCommand cmd;
            try
            {
                string sqlcad = "Select max(SUBSTRING(idLote,3))as nro from lote";
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
        public int insertaLote(Lote lote)
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            int resp;
            try
            {
                string comandoSql = "Insert producto Values ('" + lote.Id_Lote + "','" + lote.Fechcad + "','" + lote.Fechelab + "'," + lote.Pc + "," + lote.Pv + ", '" + lote.Caduca + "')";
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
        public List<Lote> traerLotes(string lot)
        {
            LotesDB l = null;
            List<Lote> listalote = new List<Lote>();
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            try
            {
                string comandoSql = "Select * from producto where idLote='" + lot + "'";
                cmd = new MySqlCommand(comandoSql, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    l = new LotesDB();
                    l.getLote().Id_Lote = int.Parse(dr[0].ToString());
                    l.getLote().Pc = double.Parse(dr[1].ToString());
                    l.getLote().Pv = double.Parse(dr[2].ToString());
                    l.getLote().Stock = dr[3].ToString();
                    l.getLote().Fechcad = Convert.ToDateTime( dr[4].ToString());
                    l.getLote().Fechelab = Convert.ToDateTime(dr[5].ToString());
                    listalote.Add(l.getLote());
                }
                dr.Close();
            }
            catch (MySqlException ex)
            {
                l = null;
                throw ex;
            }
            catch (Exception ex)
            {
                l = null;
                throw ex;
            }
            cn.Close();
            cmd = null;
           return listalote;
        }
        public Produccto traeLote(string lot)
        {
            Produccto p = null;
            Lote l = null;
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            try
            {
                string comandoSql = "Select * from producto where idLote='" + lot + "'";
                cmd = new MySqlCommand(comandoSql, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    p = new Produccto();
                    l = new Lote();
                    l.Id_Lote = int.Parse(dr["idLote"].ToString());
                    l.Fechcad= Convert.ToDateTime(dr["fechacadu_lote"].ToString());
                    l.Stock= dr["stock_lote"].ToString();
                    l.Fechelab = Convert.ToDateTime( dr["fechaelab"].ToString());
                    l.Pv= double.Parse( dr["pv_lote"].ToString());
                    l.Pc = double.Parse(dr["pc_lote"].ToString());
                    l.Caduca = Convert.ToDateTime(dr["caduca"].ToString());

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
        public int actualizaLotesStock(Lote l)
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            int resp;
            try
            {
                string comandoSql = "Update producto set fechaelab='" + l.Fechelab + "' WHERE idLote='" + l.Id_Lote + "'";
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
