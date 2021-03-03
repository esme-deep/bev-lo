
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
        public Command Cart = new Command();
        
        
        
        public Login login = new Login();
        public Presentation presentation = new Presentation();
        public Product product;
        public Catalog catalog = new Catalog();
        public Cart cart = new Cart();
        public Client_Info client_info = new Client_Info();
        public production_planning production_Planning = new production_planning();
        
        public static Form1 Instance
        {
            get
            {
                
                return obj;
            }
        }
        
        
        public Form1()
        {
            InitializeComponent();
            
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            obj = this;
            panelContainer.Controls.Add(presentation);
        }
    }
}
