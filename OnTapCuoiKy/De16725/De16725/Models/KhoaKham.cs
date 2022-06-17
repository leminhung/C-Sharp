using System;
using System.Collections.Generic;

namespace De16725.Models
{
    public partial class KhoaKham
    {
        public KhoaKham()
        {
            BenhNhans = new HashSet<BenhNhan>();
        }

        public string Makhoa { get; set; } = null!;
        public string? Tenkhoa { get; set; }

        public virtual ICollection<BenhNhan> BenhNhans { get; set; }
    }
}
