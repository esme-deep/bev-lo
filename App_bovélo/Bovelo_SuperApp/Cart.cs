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
                Form1.Instance.panelContainer.Controls.Add(new Client_Info());
            }
            else
            {
                String sqll = "INSERT INTO  command(id_customer) VALUES ('" + Form1.Instance.Cart.client.id + "')";
                MySqlConnection connectionDB = Connection.connection();
                connectionDB.Open();
                try
                {
                    MySqlCommand comando = new MySqlCommand(sqll, connectionDB);
                    
                    comando.ExecuteNonQuery();
                    MessageBox.Show("commande crée");
                    String sqlll = "SELECT max(id_command), max(production_order) FROM command, bikes";
                    comando = new MySqlCommand(sqlll, connectionDB);
                    
                    MySqlDataReader reader = null;
                    reader = comando.ExecuteReader();
                    int N_command=0;
                    int Production_Order = 1;
                    if (reader.Read())
                    {
                        N_command = int.Parse(reader.GetString(0));
                        Production_Order = int.Parse(reader.GetString(1)) +1;
                        reader.Close();
                    }
                    

                    
                    
                    foreach (Model_Bike element in Form1.Instance.Cart.list_models)
                    {
                        for (int i = 0; i < element.quantity; i++)
                        {

                            String sql = "INSERT INTO  bikes(type_bike, colour,size, N_command,production_order) VALUES ('" + element.type + "', '" + element.colour + "','" + element.size + "','" + N_command + "','"+Production_Order+"')";

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
