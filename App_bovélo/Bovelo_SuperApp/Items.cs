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
        private int qtt_used;
        private int qtt_coming;
        private int qtt_available;
        private int item_quantity;
        private string status_stock;


        public int Id_model_item { get => id_model_item; set => id_model_item = value; }
        public string Name_model_item { get => name_model_item; set => name_model_item = value; }
        public string Size_model_item { get => size_model_item; set => size_model_item = value; }
        public string Colour_model_item { get => colour_model_item; set => colour_model_item = value; }
        public double Price_model_item { get => price_model_item; set => price_model_item = value; }
        public int Qtt_used { get => qtt_used; set => qtt_used = value; }
        public int Qtt_coming { get => qtt_coming; set => qtt_coming = value; }
        public int Qtt_available { get => qtt_available; set => qtt_available = value; }
        public int Item_quantity { get => item_quantity; set => item_quantity = value; }
        public string Status_stock { get => status_stock; set => status_stock = value; }
    }
}
