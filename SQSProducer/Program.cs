using System;
using System.Threading.Tasks;

namespace SQSProducer
{
    class Program
    {
        static async Task Main(string[] args)
        {
           var message =  "New Message for " + DateTime.Now.ToString();

           SQSMessageProducer sQSMessageProducer = new SQSMessageProducer();

           await sQSMessageProducer.Send(message);

           Console.WriteLine("Message Sent: " + message);
        }

    }
}
