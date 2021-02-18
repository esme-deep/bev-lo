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
    public partial class Catalogue : UserControl
    {
        public Catalogue()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.Instance.Controls.Clear();
            Form1.Instance.Controls.Add(new Product());
        }

        private void Catalogue_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1.Instance.Controls.Clear();
            Form1.Instance.Controls.Add(new Panier());
            



        }
    }
}
