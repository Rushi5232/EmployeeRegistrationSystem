   M S B A M L   `   `   `  ����U  QEmployeeRegistrationSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]3clr-namespace:EmployeeRegistrationSystem.ViewModels%EmployeeRegistrationSystem.ViewModels  5   	   1    +EmployeeRegistrationSystem.Views.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   J
ViewModels3clr-namespace:EmployeeRegistrationSystem.ViewModels     5   	     � Title$  
MainWindow��5   	   $	��520��6   $	��840��6)    � 	Resources 5	       �� 
TargetType �� Property �� Value��%�  '��       '�� �     '��      �� 5
   
   " ��6   .�5      ��  � ��$ 5q�6'   �� 5       � ��$	 150��6)   �� 5       � ��$ 25��6*   5      �� 5   
   " ��6   .�5      ��  � ��$ 5q�6'   �� 5       � ��$	 100��6)   �� 5       � ��$ 30��6*   5      �� 5   
   " ��6   .�5      ��  � ��$ 10q�6'   5      5       � DataContext 5      =   7EmployeeRegistrationSystem.ViewModels.EmployeeViewModel  5   
   .��5      � ���#1f1f1f � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5       $
��Auto �6   �� 5!      $
��Auto �6   �� 5"      $
��Auto �6   �� 5#      $	��150 �6   �� 5$      $
��Auto �6    � ColumnDefinitions 5'   
   �� 5(      $
��Auto �6   �� 5)      $��* �6   .+�5,   
   �� $��Employee Name:��6   $��Center=�6)   $��0��6D   $��0��6Q   $��10q�6a   �� 5-   
   $��0��6U   $��1��6b   $��10q�6r   
���������6   �� *EmployeeName+ �� UpdateSourceTrigger$ PropertyChanged=�6~   �� 5/   
   $��Contact Number:��6   $��Center=�6*   $��1��6E   $��0��6R   $��10q�6b   �� 50   
   $��1��6V   $��1��6c   $��10q�6s   
���������6   �� *ContactNumber+$ PropertyChanged=�6   �� 52   
   $��	Email ID:��6   $��Center=�6$   $��2��6?   $��0��6L   $��10q�6\   �� 53   
   $��2��6P   $��1��6]   $��10q�6m   
���������6   �� *	EmailID+$ PropertyChanged=�6y   �� 55   
   $��Address:��6   $��Center=�6#   $��3��6>   $��0��6K   $��10q�6[   �� 56   
   $��3��6P   $��1��6]   $��10q�6m   
���������6   �� *	Address+$ PropertyChanged=�6y   �� 58   
   $��
Education:��6   $��Center=�6%   $��4��6@   $��0��6M   $��10q�6]   �� 59   
   $��4��6_   $��1��6l   $��10q�6|   ��6   �� *EducationOptions+	 �� SelectedItem	 6<   �� *	Education+6|   �� 5;   
   $��Total Experience:��6   $��Center=�6,   $��5��6G   $��0��6T   $��10q�6d   �� 5<   
   $��5��6X   $��1��6e   $��10q�6u   
���������6   �� *TotalExperience+$ PropertyChanged=�6�   �� 5>   
   
������ 
�������$��6��5C      $��0��5D      $��2��5E      $
��Auto=�5F      $��Disabled=�5G      ��5@      �� *	Employees+	 5A      �� *SelectedEmployee+
 �� View
 5H      �� 5I      .P�5J      �� $��Employee Name��6%    �� Width$	 100��6j    �� DisplayMemberBinding 6<   �� *EmployeeName+6j   �� 5K      $��Contact Number��6%   $	 100��6l    6=   �� *ContactNumber+6l   �� 5L      $��Email ID��6%   $	 200��6`    67   �� *	EmailID+6`   �� 5M      $��Address��6%   $	 200��6_    66   �� *	Address+6_   �� 5N      $��	Education��6%   $	 100��6c    68   �� *	Education+6c   �� 5O      $��Total Experience��6%   $	 100��6p    6?   �� *TotalExperience+6p   5P      5S      �� 5U   
   $��7��5V      $��0��5W      $��2��5X       �� Orientation$ 
Horizontal=�5Y      $
��10,0q�5Z      $��Right=�5[      .+�5\      �� $��Register��5]       ^� ShowOnDisabled$
 true��5_      ��5^      �� *RegisterCommand+��5`      �� 5a      " ��6    �� BasedOn# [B��60    �� Triggers 5b      P� 5c       P� Property � {� P� Value$ False��6;   . �5d   "   ��  �@�ToolTip$0 *Please enter all fields to enable Register��6<   �� 5e   "    �@^�	IsEnabled$
 True��6M   5f      5h      5j      �� 5k      $��Modify��5l      ��5m      �� *ModifyCommand+�� 5n      $��Delete��5o      ��5p      �� *DeleteCommand+5q      5r      5s      