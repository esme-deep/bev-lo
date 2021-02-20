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
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Connect_Button_Click(object sender, EventArgs e)
        {
            if (UserName.Text == "Mustafa" & Password.Text == "mustafa")
            {
                Index_Hautcs.Instance.User_lbl.Text = "Connected as "+UserName.Text;
                Form1.Instance.pnlContainer.Controls.Clear();
                Form1.Instance.pnlContainer.Controls.Add(new Presentation());
                Index_Gauche.Instance.Sign_in.Text = "Sign out";
                Index_Gauche.Instance.catalog_button.Enabled = true;
                Index_Gauche.Instance.cart_button.Enabled = true;
                Index_Gauche.Instance.catalog_button.Visible = true;
                Index_Gauche.Instance.cart_button.Visible = true;



            }
        }
    }
}
