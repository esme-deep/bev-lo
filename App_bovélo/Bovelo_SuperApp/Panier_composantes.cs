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
    public partial class Panier_composantes : UserControl
    {
        public Panier_composantes(string image, string model, string colour, string size,string qtt, string price)
        {
            InitializeComponent();
            model_name.Text = model;
            colour_text.Text = colour;
            size_text.Text = size;
            qtt_number.Text = qtt;
            Price_label.Text = price;
        }

        private void Remove_button_Click(object sender, EventArgs e)
        {
            int i = Cart.Instance.pnl.Controls.IndexOf(this);
            Cart.Instance.pnl.Controls.Remove(this);
            Form1.Instance.Cart.RemoveAt(i);
        }
    }
}
