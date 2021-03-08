using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Bovelo_SuperApp
{
    public partial class MounterControl : UserControl
    {
        public Dictionary<Model_Bike, Client> Orders;
        public MounterControl()
        {
            InitializeComponent();
        }

        private void pnl_week_orders_Paint(object sender, PaintEventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }
        

        private void btn_set_mounters_Click(object sender, EventArgs e)
        {   
            
            char a = Form1.Instance.index_Haut.Connection_User.Text[20];
            Console.WriteLine(a);
            this.pnl_week_orders_forMounter.Controls.Clear();
            Orders = new Dictionary<Model_Bike, Client>();
            MySqlDataReader reader = null;
            String sql = "SELECT * from model_bikes, command,customer where  mounter ='mounter" + a + "'and model_bikes.N_command = command.id_command and customer.id = command.id_customer ";
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
                        Model_Bike bike = new Model_Bike(reader.GetString("colour"), reader.GetString("type_bike"), reader.GetString("size"), 1, 1);
                        bike.set_id(reader.GetInt16("id_bike"));
                        bike.set_order(reader.GetString("production_order"));
                        Orders.Add(bike, new Client(reader.GetString("firstname"), reader.GetString("lastname"), reader.GetString("email"), reader.GetString("adress"), int.Parse(reader.GetString("postalcode")), reader.GetString("city"), reader.GetString("business_name")));
                    }

                }
                else
                {
                    MessageBox.Show("NoOrderWasfound");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Searching error" + ex.Message);

            }
            finally
            {

                connectionDB.Close();

            }
            foreach (KeyValuePair<Model_Bike, Client> elt in Orders)
            {
                Console.WriteLine("you {0} bought {1} with color {2} which id is {3}", elt.Value.first_name, elt.Key.type, elt.Key.colour, elt.Key.id_bike);

                Form1.Instance.MounteurControl.pnl_week_orders_forMounter.Controls.Add(new MounterOrder(elt.Key.id_bike.ToString(), elt.Key.type, elt.Key.colour, elt.Key.size, elt.Value.last_name, elt.Value.business_name, elt.Key.order));
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}

