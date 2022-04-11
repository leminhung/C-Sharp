using System;


namespace Bai6_TruocKhiLenLop
{
    class Student : Person
    {
        private float maths;
        private float physics;

        public Student():base()
        {
            this.physics = this.maths = 0;
        }

        public Student(string name, string address, float maths, float physics) : base(name, address)
        {
            this.maths = maths;
            this.physics = physics;
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Nhap Diem Toan: ");
            maths = int.Parse(Console.ReadLine().Trim());
            Console.Write("Nhap Diem Ly: ");
            physics = int.Parse(Console.ReadLine().Trim());
        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine("{0,10} {1,10} {2,10}", maths, physics, Total());
        }

        public float Total()
        {
            return maths + physics;
        }
    }
}
