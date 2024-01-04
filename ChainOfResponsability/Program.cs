using ChainOfResponsability.MIddlewares;
using ChainOfResponsability.Servers;
using System;

namespace ChainOfResponsability
{
    class Program
    {
        private static Server server;
        static void Init()
        {
            server = new Server();
            server.RegisterUser("master@teste.com", "789456");
            server.RegisterUser("teste2@teste.com", "741258963");

            Middleware middleware = new CheckUserMiddleware(server);
            middleware.LinkWith(new CheckPermissionMiddleware());
            server.SetMiddleware(middleware);
        }
        static void Main(string[] args)
        {
            Init();

            Boolean done;
            do
            {
                Console.WriteLine("Digite o seu e-mail");
                string email = Console.ReadLine();
                Console.WriteLine("Digite o sua senha");
                string passoword = Console.ReadLine();

                done = server.LogIn(email, passoword);


            } while (!done);
            Console.ReadLine();
        }
    }
}
