using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bovelo_SuperApp
{
    public class Client
    {
        public int id;
        public string first_name;
        public string last_name;
        public string email;
        public string adress;
        public int postal_code;
        public string city;
        public string business_name;
        public Client(string fname, string lname, string email, string adress,int pcode,string city, string business_name)
        {
            this.first_name = fname;
            this.last_name = lname;
            this.email = email;
            this.adress = adress;
            this.postal_code = pcode;
            this.city = city;
            this.business_name = business_name;

        }

    }
}
