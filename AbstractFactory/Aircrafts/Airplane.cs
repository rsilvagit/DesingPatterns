using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Aircrafts
{
    class Airplane : IAircraft
    {
        public void ChekWind()
        {
            Console.WriteLine("Verificando condições dos ventos");
        }

        public void GetCargo()
        {
            Console.WriteLine("Verificando compartimento de carga");
        }

        public void StartRoute()
        {
            ChekWind();
            GetCargo();
            Console.WriteLine("Aeronave pronta para decolagem");
        }
    }
}
