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
        public Client nextClient;
        public Client_Info()
        {
            InitializeComponent();
        }

        private void Client_Info_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!(txtLastName.Text == "" | txtFirstName.Text == "" | txtEmail.Text == "" | txtAdress.Text == "" | txtPostalCode.Text == "" | txtCity.Text == "" | Business_name.Text == ""))
            {
                try
                {
                    nextClient = new Client(txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtAdress.Text, int.Parse(txtPostalCode.Text), txtCity.Text, Business_name.Text);

                    String sql2 = "INSERT INTO customer (firstname, lastname, email, adress, postalcode, city, business_name) VALUES ('" + nextClient.first_name + "', '" + nextClient.last_name + "','" + nextClient.email + "','" + nextClient.adress + "','" + nextClient.postal_code + "','" + nextClient.city +"','"+nextClient.business_name +"')";
                    MySqlConnection connectionDB = Connection.connection();
                    connectionDB.Open();

                    try
                    {
                        MySqlCommand comando = new MySqlCommand(sql2, connectionDB);
                        comando.ExecuteNonQuery();
                        sql2 = "SELECT max(id) FROM customer";
                        comando = new MySqlCommand(sql2, connectionDB);
                        MySqlDataReader reader = comando.ExecuteReader();
                        if (reader.Read())
                        {
                            txtId.Text = reader.GetString(0);
                        }
                        MessageBox.Show("Customer saved");


                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Saving Error: " + ex.Message);
                    }
                    finally
                    {
                        
                        Form1.Instance.panelContainer.Controls.Clear();
                        if (Form1.Instance.Cart.list_models.Count ==0)
                        {
                            Form1.Instance.panelContainer.Controls.Add(new Catalog());
                        }
                        else
                        {
                            Form1.Instance.panelContainer.Controls.Add(new Cart());
                        }
                        
                        connectionDB.Close();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("only numbers for postal code  " );
                }
                



            }

        }
        private void clear()
        {
            txtId.Text = "";
            txtFirstName.Text= "";
            txtLastName.Text= "";
            txtEmail.Text= "";
            txtAdress.Text = "";
            txtPostalCode.Text ="" ;
            txtCity.Text= "";
            btnSave.Enabled = true;
            btnSave.Visible = true;
            btnUpdate.Visible = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnDelete.Visible = false;
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
            if (txtLastName.Text != "" & Business_name.Text != "" & txtFirstName.Text != "")
            {


                String firstname = txtFirstName.Text;
                String lastName = txtLastName.Text;
                MySqlDataReader reader = null;
                string business_name = Business_name.Text;
                string sql = "SELECT id, firstname, lastname, email, adress, postalcode, city, business_name FROM customer WHERE lastname LIKE '" + lastName + "' AND business_name Like '" + business_name + "' AND firstname Like '" + firstname + "' LIMIT 1";
                MySqlConnection conexionBD = Connection.connection();
                conexionBD.Open();

                try
                {
                    MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                    reader = comando.ExecuteReader();
                    if (reader.HasRows)
                    {
                        btnDelete.Enabled = true;
                        btnDelete.Visible = true;
                        btnUpdate.Enabled = true;
                        btnUpdate.Visible = true;
                        btnSave.Enabled = false;
                        btnSave.Visible = false;

                        while (reader.Read())
                        {
                            txtId.Text = reader.GetString(0);
                            txtFirstName.Text = reader.GetString(1);
                            txtLastName.Text = reader.GetString(2);
                            txtEmail.Text = reader.GetString(3);
                            txtAdress.Text = reader.GetString(4);
                            txtPostalCode.Text = reader.GetString(5);
                            txtCity.Text = reader.GetString(6);
                            Business_name.Text = reader.GetString(7);

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

                    conexionBD.Close();

                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                
                String firstName = txtFirstName.Text;
                String lastName = txtLastName.Text;
                String business_name = Business_name.Text;
                String email = txtEmail.Text;
                String adress = txtAdress.Text;
                int postalCode = int.Parse(txtPostalCode.Text);
                string city = txtCity.Text;

                String sql = "UPDATE customer SET firstname='" + firstName + "', lastname='" + lastName + "', email='" + email + "', adress='" + adress + "', postalcode='" + postalCode + "', city='" + city+"', business_name ='" + business_name + "' WHERE id='" + txtId.Text  +"'";
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

        private void btnConfirm(object sender, EventArgs e)
        {   
            if (txtLastName.Text == "" | txtFirstName.Text ==""| txtEmail.Text==""| txtAdress.Text ==""| txtPostalCode.Text==""| txtCity.Text ==""| Business_name.Text == "")
            {
                MessageBox.Show("fulfill all inputs!");
            }
            else 
            {
                nextClient = new Client(txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtAdress.Text, int.Parse(txtPostalCode.Text), txtCity.Text, Business_name.Text);
                nextClient.id = int.Parse(txtId.Text);
                Form1.Instance.Cart.client = nextClient;
            }

        }
    }
}
