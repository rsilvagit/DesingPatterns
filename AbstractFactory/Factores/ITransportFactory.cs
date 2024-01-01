
using AbstractFactory.Aircrafts;
using AbstractFactory.LandVehicles;

namespace AbstractFactory.Factores
{
    interface ITransportFactory
    {
        IAircraft CreateTransportAircraft();
        ILandVehicle CreateTransportVehicle();
    }
}
