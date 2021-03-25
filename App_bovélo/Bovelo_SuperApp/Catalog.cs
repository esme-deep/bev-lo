using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bovelo_SuperApp
{
    public partial class Catalog : UserControl
    {
        public Catalog()
        {
            InitializeComponent();
        }

       

        private void Catalog_Load(object sender, EventArgs e)
        {
            
            MySqlDataReader reader;

            string sql = "SELECT * FROM model_bikes";
            MySqlConnection conexionBD = Connection.connection();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string model = reader.GetString(0);
                        string price = reader.GetString(5);
                        string image = reader.GetString(3);
                        string colours = reader.GetString(1);
                        string desc = reader.GetString(4);
                        string sizes = reader.GetString(2);
                        FLPanel_catalog.Controls.Add(new Product_catalog(model,colours,sizes,image,price,desc));
                    }

                }
                else
                {
                    MessageBox.Show("Notfound");

                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Searching error" + ex.Message);

            }
            finally
            {
                
                conexionBD.Close();

            }

        
        
        }
    }
}
