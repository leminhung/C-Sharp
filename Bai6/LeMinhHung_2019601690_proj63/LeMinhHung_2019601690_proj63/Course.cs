using System;
using System.Collections.Generic;

namespace LeMinhHung_2019601690_proj63
{
    class Course
    {
        private string courseid;
        private string courseName;
        private int fee;

        public string CourseId { get => courseid; set => courseid = value; }

        private List<Student> listStd = new List<Student>();
        public List<Student> Students { get => listStd; set => listStd = value; }

        public Course()
        {
            this.listStd = new List<Student>();
            this.courseid = "";
            this.courseName = "";
            this.fee = 0;
        }

        public void InputStudent()
        {
            Console.Write("Nhap ID: ");
            courseid = Console.ReadLine().Trim();
            Console.Write("Nhap Ten: ");
            courseName = Console.ReadLine().Trim();
            Console.Write("Nhap Fee: ");
            fee = int.Parse(Console.ReadLine().Trim());

            Console.Write("Nhap so SV = ");
            int soSV = int.Parse(Console.ReadLine().Trim());
            for(int i=0; i<soSV; i++)
            {
                Console.WriteLine($"==Nhap Sv thu {i+1}==".ToUpper());
                Student s = new Student();
                s.InputStudent();
                listStd.Add(s);
            }
        }

        public void DisplayCourseAndStudent()
        {
            Console.WriteLine($"ID: {courseid}");
            Console.WriteLine($"Ten khoa hoc: {courseName}");
            Console.WriteLine($"Fee: {fee}");

            Console.WriteLine("==thong tin sinh vien".ToUpper());
            Console.WriteLine("{0,-5} {1,8} {2, 8}", "ID", "Name", "Mark");
            foreach (Student s in listStd)
            {
                Console.WriteLine(s);
            }

        }

        public List<Student> GetAllStudents()
        {
            return listStd;
        }
    }
}
