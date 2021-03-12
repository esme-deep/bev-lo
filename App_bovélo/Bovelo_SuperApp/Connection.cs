using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Bovelo_SuperApp
{
    class  Connection
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

        public static  MySqlDataReader SearchReader(string request)
        {
            MySqlDataReader reader;
            MySqlConnection connectionDB = Connection.connection();
            connectionDB.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(request, connectionDB);
                reader = comando.ExecuteReader();

            }

            catch (MySqlException ex)
            {
                reader = null;
                MessageBox.Show("Searching error" + ex.Message);

            }
            /*finally
            {
                

                connectionDB.Close();
                
            }*/
            connectionDB.Close();
            return reader;

        }
        public static void Execute(string sql,string message)
        {
            MySqlConnection connectionDB = Connection.connection();
            connectionDB.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, connectionDB);
                comando.ExecuteNonQuery();
                MessageBox.Show(message);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Sending error: " + ex.Message);

            }
            finally
            {

                connectionDB.Close();
            }
        }
    }
}
