using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace facturacion
{
    class Conexion
    {

        String connectionString = "Database=facturacioncentronaturista;Data Source=localhost;User Id=root;Password=root";
        public MySqlConnection GetConnection()
        {
            MySqlConnection objcon = new MySqlConnection(connectionString);
            return objcon;
        }
    }
}
