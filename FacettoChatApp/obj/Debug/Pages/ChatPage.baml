   M S B A M L   `   `   `  ����G  CFasetto.Word, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Fasetto.WordFasetto.Word  5      L HFasetto.Word.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullP:clr-namespace:Fasetto.Word.Core;assembly=Fasetto.Word.CoreFasetto.Word.Core 5          Fasetto.Word.ChatPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:Fasetto.Word     5      Kcore:clr-namespace:Fasetto.Word.Core;assembly=Fasetto.Word.Core     5      -   5           Fasetto.Word.BasePage`1   Name$
  Page��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   � $��50��6    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $
��Auto �6#   .+�5#      �� $��Parnell��6   $��2��5$         ForegroundLightBrush#��[  5%        FontSizeXLarge#��[ 5&        LatoRegular#��[ 5'      $��Center=�5(      $��Center=�5)      �� 5-       �� Orientation$ 
Horizontal=�6   $��1��62   .+�5.      ��   IconGrowButton#��[ 6     FontAwesomeSearchIcon#��[ 6A   �� 5/      #��[ 6    # FontAwesomeEllipsisVerticalIcon#��[ 6A   50      51      )   #Fasetto.Word.ChatMessageListControl  54   
   $��1��6'       Fasetto.Word.BubbleContent  57   
   $��1��6   $��Bottom=�59      $
��Left=�5:       � DataContext 58      �� *AttachmentMenu+�   �Fasetto.Word.BaseAttachedProperty`2[[Fasetto.Word.AnimateSlideInFromBottomProperty, Fasetto.Word, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null],[System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]   Value 5;      �� *!ViewModel.AttachmentMenuVisible+ �� RelativeSource �� *FindAncestor+ �� AncestorType   Fasetto.Word.ChatPage"  � 5?   
   $��2��6   $��50��5@      $	��100��5A      #��[  5B       5D      �� 5F      $
��Auto �6#   �� 5I      $��* �6#   �� 5L      $
��Auto �6#   .+�5P      �� #��[ 6     FontAwesomePaperClipIcon#��[ 5R      $	��Top=�5S        ForegroundDarkBrush#��[ 5U      ��5Q      �� *	MinHeight+ �� $
 GridL���5T      �� *AttachmentButtonCommand+5U      �� 5Y      $��1��6   
 � Tag$ Write a message��5Z        FontSizeRegular#��[ 5[      $��Center=�5\      $��0q�5]      $��
0 10 10 10q�5^      	 �� AcceptsReturn	 . 
 �� 
AcceptsTab
 . " �� VerticalScrollBarVisibility$
 Auto=�5a      �� 5e      $��2��6   $ 
Horizontal=�5f      $��0 0 8 0q�5g      .+�5j      �� #��[ 6    	 FontAwesomeEmojiIcon#��[	 5l      $	��Top=�5m       
 WordOrangeBrush#��[
 5n      ��5k      �� *	MinHeight+ �� $
 GridL�5n      �� 5r      $
��Send��6   $��8q�5s      $	��Top=�5t        WordGreenBrush#��[ 5u      #��[ 5v      5y      5z      5|      5}      