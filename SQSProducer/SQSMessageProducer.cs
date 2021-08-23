using System;
using System.Threading.Tasks;
using Amazon;
using Amazon.Runtime;
using Amazon.SQS;
using Amazon.SQS.Model;

namespace SQSProducer
{
    public class SQSMessageProducer
    {

        public SQSMessageProducer()
        {

        }

        public async Task Send(String message)
        {
            string accessKey = "";
            string secret = "";
            string queueUrl = "";
            bool useFifo = false;
            string messageGroupId = "";
            string awsregion = "";

            BasicAWSCredentials creds = new BasicAWSCredentials(accessKey, secret);

            RegionEndpoint region = RegionEndpoint.GetBySystemName(awsregion);

            SendMessageRequest sendMessageRequest = new SendMessageRequest(queueUrl, message);

            if (useFifo)
            {
                sendMessageRequest.MessageGroupId = messageGroupId;
            }

            var sqsClient = new AmazonSQSClient(creds, region);

            await sqsClient.SendMessageAsync(sendMessageRequest);

        }

    }
}