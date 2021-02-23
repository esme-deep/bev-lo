using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bovelo_SuperApp
{
    public class Model_Bike
    {
        public string colour;
        public string type;
        public string size;
        public double price;
        public int quantity;
        //:public delivery_time ;

        public Model_Bike(string c, string t, string s, double price, int quantity)
        {
            this.colour = c;
            this.type = t;
            this.size = s;
            this.price = price;
            this.quantity = quantity;


        }
    }
}