
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
    public partial class Form1 : Form
    {
        static Form1 obj;
        public List<string> Panier = new List<string>();
        private Client Client;
        public Client client
        {
            get { return Client; }
            set { Client = value; }
        }
        
        
        
        public static Form1 Instance
        {
            get
            {
                
                return obj;
            }
        }
        
        public Panel pnlContainer
        {
            get
            {
                return panelContainer;
            }
            set
            {
                panelContainer = value;
            }
        }
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void index_Gauche1_Load(object sender, EventArgs e)
        {

        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            obj = this;
            pnlContainer.Controls.Add(new Presentation());
        }
    }
}
