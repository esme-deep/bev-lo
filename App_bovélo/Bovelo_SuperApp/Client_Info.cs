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
    public partial class Client_Info : UserControl
    {
        public Client_Info()
        {
            InitializeComponent();
        }

        private void Client_Info_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtEmail.Text != "" & txtLastName.Text !="" & txtFirstName.Text != "")
            {
                try
                {
                    Client nextClient = new Client(txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtAdress.Text, int.Parse(txtPostalCode.Text), txtCity.Text);
                    /*String firstName = txtFirstName.Text;
                    String lastName = txtLastName.Text;
                    String email = txtEmail.Text;
                    String adress = txtAdress.Text;
                    int postalCode = int.Parse(txtPostalCode.Text);
                    string city = txtCity.Text; */

                    String sql2 = "INSERT INTO customer (firstname, lastname, email, adress, postalcode, city) VALUES ('" + nextClient.first_name + "', '" + nextClient.last_name + "','" + nextClient.email + "','" + nextClient.adress + "','" + nextClient.postal_code + "','" + nextClient.city + "')";
                    MySqlConnection connectionDB = Connection.connection();
                    connectionDB.Open();

                    try
                    {
                        MySqlCommand comando = new MySqlCommand(sql2, connectionDB);
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Customer saved");

                        
                        clear();

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Saving Error: " + ex.Message);

                    }
                    finally
                    {
                        Form1.Instance.client = nextClient;
                        Form1.Instance.pnlContainer.Controls.Clear();
                        Form1.Instance.pnlContainer.Controls.Add(new Cart());
                        connectionDB.Close();
                    }
                }
                catch (FormatException fex)
                {
                    MessageBox.Show("Données incorrectes: " + fex.Message);
                }
                



            }
        }
        private void clear()
        {
            txtFirstName.Text= "";
            txtLastName.Text= "";
            txtEmail.Text= "";
            txtAdress.Text = "";
            txtPostalCode.Text ="" ;
            txtCity.Text= "";
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String lastName = txtLastName.Text;
            MySqlDataReader reader = null;

            string sql = "SELECT id, firstname, lastname, email, adress, postalcode, city FROM customer WHERE lastname LIKE '" + lastName + "' LIMIT 1";
            MySqlConnection conexionBD = Connection.connection();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        txtId.Text = reader.GetString(0);
                        txtFirstName.Text = reader.GetString(1);
                        txtLastName.Text = reader.GetString(2);
                        txtEmail.Text = reader.GetString(3);
                        txtAdress.Text = reader.GetString(4);
                        txtPostalCode.Text = reader.GetString(5);
                        txtCity.Text = reader.GetString(6);

                    }

                }
                else
                {
                    MessageBox.Show("Notfound");

                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Searching error" + ex.Message);

            }
            finally
            {
                btnUpdate.Enabled = true;
                btnUpdate.Visible = true;
                conexionBD.Close();

            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                String id = txtId.Text;
                String firstName = txtFirstName.Text;
                String lastName = txtLastName.Text;
                String email = txtEmail.Text;
                String adress = txtAdress.Text;
                int postalCode = int.Parse(txtPostalCode.Text);
                string city = txtCity.Text;

                String sql = "UPDATE customer SET firstname='" + firstName + "', lastname='" + lastName + "', email='" + email + "', adress='" + adress + "', postalcode='" + postalCode + "', city='" + city + "' WHERE id='" + id + "' ";
                MySqlConnection connectionDB = Connection.connection();
                connectionDB.Open();

                try
                {
                    MySqlCommand comando = new MySqlCommand(sql, connectionDB);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Customer updated");
                    clear();

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Updating Error: " + ex.Message);

                }
                finally
                {
                    connectionDB.Close();
                }
            }
            catch
            {
                MessageBox.Show("Compléte bien les entrées");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String id = txtId.Text;
            

            String sql = "DELETE FROM customer WHERE id='" + id + "' ";
            MySqlConnection connectionDB = Connection.connection();
            connectionDB.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, connectionDB);
                comando.ExecuteNonQuery();
                MessageBox.Show("Customer deleted");
                clear();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Deleting Error: " + ex.Message);

            }
            finally
            {
                connectionDB.Close();
            }
        }
    }
}
