using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bovelo_SuperApp
{
    class CtrlItems : Connection2
    {

        public List<Object> request(string data)
        {
            MySqlDataReader reader;
            List<Object> items_list = new List<object>();
            string sql;

            if (data == null)
            {
                sql = "SELECT model_item.id_model_item, model_item.name_model_item, model_item.size_model_item, model_item.colour_model_item, model_item.price_model_item, stock.qtt_used,stock.qtt_coming,stock.qtt_available FROM model_item INNER JOIN stock ON model_item.id_stock = stock.id_stock ORDER BY model_item.name_model_item ASC";
            }
            else
            {
                sql = "SELECT model_item.id_model_item, model_item.name_model_item, model_item.size_model_item, model_item.colour_model_item, model_item.price_model_item, stock.qtt_used,stock.qtt_coming,stock.qtt_available FROM model_item INNER JOIN stock ON model_item.id_stock = stock.id_stock WHERE model_item.id_stock LIKE '%" + data + "%' OR model_item.name_model_item LIKE '%" + data + "%' OR model_item.size_model_item LIKE '%" + data + "%' OR model_item.colour_model_item LIKE '%" + data + "%' OR model_item.price_model_item LIKE '%" + data + "%' OR stock.status_stock LIKE '%" + data + "%'  ORDER BY model_item.name_model_item ASC";
            }
            try
            {
                MySqlConnection connectionBD = base.connection();
                connectionBD.Open();
                MySqlCommand command = new MySqlCommand(sql, connectionBD);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Items _items = new Items();
                    _items.Id_model_item = int.Parse(reader.GetString(0));
                    _items.Name_model_item = reader[1].ToString();
                    _items.Size_model_item = reader.GetString(2);
                    _items.Colour_model_item = reader[3].ToString();
                    _items.Price_model_item = double.Parse(reader[4].ToString());
                    _items.Qtt_used =  int.Parse(reader.GetString(5));
                    _items.Qtt_coming = int.Parse(reader.GetString(6));
                    _items.Qtt_available = int.Parse(reader.GetString(7));
                    items_list.Add(_items);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            return items_list;
        }

        public bool insert(Items data)
        {
            bool flag = false;

            string sql_model_item = "INSERT INTO model_item(name_model_item, size_model_item, colour_model_item, price_model_item, id_stock) VALUES ('" + data.Name_model_item + "', '" + data.Size_model_item + "', '" + data.Colour_model_item + "', '" + data.Price_model_item + "', (select max(id_stock) from stock) )";
            string sql_stock = "INSERT INTO stock (item_quantity, status_stock) VALUES ('" + data.Item_quantity + "', '" + data.Status_stock + "')";
            try
            {
                MySqlConnection conexionBD = base.connection();
                conexionBD.Open();
                MySqlCommand comand = new MySqlCommand(sql_model_item, conexionBD);
                MySqlCommand comand2 = new MySqlCommand(sql_stock, conexionBD);

                comand2.ExecuteNonQuery();
                comand.ExecuteNonQuery();

                flag = true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
                flag = false;
            }

            return flag;
        }

        public bool update(Items data)
        {
            bool flag = false;

            string sql = "UPDATE model_item  SET name_model_item='" + data.Name_model_item + "', size_model_item='" + data.Size_model_item + "', colour_model_item='" + data.Colour_model_item + "', price_model_item='" + data.Price_model_item + "'  WHERE id_model_item='" + data.Id_model_item + "'";
            string sql2 = "UPDATE stock  SET item_quantity='" + data.Item_quantity + "', status_stock ='" + data.Status_stock + "' WHERE id_stock ='" + data.Id_model_item + "'";
            try
            {
                MySqlConnection conexionBD = base.connection();
                conexionBD.Open();
                MySqlCommand comand = new MySqlCommand(sql, conexionBD);
                MySqlCommand comand2 = new MySqlCommand(sql2, conexionBD);

                comand2.ExecuteNonQuery();
                comand.ExecuteNonQuery();
                flag = true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
                flag = false;
            }

            return flag;
        }


        public bool delete(int id)
        {
            bool flag = false;

            string sql = "DELETE FROM stock WHERE id_stock='" + id + "'";
            string sql2 = "DELETE FROM model_item WHERE id_model_item='" + id + "'";


            try
            {
                MySqlConnection conexionBD = base.connection();
                conexionBD.Open();
                MySqlCommand comand = new MySqlCommand(sql, conexionBD);
                MySqlCommand comand2 = new MySqlCommand(sql2, conexionBD);
                comand.ExecuteNonQuery();
                comand2.ExecuteNonQuery();

                flag = true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
                flag = false;
            }

            return flag;
        }

        public void updateStock(String id_stock, int quantity)
        {
            MySqlDataReader reader;
            string sql;
            sql = "UPDATE stock SET item_quantity = item_quantity - " + quantity + " WHERE id_stock=" + id_stock;
            try
            {
                MySqlConnection connectionBD = base.connection();
                connectionBD.Open();
                MySqlCommand command = new MySqlCommand(sql, connectionBD);
                reader = command.ExecuteReader();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }

        public int getQuantityFromIdStock(int id_stock)
        {
            MySqlDataReader reader;
            string sql;
            int quantity = 0;
            sql = "SELECT item_quantity FROM stock WHERE id_stock=" + id_stock;
            try
            {
                MySqlConnection connectionBD = base.connection();
                connectionBD.Open();
                MySqlCommand command = new MySqlCommand(sql, connectionBD);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    quantity = int.Parse(reader.GetString(0));
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }

            return quantity;
        }
    }
}
