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
    public partial class Panier : UserControl
    {
        public Panier()
        {
            InitializeComponent();
        }

        private void Panier_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Form1.panier.Count; i++)
            {
                this.dataGridView1.Rows.Add(i + 1, Form1.panier[i], 1);
            }
        }

        
    }
}
