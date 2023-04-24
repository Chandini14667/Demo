int[] a = new int[10];
for(int i = 0; i < 10; i++)
{
    a[i] = Convert.ToInt16(Console.ReadLine());
}
for(int j=0; j<10; j++)
{
    for(int k=j+1;k<10; k++)
    {
        if (a[j] == a[k])
        {
            Console.WriteLine($"The duplicate values are: {a[k]}");
        }
    }
}
