using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamGiac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            float a, b, c, chuVi;
            double P, dienTich;
            Console.Write("Nhập a = ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Nhập b = ");
            b = float.Parse(Console.ReadLine());
            Console.Write("Nhập c = ");
            c = float.Parse(Console.ReadLine());
            
            /*
                Tính chu vi tam giác 
            */
            chuVi = a + b + c;
            Console.Write("Chu vi tam giác cv = {0}", chuVi);

            /*
                Tính diện tích tam giác 
            */
            P = chuVi / 2;
            dienTich = Math.Sqrt(P * (P - a) * (P - b) * (P - c));
            Console.Write("Diên tích tam giác dt = {0}", dienTich);
            Console.ReadLine();
        }
    }
}
