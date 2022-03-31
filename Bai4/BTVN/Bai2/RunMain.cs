using BTVN;
using System;
using System.Text;

namespace Bai2
{
    class RunMain
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Circle circle = new Circle();
            circle.nhap();

            Console.WriteLine("Chu vi hinh tron P = {0}", circle.Perimeter());
            Console.WriteLine("Dien tich hinh tron S = {0}", circle.Area());

            Console.ReadKey();

        }
    }
}
