   M S B A M L   `   `   `  ����U  QWebAPI_Car_Mechanic_Office, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:WebAPI_Car_Mechanic_OfficeWebAPI_Car_Mechanic_Office  5   	   +    %WebAPI_Car_Mechanic_Office.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:WebAPI_Car_Mechanic_Office     5   	     � Title$  Office��5   	   $	��450��6   $	��800��6%    � WindowStartupLocation$ CenterScreen=�61    � 	Resources 5
       �� 
TargetType �� Property �� Value&   System.Windows.Controls.DataGrid=  7System.Windows.Controls.Primitives.DataGridColumnHeader)  #System.Windows.Controls.DataGridRow �� Triggers P� Property P� Value:  4System.Windows.Controls.Primitives.DataGridRowHeader	 �� 	Resources
 �� 
TargetType��%]  '�       '�� N     '      '  ]    '  �    '  �    '�� B    �� 5   
   " �6   .�5      ��  � �� �#1F27396+   5      �� 5   
   " ��6   .�5      ��  � �� �#fff6+   �� 5       � ��$ 16(�6)   �� 5       � ��$
 Bold"�6+   �� 5       � ��$ 35, 15, 15, 0q�6'   5      �� 5   
   "  6   .�5      ��  � �� �#323C506+   �� 5       � �� �#fff6+   �� 5       � ��$ 15, 5, 15, 15q�6'   �� 5       � ��$ 5q�6(   �� 5        �@ HorizontalGridLinesBrush �#1F273969   �� 5       �@ VerticalGridLinesBrush �#1F273967   5      �� 5   
   "  6   .�5      ��  � �� �#2226+   �� 5       � ��$
 5, 0q�6(   5      �� 5    
   "  6   .�5!      ��  � ��
 ���� 6+    5"      P� 5#       �@J�IsMouseOver$
 True��61   . �5$      ��  � �� �#464A5263   5%      P� 5&       �@ 
IsSelected$
 True��60   . �5'      ��  � �� �#1F273963   5(      5*      �� 5+   
   "  6   .�5,      ��  � �� �#323C506+   5-      �� 5.   
   " ��6   	 5/      ���� 50      '��       " ��6   .�51      ��  �@��CornerRadius$ 10��65   52      53      .�54      ��  � �� 55      �� 56      "
 ��6&   .R�57      �� #��z��6!   ._�58      �� $��Center=�6/   $��Center=�6L   59      5:      5<      �� 5=       � �� �#1116+   �� 5>       � �� �#fff6+   �� 5?       � ��$	 100��6&   �� 5@       � ��$ 30��6'   �� 5A       � ��$ Right=�64   �� 5B       � ��$ 15, 0, 15, 15q�6'    5C      P� 5D       �@J�IsMouseOver$
 True��61   . �5E      ��  � �� �#323C5063   �� 5F       �@�Cursor$
 Hand��6/   5G      5I      5J      .��5L      �  � RowDefinitions 5M   
   �� 5N      $
��Auto �6   �� 5O      $��* �6   �� 5P      $
��Auto �6   .+�5S   
   �� $��	/logo.png��6   $��0��6#   $��40��60   $
��Left=�6;   $��10, 0q�6V   �� 5T   
   $��0��6   $��Autószerelő Iroda��6     5V   
   -   5        $��CustomerDataGrid��5V         AutoGenerateColumns$ False��6C      SelectionMode$ Single=�6_   $��1��6v      CanUserAddRows$ False��6�   $��Disabled=�6�   ��6+   ��    Columns 5W      0  *System.Windows.Controls.DataGridTextColumn  5X      ,  &System.Windows.Controls.DataGridColumn   Header$ Ügyfél neve��6%      
IsReadOnly$
 True��6[      CanUserSort$ False��6m   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6:   �� *CustomerName+6m     5Y      $ Autó Típusa��6%   $
 True��6W   $ False��6i    6;   �� *	CarType+6i     5Z      $ 	Rendszám��6%   $
 True��6[   $ False��6m    68   �� *CarPlateNumber+6m     5[      $ Probléma leírása��6%      MinWidth$	 120Q�6?      MaxWidth$	 475Q�6N   $
 True��6�      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6�   $ False��6�    6]   �� *ProblemDescription+   ElementStyle 5\      �� 5]      " ��6    .�5^      ��  � ��$
 Wrap=�6G   5_      5a        5b      $ Dátum��6%      SortMemberPath$ DateAndTime��64   $
 True��6�   $
 True��6�    6Q   �� *DateAndTime+ �� StringFormat$ {0:yyyy.MM.dd.}��6�   5d      �� 5f   
   -   5        $��2��5f      $��Munka felvétele��6   68   5h      5i      