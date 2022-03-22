string s;
Boolean check = true;
Console.Write("Nhap chuoi s = ");
s = Console.ReadLine();

if(s.Length == 0)
{
    Console.WriteLine("hay nhap chuoi s co do dai lon hon 0");
}

else
{
    for (int i = 0; i <s.Length; i++)
    {
        if(!s[i].Equals(s[s.Length-1-i]))
        {
            check = false;
            break;
        }
    }
    if (check) Console.WriteLine("Chuoi {0} la chuoi doi xung", s);
    else Console.WriteLine("Chuoi {0} la chuoi khong doi xung", s);
}



