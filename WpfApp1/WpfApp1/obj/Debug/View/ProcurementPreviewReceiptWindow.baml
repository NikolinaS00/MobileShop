   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WpfApp1.ViewWpfApp1.View  5   	   -clr-namespace:WpfApp1.ModelWpfApp1.Model  5      2    ,WpfApp1.View.ProcurementPreviewReceiptWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:WpfApp1.View     5   	   1	viewModelclr-namespace:WpfApp1.Model     5        � Title$  
MobileShop��5	   
   $	��700��6   $	��700��6+    � 
ResizeMode$ NoResize=�67    � Icon$) #/WpfApp1;component/Assets/phone.png��6M    � DataContext 5
      (  "WpfApp1.Model.ProcurementViewModel  5   
   .��5      �    
MainWindow#���   6    � RowDefinitions 5   
   �� 5      $��1* �6   6*   �� 5      $��2* �6   6*   �� 5      $��1* �6   6*   �� 5      $��9* �6   6*    � ColumnDefinitions 5   
   �� 5      $��1* �6   6,   �� 5      $	��15* �6   6-   �� 5      $��1* �6   6,   .+�5   
   �� -   5         ��Name$ 	BorderTop��5   .   $��1��6   $��1��6!     
BorderLeft#��[ 6A    �� CornerRadius$ 0 200 0 180��6e   ._�5      �  5       �� 5!      $��1* �6'   64   �� 5"      $��3* �6'   64   �� 5#      $��1* �6'   64   .+�5'      �� -   5         ��Name$ NameOfWindow��5'   (   $��1��6     
FontFamily#���  6>     FontSize#���  6h     
WindowName#���  6�    ! WindowNameLabelPreviewReceipt#���  6�   5)      5*      5+      � 5,   
   $��2��6   $��1��6    5-      �� 5.      $��1* �6#   60   �� 5/      $��1* �6#   60   �� 50      $��1* �6#   60    52      �� 53      $��1* �6    6.   �� 54      $	��10* �6    6/   �� 55      $��1* �6    6.   .+�57      �� -   5        	 ��Name$	 DeleteItemButton��57      $��2��6/   $��1��6?     
BackButton#���  6L     DeleteButtonContent1#���  6q   #���  6�   #���  6�   6  58      � 59   
   $��3��6   $��1��6    5:      �� 5;      $	��10* �6    6/   �� 5<      $��1* �6    6.   �� 5=      $��1* �6    6.   �� 5>      $��1* �6    6.   .+�5@      � $��2��6    5A      �� 5B      $��1* �6'   64   �� 5C      $��1* �6'   64   �� 5D      $��1* �6'   64   .+�5F      �� -   5        $	 PrintReceiptButton��5F      $��2��65     PrintReceiptButtonContent#���  6E   #���  6{   #���  6�    	 applyButton#��� 	 6�   6  5G      &   System.Windows.Controls.DataGrid  5I      -   5        
  Name$
 DataGridItems��5I      $��0��6.      CanUserResizeRows .    CanUserAddRows .     RowHeaderWidth$ 0Q�6�    
 
TableColor#��� 
 6�      AutoGenerateColumns .     CanUserResizeColumns .     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ 0.25* 64    gridCellHeader   ColumnHeaderStyle# �  6H  ��6<   �� *Items+ �� SelectedItem 6Z   ��  �� Path$ SelectedItem� �� Mode$ TwoWay=�   Columns 5J      0  *System.Windows.Controls.DataGridTextColumn  5K      ,  &System.Windows.Controls.DataGridColumn   
IsReadOnly .   HeaderContentIdArticle   Header# �  6;      HeaderStyle# �  6�     gridCell   	CellStyle# �  6�      Width$
 0.2* 6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6m   �� *	ArticleId+6�     5L       .   HeaderContentNameArticle# �  6;   # �  6�   # �  6�   $
 0.3* 6�    6o   �� *ArticleName+   ElementStyle 5M      �� 5N       �� 
TargetType" ��6$   .�5O   "   ��  �� Property � �� �� Value$
 Wrap=�6A   5P      5R        5S       .   HeaderContentAmount# �  6;   # �  6�   # �  6�   $
 0.1* 6�    6j   �� *Amount+6�     5T       .   HeaderContentArticlePrice# �  6;   # �  6�   # �  6�   $
 0.2* 6�    6p   �� *ArticlePrice+6�     5U       .   HeaderContentTotalPrice# �  6;   # �  6�   # �  6�   $
 0.2* 6�    6n   �� *
TotalPrice+6�   5W      5X      5Z      5[      