   M S B A M L   `   `   `  ����B  >De16725, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:De16725De16725  5   	       De16725.Window1   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:De16725     5   	     � Title$  Thống kê��5   	   $	��450��6   $	��800��6'   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dsChiPhi��5
         AutoGenerateColumns$ False��6%      CanUserAddRows$ False��6A      
IsReadOnly$
 True��6X   $��Center=�6j   $	��120��6�   $��	0,123,0,0q�6�   $	��Top=�6�   $	��600��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã khoa��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 66   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6@   �� *MaKhoa+  5      $ 	Tên khoa��6%   $ * 67    6A   �� *	Tenkhoa+  5      $ Tổng chi phí��6%   $ * 6;    6E   �� *TongVienPhi+	   ElementStyle	 5      �� 5      
 �� 
TargetType"
 ��6    .�5      ��  �� Property � �� �� Value
 �  ��6;   �� 5       � ��$ Right=�6D   �� 5       � ��$
 Bold"�6;   �� 5       � ��$ Italic$�6:   5      5      5      �� 5   
   $��THỐNG KÊ CHI PHÍ��6   $
��Left=�6+   $��49��6F   $��
255,69,0,0q�6R   $	��Top=�6f   $	��242��6~   $
��Bold"�6�   $��24(�6�   5      5      