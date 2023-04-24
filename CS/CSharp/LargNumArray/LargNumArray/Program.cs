int[] a = new int[5];
for(int i = 0; i < 5; i++)
{
    a[i]=Convert.ToInt16(Console.ReadLine());
}
if (a[0] > a[1] && a[0] > a[2] && a[0] > a[3] && a[0] > a[4])
{
    Console.WriteLine($"{a[0]} is greater");
}
else if (a[1] > a[0] && a[1] > a[2] && a[1] > a[3] && a[1] > a[4])
{
    Console.WriteLine($"{a[1]} is greater");
}
else if (a[2] > a[0] && a[2] > a[1] && a[2] > a[3] && a[2] > a[4])
{
    Console.WriteLine($"{a[2]} is greater");
}
else if (a[4] > a[0] && a[4] > a[1] && a[4] > a[2] && a[4] > a[3])
{
    Console.WriteLine($"{a[4]} is greater");
}
else
{
    Console.WriteLine(" Wrong Choice of numbers ");
}