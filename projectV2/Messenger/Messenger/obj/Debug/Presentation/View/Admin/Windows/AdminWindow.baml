   M S B A M L   `   `   `  ����D  @Messenger, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle7clr-namespace:Messenger.Presentation.View.Admin.Windows)Messenger.Presentation.View.Admin.Windows  5   	   ;    5Messenger.Presentation.View.Admin.Windows.AdminWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Ilocal7clr-namespace:Messenger.Presentation.View.Admin.Windows     5   	     � Title$  AdminWindow��5   	   $	��450��6   $	��800��6*    � 	Resources 5	       �� 
TargetType   menu_btn �� Property �� Value��%�   &	        �� 5
   
   " ��6   .�5      ��  � ��
 �����6+   �� 5       � ��$ 15(�6)   �� 5       � ��$ 0q�60   �� 5       � ��$ 0 0 4 0q�6'   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��30 �6   �� 5      $��* �6   .+�5   
   � $��0��6   ���#2980b9.+�5      �� $��Center=�6   $��Center=�65   $��30(�6P   
�������
ADMIN PAGE6}   5      � 5   
   $��1��6   ���#3498db.+�5       ��  �� Orientation$ 
Horizontal=�6   $
��Left=�62   .+�5!      �� -   5         ��Name$ _searchPageBtn��5!      #��[  5"      $	��100��5#      ��5$      ��  �� Path$ GoToSearchCommand�.��6D   	Find user6O   �� 5%      -   5        $ _mesPageBtn��5%      #��[  5&      $	��240��5'      ��5(      �� $ GoToMessageCommand�.��6E   Send message to all users6`   �� 5)      #��[  6   $	��150��5*      ��5+      �� $ ExitCommand�.��6>   Back to login6M   5,      5-      � 5.   
   $��2��6   	 � ColumnDefinitions	 5/      �� 50      $	��73* �6#   �� 51      $
��325* �6#   .+�53       � $��2��54      $��0,0,0,0q�55      
  � NavigationUIVisibility$
 Hidden=�56      ��53      �� $ AdminContent�56      57      59      5:      