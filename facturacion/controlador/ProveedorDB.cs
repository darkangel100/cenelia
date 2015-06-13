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
        Persona per = null;

        public Persona getPersona()
        {
            if (this.per == null)
            {
                this.per = new Persona();
              Proveedor proveedor = new Proveedor();
                this.per.Proveedor = proveedor;
               
            }
            return this.per;
        }


        ////REVISAR LA ASIGN ACION DE LA EMPRESA AL PROVEEDOR

        //public Persona getPersona()
        //{
        //    if (this.persona == null)
        //    {
        //        this.persona = new Persona();
        //        Direccion direccion = new Direccion();
        //        this.persona.Direccion = direccion;
        //    }
        //    return this.persona;
        //}
        public void setPersona(Persona pers)
        {
            this.per = pers;
        }
        public void limpiar()
        {
            this.per = null;
        }
        public int InsertaProveedor(Persona per)
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            int resp;
            try
            {
                string sqlcad = "Insert Persona Values ('" + per.Cedula + "','" + per.Apellido + "','" + per.Nombre + "','" + per.Direccion + "','" + per.Telefono + "','" + per.Estado + "')";
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
        public int ActualizaUsuario(Persona per)
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            int resp;
            try
            {
                string sqlcad = "Update Persona set ape_per='" + per.Apellido + "',nom_per='" + per.Nombre + "',dir_per='" + per.Direccion + "',tel_per='" + per.Telefono + "',est_per='" + per.Estado +  "' WHERE ced_per='" + per.Cedula + "'";
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
        public List<Persona> Traepersonas(string est)
        {
           ProveedorDB per = null;
            List<Persona> ListaProveedor = new List<Persona>();
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            try
            {
                string sqlcad = "Select * from proveedor where est_per='" + est + "' order by ape_per";
                cmd = new MySqlCommand(sqlcad, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    per = new ProveedorDB();
                    per.getPersona().Cedula = dr[0].ToString();
                    per.getPersona().Apellido = dr[1].ToString();
                    per.getPersona().Nombre= dr[2].ToString();
                    per.getPersona().Direccion = dr[3].ToString();
                    per.getPersona().Telefono= dr[4].ToString();
                    per.getPersona().Estado= dr[5].ToString();
                    
                    per.getPersona().Nombre = per.getPersona().Apellido+ " " + per.getPersona().Nombre;
              ListaProveedor.Add(per.getPersona());
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
            return ListaProveedor;
        }
        public Persona Traepersona(string ced)
        {
           ProveedorDB per = null;
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            try
            {
                string sqlcad = "Select * from Proveedor Where ced_per='" + ced + "'";
                cmd = new MySqlCommand(sqlcad, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    per = new ProveedorDB();
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
    }
}
