using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using System.Xml.Linq;

namespace TableStoragePractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string con =
                "DefaultEndpointsProtocol=https;AccountName=chandini01storage;AccountKey=hvhJbwUpffdimI1KnbNFTZ83Jh8pbiCNM7xvytx7vaZD3FNTNYY9gJGIyy1FWm3P4Mq+kO4tRhKv+AStDlJHDA==;EndpointSuffix=core.windows.net";
            CloudStorageAccount account = CloudStorageAccount.Parse(con);
            CloudTableClient client = account.CreateCloudTableClient();
            CloudTable table = client.GetTableReference("Product");
            table.CreateIfNotExistsAsync();
            var ops = TableOperation.Insert(new Product()
            {
                Name = "Laptop",
                Brand = "Dell",
                Quantity = 5,
                Price = 76000
            });

            var res = table.ExecuteAsync(ops);

            var entity = res.Result;
            Console.WriteLine(entity);

        }
    }
}