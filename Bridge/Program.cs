using Bridge.Platforms;
using Bridge.Transmissons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void StartLive(IPlatform platform)
        {
            Console.WriteLine("...Aguarde...");
            Live live = new Live(platform);

            live.Broadcasting();
            live.Result();
           
        }
        static void StartLiveAdvanced(IPlatform platform)
        {
            Console.WriteLine("...Aguarde...");
            AdvancedLive live = new AdvancedLive(platform);

            live.Broadcasting();
            live.Result();
            live.Subtitle();
            live.Comments();
        }
        static void Main(string[] args)
        {
            StartLive(new YouTube());
            Console.ReadLine();

            StartLiveAdvanced(new Facebook());
            Console.ReadLine();

            StartLive(new TwitchTV());
            Console.ReadLine();
        }
    }
}
