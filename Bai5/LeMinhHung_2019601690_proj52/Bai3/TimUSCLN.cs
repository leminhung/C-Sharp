using System;

namespace Bai3
{
    class TimUSCLN
    {
        public int sothu1 { get; set; }
        public int sothu2 { get; set; }

        public TimUSCLN()
        {
            this.sothu1 = 0;
            this.sothu2 = 0;
        }

        public TimUSCLN(int sothu1, int sothu2)
        {
            this.sothu1 = 0;
            this.sothu2 = 0;
        }

        public int handle(int a, int b)
        {
            if (a == b) return a;
            else if (a > b) return handle(b, a - b);
            else return handle(b - a, a);
        }

        public void nhap()
        {
            Console.Write("So thu nhat: ");
            sothu1 = int.Parse(Console.ReadLine());
            Console.Write("So thu hai: ");
            sothu2 = int.Parse(Console.ReadLine());
        }

        public void HienThi()
        {
            Console.WriteLine("{0,-5} {1,-5} {2, -5}", sothu1, sothu2, handle(sothu1, sothu2));
        }
    }
}
