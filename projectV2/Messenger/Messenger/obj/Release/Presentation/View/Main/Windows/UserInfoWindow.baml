   M S B A M L   `   `   `  ���� D  @Messenger, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullc6clr-namespace:Messenger.Presentation.View.Main.Windows(Messenger.Presentation.View.Main.Windows  =    7Messenger.Presentation.View.Main.Windows.UserInfoWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Hlocal6clr-namespace:Messenger.Presentation.View.Main.Windows       � WindowStartupLocation$  CenterScreen=� � Title$ UserInfoWindow��$	��400��$	��300��$	��400��$	��300��$	��400��$	��300�� � 	Resources  �� 
TargetType   
grad_block �� Property  
grad_brush �� Value  control_btn��%�   &	        &	 <     �� " ��.���  � ��# �  ��  � ��$ 0 0 0 2q��� " ��.���  � ��
 ��ح���  � ��$	 150����  � ��$ 1q�.��� 
�������.+���  �� Orientation$ Vertical=�$��Center=�$��Center=�.+��� -    ��Name$ _userImg��$	��160��$��0 5 0 10q�����  �� Path$ AccountModel.AccountImg��� -   	 ��Name$	 _adminInfoEmail��$ 
Horizontal=�$��Center=�.+��� $��email: ��$��3q�$��15(�$
��Bold"��� #��[  ._��� -   
 ��Name$
 
_userEmail��$��3q�$��15(����� $ AccountModel.AccountEmail��� $ 
Horizontal=�$��Center=�.+��� $��login: �� �� TextAlignment$ Center=�$��3q�$��15(�$
��Bold"��� #��[  ._��� -   $
 
_userLogin��$ Center=�$��3q�$��15(����� $ AccountModel.AccountLogin���   gradientButton#���  $��10q����� $ OpenOrCreateChatCommand�.���� 
�������Send Message