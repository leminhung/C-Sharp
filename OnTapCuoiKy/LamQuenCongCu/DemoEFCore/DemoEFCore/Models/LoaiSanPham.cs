using System;
using System.Collections.Generic;

namespace DemoEFCore.Models
{
    public partial class LoaiSanPham
    {
        public LoaiSanPham()
        {
            TenSanPhams = new HashSet<TenSanPham>();
        }

        public string MaLoai { get; set; } = null!;
        public string? TenLoai { get; set; }

        public virtual ICollection<TenSanPham> TenSanPhams { get; set; }
    }
}
