using System;
using System.Collections.Generic;

namespace DeOn.Models
{
    public partial class SanPham
    {
        public int MaSp { get; set; }
        public string? TenSanPham { get; set; }
        public int? DonGia { get; set; }
        public int? SoLuongBan { get; set; }
        public int MaNhomHang { get; set; }

        public virtual NhomHang MaNhomHangNavigation { get; set; } = null!;
    }
}
