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
    class PersonaDB
    {
        
        Conexion con = new Conexion();
        Persona per = null;

        public Persona getPersona()
        {
            if (this.per == null)
            {
                this.per = new Persona();
            }
            return this.per;
        }
        public void setPersona(Persona pers)
        {
            this.per = pers;
        }
        public void limpiar()
        {
            this.per = null;
        }
        public int InsertaCliente(Persona per)
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            int resp;
            try
            {
                string sqlcad = "Insert persona Values ('" + per.Cedula + "','" + per.Nombre + "','" + per.Apellido + "','" + per.Direccion + "','" + per.Telefono + "','" + per.Estado + "','"+per.Rol+"')";
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
        public List<Persona> TraeClientes(string est)
        {
           PersonaDB per = null;
            List<Persona> ListaCli = new List<Persona>();
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            try
            {
                string sqlcad = "Select * from cliente where est_per='" + est + "' order by ape_per";
                cmd = new MySqlCommand(sqlcad, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    per = new PersonaDB();
                    per.getPersona().Cedula = dr[0].ToString();
                    per.getPersona().Apellido = dr[1].ToString();
                    per.getPersona().Nombre= dr[2].ToString();
                    per.getPersona().Direccion = dr[3].ToString();
                    per.getPersona().Telefono= dr[4].ToString();
                    per.getPersona().Estado= dr[5].ToString();

                    per.getPersona().Nombre = per.getPersona().Apellido + " " + per.getPersona().Nombre;
                    ListaCli.Add(per.getPersona());
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
            return ListaCli;
        }
        public Persona TraeCliente(string ced)
        {
          PersonaDB per = null;
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            try
            {
                string sqlcad = "Select * from persona Where ced_per='" + ced + "'";
                cmd = new MySqlCommand(sqlcad, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    per = new PersonaDB();
                    per.getPersona().Cedula = dr[0].ToString();
                    per.getPersona().Apellido = dr[1].ToString();
                    per.getPersona().Nombre= dr[2].ToString();
                    per.getPersona().Direccion = dr[3].ToString();
                    per.getPersona().Telefono = dr[4].ToString();
                    per.getPersona().Estado = dr[5].ToString();
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

        public int ActualizaCliente(Persona per)
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            int resp;
            try
            {

                string sqlcad = "Update persona set ape_per='" + per.Apellido + "',nom_per='" + per.Nombre + "',dir_per='" + per.Direccion + "',tel_per='" + per.Telefono + "',est_per='" + per.Estado + "' WHERE ced_per='" + per.Cedula + "'";
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
            return resp;
        }
        public int EliminaCliente(string ced)
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            int resp = 0;
            try
            {
                string sqlcad = "Update persona set est_per='P' WHERE ced_per='" + ced + "'";
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
            return resp;
        }


    }
}
