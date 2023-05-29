using Microsoft.Azure.Storage;
using Microsoft.Azure.Storage.Queue;

namespace MessageReciever
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string con =
                "DefaultEndpointsProtocol=https;AccountName=yashu09storage;AccountKey=mZbpx0jCxeokzYf7irj0/KEeSjmwn5a31znqdtCAt0L3iUhKehwyj9rIOdMoUSEQVh/7KtZijV9g+AStXTFFuA==;EndpointSuffix=core.windows.net";
            CloudStorageAccount account = CloudStorageAccount.Parse(con);
            CloudQueueClient client = account.CreateCloudQueueClient();
            CloudQueue queue = client.GetQueueReference("myqueue");
            queue.CreateIfNotExists();
            Console.WriteLine("---- Message Receiver ----");
            Console.WriteLine("Waiting for messages....");
            while (true)
            {
                CloudQueueMessage message = queue.GetMessage();
                if (message != null)
                {
                    Console.WriteLine(message.AsString);
                    queue.DeleteMessage(message);
                }
            }
        }
    }
}