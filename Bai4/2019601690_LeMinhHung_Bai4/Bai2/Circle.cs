using System;

namespace Bai2
{
    class Circle
    {
        private float radius;
        
        public Circle()
        {
            this.radius = 0;
        }

        public Circle(float radius)
        {
            this.radius = radius;
           
        }

        public void nhap()
        {
            Console.Write("Nhap Ban Kinh R: ");
            radius = int.Parse(Console.ReadLine());
            
        }

        public double Area()
        {
            return Math.PI * radius * radius;
        }

        public double Perimeter()
        {
            return 2d * Math.PI * radius;
        }
    }
}
