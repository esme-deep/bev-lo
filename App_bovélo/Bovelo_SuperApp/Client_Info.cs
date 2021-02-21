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
    public partial class Client_Info : UserControl
    {
        public Client_Info()
        {
            InitializeComponent();
        }

        private void Client_Info_Load(object sender, EventArgs e)
        {

        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            if(City.Text != "" & Street_Name.Text !="" & Business_Name.Text != "")
            {
                /*
                    CODE FOR SOHAIB HERE To put the command and the client in the database 
                    le panier se trouve dans "Form1.Instance.Panier", c'est une liste de string
                    en mode "mode,colour,size"
                    et les infos client:
                    Mail_Adress.Text -> mail adress; Stret_Name.Text -> Street_Name; Business_Name.Text-> Business_Name !!
                */







                Form1.Instance.Panier = new List<string>();
                Form1.Instance.pnlContainer.Controls.Clear();
                Form1.Instance.pnlContainer.Controls.Add(new Presentation());
            }
        }

        
    }
}
