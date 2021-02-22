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
    public partial class Presentation : UserControl
    {
        public Presentation()
        {
            InitializeComponent();
        }

        private void Presentation_Load(object sender, EventArgs e)
        {
            if ( Index_Hautcs.Instance.User_lbl.Text.Contains("Connected as"))
            {
                user_label.Text = "U re late";
            }
            else
            {
                user_label.Text = "U re late,log in !";
            }
        }

        private void user_label_Click(object sender, EventArgs e)
        {

        }
    }
}
