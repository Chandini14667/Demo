using Microsoft.Azure.Storage;
using Microsoft.Azure.Storage.Blob;

namespace AzureBlobsPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string con =
                "DefaultEndpointsProtocol=https;AccountName=chandini01storage;AccountKey=W4A4zE8lH/6ybgqOL1QeUkm4rOUwi5zGUSLdN8l47G1dXkfB2/kwqzgPojnffIhzcxcwCvHyEaQN+AStTGT8rA==;EndpointSuffix=core.windows.net";
            CloudStorageAccount csa = CloudStorageAccount.Parse(con);
            CloudBlobClient cbc = csa.CreateCloudBlobClient();

            Console.WriteLine("Getting reference of container");
            CloudBlobContainer container = cbc.GetContainerReference("democontainer");

            container.CreateIfNotExists();

            string[] fileEntries = Directory.GetFiles("C:\\Users\\cshaik5\\OneDrive - DXC Production\\Desktop\\DTraining\\Azure\\files");
            foreach (var f in fileEntries)
            {
                string key = Path.GetFileName(f);
                UploadBlob(container, key, f);
            }

        }

        private static void UploadBlob(CloudBlobContainer container, string key, string filename)
        {
            Console.WriteLine("Uploading file...." + filename);
            CloudBlockBlob b = container.GetBlockBlobReference(key);

            using (var fs = File.Open(filename, FileMode.Open, FileAccess.Read, FileShare.None))
            {
                b.UploadFromStream(fs);
            }

            Console.WriteLine("File Upload Completed");
        }
    }
}
