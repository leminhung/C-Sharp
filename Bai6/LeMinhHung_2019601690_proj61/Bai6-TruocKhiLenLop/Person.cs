using System;

namespace Bai6_TruocKhiLenLop
{
    class Person
    {
        static int generateId = 0;
        protected int id;
        protected string name;
        protected string address;

        public int Id { get => id; set => id = value; }
        public string DiaChi { get => address; set => address = value; }

        public Person()
        {
            generateId++;
            this.id = generateId;
            this.name = "";
            this.address = "";
        }

        public Person(string name, string address)
        {
            generateId++;
            this.id = generateId;
            this.name = name;
            this.address = address;
        }

        public virtual void Input()
        {
            Console.Write("Nhap Ten: ");
            name = Console.ReadLine().Trim();
            Console.Write("Nhap Dia Chi: ");
            address = Console.ReadLine().Trim();
        }

        public virtual void Output()
        {
            Console.Write("{0,-5} {1,-16} {2, 10}", id, name, address);
        }
    }
}
