using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using facturacion.modelo;
using System.Data;

namespace facturacion.controlador
{
    class UsuarioDB
    {
        Conexion con = new Conexion();
        Persona per = null;



        private Persona usuario = null;

        public Persona getUsuario()
        {
            if (this.usuario == null)
            {
                this.usuario = new Persona();
            }
            return this.usuario;
        }
        public void setUsuario(Persona usuario)
        {
            this.usuario = usuario;
        }







       
        public int InsertaUsuario(Persona per)
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            int resp;
            try
            {
               
                string sqlcad = "Insert persona Values ('" + per.Cedula + "','" + per.Nombre + "','" + per.Apellido + "','" + per.Direccion + "','" + per.Telefono + "','" + per.Estado + "','" + per.Rol.Id_rol + "')";
                cmd = new MySqlCommand(sqlcad, cn);
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
            per = null;
            return resp;
        }
        //public int ActualizaUsuario(Persona per)
        //{
        //    MySqlCommand cmd;
        //    MySqlConnection cn = con.GetConnection();
        //    int resp;
        //    try
        //    {
        //        string sqlcad = "Update Persona set cedula='" + per.Cedula + "',nom_per='" + per.Nombre + "',apellido_per='" + per.Apellido + "',direccion='" + per.Direccion + "',telefono='" + per.Telefono + "',estado='" + per.Estado + "',Rol_idRol='" + per.Rol.Id_rol+ "' WHERE ced_usu='" + per.Cedula + "'";
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
        //    return resp;
        //}
        public List<Persona> TraeUsuarios()
        {
            PersonaDB per = null;
            List<Persona> ListaUsu = new List<Persona>();
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            try
            {
                string sqlcad = "Select * from persona where rol_idrol=1 || rol_idrol=2 ";
                cmd = new MySqlCommand(sqlcad, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    per = new PersonaDB();
                    per.getPersona().Cedula = dr[0].ToString();
                    per.getPersona().Nombre = dr[1].ToString();
                    per.getPersona().Apellido= dr[2].ToString();
                    per.getPersona().Direccion = dr[3].ToString();
                    per.getPersona().Telefono= dr[4].ToString();
                    per.getPersona().Estado = dr[5].ToString();
                    per.getPersona().Cuenta.Usuario21= dr[6].ToString();
                    per.getPersona().Cuenta.Rol.Nombre = dr[7].ToString();

                    per.getPersona().Nombre = per.getPersona().Apellido + " " + per.getPersona().Nombre;
                    ListaUsu.Add(per.getPersona());
                }
                dr.Close();
            }
            catch (MySqlException ex)
            {
                per = null;
                throw ex;
            }
            catch (Exception ex)
            {
                per = null;
                throw ex;
            }
            cn.Close();
            cmd = null;
            return ListaUsu;
        }
        public Persona TraeUsuario(string ced)
        {
            PersonaDB per = null;
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            try
            {
                string sqlcad = "Select * from Usuario Where ced_usu='" + ced + "'";
                cmd = new MySqlCommand(sqlcad, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    per = new PersonaDB();
                    per.getPersona().Cedula = dr[0].ToString();
                    per.getPersona().Nombre = dr[1].ToString();
                    per.getPersona().Apellido= dr[2].ToString();
                    per.getPersona().Direccion = dr[3].ToString();
                    per.getPersona().Telefono= dr[4].ToString();
                    per.getPersona().Estado= dr[5].ToString();
                    per.getPersona().Cuenta.Clave = dr[6].ToString();
                    per.getPersona().Cuenta.Rol.Nombre = dr[7].ToString();
                }
                dr.Close();
            }
            catch (MySqlException ex)
            {
                per = null;
                throw ex;
            }
            catch (Exception ex)
            {
                per = null;
                throw ex;
            }
            cn.Close();
            cmd = null;
            return per.getPersona();
        }
        //public int EliminaUsuario(string ced)
        //{
        //    MySqlCommand cmd;
        //    MySqlConnection cn = con.GetConnection();
        //    int resp = 0;
        //    try
        //    {
        //        string sqlcad = "Update Usuario set est_usu='P' WHERE ced_usu='" + ced + "'";
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
        //    return resp;
        //}
    }
}
