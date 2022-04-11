using System;

namespace LeMinhHung_2019601690_proj62
{
    class Trunk : Vehicles
    {
        private int truckload;

        public Trunk()
        {
            this.truckload = 0;
        }

        public Trunk(string id, string marker, string model, int year, double price, int truckload) : base(id, marker, model, year, price)
        {
            this.truckload = truckload;
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Nhap TrunkLoad: ");
            truckload = int.Parse(Console.ReadLine());
        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine("{0, 0}", truckload);
        }
    }
}
