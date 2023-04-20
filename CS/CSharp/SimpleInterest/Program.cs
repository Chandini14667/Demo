namespace SimpleInterest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter P");
            int P = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter r");
            int r = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter t");
            int t = Convert.ToInt16(Console.ReadLine());
            int SI = P * (1 + r * t);
            Console.WriteLine(SI);

        }
    }
}