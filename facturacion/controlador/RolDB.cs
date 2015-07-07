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
        Conexion con = new Conexion();
     
        
        private Rol rol = null;
       
        public Rol getRol()
        {
            if (this.rol == null)
            {
                this.rol = new Rol();
            }
            return this.rol;
        }
        public void setRol(Rol rol)
        {
            this.rol = rol;
        }
        


        public int generarId()
        {
            int id = 1;
            if (id > 0)
            {
                id +=  1;
            }
            return id;
        }
        public void crearNuevosRoles()
        {
            
           Rol r3 = new Rol();
            r3.Nombre ="Cliente";
            r3.Id_rol = 0;
            InsertaRol(r3);
            Rol r2 = new Rol();
            r2.Nombre="Vendedor";
            r2.Id_rol = 1;
            InsertaRol(r2);
            Rol r1 = new Rol();
            r1.Nombre = "Gerente";
            r1.Id_rol = 2;
            InsertaRol(r1);
            
            Rol r4 = new Rol();
            r4.Nombre = "proveedor";
            r4.Id_rol = 3;
            InsertaRol(r4);
        }
        public int InsertaRol(Rol rol)
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            int resp;
            try
            {
                string sqlcad = "Insert Rol Values ('" + rol.Id_rol + "','" + rol.Nombre+"')";
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
           
            cn.Close();
            cmd = null;
            rol = null;
            return resp;
        }
        public List<Rol> TraeRol()
        {
           Rol cat = null;
            List<Rol> ListaCat = new List<Rol>();
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            try
            {
                string sqlcad = "Select * from Rol where idrol=1||idrol=2 order by nombre";
                cmd = new MySqlCommand(sqlcad, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cat = new Rol();
                    cat.Nombre = dr["Nombre"].ToString();
                    cat.Id_rol = Convert.ToInt32(dr["idrol"]);
                    ListaCat.Add(cat);
                }
                dr.Close();
            }
            catch (MySqlException ex)
            {
                cat = null;
                throw ex;
            }
            catch (Exception ex)
            {
                cat = null;
                throw ex;
            }
            cn.Close();
            cmd = null;
            return ListaCat;
        }
        //Metodo para traer el id del Rol
       

    }
}
