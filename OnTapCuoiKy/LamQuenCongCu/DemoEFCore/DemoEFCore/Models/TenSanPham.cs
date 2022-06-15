using System;
using System.Collections.Generic;

namespace DemoEFCore.Models
{
    public partial class TenSanPham
    {
        public string MaSp { get; set; } = null!;
        public string? TenSp { get; set; }
        public int? SoLuong { get; set; }
        public double? DonGia { get; set; }
        public string? MaLoai { get; set; }

        public virtual LoaiSanPham? MaLoaiNavigation { get; set; }
    }
}
