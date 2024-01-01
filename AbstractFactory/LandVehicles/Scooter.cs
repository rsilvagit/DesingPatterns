using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.LandVehicles
{
    class Scooter : ILandVehicle
    {
            public void GetCargo()
        {
            Console.WriteLine("Patinete coletando carga");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciando transporte");
        }
    }
}
