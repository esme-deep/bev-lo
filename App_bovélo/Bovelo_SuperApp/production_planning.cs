using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Bovelo_SuperApp
{
    public partial class production_planning : UserControl
    {
        public production_planning()
        {
            InitializeComponent();
        }

        private void title_production_planning_Click(object sender, EventArgs e)
        {

        }

        private void btn_get_orders_Click(object sender, EventArgs e)
        {
            Form1.Instance.production_Planning.title_production_planning.Text = "This week orders are";
            Form1.Instance.production_Planning.title_production_planning.Location = new Point(287, 57);
            Form1.Instance.production_Planning.btn_get_orders.Visible = false;


            Dictionary<Model_Bike, Client> Orders = new Dictionary<Model_Bike, Client>();
            MySqlDataReader reader = null;
            String sql = "SELECT * from model_bikes, command,customer where model_bikes.N_command = command.id_command and customer.id = command.id_customer ";
            MySqlConnection connectionDB = Connection.connection();
            connectionDB.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, connectionDB);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Orders.Add(new Model_Bike(reader.GetString("colour"), reader.GetString("type_bike"), reader.GetString("size"),1,1),new Client(reader.GetString("firstname"), reader.GetString("lastname"),reader.GetString("email"), reader.GetString("adress"), int.Parse(reader.GetString("postalcode")), reader.GetString("city"), reader.GetString("business_name")));
                    }

                }
                else
                {
                    MessageBox.Show("NoOrderWasfound");

                }

                }
            catch (MySqlException ex)
            {
                MessageBox.Show("Searching error" + ex.Message);

            }
            finally
            {

                connectionDB.Close();

            }
            foreach (KeyValuePair<Model_Bike,Client> elt in Orders)
            {
                Console.WriteLine("you {0} bought {1} with color {2}", elt.Value.first_name, elt.Key.type, elt.Key.colour);
            }
            
        }




    }
    
}
