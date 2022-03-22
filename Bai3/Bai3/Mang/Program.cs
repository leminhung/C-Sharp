int n, tong=0;
Console.Write("n = ");
n = int.Parse(Console.ReadLine());
int[] a = new int[n];

for (int i = 0; i < n; i++)
{
    a[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < n; i++)
{
    if (a[i] % 2 != 0)
       tong += a[i];
       
}
Console.Write("{0} ", tong);
Console.ReadKey();
