using System;
using System.Collections.Generic;
using System.Text;

namespace Bai6_TruocKhiLenLop
{
    class Program
    {

        static private List<Student> listSV = new List<Student>();

        static void ThemMotSinhVien()
        {
            Student student = new Student();
            student.Input();
            listSV.Add(student);
        }

        static void HienThiDSSinhVien()
        {
            if(listSV.Count == 0)
            {
                Console.WriteLine("Danh sach trong".ToUpper());
                return;
            }
            Console.WriteLine("========hien thi ds sinh vien==========".ToUpper());

            Console.WriteLine("{0,-5} {1,-16} {2, 10} {3, 10} {4, 10} {5, 10}", "ID", "Ho Ten", "Dia Chi", "Toan", "Ly", "TongDiem");
            foreach (Student sv in listSV)
            {
                sv.Output();
            }
        }

        static void TimKiemSVById()
        {
            if (listSV.Count == 0)
            {
                Console.WriteLine("Danh sach trong, khong the tim kiem :((".ToUpper());
                return;
            }

            Console.Write("==Nhap ID SV can tim ID = ");
            int ID = int.Parse(Console.ReadLine());

            Console.WriteLine("{0,-5} {1,-16} {2, 10} {3, 10} {4, 10} {5, 10}", "ID", "Ho Ten", "Dia Chi", "Toan", "Ly", "TongDiem");
            foreach (Student sv in listSV)
            {
                if(sv.Id == ID)
                {
                    sv.Output();
                }
            }
        }

        static void TimKiemSVByDiaChi()
        {
            if (listSV.Count == 0)
            {
                Console.WriteLine("Danh sach trong, khong the tim kiem :((".ToUpper());
                return;
            }

            Console.Write("==Nhap Dia Chi SV can tim Address = ");
            string dc = Console.ReadLine();

            Console.WriteLine("{0,-5} {1,-16} {2, 10} {3, 10} {4, 10} {5, 10}", "ID", "Ho Ten", "Dia Chi", "Toan", "Ly", "TongDiem");
            foreach (Student sv in listSV)
            {
                if (sv.DiaChi.ToUpper().Contains(dc.ToUpper()))
                {
                    sv.Output();
                }
            }
        }
        static void XoaSVById()
        {
            if (listSV.Count == 0)
            {
                Console.WriteLine("Danh sach trong, khong the tim kiem :((".ToUpper());
                return;
            }

            Console.Write("==Nhap ID SV can xoa ID = ");
            int ID = int.Parse(Console.ReadLine());

            Console.WriteLine("{0,-5} {1,-16} {2, 10} {3, 10} {4, 10} {5, 10}", "ID", "Ho Ten", "Dia Chi", "Toan", "Ly", "TongDiem");
            Student student = listSV.Find(e => e.Id == ID);

            if(student == null)
            {
                Console.WriteLine($"Khong tim thay SV voi ma ID = {ID} de xoa");
                return;
            }

            listSV.Remove(student);
            Console.WriteLine("=====Xoa thanh cong=====".ToUpper());
        }



        static void Main(string[] args)
        {

            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            int choose;
            do
            {
                Console.WriteLine("============================================================");
                Console.WriteLine("===================QUẢN LÝ SINH VIÊN========================");
                Console.WriteLine("============================================================");
                Console.WriteLine("=1. Thêm Sinh Viên                                         =");
                Console.WriteLine("=2. Hiển Thị Danh Sách Sinh Viên                           =");
                Console.WriteLine("=3. Tìm Kiếm Sinh Viên Theo ID                             =");
                Console.WriteLine("=4. Tìm Kiếm Sinh Viên Theo Address                        =");
                Console.WriteLine("=5. Xóa Một Sinh Viên Theo ID                              =");
                Console.WriteLine("=6. Kết Thúc Chương Trình                                  =");
                Console.WriteLine("============================================================");
                Console.Write("Mời bạn nhập lựa chọn: ");
                choose = int.Parse(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        ThemMotSinhVien();
                        break;
                    case 2:
                        HienThiDSSinhVien();
                        break;
                    case 3:
                        TimKiemSVById();
                        break;
                    case 4:
                        TimKiemSVByDiaChi();
                        break;
                    case 5:
                        XoaSVById();
                        break;
                    case 6:
                        Console.WriteLine("=======Thoat chuong trinh=======".ToUpper());
                        break;
                    default:
                        Console.WriteLine("Ban da nhap sai, moi nhap lai :((");
                        break;
                }

            } while (choose != 6);
        }
    }
}
