   M S B A M L   `   `   `  ����G  CFasetto.Word, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Fasetto.WordFasetto.Word  5      L HFasetto.Word.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullP:clr-namespace:Fasetto.Word.Core;assembly=Fasetto.Word.CoreFasetto.Word.Core 5      -    'Fasetto.Word.ChatMessageListItemControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:Fasetto.Word     5      Kcore:clr-namespace:Fasetto.Word.Core;assembly=Fasetto.Word.Core     5      .��5      ��   �� Padding$  5q�6   ._�5   
   � .+�5      �� $	��Top=�6   $
��Left=�5      $��0 7.5 0 7.5q�5      $��35��5      
��� � �   ForegroundLightBrush#��[  5      $��1q�5      y�5      �� *
SendByMe+ �� 	Converter /   )Fasetto.Word.BooleanToVisibilityConverter   �� CornerRadius 5      �� *ActualWidth+ �� RelativeSource �� *Self+��5      �� *ActualWidth+ �� *Self+._�5      �� $��Center=�5      $��Center=�5      #��[  5        LatoRegular#��[ 5       ��5      �� *
Initials+5       5"      � 5%      $��	25 0 25 0q�6   ��5&      �� *
SendByMe+ /   )Fasetto.Word.SentByMeToAlignmentConverter   � Triggers 5*      :� 5+       :� RoutedEvent$ 
MouseEnter��6#   .[�5,      �� .��5-      ��  �� 
TargetName$ ExtraDetails��6)    �� TargetProperty$ Opacity�6N   .��5.   "   W� 	 W� To$ 1X�62   	 g� Duration$	 
00:00:00.5D�5/   2   51      52      53      :� 56      $ 
MouseLeave��6#   .[�57      �� .��58      �� $ ExtraDetails��6)   $ Opacity�6N   .��59   "   W� $ 0X�62   $	 
00:00:00.5D�5:   2   5<      5=      5>      
 � RowDefinitions
 5A      �� 5B      $��* �6$   �� 5C      $
��Auto �6$   �� 5D      $
��Auto �6$   .+�5H      �� $ 10��6   $  15q�5I      ��5J      �� *
SendByMe+ 0   *Fasetto.Word.SentByMeToBackgroundConverter  ._�5M      �� $��Center=�6    $
��Wrap=�5N       #��[ 5O         WordDarkBlueBrush#��[ 5P       ��5Q       �� *	Message+5S      F� 5[      $��1��6   
���   � K� ZIndex$ 1��5]      $��0��5^      $��
15 -1 15 0q�5_      "����        р�� ��� � -1    	��5`      �� *
SendByMe+   ��5a      �� *
SendByMe+   5b      �� 5f      -   5        $��ExtraDetails��5f       J� Opacity$ 0Q�5g      $��2��5h       �� Orientation$ 
Horizontal=�5j      ��5i      �� *
SendByMe+    �� ConverterParameter$
 True��.+�5n      �� #��[  5o         FontSizeSmall#��[ 5p       #��[ 5q       $��0 0 15 0q�5r       ��5n       �� *MessageSentTime+ -   'Fasetto.Word.TimeToDisplayTimeConverter  5r       �� 5v      #��[ 5w       #��[ 5x       #��[ 5y       ��5v       �� *MessageReadTime+ *   $Fasetto.Word.TimeToReadTimeConverter  5y       5{      5}      5~      5      5�      