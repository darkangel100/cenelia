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
        //es este
        public int InsertaCliente(Persona per)
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            int resp;
            try
            {
                string comandoSql = "Insert persona set cedula='" + per.Cedula + "', nombre_per='" +per.Nombre + "', apellido_per='" + per.Apellido + "', direccion='" + per.Direccion +"',telefono='"+per.Telefono+"',Rol_idrol='"+per.Id_rol+ "'";
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
            per = null;
            return resp;
        }
        public List<Persona> TraePersonasC(string letra)//metodo trae cliente por cedula
        {
            PersonaDB per = null;
            List<Persona> ListaCli = new List<Persona>();
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            try
            {
              
                string sqlcad = " select * from persona where rol_idrol=0 and   cedula=  '" + letra + "'";
                cmd = new MySqlCommand(sqlcad, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    per = new PersonaDB();
                    per.getPersona().Id_persona = int.Parse(dr[0].ToString());
                    per.getPersona().Cedula = dr[1].ToString();
                    per.getPersona().Nombre = dr[2].ToString();
                    per.getPersona().Apellido = dr[3].ToString();
                    per.getPersona().Direccion = dr[4].ToString();
                    per.getPersona().Telefono = dr[5].ToString();
                    per.getPersona().Estado = dr[6].ToString();

                    //per.getPersona().Nombre = per.getPersona().Apellido + " " + per.getPersona().Nombre;
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
        public List<Persona> TraePersonas(string letra)//metodo trae cliente por apellido
        {
            PersonaDB per = null;
            List<Persona> ListaCli = new List<Persona>();
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            try
            {
       
                string sqlcad = " select * from persona where rol_idrol=0 and   apellido_per LIKE '%" + letra + "%'";
                cmd = new MySqlCommand(sqlcad, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    per = new PersonaDB();
                    per.getPersona().Id_persona = int.Parse(dr[0].ToString());
                    per.getPersona().Cedula = dr[1].ToString();
                    per.getPersona().Nombre = dr[2].ToString();
                    per.getPersona().Apellido = dr[3].ToString();
                    per.getPersona().Direccion = dr[4].ToString();
                    per.getPersona().Telefono = dr[5].ToString();
                    per.getPersona().Estado = dr[6].ToString();

                    //per.getPersona().Nombre = per.getPersona().Apellido + " " + per.getPersona().Nombre;
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
        public Persona TraePersona(string ced)//metodo para  traer un solo cliente cliente
        {
          PersonaDB per = null;
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            try
            {
                string sqlcad = "Select * from persona Where rol_idrol=0 and    cedula='" + ced + "'";
                cmd = new MySqlCommand(sqlcad, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    per = new PersonaDB();
                    per.getPersona().Id_persona = int.Parse( dr[0].ToString());
                    per.getPersona().Cedula = dr[1].ToString();
                    per.getPersona().Nombre = dr[2].ToString();
                    per.getPersona().Apellido= dr[3].ToString();
                    per.getPersona().Direccion = dr[4].ToString();
                    per.getPersona().Telefono = dr[5].ToString();
                    per.getPersona().Estado = dr[6].ToString();
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

        public int ActualizaCliente(Persona per)//metodo para modificar Cliente
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            int resp;
            try
            {

                string sqlcad = "Update persona set nombre_per='" + per.Nombre + "',apellido_per='" + per.Apellido + "',direccion='" + per.Direccion + "',telefono='" + per.Telefono + "' WHERE cedula='" + per.Cedula + "'";
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
        }//metodo para cambiar de estado a un cliente

        public string traenumero()
        {
            MySqlConnection cn = con.GetConnection();
            MySqlCommand cmd;
            string num = "";
            try
            {
                string Sqlcad = "Select max(idpersona)as num from Persona";
                cmd = new MySqlCommand(Sqlcad, cn);
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    num = dr["num"].ToString();
                }
                dr.Close();
            }
            catch (MySqlException ex)
            {
                num = "";
                throw ex;
            }
            catch (Exception ex)
            {
                num = "";
                throw ex;
            }
            cn.Close();
            cmd = null;
            return num;
        }//trae numrero
        public int traeId(string nom)//trae id de rol
        {
            int num = 0;
            //RolDB r = null;
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            try
            {
                string sqlrol = "Select * from rol where nombre='" + nom + "'";
                cmd = new MySqlCommand(sqlrol, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    num = Convert.ToInt32(dr["idrol"]);
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
            cn.Close();
            cmd = null;
            return num;

        }
        public Persona TraePersonaP(string ced)//metodo para  traer un solo cliente cliente
        {
            PersonaDB per = null;
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            try
            {
                string sqlcad = "Select * from persona Where rol_idrol=3 and    cedula='" + ced + "'";
                cmd = new MySqlCommand(sqlcad, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    per = new PersonaDB();
                    per.getPersona().Id_persona = int.Parse(dr[0].ToString());
                    per.getPersona().Cedula = dr[1].ToString();
                    per.getPersona().Nombre = dr[2].ToString();
                    per.getPersona().Apellido = dr[3].ToString();
                    per.getPersona().Direccion = dr[4].ToString();
                    per.getPersona().Telefono = dr[5].ToString();
                    per.getPersona().Estado = dr[6].ToString();
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
        
    }
}
