   M S B A M L   `   `   `  ����E  AContactApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:ContactApp
ContactApp  5   	       ContactApp.ContactWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:ContactApp     5   	     � Title$  ContactWindow��5   	   $	��300��6   $	��240��6+    +� FocusedElement 5	   	   ��  �� ElementName$ uxName��.��5      � -   5         �Name$ uxGrid��5       � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��0��6   $��0��6$   $��Right=�61   Name:6T   �� 5   
   -   5         ��Name$ uxName��5      $��1��6"   $��0��62   6A   �� 5   
   $��0��6   $��1��6$   $��Right=�61   Email:6U   �� 5   
   -   5        $ uxEmail��5      $��1��6#   $��1��63   6B   �� 5    
   $��0��6   $��2��6$   $��Right=�61   Phone Number:6\   �� 5!   
   -   5        $ uxPhoneNumber��5!      $��1��6)   $��2��69   6H   �� 5#   
   $��0��6   $��3��6$   $��Right=�61   Phone Type:6Z   �� 5$   
    �� Orientation$ 
Horizontal=�6   $��1��6.   $��3��6>   .+�5%      	� -   5         	�Name$ uxHome��5%      	 d� 	IsChecked$
	 trueY�6*   .��6;   Home6A   	� 5&      -   5        $ uxMobile��5&      .��6,   Mobile64   5'      �� 5(   
   $��0��6   $��4��6$   $��Right=�61   : Age6T   �� 5)   
   $ 
Horizontal=�6   $��1��6.   $��4��6>   .+�5*   
   �� $��40��6C   ��6   �� $ uxAge��
 �� Path$
 Value�6P   �� 5+   
   -   5         ��Name$ uxAge��5+       � Maximum$	 100Q�6    $	��100��6.    �� IsSnapToTickEnabled . 6W   5,      �� 5.   
   $��0��6   $��5��6$   $��Right=�61   Notes:6U   �� 5/   
   -   5        $ uxNotes��5/      $��1��6#   $��5��63    �� AcceptsReturn .  �� TextWrapping$
 Wrap=�6U   $��60��6i   6w   �� 51   
   $ 
Horizontal=�6   $��1��6.   $��6��6>   $��Right=�6K   .+�52      �� -	   5         ��Name$ uxSubmit��52      $��10��6(   $��Center=�66   $��10q�6j   .��6v   Add6{   �� 53      -
   5        $ uxCancel��53      $��10��6(   $��Center=�66   $��10q�6j   .��6v   Cancel6~   54      55      56      