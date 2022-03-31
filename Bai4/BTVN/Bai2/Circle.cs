using System;

namespace BTVN
{
    class Circle
    {
        public float radius { get; set; }
        
        public Circle()
        {
            radius = 0;
            
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
