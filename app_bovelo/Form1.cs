using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        static Form1 obj;
        public static Form1 Instance
        {
            get
            {
                if (obj == null)
                {
                    obj = new Form1();
                }
                return obj;
            }

        }
        public static  List<string> panier = new List<string>();
        public Panel PnlContainer
        {
            get { return panelContainer; }
            set { panelContainer = value; }
        }

        public Form1()
        {
            InitializeComponent();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            obj = this;
            panelContainer.Controls.Add(new Login());
            
        }

        
    }
}
