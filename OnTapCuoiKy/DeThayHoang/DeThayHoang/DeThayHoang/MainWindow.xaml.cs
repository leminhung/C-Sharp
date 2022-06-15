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
using System.Windows.Navigation;
using System.Windows.Shapes;
using DeThayHoang.models;

namespace DeThayHoang
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        QLBHContext qlbh = new QLBHContext();
        public MainWindow()
        {
            InitializeComponent();
            DataComboBox();
            LoadItem();
        }

        private void DataComboBox()
        {
            var query = from nh in qlbh.NhomHangs
                        select nh.TenNhomHang;
            cb_nhomhang.ItemsSource = query.ToList();
            cb_nhomhang.SelectedIndex = 0;
        }

        private void LoadItem()
        {
            var query = from nh in qlbh.NhomHangs
                        join sp in qlbh.SanPhams
                        on nh.MaNhomHang equals sp.MaNhomHang
                        orderby sp.SoLuongBan descending
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

        private void Clear()
        {
            txt_masp.Clear();
            txt_tensp.Clear();
            txt_dongia.Clear();
            txt_soluongban.Clear();
            cb_nhomhang.SelectedIndex = 0;
        }

        private void btnTim_ClickAction(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.ShowDialog();
        }

        private void btnThem_ClickAction(object sender, RoutedEventArgs e)
        {
            int number1, number2, number3;
            bool kTraDonGia = Int32.TryParse(txt_dongia.Text, out number1);
            bool kTraSoLuong = Int32.TryParse(txt_soluongban.Text, out number2);
            bool kTraMaSP = Int32.TryParse(txt_masp.Text, out number3);

            var check_sp = (from sp in qlbh.SanPhams
                            where sp.MaSp == Int32.Parse(txt_masp.Text)
                            select sp
                           ).SingleOrDefault();

            try
            {
                if (!kTraDonGia)
                    throw new Exception("Mã đơn giá không đúng dữ liệu");
                if (!kTraSoLuong)
                    throw new Exception("Số lượng bán không đúng dữ liệu");
                if (!kTraMaSP)
                    throw new Exception("Mã sản phẩm không đúng dữ liệu");

                if (check_sp != null)
                    throw new Exception("Mã SP đã tồn tại");

                var maNH = (from nh in qlbh.NhomHangs
                            where nh.TenNhomHang == cb_nhomhang.Text
                            select nh.MaNhomHang).Single();

                SanPham sp = new SanPham();
                sp.MaSp = Int32.Parse(txt_masp.Text);
                sp.TenSp = txt_tensp.Text;
                sp.DonGia = Int32.Parse(txt_dongia.Text);
                sp.SoLuongBan = Int32.Parse(txt_soluongban.Text);
                sp.MaNhomHang = Convert.ToInt32(maNH);
                qlbh.SanPhams.Add(sp);
                qlbh.SaveChanges();
                LoadItem();

                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
