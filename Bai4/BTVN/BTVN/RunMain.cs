using System;
using System.Text;

namespace BTVN
{
    class RunMain
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Person person = new Person();
            person.nhap();
            person.xuat();
            person.CheckAge();

            Console.ReadKey();

        }
    }
}
