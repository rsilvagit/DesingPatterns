using System;


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
