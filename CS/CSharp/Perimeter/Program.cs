namespace Perimeter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Length");
            int Length = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Breadth");
            int Breadth = Convert.ToInt16(Console.ReadLine());
            int Perimeter = (Length + Breadth) * 2;
            Console.WriteLine(Perimeter);
        }
    }
}