   M S B A M L   `   `   `  ����  CoffeShopManagement%    CoffeShopManagement.LoginWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � Title$  LoginWindow��5   	   $	��450��6   $	��800��6*    � WindowStartupLocation$ CenterScreen=�66    � 	Resources 5       �� 
TargetType �� Property �� Value3  -System.Windows.Media.Effects.DropShadowEffect   ShadowDepth   
BlurRadius   Color	 �� Triggers
 P� Property P� Value��%�  '��       '�� /    '��     'G� ]    �� 5
   
   " ��6   .�5      ��  � ��$ 16(�6)   �� 5       � ��$
 Bold"�6+   �� 5       � �� �#3333336+   �� 5       � ��$ 5q�6'   �� 5       � ��$
 Left=�64   �� 5       � ��$ Center=�62   �� 5       � ��$
 Wrap=�6-   5      �� 5   
   " ��6   .�5      ��  � ��$ 16(�6)   �� 5       � �� �#9B44446+   �� 5       � ��
 �����6+   �� 5       � ��$	 200��6&   �� 5       � ��$ 40��6'   5      �� 5   
   " ��6   .�5      ��  � ��$ 5q�6'   �� 5        � ��$ 14(�6)   �� 5!       � ��$ 5q�6(   �� 5"       � ��
 �����6,   �� 5#       � ��$ 1q�60   �� 5$       � ��
 �����6+   �� 5%       �@J�Effect 5&        5'      $ 0Q�6'   $ 5Q�67   $ 	LightGray��6F   5)      	 5*      P� 5+      
 �@J�	IsFocused$
 True��6/   . �5,      ��  � ��
 ����64   �� 5-       �@J�Effect 5.        5/      $ 0Q�6/   $ 8Q�6?   $ 
DodgerBlue��6N   51      52      54      �� 57   
   " G�6   .�58      ��  � ��$ 5q�6'   �� 59       � ��$ 14(�6)   �� 5:       � ��$ 5q�6(   �� 5;       � ��
 �����6,   �� 5<       � ��$ 1q�60   �� 5=       � ��
 �����6+   �� 5>       �@J�Effect 5?        5@      $ 0Q�6'   $ 5Q�67   $ 	LightGray��6F   5B      	 5C      P� 5D      
 �@J�	IsFocused$
 True��6/   . �5E      ��  � ��
 ����64   �� 5F       �@J�Effect 5G        5H      $ 0Q�6/   $ 8Q�6?   $ 
DodgerBlue��6N   5J      5K      5M      5N      .��5P      �  � ColumnDefinitions 5R   
   �� 5S      $	��300 �6   �� 5T      $��* �6   .+�5X   
   � $��0��6   ���#633232.+�5Y      �� $��Center=�6   $��Center=�64   .+�5Z      �� $��0,0,0,60q�6   .+�5[      �� $c��]D:\PRN211\prn212_Assignment\PRN212_Project\Project_PRN212\CoffeShopManagement\Images\logo.png��6   $	��100��6�   $	��100��6�   �� 5\      $��Coffee Management System��6    
�������$��20(�6S   $
��Bold"�6a    �� TextAlignment$ Center=�6s   $��0,0,0,20q�6�   5]      �� 5^      $��Register Your Account��6   
�������$ Center=�6L   $��0,0,0,20q�6c   �� 5_      -   5        $��SIGNUP��5_      6*   5`      5a      �� 5d   
   $��1��6   $��Center=�6%   $	��411��6B   $��0,65,0,0q�6N   .+�5e      �� $��
Login Form��6   $��24(�6*   $
��Bold"�68   $��0,0,0,20q�6J   �� 5g      $��0,0,0,10q�6   $��80��6+   $	��409��67   .+�5h      �� $��Username��6   �� 5i      -   5         ��Name$ txtEmail��5i      5j      �� 5l      $��0,0,0,10q�6   $	��120��6+   $	��409��68   .+�5m      �� $��Password��6   G� 5n      -   5         G�Name$ txtPassword��5n      63   �� 5o      -   5        $��PasswordVisible��5o      $y�	Collapsed=�61   �� 5p      -   5        $��Show password��5p      $��Right=�63   $��0,5,0,0q�6O   5r      5s      �� 5u      -   5        $��LOGIN��5u      $
��Left=�6%   6@   5v      5w      5x      