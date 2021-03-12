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
        private string P_colors;
        private string P_size;
        private string P_model; 
        private string P_img;
        private string P_desc;
        private string P_price;
        public Product_catalog(string model,string color,string size ,string img ,string price,string desc)
        {
            this.P_colors = color;
            this.P_price = price;
            this.P_size = size;
            this.P_model = model;
            this.P_img = img;
            this.P_desc = desc;
            InitializeComponent();
            
            Image image_bike = Image.FromFile("..\\images\\" + img+"2.jpg");

            pic_bike.Image = image_bike ;
            label_price.Text = price;
            label_Model.Text = model;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.Instance.panelContainer.Controls.Clear();
            
            Form1.Instance.panelContainer.Controls.Add(new Product(this.P_model,this.P_colors, this.P_size,this.P_img,this.P_price ,P_desc));
        }

        private void pic_bike_Click(object sender, EventArgs e)
        {

        }
    }
}
