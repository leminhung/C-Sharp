Boolean check = false;

int n;
Console.Write("Nhap n = ");
n = int.Parse(Console.ReadLine());


/* a. Dung while*/
/*while(n < 1 || n > 100)
{
    Console.Write("Nhap lai n = ");
    n = int.Parse(Console.ReadLine());
}*/

/* b. Dung for*/
do
{
    Console.Write("Nhap lai n = ");
    n = int.Parse(Console.ReadLine());
} while (n < 1 || n > 100);
