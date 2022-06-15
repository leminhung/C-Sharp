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
using DeOn.Models;

namespace DeOn
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        QLBHContext ql = new QLBHContext();
        public MainWindow()
        {
            InitializeComponent();
            LoadItems();
            DataComboBox();
        }

        private void DataComboBox()
        {
            var query = from nh in ql.NhomHangs
                        select nh.TenNhomHang;
            cbNhomHang.ItemsSource = query.ToList();
            cbNhomHang.SelectedIndex = 0;
        }

        private void LoadItems()
        {
            var query = from sp in ql.SanPhams
                        join th in ql.NhomHangs
                        on sp.MaNhomHang equals th.MaNhomHang
                        orderby sp.SoLuongBan descending
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

        private void Clear()
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtDonGia.Clear();
            txtSoLuongBan.Clear();
            cbNhomHang.SelectedIndex = 0;
        }

        private void HienThi()
        {
            var query = from sp in ql.SanPhams
                        join th in ql.NhomHangs
                        on sp.MaNhomHang equals th.MaNhomHang
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

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            int number1;
            bool ktraDonGia = Int32.TryParse(txtDonGia.Text, out number1);
            int number2;
            bool ktraSoLuong = Int32.TryParse(txtSoLuongBan.Text, out number2);
            int number3;
            bool ktraMa = Int32.TryParse(txtMaSP.Text, out number3);

            var maSP = (from sp in ql.SanPhams
                        where sp.MaSp == int.Parse(txtMaSP.Text)
                        select sp).SingleOrDefault();
            try
            {
                if (!ktraDonGia)
                    throw new Exception("Đơn giá không đúng kiểu dữ liệu");
                if (!ktraSoLuong)
                    throw new Exception("Số lượng không đúng kiểu dữ liệu");
                if (!ktraMa)
                    throw new Exception("Mã SP không đúng kiểu dữ liệu");

                int soluong = int.Parse(txtSoLuongBan.Text);
                if (soluong < 1)
                    throw new Exception("Số lượng bán phải >= 1");

                if (maSP != null)
                    throw new Exception("Mã SP đã tồn tại");

                var maNH = (from mh in ql.NhomHangs
                            where mh.TenNhomHang == cbNhomHang.Text
                            select mh.MaNhomHang).Single();

                SanPham sp = new SanPham();
                sp.MaSp = int.Parse(txtMaSP.Text);
                sp.TenSanPham = txtTenSP.Text;
                sp.DonGia = int.Parse(txtDonGia.Text);
                sp.SoLuongBan = int.Parse(txtSoLuongBan.Text);
                sp.MaNhomHang = Convert.ToInt32(maNH);
                ql.SanPhams.Add(sp);
                ql.SaveChanges();
                HienThi();

                Clear();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTim_Click(object sender, RoutedEventArgs e)
        {
            Window1 w = new Window1();
            w.ShowDialog();
        }

        private void dgDSSP_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = dgDSSP.SelectedItem;

            if (item != null)
            {
                string tenNH = (dgDSSP.SelectedCells[4].Column.GetCellContent(item) as TextBlock).Text;

                cbNhomHang.SelectedItem = tenNH;
            }    
        }
    }
}
