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
    public partial class Index_Gauche : UserControl
    {
        public Button Sign_in
        {
            get
            {
                return Log_in_Button;
            }
            
        }
        public Button catalog_button
        {
            get
            {
                return Catalog_Button;
            }

        }
        public Button cart_button
        {
            get
            {
                return Cart_Button;
            }

        }
        public Button button3
        {
            get
            {
                return Client_info;
            }
        }
        public Index_Gauche()
        {
            InitializeComponent();
        }

        private void Log_In_Button_Click(object sender, EventArgs e)
        {
            if (Log_in_Button.Text == "Sign out")
            {
                Form1.Instance.index_Haut.btnStock.Visible = false;
                Form1.Instance.index_Haut.Connection_User.Text = "Not Connected";
                Form1.Instance.panelContainer.Controls.Clear();
                Form1.Instance.panelContainer.Controls.Add(new Presentation());
                Form1.Instance.index_Gauche.Sign_in.Text = "Sign in";
                Form1.Instance.index_Gauche.catalog_button.Enabled = false;
                Form1.Instance.index_Gauche.cart_button.Enabled = false;
                Form1.Instance.index_Gauche.catalog_button.Visible = false;
                Form1.Instance.index_Gauche.cart_button.Visible = false;
                Form1.Instance.index_Gauche.button3.Visible = false;
                Form1.Instance.index_Gauche.button3.Visible = false;
                Form1.Instance.index_Gauche.buttonAssign.Enabled = false;
                Form1.Instance.index_Gauche.buttonAssign.Visible = false;
            }
            else
            {
                Form1.Instance.panelContainer.Controls.Clear();
                Form1.Instance.panelContainer.Controls.Add(new Login());
            }
        }


        private void Index_Gauche_Load(object sender, EventArgs e)
        {
            
        }

        private void Catalog_Button_Click(object sender, EventArgs e)
        {
            //
            Form1.Instance.panelContainer.Controls.Clear();
            Form1.Instance.panelContainer.Controls.Add(Form1.Instance.catalog);
        }

        private void Cart_Button_Click(object sender, EventArgs e)
        {
            Form1.Instance.panelContainer.Controls.Clear();
            Form1.Instance.panelContainer.Controls.Add(Form1.Instance.cart);
            if (Form1.Instance.Cart.list_models.Count != 0)
            {
                Form1.Instance.cart.Text_Estimated_time.Text = Form1.Instance.cart.EstimateDeliveryTime().ToString();
                Form1.Instance.cart.label3.Visible = true;
            }
        }

        private void Client_info_Click(object sender, EventArgs e)
        {
            Form1.Instance.panelContainer.Controls.Clear();
            Form1.Instance.panelContainer.Controls.Add(Form1.Instance.client_info);
        }

        private void buttonAssign_Click(object sender, EventArgs e)
        {
            Form1.Instance.panelContainer.Controls.Clear();
            Form1.Instance.production_Planning = new production_planning();
            Form1.Instance.panelContainer.Controls.Add(Form1.Instance.production_Planning);
        }
    }
}
