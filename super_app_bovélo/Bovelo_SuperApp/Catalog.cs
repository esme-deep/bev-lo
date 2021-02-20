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
    public partial class Catalog : UserControl
    {
        public Catalog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.Instance.pnlContainer.Controls.Clear();
            Form1.Instance.pnlContainer.Controls.Add(new Productcs("City"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.Instance.pnlContainer.Controls.Clear();
            Form1.Instance.pnlContainer.Controls.Add(new Productcs("Explorer"));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1.Instance.pnlContainer.Controls.Clear();
            Form1.Instance.pnlContainer.Controls.Add(new Productcs("Adventure"));
        }
    }
}
