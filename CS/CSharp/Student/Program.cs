using System.Xml.Schema;

namespace Student
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Student Id");
            int id = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the Student Name");
            string name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the Student Age");
            int age = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the Student Marks1 ");
            int m1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the Student Marks2 ");
            int m2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the Student Marks3 ");
            int m3 = Convert.ToInt16(Console.ReadLine());
            int Sum = m1 + m2 + m3;
            Console.WriteLine(Sum + " " + "is your total score");
            float  P = (Sum / 3);
            Console.WriteLine(P + " " + "is your total percentage");
            if (P<=100 && P >= 90)
            {
                Console.WriteLine("Your Grade is A");
                Console.WriteLine("Your result for the exam is PASS");
            }
            else if (P <= 89 && P >= 80)
            {
                Console.WriteLine("Your Grade is B");
                Console.WriteLine("Your result for the exam is PASS");
            }
            else if (P <= 79 && P >= 60)
            {
                Console.WriteLine("Your Grade is C");
                Console.WriteLine("Your result for the exam is PASS");
            }
            else if (P <= 59 && P >= 50)
            {
                Console.WriteLine("Your Grade is D");
                Console.WriteLine("Your result for the exam is PASS");
            }
            else 
            {
                Console.WriteLine("Your Grade is E");
                Console.WriteLine("Your result for the exam is FAIL");
            }
           





        }
    }
}