   M S B A M L   `   `   `  ����W  SWebAPI_Car_Mechanic_Workshop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:WebAPI_Car_Mechanic_WorkshopWebAPI_Car_Mechanic_Workshop  5   	   -    'WebAPI_Car_Mechanic_Workshop.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:WebAPI_Car_Mechanic_Workshop     5   	     � Title$  Műhely��5   	   $	��450��6   $	��800��6%    � Icon$ /villaskulcs.jpg��61    � WindowStartupLocation$ CenterScreen=�5	   	   ���#1F2739 � 	Resources 5       �� 
TargetType �� Property �� Value&   System.Windows.Controls.DataGrid=  7System.Windows.Controls.Primitives.DataGridColumnHeader)  #System.Windows.Controls.DataGridRow �� Triggers P� Property	 P� Value:  4System.Windows.Controls.Primitives.DataGridRowHeader
 �� 	Resources �� 
TargetType��%]  '�       '�� N     '      '  ]    '  �    '  �    '�� B    �� 5   
   " �6   .�5      ��  � �� �#1F27396+   5      �� 5   
   " ��6   .�5      ��  � �� �#fff6+   �� 5       � ��$ 16(�6)   �� 5       � ��$
 Bold"�6+   �� 5       � ��$ 35, 15, 15, 0q�6'   5      �� 5   
   "  6   .�5      ��  � �� �#323C506+   �� 5       � �� �#fff6+   �� 5       � ��$ 15, 5, 15, 15q�6'   �� 5       � ��$ 5q�6(   �� 5        �@ HorizontalGridLinesBrush �#1F273969   �� 5       �@ VerticalGridLinesBrush �#1F273967   5      �� 5   
   "  6   .�5       ��  � �� �#2226+   �� 5!       � ��$
 5, 0q�6(   5"      �� 5#   
   "  6   .�5$      ��  � ��
 ���� 6+    5%      P� 5&       �@J�IsMouseOver$
	 True��61   . �5'      ��  � �� �#464A5263   5(      P� 5)       �@ 
IsSelected$
	 True��60   . �5*      ��  � �� �#1F273963   5+      5-      �� 5.   
   "  6   .�5/      ��  � �� �#323C506+   50      �� 51   
   " ��6   
 52      ���� 53      '��       " ��6   .�54      ��  �@��CornerRadius$ 10��65   55      56      .�57      ��  � �� 58      �� 59      " ��6&   .R�5:      �� #��z��6!   ._�5;      �� $��Center=�6/   $��Center=�6L   5<      5=      5?      �� 5@       � �� �#1116+   �� 5A       � �� �#fff6+   �� 5B       � ��$	 100��6&   �� 5C       � ��$ 30��6'   �� 5D       � ��$ Right=�64   �� 5E       � ��$ 15, 0, 15, 15q�6'    5F      P� 5G       �@J�IsMouseOver$
	 True��61   . �5H      ��  � �� �#323C5063   �� 5I       �@�Cursor$
 Hand��6/   5J      5L      5M      .��5O      �  � RowDefinitions 5P   
   �� 5Q      $
��Auto �6   �� 5R      $��* �6   �� 5S      $
��Auto �6   .+�5V   
   �� $��	/logo.png��6   $��0��6#   $��40��60   $
��Left=�6;   $��10, 0q�6V   �� 5W   
   $��0��6   $��Autószerelő Műhely��6     5Y   
   -   5        $��CustomerDataGrid��5Y         AutoGenerateColumns$ False��6C      SelectionMode$ Single=�6_   $��1��6v   $��15q�6�      CanUserAddRows$ false��6�   ��6+   ��    Columns 5Z      0  *System.Windows.Controls.DataGridTextColumn  5[      ,  &System.Windows.Controls.DataGridColumn   Header$ Ügyfél neve��6%      
IsReadOnly$
 True��6[      CanUserSort$ False��6m   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6:   �� *CustomerName+6m     5\      $ Autó Típusa��6%   $
 True��6W   $ False��6i    6;   �� *	CarType+6i     5]      $ 	Rendszám��6%   $
 True��6[   $ False��6m    68   �� *CarPlateNumber+6m     5^      $ Probléma leírása��6%      MinWidth$	 150Q�6?   $
 True��6u      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6�   $ False��6�    6N   �� *ProblemDescription+   ElementStyle 5_      �� 5`      " ��6    .�5a      ��  � ��$
 Wrap=�6G   5b      5d        5e      $ Dátum��6%      SortMemberPath$ DateAndTime��64   $
 True��6�   $
 True��6�    6Q   �� *DateAndTime+ �� StringFormat$ {0:yyyy.MM.dd.}��6�   5g      �� 5i   
   -   5        $��2��5i      $��Státusz frissítése��6   $	��100��6;   $��Right=�6G   $��15, 0, 15, 15q�6c   6z   5j      5k      