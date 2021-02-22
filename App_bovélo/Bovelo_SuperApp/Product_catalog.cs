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
    public partial class Product_catalog : UserControl
    {
        public Product_catalog(string model, string price)
        {
            InitializeComponent();
            label_price.Text = price;
            label_Model.Text = model;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.Instance.pnlContainer.Controls.Clear();
            Form1.Instance.pnlContainer.Controls.Add(new Productcs(label_Model.Text, label_price.Text));
        }
    }
}
