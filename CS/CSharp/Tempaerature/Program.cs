string z ;
do
{
    Console.WriteLine("Enter the temperature in degree C");
    int C = Convert.ToInt16(Console.ReadLine());
    double F = 1.8 * C + 32;
    Console.WriteLine($"Temperature in F is{F}   Temperature in C is{C}");
    Console.WriteLine("Do you wish to contunue(y/n)?");
    z = Console.ReadLine();

} while(z=="y");

