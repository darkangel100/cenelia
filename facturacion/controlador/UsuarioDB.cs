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

        public List<Persona> Traeusuarios()
        {
            Persona usu = null;
            List<Persona> ListaUsu = new List<Persona>();//crea la lista de los usuarios
            MySqlCommand cmd;//para ejecutar la base de datos 
            MySqlConnection cn = con.GetConnection();// conectar a la base de datos , obten la conexon
            try
            {
               // string sqlcad = "Select * from persona order by nom_usu";//cadena sql
                string sqlcad = "Select * from persona where rol_idrol=1 || rol_idrol=2 order by nombre_per";
                cmd = new MySqlCommand(sqlcad, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();// abre base de datos 
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())//permite leer los datos
                {
                    usu = new Persona();//crea los usuarios importante
                    usu.Id_persona = int.Parse(dr["idPersona"].ToString());
                    usu.Cedula = dr["cedula"].ToString() ;//nombre de las tablas
                    usu.Nombre = dr["nombre_per"].ToString();
                    usu.Apellido = dr["apellido_per"].ToString();
                    usu.Direccion= dr["direccion"].ToString();
                    usu.Telefono = dr["telefono"].ToString();
                    usu.Estado = dr["estado"].ToString();
                    //usu.Cuenta.Usuario21 = dr["usuario"].ToString();
                    //      usu.Cuenta.Clave = dr["clave"].ToString();
                 // usu. Nombre = usu.Apellido + " " +usu.Nombre;
                    //            ListaUsu.Add(per.getPersona());
                    ListaUsu.Add(usu);
                }
                dr.Close();
            }
            catch (MySqlException ex)
            {
                usu = null;
                throw ex;
            }
            catch (Exception ex)
            {
                usu = null;
                throw ex;
            }
            cn.Close();//cerras conexion
            cmd = null;//rompe el enlace y es basura
            return ListaUsu;// retorno a llenado datos
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
        
    }
}
