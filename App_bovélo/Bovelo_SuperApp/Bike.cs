using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bovelo_SuperApp
{
    class Bike
    {
        public string color;
        public string type;
        public string size;
        public Client client;
        //public delivery_time ;

        public Bike(string c,string t,string s )
        {
            this.color = c;
            this.type = t;
            this.size = s;
            

        }
        public void SetClient(Client CL)
        {
            this.client = CL;
        }




    }
}
