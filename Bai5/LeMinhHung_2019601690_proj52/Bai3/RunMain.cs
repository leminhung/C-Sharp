using System;
using System.Collections.Generic;

namespace Bai3
{
    class RunMain
    {
        static List<TimUSCLN> timUSCLNs = new List<TimUSCLN>();
        static void Main(string[] args)
        {
            Console.Write("Nhap so phan tu n = ");
            int n = int.Parse(Console.ReadLine());
            for(int i=0; i<n; i++)
            {
                TimUSCLN timUSCLN = new TimUSCLN();
                timUSCLN.nhap();

                timUSCLNs.Add(timUSCLN);
            }

            Console.WriteLine("======Hien thi ds UCLN=====".ToString());
            Console.WriteLine("{0,-5} {1,-5} {2, -5}", "a", "b", "UCLN");

            foreach(TimUSCLN timUSCLN in timUSCLNs)
            {
                timUSCLN.HienThi();
            }

            Console.ReadLine();

        }

    }
}
