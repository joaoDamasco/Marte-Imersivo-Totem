   M S B A M L   `   `   `  ����D  @WPF-PIM-4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:WPF_PIM_4	WPF_PIM_4  5   	       WPF_PIM_4.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   X TFontAwesome.Sharp, Version=6.6.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5   	   #localclr-namespace:WPF_PIM_4  5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)    � WindowStartupLocation$ CenterScreen=�5
   	    � WindowState$ 	Maximized=�5   	    � WindowStyle$
 None=�5   	   
������  � AllowsTransparency$
 True��5   	   .��5      ��  �� CornerRadius$ 10��6   $��1q�5      ��5   
   �� 5       �� 
StartPoint$	 0,0&�6"    �� EndPoint$	 1,1&�63   .��5      �    winBorderColor1 � Color# [  6   	 � Offset$	 0Q�6H   � 5        winBorderColor2# [ 6   $
	 0.75Q�6H   � 5        winBorderColor3# [ 6   $	 1Q�6H   5      ._�5   
   � 
 � ColumnDefinitions
 5      �� 5      $	��229 �6#   �� 5       .+�5$      �� $ 	10,0,0,10��6   $��0��5%       J� RenderTransformOrigin$ 0.5,0.5&�6%   $��0,0,51,0q�6E   z�5&      V� 5'      .~�5(      �� �� 5)      �� 5*       �� Angle$ 0Q�6*   T� 5+      5,      ��5/      �� 50      $	 0,0&�6*   $ 1,0.7&�6;   .��51      �   secondaryBackColor1# [ 6'   $	 0Q�6T   � 52        secondaryBackColor2# [ 6'   $	 2Q�6T   53      ._�56      �� .+�59      ��  �� Orientation$ 
Horizontal=�6!   $��35��5:   !   $��
15,25,0,40q�5;   !   .+�5=      �� $��Marte Imersivo��6$     titleColor2#��[ 5>   $   $��20(�5?   $   $��Segoe UI)�5@   $   $��Medium"�5A   $   $��Center=�5B   $   $��10,0,0,0q�5C   $   5E      	� 5H      -   5         	�Name$ RadioButtonInicial��5H   "     
menuButton#��[ 6>    
 color1
 � Tag# [ 5I   "   .��5K      �� $ 
Horizontal=�6%   .+�5L      !  FontAwesome.Sharp.IconImage  �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.6.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$ House=�6+     menuButtonIcon#��[ 68   �� 5M      $��INICIAL��6(    	 menuButtonText#��[	 67   5N      5O      	� 5R      -   5        $ RadioButtonMapa��5R   "   #��[ 6;   $��0,20,0,0q�5S   !    

 color3# [
 5T   "   .��5V      �� $ 
Horizontal=�6%   .+�5W        $	 Map=�6+   #��[ 66   �� 5X      $
��MAPA��6(   #��[	 64   5Y      5Z      	� 5]      -   5        $ RadioButtonHistoria��5]   "   #��[ 6?   $��0,20,0,0q�5^   !    
 color2# [ 5_   "   .��5a      �� $ 
Horizontal=�6%   .+�5b        $ BookOpen=�6+   #��[ 6;   �� 5c      $��	HISTÓRIA��6(   #��[	 68   5d      5e      	� 5h      -   5        $ RadioButtonAvaliacao��5h   "   #��[ 6@   $��0,20,0,0q�5i   !    
 color6# [ 5j   "   .��5l      �� $ 
Horizontal=�6%   .+�5m        $ Smile=�6+   #��[ 68   �� 5n      $��AVALIAÇÃO��6(   #��[	 69   5o      5p      	� 5s      -   5        $ 
ButaoEmail��5s   "   #��[ 66   $��0,20,0,0q�5t   "    
 color8# [ 5u   "   .��5w      �� $ 
Horizontal=�6%   .+�5x        $ Envelope=�6+   #��[ 6;   �� 5y      $��E-mail��6(   #��[	 66   5z      5{      	� 5}      -   5        $ 
BotaoAdmin��5}   "   #��[ 66   $��	0,220,0,0q�6Z    
 color4# [ 5~   "   .��5�      �� $ 
Horizontal=�6%   .+�5�        $ Wrench=�6+   #��[ 69   �� 5�      $��
Configurar��6(   #��[	 6:   5�      5�      5�      5�      �� 5�      $ 	0,10,10,0��6   $��2��6.   $��	178,0,0,0q�6B   ��5�      �� 5�      $	 1,1&�6*   $	 0,0&�6;   .��5�      �   primaryBackColor1# [ 6'   $	 0Q�6R   � 5�        primaryBackColor2# [ 6'   $	 2Q�6R   5�      ._�5�      �  � RowDefinitions 5�      �� 5�      $��19 �6(   �� 5�      $��0 �6(   �� 5�      .+�5�      �� -   5         ��Name$ pnlBarraControle��5�   !   $��0��5�   !   $ 
Horizontal=�5�   !   
������ $��0,0,5,9q�5�   !   5�      �� 5�      -   5         ��Name$ MainContentControl��5�   %   $�� ��6A   $��2��5�   %   $��31,10,25,25q�5�   %   5�      5�      5�      5�      5�      