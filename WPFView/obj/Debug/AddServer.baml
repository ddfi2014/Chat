   M S B A M L   `   `   `  ����B  >WPFView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WPFViewWPFView  5   	       WPFView.AddServer   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WPFView     5   	     � Title$  
Add Server��5   	   $	��190��6   $	��300��6)   $	��190��65   $	��300��6E   .��5	      �  � RowDefinitions 5
   
   �� 5      .+�5   
   �� -   5         ��Name$ textBoxServerName��5      $��23��6-   $��114,10,10,0q�69    �� TextWrapping$
 Wrap=�6N   $��TextBox��6b   $	��Top=�6q   �� 5   
   -   5         ��Name$ labelServerName��5      $��Server Name:��6)   $
��Left=�6@   $��	10,10,0,0q�6[   $	��Top=�6n   $��80��6�   �� 5   
   -   5        $ labelServerIP��5      $��Server IP-Adress:��6'   $
��Left=�6C   $��	10,41,0,0q�6^   $	��Top=�6q   �� 5   
   -   5        $ textBoxServerIP��5      $��23��6+   $��114,41,10,0q�67   $
 Wrap=�6L   $��TextBox��6`   $	��Top=�6o   �� 5   
   -   5        $ labelServerPort��5      $��Server Port:��6)   $
��Left=�6@   $��	10,71,0,0q�6[   $	��Top=�6n   �� 5   
   -   5        $ textBox��5      $��23��6#   $��114,71,10,0q�6/   $
 Wrap=�6D   $��TextBox��6X   $	��Top=�6g   �� 5   
   -   5         ��Name$ buttonTestAndAdd��5      $��Test and Add Server��6+   $��
10,0,10,10q�6I   $��40��6]   $��Bottom=�6i   5      5      