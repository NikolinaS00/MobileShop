   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	   -clr-namespace:WpfApp1.ModelWpfApp1.Model  5   	       WpfApp1.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   1	viewModelclr-namespace:WpfApp1.Model     5   	     � Title$  
MobileShop��5	   	   $	��750��6   $
��1200��6)    � WindowStartupLocation$ CenterScreen=�66    � DataContext 5      !  WpfApp1.Model.MainViewModel  5   
   .��5      �    
MainWindow#��[  6    � ColumnDefinitions 5   
   �� 5      $��2* �6   5      �� 5      $��6* �6   6,   .+�5   
   � $��0��6    � RowDefinitions 5      �� 5      $��1* �6    6.   �� 5      $��8* �6    6.   .+�5!      �� -   5         ��Name$ BorderL��5!   "   $��1��6     
BorderLeft#��[ 63    �� CornerRadius$ 0 200 0 180��6W   ._�5#      �  5$      �� 5%      �� 5&       5(      �� 5)      $��2* �6(   66   �� 5*      $��4* �6(   66   �� 5+      $��1* �6(   66   .+�5.      �� $��2��6!   $��	0,186,0,0q�65   $��2��6H   .+�50      ��   ButtonsInTheMenu#��[ 6!   $��50��6M   ��6Y   �� *HomeRelayCommand+.��51      ��  �� Orientation$ 
Horizontal=�6)   .+�53   "   ��   LabelDesign#��[ 6(     
HomeButton#��[ 6M   54      55      �� 56      #��[ 6!   $��50��6K   ��6W   �� *ArticlesRelayCommand+.��57      �� $ 
Horizontal=�6)   .+�59   "   �� #��[ 6(     ArticlesButton#��[ 6M   5:      5;      �� 5<      #��[ 6!   $��50��6K   ��6W   �� *EmployeesRelayCommand+.��5=      �� $ 
Horizontal=�6)   .+�5?   "   �� #��[ 6(     EmployeesButton#��[ 6M   5@      5A      �� 5B      #��[ 6!     SuppliersButton#��[ 6K   $��50��6v   ��6�   �� *SuppliersRelayCommand+�� 5C      #��[ 6!     ProcurementButton#��[ 6K   $��50��6x   ��6�   �� *ProcurementRelayCommand+�� 5D      #��[ 6!    	 
SaleButton#��[	 6K   $��50��6q   ��6}   �� *SaleRelayCommand+�� 5E      #��[ 6!   $��50��6K   .��5F      �� $ 
Horizontal=�6)   .+�5G   "   �� $��/settings.png��6(   $��30��6?   $��30��6J   �� 5H   "   #��[ 6(    
 SettingsButton#��[
 6M   5I      5J      5K      ]� 5O      $��0��6    $��70 -150 0 0 q�60   $��2��6F   .+�5P      �� $	��100��6!   $	��100��6-    �� Padding$ 3q�6:     CirclePanel#��[ 6G   $	 100��6m   $	��Top=�6�   $
��Left=�6�   $��
20 -30 0 0q�6�   	 J� RenderTransformOrigin$	 0.5,0.5&�6�   z�5Q      V� 5R   "   .~�5S   &   �� �� 5T   &   �� 5U   &   
 �� Angle$
 16.369Q�66   T� 5V   &   5W   #   ._�5Y      A� ��5Z   "   �� 5[   &    �� ImageSource$ /google_mobile_512px.png��61   5]      5^      5_      �� 5`      $��Mobile Shop��6    $��0��63   $��
70 70 0 0 q�6C     	mainTitle#��[ 6W   $��2��6z   5a      5b      5e      � 5f   
   $��1��6   .+�5g      �� ��6   �� *CurrentView+5h      5l      5m      