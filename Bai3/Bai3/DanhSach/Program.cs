using System;
using System.Collections.Generic;

namespace DanhSach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            List<double> values = new List<double>();
            //Nhập 5 phần tử
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Nhập phần tử thứ {0} = ", i + 1);
                values.Add(double.Parse(Console.ReadLine()));
            }
            //Sắp xếp và in
            values.Sort();
            foreach (double i in values)
                Console.Write(i + " ");
            Console.WriteLine();
            //Kiểm tra và xóa số âm và in
            for (int i = 0; i < values.Count; i++)
                while (values[i] < 0)
                    values.RemoveAt(i);

            foreach (double e in values)
                Console.Write(e + " ");
            Console.WriteLine();
            //Chèn và in
            Console.Write("Nhập số x = ");
            double x = double.Parse(Console.ReadLine());
            for (int i = 0; i < values.Count; i++)
                if (values[i] > x)
                {
                    values.Insert(i, x);
                    break;
                }

            foreach (double i in values)
                Console.Write(i + " ");
        }
    }
}
