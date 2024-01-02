using System;

namespace Adapter
{
    class Payonner: IPayPayonner
    {

        private Token token;

        public Token AuthToken()
        {
            return new Token();
        }

        public void ReceivePayment()
        {
            token = AuthToken();
            Console.WriteLine("Recebendo pagamento via payonner");

        }

        public void SendPayment()
        {
            token = AuthToken();
            Console.WriteLine("Enviando pagamento via payonner");
        }
    }
}
