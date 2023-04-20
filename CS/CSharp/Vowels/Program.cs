namespace Vowels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter an Alphabet");
            ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A'|| ch == 'E' || ch == 'I' || ch=='O' || ch == 'U')
            {
                Console.WriteLine("It is a Vowel");
            }
            else
            {
                Console.WriteLine("It is not a Vowel");
            }

        }
    }
}