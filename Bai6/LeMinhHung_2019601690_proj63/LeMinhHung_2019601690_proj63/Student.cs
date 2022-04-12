using System;


namespace LeMinhHung_2019601690_proj63
{
    class Student
    {
        protected int studentid;
        protected string name;
        protected float mark;

        public int StudentId { get => studentid; set => studentid = value; }
        public float Mark { get => mark; set => mark = value; }

        public Student()
        {
            this.studentid = 0;
            this.name = "";
            this.mark = 0;
        }

        public Student(int studentid, string name, float mark)
        {
            this.studentid = studentid;
            this.name = name;
            this.mark = mark;
        }

        public void InputStudent()
        {
            Console.Write("Nhap MHS: ");
            studentid = int.Parse(Console.ReadLine());
            Console.Write("Nhap Ten: ");
            name = Console.ReadLine().Trim();
            Console.Write("Nhap Diem: ");
            mark = float.Parse(Console.ReadLine().Trim());
        }

        public virtual void Output()
        {
            Console.Write(this);
        }

        public override string ToString()
        {
            return $"{studentid}" +
                    $"\t     {name}" +
                    $"\t     {mark}" +
                    "\t     ";
        }
    }
}
