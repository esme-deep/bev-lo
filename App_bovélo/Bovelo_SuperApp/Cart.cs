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
                DateTime  now = DateTime.Now;
                DateTime estimated_time = now.AddMinutes(150); //change that 
                double price = 0;
                foreach(Model_Bike elt in Form1.Instance.Cart.list_models)
                {
                    price += elt.price;
                }
                String sqll = "INSERT INTO  command(id_customer,order_date,production_date,order_price) VALUES ('" + Form1.Instance.Cart.client.id + "','" + now.ToString("yyyy-MM-dd hh:mm:ss") + "','" + estimated_time.ToString("yyyy-MM-dd hh:mm:ss") + "',"+price+")";
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
                            Production_Order = int.Parse(reader.GetString(0))+1;
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

                            String sql = "INSERT INTO  bikes(type_bike, colour,size, id_command,production_order,id_mounter,status) VALUES ('" + element.type + "', '" + element.colour + "','" + element.size + "',(select max(id_command) from command),'"+Production_Order+"',4,'Waiting')";

                            comando = new MySqlCommand(sql, connectionDB);
                            comando.ExecuteNonQuery();
                            Production_Order++;

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

        
    }
}
