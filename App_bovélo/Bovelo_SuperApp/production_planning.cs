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
          
            String sql = "SELECT * from bikes, command,customer where bikes.id_command = command.id_command and customer.id_customer = command.id_customer ";
            MySqlDataReader reader = null;
            /* MySqlDataReader reader = null;
             reader    = Connection.SearchReader(sql);
             Console.WriteLine(2);
             if (reader.HasRows)
             {
                 while (reader.Read())
                 {
                     Console.WriteLine(1);
                     Model_Bike bike = new Model_Bike(reader.GetString("colour"), reader.GetString("type_bike"), reader.GetString("size"), 1, 1);
                     bike.set_id(reader.GetInt16("id_bike"));

                     Orders.Add(bike, new Client(reader.GetString("firstname"), reader.GetString("lastname"), reader.GetString("email"), reader.GetString("adress"), int.Parse(reader.GetString("postalcode")), reader.GetString("city"), reader.GetString("business_name")));
                 }

             }
             else
             {
                 MessageBox.Show("NoOrderWasfound");

             }*/

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
                
                Form1.Instance.production_Planning.pnl_week_orders.Controls.Add(new WeekOrders(elt.Key.id_bike.ToString(),elt.Key.type, elt.Key.size, elt.Value.last_name, elt.Value.business_name,elt.Key.order.ToString()));
                
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_set_mounters_Click(object sender, EventArgs e)

        {
            var list = new List<string>();


            foreach (WeekOrders elt in Form1.Instance.production_Planning.pnl_week_orders.Controls)
            {

                list.Add(elt.OrderOfProduction.Text);

            }
            if (list.Any(item => item == "") | list.Count != list.Distinct().Count())
            {
                MessageBox.Show("identical orders or empty order");
            }
            else
            {
                foreach (WeekOrders elt in Form1.Instance.production_Planning.pnl_week_orders.Controls)
                {
                    //String sqlll = "ALTER model_bikes (mounter,production_order)  WHERE id_bike LIKE '" + int.Parse(elt.id_bike) +  "' VALUES ('" + elt.mounter.Text+ "', '" + elt.OrderOfProduction.Text + "' )"  ;
                    String sqlll = "UPDATE bikes SET   production_order ='" + int.Parse(elt.OrderOfProduction.Text) + "' WHERE id_bike LIKE '" + int.Parse(elt.id_bike) + "'";
                    MySqlConnection connectionDB = Connection.connection();
                    connectionDB.Open();
                    try
                    {
                        MySqlCommand comando = new MySqlCommand(sqlll, connectionDB);
                        comando.ExecuteNonQuery();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        
                        connectionDB.Close();



                    }
                    Form1.Instance.production_Planning.pnl_week_orders.Controls.Clear();
                    //Form1.Instance.production_Planning.btn_set_mounters.Visible = false;
                    Form1.Instance.production_Planning.btn_set_mounters.Enabled = false;
                }
                
            }
            
                    


                    

                
                
            

            
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

       

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
    
}
