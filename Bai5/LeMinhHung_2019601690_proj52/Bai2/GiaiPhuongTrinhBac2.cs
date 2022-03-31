using System;


namespace Bai2
{
    class GiaiPhuongTrinhBac2
    {
        public int a { get; set; }
        public int b { get; set; }
        public int c { get; set; }

        public GiaiPhuongTrinhBac2()
        {
            this.a = 0;
            this.b = 0;
            this.c = 0;
        }

        public GiaiPhuongTrinhBac2(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void giaiPTB2()
        {
            float delta = b * b - 4 * a * c;
            if (delta < 0) Console.WriteLine("Phuong trinh vo nghiem");
            else if (delta == 0) Console.WriteLine("Phuong trinh co nghiem kep x1 = x2 = {0}", -b/(2*a));
            else
            {
                Console.WriteLine("====Phuong trinh co 2 nghiem x1 = {0},  x2={1}", (-b + Math.Sqrt(delta))/(2*a), (-b - Math.Sqrt(delta)) / (2 * a));
            }
        }

    }
}
