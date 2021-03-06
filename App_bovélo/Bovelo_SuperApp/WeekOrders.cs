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
    public partial class WeekOrders : UserControl
    {
        public WeekOrders(string model, string size,string client,string business_name)
        {
            InitializeComponent();
            lbl_model.Text = model;
            lbl_size.Text = size;
            lbl_client_name.Text = client;
            lbl_business_name.Text = business_name;
            if (lbl_model.Text == "City")
            {
                lbl_time.Text = "2H";
            }
            if (lbl_model.Text == "Explorer")
            {
                lbl_time.Text = "2H30";
            }
            if (lbl_model.Text == "Adventure")
            {
                lbl_time.Text = "2H45";
            }

        }

        private void WeekOrders_Load(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged_1(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged_2(object sender, EventArgs e)
        {

        }
    }
}
