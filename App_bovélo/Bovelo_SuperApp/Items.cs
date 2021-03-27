using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bovelo_SuperApp
{
    class Items
    {
        private int id_model_item;
        private string name_model_item;
        private string size_model_item;
        private string colour_model_item;
        private double price_model_item;
        private int item_quantity;

        public int Id_model_item { get => id_model_item; set => id_model_item = value; }
        public string Name_model_item { get => name_model_item; set => name_model_item = value; }
        public string Size_model_item { get => size_model_item; set => size_model_item = value; }
        public string Colour_model_item { get => colour_model_item; set => colour_model_item = value; }
        public double Price_model_item { get => price_model_item; set => price_model_item = value; }
        public int Item_quantity { get => item_quantity; set => item_quantity = value; }
    }
}
