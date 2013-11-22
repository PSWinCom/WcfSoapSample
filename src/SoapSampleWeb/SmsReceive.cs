using System;
using PSWinCom.Gateway.SoapContracts;

namespace SoapSampleWeb
{
    public class SmsReceive : SMSReceiveSoap
    {
        public ReturnValue ReceiveSMSMessage(IncomingSMSMessage m)
        {
            /* Your implementation here */
            return new ReturnValue { Code = 200 };
        }

        public ReturnValue ReceiveDeliveryReport(DeliveryReport dr)
        {
            /* Your implementation here */
            return new ReturnValue { Code = 200 };
        }

        public ReturnValue ReceiveMMSMessage(IncomingMMSMessage m)
        {
            /* Your implementation here */
            return new ReturnValue { Code = 200 };
        }
    }
}