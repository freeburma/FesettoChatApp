   M S B A M L   `   `   `  ����G  CFasetto.Word, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Fasetto.WordFasetto.Word  5      L HFasetto.Word.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullP:clr-namespace:Fasetto.Word.Core;assembly=Fasetto.Word.CoreFasetto.Word.Core 5      &     Fasetto.Word.ChatListItemControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:Fasetto.Word     5      Kcore:clr-namespace:Fasetto.Word.Core;assembly=Fasetto.Word.Core     5      $��60��5	        � 	Resources  5         ContentStyle �� 
TargetType �� Property �� Value �� 
TargetType ��Name  ForegroundLightBrush �Name � ColumnDefinitions �� 	Converter/   )Fasetto.Word.BooleanToVisibilityConverter	 �� ConverterParameter
 �� Padding,   &Fasetto.Word.StringRGBToBrushConverter �� RelativeSource �� CornerRadius  FontSizeXLarge  LatoRegular  WordBlueBrush  ForegroundDarkBrush �� Triggers �� Value �� Binding �� 
TargetName  WordVeryVeryLightBlueBrush :� RoutedEvent  WordVeryVeryLightBlue	 �� To g� Duration �� 
TargetName �� TargetProperty P� Property P� Value��%�  &	        7  7  7  7  7  7  7  7  7  7  7  �� 5   
   " ��6%   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      �� $ 
background��6!   8��  ._�5      � $ 	container��6#   
������  5   "   �� 5   &   $
��Auto �67   �� 5   &   $��* �67   .+�5!   "   �� 
���  ��$��4��5"   )   $
��Left=�5#   )   y�5$   )   �� *NewContentAvailable+   $
	 True���� 5(   "   $��0��6)   $
 8q�69   ._�5*   &   �� ��6-   �� *ProfilePictureRGB+   ��5+   )   �� *ActualHeight+ �� *Self+ 5,   )   �� *ActualHeight+ �� *Self+._�5/   *   �� $��Center=�50   ,   $��Center=�51   ,   8�� 8�� 8�� ��5/   4   �� *
Initials+54   ,   56   '   57   #   �� 5:   "   $��1��6)   $
 0 0 15 0q�69   ._�5;   &   �� $��Center=�61   .+�5=   *   �� 8�� $��CharacterEllipsis=�5?   ,   8�� ��5=   4   �� *Name+5@   ,   �� 5C   *   8�� $��CharacterEllipsis=�5E   ,   8�� ��5C   4   �� *	Message+5F   ,   5H   '   5I   #   5J      5L       5N      �� 5Q      $
 True��6I    6*   �� *
IsSelected+.a�5R   "   �� $ 
background��6?   8   � ��6W   5S      :� 5U      $ 
MouseEnter��6+   .[�5W   "   �� .��5X   &   �� .��5Y   *   �� 8 	 $ 0:0:0.3D�6e   $ 	container��6x   $ Background.Color�6�   5Z   '   5[   #   5\      :� 5^      $ 
MouseLeave��6+   .[�5`   "   �� .��5a   &   �� .��5b   *   �� $ TransparentX�69   $ 0:0:0.3D�6J   $ 	container��6]   $ Background.Color�6   5c   '   5d   #   5e      P� 5m       � {� .  . �5n   "   �� $ 	container��6?   8 
  � ��6V   5o      5u      5w      5x      5y      .��5{      �� #��[  5|      5�      