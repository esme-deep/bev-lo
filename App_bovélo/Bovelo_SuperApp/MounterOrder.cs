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
    public partial class MounterOrder : UserControl
    {
        public string id_bike;
        public MounterOrder(string id_bike,string model, string color,string size,string client_Name, string Business_Name, string order)
        {
            InitializeComponent();
            model_mounter.Text = model;
            size_mounter.Text = size;
            client_name_mounter.Text = client_Name;
            business_name_mounter.Text = Business_Name;
            if (model_mounter.Text == "City")
            {
                time_mounter.Text = "2H";
            }
            if (model_mounter.Text == "Explorer")
            {
                time_mounter.Text = "2H30";
            }
            if (model_mounter.Text == "Adventure")
            {
                time_mounter.Text = "2H45";
            }
            this.id_bike = id_bike;
            color_mounter.Text = color;
            order_mounter.Text = order;

        }

        private void MounterOrder_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
