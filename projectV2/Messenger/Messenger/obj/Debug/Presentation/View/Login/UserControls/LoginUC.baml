   M S B A M L   `   `   `  ����D  @Messenger, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullo<clr-namespace:Messenger.Presentation.View.Login.UserControls.Messenger.Presentation.View.Login.UserControls  5      <    6Messenger.Presentation.View.Login.UserControls.LoginUC   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Nlocal<clr-namespace:Messenger.Presentation.View.Login.UserControls     5        � 	Resources  5	       �� 
TargetType �� Property �� Value   	help_text �� Triggers P� Property P� Value  
grad_brush��%�  '��       &	  �     '�� �    'G� �    �� 5
   
   " ��6   �5      �� 5       � ��$ Arial)�6/   �� 5       � ��$ 15(�6-   �� 5       � ��$
 0 10q�6+   �� 5       � ��
 �����6/   5      �� 5   
   " ��6   �5      �� 5       � �� �#3742fa6/   �� 5       � ��$ 	0 10 10 0q�6+    5      P� 5       �@J�IsMouseOver . . �5      ��  � �� �#2980b963   �� 5       �@�Cursor$
 Hand��6/   5      5       �� 5!   
   " ��6   �5"      �� 5#       � ��$ 30��6+   �� 5$       � ��$ 0 0 0 2q�64   �� 5%       � ��# �  60   �� 5&       � ��$ 15(�6-   5*      �� 5+   
   " G�6   .�5,      ��  � ��$ 30��6'   �� 5-       � ��$ 0 0 0 2q�60   �� 5.       � ��# �  6,   �� 5/       � ��$ 15(�6)   50      51      .��52      � .+�53   
   ��  �� Orientation$ Vertical=�6   $��Center=�6,   $��15q�6G   $	��450��6S   .+�54      �� $��	0 20 0 55q�6   $��
ExtraLight"�6+   
���   �$��Center=�6V   $��35(�6s   Login6�   �� 55      	Username:6#   �� 56      -   5         ��Name$ _login��56      ��6&   �� 	 �� Path$	 LoginModel.Username�6R   �� 57      	Password:6#   G� 58      -   5        
 G�Name$
 	_password��58      60   �� 59      $ 
Horizontal=�6   .+�5:      �� #��[  6    J� InputBindings 5;      d� 5<       d� MouseAction$ 	LeftClicke�6V    �� Command 6'   �� $	 ForgotPasswordCommand�6V   Forgot password?5?      5A      �� 5B        gradientButton#���  6   $��0 60 0 0q�5C       �� 	IsDefault . ��5D      �� $	 SignInCommand���5E      ��  �� ElementName$ 	_password��.��5F      �� $��0q�6   
�������$��15(�6:   $��Light"�6H   Enter6b   5G      5I      5J      5K      