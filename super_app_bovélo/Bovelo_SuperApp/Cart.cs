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
    public partial class Cart : UserControl
    {

        public Cart()
        {
            InitializeComponent();
        }

        private void Cart_Load(object sender, EventArgs e)
        {
            
            for (int i=0; i<Form1.Instance.Panier.Count;i++)
            {
                
                FLPanel_Cart.Controls.Add(new Panier_composantes("ok","velo","red","15","2"));
               
            }
        }

        private void confirm_cart_button_Click(object sender, EventArgs e)
        {
            Form1.Instance.pnlContainer.Controls.Clear();
            Form1.Instance.pnlContainer.Controls.Add(new Client_Info());
            
        }

        private void FLPanel_Cart_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
