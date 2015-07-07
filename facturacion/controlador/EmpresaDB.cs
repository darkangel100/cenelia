using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using facturacion.modelo;
using MySql.Data.MySqlClient;
using System.Data;

namespace facturacion.controlador
{
    class EmpresaDB
    {
        Conexion con = new Conexion();
       Empresa empre = null;

        public Empresa getEmpresa ()
        {
            if (this.empre == null)
            {
                this.empre = new Empresa();
            }
            return this.empre;
        }
        public void setEmpresa(Empresa empres)
        {
            this.empre = empres;
        }
        public void limpiar()
        {
            this.empre = null;
        }

        public List<Empresa> TraeEmpresas()
        {
           EmpresaDB  emp = null;
            List<Empresa> Listaempresa= new List<Empresa>();
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            try
            {
                string sqlcad = "Select * from empresa  order by nombre_empresa";
                cmd = new MySqlCommand(sqlcad, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    emp = new EmpresaDB();
                    emp.getEmpresa().IdEmpresa =int.Parse( dr[0].ToString());
                    emp.getEmpresa().NombreEmpresa = dr[1].ToString();
                    emp.getEmpresa().Direccion = dr[2].ToString();
                    emp.getEmpresa().Pais = dr[3].ToString();
                    emp.getEmpresa().Telefono = dr[4].ToString();
                   
                    Listaempresa. Add(emp.getEmpresa());
                }
                dr.Close();
            }
            catch (MySqlException ex)
            {
                emp = null;
                throw ex;
            }
            catch (Exception ex)
            {
             emp= null;
                throw ex;
            }
            cn.Close();
            cmd = null;
            return Listaempresa;
        }
        public int InsertaEmpresa(Empresa emp)
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            int resp;
            try
            {
               // string sqlcad = "Insert Empresa Values ('" + emp.NombreEmpresa + "','" + emp.Direccion+ "','" + emp.Pais + "','" + emp.Telefono + "')";
                string comandoSql = "Insert empresa set nombre_empresa='" + emp.NombreEmpresa + "', direccion='" +emp.Direccion + "', pais='" + emp.Pais + "', telefono='" +emp.Telefono + "'";
                
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
            emp = null;
            return resp;
        }
        public int ActualizaEmpresa(Empresa emp)
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            int resp;
            try
            {

                string sqlcad = "Update empresa set nombre_empresa='" + emp.NombreEmpresa+ "',direccion='" + emp.Direccion+ "',pais='" + emp.Pais + "',telefono='" + emp.Telefono + "',estado='" + emp.Estado+ "' WHERE idEmpresa='" + emp.IdEmpresa + "'";
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
        public Empresa TraeEmpresa(int ced)
        {
           EmpresaDB emp = null;
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            try
            {
                string sqlcad = "Select * from empresa Where idEmpresa='" + ced + "'";
                cmd = new MySqlCommand(sqlcad, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    emp = new EmpresaDB();
                    emp.getEmpresa().IdEmpresa= int.Parse(dr[0].ToString());
                    emp.getEmpresa().NombreEmpresa = dr[1].ToString();
                    emp.getEmpresa().Direccion = dr[2].ToString();
                    emp.getEmpresa().Pais = dr[3].ToString();
                    emp.getEmpresa().Telefono= dr[4].ToString();
                    emp.getEmpresa().Estado = dr[5].ToString();
                    
                }
                dr.Close();
            }
            catch (MySqlException ex)
            {
                emp = null;
                throw ex;
            }
            catch (Exception ex)
            {
                emp = null;
                throw ex;
            }
            cn.Close();
            cmd = null;
            return emp.getEmpresa();
        }
        public string TraeEmpresanombre(int ced)
        {
            EmpresaDB emp = null;
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            string nombre="";
            try
            {
                string sqlcad = "Select * from empresa Where idEmpresa='" + ced + "'";
                cmd = new MySqlCommand(sqlcad, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    emp = new EmpresaDB();
                  //  emp.getEmpresa().IdEmpresa = int.Parse(dr[0].ToString());
                    nombre = dr[1].ToString();
                    //emp.getEmpresa().Direccion = dr[2].ToString();
                    //emp.getEmpresa().Pais = dr[3].ToString();
                    //emp.getEmpresa().Telefono = dr[4].ToString();
                    //emp.getEmpresa().Estado = dr[5].ToString();

                }
                dr.Close();
            }
            catch (MySqlException ex)
            {
                emp = null;
                throw ex;
            }
            catch (Exception ex)
            {
                emp = null;
                throw ex;
            }
            cn.Close();
            cmd = null;
            return nombre;
        }
        
    }
}
