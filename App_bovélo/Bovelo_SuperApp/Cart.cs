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
    public partial class Cart : UserControl 
    {






        public Cart()
        {
            InitializeComponent();
        }

        private void Cart_Load(object sender, EventArgs e)
        {


        }

        private void confirm_cart_button_Click(object sender, EventArgs e)
        {


            if (Form1.Instance.Cart.client == null)
            {
                MessageBox.Show("complétez le formulaire client !");
                Form1.Instance.panelContainer.Controls.Clear();
                Form1.Instance.panelContainer.Controls.Add(Form1.Instance.client_info);
            }
            else
            {

                DateTime estimated_time = EstimateDeliveryTime();
                DateTime now = DateTime.Now;
                double price = 0;
                foreach (Model_Bike elt in Form1.Instance.Cart.list_models)
                {
                    price += elt.price;
                }
                String sqll = "INSERT INTO  command(id_customer,order_date,production_date,order_price) VALUES ('" + Form1.Instance.Cart.client.id + "','" + now.ToString("yyyy-MM-dd hh:mm:ss") + "','" + estimated_time.ToString("yyyy-MM-dd hh:mm:ss") + "'," + price + ")";
                MySqlConnection connectionDB = Connection.connection();
                connectionDB.Open();
                try
                {
                    MySqlCommand comando = new MySqlCommand(sqll, connectionDB);

                    comando.ExecuteNonQuery();
                    MessageBox.Show("commande crée");
                    //string sql = "INSERT INTO bikes(type_bike, colour,size, id_command,production_order,id_mounter,status) as '...','...','...',commmand.AUTO_INCREMENT"
                    String sqlll = "SELECT  max(production_order) FROM  bikes";
                    comando = new MySqlCommand(sqlll, connectionDB);
                    MessageBox.Show("connection crée");

                    MySqlDataReader reader = null;
                    reader = comando.ExecuteReader();

                    int Production_Order = 1;
                    if (reader.Read())
                    {
                        try
                        {
                            Production_Order = int.Parse(reader.GetString(0)) + 1;
                        }
                        catch
                        {


                        }



                        reader.Close();
                    }




                    foreach (Model_Bike element in Form1.Instance.Cart.list_models)
                    {
                        for (int i = 0; i < element.quantity; i++)
                        {

                            String sql = "INSERT INTO  bikes(type_bike, colour,size, id_command,production_order,id_mounter,status) VALUES ('" + element.type + "', '" + element.colour + "','" + element.size + "',(select max(id_command) from command),'" + Production_Order + "',4,'Waiting')";

                            comando = new MySqlCommand(sql, connectionDB);
                            comando.ExecuteNonQuery();
                            Production_Order++;

                        }
                        foreach (KeyValuePair<string, int> item in element.items)
                        {
                            String name = item.Key.Split('_')[0];
                            String color = item.Key.Split('_')[1];
                            String size = item.Key.Split('_')[2];
                            String Status = "Used";

                            string sql = "SELECT model_item.id_model_item, model_item.name_model_item, model_item.size_model_item, model_item.colour_model_item, model_item.price_model_item, stock.qtt_used FROM model_item INNER JOIN stock ON model_item.id_stock = stock.id_stock WHERE model_item.name_model_item LIKE '%" + name + "%' AND model_item.size_model_item LIKE '%" + size + "%' AND model_item.colour_model_item LIKE '%" + color + "%'  ORDER BY model_item.name_model_item ASC";
                            
                            MySqlConnection connectionBD = Connection.connection();
                            connectionBD.Open();
                            MySqlCommand command = new MySqlCommand(sql, connectionBD);
                            reader = command.ExecuteReader();

                            
                            if (reader.Read())
                            {
                                
                                int qtt_used= int.Parse(reader.GetString(5));
                                int id_stock = int.Parse(reader.GetString(0));
                                string sql2 = "UPDATE stock  SET qtt_used='" + (qtt_used+ (item.Value * element.quantity)) + "' WHERE id_stock ='" + id_stock + "'";
                                MySqlConnection conexionBD = Connection.connection();
                                conexionBD.Open();
                                MySqlCommand comand2 = new MySqlCommand(sql2, conexionBD);
                                comand2.ExecuteNonQuery();
                            }
                            
                            
                            
                        }
                    }
                    MessageBox.Show("commande remplie");
                    Form1.Instance.cart = new Cart();
                    Form1.Instance.Cart = new Command();

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Sending error: " + ex.Message);

                }
                finally
                {

                    connectionDB.Close();
                }

                //envoyez a la base donnée

                Form1.Instance.Cart.client = null;
                Form1.Instance.Cart = new Command();
                Form1.Instance.panelContainer.Controls.Clear();






                Form1.Instance.panelContainer.Controls.Add(Form1.Instance.presentation);
            }
            
        }

        

        public Dictionary<string, int[,] > FindUsedItems()
        {
            Dictionary < string, int[,]> Items = new Dictionary<string, int[,]>();
            return Items;


        }
        public DateTime EstimateDeliveryTime()
        {
            
            string sql = "SELECT max(production_date) FROM command";
            MySqlConnection connectionDB = Connection.connection();
            connectionDB.Open();
            DateTime myDate = DateTime.Now;
            try
            {
                string date;
                
                
                MySqlCommand comando = new MySqlCommand(sql, connectionDB);
                MySqlDataReader reader = comando.ExecuteReader();


                if (reader.Read())
                {
                    try
                    {
                        date = reader.GetString(0);
                        myDate = Convert.ToDateTime(date);
                        myDate = myDate.AddDays(1);
                        date = myDate.ToString();
                        var x = date.Split(' ');
                        x[1] = "08:00:00";
                        date = string.Join(" ", x);
                        myDate = Convert.ToDateTime(date);
                    }
                    catch
                    {
                        myDate = myDate.AddDays(1);
                        date = myDate.ToString();
                        var x = date.Split(' ');
                        x[1] = "08:00:00";
                        date = string.Join(" ", x);
                        myDate = Convert.ToDateTime(date);
                    }


                }
                CtrlItems _ctrlItems = new CtrlItems();
                List<Object> stock = _ctrlItems.request(null);
                bool notEnough = false;
                int production_time = 0;
                int days = 0;
                foreach (Model_Bike element in Form1.Instance.Cart.list_models)
                {
                    if (!notEnough)
                    {
                        foreach (KeyValuePair<string, int> item in element.items)
                        {
                            String name = item.Key.Split('_')[0];
                            String color = item.Key.Split('_')[1];
                            String size = item.Key.Split('_')[2];
                            int qtt_will_use = item.Value * element.quantity;
                            foreach (Items elem_stock in stock)
                            {
                                if (name == elem_stock.Name_model_item && color == elem_stock.Colour_model_item && size == elem_stock.Size_model_item)
                                {
                                    elem_stock.Qtt_available -= qtt_will_use;
                                    notEnough = elem_stock.Qtt_available - elem_stock.Qtt_used < 0 ? true : false;
                                    if (notEnough) days += 7;
                                }
                            }
                        }
                    }
                    for (int i = 0; i < element.quantity; i++)
                    {
                        if (element.type == "City")
                        {
                            production_time += 120;
                        }
                        else if (element.type == "Explorer")
                        {
                            production_time += 150;
                        }
                        else
                        {
                            production_time += 165;
                        }
                        if (production_time / 3 >= 8*60)
                        {
                            production_time = 0;
                            days++;
                        }
                    }
                    
                }
                Console.WriteLine(production_time);
                production_time = production_time / 3 + 100;
                myDate = myDate.AddDays(days);
                myDate = myDate.AddMinutes(production_time);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally{
                connectionDB.Close();              
            }
            

            return myDate;
        }

        

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void FLPanel_Cart_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
