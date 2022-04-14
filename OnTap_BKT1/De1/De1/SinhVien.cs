using System;

namespace De1
{
    class SinhVien : Person
    {
        private string mSV;
        private float diem;
        private string xepLoai;


        public string MSV { get => mSV; set => mSV = value; }
        public float Diem { get => diem; }
        public string XepLoai { get => xepLoai; }

        public override void nhap()
        {
            base.nhap();
            Console.Write("Nhap Diem: ");
            diem = float.Parse(Console.ReadLine());

            xepLoai = xepLoaiHS();
        }

        private string xepLoaiHS()
        {
            if(diem >= 8)
            {
                return "Giỏi";
            }
            else if(diem >= 6.5)
            {
                return "Khá";
            }
            else if (diem >= 5)
            {
                return "Trung bình";
            }
            return "Kém";
        }
    }
}
