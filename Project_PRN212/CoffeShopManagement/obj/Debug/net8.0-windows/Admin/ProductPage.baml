   M S B A M L   `   `   `  ����N  JCoffeShopManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:CoffeShopManagement.AdminCoffeShopManagement.Admin  5      +    %CoffeShopManagement.Admin.ProductPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:CoffeShopManagement.Admin     5        N� Title$  ProductPage��5	       N� 
Background
 ����� � 	Resources 5
         ActionButtonStyle �� 
TargetType �� Property �� Value  InputLabelStyle&   System.Windows.Controls.DataGrid=  7System.Windows.Controls.Primitives.DataGridColumnHeader��%�  &	        &	 �    '  A    '  �    �� 5   
   " ��6*   .�5      ��  � ��$ 5,0,0,0q�6'   �� 5       � ��$ 5q�6(   �� 5       � �� �#9B44446+   �� 5       � ��
 �����6+   �� 5       � ��$
 Bold"�6+   �� 5       � �� �#9B44446,   �� 5       � ��$	 100��6&   �� 5       � ��$ 30��6'   �� 5       �@�Cursor$
 Hand��6'   5      �� 5   
   " ��6(   .�5      ��  � ��$ 14(�6)   �� 5       � ��$ Center=�62   �� 5       � ��$
 Left=�64   �� 5       � ��$	 120��6&   5      �� 5   
   "  6   .�5      ��  � ��$ 14(�6)   �� 5        �@ 	RowHeight$ 30Q�6*   �� 5!       �@ GridLinesVisibility$ 
Horizontal=�64   5"      �� 5#   
   "  6   .�5$      ��  � �� �#9B44446+   �� 5%       � ��
 �����6+   �� 5&       � ��$
 Bold"�6+   �� 5'       � ��$ 10q�6(   5(      5)      .��5*      � $	��523��6   $	��Top=�6    � RowDefinitions 5+   
   �� 5,      $
��Auto �6   �� 5-      $��* �6   .+�50   
   �� $��0��6   $��10q�6%   .+�52      ��  �� Orientation$ 
Horizontal=�6   $��5q�62   .+�53      �� $��Food ID:��6   #��[ 6+   �� 54      -   5         ��Name$ ProductIDTextBox��54   &   $	��200��6   	 �� 
IsReadOnly$
	 True��6@   ${�False��6R   55      �� 57      $ 
Horizontal=�6   $��5q�62   .+�58      �� $��
Food Name:��6   #��[ 6-   �� 59      -   5        $ ProductNameTextBox��59   &   $	��200��6   6&   5:      �� 5=      $ 
Horizontal=�6   $��5q�62   .+�5>      �� $��Image:��6   #��[ 6)   �� 5?      -   5        $��Image��5?      $��50��6I   $��30��6T   �� 5@      -   5        
 ��Name$
 	FoodImage��5@      $	��100��6+   $	��125��68   $��10,0,0,0q�6D   5A      �� 5D      $ 
Horizontal=�6   $��5q�62   .+�5E      �� $��	Category:��6   #��[ 6,   �� 5F      -   5         ��Name$ CategoryComboBox��5F   '   $	��200��6   .@�5G      �� $��Beverage��6#   �� 5H      $
��Food��6#   5I      5J      �� 5M      $ 
Horizontal=�6   $��5q�62   .+�5N      �� $��Price:��6   #��[ 6)   �� 5O      -   5        $ PriceTextBox��5O   &   $	��200��6   6&   5P      �� 5S      $ 
Horizontal=�6   $��5q�62   .+�5T      �� -   5        $	��Add��5T      #��[  6'   6R   �� 5U      -   5        $��Update��5U      #��[  6*   6U   �� 5V      -	   5        $��Delete��5V      #��[  6*   6U   5W      5X      �� 5[   
   $ 
Horizontal=�6   $��Right=�6.   $��54��6J   $	��Top=�6V    J� RenderTransformOrigin$ 2.071,0.537&�6n   $��0,0,10,0q�6�   $	��300��6�   .+�5\      �� -
   5        $ SearchTextBox��5\   .   $	��200��6   $��30��6"   $��0,0,5,0q�6E   �� 5]      -   5        $��Search��5]      #��[  6&   6Q   5^        5a   
   -   5          Name$ FoodDataGrid��5a         AutoGenerateColumns$ False��6)   $��10,320,10,0q�6E      
IsReadOnly$
 True��6Z   $��2��6�      Columns 5b      0  *System.Windows.Controls.DataGridTextColumn  5c      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Product ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6P   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   �� *Id+6P     5d      $ Product Name��6%   $	 220 6T    6;   �� *Name+6T     5e      $ Image��6%   $	 250 6R    64   �� *	ImageLink+6R     5f      $ Category��6%   $	 100 6V    67   �� *
IdCategory+6V     5g      $ Price��6%   $	 100 6N    64   �� *Price+6N   5i      5j      5m      