   M S B A M L   `   `   `  ����D  @MetroDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:MetroDemo	MetroDemo  5   	   U QMahApps.Metro, Version=1.5.0.23, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	       MetroDemo.MainWindow   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:MetroDemo     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   9System&clr-namespace:System;assembly=mscorlib     5   	     � Title$  
MainWindow��5
   	   $	��350��6   $	��525��6)   .��5      �  � RowDefinitions 5   
   �� 5      $��5* �6   �� 5      $	��15* �6    � ColumnDefinitions 5   
   �� 5      $
��0.5* �6   �� 5      .+�5   
   �� -   5        $
��Dark��5      $��75��6    $��25��6+   $
��Left=�6L   $	��Top=�6g   &   System.Windows.Controls.DataGrid  5   
   $��1��6   $��1��6#      AutoGenerateColumns .  ��5      ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 File��6&      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 64   �� *
FileName+6Q     5      $
 Size��6&    .  64   �� *
FileSize+6Q   ��5      �� 5         MetroDataGrid �� BasedOn# [  6   	 �� 
TargetType"	  6A   .�5      �� 
 �� Property 
 �@ AlternatingRowBackground  GrayBrush10 �� Value# �  6A   5       5"      �� 5#   
   $��1��6   $��0��6"   .+�5$      �� -   5        $
��read��5$      6$   5%      5&      5'      