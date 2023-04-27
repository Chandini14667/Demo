using Classes;
using System.Threading.Channels;

namespace Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter a number: ");
            int b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the operator: ");
            var x = Console.ReadLine();
            switch (x)
            {
                case "+":
                    int r = a+b;
                    Console.WriteLine( r);
                    break;
                case "-":
                    int s = a - b;
                    Console.WriteLine(s);
                    break;
                case "*":
                    int t = a * b;
                    Console.WriteLine(t);
                    break;
                case "/":
                    int u = a / b;
                    Console.WriteLine(u);
                    break;
                

            }
            Console.ReadKey();

        }
    }
}