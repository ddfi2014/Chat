   M S B A M L   `   `   `  ����B  >WPFView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WPFViewWPFView  5   	       WPFView.AddChatRoom   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WPFView     5   	     � Title$  AddChatRoom��5   	   $	��190��6   $	��300��6*   $	��190��66   $	��300��6F   .��5	      � .+�5
   
   �� -   5         ��Name$ labelChatRoomName��5
      $��Name:��6+   $
��Left=�6;   $	��Top=�6V   $��	10,10,0,0q�6n   �� 5   
   -   5        $ labelChatRoomPassword��5      $��	Password:��6/   $
��Left=�6C   $	��Top=�6^   $��	10,41,0,0q�6v   �� 5   
   -   5         ��Name$ textBoxChatRoomName��5      $��23��6/    �� TextWrapping$
 Wrap=�6;   $��TextBox��6O   $	��Top=�6^   $��162,14,10,0q�6v   G� 5   
   -   5         G�Name$! passwordBoxChatRoomPassword��5      $��162,45,10,0q�6;   $	��Top=�6P   $��22��6h   G� 5   
   -   5        $( "passwordBoxChatRoomConfirmPassword��5      $��162,76,10,0q�6B   $	��Top=�6W   $��22��6o   �� 5   
   -   5        $" labelChatRoomConfirmPassword��5      $��Confirm Password:��66   $
��Left=�6R   $��	10,72,0,0q�6m   $	��Top=�6�   �� 5   
   -   5         ��Name$ buttonCreateChatRoom��5      $��Create Chat Room��6/   $��	10,0,10,7q�6J   $��40��6]   $��Bottom=�6i   5      5      