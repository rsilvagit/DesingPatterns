
namespace Adapter
{
 interface IMercadoPago
    {
        Token AuthToken();
        void MercadoSendPayment();
        void MercadoReceivePayment();
    }
}
