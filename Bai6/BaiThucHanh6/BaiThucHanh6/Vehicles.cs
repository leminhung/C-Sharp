using System;
using System.Text;

namespace LeMinhHung_2019601690_proj62
{
    class Vehicles : IVehicle
    {
        protected string id;
        protected string marker;
        protected string model;
        protected int year;
        protected double price;

        public Vehicles()
        {
            this.id = "";
            this.marker = "";
            this.model = "";
            this.year = 0;
            this.price = 0;
        }

        public Vehicles(string id)
        {
            this.id = id;
            this.marker = "";
            this.model = "";
            this.year = 0;
            this.price = 0;
        }

        public Vehicles(string id, string marker, string model, int year, double price)
        {
            this.id= id;
            this.marker = marker;
            this.model = model;
            this.year = year;
            this.price = price;
        }

        public string Id { get => id; set => id = value; }
        public string Marker { get => marker; set => marker = value; }
        public string Model { get => model; set => model = value; }
        public int Year{ get => year; set => year = value; }
        public double Price { get => price; set => price = value; }

        public override bool Equals(object obj)
        {
            return id.Equals((obj as Vehicles).id);
        }

        public virtual void Input()
        {

            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập ID: ");
            id = Console.ReadLine();
            Console.Write("Nhập Nhà Sản Xuất: ");
            marker = Console.ReadLine();
            Console.Write("Nhập Mẫu Sản Xuất: ");
            model = Console.ReadLine();
            Console.Write("Nhập Năm Sản Xuất: ");
            year = int.Parse(Console.ReadLine());
            Console.Write("Nhập Giá Thành: ");
            price = double.Parse(Console.ReadLine());
        }

        public virtual void Output()
        {
            Console.Write(this);
        }

        public override string ToString()
        {
            return  $"{id}" +
                    $"\t     {marker}" +
                    $"\t     {model}" +
                    $"\t     {year}" +
                    $"\t     {price}" +
                    "\t     ";
        }
    }
}
