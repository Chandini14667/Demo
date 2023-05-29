namespace enumPractice
{
    enum Features { Audio,Video=10,Message}
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Features.Audio );
            Console.WriteLine(Features.Message);
        }
    }
}