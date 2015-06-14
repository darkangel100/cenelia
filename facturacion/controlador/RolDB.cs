using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using facturacion.modelo;
using MySql.Data.MySqlClient;
using System.Data;

namespace facturacion.controlador
{
    class RolDB
    {
        Conexion cn = new Conexion();
        Rol rols = null;

        public Rol getrol()
        {
            if (this.rols == null)
            {
                rols = new Rol();
            }
            return rols;
        }
        public void setrol(Rol r)
        {
            rols = r;
        }

        public int insertarol(Rol rol)
        {
            int res;
            MySqlCommand cm;
            MySqlConnection con = cn.GetConnection();
            try
            {
                string sqlrol = "Insert rol Values(" + rol.Id_rol + ",'" + rol.Nombre + "')";
                cm = new MySqlCommand(sqlrol, con);
                cm.CommandType = CommandType.Text;
                con.Open();
                res = cm.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                res = 0;
                throw ex;

            }
            catch (Exception ex)
            {
                res = 0;
                throw ex;
            }
            con.Close();
            cm = null;
            return res;
        }
        public int traeid()
        {
            int num = 0;
            MySqlCommand cmd;
            MySqlConnection con = cn.GetConnection();
            try
            {
                string sqlrol = "Select max(SUBSTRING(id_rol,1)) as num from rol";
                cmd = new MySqlCommand(sqlrol, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (DBNull.Value == dr["num"])
                    {
                        num = 0;
                    }
                    else
                    {
                        num = Convert.ToInt32(dr["num"]);
                    }
                }
                dr.Close();
            }
            catch (MySqlException ex)
            {
                num = 0;
                throw ex;
            }
            catch (Exception ex)
            {
                num = 0;
                throw ex;
            }
            con.Close();
            cmd = null;
            return num;
        }
        public List<Rol> TraeRoles(string est)
        {
            Rol rol = null;
            List<Rol> LisRol = new List<Rol>();
            MySqlCommand cmd;
            MySqlConnection con = cn.GetConnection();
            try
            {
                string sqlrol = "Select * from rol where est_rol='" + est + "' order by nombre_rol";
                cmd = new MySqlCommand(sqlrol, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    rol = new Rol();
                    rol.Id_rol = Convert.ToInt32(dr["id_rol"]);
                    rol.Nombre = dr["nombre_rol"].ToString();
                    LisRol.Add(rol);
                }
                dr.Close();
            }
            catch (MySqlException ex)
            {
                rol = null;
                throw ex;
            }
            catch (Exception ex)
            {
                rol = null;
                throw ex;
            }
            cmd = null;
            con.Close();
            return LisRol;

        }
        public Rol TraeRol(int id)
        {
            RolDB r = null;
            MySqlCommand cmd;
            MySqlConnection con = cn.GetConnection();
            try
            {
                string sqlrol = "Select * from rol where est_rol=" + id + "";
                cmd = new MySqlCommand(sqlrol, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    r = new RolDB();
                    r.getrol().Id_rol = Convert.ToInt32(dr["id_rol"]);
                    r.getrol().Nombre = dr["nombre_rol"].ToString();
                }
                dr.Close();
            }
            catch (MySqlException ex)
            {
                r = null;
                throw ex;
            }
            catch (Exception ex)
            {
                r = null;
                throw ex;
            }
            cmd = null;
            con.Close();
            return r.getrol();
        }
        public int ActulizarRol(Rol r)
        {
            MySqlCommand cmd;
            MySqlConnection con = cn.GetConnection();
            int resp;
            try
            {
                string sqlrol = "Update rol set nombre_rol='" + r.Nombre + "'WHERE id_rol=" + r.Id_rol + "";
                cmd = new MySqlCommand(sqlrol, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
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
            cmd = null;
            con.Close();
            return resp;
        }

        public int EliminarRol(int id)
        {
            MySqlCommand cmd;
            MySqlConnection con = cn.GetConnection();
            int resp;
            try
            {
                string sqlrol = "Update rol where id_rol=" + id + " ";
                cmd = new MySqlCommand(sqlrol, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
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
            cmd = null;
            con.Close();
            return resp;
        }

        public int treidsefunnom(string nom)
        {
            int num = 0;
            RolDB r = null;
            MySqlCommand cmd;
            MySqlConnection con = cn.GetConnection();
            try
            {
                string sqlrol = "Select * from rol where nombre_rol='" + nom + "' AND est_rol= 'A'";
                cmd = new MySqlCommand(sqlrol, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    r = new RolDB();
                    num = Convert.ToInt32(dr["id_rol"]);
                }

                dr.Close();
            }
            catch (MySqlException ex)
            {
                num = 0;
                throw ex;
            }
            catch (Exception ex)
            {
                num = 0;
                throw ex;
            }
            con.Close();
            cmd = null;
            return num;

        }
        //public void crearNuevosRoles()
        //{
        //    Rol r1 = new Rol();
        //    r1.Nombre =("Gerente");

        //    InsertaRol(r1);
        //    Rol r2 = new Rol();
        //    r2.Nombre=("Vendedor");

        //    InsertaRol(r2);
        //}
        //public int InsertaRol(Rol r1)
        //{
        //    MySqlCommand cmd;
        //    MySqlConnection cn = con.GetConnection();
        //    int resp;
        //    try
        //    {
        //        string sqlcad = "Insert rol Values ('" + r1  + "')";
        //        cmd = new MySqlCommand(sqlcad, cn);
        //        cmd.CommandType = CommandType.Text;
        //        cn.Open();
        //        resp = cmd.ExecuteNonQuery();
        //    }
        //    catch (MySqlException ex)
        //    {
        //        resp = 0;
        //        throw ex;
        //    }
        //    catch (Exception ex)
        //    {
        //        resp = 0;
        //        throw ex;
        //    }
        //    cn.Close();
        //    cmd = null;
        //    r1 = null;
        //    return resp;
        //}
    }
}
