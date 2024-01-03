using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Platforms
{
   class Facebook: IPlatform
    {
        public Facebook()
        {
            ConfigureRMTP();
            Console.WriteLine("Facebook: Tranmissão iniciada");
        }

        public void AuthToken()
        {
            Console.WriteLine("facebook: Autorizando a aplicação ");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("Facebook: configurando servidor RMTP.");

        }
    }
}
