using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bovelo_SuperApp
{
    class CtrlItems: Connection2
    {
        public List<Object> request(string data)
        {
            MySqlDataReader reader;
            List<Object> items_list = new List<object>();
            string sql;

            if (data == null)
            {
                sql = "SELECT model_item.id_model_item, model_item.name_model_item, model_item.size_model_item, model_item.colour_model_item, model_item.price_model_item, stock.item_quantity FROM model_item INNER JOIN stock ON model_item.id_stock = stock.id_stock ORDER BY model_item.name_model_item ASC";
            }
            else
            {
                sql = "SELECT model_item.id_model_item, model_item.name_model_item, model_item.size_model_item, model_item.colour_model_item, model_item.price_model_item, stock.item_quantity FROM model_item INNER JOIN stock ON model_item.id_stock = stock.id_stock WHERE model_item.id_stock LIKE '%" + data + "%' OR model_item.name_model_item LIKE '%" + data + "%' OR model_item.size_model_item LIKE '%" + data + "%' OR model_item.colour_model_item LIKE '%" + data + "%' OR model_item.price_model_item LIKE '%" + data + "%' ORDER BY model_item.name_model_item ASC";
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
                    _items.Item_quantity = int.Parse(reader.GetString(5));
                    items_list.Add(_items);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            return items_list;
        }
    }
}
