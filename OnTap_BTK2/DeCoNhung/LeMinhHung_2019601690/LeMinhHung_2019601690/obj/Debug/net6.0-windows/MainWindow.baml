   M S B A M L   `   `   `  ����P  LLeMinhHung_2019601690, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:LeMinhHung_2019601690LeMinhHung_2019601690  5   	   &     LeMinhHung_2019601690.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:LeMinhHung_2019601690     5   	     � Title$  LeMinhHung_2019601690��5   	   $	��450��6'   $	��800��64   .��5	      � .+�5
   
   �� $
��Left=�6   $��36��6/   $��
264,24,0,0q�6;   $
��Wrap=�6O   $��Quản lý nhân viên��6c   $	��Top=�6|   $	��208��6�   $��24(�6�   $
��Bold"�6�   �� 5   
   $
��Left=�6   $��26��6/   $��
114,82,0,0q�6;   $
��Wrap=�6O   $ ��Họ và tên nhân viên:��6c   $	��Top=�6   $	��111��6�   �� 5   
   -   5         ��Name$ 	txt_hoten��5      $
��Left=�6%   $��26��6@   $��
264,82,0,0q�6L    �� TextWrapping$
 Wrap=�6`   $	��Top=�6t   $	��277��6�   �� 5   
   $
��Left=�6   $��26��6/   $��114,217,0,0q�6;   $
��Wrap=�6P   $��Số tiền bán hàng��6d   $	��Top=�6|   $	��111��6�   �� 5   
   -   5        $ txt_tienbanhang��5      $
��Left=�6+   $��26��6F   $��264,217,0,0q�6R   $
 Wrap=�6g   $	��Top=�6{   $	��277��6�   �� 5   
   $
��Left=�6   $��26��6/   $��114,123,0,0q�6;   $
��Wrap=�6P   $��Loại nhân viên:��6d   $	��Top=�6{   $	��111��6�   �� 5   
   $
��Left=�6   $��26��6/   $��114,163,0,0q�6;   $
��Wrap=�6P   $��Ngày sinh:��6d   $	��Top=�6v   $	��111��6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ 
datepicker��5      $
��Left=�6)   $��26��6D   $��264,163,0,0q�6P   $	��Top=�6e   $	��185��6}   �� 5   
   -   5         ��Name$ 
opt_loainv��5      $
��Left=�6'   $��26��6B   $��264,123,0,0q�6N   $	��Top=�6c   $	��185��6{    �� SelectedIndex$ 0��6�   .@�5      �� .��6   	Cơ Hữu6#   �� 5      .��6   Hợp đồng6%   �� 5      .��6   Cộng tác viên6*   5      �� 5   
   -   5         ��Name$ list_nv��5      $
��Left=�6#   $	��110��6>   $��114,262,0,0q�6K   $	��Top=�6`   $	��582��6x   5      �� 5   
   -   5         ��Name$ 	btn_nhapp��5      $��Nhập��6$   $
��Left=�63   $��27��6N   $��234,390,0,0q�6Z   $	��Top=�6o   $��71��6�   6�   �� 5   
   -   5        $ btn_xoaa��5      $
��Xóa��6#   $
��Left=�61   $��27��6L   $��334,390,0,0q�6X   $	��Top=�6m   $��71��6�   6�   �� 5   
   -   5        $ btn_chitiett��5      $��Window2��6'   $
��Left=�69   $��27��6T   $��436,390,0,0q�6`   $	��Top=�6u   $��71��6�   6�   5      5      