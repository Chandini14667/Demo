namespace Temperature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Temperature in C");
            int C = Convert.ToInt16(Console.ReadLine());
            int F = (9 / 5) * C + 32;
            Console.WriteLine(F);
        }
    }
}