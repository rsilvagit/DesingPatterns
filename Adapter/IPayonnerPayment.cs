

namespace Adapter
{
    interface IPayPayonner
    {
        Token AuthToken();
        void SendPayment();
        void ReceivePayment();
    }
}
