using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XepLoaiHS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            float diem;
            string ten;
            Console.Write("Nhập diem = ");
            diem = float.Parse(Console.ReadLine());
            Console.Write("Nhập ten:  ");

            ten = Console.ReadLine();

            if (diem >= 8f) Console.WriteLine("Ten: {0}", ten.ToUpper());
            else if (diem < 8f && diem >= 6.5f) Console.WriteLine("Ten: {0}", ten.ToUpper());
            else if (diem < 6.5f && diem >= 5f) Console.WriteLine("Ten: {0}", ten.ToUpper());
            else Console.WriteLine("Ten: {0}", ten.ToUpper());

            Console.ReadLine();
        }
    }
}
