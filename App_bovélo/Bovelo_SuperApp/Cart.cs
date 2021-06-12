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

                            string sql = "SELECT model_item.id_model_item, model_item.name_model_item, model_item.size_model_item, model_item.colour_model_item, model_item.price_model_item, stock.item_quantity, stock.status_stock FROM model_item INNER JOIN stock ON model_item.id_stock = stock.id_stock WHERE model_item.name_model_item LIKE '%" + name + "%' AND model_item.size_model_item LIKE '%" + size + "%' AND model_item.colour_model_item LIKE '%" + color + "%' AND stock.status_stock LIKE '%" + Status + "%'  ORDER BY model_item.name_model_item ASC";
                            
                            MySqlConnection connectionBD = Connection.connection();
                            connectionBD.Open();
                            MySqlCommand command = new MySqlCommand(sql, connectionBD);
                            reader = command.ExecuteReader();

                            
                            if (reader.Read())
                            {
                                
                                int quantity= int.Parse(reader.GetString(5));
                                Console.WriteLine(item.Key + " quantity is " + quantity);
                                int id_stock = int.Parse(reader.GetString(0));
                                string sql2 = "UPDATE stock  SET item_quantity='" + (quantity+ (item.Value * element.quantity)) + "' WHERE id_stock ='" + id_stock + "'";
                                MySqlConnection conexionBD = Connection.connection();
                                conexionBD.Open();
                                MySqlCommand comand2 = new MySqlCommand(sql2, conexionBD);
                                comand2.ExecuteNonQuery();
                                Console.WriteLine("cela existe deja");
                                
                            }
                            else
                            {
                                string sql_model_item = "INSERT INTO model_item(name_model_item, size_model_item, colour_model_item, price_model_item, id_stock) VALUES ('" + name + "', '" + size + "', '" + color + "', '" + 0 + "', (select max(id_stock) from stock) )";
                                string sql_stock = "INSERT INTO stock (item_quantity, status_stock) VALUES ('" + item.Value* element.quantity + "', '" + Status + "')";
                                MySqlConnection conexionBD = Connection.connection();
                                conexionBD.Open();
                                MySqlCommand comand = new MySqlCommand(sql_model_item, conexionBD);
                                MySqlCommand comand2 = new MySqlCommand(sql_stock, conexionBD);
                                comand2.ExecuteNonQuery();
                                comand.ExecuteNonQuery();
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
            DateTime date = DateTime.Now;
            int production_time = 0;
            int number_tyres = 0;
            int number_lighting = 0;
            int number_crutch = 0;
            int number_framework = 0;
            int number_reinforced_framework = 0;

            foreach (Model_Bike element in Form1.Instance.Cart.list_models)
            {
                for (int i = 0; i < element.quantity; i++)
                {
                    number_tyres += 2;
                    number_lighting += 1;
                    number_crutch += 1;
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

                    if (element.size == "27")
                    {
                        number_reinforced_framework += 1;
                    }
                    else
                    {
                        number_framework += 1;
                    }
                }
            }
            int[,] id_stock_vs_quantity = new int[,] { { 1, number_crutch }, { 3, number_framework }, { 4, number_tyres }, { 5, number_reinforced_framework }, { 6, number_lighting } };
            CtrlItems _ctrlItems = new CtrlItems();
            bool out_of_stock = false;
            for (int i = 0; i < id_stock_vs_quantity.Rank; i++)
            {
                int stock = _ctrlItems.getQuantityFromIdStock(id_stock_vs_quantity[i, 0]);
                if (stock < id_stock_vs_quantity[i, 1])
                {
                    out_of_stock = true;
                }
            }
            if (out_of_stock)
            {
                production_time += 10080;   //une semaine en minutes.
            }
            date.AddMinutes(production_time);
            return date;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
