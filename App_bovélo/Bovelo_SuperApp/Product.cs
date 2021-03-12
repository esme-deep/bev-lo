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
    public partial class Product : UserControl
    {
        public Product(string model, string colors, string sizes, string img, string price,string description)
        {


            InitializeComponent();
            label_model.Text = model;
            price_lbl.Text = price;
            label_desc.Text = description;
            foreach(string elt in sizes.Split(';'))
            {

                this.BoxSize.Items.Add(elt);
            }
            foreach (string elt in colors.Split(';'))
            {

                this.boxColor.Items.Add(elt);
            }
            Image image_bike = Image.FromFile("..\\images\\" + img + ".jpg");
            pic_bike.Image = image_bike;
        }

        

        private void Add_to_Cart_Click(object sender, EventArgs e)
        {
            if (BoxSize.Text != "" & boxColor.Text != "")
            {   
            
                
                Model_Bike model_bike = new Model_Bike(boxColor.Text, label_model.Text, BoxSize.Text,Double.Parse( price_lbl.Text),int.Parse(quantity_input.Text));
                //Command.Add(model_bike);
                Form1.Instance.Cart.list_models.Add(model_bike);
                Form1.Instance.cart.FLPanel_Cart.Controls.Add(new Panier_composantes("ok", model_bike.type, model_bike.colour, model_bike.size, model_bike.quantity.ToString(), model_bike.price.ToString()));

            }
        }

        

        private void Product_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 50; i++)
            {
                quantity_input.Items.Add(i);
            }
        }

        private void pic_bike_Click(object sender, EventArgs e)
        {

        }
    }
}
