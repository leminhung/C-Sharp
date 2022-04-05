using System;

namespace Bai1
{
    class Person
    {
        private string id;
        private string name;
        private int age;
        private string email;
        private string address;

        public Person()
        {
            id = "";
            name = "";
            age = 0;
            email = "";
            address = "";
        }

        public Person(string id, string name, int age, string email, string address)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.email = email;
            this.address = address;
        }

        public void nhap()
        {
            Console.Write("Nhap ID: ");
            id = Console.ReadLine().Trim();
            Console.Write("Nhap Ten: ");
            name = Console.ReadLine().Trim();
            Console.Write("Nhap Tuoi: ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Nhap Email: ");
            email = Console.ReadLine().Trim();
            Console.Write("Nhap Address: ");
            address = Console.ReadLine().Trim();
        }

        public void xuat()
        {
            Console.WriteLine(
                $"ID: {id}" +
                $"\nTen: {name}" +
                $"\nTuoi: {age}" +
                $"\nEmail: {email}" +
                $"\nAddress: {address}"
            );
        }

        public void CheckAge()
        {
            if (age >= 18) Console.WriteLine("Bạn đủ tuổi bầu cử");
            Console.WriteLine("Bạn còn nhỏ");
        }
    }
}
