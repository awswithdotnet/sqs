using System;
using System.Threading.Tasks;

namespace SQSProducer
{
    class Program
    {
        static async Task Main(string[] args)
        {
           var message =  "New Message for " + DateTime.Now.ToString();

           SQSMessageProducer sqsMessageProducer = new SQSMessageProducer();

           await sqsMessageProducer.Send(message);

           Console.WriteLine("Message Sent: " + message);
        }

    }
}
