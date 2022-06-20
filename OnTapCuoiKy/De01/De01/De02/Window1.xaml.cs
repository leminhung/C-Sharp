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
using De02.Models;

namespace De02
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        QuanLyBenhNhanDBContext ql = new QuanLyBenhNhanDBContext();
        public Window1()
        {
            InitializeComponent();

            var query = from bn in ql.BenhNhans
                        where bn.MaKhoa == 1
                        select bn;

            listBN.ItemsSource = query.ToList();
        }
    }
}
