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
        static Cart obj;
        

        public static Cart Instance
        {
            get
            {
                return obj;
            }
        }

        public FlowLayoutPanel pnl
        {
            get
            {
                return FLPanel_Cart;
            }
            
        }
        public Cart()
        {
            InitializeComponent();
        }

        private void Cart_Load(object sender, EventArgs e)
        {
            obj = this;
            foreach (string élément in Form1.Instance.Panier)
            {
                string[] vélo = élément.Split(';');
                FLPanel_Cart.Controls.Add(new Panier_composantes("ok",vélo[0],vélo[1],vélo[2],"2","399"));
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
