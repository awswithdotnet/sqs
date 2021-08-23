using System;
using System.Threading.Tasks;

namespace SQSConsumer
{
    class Program
    {
        static async Task Main(string[] args)
        {
            SQSMessageConsumer sqsConsumer = new SQSMessageConsumer();
                       
            await sqsConsumer.Listen();           
                       
        }
    }
}
