   M S B A M L   `   `   `  ����E  ADemoEFCore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:DemoEFCore
DemoEFCore  5   	       DemoEFCore.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:DemoEFCore     5   	   -   5          � Title$$  Quản lý loại sản phẩm��5	   	   $	��550��6'   $	��800��64   .��5
      � .+�5   
   �� -   5         ��Name$ txt_maloaisp��5      $
��Left=�6(   $��38��6C   $��
253,46,0,0q�6O    �� TextWrapping$
 Wrap=�6c   $	��Top=�6w   $	��334��6�   6�   �� 5   
   $
��Left=�6   $��38��6/   $��	98,51,0,0q�6;   $
��Wrap=�6N   $��Mã loại sản phẩm:��6b   $	��Top=�6{   $	��151��6�   $��16(�6�   $
��Bold"�6�   �� 5   
   -   5        $ txt_tenloaisp��5      $
��Left=�6)   $��38��6D   $��253,105,0,0q�6P   $
 Wrap=�6e   $	��Top=�6y   $	��334��6�   6�   �� 5   
   $
��Left=�6   $��38��6/   $��
98,110,0,0q�6;   $
��Wrap=�6O   $��Tên loại sản phẩm:��6c   $	��Top=�6}   $	��151��6�   $��16(�6�   $
��Bold"�6�   � 5   
   $
��Left=�6   $	��216��6*   $��
98,230,0,0q�67   $	��Top=�6K   $	��489��6c   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ dgvLoaiSanPham��5         
IsReadOnly$
 True��6/      CanUserAddRows$ False��6A      AlternatingRowBackground
 ��ح�   AutoGenerateColumns$ False��6}      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 
Mã Loại��6)   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6:   �� *MaLoai+  5      $	 Tên Loại��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6W   
 6;   �� *	TenLoai+6W   5      5      5      5      