   M S B A M L   `   `   `  ����B  >WPFView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WPFViewWPFView  5   	       WPFView.Login   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WPFView     5   	     � Title$  Login��5   	   $	��195��6   $	��300��6$   $	��195��60   $	��300��6@   .��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      $	��64* �6   �� 5      $	��35* �6   .+�5   
   �� -   5         ��Name$ textBoxUserName��5      $��22��6+   $��22.42,11,10,0q�67    �� TextWrapping$
 Wrap=�6N   $	��Top=�6b   $��1��6z   �� 5   
   -   5         ��Name$ labelUserName��5      $��
User Name:��6'   $
��Left=�6<   $	��Top=�6W   $��10,7,0,0q�6o   $��26��6�   $	��115��6�   �� 5   
   -   5         ��Name$ buttonLogin��5      $��Sign in��6&   $��10,0,9.58,10q�68   $��1��6N   $��38��6[   $��Bottom=�6g   ��6�   �� *ButtonSignin+�� 5   
   -   5        $ labelPassword��5      $��	Password:��6'   $
��Left=�6;   $��	10,38,0,0q�6V   $	��Top=�6i   $��26��6�   $	��115��6�   G� 5   
   -   5         G�Name$ passwordBox��5      $��22.42,42,10,0q�6+   $	��Top=�6B   $��22��6Z   $��1��6f   �� 5   
   -   5        $ labelConfirmPassword��5      $��Confirm Password:��6.   $
��Left=�6J   $��	10,69,0,0q�6e   $	��Top=�6x   $��26��6�   $	��115��6�   G� 5   
   -   5        $ passwordBox1��5      $��22.42,73,10,0q�6,   $	��Top=�6C   $��22��6[   $��1��6g   �� 5   
   -   5        $ buttonSignUp��5      $��Sign Up��6'   $��10.42,0,10,10q�69   $��1��6P   $��38��6]   $��Bottom=�6i   $��1��6�   ��6�   �� *ButtonSignup+5      5      