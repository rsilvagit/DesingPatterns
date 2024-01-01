using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Aircrafts
{
    class Drone : IAircraft
    {
        public void ChekWind()
        {
            Console.WriteLine("Drone checando condições dos ventos");
        }

        public void GetCargo()
        {
            Console.WriteLine("Efetuando o carregamento de carga");
        }

        public void StartRoute()
        {
            ChekWind();
            GetCargo();
            Console.WriteLine("Drone pronto para decolagem");
        }
    }
}
