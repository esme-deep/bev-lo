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
        private string name_mode_item;
        private string size_model_item;
        private string colour_model_itemcol;
        private double price_model_item;
        private int id_stock;

        public int Id_model_item { get => id_model_item; set => id_model_item = value; }
        public string Name_mode_item { get => name_mode_item; set => name_mode_item = value; }
        public string Size_model_item { get => size_model_item; set => size_model_item = value; }
        public string Colour_model_itemcol { get => colour_model_itemcol; set => colour_model_itemcol = value; }
        public double Price_model_item { get => price_model_item; set => price_model_item = value; }
        public int Id_stock { get => id_stock; set => id_stock = value; }
    }
}
