using BTVN;
using System;
using System.Text;

namespace Bai3
{
    class RunMain
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Student student = new Student();
            student.nhap();
            student.setScholarship();
            student.xuat();

            Console.ReadKey();

        }
    }
}
