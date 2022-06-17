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
using De16725.Models;

namespace De16725
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        QLBenhNhanContext qlbn = new QLBenhNhanContext();
        public Window1()
        {
            InitializeComponent();
            var query = from bn in qlbn.BenhNhans
                        join kh in qlbn.KhoaKhams
                        on bn.Makhoa equals kh.Makhoa
                        group bn.SongayNv * 60000 by bn.Makhoa into gr
                        select new
                        {
                            MaKhoa = gr.Key,
                            TongVienPhi = gr.Sum()
                        };
            var query2 = from result1 in query
                         join kh in qlbn.KhoaKhams
                         on result1.MaKhoa equals kh.Makhoa
                         select new
                         {
                             result1.MaKhoa,
                             kh.Tenkhoa,
                             result1.TongVienPhi
                         };

            dsChiPhi.ItemsSource = query2.ToList();
        }
    }
}
