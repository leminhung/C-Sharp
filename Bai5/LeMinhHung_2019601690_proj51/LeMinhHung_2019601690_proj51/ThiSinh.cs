using System;

namespace LeMinhHung_2019601690_proj51
{
    class ThiSinh
    {
        private string HoTen;
        private double DiemToan;
        private double DiemLy;
        private double DiemHoa;
        private double DiemUuTien;

        private int soBaoDanh;
        public int SoBaoDanh { get => soBaoDanh; set => soBaoDanh = value; }

        private double tongDiem;
        public double TongDiem { get => tongDiem; set => tongDiem = value; }

        private string diaChi;
        public string DiaChi { get => diaChi; set => diaChi = value; }


        public ThiSinh()
        {
            this.soBaoDanh = 0;
            this.HoTen = "";
            this.diaChi = "";
            this.DiemToan = 0;
            this.DiemLy = 0;
            this.DiemHoa = 0;
            this.DiemUuTien = 0;
            this.tongDiem = 0;
        }

        public ThiSinh(int SoBaoDanh)
        {
            this.soBaoDanh = SoBaoDanh;
            this.HoTen = "";
            this.diaChi = "";
            this.DiemToan = 0;
            this.DiemLy = 0;
            this.DiemHoa = 0;
            this.DiemUuTien = 0;
            this.tongDiem = 0;
        }


        public ThiSinh(int soBaoDanh, string hoTen, string diaChi, double diemToan, double diemLy, double diemHoa, double diemUuTien)
        {
            this.soBaoDanh = soBaoDanh;
            this.HoTen = hoTen;
            this.diaChi = diaChi;
            this.DiemToan = diemToan;
            this.DiemLy = diemLy;
            this.DiemHoa = diemHoa;
            this.DiemUuTien = diemUuTien;
            this.tongDiem = diemToan + diemLy + diemHoa + diemUuTien;
        }


        public void nhap()
        {
            Console.Write("Nhập Họ Tên: ");
            HoTen = Console.ReadLine().Trim();
            Console.Write("Nhập Địa Chỉ: ");
            diaChi = Console.ReadLine().Trim();
            Console.Write("Nhập Điểm Toán: ");
            DiemToan = double.Parse(Console.ReadLine());
            Console.Write("Nhập Điểm Lý: ");
            DiemLy = double.Parse(Console.ReadLine());
            Console.Write("Nhập Điểm Hóa: ");
            DiemHoa = double.Parse(Console.ReadLine());
            Console.Write("Nhập Điểm Ưu Tiên: ");
            DiemUuTien = double.Parse(Console.ReadLine());

            tongDiem = DiemHoa + DiemToan + DiemLy + DiemUuTien;
        }

        public override string ToString()
        {
            return
                $"\nSBD: {soBaoDanh}" +
                $"\nHọ Tên: {HoTen}" +
                $"\nĐịa Chỉ: {diaChi}" +
                $"\nĐiểm Toán: {DiemToan}" +
                $"\nĐiểm Lý: {DiemLy}" +
                $"\nĐiểm Hóa: {DiemHoa}" +
                $"\nĐiểm Ưu Tiên: {DiemUuTien}" +
                $"\nTổng Điểm: {tongDiem}";
        }

        public void xuat()
        {
            Console.WriteLine("{0,-5} {1,-16} {2, 10} {3, 5} {4, 5} {5, 5} {6, 8} {7, 8}", soBaoDanh, HoTen, diaChi, DiemToan, DiemLy, DiemHoa, DiemUuTien, tongDiem);
        }
    }
}
