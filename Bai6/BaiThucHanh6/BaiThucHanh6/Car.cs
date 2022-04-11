using System;

namespace LeMinhHung_2019601690_proj62
{
    class Car : Vehicles
    {
        private string color;

        public Car()
        {
            this.color = "";
        }

        public Car(string id, string marker, string model, int year, double price, string color) : base(id, marker, model, year, price)
        {
            this.color = color;
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Nhap Mau Sac: ");
            color = Console.ReadLine();
        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine("{0, 0}", color);
        }
    }
}
