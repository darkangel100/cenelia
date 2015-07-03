using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using facturacion.modelo;

namespace facturacion.controlador
{
    class ProveedorDB
    {
        Conexion con = new Conexion();
        
         Proveedor proveedor = null;

        public Proveedor getProveedor()
        {
            if (this.proveedor == null)
            {
                this.proveedor = new Proveedor();
            }
            return this.proveedor;
        }
        public void setProveedor(Proveedor proveedors)
        {
            this.proveedor = proveedors;
        }
        public int traeId(string nom)
        {
            int num = 0;
            //RolDB r = null;
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            try
            {
                string sqlrol = "Select * from proveedor where persona_idpersona='" + nom + "'";
                cmd = new MySqlCommand(sqlrol, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    num = Convert.ToInt32(dr["idempresa"]);
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

        public int traeidEmpresa(string nom)
        {
            int num = 0;
            //RolDB r = null;
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            try
            {
                string sqlrol = "Select * from empresa where nombre_empresa='" + nom + "'";
                cmd = new MySqlCommand(sqlrol, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    num = Convert.ToInt32(dr["idempresa"]);
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


        public int Actualizaprovedor(Proveedor per)//metodo para modificar Cliente
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            int resp;
            try
            {

                string sqlcad = "Update proveedor set empresa_idempresa='" + per.IdEmpresa + "' WHERE persona_idpersona='" + per.Idpersona + "'";
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
        public int InsertaProveedor(Proveedor per)
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            int resp;
            try
            {
                string sqlcad = "Insert proveedor set ruc='" + per.Ruc + "', persona_idpersona='" +per.Idpersona+ "', empresa_idempresa='" + per.IdEmpresa + "'";
               // string sqlcad = "Insert proveedor Values ('" + per.Ruc + "','" + per.Id_persona + "','" + per.IdEmpresa+  "')";
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
        //        string sqlcad = "Update Persona set ape_per='" + per.Apellido + "',nom_per='" + per.Nombre + "',dir_per='" + per.Direccion + "',tel_per='" + per.Telefono + "',est_per='" + per.Estado +  "' WHERE ced_per='" + per.Cedula + "'";
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
        public List<Persona> TraeProveedoresC(string letra)
        {
            PersonaDB per = null;
            List<Persona> ListaCli = new List<Persona>();
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            try
            {

                string sqlcad = " select * from persona where rol_idrol=3 and   cedula=  '" + letra + "'";
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
        public Persona  TraeProveedor(string ced)
        {
           PersonaDB per = null;
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            try
            {
                string sqlcad = "Select * from Persona Where cedula='" + ced + "'";
                cmd = new MySqlCommand(sqlcad, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    per = new PersonaDB();
                    per.getPersona().Cedula = dr[0].ToString();
                    per.getPersona().Apellido = dr[1].ToString();
                    per.getPersona().Nombre = dr[2].ToString();
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
        public int EliminaProveedor(string ced)
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            int resp = 0;
            try
            {
                string sqlcad = "Update Proveedor set est_per='P' WHERE ced_per='" + ced + "'";
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
        public List<Persona> Traeproveedores(string letra)
        {
          PersonaDB per = null;
            List<Persona> ListaCli = new List<Persona>();
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            try
            {

                string sqlcad = " select * from persona where rol_idrol=3 and   apellido_per LIKE '%" + letra + "%'";
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
                  //per.getPersona().Id_persona = int.Parse(dr[7].ToString());
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
        public List<Proveedor > Tablaproveedor()
        {
            ProveedorDB per = null;
            List<Proveedor> ListaProvee = new List<Proveedor>();
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            try
            {

                string sqlcad = " select * from proveedor ";
                cmd = new MySqlCommand(sqlcad, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    per = new ProveedorDB();
                    per.getProveedor().Ruc= dr[0].ToString();
                 per.getProveedor().Idpersona= int.Parse(dr[1].ToString());
                    per.getProveedor().Estado = dr[2].ToString();
                    per.getProveedor().IdEmpresa= int.Parse(dr[3].ToString());
                   
                    ListaProvee.Add(per.getProveedor());
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
            return ListaProvee;
        }
        public int traeidPersona(string ced)
        {
            int num = 0;
           // RolDB r = null;
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            try
            {
                string sqlrol = "Select * from persona where cedula='" + ced + "'";
                cmd = new MySqlCommand(sqlrol, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    num = Convert.ToInt32(dr["idpersona"]);
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
    }
}
