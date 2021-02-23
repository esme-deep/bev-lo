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
            
            foreach (Model_Bike element in Form1.Instance.Cart.list_models)
            {
                FLPanel_Cart.Controls.Add(new Panier_composantes("ok",element.type,element.colour,element.size,element.quantity.ToString(),element.price.ToString()));
            }
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
                
                //envoyez a la base donnée
                foreach (Model_Bike element in Form1.Instance.Cart.list_models)
                {
                    for (int i = 0; i < element.quantity; i++)
                    {
                        String sql = "INSERT INTO  model_bikes(id_bike, type_bike, colour,size) VALUES ('" + element.type + "', '" + element.size + "','" + element.colour + "','" + Form1.Instance.Cart.client.last_name + "')";
                        MySqlConnection connectionDB = Connection.connection();
                        connectionDB.Open();

                        try
                        {
                            MySqlCommand comando = new MySqlCommand(sql, connectionDB);
                            comando.ExecuteNonQuery();
                            MessageBox.Show("commande envoyé");


                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show("Sending error: " + ex.Message);

                        }
                        finally
                        {

                            connectionDB.Close();
                        }
                    }
                }
                Form1.Instance.Cart.client = null;
                Form1.Instance.Cart = new Command();
                Form1.Instance.panelContainer.Controls.Clear();
                Form1.Instance.panelContainer.Controls.Add(Form1.Instance.presentation);
            }
        }

        
    }
}
