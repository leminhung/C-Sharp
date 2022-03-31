﻿using System;

namespace BTVN
{
    class Student
    {
        public string id { get; set; }
        public string name { get; set; }
        public int mark { get; set; }
        public int scholarship { get; set; }

        public Student()
        {
            id = "";
            name = "";
            mark = 0;
        }
        public Student(String id)
        {
            this.id = id;
            name = "";
            mark = 0;
        }

        public Student(string id, string name, int mark)
        {
            this.id = id;
            this.name = name;
            this.mark = mark;
        }

        public void nhap()
        {
            Console.Write("Nhap ID: ");
            id = Console.ReadLine().Trim();
            Console.Write("Nhap Ten: ");
            name = Console.ReadLine().Trim();
            Console.Write("Nhap Diem: ");
            mark = int.Parse(Console.ReadLine());
        }

        public void xuat()
        {
            Console.WriteLine(
                $"ID: {id}" +
                $"\nTen: {name}" +
                $"\nTuoi: {mark}" +
                $"\nHoc bong: {scholarship}"
            );
        }

        public int setScholarship()
        {
            if (mark > 8)
                this.scholarship = 500;
            else if (mark >= 7)
                this.scholarship = 300;
            else this.scholarship = 0;

            return this.scholarship;
        }

    }
}
