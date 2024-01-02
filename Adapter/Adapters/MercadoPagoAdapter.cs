using System;


namespace Adapter.Adapters
{
    class MercadoPagoAdapter : IPayPalPayment
    {
        private MercadoPago mercadoPago;

        public MercadoPagoAdapter(MercadoPago mercadoPago)
        {
            this.mercadoPago = mercadoPago;
            Console.WriteLine("Efetuando adaptação para transações via Mercado Pago");
        }
        public Token AuthToken()
        {
            return mercadoPago.AuthToken();
        }

        public void PayPalPayment()
        {
            this.mercadoPago.MercadoSendPayment();
        }

        public void PayPalReceive()
        {
            this.mercadoPago.MercadoReceivePayment();
        }
    }
}
