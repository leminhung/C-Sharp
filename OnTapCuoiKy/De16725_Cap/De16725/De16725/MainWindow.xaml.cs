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
using De16725.Models;

namespace De16725
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        QLBenhNhanContext ql = new QLBenhNhanContext();
        public MainWindow()
        {
            InitializeComponent();
            LoadItems();
            DataComboBox();
        }

        //Hiển thị dữ liệu vào bàng lần đầu
        private void LoadItems()
        {
            var query = from bn in ql.BenhNhans
                        where bn.SongayNv <= 20
                        orderby bn.SongayNv descending
                        select new
                        {
                            bn.Mabn,
                            bn.Hoten,
                            bn.Makhoa,
                            bn.Diachi,
                            bn.SongayNv,
                            VienPhi = bn.SongayNv * 60000
                        };
            dgDSBN.ItemsSource = query.ToList();                        
        }

        //Lấy dữ liệu khoa khám từ CSDL đổ vào ComboBox
        private void DataComboBox()
        {
            var query = from k in ql.KhoaKhams
                        select k.Tenkhoa;
            cbKhoaKham.ItemsSource = query.ToList();
            cbKhoaKham.SelectedIndex = 0;
        }

        //Hiển thị dữ liệu
        private void HienThi()
        {
            var query = from bn in ql.BenhNhans
                        select new
                        {
                            bn.Mabn,
                            bn.Hoten,
                            bn.Makhoa,
                            bn.Diachi,
                            bn.SongayNv,
                            VienPhi = bn.SongayNv * 60000
                        };
            dgDSBN.ItemsSource = query.ToList();
        }

        private bool checkNull()
        {
            if (string.IsNullOrEmpty(txtMaBN.Text) || string.IsNullOrEmpty(txtHoTen.Text) || string.IsNullOrEmpty(txtDiaChi.Text) || string.IsNullOrEmpty(txtSoNgayNV.Text))
                return false;
            else
                return true;
        }
        private void Clear()
        {
            txtMaBN.Clear();
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtSoNgayNV.Clear();
        }

        private void btThem_Click(object sender, RoutedEventArgs e)
        {
            var maBN = (from bn in ql.BenhNhans
                       where bn.Mabn == txtMaBN.Text
                       select bn).SingleOrDefault();
            try
            {
                if (!checkNull())
                    throw new Exception("Không được bỏ trống trường dữ liệu");
                int SoNgayNV = int.Parse(txtSoNgayNV.Text);
                if (SoNgayNV <= 0)
                    throw new Exception("Số ngày nằm viện phải là số nguyên và > 0");
                
                if (maBN != null)
                    throw new Exception("Mã bệnh nhân đã tồn tại");
                var maK = (from MaK in ql.KhoaKhams
                           where MaK.Tenkhoa == cbKhoaKham.Text
                           select MaK.Makhoa).Single();

                BenhNhan bn = new BenhNhan();
                bn.Mabn = txtMaBN.Text;
                bn.Hoten = txtHoTen.Text;
                bn.Diachi = txtDiaChi.Text;
                bn.SongayNv = SoNgayNV;
                bn.Makhoa = maK.ToString();
                ql.BenhNhans.Add(bn);
                ql.SaveChanges();
                HienThi();

                Clear();
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btSua_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var item = (from bn in ql.BenhNhans
                            where bn.Mabn == txtMaBN.Text
                            select bn).SingleOrDefault();
                if (item == null)
                    throw new Exception("Bạn chưa chọn bệnh nhân cần sửa");

                int SoNgayNV = int.Parse(txtSoNgayNV.Text);
                if (SoNgayNV <= 0)
                    throw new Exception("Số ngày nằm viện phải là số nguyên và > 0");

                var MaKhoaChon = (from MaK in ql.KhoaKhams
                                  where MaK.Tenkhoa == cbKhoaKham.Text
                                  select MaK.Makhoa).Single();
                item.Hoten = txtHoTen.Text;
                item.Diachi = txtDiaChi.Text;
                item.SongayNv = SoNgayNV;
                item.Makhoa = MaKhoaChon;
                ql.SaveChanges();
                HienThi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btXoa_Click(object sender, RoutedEventArgs e)
        {
            var kq = MessageBox.Show("Bạn có chắc chắn muốn xoá?", "", MessageBoxButton.YesNo);
            if (kq == MessageBoxResult.Yes)
            {
                var item = (from bn in ql.BenhNhans
                            where bn.Mabn == txtMaBN.Text
                            select bn).SingleOrDefault();

                if (item == null)
                {
                    MessageBox.Show("Bạn chưa chọn bệnh nhân cần xoá!");
                    Clear();
                }    
                else
                {
                    ql.BenhNhans.Remove(item);
                    ql.SaveChanges();
                    HienThi();
                    Clear();
                }    
            }    
        }

        private void btThongKe_Click(object sender, RoutedEventArgs e)
        {
            Window1 w = new Window1();
            w.ShowDialog();
        }

        private void dgDSBN_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = dgDSBN.SelectedItem;

            if (item != null)
            {
                string MaKhoaChon = (dgDSBN.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text;

                var TenK = (from k in ql.KhoaKhams
                            where k.Makhoa == MaKhoaChon
                            select k.Tenkhoa).Single();

                cbKhoaKham.SelectedItem = TenK.ToString();
            }    
        }
    }
}
