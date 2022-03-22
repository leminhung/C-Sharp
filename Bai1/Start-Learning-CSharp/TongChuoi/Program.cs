using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TongChuoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int n;
            Console.Write("Nhap n = ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Tong chuoi S1 = {0}", tongChuoi1(n));
            Console.WriteLine("Tong chuoi S2 = {0}", tongChuoi2(n));
            Console.ReadLine();
        }

        static int tongChuoi1(int n)
        {
            return n * (1 + n) / 2;
        }

        static float tongChuoi2(int n)
        {
            if(n == 1)
                return 1;
            return (float)1/n + tongChuoi2(n - 1);
        }
    }
}
