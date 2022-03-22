Console.OutputEncoding = System.Text.Encoding.UTF8;
float a, b, c, chuVi;
double P, dienTich;

do { 
    Console.Write("Nhập a = ");
    a = float.Parse(Console.ReadLine());
    Console.Write("Nhập b = ");
    b = float.Parse(Console.ReadLine());
    Console.Write("Nhập c = ");
    c = float.Parse(Console.ReadLine());
} while (a + b < c || a + c < b || b + c < a);


/*
    Tính chu vi tam giác 
*/
chuVi = a + b + c;
Console.WriteLine("Chu vi tam giác cv = {0}", chuVi);

/*
    Tính diện tích tam giác 
*/
P = chuVi / 2;
dienTich = Math.Sqrt(P * (P - a) * (P - b) * (P - c));
Console.Write("Diên tích tam giác dt = {0}", dienTich);
Console.ReadLine();
