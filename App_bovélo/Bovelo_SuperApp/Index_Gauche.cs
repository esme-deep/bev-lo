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
        static Index_Gauche obj;

        public static Index_Gauche Instance
        {
            get
            {

                return obj;
            }
        }

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
                return Button3;
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
                Index_Hautcs.Instance.User_lbl.Text = "Not Connected";
                Form1.Instance.pnlContainer.Controls.Clear();
                Form1.Instance.pnlContainer.Controls.Add(new Presentation());
                Index_Gauche.Instance.Sign_in.Text = "Sign in";
                Index_Gauche.Instance.catalog_button.Enabled = false;
                Index_Gauche.Instance.cart_button.Enabled = false;
                Index_Gauche.Instance.catalog_button.Visible = false;
                Index_Gauche.Instance.cart_button.Visible = false;
            }
            else
            {
                Form1.Instance.pnlContainer.Controls.Clear();
                Form1.Instance.pnlContainer.Controls.Add(new Login());
            }
        }


        private void Index_Gauche_Load(object sender, EventArgs e)
        {
            obj = this;
        }

        private void Catalog_Button_Click(object sender, EventArgs e)
        {
            Form1.Instance.pnlContainer.Controls.Clear();
            Form1.Instance.pnlContainer.Controls.Add(new Catalog());
        }

        private void Cart_Button_Click(object sender, EventArgs e)
        {
            Form1.Instance.pnlContainer.Controls.Clear();
            Form1.Instance.pnlContainer.Controls.Add(new Cart());
        }
    }
}
