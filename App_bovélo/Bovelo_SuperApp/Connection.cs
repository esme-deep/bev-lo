using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bovelo_SuperApp
{
    class Connection
    {
        public static MySqlConnection connection()
        {
            String server = "193.191.240.67";
            String port = "63301";
            String database = "test";
            String user = "Mustafa";
            String password = "mustafa";

            String chainConnection = "Database=" + database + "; Data Source=" + server + "; Port=" + port + "; User Id= " + user + "; Password=" + password + "";

            try
            {
                MySqlConnection connectionDB = new MySqlConnection(chainConnection);

                return connectionDB;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;

            }
        }
    }
}
