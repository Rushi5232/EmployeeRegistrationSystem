   M S B A M L   `   `   `  ����U  QEmployeeRegistrationSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:EmployeeRegistrationSystem.Views EmployeeRegistrationSystem.Views  5   	   2    ,EmployeeRegistrationSystem.Views.LoginWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @local.clr-namespace:EmployeeRegistrationSystem.Views     5   	     � Title$  Login Window��5   	   $	��300��6   $	��400��6+    � 
ResizeMode$ NoResize=�5	   	   .��5
      � .+�5   
   � ���#1f1f1f � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    .+�5      �� $��10q�6   .+�5      �� $"��Employee Registration System��6   $��Center=�6?   $��10q�6\   �� 5      $��User Authentication��6   $��Center=�66   5      �� 5      $��1��6    �� Orientation$ 
Horizontal=�6&   $��50,10q�6?   .+�5      �� $��	Username:��6   $
��10,0q�6,   �� 5      $	��200��6Y   ��6   �� *
Username+ �� UpdateSourceTrigger$ PropertyChanged=�6Y   5      �� 5      $��2��6   $ 
Horizontal=�6&   $��50,10q�6?   .+�5      �� $��	Password:��6   $
��10,0q�6,   �� 5       $	��200��6Y   ��6   �� *
Password+$ PropertyChanged=�6Y   5!      �� 5#      $��Login��5$      $��3��5%      $��2��5&      $��Center=�5'      $	��100��5(      $��10q�5)         ButtonTheme#��[  5+      ��5*      �� *LoginCommand+5+      �� 5-      $.��(Incorrect credentials. Please try again.��5.      $��4��5/      $��2��50      $��Center=�51      
���  ��y�52   "   �� * IncorrectCredentialsVisibility+53      54      55      