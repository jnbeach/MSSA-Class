   M S B A M L   `   `   `  ����J  FProfileLoadouts, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ProfileLoadoutsProfileLoadouts  5   	        ProfileLoadouts.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:ProfileLoadouts     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��600��6)   $	��600��65   
�������$��5q�6Z   $��Palatino Linotype)�6n   $��16(�6�    � 	Resources 5	      -   'ProfileLoadouts.RadioBoolToIntConverter   RadioBoolToIntConverter �� 
TargetType  UserButtonClickStyle �� Property �� Value �� Triggers��%~   &	        &	        5   
   6(   �� 5   
   " 	�6   .�5      ��  � ��
 �  ��6=    5      5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��2* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5       $��1* �6   �� 5!      $��1* �6   �� 5"      $��1* �6    � ColumnDefinitions 5$   
   �� 5%      $	��41* �6   �� 5&      $
��119* �6   .+�5(   
   �� $��User Options��6   $��0��6'   $��2��67   $��Center=�6K   $��0,0,0,0q�6h   $��0��6y   $��Center=�6�   $��36(�6�   $
��Bold"�6�   	� 5)   
   -   5         	�Name$ User1Btn��5)      $��User 1��6(   $��Center=�69   $��0,0,0,0q�6V   $��1��6g   $��Center=�6t   $��25��6�   $	��100��6�   
	 � Tag$	 1��6�   #��[Bd�6�   
 d� 	IsChecked$

 TrueY�6�   $��2q�6  	� 5*   
   -   5        $ User2Btn��5*      $��User 2��6(   $��Center=�69   $��0,0,0,0q�6V   $��2��6g   $��Center=�6t   $��25��6�   $	��100��6�   $	 2��6�   #��[Bd�6�   $
 FalseY�6�   $��2q�6  	� 5+   
   -   5        $ User3Btn��5+      $��User 3��6(   $��Center=�69   $��0,0,0,0q�6V   $��3��6g   $��Center=�6t   $��25��6�   $	��100��6�   $	 3��6�   #��[Bd�6�   $
 FalseY�6�   $��2q�6  	� 5,   
   -   5        $ User4Btn��5,      $��User 4��6(   $��Center=�69   $��0,0,0,0q�6V   $��4��6g   $��Center=�6t   $��25��6�   $	��100��6�   $	 4��6�   #��[Bd�6�   $
 FalseY�6�   $��2q�6  �� 5.   
   -   5         ��Name$ BrightSlider��5.      $��1��6'   $��Center=�67   $��0,0,0,0q�6T   $��1��6e   $��Center=�6r   $	��200��6�    � Minimum$ 0Q�6�    � Maximum$	 100Q�6�    � Value 6�   �� *
Brightness+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� 5/   
   $��1��6   $��1��6!   $��Center=�61   $��	250,0,0,0q�6N   $��50��6a    �� TextAlignment$ Center=�6�   $��20��6�   ��6l   ��  �� ElementName$ BrightSlider�� �� Path$ Value�6�   	� 51   
   -   5        $ 	EasyRadio��51   -    	� 	GroupName$ 
Difficulty��6   $
��Easy��6@   $��1��6O   $��Center=�6_   $��
-150,0,0,0q�6|   $��2��6�   $��Center=�6�   
 6�   �� *
Difficulty+$ TwoWay=�$ PropertyChanged=� �� 	Converter# [   �� ConverterParameter$ 1��	� 52   
   -   5        $ NormalRadio��52   -   $ 
Difficulty��6   $��Normal��6B   $��1��6S   $��Center=�6c   $��0,0,0,0q�6�   $��2��6�   $��Center=�6�   
 6�   �� *
Difficulty+$ TwoWay=�$ PropertyChanged=�# [  $ 2��	� 53   
   -   5        $ 	HardRadio��53   -   $ 
Difficulty��6   $
��Hard��6@   $��1��6O   $��Center=�6_   $��	150,0,0,0q�6|   $��2��6�   $��Center=�6�   
 6�   �� *
Difficulty+$ TwoWay=�$ PropertyChanged=�# [  $ 3���� 54   
   -	   5         ��Name$ ResCombo��54      $��1��6%   $��Center=�65   $��0,0,0,0q�6R   $��3��6c   $��Center=�6p   $	��168��6�    �� SelectedIndex 6�   �� *
Resolution+$ TwoWay=�$ PropertyChanged=�.@�55      �� .��6   	640 x 4806&   �� 56      .��6   
1280 x 7206'   �� 57      .��6   1920 x 10806(   �� 58      .��6   2560 x 10806(   �� 59      .��6   3840 x 21606(   5:      �� 5;   
   -
   5         ��Name$ PermadeathCheck��5;      $��
PERMADEATH��6,   $��1��6A   $��Center=�6Q   $��	-40,0,0,0q�6n   $��4��6�   $��Center=�6�   
 6�   �� *IsPermadeath+$ TwoWay=�$ PropertyChanged=��� 5<   
   -   5        $ 	HintCheck��5<      $��Hints Enabled��6&   $��1��6>   $��Center=�6N   $��	250,0,0,0q�6k   $��4��6~   $��Center=�6�   
 6�   �� *AreHintsEnabled+$ TwoWay=�$ PropertyChanged=��� 5=   
   $��
Brightness��6   $��1��6%   $��Center=�65   $��
-340,0,0,0q�6R   $��1��6f   $��Center=�6s   �� 5>   
   $��
Difficulty��6   $��1��6%   $��Center=�65   $��
-347,0,0,0q�6R   $��2��6f   $��Center=�6s   �� 5?   
   $��
Resolution��6   $��1��6%   $��Center=�65   $��
-340,0,0,0q�6R   $��3��6f   $��Center=�6s   �� 5@   
   $��Extra Options��6   $��1��6(   $��Center=�68   $��
-318,0,0,0q�6U   $��4��6i   $��Center=�6v   �� 5A   
   $
��Left=�6   $	��196��6+   $��	50,10,0,0q�68   $��5��6K   $	��Top=�6X   $	��379��6p   $��/DarkSoulsBackground.jpg��6|   $��1��6�   $��7��6�   �� 5B   
   -   5         ��Name$ Praise��5B      $
��Left=�6    $	��163��6;   $��6��6H   $	��Top=�6U   $	��151��6m   $��/PraiseTheSun.jpg��6y   $��2��6�   $��26,4,0,0q�6�   $��6��6�   $y�Hidden=�6�   5N      5O      