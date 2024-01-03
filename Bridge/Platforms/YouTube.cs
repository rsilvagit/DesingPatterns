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
            Console.WriteLine("YouTube: Tranmissão iniciada");
        }

        public void AuthToken()
        {
            Console.WriteLine("Youtube: Autorizando a aplicação ");
        }

        public void ConfigureRMTP()
        {
           AuthToken();
            Console.WriteLine("Youtube: configurando servidor RMTP.");

        }
    }
}
