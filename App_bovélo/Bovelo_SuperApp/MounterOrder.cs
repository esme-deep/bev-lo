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
            if (this.Status_bike.Text == "Done" && this.run==1)
            {
                this.Status_bike.Enabled = false;
                Dictionary<string, int> items = new Dictionary<string, int>();
                items.Add("Béquille_Standart_Standart", 1);
                items.Add("Kit de frein_Standart_Standart", 1);
                items.Add("Kit vitesse_Standart_Standart", 1);
                items.Add("Kit pédalier_Standart_Standart", 1);
                items.Add("Cassette de pignons_Standart_Standart", 1);
                items.Add("Catadioptre_Standart_Standart", 4);
                items.Add("Chaîne_Standart_Standart", 1);
                items.Add("Chambre à air_Standart_Standart", 2);
                items.Add("Détrailleur_Standart_Standart", 1);
                items.Add("Disque de frein_Standart_Standart", 2);
                items.Add("Guidon_Standart_Standart", 1);
                items.Add("Plateau_Standart_Standart", 1);
                items.Add("Selle_Standart_Standart", 1);
                if (this.size_mounter.Text == "25")
                {
                    items.Add("Fourche_Standart_M", 1);
                    items.Add("Roue_Standart_M", 1);
                }
                if (this.size_mounter.Text == "27")
                {
                    items.Add("Fourche_Standart_L", 1);
                    items.Add("Roue_Standart_M", 1);
                }

                if (this.model_mounter.Text == "City")
                {
                    items.Add("Eclairage_Standart_Standart", 1);
                    items.Add("Porte-bagage_Standart_Standart", 1);
                    if (this.color_mounter.Text == "green" && this.size_mounter.Text == "25")
                    {
                        items.Add("Cadre_Green_M", 1);
                        items.Add("Garde-boue_Green_M", 1);

                    }
                    if (this.color_mounter.Text == "green" && this.size_mounter.Text == "27")
                    {
                        items.Add("Cadre_Green_L", 1);
                        items.Add("Garde-boue_Green_L", 1);
                    }
                    if (this.color_mounter.Text == "red" && this.size_mounter.Text == "25")
                    {
                        items.Add("Cadre_Red_M", 1);
                        items.Add("Garde-boue_Red_M", 1);
                    }
                    if (this.color_mounter.Text == "red" && this.size_mounter.Text == "27")
                    {
                        items.Add("Cadre_Red_L", 1);
                        items.Add("Garde-boue_Red_L", 1);
                    }
                    if (this.color_mounter.Text == "blue" && this.size_mounter.Text == "25")
                    {
                        items.Add("Cadre_Blue_M", 1);
                        items.Add("Garde-boue_Blue_M", 1);
                    }
                    if (this.color_mounter.Text == "blue" && this.size_mounter.Text == "27")
                    {
                        items.Add("Cadre_Blue_L", 1);
                        items.Add("Garde-boue_Blue_L", 1);
                    }
                    if (this.size_mounter.Text == "25")
                    {
                        items.Add("Pneu_Standart_M", 2);
                    }
                    if (this.size_mounter.Text == "27")
                    {
                        items.Add("Pneu_Standart_L", 2);
                    }

                }
                if (this.model_mounter.Text == "Explorer")
                {
                    items.Add("Eclairage_Standart_Standart", 1);
                    items.Add("Porte-bagage_Standart_Standart", 1);
                    if (this.color_mounter.Text == "green" && this.size_mounter.Text == "25")
                    {
                        items.Add("Cadre_Green_M", 1);
                        items.Add("Garde-boue large_Green_M", 1);
                    }
                    if (this.color_mounter.Text == "green" && this.size_mounter.Text == "27")
                    {
                        items.Add("Cadre_Green_L", 1);
                        items.Add("Garde-boue large_Green_L", 1);
                    }
                    if (this.color_mounter.Text == "red" && this.size_mounter.Text == "25")
                    {
                        items.Add("Cadre_Red_M", 1);
                        items.Add("Garde-boue large_Red_M", 1);
                    }
                    if (this.color_mounter.Text == "red" && this.size_mounter.Text == "27")
                    {
                        items.Add("Cadre_Red_L", 1);
                        items.Add("Garde-boue large_Red_L", 1);
                    }
                    if (this.color_mounter.Text == "blue" && this.size_mounter.Text == "25")
                    {
                        items.Add("Cadre_Blue_M", 1);
                        items.Add("Garde-boue large_Blue_M", 1);
                    }
                    if (this.color_mounter.Text == "blue" && this.size_mounter.Text == "27")
                    {
                        items.Add("Cadre_Blue_L", 1);
                        items.Add("Garde-boue large_Blue_L", 1);
                    }
                    if (this.color_mounter.Text == "25")
                    {
                        items.Add("Pneu large_Standart_M", 2);
                    }
                    if (this.color_mounter.Text == "27")
                    {
                        items.Add("Pneu large_Standart_L", 2);
                    }
                }
                if (this.model_mounter.Text == "Adventure")
                {
                    if (this.color_mounter.Text == "green" && this.size_mounter.Text == "25")
                    {
                        items.Add("Cadre renforcé_Green_M", 1);
                    }
                    if (this.color_mounter.Text == "green" && this.size_mounter.Text == "27")
                    {
                        items.Add("Cadre renforcé_Green_L", 1);
                    }
                    if (this.color_mounter.Text == "red" && this.size_mounter.Text == "25")
                    {
                        items.Add("Cadre renforcé_Red_M", 1);
                    }
                    if (this.color_mounter.Text == "red" && this.size_mounter.Text == "27")
                    {
                        items.Add("Cadre renforcé_Red_L", 1);
                    }
                    if (this.color_mounter.Text == "blue" && this.size_mounter.Text == "25")
                    {
                        items.Add("Cadre renforcé_Blue_M", 1);
                    }
                    if (this.color_mounter.Text == "blue" && this.size_mounter.Text == "27")
                    {
                        items.Add("Cadre renforcé_Blue_L", 1);
                    }
                    if (this.size_mounter.Text == "25")
                    {
                        items.Add("Pneu large_Standart_M", 2);
                    }
                    if (this.size_mounter.Text == "27")
                    {
                        items.Add("Pneu large_Standart_L", 2);
                    }
                }
                foreach (KeyValuePair<string, int> item in items)
                {
                    String name = item.Key.Split('_')[0];
                    String color = item.Key.Split('_')[1];
                    String size = item.Key.Split('_')[2];
                    string sql = "SELECT model_item.id_model_item, model_item.name_model_item, model_item.size_model_item, model_item.colour_model_item, stock.qtt_used, stock.qtt_available FROM model_item INNER JOIN stock ON model_item.id_stock = stock.id_stock WHERE model_item.name_model_item LIKE '%" + name + "%' AND model_item.size_model_item LIKE '%" + size + "%' AND model_item.colour_model_item LIKE '%" + color + "%'  ORDER BY model_item.name_model_item ASC";

                    MySqlConnection connectionBD = Connection.connection();
                    connectionBD.Open();
                    MySqlCommand command = new MySqlCommand(sql, connectionBD);
                    MySqlDataReader reader = command.ExecuteReader();


                    if (reader.Read())
                    {

                        int qtt_used = int.Parse(reader.GetString(4));
                        int qtt_available = int.Parse(reader.GetString(5));
                        int id_stock = int.Parse(reader.GetString(0));
                        string sql2 = "UPDATE stock  SET qtt_used='" + (qtt_used - (item.Value)) + "',qtt_available ='"+ (qtt_available-(item.Value))+"' WHERE id_stock ='" + id_stock + "'";
                        MySqlConnection conexionBD = Connection.connection();
                        conexionBD.Open();
                        MySqlCommand comand2 = new MySqlCommand(sql2, conexionBD);
                        comand2.ExecuteNonQuery();

                    }



                }
                
            }
            this.run = 1;

        }

            
        
    }
}

