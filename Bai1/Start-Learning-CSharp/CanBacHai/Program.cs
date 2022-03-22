using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanBacHai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            float EPSILON;
            Console.Write("Nhap a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap EPSILON = ");
            EPSILON = float.Parse(Console.ReadLine());
            Console.WriteLine("ANS = {0}", mySqrt(a, EPSILON));
            Console.ReadLine();
        }

        static float mySqrt(int number, float EPSILON)
        {   
            float result = 1.0f;
            while ((float)Math.Abs(result * result - number) / number >= EPSILON)
                result = (number / result - result) / 2 + result;
            return result;
        }
    }
}
