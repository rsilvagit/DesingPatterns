using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class PayPal : IPayPalPayment
    {
        private Token token;
        public Token AuthToken()
        {
            return new Token();
        }

        public void PayPalPayment()
        {
            token = AuthToken();
            Console.WriteLine("Enviando pagamento via PayPal");
            
        }

        public void PayPalReceive()
        {
            Console.WriteLine("Recebendo pagamento via PayPal");
        }
    }
}
