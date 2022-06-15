using System;
using System.Collections.Generic;

namespace DeThayHoang.models
{
    public partial class NhomHang
    {
        public NhomHang()
        {
            SanPhams = new HashSet<SanPham>();
        }

        public int MaNhomHang { get; set; }
        public string? TenNhomHang { get; set; }

        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
