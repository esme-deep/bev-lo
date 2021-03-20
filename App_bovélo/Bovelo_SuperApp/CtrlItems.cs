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
                sql = "SELECT id_model_item, name_mode_item, size_model_item, colour_model_itemcol, price_model_item, id_stock FROM model_item ORDER BY name_mode_item ASC";
            }
            else
            {
                sql = "SELECT id_model_item, name_mode_item, size_model_item, colour_model_itemcol, price_model_item, id_stock FROM model_item WHERE id_stock LIKE '%" + data + "%' OR name_mode_item LIKE '%" + data + "%' OR size_model_item LIKE '%" + data + "%' OR colour_model_itemcol LIKE '%" + data + "%' OR price_model_item LIKE '%" + data + "%' ORDER BY name_mode_item ASC";
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
                    _items.Name_mode_item = reader[1].ToString();
                    _items.Size_model_item = reader.GetString(2);
                    _items.Colour_model_itemcol = reader[3].ToString();
                    _items.Price_model_item = double.Parse(reader[4].ToString());
                    _items.Id_stock = int.Parse(reader.GetString(5));
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
