   M S B A M L   `   `   `  ����U  QWebAPI_Car_Mechanic_Office, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:WebAPI_Car_Mechanic_OfficeWebAPI_Car_Mechanic_Office  5   	   /    )WebAPI_Car_Mechanic_Office.CustomerWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:WebAPI_Car_Mechanic_Office     5   	     � Title$  Munka adatai��5   	   $	��400��6   $	��400��6+    � 
ResizeMode$ NoResize=�67    � WindowStartupLocation$ CenterScreen=�6M    � 	Resources 5
       �� 
TargetType �� Property �� Value(  "System.Windows.Controls.DatePicker �� 	Resources:  4System.Windows.Controls.Primitives.DatePickerTextBox �� 
TargetType	 �� Triggers
 P� Property P� Value��%�  '�       '�� N     '��     '�� �    '      '�� �    �� 5   
   " �6   .�5      ��  � �� �#1F27396+   5      �� 5   
   " ��6   .�5      ��  � �� �#fff6+   �� 5       � ��$ 12(�6)   �� 5       � ��$
 Bold"�6+   �� 5       � ��$ 10q�6'   5      �� 5   
   " ��6   .�5      ��  � �� �#fff6+   �� 5       � �� �#323C506+   �� 5       � ��$ 12(�6)   �� 5       � ��$ 10q�6'   5      �� 5   
   " ��6   .�5      ��  � ��$ 10q�6'   5      �� 5   
   "  6   .�5      ��  � ��$ 10q�6'   �� 5       � �� �#fff6+   �� 5        � ��$ 14(�6)    5#      ���� 5$      '        "  6   .�5%      ��  � �� �#323C5063   �� 5&       � ��$ Center=�6:   5'      �� 5(      '��       " ��6   .�5)      ��  � ��$ 25��6.   �� 5*       � ��$ 25��6/   5+      5,      5-      �� 5/   
   " ��6    50      ���� 51      '��       " ��6   .�52      ��  �@��CornerRadius$ 10��65   53      54      .�55      ��  � �� 56      �� 57      " ��6&   .R�58      �� #��z��6!   ._�59      �� $��Center=�6/   $��Center=�6L   5:      5;      5=      �� 5>       � �� �#1116+   �� 5?       � �� �#fff6+   �� 5@       � ��$	 100��6&   �� 5A       � ��$ 30��6'   �� 5B       � ��$ Right=�64   �� 5C       � ��$ 15, 0, 15, 15q�6'   	 5D      P� 5E      
 �@J�IsMouseOver$
 True��61   . �5F      ��  � �� �#323C5063   �� 5G       �@�Cursor$
 Hand��6/   5H      5J      5K      .��5M      �  � RowDefinitions 5N   
   �� 5O      $
��auto �6   �� 5P      $��* �6   .+�5S   
   � $��0��6    � ColumnDefinitions 5T      �� 5U      $	��150 �6#   �� 5V      $��* �6#    5X      �� 5Y      $
��auto �6    �� 5Z      $
��auto �6    �� 5[      $
��auto �6    �� 5\      $
��auto �6    �� 5]      $
��auto �6    �� 5^      $
��auto �6    .+�5a      �� $��0��6   $��0��6$   $��Ügyfél neve��61   �� 5b      -   5         ��Name$ CustomerNameTextBox��5b      $��1��63   $��0��6C   �� 5d      $��0��6   $��1��6$   $��Autó Típusa��61   �� 5e      -   5        $ CarTypeTextBox��5e      $��1��6.   $��1��6>   �� 5g      $��0��6   $��2��6$   $��	Rendszám��61   �� 5h      -   5        $ CarPlateTextBox��5h      $��1��6/   $��2��6?   �� 5j      $��0��6   $��3��6$   $��Probléma leírása��61   $��50��6L   �� 5k      -   5        $ DescriptionTextBox��5k      $��1��62   $��50��6B   $��3��6Q    �� TextWrapping$
 Wrap=�6^    �� AcceptsReturn$
 True��6r   " �� VerticalScrollBarVisibility$ Visible=�6�   �� 5m      $��0��6   $��4��6$   $��Státusz��61   �� 5n      -   5         ��Name$ StatusComboBox��5n      $��1��6/   $��4��6?   �� 5p      $��0��6   $��5��6$   $��Dátum��61     5q      -   5          Name$ 
DatePicker��5q      $��1��6-   $��5��6=   5r      �� 5t   
   $��1��6    �� Orientation$ 
Horizontal=�6"   $��Bottom=�6;   $��Center=�6V   .+�5u      �� -   5         ��Name$ CreateButton��5u      $��	Felvétel��6+   6>   �� 5v      -   5        $ UpdateButton��5v      $��Frissítés��6+   6?   �� 5w      -	   5        $ DeleteButton��5w      $��Törlés��6+   6<   5x      5z      5{      