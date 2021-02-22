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
    public partial class Productcs : UserControl
    {
        public Productcs(string vélo_model,string price)
        {
            
            InitializeComponent();
            label_model.Text = vélo_model;
            price_lbl.Text = price;

            
        }

        private void BoxSize_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Add_to_Cart_Click(object sender, EventArgs e)
        {
            if (BoxSize.Text != "" & boxColor.Text != "")
            {
                string vélo = label_model.Text + ";" + boxColor.Text + ";" + BoxSize.Text+";" +price_lbl.Text;
                Form1.Instance.Cart.Add(vélo);
                Console.WriteLine(Form1.Instance.Cart.Count);
            }
        }
    }
}
