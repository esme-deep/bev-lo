using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bovelo_SuperApp
{
    public class Command
    {
        public List<Model_Bike> list_models;
        public Client client;
        public Command()
        {
            list_models = new List<Model_Bike>();
        }

    }
}
