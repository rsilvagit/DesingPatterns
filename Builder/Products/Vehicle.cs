using Builder.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Products
{
    class Vehicle
    {
        private VehicleType _vehicleType;
        private int seats;
        private Engine _engine;
        private Transmission _transmission;

        public VehicleType VehicleType
        {
            get { return _vehicleType; }
            set { _vehicleType = value; }
        }
        public int Seats
        {
            get { return seats; }
            set { seats = value; }
        }
        public Engine Engine
        {
            get { return _engine; }
            set{_engine = value; }
        }
        public Transmission Transmission
        {
            get { return _transmission; }
            set{ _transmission = value; }
        }

    }
}
