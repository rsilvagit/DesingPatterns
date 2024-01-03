using Bridge.Platforms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Transmissons
{
    class AdvancedLive : Live
    {
        public AdvancedLive(IPlatform platform) : base(platform)
        {

        }

        public void Subtitle()
        {
            Console.WriteLine("Legendas ativadas na transmissão");
        }
        public void Comments() 
        {
            Console.WriteLine("Comentários liberados na live");
        }
        public void Record() 
        { 
            Console.WriteLine("Gravação iniciada");
        }
     
    }
}
