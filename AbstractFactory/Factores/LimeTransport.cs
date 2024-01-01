﻿using AbstractFactory.Aircrafts;
using AbstractFactory.LandVehicles;


namespace AbstractFactory.Factores
{
    class LimeTransport : ITransportFactory
    {
        public IAircraft CreateTransportAircraft()
        {
            return new Drone();
        }

        public ILandVehicle CreateTransportVehicle()
        {
            return new Scooter();
        }
    }
}
