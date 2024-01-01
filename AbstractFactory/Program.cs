﻿using AbstractFactory.App;
using AbstractFactory.Factores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static Application ConfigureApplication()
        {
            Application app;
            ITransportFactory transportFactory;
            string company = "Lime";

            if(company == "Uber")
            {
                transportFactory = new UberTransport();
            }else if(company == "99")
            {
                transportFactory = new NineNineTransport();
            }
            else
            {
                transportFactory= new LimeTransport();
            }

            app = new Application(transportFactory);
            return app;
        }
        static void Main(string[] args)
        {
            Application app = ConfigureApplication();
            app.StartRoute();
            Console.ReadLine();

        }
    }
}
