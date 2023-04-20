Console.WriteLine("Enter First Number");
int n1 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter Second Number");
int n2 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter Operator");
char ch = Convert.ToChar(Console.ReadLine());
float r;
switch (ch)
{
    case '+':
        {
            r = n1 + n2;
            Console.WriteLine(r + "" + "is your result");
            break;

        }
    case '-':
        {
            r = n1 - n2;
            Console.WriteLine(r + "" + "is your result");
            break;

        }
    case '*':
        {
            r = n1 * n2;
            Console.WriteLine(r + "" + "is your result");
            break;

        }
    case '/':
        {
            r = n1 / n2;
            Console.WriteLine(r + "" + "is your result");
            break;

        }
    case '%':
        {
            r = n1 % n2;
            Console.WriteLine(r + "" + "is your result");
            break;

        }
    default:
        {
            Console.WriteLine("Wrong Choice");
            break;
        }
}