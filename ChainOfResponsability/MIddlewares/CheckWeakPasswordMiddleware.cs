using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability.MIddlewares
{
    class CheckWeakPasswordMiddleware : Middleware
    {
        public override bool Check(string email, string password)
        {
            if (password.Equals("123456"))
            {
                Console.WriteLine("Senha muito fraca para sua segurança solicitamops que altere para uma senha mais forte");
                
            }
            return CheckNext(email, password);
        }
    }
}
