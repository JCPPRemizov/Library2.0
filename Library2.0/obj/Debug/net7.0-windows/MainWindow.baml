   M S B A M L   `   `   `  ����E  ALibrary2.0, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Library2._0Library2._0  5   	       Library2._0.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Library2._0     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� -   5        $��IDBox��5       �� TextWrapping$
 Wrap=�6   63   �� 5   
   -   5        $��NameBox��5      $��0��6"   $��1��62   $
 Wrap=�6?   �� 5   
   -   5        $��AgeBox��5      $��0��6    $��2��60   $
 Wrap=�6=   6Q   �� 5   
   -   5        $��SubmitButton��5      $��0��6%   $��3��65    
  w_Save#���   6B   6e   �� 5   
   -   5        $��
LoadButton��5       
 w_Load#���  6%   $��0��6H   $��4��6X   6e   �� 5   
   $��1��6   $��0��6$   $��Center=�61   $��Center=�6N     w_ID#���  6i   �� 5   
   $��1��6   $��1��6$   $��Center=�61   $��Center=�6N    
 w_Name#���  6i   �� 5   
   $��1��6   $��2��6$   $��Center=�61   $��Center=�6N    	 w_Age#���  6i   �� 5   
   -   5        $��ChangeThemeButton��5      $��1��6+   $��3��6;     w_Theme#���  6H   6l   �� 5   
   -   5        $��ChangeLanButton��5      $��1��6(   $��4��68     
w_Language#���  6E   6l   5       5!      