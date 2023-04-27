using System.Data;

namespace OOP_Practice
{
    class Calculator
    {
        public void Print()
        {
            Console.WriteLine("This is a calculator");
        }
        public void Welcome(string name)
        {
            Console.WriteLine($"Welcome {name}");
        }
        public void add(int a,int b)
        {
            Console.WriteLine(a+b);
        }
        public void sub(int a, int b = 0)
        {
            Console.WriteLine(a - b);
        }
        public void mul(int a, int b = 0)
        {
            Console.WriteLine(a * b);
        }
        public void div(int a, int b)
        {
            Console.WriteLine(a / b);
        }
        public int Square(int a)
        {
            return a * a;
        }
        public string Sen(string s)
        {
            return s;
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator a = new Calculator();
            a.Print();
            a.Welcome("Chandini");
            a.add(10, 20);
            int b = a.Square(10);
            Console.WriteLine( b );
            a.sub(10);
            a.sub(10, 5);
            a.mul(10, 5);
            a.div(100, 6);
            string c = a.Sen("Errors");
            Console.WriteLine($"It has no {c} " );
        }
    }
}