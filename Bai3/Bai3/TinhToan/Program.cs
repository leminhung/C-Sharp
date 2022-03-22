float a, b;
String k;
Console.Write("a = ");
a = float.Parse(Console.ReadLine());
Console.Write("b = ");
b = float.Parse(Console.ReadLine());
Console.Write("Operator: ");
k = Console.ReadLine();

switch (k)
{
    case "+":
        Console.WriteLine("{0} + {1} = {2}", a, b, (a+b));
        break;
    case "-":
        Console.WriteLine("{0} - {1} = {2}", a, b, (a - b));
        break;
    case "*":
        Console.WriteLine("{0} * {1} = {2}", a, b, (a * b));
        break;
    case "/":
        Console.WriteLine("{0} + {1} = {2}", a, b, (a / b));
        break;
    default:
        Console.WriteLine("Ban da nhap sai toan tu, moi nhap lai :))");
        break;
}

