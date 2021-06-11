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
                Dictionary<string, int> items = new Dictionary<string, int>();
                items.Add("Béquille_Standart_Standart", 1);
                items.Add("Kit de frein_Standart_Standart", 1);
                items.Add("Kit vitesse_Standart_Standart", 1);
                items.Add("Kit pédalier_Standart_Standart", 1);
                items.Add("Cassette de pignons_Standart_Standart", 1);
                items.Add("Catadioptre_Standart_Standart", 4);
                items.Add("Chaîne_Standart_Standart", 1);
                items.Add("Chambre à air_Standart_Standart", 2);
                items.Add("Détrailleur_Standart_Standart", 1);
                items.Add("Disque de frein_Standart_Standart", 2);
                items.Add("Guidon_Standart_Standart", 1);
                items.Add("Plateau_Standart_Standart", 1);
                items.Add("Selle_Standart_Standart", 1);
                if (BoxSize.Text == "25")
                {
                    items.Add("Fourche_Standart_M", 1);
                    items.Add("Roue_Standart_M", 1);
                }
                if (BoxSize.Text == "27")
                {
                    items.Add("Fourche_Standart_L", 1);
                    items.Add("Roue_Standart_M", 1);
                }

                if (label_model.Text == "City")
                {
                    Console.WriteLine("its city bike");
                    items.Add("Eclairage_Standart_Standart", 1);
                    items.Add("Porte-bagage_Standart_Standart", 1);
                    if (boxColor.Text =="green" && BoxSize.Text == "25")
                    {
                        items.Add("Cadre_Green_M", 1);
                        items.Add("Garde-boue_Green_M", 1);

                    }
                    if (boxColor.Text == "green" && BoxSize.Text == "27")
                    {
                        items.Add("Cadre_Green_L", 1);
                        items.Add("Garde-boue_Green_L", 1);
                    }
                    if (boxColor.Text == "red" && BoxSize.Text == "25")
                    {
                        items.Add("Cadre_Red_M", 1);
                        items.Add("Garde-boue_Red_M", 1);
                    }
                    if (boxColor.Text == "red" && BoxSize.Text == "27")
                    {
                        items.Add("Cadre_Red_L", 1);
                        items.Add("Garde-boue_Red_L", 1);
                    }
                    if (boxColor.Text == "blue" && BoxSize.Text == "25")
                    {
                        items.Add("Cadre_Blue_M", 1);
                        items.Add("Garde-boue_Blue_M", 1);
                    }
                    if (boxColor.Text == "blue" && BoxSize.Text == "27")
                    {
                        items.Add("Cadre_Blue_L", 1);
                        items.Add("Garde-boue_Blue_L", 1);
                    }
                    if (BoxSize.Text == "25")
                    {
                        items.Add("Pneu_Standart_M", 2);
                    }
                    if (BoxSize.Text == "27")
                    {
                        items.Add("Pneu_Standart_L", 2);
                    }

                }
                if (label_model.Text == "Explorer")
                {
                    Console.WriteLine("explorer samere");
                    items.Add("Eclairage_Standart_Standart", 1);
                    items.Add("Porte-bagage_Standart_Standart", 1);
                    if (boxColor.Text == "green" && BoxSize.Text == "25")
                    {
                        items.Add("Cadre_Green_M", 1);
                        items.Add("Garde-boue large_Green_M", 1);
                    }
                    if (boxColor.Text == "green" && BoxSize.Text == "27")
                    {
                        items.Add("Cadre_Green_L", 1);
                        items.Add("Garde-boue large_Green_L", 1);
                    }
                    if (boxColor.Text == "red" && BoxSize.Text == "25")
                    {
                        items.Add("Cadre_Red_M", 1);
                        items.Add("Garde-boue large_Red_M", 1);
                    }
                    if (boxColor.Text == "red" && BoxSize.Text == "27")
                    {
                        items.Add("Cadre_Red_L", 1);
                        items.Add("Garde-boue large_Red_L", 1);
                    }
                    if (boxColor.Text == "blue" && BoxSize.Text == "25")
                    {
                        items.Add("Cadre_Blue_M", 1);
                        items.Add("Garde-boue large_Blue_M", 1);
                    }
                    if (boxColor.Text == "blue" && BoxSize.Text == "27")
                    {
                        items.Add("Cadre_Blue_L", 1);
                        items.Add("Garde-boue large_Blue_L", 1);
                    }
                    if (BoxSize.Text == "25")
                    {
                        items.Add("Pneu large_Standart_M", 2);
                    }
                    if (BoxSize.Text == "27")
                    {
                        items.Add("Pneu large_Standart_L", 2);
                    }
                }
                if (label_model.Text == "Adventure")
                {
                    Console.WriteLine("adventure baby");
                    if (boxColor.Text == "green" && BoxSize.Text == "25")
                    {
                        items.Add("Cadre renforcé_Green_M", 1);
                    }
                    if (boxColor.Text == "green" && BoxSize.Text == "27")
                    {
                        items.Add("Cadre renforcé_Green_L", 1);
                    }
                    if (boxColor.Text == "red" && BoxSize.Text == "25")
                    {
                        items.Add("Cadre renforcé_Red_M", 1);
                    }
                    if (boxColor.Text == "red" && BoxSize.Text == "27")
                    {
                        items.Add("Cadre renforcé_Red_L", 1);
                    }
                    if (boxColor.Text == "blue" && BoxSize.Text == "25")
                    {
                        items.Add("Cadre renforcé_Blue_M", 1);
                    }
                    if (boxColor.Text == "blue" && BoxSize.Text == "27")
                    {
                        items.Add("Cadre renforcé_Blue_L", 1);
                    }
                    if (BoxSize.Text == "25")
                    {
                        items.Add("Pneu large_Standart_M", 2);
                    }
                    if (BoxSize.Text == "27")
                    {
                        items.Add("Pneu large_Standart_L", 2);
                    }
                }
                
                Model_Bike model_bike = new Model_Bike(boxColor.Text, label_model.Text, BoxSize.Text,Double.Parse( price_lbl.Text),int.Parse(quantity_input.Text));
                //Command.Add(model_bike);
                model_bike.set_items(items);
                Form1.Instance.Cart.list_models.Add(model_bike);
                Form1.Instance.cart.FLPanel_Cart.Controls.Add(new Panier_composantes("ok", model_bike.type, model_bike.colour, model_bike.size, model_bike.quantity.ToString(), model_bike.price.ToString()));
                foreach (KeyValuePair<string, int> item in model_bike.items)
                {
                    Console.WriteLine("Pièce: {0}, quantité: {1}", item.Key, item.Value);
                }
                
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

        private void boxColor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
