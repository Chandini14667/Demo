int[] a = new int[10];
for(int i = 0; i < 10; i++)
{
    a[i] = Convert.ToInt16(Console.ReadLine());
}
var sum = a[0] + a[1] + a[2] + a[3] + a[4] + a[5] + a[6] + a[7] + a[8] + a[9];
var avg = sum / 10;
Console.WriteLine($"The average of numbers is: {avg}");
