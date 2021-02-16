using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Product : UserControl
    {
        public Product()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.Instance.Controls.Clear();
            Form1.Instance.Controls.Add(new Catalogue());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.panier.Add(comboBox1.Text + ";" + comboBox2.Text);
        }
    }
}
