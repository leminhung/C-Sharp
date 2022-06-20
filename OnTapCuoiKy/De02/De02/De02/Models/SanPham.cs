using System;
using System.Collections.Generic;

namespace De02.Models
{
    public partial class SanPham
    {
        public int MaSp { get; set; }
        public string? TenSanPham { get; set; }
        public double? DonGia { get; set; }
        public double? SoLuongBan { get; set; }
        public double? TienBan { get; set; }
        public int? MaNhomHang { get; set; }

        public virtual NhomHang? MaNhomHangNavigation { get; set; }
    }
}
