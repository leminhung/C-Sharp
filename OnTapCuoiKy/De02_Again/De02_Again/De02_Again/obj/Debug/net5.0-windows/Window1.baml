   M S B A M L   `   `   `  ����E  ADe02_Again, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:De02_Again
De02_Again  5   	       De02_Again.Window1   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:De02_Again     5   	     � Title$  Window1��5   	   $	��450��6   $	��800��6&    � 	Resources 5	         Template_btn �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value��%  &	        '  �     �� 5
   
   " ��6/   .R�5      � .+�5      A� 
���2͚�6   �� 5      $��Center=�6#   $��Center=�6@   5      5      �� 5   
   "  6   .�5      ��  � ��$
 Bold"�6+   �� 5       � ��$ Center=�6;   5      5      .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ listSP��5   A      
IsReadOnly$
 True��6      AutoGenerateColumns$ False��6%   $��Center=�6Q   $	��136��6n   $��Center=�6{   $	��604��6�   	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Mã SP��6>      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6M   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *MaSp+6M     5      $
 Tên sản phẩm��6D   $ * 6Z    6%   �� *
TenSanPham+6Z     5      $
 
Đơn giá��6@   $ * 6Q    6%   �� *DonGia+6Q     5      $
 Số lượng bán��6D   $ * 6Z    6%   �� *
SoLuongBan+6Z     5      $
 Nhóm hàng��6D   $ * 6W    6%   �� *
MaNhomHang+6W     5      $
 Tiền bán��6A   $ * 6S    6%   �� *	TienBan+6S   5      5       5!      