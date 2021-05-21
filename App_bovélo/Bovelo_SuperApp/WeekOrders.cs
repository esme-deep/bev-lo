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
        public string id_bike;
        public WeekOrders(string id_bike, string model, string size, string client, string business_name, string order, string delivery_date)

        {
            InitializeComponent();
            lbl_model.Text = model;
            lbl_size.Text = size;
            lbl_client_name.Text = client;
            lbl_business_name.Text = business_name;
            OrderOfProduction.Text = order;
            lbl_time.Text = delivery_date;

            this.id_bike = id_bike;

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

        private void lbl_time_Click(object sender, EventArgs e)
        {

        }

        private void lbl_time_Click_1(object sender, EventArgs e)
        {

        }
    }
}
