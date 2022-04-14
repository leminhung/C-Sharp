using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeCa1
{
    class ThiSinh
    {
        protected string sbd;
        private string hoTen;
        private float diemToan;
        private float diemLy;
        private float diemHoa;


        public string SBD { get => sbd; set => sbd = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public float DiemToan { get => diemToan; set => diemToan = value; }
        public float DiemLy { get => diemLy; set => diemLy = value; }
        public float DiemHoa { get => diemHoa; set => diemHoa = value; }

        public ThiSinh()
        {
        }

        public ThiSinh(string sbd, string hoTen, float diemToan, float diemLy, float diemHoa)
        {
            this.sbd = sbd;
            this.HoTen = hoTen;
            this.DiemToan = diemToan;
            this.DiemLy = diemLy;
            this.DiemHoa = diemHoa;
        }

        public virtual float TongDiem()
        {
            return diemToan + diemLy + diemHoa;
        }

        public string XetTuyen(float diemsan)
        {
            if (TongDiem() >= diemsan) return "Thi đỗ";
            return "Thi trượt";
        }
       
    }
}
