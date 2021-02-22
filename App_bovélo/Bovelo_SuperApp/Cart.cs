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
        static Cart obj;
        

        public static Cart Instance
        {
            get
            {
                return obj;
            }
        }

        public FlowLayoutPanel pnl
        {
            get
            {
                return FLPanel_Cart;
            }
            
        }
        public Cart()
        {
            InitializeComponent();
        }

        private void Cart_Load(object sender, EventArgs e)
        {
            obj = this;
            foreach (string element in Form1.Instance.Cart)
            {
                string[] bike = element.Split(';');
                FLPanel_Cart.Controls.Add(new Panier_composantes("ok",bike[0],bike[1],bike[2],"1",bike[3]));
            }
        }

        private void confirm_cart_button_Click(object sender, EventArgs e)
        {

            if (Form1.Instance.client == null)
            {
                MessageBox.Show("complétez le formulaire client !");
                Form1.Instance.pnlContainer.Controls.Clear();
                Form1.Instance.pnlContainer.Controls.Add(new Client_Info());
            }
            else
            {
                
                //envoyez a la base donnée
                foreach (string element in Form1.Instance.Cart)
                {
                    string[] elem = element.Split(';');
                    String sql = "INSERT INTO  command(model, size, colour,Client_Last_Name) VALUES ('" + elem[0] + "', '" + elem[1] + "','" + elem[2] + "','" + Form1.Instance.client.last_name+"')";
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
                Form1.Instance.client = null;
                Form1.Instance.Cart = new List<string>();
                Form1.Instance.pnlContainer.Controls.Clear();
                Form1.Instance.pnlContainer.Controls.Add(new Presentation());
            }
        }

        private void FLPanel_Cart_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
