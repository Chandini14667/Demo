namespace GreaterNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;
            Console.WriteLine("Enter First Number");
            n1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            n2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Third Number");
            n3 = Convert.ToInt16(Console.ReadLine());
            if(n1>n2 && n1 > n3)
            {
                Console.WriteLine("First Number is Greater");
            }else if(n2>n1 && n2>n3)
            {
                Console.WriteLine("Second Number is Greater");
            }else if(n3>n1 && n3>n2)
            {
                Console.WriteLine("Third Number is Greater");
            }
            else
            {
                Console.WriteLine("All are Equal");
            }
        }
    }
}