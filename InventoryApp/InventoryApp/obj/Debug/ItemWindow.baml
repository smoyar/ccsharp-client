   M S B A M L   `   `   `  ����G  CInventoryApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:InventoryAppInventoryApp  5   	       InventoryApp.ItemWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:InventoryApp     5   	   -   5          � Title$  DUSA Inventory Manager��5   	   $	��500��6(   $	��380��64    +� FocusedElement 5	   	   ��  �� ElementName$ uxName��.��5      � -   5         �Name$ uxGrid��5      ��5   
   �� 5       �� ImageSource$K EC:\source\ccsharp-client\InventoryApp\InventoryApp\Images\Bertha3.jpg��6    �� Opacity$	 0.3Q�6m    � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5!   
   �� $��0��6   $��0��6$   $��Right=�61   $��10q�6M   Name:6`   �� 5"   
   -   5         ��Name$ uxName��5"      $��1��68   $��0��6H   $��10q�6U   ��6"   �� *Name+6c   �� 5$   
   $��0��6   $��1��6$   $��Right=�61   $��10q�6M   	System:6b   �� 5%   
   -   5        	 ��Name$	 uxSystem��5%      
 �� SelectedValuePath$
 Content��6=   $��10q�6Y   $��1��6e   $��1��6u    �� Text 6%   �� *System+.@�5&      �� .��6   	Hydraulic6&   �� 5'      .��6   
Electrical6'   �� 5(      .��6   	Pneumatic6&   �� 5)      .��6   Lubrication6(   �� 5*      .��6   Foam Injection6+   �� 5+      .��6   Bentonite Injection60   �� 5,      .��6   Conveyor Belt6*   �� 5-      .��6   High Pressure Water60   5.      �� 50   
   $��0��6   $��2��6$   $��Center=�61   $��10q�6L   	Quantity:6c   ]� 51   
   $��1��6   $��2��6$   $��Center=�61   $��10q�6L   .+�52      �� $��0��6G   $��2��6W   $��60��6d    �� TextAlignment$ Center=�6r    �� 
LineHeight$ 12��6�   $
��Bold"�6�   ��6   �� $ uxQty�� �� Path$ Value�6�   �� 53      -   5         ��Name$ uxQty��53       � Maximum$	 500Q�6:    � Minimum$ 1Q�6H    �� IsSnapToTickEnabled .  � Value 6$   �� *Qty+6q   54      �� 56   
   $��0��6   $��3��6$   $��Right=�61   $��10q�6M   Price:6a   �� 57   
   -   5        $ uxPrice��57      $��10q�6#   $��1��6�   $��3��6�   ��6/   �� *Price+ �� StringFormat$ {0:C}�� �� UpdateSourceTrigger$ PropertyChanged=� �� ValidatesOnDataErrors . 6�   �� 59   
   $��0��6   $��4��6$   $��Right=�61   $��10q�6M   	Contract:6d   �� 5:   
    �� Orientation$ 
Horizontal=�6   $��1��6.   $��4��6>   $��10q�6K   .+�5;      	� -   5         	�Name$ uxConsignment��5;       d� 	IsChecked$
 trueY�61   .��6B   Consignment6O   	� 5<      -   5        $ uxPurchased��5<      .��6/   	Purchased6:   5=      �� 5?   
   $��0��6   $��5��6$   $��Right=�61   $��10q�6M   Notes:6a   �� 5@   
   -	   5        $ uxNotes��5@      $��1��6@   $��10q�6P   $��5��6\    �� AcceptsReturn .  �� TextWrapping$
 Wrap=�6~   $��60��6�   ��6#   �� *Description+6�   �� 5B   
   -
   5         ��Name$ uxNameError��5B      $��10q�6%   $��1��61   $��6��6A   ��6N   �� *	NameError+$ PropertyChanged=��� 5D   
   $ 
Horizontal=�6   $��1��6.   $��8��6>   $��Right=�6K   $��10q�6g   .+�5E      �� -   5         ��Name$ uxSubmit��5E      $��10��6(   $��Center=�66   $��10q�6j   {�.  .��6�   Add6�   �� 5F      -   5        $ uxCancel��5F      $��10��6(   $��Center=�66   $��10q�6j   .��6v   Cancel6~   5G      5H      5I      