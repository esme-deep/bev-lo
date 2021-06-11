using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bovelo_SuperApp
{
    public class Model_Bike
    {
        public int order;
        public string colour;
        public string type;
        public string size;
        public double price;
        public int quantity;
        public int id_bike;
        public string status;
        public string mounter;
        public string delivery_time;
        public Dictionary<string, int> items;
        public Model_Bike(string c, string t, string s, double price, int quantity, string delivery_time = null)
        {
            this.colour = c;
            this.type = t;
            this.size = s;
            this.price = price * quantity;
            this.quantity = quantity;
            this.delivery_time = delivery_time;
            

        }
        public void set_mounter(string id)
        {
            this.mounter = id;
        }
        public void set_id(int id)
        {
            this.id_bike = id;
        }

        public void set_order(int order)
        {
            this.order = order;
        }
        public void set_status(string status)
        {
            this.status = status;
        }
        public void set_items(Dictionary<string, int> items)
        {
            this.items = items;
        }
    }
}