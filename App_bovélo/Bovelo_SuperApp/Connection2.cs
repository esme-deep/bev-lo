using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bovelo_SuperApp
{
    class Connection2
    {
        public MySqlConnection connection()
        {
            String server = "193.191.240.67";
            String port = "63301";
            String database = "test2";
            String user = "Mustafa";
            String password = "mustafa";

            String chainConnection = "Database=" + database + "; Data Source=" + server + "; Port=" + port + "; User Id= " + user + "; Password=" + password + "";

            try
            {
                MySqlConnection conexionBD = new MySqlConnection(chainConnection);

                return conexionBD;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }
    }
}
