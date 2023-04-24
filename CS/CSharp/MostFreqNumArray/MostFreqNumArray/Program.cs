int[] a = new int[5];
for(int i=0; i < 5; i++)
{
    a[i] = Convert.ToInt16(Console.ReadLine());
}
int count; int mf = 0;int n = a[0];
for(int j = 1; j < 5; j++)
{
    count = 0;
    for(int k = 0; k < 5; k++)
    {
        if (a[j] == a[k])
            count++;
    }
    if (mf < count)
    {
        mf = count;
        n = a[j];
    }
}
Console.WriteLine($"The most frequent number is: {n}");

