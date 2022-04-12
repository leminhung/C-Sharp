using System;
using System.Collections.Generic;
using System.Text;

namespace LeMinhHung_2019601690_proj63
{
    class Program
    {
        static private List<Course> courses = new List<Course>();

        static void ThemKhoaHoc()
        {
            Course course = new Course();
            course.InputStudent();
            courses.Add(course);
        }

        static void HienThiCacKhoaHoc()
        {
            if (courses.Count == 0)
            {
                Console.WriteLine("Danh sach courses trong".ToUpper());
            }

            Console.WriteLine("======hien thi danh sach khoa hoc======".ToUpper());
            foreach (Course c in courses)
            {
                c.DisplayCourseAndStudent();
            }
        }

        static void TimKiemKhoaHoc()
        {
            Console.Write("Nhap ma khoa hoc can tim CourseId = ");
            string CId = Console.ReadLine();

            Course course = courses.Find(e => e.CourseId == CId);

            if (course == null)
            {
                Console.WriteLine($"Không tìm được khoá học có mã {CId}".ToUpper());
                return;
            }
            else
            {
                Console.WriteLine("===Thông tin Khóa học===".ToUpper());
                course.DisplayCourseAndStudent();
            }
        }

        static void TimKiemSinhVien()
        {
            Console.Write("Nhap ma SV can tim SVId = ");
            int SVId = int.Parse(Console.ReadLine());

            Console.WriteLine("==thong tin sinh vien".ToUpper());
            Console.WriteLine("{0,-5} {1,8} {2, 8}", "ID", "Name", "Mark");
            foreach (Course c in courses)
            {
                Student s = c.GetAllStudents().Find(e => e.StudentId == SVId);
                
                if (s != null)
                {
                    s.Output();
                }
            }
        }

        static void XoaKhoaHoc()
        {
            Console.Write("Nhap ma khoa hoc can xoa courseid = ");
            string CourseId = Console.ReadLine();

            Course course = courses.Find(e => e.CourseId == CourseId);

            if (course == null)
            {
                Console.WriteLine($"Không tìm được khoá học có mã {CourseId}".ToUpper());
                return;
            }
            else
            {
                courses.Remove(course);
                Console.WriteLine("===Xóa Khóa học thành công===".ToUpper());
            }

        }


        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            int choose;

            do
            {
                Console.WriteLine("\n============================================================");
                Console.WriteLine("=====================QUẢN LÝ TRƯỜNG HỌC=====================");
                Console.WriteLine("============================================================");
                Console.WriteLine("=1. Thêm Một Khóa Học                                      =");
                Console.WriteLine("=2. Hiển Thị Các Khóa Học                                  =");
                Console.WriteLine("=3. Tìm Kiếm Khóa Học                                      =");
                Console.WriteLine("=4. Tìm Kiếm Sinh Viên                                     =");
                Console.WriteLine("=5. Xóa Một Khóa Học                                       =");
                Console.WriteLine("=6. Kết Thúc                                               =");
                Console.WriteLine("============================================================");
                Console.Write("Mời bạn nhập lựa chọn: ");
                choose = int.Parse(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        ThemKhoaHoc();
                        break;
                    case 2:
                        HienThiCacKhoaHoc();
                        break;
                    case 3:
                        TimKiemKhoaHoc();
                        break;
                    case 4:
                        TimKiemSinhVien();
                        break;
                    case 5:
                        XoaKhoaHoc();
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
