using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bovelo_SuperApp
{
    public partial class Stock : UserControl
    {
        public Stock()
        {
            InitializeComponent();
            loadTable(null);
        }

        private void btnChercher_Click(object sender, EventArgs e)
        {
            string data = txtChercher.Text;
            loadTable(data);
        }

        private void loadTable(string data)
        {
            List<Items> lista = new List<Items>();
            CtrlItems _ctrlItems = new CtrlItems();
            dataGridView1.DataSource = _ctrlItems.request(data);
        }
    }
}
