using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class MercadoPago : IMercadoPago
    {
        private Token token;
        public Token AuthToken()
        {
            return new Token();
        }

        public void MercadoReceivePayment()
        {
            token = this.AuthToken();
            Console.WriteLine("Recebendo via Mercado Pago");
        }

        public void MercadoSendPayment()
        {
            token= this.AuthToken();
            Console.WriteLine("Pagando via Mercado Pago");
        }
    }
}
