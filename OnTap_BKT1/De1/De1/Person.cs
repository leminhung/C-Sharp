using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De1
{
    class Person
    {
        private string hoTen;
        private string sdt;


        public string HoTen { get => hoTen; }
        public string Sdt { get => hoTen; }

        public virtual void nhap()
        {
            Console.Write("Nhap HoTen: ");
            hoTen = Console.ReadLine();
            Console.Write("Nhap SDT: ");
            sdt = Console.ReadLine();
        }
    }
}
