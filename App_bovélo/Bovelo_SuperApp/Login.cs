﻿using System;
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
            if (UserName.Text == "" & Password.Text == "")
            {
                Form1.Instance.index_Haut.Connection_User.Text = "Connected as "+UserName.Text;
                Form1.Instance.panelContainer.Controls.Clear();
                Form1.Instance.panelContainer.Controls.Add(Form1.Instance.presentation);
                Form1.Instance.index_Gauche.Sign_in.Text = "Sign out";
                Form1.Instance.index_Gauche.catalog_button.Enabled = true;
                Form1.Instance.index_Gauche.cart_button.Enabled = true;
                Form1.Instance.index_Gauche.catalog_button.Visible = true;
                Form1.Instance.index_Gauche.cart_button.Visible = true;
                Form1.Instance.index_Gauche.button3.Visible = true;
                Form1.Instance.index_Gauche.button3.Enabled = true;


            }
        }
    }
}
