using System;
using System.Text;

namespace Bai1
{
    class RunMain
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Employee employee = new Employee("2", "Hung", 21, 20);
            employee.Output();

            Console.ReadLine();
        }
    }
}
