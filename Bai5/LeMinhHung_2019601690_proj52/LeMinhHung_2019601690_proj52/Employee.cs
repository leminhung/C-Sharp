using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class Employee
    {
        public string id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public int workingdays { get; set; }
        public double salary { get; set; }

        public const int PRICE = 500;

        public Employee()
        {
            this.id = "";
            this.name = "";
            this.age = 0;
            this.workingdays = 0;
            this.salary = 0;
        }

        public Employee(string id)
        {
            this.id = id;
            this.name = "";
            this.age = 0;
            this.workingdays = 0;
            this.salary = 0;
        }

        public Employee(string id, string name, int age, int workingdays)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.workingdays = workingdays;
            this.salary = this.workingdays * PRICE;
        }

        public void Input()
        {
            Console.Write("Nhap ID: ");
            id = Console.ReadLine().Trim();
            Console.Write("Nhap Ten: ");
            name = Console.ReadLine().Trim();
            Console.Write("Nhap Tuoi: ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Nhap So Ngay Cong: ");
            workingdays = int.Parse(Console.ReadLine());

            salary = workingdays * PRICE;
        }

        public void Output()
        {
            Console.WriteLine(
                $"ID: {id}" +
                $"\nTen: {name}" +
                $"\nTuoi: {age}" +
                $"\nSo Ngay Cong: {workingdays}" +
                $"\nLuong: {salary}"
            );
        }
    }
}
