using Builder.Builders;
using Builder.Directors;
using Builder.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleBuider buider = new VehicleBuider();
            Director director = new Director(buider);

            director.ConstructSedanCar();

            Vehicle sedan = buider.GetVehicle();

            Console.WriteLine($"Criando Veiculo {sedan.VehicleType}");

            director.ConstructTruck();
            Vehicle truck = buider.GetVehicle();
            Console.WriteLine($"Criando Veiculo {truck.VehicleType}");

            director.ConstructSuv();
            Vehicle suv = buider.GetVehicle();
            Console.WriteLine($"Crindo Veiculo {suv.VehicleType}, Motor {suv.Engine.Power}, Airbags {suv.Airbag} ");
            Console.ReadLine();
        }
    }
}
