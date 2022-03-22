int n, x;
float tmp, g;

Console.Write("n = ");
n = int.Parse(Console.ReadLine());

float[] a = new float[1000];

for (int i = 0; i < n; i++)
{
    a[i] = float.Parse(Console.ReadLine());
}

/*
 Sap xep tang
 */
/*void sapXepTang()
{
    for (int i = 0; i < n - 1; i++)
        for (int j = n - 1; j > i; j--)
        {
            if (a[j - 1] > a[j])
            {
                tmp = a[j - 1];
                a[j - 1] = a[j];
                a[j] = tmp;
            }
        }
}*/



/*
 Xoa phan tu khoi mang
 */

void xoaPhanTu(int k)
{
    for (int i = k; i < n - 1; i++)
    {
        a[i] = a[i + 1];
        Console.Write("{0} ", a[i]);
    }
    --n;
}

/*
 Chen phan tu vao mang
 */

void chenPhanTu(float g, int x)
{
    for (int i = n; i > x; i--)
    {
        a[i] = a[i-1];
    }
    a[x] = g;
    ++n;
}


/*
 * Xoa phan tu am
 */
/*//**void xoaPhanTuAm()
{
    for (int i = 0; i < n; i++)
    {
        if (a[i] < 0)
        {
            xoaPhanTu(i);
            i--;
        }
    }
    Console.WriteLine("");
*//*}*/



/*
 Hien thi
 */
void hienThi()
{
    for (int i = 0; i < n; i++)
    {
        Console.Write("{0} ", a[i]);
    }
    Console.ReadLine();
}




Console.Write("Nhap g = ");
g = float.Parse(Console.ReadLine());
Console.Write("VT can chen x = ");
x = int.Parse(Console.ReadLine());
chenPhanTu(g, x);
hienThi();

