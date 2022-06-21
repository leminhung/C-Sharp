using System;
using System.Collections.Generic;

#nullable disable

namespace De16725_Again.Models
{
    public partial class BenhNhan
    {
        public string Mabn { get; set; }
        public string Hoten { get; set; }
        public string Diachi { get; set; }
        public int? SongayNv { get; set; }
        public string Makhoa { get; set; }

        public virtual KhoaKham MakhoaNavigation { get; set; }
    }
}
