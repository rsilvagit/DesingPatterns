using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Platforms
{
    class YouTube : IPlatform
    {
        public YouTube() 
        {
            ConfigureRMTP();
        }

        public void AuthToken()
        {
            Console.WriteLine("Autorizando a ");
        }

        public void ConfigureRMTR()
        {
            throw new NotImplementedException();
        }
    }
}
