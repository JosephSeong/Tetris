   M S B A M L   `   `   `  ����A  =Tetris, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:TetrisTetris  5   	       Tetris.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Tetris     5   	   -   5          � Title$  T E T R I S��5   	   $	��600��6   $	��800��6*   $	��600��5	   	   $	��600��6   
�������$��Segoe UI Light)�5   	   $��28(�6%   .��5      � -   5        $��
LayoutRoot��5       � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��auto �6   �� 5      $��* �6   ��5   
   �� 5       �� ImageSource$ Assets/Background.png��6   .+�5   
   (� $��1��6   $��1��5      $��0,0,0,20q�5      .��5       �� -   5         ��Name$ 
GameCanvas��5       ���#101010$	��250��5"      $	��510��5#      $
}�True��5$      5%      5&      �� 5(   
   -   5         ��Name$ 	ScoreText��5(      $��0��5)      $��1��5*      $��Score : ��5+      $��0, 10q�5,       �� TextAlignment$ Center=�5-      �� 5/   
   -   5        $
��Back��5/      $��2��6   $��Right=�6-   $��60��6I   $��55��6U    � 	Resources 51       �� 
TargetType	 �� Property
 �� Value��%^   '��       �� 52      " ��6   .�53      �� 	 �@��CornerRadius$
 5��65   54      55      ��56      �� 57       �� 
TargetType" ��6"   .R�58      �� 
���   �$��10q�61   #��z��6F   ._�59      �� #��z��6+   #��z��6n   5:      5;      .��5=      �� $4��.C:\Users\USER\Desktop\C#\TetrisAssets/Back.png��6   $
��Fill=�6L   5>      �� 5@   
   $��1��6   $��0��5A      $��Center=�5B      $��Right=�5C      .+�5E      r�  r� Source$ \Sound\Tetris_game.mp3?�6   �� 5G      $
��Hold��6   $ Center=�5H      �� 5J      -   5         ��Name$ 	HoldImage��5J      $��20q�5K      $	��125��5L      5M      �� 5O   
   $��1��6   $��2��5P      $��Center=�5Q      $
��Left=�5R      .+�5S      �� $
��Next��6   $ Center=�5T      �� 5V      -   5        $ 	NextImage��5V      $��20q�5W      $	��125��5X      5Y      � 5[   
   -   5         �Name$ GameOverMenu��5[      ���	#cc000000$��2��5]      $��3��5^      $y�Hidden=�5_      .+�5`      �� $��Center=�6   $��Center=�5a      .+�5b      �� $��	Game Over��6   $��48(�5c      $ Center=�5d      �� 5f      -	   5        $ FinalScoreText��5f      $��Score : ��5g      $��36(�5h      $ Center=�5i      �� 5k      -
   5        $��
Play Again��5k      ���	#FF9DAECB$��0,20,0,0q�5m      $��5q�5n      5o      5p      5r      5s      5t      