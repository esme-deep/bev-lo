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
    public partial class Panier_composantes : UserControl
    {
        public Panier_composantes(string image, string model, string colour, string size,string qtt)
        {
            InitializeComponent();
            model_name.Text = model;
            colour_text.Text = colour;
            size_text.Text = size;
            qtt_number.Text = qtt;
        }

        
    }
}
