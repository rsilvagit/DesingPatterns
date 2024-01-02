using Builder.Components;
using Builder.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builders
{
    interface IBuilder
    {
        void Reset();
        Vehicle GetVehicle();
        void SetSeats( int sats);
        void SetEngine(Engine engine);
        void SetTransmission(Transmission transmission);
        void SetVehicleType(VehicleType vehicleType);
        void SetAirbag(Airbag airbag);

    }
}
