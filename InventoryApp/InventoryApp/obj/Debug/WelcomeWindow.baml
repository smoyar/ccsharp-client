   M S B A M L   `   `   `  ����G  CInventoryApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:InventoryAppInventoryApp  5   	        InventoryApp.WelcomeWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:InventoryApp     5   	     � Title$%  DUSA Inventory Control Software��5   	   $	��350��61   $	��600��6>   .��5	      � ��5
   
   �� 5       �� ImageSource$K EC:\source\ccsharp-client\InventoryApp\InventoryApp\Images\Bertha3.jpg��6    �� Opacity$	 0.3Q�6m    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��0��6   $
��Bold"�6!   $��Italic$�63   $
��Left=�6F   #!Welcome to DUSA Inventory Control6�   �� 5   
   $��1��6   .+�5      �� $��1��6   $��Center=�6%   $
��Bold"�6B   User:6[   �� 5      -   5         ��Name$ uxUser��5      $��1��6&   $	��300��63   ���	#FFDFE1FF$��Center=�6V    � ForceCursor . 6�   �� 5      $��1��6   $��Center=�6%   $
��Bold"�6B   $��0,15,0,0q�6T   	Password:6q   G� 5      -   5         G�Name$ 
uxPassword��5      $	��300��6.   $��1��6:   ���	#FFDFE1FF$��0,0,0,10q�6^   $��Center=�6p   6�   5      ]� 5   
   $��2��6   $��0q�6!   $��Center=�6,   $��Center=�6I   .+�5      �� -   5         ��Name$ 
uxOKButton��5      $��20��6)   $��60��65   $��
10,50,20,0q�6@    .  � Cursor$
 Hand��6|   ���	#FFCACCFF.��6�   OK6�   �� 5      -   5        $ uxCancelButton��5      $��20��6-   $��60��69   $��
10,50,20,0q�6D   $
 Hand��6u   ���	#FFCACCFF.��6�   Exit6�   5      5       5!      