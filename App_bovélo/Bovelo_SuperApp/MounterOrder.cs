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
    public partial class MounterOrder : UserControl
    {
        public string id_bike;
        
        private int run = 0;
        public MounterOrder(string id_bike,string model, string color,string size,string client_Name, string Business_Name, string order,string status)
        {
            
            InitializeComponent();
            
            model_mounter.Text = model;
            size_mounter.Text = size;
            client_name_mounter.Text = client_Name;
            business_name_mounter.Text = Business_Name;
            if (model_mounter.Text == "City")
            {
                time_mounter.Text = "2H";
            }
            else if (model_mounter.Text == "Explorer")
            {
                time_mounter.Text = "2H30";
            }
            else if (model_mounter.Text == "Adventure")
            {
                time_mounter.Text = "2H45";
            }
            this.id_bike = id_bike;
            
            color_mounter.Text = color;
            Status_bike.Text = status;
            
        }

        private void MounterOrder_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void Bte_bike_Click(object sender, EventArgs e)
        {
            
            String sqll = "DELETE FROM model_bikes WHERE id_bike = '" + this.id_bike + "'";
            MySqlConnection connectionDB = Connection.connection();
            connectionDB.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(sqll, connectionDB);
                comando.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Le vélo n'est pas supprimé de la base de donnée" + ex.Message);
            }
            finally
            {
                connectionDB.Close();


                

                Form1.Instance.MounteurControl.pnl_week_orders_forMounter.Controls.Remove(this);
                try { Form1.Instance.MounteurControl.Orders.Remove(this.search()); }
                catch
                {
                    Console.WriteLine("ok");
                }
                



            }
        }
        public Model_Bike search()
        {
            foreach (KeyValuePair<Model_Bike, Client> elt in Form1.Instance.MounteurControl.Orders)
            {
                    if (elt.Key.id_bike == int.Parse(this.id_bike))
                    {
                        return elt.Key;
                    }

            }
            return new Model_Bike("","","",0,0);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            char i= Form1.Instance.index_Haut.Connection_User.Text[14];
            if (this.run ==1)
            {
                
                string sql = "UPDATE bikes set status = '" + Status_bike.Text + "' , Id_mounter ='" + i + "' where id_bike like '" + int.Parse(this.id_bike) + "'";
                MySqlConnection Conn = Connection.connection();


                try
                {
                    Conn.Open();
                    MySqlCommand commando = new MySqlCommand(sql, Conn);
                    commando.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Conn.Close();
                }
                
            }
            else
            {
                this.run = 1;           
            }
            
        }
    }
}

