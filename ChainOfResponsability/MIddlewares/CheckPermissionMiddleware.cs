using ChainOfResponsability.Servers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability.MIddlewares
{
    class CheckPermissionMiddleware : Middleware
    {
      
        public override bool Check(string email, string password)
        {
            if (email.Equals("master@teste.com"))
            {
                Console.WriteLine("Seja bem-vindo administrador: ");
                return true;
            }
            Console.WriteLine("Seja bem-vindo!");
            return CheckNext(email, password);
        }
    }
}
