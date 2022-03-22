int n;
Console.Write("n = ");
n = int.Parse(Console.ReadLine());
int[] a = new int[n];

for(int i = 0; i < n; i++)
{
    a[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < n; i++)
{
    if(a[i] % 2 == 0)
        Console.Write("{0} ", a[i]);
}
Console.WriteLine("");

for (int i = 0; i < n; i++)
{
    if (a[i] % 2 != 0)
        Console.Write("{0} ", a[i]);
}

Console.ReadKey();