   M S B A M L   `   `   `  ����Q  M301065374(Sloan)_Lab01, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:_301065374_Sloan__Lab01_301065374_Sloan__Lab01  5   	   %    _301065374_Sloan__Lab01.Window1   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:_301065374_Sloan__Lab01     5   	     � Title$  Window1��5   	   $	��450��6   $	��800��6&   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgvBucketList��5
      $
��Left=�6*   $	��249��6E   $��
10,120,0,0q�6R   $	��Top=�6f   $	��772��6~      AutoGenerateColumns .  ��6�   �� *
Class1.obj+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Bucet Name��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   �� *
BucketName+  5      $ Creation Date��6%    6<   �� *CreationDate+5      �� 5   
   -   5         ��Name$ 	txtCreate��5      $��Create Bucket��6$   $
��Left=�6<   $��
601,22,0,0q�6W   $	��Top=�6k   $	��169��6�   $��78��6�   $��18(�6�   ���	#FF1C9CF5���	#FFFFDE0E
�������$
��Bold"�6�   6�   �� 5   
   -   5         ��Name$ txtBucketName��5      $
��Left=�6)   $��31��6D   $��
236,44,0,0q�6P    �� TextWrapping$
 Wrap=�6d   $	��Top=�6x   $	��360��6�   $��16(�6�   �� 5   
   $��Bucket Name:��6   $
��Left=�6'   $��
117,40,0,0q�6B   $	��Top=�6V   $��31��6n   $	��114��6z   $��16(�6�   $
��Bold"�6�   �� 5   
   -   5        $ txtMainMenu��5      $��Back to Main Menu��6&   $
��Left=�6B   $��
10,374,0,0q�6]   $	��Top=�6q   $	��586��6�   $��35��6�   $��18(�6�   ���	#FF1C9CF5���	#FFFFDE0E
�������$
��Bold"�6�   6  �� 5   
   -   5        $ 	txtReload��5      $��Reload��6$   $
��Left=�65   $��601,374,0,0q�6P   $	��Top=�6e   $	��181��6}   $��35��6�   $��18(�6�   ���	#FF1C9CF5���	#FFFFDE0E
�������$
��Bold"�6�   6�   5      5      