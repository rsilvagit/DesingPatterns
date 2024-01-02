using Builder.Components;
using Builder.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builders
{
    class VehicleBuider : IBuilder
    {
        public Vehicle GetVehicle()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public void SetEngine()
        {
            throw new NotImplementedException();
        }

        public void SetSeats()
        {
            throw new NotImplementedException();
        }

        public void SetVehicleType(VehicleType vehicleType)
        {
            throw new NotImplementedException();
        }
    }
}
