Console.Write("Nhap chuoi: ");
string myString = Console.ReadLine();
char[] myArray = myString.ToCharArray();
int doDai = myArray.Length;
if (doDai < 2)
    Console.WriteLine("Khong doi xung");
else
{
    for (int i = 0; i < doDai / 2; i++)
        if (myArray[i] != myArray[doDai - 1 - i])
        {
            Console.WriteLine("Day khong phai la chuoi doi xung");
            return;
        }
    Console.WriteLine("Day la chuoi doi xung");
}