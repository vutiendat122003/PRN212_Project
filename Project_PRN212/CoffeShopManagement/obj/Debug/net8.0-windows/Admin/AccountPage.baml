   M S B A M L   `   `   `  ����N  JCoffeShopManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:CoffeShopManagement.ConvertersCoffeShopManagement.Converters  5      +    %CoffeShopManagement.Admin.AccountPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      >local,clr-namespace:CoffeShopManagement.Converters     5        N� Title$  AccountPage��5	       N� 
Background
 ����� � 	Resources 5      5   /CoffeShopManagement.Converters.GeneralConverter   GenderConverter   ConverterType  RoleConverter  ActionButtonStyle �� 
TargetType �� Property �� Value  InputLabelStyle&   System.Windows.Controls.DataGrid=  7System.Windows.Controls.Primitives.DataGridColumnHeader3  -System.Windows.Media.Effects.DropShadowEffect   ShadowDepth   
BlurRadius	   Color
 �� Triggers P� Property P� Value��%�  &	        &	       &	 >     &	 �    '      '  5    '�� �    'G� @      5   
   $ Gender��69     5   
   $
 Role��67   �� 5   
   " ��6*   .�5      ��  � ��$ 5,0,0,0q�6'   �� 5       � ��$ 5q�6(   �� 5       � �� �#9B44446+   �� 5       � ��
 �����6+   �� 5       � ��$
 Bold"�6+   �� 5       � �� �#9B44446,   �� 5       � ��$	 100��6&   �� 5       � ��$ 30��6'   �� 5       �@�Cursor$
 Hand��6'   5      �� 5!   
   " ��6(   .�5"      ��  � ��$ 14(�6)   �� 5#       � ��$ Center=�62   �� 5$       � ��$
 Left=�64   �� 5%       � ��$	 120��6&   5&      �� 5)   
   "  6   .�5*      ��  � ��$ 14(�6)   �� 5+       �@ 	RowHeight$ 30Q�6*   �� 5,       �@ GridLinesVisibility$ 
Horizontal=�64   5-      �� 5.   
   "  6   .�5/      ��  � �� �#9B44446+   �� 50       � ��
 �����6+   �� 51       � ��$
 Bold"�6+   �� 52       � ��$ 10q�6(   53      �� 54   
   " ��6   .�55      ��  � ��$ 5q�6'   �� 56       � ��$ 14(�6)   �� 57       � ��$ 5q�6(   �� 58       � ��
 �����6,   �� 59       � ��$ 1q�60   �� 5:       � ��
 �����6+   �� 5;       �@J�Effect 5<        5=      $ 0Q�6'   $ 5Q�67   $	 	LightGray��6F   5?      
 5@      P� 5A       �@J�	IsFocused$
 True��6/   . �5B      ��  � ��
 ����64   �� 5C       �@J�Effect 5D        5E      $ 0Q�6/   $ 8Q�6?   $	 
DodgerBlue��6N   5G      5H      5J      �� 5M   
   " G�6   .�5N      ��  � ��$ 5q�6'   �� 5O       � ��$ 14(�6)   �� 5P       � ��$ 5q�6(   �� 5Q       � ��
 �����6,   �� 5R       � ��$ 1q�60   �� 5S       � ��
 �����6+   �� 5T       �@J�Effect 5U        5V      $ 0Q�6'   $ 5Q�67   $	 	LightGray��6F   5X      
 5Y      P� 5Z       �@J�	IsFocused$
 True��6/   . �5[      ��  � ��
 ����64   �� 5\       �@J�Effect 5]        5^      $ 0Q�6/   $ 8Q�6?   $	 
DodgerBlue��6N   5`      5a      5c      5d      .��5f      �  � RowDefinitions 5g   
   �� 5h      $
��Auto �6   �� 5i      $��* �6   .+�5m   
   ��  �� Orientation$ Vertical=�6   $��10q�6,   .+�5o      �� $ 
Horizontal=�6   $��5q�62   .+�5p      �� $��Account ID:��6   #��[ 6.   �� 5q      -   5         ��Name$ AccountIdTextBox��5q      $	��200��64   ${�False��6@   5r      �� 5u      $ 
Horizontal=�6   $��5q�62   .+�5v      �� $��Name:��6   #��[ 6(   �� 5w      -   5        $ NameTextBox��5w      $	��200��6/   5x      �� 5{      $ 
Horizontal=�6   $��5q�62   .+�5|      �� $��	Password:��6   #��[ 6,   G� 5}      -   5         G�Name$ PasswordBox��5}      $	��200��63   5~      �� 5�      $ 
Horizontal=�6   $��5q�62   .+�5�      �� $��Gender:��6   #��[ 6*   �� 5�      -   5         ��Name$ GenderComboBox��5�      $	��200��63   $��5q�6?    �� SelectedValuePath$ Content��6J   .@�5�      �� $
��Male��6#   �� 5�      $��Female��6#   5�      5�      �� 5�      $ 
Horizontal=�6   $��5q�62   .+�5�      �� $��Type:��6   #��[ 6(   �� 5�      -   5        $ TypeComboBox��5�      $	��200��61   $��5q�6=   $ Content��6H   .@�5�      �� $��Admin��6#   �� 5�      $��Staff��6#   5�      5�      �� 5�      $ 
Horizontal=�6   $��5q�62   .+�5�      �� -   5        $	��Add��5�      #��[ 6'   6R   �� 5�      -   5        $��Update��5�      #��[ 6*   6U   �� 5�      -   5        $��Delete��5�      #��[ 6*   6U   5�      5�        5�   
   -	   5          Name$ AccountsDataGrid��5�      $��1��6-      AutoGenerateColumns$ False��6:   $��10q�6V      
IsReadOnly$
 True��6b      Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Account ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6P   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   �� *Id+6P     5�      $
 Name��6%   $	 150 6L    63   �� *Name+6L     5�      $ Password��6%   $	 350 6T    67   �� *
Password+6T   4	  .System.Windows.Controls.DataGridTemplateColumn	  5�      $ Gender��6)   $	 100 69    	  CellTemplate 5�      �� 5�      .R�5�      �� ��6(   �� *Gender+ �� 	Converter# [  5�      5�      	  5�      $
 Type��6)   $	 100 67    5�      �� 5�      .R�5�      �� ��6(   �� *Type+# [ 5�      5�      5�      5�      5�      