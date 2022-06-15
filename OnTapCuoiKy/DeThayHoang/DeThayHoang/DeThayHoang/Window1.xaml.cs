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
using DeThayHoang.models;

namespace DeThayHoang
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        QLBHContext qlbh = new QLBHContext();
        public Window1()
        {
            InitializeComponent();
            TimKiem();
        }

        private void TimKiem()
        {
            var query = from nh in qlbh.NhomHangs
                        join sp in qlbh.SanPhams
                        on nh.MaNhomHang equals sp.MaNhomHang
                        where sp.MaSp == 1
                        select new
                        {
                            sp.MaSp,
                            sp.TenSp,
                            sp.DonGia,
                            sp.SoLuongBan,
                            nh.TenNhomHang,
                            TienBan = sp.DonGia * sp.SoLuongBan
                        };
            listDSSP.ItemsSource = query.ToList();
        }
    }
}
