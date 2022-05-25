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

namespace WPF_Demo_Control
{
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ButtonXem_Click(object sender, RoutedEventArgs e)
        {
            string strMessage, strHoTen, strTitle;

            strHoTen = txthodem.Text + " " + txtten.Text;

            if(radionam.IsChecked == true)
            {
                strTitle = "Mr. ";
            }
            else
            {
                strTitle = "Ms. ";
            }
            strMessage = "Xin chào: " + strTitle + " " + strHoTen;

            if(cboQueQuan.SelectedIndex >= 0)
            {
                strMessage += "\n Quê quán: " + cboQueQuan.Text;
            }
            MessageBox.Show(strMessage);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txthodem.Text = "";
            txtten.Text = "";
            radionam.IsChecked = false;
            radionu.IsChecked = false;
            cboQueQuan.SelectedIndex = 0;
        }
    }
}
