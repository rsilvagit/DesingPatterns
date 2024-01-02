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
        private int _seats;
        private Engine _engine;
        private Transmission _transmission;
        private Airbag _airbag;

        public VehicleType VehicleType
        {
            get { return _vehicleType; }
            set { _vehicleType = value; }
        }
        public int Seats
        {
            get { return _seats; }
            set { _seats = value; }
        }
        public Engine Engine
        {
            get { return _engine; }
            set{_engine = value; }
        }
        public Transmission Transmission
        {
            get { return _transmission; }
            set { _transmission = value; }
        }
        public Airbag Airbag
        {
            get { return _airbag; }
            set { _airbag = value; }
        }

    }
}
