using System;

namespace DeCa1
{
    class ThiSinhUT:ThiSinh
    {
        private int khuvuc;
        private float diemuutien;

        public int KhuVuc { get => khuvuc; set => khuvuc = value; }

        public void NhapThongTin()
        {
            Console.Write("Nhap hoTen: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap diem toan: ");
            DiemToan = float.Parse(Console.ReadLine());
            Console.Write("Nhap diem ly: ");
            DiemLy = float.Parse(Console.ReadLine());
            Console.Write("Nhap diem hoa: ");
            DiemHoa = float.Parse(Console.ReadLine());
            Console.Write("Nhap khu vuc: ");
            khuvuc = int.Parse(Console.ReadLine());

            if (khuvuc == 1)
            {
                diemuutien = 0;
            }
            else if (khuvuc == 2)
            {
                diemuutien = 0.5f;
            }
            else diemuutien = 1;
        }



        public void HienThi()
        {
            Console.WriteLine("{0,-5} {1,-16} {2, 10} {3, 10} {4, 10} {5, 10} {6, 10} {7, 10}", SBD, HoTen, DiemToan, DiemLy, DiemHoa, khuvuc, diemuutien, TongDiem());
        }

        public override float TongDiem()
        {
            return base.TongDiem() + diemuutien;
        }
    }
}
