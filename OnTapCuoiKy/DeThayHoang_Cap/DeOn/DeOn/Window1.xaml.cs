using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using DeOn.Models;

namespace DeOn
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        QLBHContext ql = new QLBHContext();
        public Window1()
        {
            InitializeComponent();
            TimKiem();
        }

        private void TimKiem()
        {
            var query = from sp in ql.SanPhams                        
                        join th in ql.NhomHangs
                        on sp.MaNhomHang equals th.MaNhomHang
                        where sp.MaNhomHang == 1
                        select new
                        {
                            sp.MaSp,
                            sp.TenSanPham,
                            sp.DonGia,
                            sp.SoLuongBan,
                            th.TenNhomHang,
                            Tienban = sp.DonGia * sp.SoLuongBan
                        };
            dgDSSP.ItemsSource = query.ToList();
        }
    }
}
