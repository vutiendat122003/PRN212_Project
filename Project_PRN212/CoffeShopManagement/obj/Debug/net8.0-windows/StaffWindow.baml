   M S B A M L   `   `   `  ����N  JCoffeShopManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:CoffeShopManagementCoffeShopManagement  5   	   %    CoffeShopManagement.StaffWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:CoffeShopManagement     5   	     � Title$  StaffWindow��5   	   $	��600��6   $
��1000��6*    � WindowStartupLocation$ CenterScreen=�67    � 	Resources 5	         MenuButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType �� Triggers P� Property	 P� Value
 �� 
TargetName��%�  &	        �� 5
   
   " ��6(   .�5      ��  � �� �#9B44446+   �� 5       � ��
 �����6+   �� 5       � ��$ 40��6'   �� 5       � ��$ 5q�6'   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� #��z��6!   #��z��6K   #��z��6w   ._�5      � .+�5   "   A� $	��Dot��6*   
�������$��5��6B   $��5��6L   $
��Left=�6W   $��Center=�6r   $��5,0,0,0q�6�   $y�	Collapsed=�6�   �� 5   "   $��Center=�63   $��Center=�6P   $��10,0,0,0q�6k   5      5       5      P� 5       �@J�	IsFocused$
	 True��6;   . �5   "   �� $	
 Dot��6)    � y�$ Visible=�6P   �� 5   "    � ��$
 Bold"�6?   5      5      5       5!      5"      .��5#      � ���#E3E3E3.+�5$   
   �� ���#5C1D1D$
��Left=�6&   $	��200��6A   ._�5%      �� $	��Top=�6   $��Center=�61   $
��0,20q�6N   .+�5&      �� $��50��6   $��50��6$   $��0,0,0,20q�6/   �� 5'      $��Welcome, Coffee��6   
�������$��16(�6F   $
��Bold"�6T    �� TextAlignment$ Center=�6f   $��0,0,0,20q�6}   �� 5,      .+�5-      �� -   5        $��Orders��5-      #��[  6.   6W   �� 5.      -   5        $��Daily Bills��5.      #��[  63   6\   5/      �� 51      -   5        $��Log Out��51      #��[  6+   6T   52      53      � 56   
   $��220,20,20,20q�6   .+�58       � -   5          �Name$ frMain��58        � NavigationUIVisibility$ Visible=�6$   59      5:      5;      