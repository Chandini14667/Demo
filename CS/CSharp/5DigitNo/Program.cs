Console.WriteLine("Enter a five digit number");
int n = Convert.ToInt16(Console.ReadLine());
int sum = 0, x;
while (n > 0)
{
    x = n % 10;
    sum = sum + x;
    n = n / 10;
}
Console.WriteLine($"The sum is {sum}");
