using System;


namespace AbstractFactory.LandVehicles
{
    class Car : ILandVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegando os Passageiros");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciando Viagem");
        }
    }
}
