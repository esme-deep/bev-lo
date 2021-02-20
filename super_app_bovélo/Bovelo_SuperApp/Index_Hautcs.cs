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
    public partial class Index_Hautcs : UserControl
    {
        static Index_Hautcs obj;

        public static Index_Hautcs Instance
        {
            get
            {

                return obj;
            }
        }

        public Label User_lbl
        {
            get
            {
                return Connection_User;
            }
            set
            {
                Connection_User = value;
            }
        }
        public Index_Hautcs()
        {
            InitializeComponent();
        }

        private void Index_Hautcs_Load(object sender, EventArgs e)
        {
            obj = this;
        }
    }
}
