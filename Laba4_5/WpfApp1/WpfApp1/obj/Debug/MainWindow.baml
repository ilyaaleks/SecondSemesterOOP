   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $��0.05* �6   �� 5      $��0.07* �6   6-   �� 5      $��* �6   �� 5      $��0.06* �6   6-   .+�5   
   �� -   5        $��numofsymbols��5      $��3��6(   67   o� 5   
   $��0��6   
�������.@�5      m� $
��File��6   .@�5      m� -   5        $	��New��5   )   $	��New��6   6H   m� 5      -   5        $
��Open��5   )   $
��Open��6   5      m� 5      -   5        $
��Save��5   )   $
��Save��6   6J   5      m� 5      $
��Edit��6   .@�5      m� -   5        $
��Copy��5   *   $
��Copy��6    m� Command$
 Copy��6I   6Z   m� 5      -   5        $��Paste��5   +   $��Paste��6   $ Paste��6L   6^   5      5       c� 5!   
   $��1��6   
�������.@�5#      d� -   5        $	��Fat��5#      $��
ToggleBold��6&   .��5$      �� $��Resources\bold.png��6   66   5%      d� 5&      -   5        $��Italic��5&      $��ToggleItalic��6)   .��5'      �� $��Resources\italic.jpg��6   68   5(      d� 5)      -	   5        $��	Underline��5)      $��ToggleUnderline��6,   .��5*      �� $��Resources\GtqjRl7JgUA.jpg��6   6=   5+      �� 5,      -
   5        $��Save2��5,      .��5-      �� $��Resources\KA9MtGUXeRg.jpg��6   6=   5.      �� 5/      -   5        $	��Cut��5/      $
��Copy��6    .��50      �� $��Resources\gBgLSD_BBP4.jpg��6   6=   51      �� 52      -   5        $
��Redo��52      $
��Redo��6!   .��53      �� $��Resources\lNUza1X5gkU.jpg��6   6=   54      �� 55      -   5        $
��Undo��55      $
��Undo��6!   .��56      �� $��Resources\zBmuHoFWMFA.jpg��6   6=   57      �� 58      -   5        $
��font��58      59      �� 5:      -   5        $
��Size��5:      5<      5=      �� 5>   
   -   5        $��	rtbEditor��5>   #   $��2��6    �� 	IsEnabled .  � Cursor$ IBeam��6P   6�   5?      5A      