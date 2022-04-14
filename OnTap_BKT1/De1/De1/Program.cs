using System;
using System.Collections.Generic;
using System.Text;

namespace De1
{
    class Program
    {
        static private List<SinhVien> sinhviens = new List<SinhVien>();



        static bool checkMSV(string maSV)
        {
            SinhVien sv = sinhviens.Find(s => s.MSV == maSV);
            if (sv != null) return false;
            return true;
        }

        static void NhapSinhVien()
        {
            SinhVien sv = new SinhVien();
            bool check;
            do
            {
                check = true;
                Console.Write("Nhap MSV: ");
                sv.MSV = Console.ReadLine();

                check = checkMSV(sv.MSV);
                if (!check)
                {
                    Console.WriteLine("Ma SV da ton tai, moi nhap lai :((");
                }
            } while (!check);
            

            sv.nhap();
            sinhviens.Add(sv);
        }

        static void HienThiDS()
        {
            if (sinhviens.Count == 0)
            {
                Console.WriteLine("Danh sach trong".ToUpper());
                return;
            }

            Console.WriteLine("========hien thi ds sinh vien==========".ToUpper());

            Console.WriteLine("{0,-5} {1,-16} {2, 10} {3, 10} {4, 10}", "MSV", "Ho Ten", "Dien thoai", "Diem", "Xep Loai");
            foreach (SinhVien sv in sinhviens)
            {
                Console.WriteLine("{0,-5} {1,-16} {2, 10} {3, 10} {4, 10}", sv.MSV, sv.HoTen, sv.Sdt, sv.Diem, sv.XepLoai);
            }
        }

        static void XoaSinhVien()
        {
            Console.Write("Nhap MSV can xoa: ");
            string msv = Console.ReadLine();

            SinhVien sv = sinhviens.Find(s => s.MSV == msv);

            if (sv == null)
            {
                Console.WriteLine($"Khong co sinh vien nao co ma {msv}".ToUpper());
                return;
            }

            int luachon;
            Console.WriteLine("1. Chac chan xoa,  2.Huy khong xoa nua");
            Console.Write("Nhap lua chon cua ban: ");
            luachon = int.Parse(Console.ReadLine());
            if(luachon == 1)
            {
                sinhviens.Remove(sv);
                Console.WriteLine("===Xoa thanh cong===".ToUpper());
            }
            else
            {
                Console.WriteLine("====Huy xoa thanh cong====".ToUpper());
            }
        }

        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            int choose;
            do
            {
                Console.WriteLine("============================================================");
                Console.WriteLine("===================Lê Minh Hưng, 2019601690=================");
                Console.WriteLine("============================================================");
                Console.WriteLine("=1. Thêm Sinh Viên                                         =");
                Console.WriteLine("=2. Hiển Thị Danh Sách Sinh Viên                           =");
                Console.WriteLine("=3. Xóa sinh viên                                          =");
                Console.WriteLine("=4. Kết Thúc Chương Trình                                  =");
                Console.WriteLine("============================================================");
                Console.Write("Mời bạn nhập lựa chọn: ");
                choose = int.Parse(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        NhapSinhVien();
                        break;
                    case 2:
                        HienThiDS();
                        break;
                    case 3:
                        XoaSinhVien();
                        break;
                    case 4:
                        Console.WriteLine("=======Thoat chuong trinh=======".ToUpper());
                        break;
                    default:
                        Console.WriteLine("Ban da nhap sai, moi nhap lai :((");
                        break;
                }

            } while (choose != 4);
        }
    }
}
