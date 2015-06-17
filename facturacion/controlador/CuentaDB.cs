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
    class CuentaDB
    {
        Conexion con = new Conexion();
        Cuenta cuenta = null;
        public Cuenta getCuenta()
        {
            if(this.cuenta==null){
                this.cuenta = new Cuenta();
            }
            return this.cuenta;
        }
        public void setCuenta(Cuenta cuenta1)
        {
            this.cuenta = cuenta1;
        }
        public Cuenta iniciarSesion(string user, string passw)
        {
            Cuenta c = null;
            
            return c;
        }


       
        public Cuenta Traecuenta(string ced)
        {
         CuentaDB per = null;
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            try
            {
                string sqlcad = "Select * from cuenta Where usuario='" +ced+"'";
                cmd = new MySqlCommand(sqlcad, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    per = new CuentaDB();
                    per.getCuenta().Usuario21 = dr[1].ToString();
                    per.getCuenta().Clave = dr[2].ToString();
                 
                    
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
            return per.getCuenta();
        }
        public int ingresacuenta(Cuenta cuen)
        {
            int resp;
            MySqlCommand cmd;
            MySqlConnection cnn = con.GetConnection();
            try
            {
                string sqlcuenta = "Insert cuenta values(" + cuen.Id_cuenta + "," + cuen.Usuario21 + ",'" + cuen.Clave + "','" + cuen.Estado + "','" + cuen.Persona.Id_persona + "','" + cuen.Ultimoacceso + "')";
                cmd = new MySqlCommand(sqlcuenta, cnn);
                cmd.CommandType = CommandType.Text;
                cnn.Open();
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
            cnn.Close();
            return resp;

        }
    }
}
