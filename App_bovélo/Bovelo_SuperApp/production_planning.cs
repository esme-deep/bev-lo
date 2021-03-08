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
            Form1.Instance.production_Planning.pnl_week_orders.Visible = true;

            Dictionary<Model_Bike, Client> Orders = new Dictionary<Model_Bike, Client>();
            MySqlDataReader reader = null;
            String sql = "SELECT * from model_bikes, command,customer where  mounter is null and model_bikes.N_command = command.id_command and customer.id = command.id_customer ";
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

                        Orders.Add(bike,new Client(reader.GetString("firstname"), reader.GetString("lastname"), reader.GetString("email"), reader.GetString("adress"), int.Parse(reader.GetString("postalcode")), reader.GetString("city"), reader.GetString("business_name")));
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
                Console.WriteLine("you {0} bought {1} with color {2} which id is {3}", elt.Value.first_name, elt.Key.type, elt.Key.colour,elt.Key.id_bike);
                Form1.Instance.production_Planning.pnl_week_orders.Controls.Add(new WeekOrders(elt.Key.id_bike.ToString(),elt.Key.type, elt.Key.size, elt.Value.last_name, elt.Value.business_name));
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_set_mounters_Click(object sender, EventArgs e)

        {
            
           
            foreach (WeekOrders elt in Form1.Instance.production_Planning.pnl_week_orders.Controls)
            {
                if (elt.mounter.Text != "" & elt.OrderOfProduction.Text != "")
                {


                    //String sqlll = "ALTER model_bikes (mounter,production_order)  WHERE id_bike LIKE '" + int.Parse(elt.id_bike) +  "' VALUES ('" + elt.mounter.Text+ "', '" + elt.OrderOfProduction.Text + "' )"  ;
                    String sqlll = "UPDATE model_bikes SET mounter = '" + elt.mounter.Text + "'  ,production_order = '" + elt.OrderOfProduction.Text + "' WHERE id_bike LIKE '" + int.Parse(elt.id_bike) + "'";
                    MySqlConnection connectionDB = Connection.connection();
                    connectionDB.Open();
                    try
                    {
                        MySqlCommand comando = new MySqlCommand(sqlll, connectionDB);
                        comando.ExecuteNonQuery();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("the bike" + elt.id_bike + " not assigned to the mounter Error: " + ex.Message);
                    }
                    finally
                    {
                        connectionDB.Close();
                        


                    }

                }
                /*
                else
                {
                    MessageBox.Show("fulfill all the inputs");
                }
                */
            }
            Form1.Instance.production_Planning.pnl_week_orders.Controls.Clear();
            //Form1.Instance.production_Planning.btn_set_mounters.Visible = false;
            Form1.Instance.production_Planning.btn_set_mounters.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void production_planning_Load(object sender, EventArgs e)
        {

        }



        private void button3_Click_1(object sender, EventArgs e)
        {
           


        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
    

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void time_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            double time1 = 0.0;
            double time2 = 0.0;
            double time3 = 0.0;
            TimeMounter1.Text = "Time mounter1 : ";
            TimeMounter2.Text = "Time mounter2 : ";
            TimeMounter3.Text = "Time mounter3 : ";







            foreach (WeekOrders elt in Form1.Instance.production_Planning.pnl_week_orders.Controls)
            {


                if (elt.mounter.Text == "mounter1")
                {

                    time1 = double.Parse(elt.lbl_time.Text) + time1;
                }
                else if (elt.mounter.Text == "mounter2")
                {
                    time2 = double.Parse(elt.lbl_time.Text) + time2;
                }
                else if (elt.mounter.Text == "mounter3")
                {
                    time3 = double.Parse(elt.lbl_time.Text) + time3;

                }
            }
            TimeMounter1.Text += time1.ToString() + " H";
            TimeMounter2.Text += time2.ToString() + " H";
            TimeMounter3.Text += time3.ToString() + " H";





        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
    
}
