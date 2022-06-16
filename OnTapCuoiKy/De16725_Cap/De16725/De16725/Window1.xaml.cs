﻿using System;
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
        QLBenhNhanContext ql = new QLBenhNhanContext();
        public Window1()
        {
            InitializeComponent();

            var query = from k in ql.KhoaKhams
                        join bn in ql.BenhNhans
                        on k.Makhoa equals bn.Makhoa
                        group bn.SongayNv * 60000 by k.Makhoa into gr
                        select
                        new
                        {
                            MaKhoa = gr.Key,
                            TongVienPhi = gr.Sum()
                        };
            var query2 = from e in query
                         join k in ql.KhoaKhams
                         on e.MaKhoa equals k.Makhoa
                         select new
                         {
                             k.Makhoa,
                             k.Tenkhoa,
                             e.TongVienPhi
                         };
            dgList.ItemsSource = query2.ToList();
        }
    }
}
