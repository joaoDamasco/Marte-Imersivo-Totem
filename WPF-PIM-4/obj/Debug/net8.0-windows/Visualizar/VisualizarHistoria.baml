   M S B A M L   `   `   `  ����D  @WPF-PIM-4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:WPF_PIM_4.VisualizarWPF_PIM_4.Visualizar  5      -    'WPF_PIM_4.Visualizar.VisualizarHistoria   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:WPF_PIM_4.Visualizar     5      .��5
      � ��5   
   �� 5        �� ImageSource$   /Imagens/HistoriaTemas.png��6    j� Stretch$
 Fill=�6B   .+�5   
   �� -   5         ��Name$ titleTextBlock��5      $��Center=�6,   $��0,60,0,0q�6I   $��22(�5      $
��Bold"�6   
���   � �� TextAlignment$ Center=�6C   $��Título da História��5      �� 5   
   
���   �$��2q�6%    �� CornerRadius$ 5��69    �� Padding$ 5q�6J   $��Center=�6V   $	��Top=�6s   $��0,10,0,0q�6�   $��45��6�   ._�5      �� -   5        $ textBlockTelaAtual��5      $��Center=�64   $��0,4,0,0q�6Q   $
��Wrap=�6b   $	��1/3��6v   $	��Top=�6�   $��18(�6�   $
��Bold"�5      
���   �$ Center=�69   5      � 5   
   $��215,140,110,70q�6    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��* �6#   .+�5#      �� $��0��6   $	��Top=�6)   .+�5$      �� -   5         ��Name$ rtbHistoria��5$      
������  �� 
IsReadOnly$
 True��6L   
������ 	 � OverridesDefaultStyle$
	 True��6x   $|�False��6�   $��0q�6�   . �5%      /� 
 � 	Resources
 5&       �� 
TargetType �� Property �� Value��%�   'J�       �� 5'      " J�6$   .�5(   "   ��  � ��$ Segoe UI)�6?   �� 5)   "    � ��$ 25(�6=   �� 5*   "    � ��
 �   �6?   �� 5+   "    �@��TextAlignment$ Center=�6B   5,      5-      .T�5.      J� .*�6$   .*�5/      �� $� ��6"   50      51      52      53      �� 56      -   5         ��Name$ imgHistoria��56      $��1��6)   $	��300��69   $	��300��6E   $��Center=�6R   $��Center=�6o   $��10,0,0,0q�6�   57      �� 59   
    �� Orientation$ 
Horizontal=�6   $��Center=�6.   $��Bottom=�6K   $��	0,20,0,95q�6f   .+�5;      �� -   5         ��Name$ btnAnterior��5;      $��0q�6*   $��Anterior��6>   
�������$��17(�6d   $��
Montserrat)�6r    � Cursor$
 Hand��6�   ��5<      �� 5=      " ��6   .�5>      ��  � �� �#462AD867    �� Triggers 5?      P� 5@       P� Property �@J�IsMouseOver P� Value$
 True��6=   . �5A   "   ��  � �� �#28AEED6?   5B      5D      ��5F      �� 5G       �� 
TargetType" ��6&   .R�5H      �� $	��150��6!   $��55��6-   $��0,0,20,0q�69   $ 20��6K   #��z��6]   ._�5I      �� $��Center=�6/   $��Center=�6J   5J      5K      5M      �� 5P      -   5        $ 
btnProximo��5P      $��0q�6)   $��Próximo��6=   
�������$��17(�6b   $��
Montserrat)�6p   $
 Hand��6�   $��0,0,0,0q�6�   ��5Q      �� 5R      " ��6   .�5S      ��  � �� �#462AD867    5T      P� 5U       �@J�IsMouseOver$
 True��6=   . �5V   "   ��  � �� �#28AEED6?   5W      5Y      ��5[      �� 5\      " ��6&   .R�5]      �� $	��150��6!   $��55��6-   $��20,0,0,0q�69   $ 20��6K   #��z��6]   ._�5^      �� $��Center=�6/   $��Center=�6J   5_      5`      5b      5c      5d      5e      