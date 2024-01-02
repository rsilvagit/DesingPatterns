using Builder.Builders;
using Builder.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Directors
{
    class Director
    {
        IBuilder builder;
        public Director(IBuilder builder)
        {
            this.builder = builder;
        }
        public void ConstructSedanCar()
        {
            builder.SetVehicleType(VehicleType.SEDAN);
            builder.SetEngine(new Engine(1000));
            builder.SetSeats(5);
            builder.SetTransmission(Transmission.AT);
        }
        public void ConstructTruck()
        {
            builder.SetVehicleType(VehicleType.TRUCK);
            builder.SetEngine(new Engine(5000));
            builder.SetSeats(2);
            builder.SetTransmission(Transmission.MT);
        }
        public void ConstructSuv() 
        {
            builder.SetVehicleType(VehicleType.SUV);
            builder.SetEngine(new Engine(2500));
            builder.SetSeats(4);
            builder.SetTransmission(Transmission.AT);
            builder.SetAirbag(Airbag.DUPLO_FRONTAL);
        }
    }
}