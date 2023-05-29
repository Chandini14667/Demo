using Microsoft.Azure.Storage;
using Microsoft.Azure.Storage.Queue;

namespace MessageSender
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string con =
                "DefaultEndpointsProtocol=https;AccountName=chandini01storage;AccountKey=hvhJbwUpffdimI1KnbNFTZ83Jh8pbiCNM7xvytx7vaZD3FNTNYY9gJGIyy1FWm3P4Mq+kO4tRhKv+AStDlJHDA==;EndpointSuffix=core.windows.net";
            CloudStorageAccount account = CloudStorageAccount.Parse(con);
            CloudQueueClient client = account.CreateCloudQueueClient();
            CloudQueue queue = client.GetQueueReference("myqueue");
            queue.CreateIfNotExists();
            Console.WriteLine("---- Message Sender ----");
            while (true)
            {
                Console.WriteLine("Type Your Message");
                string msg = Console.ReadLine();
                CloudQueueMessage message = new CloudQueueMessage(msg);
                queue.AddMessage(message);
                Console.WriteLine("Message Sent!");
            }
        }
    }
}