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
            
            char a = Form1.Instance.index_Haut.Connection_User.Text[14];
            
            this.pnl_week_orders_forMounter.Controls.Clear();
            Orders = new Dictionary<Model_Bike, Client>();
            MySqlDataReader reader = null;
            String sql = "SELECT * from bikes, command,customer where bikes.id_command = command.id_command and customer.id_customer = command.id_customer order by bikes.production_order";
            
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
                        bike.set_order(reader.GetInt16("production_order"));
                        bike.set_status(reader.GetString("Status"));
                        bike.set_mounter(reader.GetInt16("Id_mounter").ToString());
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

                MounterOrder order = new MounterOrder(elt.Key.id_bike.ToString(), elt.Key.type, elt.Key.colour, elt.Key.size, elt.Value.last_name, elt.Value.business_name, elt.Key.order.ToString(), elt.Key.status);
                if (Form1.Instance.index_Haut.Connection_User.Text[14] == elt.Key.mounter[0]) order.Status_bike.Enabled = true;
                else if (order.Status_bike.Text != "Waiting") order.Status_bike.Enabled = false;
                Form1.Instance.MounteurControl.pnl_week_orders_forMounter.Controls.Add(order);
                
            }

        }

        
    }
}

