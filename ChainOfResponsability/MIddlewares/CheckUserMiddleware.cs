using ChainOfResponsability.Servers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability.MIddlewares
{
    class CheckUserMiddleware : Middleware
    {
        private Server server;
        public CheckUserMiddleware(Server server )
        {
            this.server = server;
        }
        public override bool Check(string email, string password)
        {
            if (!server.HasEmail(email))
            {
                Console.WriteLine("E-mail inválido e/ou senha inválidos!");
                return false;
            }
            if (!server.IsValidPassword(email, password))
            {
                Console.WriteLine("Senha inválida!");
                return false;
            }
            return CheckNext(email, password);
        }
    }
}
