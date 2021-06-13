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
    public partial class Index_Hautcs : UserControl
    {
        

        
        public Index_Hautcs()
        {
            InitializeComponent();
        }

        private void Connection_User_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            Form1.Instance.panelContainer.Controls.Clear();
            Form1.Instance.panelContainer.Controls.Add(Form1.Instance.stock);
            Form1.Instance.stock.loadTable(null);
        }
    }
}
