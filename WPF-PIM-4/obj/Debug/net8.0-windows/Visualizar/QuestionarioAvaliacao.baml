   M S B A M L   `   `   `  ����D  @WPF-PIM-4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:WPF_PIM_4.VisualizarWPF_PIM_4.Visualizar  5      U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf 5      0    *WPF_PIM_4.Visualizar.QuestionarioAvaliacao   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:WPF_PIM_4.Visualizar     5      K
LiveCharts4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf     5        � 	Resources  5       �� 
TargetType   StarRadioButtonStyle �� Property �� Value �� 
TargetType ��Name �� CornerRadius �� Padding �� Orientation	 F�Name
 �� Triggers P� Property P� Value �� 
TargetName��%�  &	        �� 5   
   " 	�6   .�5      ��  � �� 5      �� 5      " 	�6&   .R�5      �� $ RadioBorder��6!   
�������$��1q�6I   $ 5��6]   $ 5q�6n   
������ ._�5      �� $ 
Horizontal=�6)   $��Center=�6B   .+�5   "   � $��20��6'   $��20��62   $��5q�6>   .+�5   &   F� $	 StarPath��6+   a�������     � � ��[ р���[ �@]� ��� ����  $� р��  � �@KL  $� ���j ��� р� ��[ � z ��[ 	
�������5   +   5   #   �� 5   "   $��Center=�63   $��5,0,30,0q�6N   5      5      
 5      P� 5        �@d�	IsChecked$
 TrueY�6;   . �5!   "   �� $ StarPath��6)    � ��
 � ���6O   �� 5"   "   $ RadioBorder��6)    � ��
 � ���6Y   5#      P� 5$       �@d�	IsChecked$ FalseY�6;   . �5%   "   �� $ StarPath��6)    � ��
 �����6O   �� 5&   "   $ RadioBorder��6)    � ��
 �����6Y   5'      5)      5+      5,      5-      .��5/      � ��50   
   �� 51       �� ImageSource$  /Imagens/HistoriaTemas.png��6    j� Stretch$
 Fill=�6B   .+�54   
   �� $��10,40,10,-46q�6   .+�55      �� $��22(�6   $��Segoe UI)�6&   $
��Bold"�6<   
���   �$��Center=�6a   $
��Wrap=�6~   $ ��Como foi sua experiência?��6�   $��0,10,0,5q�6�   � 57      -   5         �Name$ 
wrapPanel1��57      $��Center=�6,   $��0,0,0,15q�6I   .+�58      	� $	��5,0q�6   $
��Bold"�6+   $
��Ruim��6=   #��[  6L   	� 59      $	��5,0q�6   $
��Bold"�6+   $	��Boa��6=   #��[  6K   	� 5:      $	��5,0q�6   $
��Bold"�6+   $��	Muito Boa��6=   #��[  6Q   5;      �� 5=      $��22(�6   $��Segoe UI)�6&   $
��Bold"�6<   
���   �$��Center=�6a   $
��Wrap=�6~   $9��3Como você avaliaria a qualidade das informações?��6�   $��0,10,0,5q�6�   � 5?      -   5        $ 
wrapPanel2��5?      $��Center=�6,   $��0,0,0,15q�6I   .+�5@      	� $	��5,0q�6   $
��Bold"�6+   $
��Ruim��6>   #��[  6M   	� 5A      $	��5,0q�6   $
��Bold"�6+   $	��Boa��6=   #��[  6K   	� 5B      $	��5,0q�6   $
��Bold"�6+   $��	Muito Boa��6=   #��[  6Q   5C      �� 5E      $��22(�6   $��Segoe UI)�6&   $
��Bold"�6<   
���   �$��Center=�6a   $
��Wrap=�6~   $"��Como nos avaliaria no geral?��6�   $��0,10,0,5q�6�   � 5F      -   5        $ 
wrapPanel3��5F      $��Center=�6,   $��0,0,0,15q�6I   .+�5G      	� $	��5,0q�6   $
��Bold"�6+   $
��Ruim��6=   #��[  6L   	� 5H      $	��5,0q�6   $
��Bold"�6+   $	��Boa��6=   #��[  6K   	� 5I      $	��5,0q�6   $
��Bold"�6+   $��	Muito Boa��6=   #��[  6Q   5J      �� 5L      -   5        $��Salvar Respostas��5L      $
��Bold"�5M      $��Center=�5N        BotaoEstilo1#��[ 5O      $��0,20,0,0q�5P      $	��170��5Q      $��70��5R      5S      #  LiveCharts.Wpf.CartesianChart  5V      -   5          Name$ resultadoChart��5V   (   $
��Bold"�5W   (   $	��400��5X   (   $	��200��64   $y�	Collapsed=�5Y   (   $��0,20,0,0q�5Z   (   &   LiveCharts.Wpf.Charts.Base.Chart   AxisX 5\        LiveCharts.Wpf.Axis     Title$ Avaliação��6&      FontSize$ 12Q�5]   &      Labels9  3LiveCharts.Wpf.Converters.StringCollectionConverter$ Muito Boa,Boa,Ruim 5^   &      
Foreground
 �   �5_   &      AxisY 5b        $ Total de Respostas��6&   $ 12Q�5c   &   
 �   �5d   &   5f      5h      5i      5j      