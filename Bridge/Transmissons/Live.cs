using Bridge.Platforms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Transmissons
{
    class Live : ITransmisson
    {
        protected IPlatform platform;
        public Live(IPlatform platform) 
        {
            this.platform = platform;
        }
        public void Broadcasting()
        {
            Console.WriteLine($"Iniciando a transmissão na {platform}");
        }

        public void Result()
        {
            Console.WriteLine("*****No AR*****");

        }
    }
}
