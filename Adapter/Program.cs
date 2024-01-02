using Adapter.Adapters;
using System;


namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // PayPal payment = new PayPal();
            //Payonner payment = new Payonner();

            //IPayPalPayment payment = new PayonnerAdapter(new Payonner());

            IPayPalPayment payment = new MercadoPagoAdapter(new MercadoPago());
            payment.PayPalPayment();
            payment.PayPalReceive();

            //payment.SendPayment();
            //payment.ReceivePayment();

            Console.ReadLine();

        }
    }
}
